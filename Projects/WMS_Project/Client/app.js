// ===== Application State =====
const state = {
    currentView: "projects",
    showDeleted: false,
    projects: [],
    components: [],
    categories: [],
    manufacturers: [],
    locations: [],
    selectedComponents: new Map(),
    editingId: null,
    editingType: null,
};

// ===== Initialize Application =====
document.addEventListener("DOMContentLoaded", () => {
    setupEventListeners();
    loadAllData();
});

// ===== Setup Event Listeners =====
function setupEventListeners() {
    // Navigation
    document.querySelectorAll(".nav-btn").forEach((btn) => {
        btn.addEventListener("click", (e) =>
            handleNavigation(e.target.dataset.view),
        );
    });

    // Filter toggle
    document
        .getElementById("showDeletedToggle")
        .addEventListener("change", (e) => {
            state.showDeleted = e.target.checked;
            renderCurrentView();
        });

    // Project Modal
    document
        .getElementById("createProjectBtn")
        .addEventListener("click", openProjectModal);
    document
        .getElementById("projectForm")
        .addEventListener("submit", saveProject);
    setupModalCloseButtons();

    // Component Modal
    document
        .getElementById("createComponentBtn")
        .addEventListener("click", openComponentModal);
    document
        .getElementById("componentForm")
        .addEventListener("submit", saveComponent);

    // Category Modal
    document
        .getElementById("createCategoryBtn")
        .addEventListener("click", openCategoryModal);
    document
        .getElementById("categoryForm")
        .addEventListener("submit", saveCategory);

    // Manufacturer Modal
    document
        .getElementById("createManufacturerBtn")
        .addEventListener("click", openManufacturerModal);
    document
        .getElementById("manufacturerForm")
        .addEventListener("submit", saveManufacturer);

    // Location Modal
    document
        .getElementById("createLocationBtn")
        .addEventListener("click", openLocationModal);
    document
        .getElementById("locationForm")
        .addEventListener("submit", saveLocation);

    // Component selector
    document
        .getElementById("addComponentBtn")
        .addEventListener("click", addComponentToSelection);
}

function setupModalCloseButtons() {
    const modals = document.querySelectorAll(".modal");
    modals.forEach((modal) => {
        const closeBtn = modal.querySelector(".modal-close");
        const cancelBtn = modal.querySelector('[id$="CancelBtn"]');

        if (closeBtn)
            closeBtn.addEventListener("click", () => closeModal(modal.id));
        if (cancelBtn)
            cancelBtn.addEventListener("click", () => closeModal(modal.id));
    });

    // Close modal when clicking outside
    modals.forEach((modal) => {
        modal.addEventListener("click", (e) => {
            if (e.target === modal) closeModal(modal.id);
        });
    });
}

// ===== Load Data =====
async function loadAllData() {
    try {
        const [projects, components, categories, manufacturers, locations] =
            await Promise.all([
                API.getAllProjects(),
                API.getAllComponents(),
                API.getAllCategories(),
                API.getAllManufacturers(),
                API.getAllLocations(),
            ]);

        state.projects = projects || [];
        state.components = components || [];
        state.categories = categories || [];
        state.manufacturers = manufacturers || [];
        state.locations = locations || [];

        renderCurrentView();
        populateSelects();
    } catch (error) {
        console.error("Error loading data:", error);
        showAlert("Error loading data. Please refresh the page.", "error");
    }
}

// ===== Navigation =====
function handleNavigation(viewName) {
    state.currentView = viewName;
    state.editingId = null;
    state.editingType = null;
    state.selectedComponents.clear();

    // Update active nav button
    document.querySelectorAll(".nav-btn").forEach((btn) => {
        btn.classList.remove("active");
        if (btn.dataset.view === viewName) btn.classList.add("active");
    });

    // Update active view
    document.querySelectorAll(".view").forEach((view) => {
        view.classList.remove("active");
    });
    document.getElementById(`${viewName}-view`).classList.add("active");

    renderCurrentView();
}

