// ===== API Configuration =====
const API_BASE_URL = "http://localhost:5000";

// ===== API Service =====
const API = {
    // ===== Projects =====
    async getAllProjects() {
        try {
            const response = await fetch(`${API_BASE_URL}/projects`);
            if (!response.ok) throw new Error("Failed to fetch projects");
            return await response.json();
        } catch (error) {
            console.error("Error fetching projects:", error);
            throw error;
        }
    },

    async getProjectById(id) {
        try {
            const response = await fetch(`${API_BASE_URL}/projects/${id}`);
            if (!response.ok) throw new Error("Failed to fetch project");
            return await response.json();
        } catch (error) {
            console.error("Error fetching project:", error);
            throw error;
        }
    },

    async createProject(projectData) {
        try {
            const response = await fetch(`${API_BASE_URL}/projects`, {
                method: "POST",
                headers: {
                    "Content-Type": "application/json",
                },
                body: JSON.stringify(projectData),
            });
            if (!response.ok) throw new Error("Failed to create project");
            return await response.json();
        } catch (error) {
            console.error("Error creating project:", error);
            throw error;
        }
    },

    async updateProject(id, projectData) {
        try {
            const response = await fetch(`${API_BASE_URL}/projects/${id}`, {
                method: "PUT",
                headers: {
                    "Content-Type": "application/json",
                },
                body: JSON.stringify(projectData),
            });
            if (!response.ok) throw new Error("Failed to update project");
        } catch (error) {
            console.error("Error updating project:", error);
            throw error;
        }
    },

    async deleteProject(id) {
        try {
            const response = await fetch(`${API_BASE_URL}/projects/${id}`, {
                method: "DELETE",
            });
            if (!response.ok) throw new Error("Failed to delete project");
        } catch (error) {
            console.error("Error deleting project:", error);
            throw error;
        }
    },

    // ===== Components =====
    async getAllComponents() {
        try {
            const response = await fetch(`${API_BASE_URL}/components`);
            if (!response.ok) throw new Error("Failed to fetch components");
            return await response.json();
        } catch (error) {
            console.error("Error fetching components:", error);
            throw error;
        }
    },

    async getComponentById(id) {
        try {
            const response = await fetch(`${API_BASE_URL}/components/${id}`);
            if (!response.ok) throw new Error("Failed to fetch component");
            return await response.json();
        } catch (error) {
            console.error("Error fetching component:", error);
            throw error;
        }
    },

    async createComponent(componentData) {
        try {
            const response = await fetch(`${API_BASE_URL}/components`, {
                method: "POST",
                headers: {
                    "Content-Type": "application/json",
                },
                body: JSON.stringify(componentData),
            });
            if (!response.ok) throw new Error("Failed to create component");
            return await response.json();
        } catch (error) {
            console.error("Error creating component:", error);
            throw error;
        }
    },

    async updateComponent(id, componentData) {
        try {
            const response = await fetch(`${API_BASE_URL}/components/${id}`, {
                method: "PUT",
                headers: {
                    "Content-Type": "application/json",
                },
                body: JSON.stringify(componentData),
            });
            if (!response.ok) throw new Error("Failed to update component");
        } catch (error) {
            console.error("Error updating component:", error);
            throw error;
        }
    },

    async deleteComponent(id) {
        try {
            const response = await fetch(`${API_BASE_URL}/components/${id}`, {
                method: "DELETE",
            });
            if (!response.ok) throw new Error("Failed to delete component");
        } catch (error) {
            console.error("Error deleting component:", error);
            throw error;
        }
    },

    // ===== Categories =====
    async getAllCategories() {
        try {
            const response = await fetch(`${API_BASE_URL}/categories`);
            if (!response.ok) throw new Error("Failed to fetch categories");
            return await response.json();
        } catch (error) {
            console.error("Error fetching categories:", error);
            throw error;
        }
    },

    async getCategoryById(id) {
        try {
            const response = await fetch(`${API_BASE_URL}/categories/${id}`);
            if (!response.ok) throw new Error("Failed to fetch category");
            return await response.json();
        } catch (error) {
            console.error("Error fetching category:", error);
            throw error;
        }
    },

    async createCategory(categoryData) {
        try {
            const response = await fetch(`${API_BASE_URL}/categories`, {
                method: "POST",
                headers: {
                    "Content-Type": "application/json",
                },
                body: JSON.stringify(categoryData),
            });
            if (!response.ok) throw new Error("Failed to create category");
            return await response.json();
        } catch (error) {
            console.error("Error creating category:", error);
            throw error;
        }
    },

    async updateCategory(id, categoryData) {
        try {
            const response = await fetch(`${API_BASE_URL}/categories/${id}`, {
                method: "PUT",
                headers: {
                    "Content-Type": "application/json",
                },
                body: JSON.stringify(categoryData),
            });
            if (!response.ok) throw new Error("Failed to update category");
        } catch (error) {
            console.error("Error updating category:", error);
            throw error;
        }
    },

    async deleteCategory(id) {
        try {
            const response = await fetch(`${API_BASE_URL}/categories/${id}`, {
                method: "DELETE",
            });
            if (!response.ok) throw new Error("Failed to delete category");
        } catch (error) {
            console.error("Error deleting category:", error);
            throw error;
        }
    },

    // ===== Manufacturers =====
    async getAllManufacturers() {
        try {
            const response = await fetch(`${API_BASE_URL}/manufacturers`);
            if (!response.ok) throw new Error("Failed to fetch manufacturers");
            return await response.json();
        } catch (error) {
            console.error("Error fetching manufacturers:", error);
            throw error;
        }
    },

    async getManufacturerById(id) {
        try {
            const response = await fetch(`${API_BASE_URL}/manufacturers/${id}`);
            if (!response.ok) throw new Error("Failed to fetch manufacturer");
            return await response.json();
        } catch (error) {
            console.error("Error fetching manufacturer:", error);
            throw error;
        }
    },

    async createManufacturer(manufacturerData) {
        try {
            const response = await fetch(`${API_BASE_URL}/manufacturers`, {
                method: "POST",
                headers: {
                    "Content-Type": "application/json",
                },
                body: JSON.stringify(manufacturerData),
            });
            if (!response.ok) throw new Error("Failed to create manufacturer");
            return await response.json();
        } catch (error) {
            console.error("Error creating manufacturer:", error);
            throw error;
        }
    },

    async updateManufacturer(id, manufacturerData) {
        try {
            const response = await fetch(
                `${API_BASE_URL}/manufacturers/${id}`,
                {
                    method: "PUT",
                    headers: {
                        "Content-Type": "application/json",
                    },
                    body: JSON.stringify(manufacturerData),
                },
            );
            if (!response.ok) throw new Error("Failed to update manufacturer");
        } catch (error) {
            console.error("Error updating manufacturer:", error);
            throw error;
        }
    },

    async deleteManufacturer(id) {
        try {
            const response = await fetch(
                `${API_BASE_URL}/manufacturers/${id}`,
                {
                    method: "DELETE",
                },
            );
            if (!response.ok) throw new Error("Failed to delete manufacturer");
        } catch (error) {
            console.error("Error deleting manufacturer:", error);
            throw error;
        }
    },

    // ===== Locations =====
    async getAllLocations() {
        try {
            const response = await fetch(`${API_BASE_URL}/locations`);
            if (!response.ok) throw new Error("Failed to fetch locations");
            return await response.json();
        } catch (error) {
            console.error("Error fetching locations:", error);
            throw error;
        }
    },

    async getLocationById(id) {
        try {
            const response = await fetch(`${API_BASE_URL}/locations/${id}`);
            if (!response.ok) throw new Error("Failed to fetch location");
            return await response.json();
        } catch (error) {
            console.error("Error fetching location:", error);
            throw error;
        }
    },

    async createLocation(locationData) {
        try {
            const response = await fetch(`${API_BASE_URL}/locations`, {
                method: "POST",
                headers: {
                    "Content-Type": "application/json",
                },
                body: JSON.stringify(locationData),
            });
            if (!response.ok) throw new Error("Failed to create location");
            return await response.json();
        } catch (error) {
            console.error("Error creating location:", error);
            throw error;
        }
    },

    async updateLocation(id, locationData) {
        try {
            const response = await fetch(`${API_BASE_URL}/locations/${id}`, {
                method: "PUT",
                headers: {
                    "Content-Type": "application/json",
                },
                body: JSON.stringify(locationData),
            });
            if (!response.ok) throw new Error("Failed to update location");
        } catch (error) {
            console.error("Error updating location:", error);
            throw error;
        }
    },

    async deleteLocation(id) {
        try {
            const response = await fetch(`${API_BASE_URL}/locations/${id}`, {
                method: "DELETE",
            });
            if (!response.ok) throw new Error("Failed to delete location");
        } catch (error) {
            console.error("Error deleting location:", error);
            throw error;
        }
    },

    // ===== Project Components =====
    async getAllProjectComponents() {
        try {
            const response = await fetch(`${API_BASE_URL}/projectComponents`);
            if (!response.ok)
                throw new Error("Failed to fetch project components");
            return await response.json();
        } catch (error) {
            console.error("Error fetching project components:", error);
            throw error;
        }
    },

    async getProjectComponents(projectId) {
        try {
            const response = await fetch(
                `${API_BASE_URL}/projectComponents/projects/${projectId}`,
            );
            if (!response.ok)
                throw new Error("Failed to fetch project components");
            return await response.json();
        } catch (error) {
            console.error("Error fetching project components:", error);
            throw error;
        }
    },

    async createProjectComponent(projectComponentData) {
        try {
            const response = await fetch(`${API_BASE_URL}/projectComponents`, {
                method: "POST",
                headers: {
                    "Content-Type": "application/json",
                },
                body: JSON.stringify(projectComponentData),
            });
            if (!response.ok)
                throw new Error("Failed to create project component");
            return await response.json();
        } catch (error) {
            console.error("Error creating project component:", error);
            throw error;
        }
    },

    async updateProjectComponent(projectId, componentId, projectComponentData) {
        try {
            const response = await fetch(`${API_BASE_URL}/projectComponents`, {
                method: "PUT",
                headers: {
                    "Content-Type": "application/json",
                },
                body: JSON.stringify(projectComponentData),
            });
            if (!response.ok)
                throw new Error("Failed to update project component");
        } catch (error) {
            console.error("Error updating project component:", error);
            throw error;
        }
    },

    async deleteProjectComponent(projectId, componentId) {
        try {
            const response = await fetch(
                `${API_BASE_URL}/projectComponents/${projectId}/${componentId}`,
                {
                    method: "DELETE",
                },
            );
            if (!response.ok)
                throw new Error("Failed to delete project component");
        } catch (error) {
            console.error("Error deleting project component:", error);
            throw error;
        }
    },
};
