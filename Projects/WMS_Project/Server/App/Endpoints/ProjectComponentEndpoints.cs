using App.Data;
using App.Dto.ProjectComponent;
using App.Entities;
using App.Mapping;
using Microsoft.EntityFrameworkCore;

namespace App.Endpoints;

public static class ProjectComponentEndpoints {
    public static RouteGroupBuilder MapProjectComponentEndpoints(this WebApplication app) {
        const string getProjectComponentEndpointName = "GetProjectComponent";

        RouteGroupBuilder group = app.MapGroup("projectComponents").WithParameterValidation();

        // GET
        group.MapGet("/", async (WarehouseDbContext dbContext) => {
            await dbContext.ProjectComponents
                .Select(projectComponent => projectComponent.ToDto())
                .AsNoTracking()
                .ToListAsync();
        });

        group.MapGet("/projects/{id:long}", async (long id, WarehouseDbContext dbContext) => {
            await dbContext.ProjectComponents
                .Where(projectComponent => projectComponent.ProjectId == id)
                .Select(projectComponent => projectComponent.ToDto())
                .AsNoTracking()
                .ToListAsync();
        });

        group.MapGet("/components/{id:long}", async (long id, WarehouseDbContext dbContext) => {
            await dbContext.ProjectComponents
                .Where(projectComponent => projectComponent.ComponentId == id)
                .Select(projectComponent => projectComponent.ToDto())
                .AsNoTracking()
                .ToListAsync();
        });

        // POST
        group.MapPost("/",
            async (CreateProjectComponentDto createProjectComponent, WarehouseDbContext dbContext) => {
                Project? existingProject = await dbContext.Projects.FindAsync(createProjectComponent.ProjectId);
                Component? existingComponent = await dbContext.Components.FindAsync(createProjectComponent.ComponentId);

                if (existingProject == null) return Results.NotFound("Project not found");
                if (existingComponent == null) return Results.NotFound("Component not found");

                ProjectComponent newProjectComponent = createProjectComponent.ToEntity();

                await dbContext.ProjectComponents.AddAsync(newProjectComponent);
                await dbContext.SaveChangesAsync();

                return Results.CreatedAtRoute(getProjectComponentEndpointName, newProjectComponent.ToDto());
            });

        // PUT
        group.MapPut("/",
            async (UpdateProjectComponentDto updateProjectComponent, WarehouseDbContext dbContext) => {
                ProjectComponent? existingProjectComponent =
                    await dbContext.ProjectComponents.FindAsync(updateProjectComponent.ProjectId);

                if (existingProjectComponent == null) return Results.NotFound();

                dbContext.Entry(existingProjectComponent).CurrentValues.SetValues(updateProjectComponent.ToEntity());

                return Results.NoContent();
            });

        // DELETE
        group.MapDelete("/{id:long}", async (long id, WarehouseDbContext dbContext) => {
            ProjectComponent? existingProjectComponent = await dbContext.ProjectComponents.FindAsync(id);

            if (existingProjectComponent == null) return Results.NotFound();

            if (existingProjectComponent.IsDeleted) return Results.NoContent();

            existingProjectComponent.IsDeleted = true;

            dbContext.Entry(existingProjectComponent).CurrentValues.SetValues(existingProjectComponent);
            await dbContext.SaveChangesAsync();

            return Results.NoContent();
        });

        return group;
    }
}