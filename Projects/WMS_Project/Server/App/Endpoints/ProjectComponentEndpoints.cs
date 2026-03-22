using App.Data;
using App.Dto.ProjectComponent;
using App.Entities;
using App.Mapping;
using Microsoft.EntityFrameworkCore;

namespace App.Endpoints;

public static class ProjectComponentEndpoints {
    public static RouteGroupBuilder MapProjectComponentEndpoints(this WebApplication app) {
        const string getPcEndpointName = "GetProjectComponent";

        RouteGroupBuilder group = app.MapGroup("projectComponents").WithParameterValidation();

        // GET
        group.MapGet("/", async (WarehouseDbContext dbContext) => {
            return await dbContext.ProjectComponents
                .Include(pc => pc.Project)
                .Include(pc => pc.Component)
                .Select(pc => pc.ToDto())
                .AsNoTracking()
                .ToListAsync();
        });

        group.MapGet("/{projectId:long}/{componentId:long}",
            async (long projectId, long componentId, WarehouseDbContext dbContext) => {
                ProjectComponent? existingPc = await dbContext.ProjectComponents
                    .Include(pc => pc.Project)
                    .Include(pc => pc.Component)
                    .FirstOrDefaultAsync(pc => pc.ProjectId == projectId && pc.ComponentId == componentId);

                return existingPc == null ? Results.NotFound() : Results.Ok(existingPc.ToDto());
            }).WithName(getPcEndpointName);

        group.MapGet("/projects/{id:long}", async (long id, WarehouseDbContext dbContext) => {
            return await dbContext.ProjectComponents
                .Include(pc => pc.Project)
                .Include(pc => pc.Component)
                .Where(pc => pc.ProjectId == id)
                .Select(pc => pc.ToDto())
                .AsNoTracking()
                .ToListAsync();
        });

        group.MapGet("/components/{id:long}", async (long id, WarehouseDbContext dbContext) => {
            return await dbContext.ProjectComponents
                .Include(pc => pc.Project)
                .Include(pc => pc.Component)
                .Where(pc => pc.ComponentId == id)
                .Select(pc => pc.ToDto())
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

                ProjectComponent newPc = createProjectComponent.ToEntity();

                await dbContext.ProjectComponents.AddAsync(newPc);
                await dbContext.SaveChangesAsync();

                return Results.CreatedAtRoute(getPcEndpointName,
                    new { projectId = newPc.ProjectId, componentId = newPc.ComponentId },
                    newPc.ToDto());
            });

        // PUT
        group.MapPut("/",
            async (UpdateProjectComponentDto updateProjectComponent, WarehouseDbContext dbContext) => {
                ProjectComponent? existingProjectComponent =
                    await dbContext.ProjectComponents.FindAsync(updateProjectComponent.ProjectId,
                        updateProjectComponent.ComponentId);

                if (existingProjectComponent == null) return Results.NotFound();

                dbContext.Entry(existingProjectComponent).CurrentValues.SetValues(updateProjectComponent.ToEntity());
                await dbContext.SaveChangesAsync();

                return Results.NoContent();
            });

        // DELETE
        group.MapDelete("/{projectId:long}/{componentId:long}",
            async (long projectId, long componentId, WarehouseDbContext dbContext) => {
                ProjectComponent? existingProjectComponent =
                    await dbContext.ProjectComponents.FindAsync(projectId, componentId);

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