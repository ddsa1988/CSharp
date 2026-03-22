# Warehouse Management System - Client Application

A modern web-based warehouse management system for automation companies, built with pure HTML, CSS, and JavaScript.

## Features

- **Project Management**: Create, edit, and manage projects
- **Component Management**: Manage inventory components with pricing and location tracking
- **Category Management**: Organize components into categories
- **Manufacturer Tracking**: Keep track of component manufacturers
- **Location Management**: Manage warehouse locations
- **Component Selection**: Add multiple components to projects through an intuitive selection interface
- **Soft Delete**: Mark items as deleted without permanently removing them (IsDeleted flag)
- **Filter Control**: Toggle between showing/hiding deleted items
- **Responsive Design**: Works on desktop and mobile devices
- **Real-time Sync**: All changes sync with the backend API

## Setup Instructions

### Prerequisites

1. The WMS backend server must be running on `http://localhost:5000`
2. A modern web browser (Chrome, Firefox, Safari, or Edge)

### Starting the Application

1. **Start the Backend Server**:

    ```bash
    cd /home/ddsa/Downloads/WMS_Project/Server/App
    dotnet run
    ```

    The server will start on `http://localhost:5000`

2. **Open the Web Application**:
    - Navigate to `/home/ddsa/Downloads/WMS_Project/Client/index.html` in your browser
    - Or start a simple HTTP server in the Client folder:
        ```bash
        cd /home/ddsa/Downloads/WMS_Project/Client
        # Using Python 3
        python -m http.server 8000
        # Using Python 2
        python -m SimpleHTTPServer 8000
        # Using Node.js
        npx http-server
        ```
    - Then visit `http://localhost:8000` in your browser

## File Structure

```
Client/
├── index.html        # Main HTML file with all modals and layout
├── style.css         # Complete styling and responsive design
├── app.js            # Main application logic and event handlers
└── api.js            # API service for backend communication
```

## Usage

### Navigation

Use the navigation bar at the top to switch between different views:

- **Projects**: View and manage projects
- **Components**: Manage inventory components
- **Categories**: Organize component categories
- **Manufacturers**: Track component manufacturers
- **Locations**: Manage warehouse locations

### Filter Deleted Items

The "Show Deleted Items" checkbox in the filter section allows you to:

- **Unchecked**: Only show active items (IsDeleted = false)
- **Checked**: Show both active and deleted items

### Creating Items

Click the **"+ Create [Item Type]"** button to open the creation modal for any item type.

### Creating Projects with Components

1. Click **"+ Create Project"** button
2. Enter project name and description
3. Use the **"Component Select"** dropdown to add components to the project
4. Click **"Add Component"** to add each selected component
5. Review your selections in the "Selected Components" list
6. Click **"Save Project"** to create the project

You can remove components before saving by clicking the **"Remove"** button next to each component.

### Editing Items

Click the **"Edit"** button on any item card to open the edit modal with pre-filled values.

### Deleting Items

Click the **"Delete"** button to soft-delete an item. The item will be marked as deleted and can be shown/hidden using the filter toggle.

## Component Selection for Projects

When editing or creating projects:

- A dropdown shows all available (non-deleted) components
- Click **"Add Component"** to add the selected component to the project
- Remove components by clicking the **"Remove"** button in the selected components list
- Only non-deleted components can be added to projects

## API Endpoints Used

The application communicates with the backend using the following endpoints:

### Projects

- `GET /projects` - Get all projects
- `GET /projects/{id}` - Get a specific project with components
- `POST /projects` - Create a new project
- `PUT /projects/{id}` - Update a project
- `DELETE /projects/{id}` - Delete (soft delete) a project

### Components

- `GET /components` - Get all components
- `GET /components/{id}` - Get a specific component
- `POST /components` - Create a new component
- `PUT /components/{id}` - Update a component
- `DELETE /components/{id}` - Delete a component

### Project Components

- `GET /projectComponents` - Get all project components
- `POST /projectComponents` - Add component to project
- `DELETE /projectComponents/{projectId}/{componentId}` - Remove component from project

### Categories, Manufacturers, Locations

- Similar CRUD endpoints for each entity type

## Styling

The application features:

- Modern gradient header with the company branding
- Card-based layout for items
- Color-coded badges for component metadata
- Responsive grid that adapts to mobile devices
- Modal dialogs for forms
- Smooth animations and transitions
- Hover effects for better interactivity

## Error Handling

- The application displays user-friendly error messages when API calls fail
- Success messages confirm when items are created, updated, or deleted
- All API errors are logged to the browser console for debugging

## Notes

- The "Show Deleted Items" filter affects all views (Projects, Components, Categories, etc.)
- Items with `IsDeleted = true` are displayed with reduced opacity and a "DELETED" badge
- When editing a project, existing component associations are preserved
- All timestamps are automatically formatted for readability
- Form validation ensures all required fields are filled before submission

## Troubleshooting

**Can't connect to backend?**

- Make sure the server is running on `http://localhost:5000`
- Check the browser console for CORS errors
- Backend has CORS enabled for "AllowAll" policy

**Changes not appearing?**

- The application loads data on startup and after each operation
- Try refreshing the page if data seems out of sync

**Components dropdown empty?**

- Only non-deleted components appear in the dropdown
- Check the "Show Deleted Items" filter status