// ===== Render Views =====
function renderCurrentView() {
    switch (state.currentView) {
        case "projects":
            renderProjects();
            break;
        case "components":
            renderComponents();
            break;
        case "categories":
            renderCategories();
            break;
        case "manufacturers":
            renderManufacturers();
            break;
        case "locations":
            renderLocations();
            break;
    }
}

function renderProjects() {
    const container = document.getElementById("projectsList");
    const filteredProjects = filterByDeleted(state.projects, state.showDeleted);

    if (filteredProjects.length === 0) {
        container.innerHTML = getEmptyStateHTML("No projects found", "📋");
        return;
    }

    container.innerHTML = filteredProjects
        .map((project) => {
            const components = project.components || [];
            const deletedClass = project.isDeleted ? "deleted" : "";

            // Calculate total price: sum of (component price × quantity)
            const totalPrice = components.reduce((sum, pc) => {
                const price = pc.component?.price || 0;
                const quantity = pc.quantity || 1;
                return sum + price * quantity;
            }, 0);

            return `
                <div class="item-card ${deletedClass}">
                    <div class="item-header">
                        <div class="item-title">${escapeHtml(project.name)}</div>
                        <div class="item-description">${escapeHtml(project.description || "No description")}</div>
                    </div>
                    <div class="item-meta">
                        Created: ${formatDate(project.creationDate)}
                    </div>
                    <div class="item-meta">
                        Components: ${components.length}
                    </div>
                    <div class="item-meta">
                        Total Project Price: $${totalPrice.toFixed(2)}
                    </div>
                    ${
                        components.length > 0
                            ? `
                        <div class="components-list">
                            ${components
                                .map(
                                    (pc) => `
                                <div class="component-item">
                                    <span>${escapeHtml(pc.component?.name || "Unknown")} (Qty: ${pc.quantity})</span>
                                    <span style="color: var(--success-color); font-weight: bold;">
                                        $${((pc.component?.price || 0) * pc.quantity).toFixed(2)}
                                    </span>
                                </div>
                            `,
                                )
                                .join("")}
                        </div>
                    `
                            : ""
                    }
                    <div class="item-actions">
                        <button class="btn btn-edit" onclick="editProject(${project.id})">Edit</button>
                        <button class="btn btn-danger" onclick="deleteItem(${project.id}, 'projects')">Delete</button>
                    </div>
                </div>
            `;
        })
        .join("");
}

function renderComponents() {
    const container = document.getElementById("componentsList");
    const filteredComponents = filterByDeleted(
        state.components,
        state.showDeleted,
    );

    if (filteredComponents.length === 0) {
        container.innerHTML = getEmptyStateHTML("No components found", "⚙️");
        return;
    }

    container.innerHTML = filteredComponents
        .map((component) => {
            const deletedClass = component.isDeleted ? "deleted" : "";

            return `
                <div class="item-card ${deletedClass}">
                    <div class="item-header">
                        <div class="item-title">${escapeHtml(component.name)}</div>
                        <div class="item-description">${escapeHtml(component.description || "No description")}</div>
                    </div>
                    <div class="badge category">${escapeHtml(component.category?.name || "Unknown Category")}</div>
                    <div class="badge manufacturer">${escapeHtml(component.manufacturer?.name || "Unknown Manufacturer")}</div>
                    <div class="badge location">${escapeHtml(component.location?.name || "Unknown Location")}</div>
                    <div class="price">$${component.price.toFixed(2)}</div>
                    <div class="item-actions">
                        <button class="btn btn-edit" onclick="editComponent(${component.id})">Edit</button>
                        <button class="btn btn-danger" onclick="deleteItem(${component.id}, 'components')">Delete</button>
                    </div>
                </div>
            `;
        })
        .join("");
}

function renderCategories() {
    const container = document.getElementById("categoriesList");
    const filteredCategories = filterByDeleted(
        state.categories,
        state.showDeleted,
    );

    if (filteredCategories.length === 0) {
        container.innerHTML = getEmptyStateHTML("No categories found", "🏷️");
        return;
    }

    container.innerHTML = filteredCategories
        .map((category) => {
            const deletedClass = category.isDeleted ? "deleted" : "";

            return `
                <div class="item-card ${deletedClass}">
                    <div class="item-header">
                        <div class="item-title">${escapeHtml(category.name)}</div>
                        <div class="item-description">${escapeHtml(category.description || "No description")}</div>
                    </div>
                    <div class="item-actions">
                        <button class="btn btn-edit" onclick="editCategory(${category.id})">Edit</button>
                        <button class="btn btn-danger" onclick="deleteItem(${category.id}, 'categories')">Delete</button>
                    </div>
                </div>
            `;
        })
        .join("");
}

function renderManufacturers() {
    const container = document.getElementById("manufacturersList");
    const filteredManufacturers = filterByDeleted(
        state.manufacturers,
        state.showDeleted,
    );

    if (filteredManufacturers.length === 0) {
        container.innerHTML = getEmptyStateHTML("No manufacturers found", "🏭");
        return;
    }

    container.innerHTML = filteredManufacturers
        .map((manufacturer) => {
            const deletedClass = manufacturer.isDeleted ? "deleted" : "";

            return `
                <div class="item-card ${deletedClass}">
                    <div class="item-header">
                        <div class="item-title">${escapeHtml(manufacturer.name)}</div>
                        <div class="item-description">${escapeHtml(manufacturer.description || "No description")}</div>
                    </div>
                    <div class="item-actions">
                        <button class="btn btn-edit" onclick="editManufacturer(${manufacturer.id})">Edit</button>
                        <button class="btn btn-danger" onclick="deleteItem(${manufacturer.id}, 'manufacturers')">Delete</button>
                    </div>
                </div>
            `;
        })
        .join("");
}

function renderLocations() {
    const container = document.getElementById("locationsList");
    const filteredLocations = filterByDeleted(
        state.locations,
        state.showDeleted,
    );

    if (filteredLocations.length === 0) {
        container.innerHTML = getEmptyStateHTML("No locations found", "📍");
        return;
    }

    container.innerHTML = filteredLocations
        .map((location) => {
            const deletedClass = location.isDeleted ? "deleted" : "";

            return `
                <div class="item-card ${deletedClass}">
                    <div class="item-header">
                        <div class="item-title">${escapeHtml(location.name)}</div>
                        <div class="item-description">${escapeHtml(location.description || "No description")}</div>
                    </div>
                    <div class="item-actions">
                        <button class="btn btn-edit" onclick="editLocation(${location.id})">Edit</button>
                        <button class="btn btn-danger" onclick="deleteItem(${location.id}, 'locations')">Delete</button>
                    </div>
                </div>
            `;
        })
        .join("");
}

// ===== Filter Helpers =====
function filterByDeleted(items, showDeleted) {
    if (showDeleted) return items;
    return items.filter((item) => !item.isDeleted);
}

// ===== Project Modal Functions =====
async function openProjectModal() {
    state.editingId = null;
    state.editingType = "project";
    state.selectedComponents.clear();

    document.getElementById("projectModalTitle").textContent = "Create Project";
    document.getElementById("projectForm").reset();
    document.getElementById("selectedComponentsList").innerHTML = "";
    document.getElementById("quantityInput").value = "1";

    populateComponentSelect();
    openModal("projectModal");
}

async function editProject(id) {
    try {
        const project = await API.getProjectById(id);
        state.editingId = id;
        state.editingType = "project";
        state.selectedComponents.clear();

        document.getElementById("projectModalTitle").textContent =
            "Edit Project";
        document.getElementById("projectName").value = project.name;
        document.getElementById("projectDescription").value =
            project.description || "";

        // Load existing components
        if (project.components && project.components.length > 0) {
            project.components.forEach((pc) => {
                state.selectedComponents.set(pc.componentId, {
                    name: pc.component.name,
                    quantity: pc.quantity,
                });
            });
        }

        populateComponentSelect();
        renderSelectedComponents();
        openModal("projectModal");
    } catch (error) {
        console.error("Error loading project:", error);
        showAlert("Error loading project", "error");
    }
}

async function saveProject(e) {
    e.preventDefault();

    const name = document.getElementById("projectName").value;
    const description = document.getElementById("projectDescription").value;

    if (!name) {
        showAlert("Project name is required", "error");
        return;
    }

    try {
        const projectData = {
            name,
            description,
            creationDate: new Date().toISOString().split("T")[0],
        };

        let projectId;

        if (state.editingId) {
            await API.updateProject(state.editingId, projectData);
            projectId = state.editingId;
        } else {
            const createdProject = await API.createProject(projectData);
            projectId = createdProject.id;
        }

        // Remove deleted components
        const originalProject = state.projects.find((p) => p.id === projectId);
        if (originalProject && originalProject.components) {
            for (const pc of originalProject.components) {
                if (!state.selectedComponents.has(pc.componentId)) {
                    await API.deleteProjectComponent(projectId, pc.componentId);
                }
            }
        }

        // Add new components, update existing ones with changed quantities
        for (const [componentId, componentData] of state.selectedComponents) {
            const existingComponent = originalProject?.components?.find(
                (pc) => pc.componentId === componentId,
            );

            if (existingComponent) {
                // Component exists, check if quantity changed
                if (existingComponent.quantity !== componentData.quantity) {
                    await API.updateProjectComponent(projectId, componentId, {
                        projectId,
                        componentId,
                        quantity: componentData.quantity,
                    });
                }
            } else {
                // New component, create it
                await API.createProjectComponent({
                    projectId,
                    componentId,
                    quantity: componentData.quantity,
                });
            }
        }

        showAlert(
            state.editingId
                ? "Project updated successfully"
                : "Project created successfully",
            "success",
        );
        closeModal("projectModal");
        await loadAllData();
    } catch (error) {
        console.error("Error saving project:", error);
        showAlert("Error saving project", "error");
    }
}

function populateComponentSelect() {
    const select = document.getElementById("componentSelect");
    const activeComponents = filterByDeleted(state.components, false);

    select.innerHTML =
        '<option value="">Select a component to add</option>' +
        activeComponents
            .map(
                (component) => `
        <option value="${component.id}">${escapeHtml(component.name)}</option>
    `,
            )
            .join("");
}

function addComponentToSelection() {
    const select = document.getElementById("componentSelect");
    const quantityInput = document.getElementById("quantityInput");
    const componentId = parseInt(select.value);
    const quantity = parseInt(quantityInput.value) || 1;

    if (!componentId) {
        showAlert("Select a component", "error");
        return;
    }

    if (quantity < 1) {
        showAlert("Quantity must be at least 1", "error");
        return;
    }

    const component = state.components.find((c) => c.id === componentId);
    if (component && !state.selectedComponents.has(componentId)) {
        state.selectedComponents.set(componentId, {
            name: component.name,
            quantity: quantity,
        });
        renderSelectedComponents();
        select.value = "";
        quantityInput.value = "1";
    } else if (state.selectedComponents.has(componentId)) {
        showAlert("Component already added", "error");
    }
}

function renderSelectedComponents() {
    const container = document.getElementById("selectedComponentsList");

    if (state.selectedComponents.size === 0) {
        container.innerHTML =
            '<p style="color: var(--text-light); font-size: 0.9rem;">No components selected</p>';
        return;
    }

    container.innerHTML = Array.from(state.selectedComponents.entries())
        .map(
            ([id, data]) => `
            <div class="selected-component-item">
                <div style="flex: 1;">
                    <div style="margin-bottom: 5px;">${escapeHtml(data.name)}</div>
                    <div style="display: flex; gap: 8px; align-items: center;">
                        <label style="margin: 0; font-size: 0.85rem; color: var(--text-light);">Qty:</label>
                        <input type="number" 
                               min="1" 
                               value="${data.quantity}" 
                               onchange="updateComponentQuantity(${id}, this.value)"
                               style="width: 60px; padding: 4px; border: 1px solid var(--border-color); border-radius: 3px; font-size: 0.9rem;">
                    </div>
                </div>
                <button type="button" class="remove-component" onclick="removeComponentFromSelection(${id})">Remove</button>
            </div>
        `,
        )
        .join("");
}

function updateComponentQuantity(componentId, quantity) {
    const q = parseInt(quantity) || 1;
    if (q < 1) {
        showAlert("Quantity must be at least 1", "error");
        return;
    }
    const componentData = state.selectedComponents.get(componentId);
    if (componentData) {
        componentData.quantity = q;
    }
}

function removeComponentFromSelection(componentId) {
    state.selectedComponents.delete(componentId);
    renderSelectedComponents();
}

// ===== Component Modal Functions =====
async function openComponentModal() {
    state.editingId = null;
    state.editingType = "component";

    document.getElementById("componentModalTitle").textContent =
        "Create Component";
    document.getElementById("componentForm").reset();

    populateComponentSelects();
    openModal("componentModal");
}

async function editComponent(id) {
    try {
        const component = await API.getComponentById(id);
        state.editingId = id;
        state.editingType = "component";

        document.getElementById("componentModalTitle").textContent =
            "Edit Component";
        document.getElementById("componentName").value = component.name;
        document.getElementById("componentDescription").value =
            component.description || "";
        document.getElementById("componentPrice").value = component.price;
        document.getElementById("componentCategory").value =
            component.categoryId || "";
        document.getElementById("componentManufacturer").value =
            component.manufacturerId || "";
        document.getElementById("componentLocation").value =
            component.locationId || "";

        populateComponentSelects();
        openModal("componentModal");
    } catch (error) {
        console.error("Error loading component:", error);
        showAlert("Error loading component", "error");
    }
}

async function saveComponent(e) {
    e.preventDefault();

    const name = document.getElementById("componentName").value;
    const description = document.getElementById("componentDescription").value;
    const price = parseFloat(document.getElementById("componentPrice").value);
    const categoryId = parseInt(
        document.getElementById("componentCategory").value,
    );
    const manufacturerId = parseInt(
        document.getElementById("componentManufacturer").value,
    );
    const locationId = parseInt(
        document.getElementById("componentLocation").value,
    );

    if (!name || !price || !categoryId || !manufacturerId || !locationId) {
        showAlert("All fields are required", "error");
        return;
    }

    try {
        const componentData = {
            name,
            description,
            price,
            categoryId,
            manufacturerId,
            locationId,
        };

        if (state.editingId) {
            await API.updateComponent(state.editingId, componentData);
            showAlert("Component updated successfully", "success");
        } else {
            await API.createComponent(componentData);
            showAlert("Component created successfully", "success");
        }

        closeModal("componentModal");
        await loadAllData();
    } catch (error) {
        console.error("Error saving component:", error);
        showAlert("Error saving component", "error");
    }
}

function populateComponentSelects() {
    populateCategorySelect();
    populateManufacturerSelect();
    populateLocationSelect();
}

function populateCategorySelect() {
    const select = document.getElementById("componentCategory");
    const activeCategories = filterByDeleted(state.categories, false);

    select.innerHTML =
        '<option value="">Select a category</option>' +
        activeCategories
            .map(
                (category) => `
        <option value="${category.id}">${escapeHtml(category.name)}</option>
    `,
            )
            .join("");

    if (state.editingId && state.editingType === "component") {
        const component = state.components.find(
            (c) => c.id === state.editingId,
        );
        if (component) select.value = component.categoryId;
    }
}

function populateManufacturerSelect() {
    const select = document.getElementById("componentManufacturer");
    const activeManufacturers = filterByDeleted(state.manufacturers, false);

    select.innerHTML =
        '<option value="">Select a manufacturer</option>' +
        activeManufacturers
            .map(
                (manufacturer) => `
        <option value="${manufacturer.id}">${escapeHtml(manufacturer.name)}</option>
    `,
            )
            .join("");

    if (state.editingId && state.editingType === "component") {
        const component = state.components.find(
            (c) => c.id === state.editingId,
        );
        if (component) select.value = component.manufacturerId;
    }
}

function populateLocationSelect() {
    const select = document.getElementById("componentLocation");
    const activeLocations = filterByDeleted(state.locations, false);

    select.innerHTML =
        '<option value="">Select a location</option>' +
        activeLocations
            .map(
                (location) => `
        <option value="${location.id}">${escapeHtml(location.name)}</option>
    `,
            )
            .join("");

    if (state.editingId && state.editingType === "component") {
        const component = state.components.find(
            (c) => c.id === state.editingId,
        );
        if (component) select.value = component.locationId;
    }
}

// ===== Category Modal Functions =====
async function openCategoryModal() {
    state.editingId = null;
    state.editingType = "category";

    document.getElementById("categoryModalTitle").textContent =
        "Create Category";
    document.getElementById("categoryForm").reset();

    openModal("categoryModal");
}

async function editCategory(id) {
    try {
        const category = await API.getCategoryById(id);
        state.editingId = id;
        state.editingType = "category";

        document.getElementById("categoryModalTitle").textContent =
            "Edit Category";
        document.getElementById("categoryName").value = category.name;
        document.getElementById("categoryDescription").value =
            category.description || "";

        openModal("categoryModal");
    } catch (error) {
        console.error("Error loading category:", error);
        showAlert("Error loading category", "error");
    }
}

async function saveCategory(e) {
    e.preventDefault();

    const name = document.getElementById("categoryName").value;
    const description = document.getElementById("categoryDescription").value;

    if (!name) {
        showAlert("Category name is required", "error");
        return;
    }

    try {
        const categoryData = {
            name,
            description,
        };

        if (state.editingId) {
            await API.updateCategory(state.editingId, categoryData);
            showAlert("Category updated successfully", "success");
        } else {
            await API.createCategory(categoryData);
            showAlert("Category created successfully", "success");
        }

        closeModal("categoryModal");
        await loadAllData();
    } catch (error) {
        console.error("Error saving category:", error);
        showAlert("Error saving category", "error");
    }
}

// ===== Manufacturer Modal Functions =====
async function openManufacturerModal() {
    state.editingId = null;
    state.editingType = "manufacturer";

    document.getElementById("manufacturerModalTitle").textContent =
        "Create Manufacturer";
    document.getElementById("manufacturerForm").reset();

    openModal("manufacturerModal");
}

async function editManufacturer(id) {
    try {
        const manufacturer = await API.getManufacturerById(id);
        state.editingId = id;
        state.editingType = "manufacturer";

        document.getElementById("manufacturerModalTitle").textContent =
            "Edit Manufacturer";
        document.getElementById("manufacturerName").value = manufacturer.name;
        document.getElementById("manufacturerDescription").value =
            manufacturer.description || "";

        openModal("manufacturerModal");
    } catch (error) {
        console.error("Error loading manufacturer:", error);
        showAlert("Error loading manufacturer", "error");
    }
}

async function saveManufacturer(e) {
    e.preventDefault();

    const name = document.getElementById("manufacturerName").value;
    const description = document.getElementById(
        "manufacturerDescription",
    ).value;

    if (!name) {
        showAlert("Manufacturer name is required", "error");
        return;
    }

    try {
        const manufacturerData = {
            name,
            description,
        };

        if (state.editingId) {
            await API.updateManufacturer(state.editingId, manufacturerData);
            showAlert("Manufacturer updated successfully", "success");
        } else {
            await API.createManufacturer(manufacturerData);
            showAlert("Manufacturer created successfully", "success");
        }

        closeModal("manufacturerModal");
        await loadAllData();
    } catch (error) {
        console.error("Error saving manufacturer:", error);
        showAlert("Error saving manufacturer", "error");
    }
}

// ===== Location Modal Functions =====
async function openLocationModal() {
    state.editingId = null;
    state.editingType = "location";

    document.getElementById("locationModalTitle").textContent =
        "Create Location";
    document.getElementById("locationForm").reset();

    openModal("locationModal");
}

async function editLocation(id) {
    try {
        const location = await API.getLocationById(id);
        state.editingId = id;
        state.editingType = "location";

        document.getElementById("locationModalTitle").textContent =
            "Edit Location";
        document.getElementById("locationName").value = location.name;
        document.getElementById("locationDescription").value =
            location.description || "";

        openModal("locationModal");
    } catch (error) {
        console.error("Error loading location:", error);
        showAlert("Error loading location", "error");
    }
}

async function saveLocation(e) {
    e.preventDefault();

    const name = document.getElementById("locationName").value;
    const description = document.getElementById("locationDescription").value;

    if (!name) {
        showAlert("Location name is required", "error");
        return;
    }

    try {
        const locationData = {
            name,
            description,
        };

        if (state.editingId) {
            await API.updateLocation(state.editingId, locationData);
            showAlert("Location updated successfully", "success");
        } else {
            await API.createLocation(locationData);
            showAlert("Location created successfully", "success");
        }

        closeModal("locationModal");
        await loadAllData();
    } catch (error) {
        console.error("Error saving location:", error);
        showAlert("Error saving location", "error");
    }
}

// ===== Delete Item =====
async function deleteItem(id, type) {
    if (!confirm("Are you sure you want to delete this item?")) return;

    try {
        switch (type) {
            case "projects":
                await API.deleteProject(id);
                break;
            case "components":
                await API.deleteComponent(id);
                break;
            case "categories":
                await API.deleteCategory(id);
                break;
            case "manufacturers":
                await API.deleteManufacturer(id);
                break;
            case "locations":
                await API.deleteLocation(id);
                break;
        }

        showAlert("Item deleted successfully", "success");
        await loadAllData();
    } catch (error) {
        console.error("Error deleting item:", error);
        showAlert("Error deleting item", "error");
    }
}

// ===== Modal Management =====
function openModal(modalId) {
    const modal = document.getElementById(modalId);
    modal.classList.add("active");
}

function closeModal(modalId) {
    const modal = document.getElementById(modalId);
    modal.classList.remove("active");
}

// ===== Populate Selects =====
function populateSelects() {
    populateCategorySelect();
    populateManufacturerSelect();
    populateLocationSelect();
}

// ===== Utility Functions =====
function escapeHtml(text) {
    if (!text) return "";
    const map = {
        "&": "&amp;",
        "<": "&lt;",
        ">": "&gt;",
        '"': "&quot;",
        "'": "&#039;",
    };
    return text.replace(/[&<>"']/g, (m) => map[m]);
}

function formatDate(dateString) {
    if (!dateString) return "N/A";
    const date = new Date(dateString);
    return date.toLocaleDateString("en-US", {
        year: "numeric",
        month: "short",
        day: "numeric",
    });
}

function getEmptyStateHTML(message, icon) {
    return `
        <div class="empty-state">
            <div class="empty-state-icon">${icon}</div>
            <h3>${message}</h3>
        </div>
    `;
}

function showAlert(message, type) {
    const alertDiv = document.createElement("div");
    alertDiv.className = `alert alert-${type}`;
    alertDiv.textContent = message;

    const mainContent = document.querySelector(".main-content");
    mainContent.insertBefore(alertDiv, mainContent.firstChild);

    setTimeout(() => {
        alertDiv.remove();
    }, 3000);
}
