using App.Data;
using App.Dto.Project;
using App.Entities;
using App.Mapping;
using Microsoft.EntityFrameworkCore;

namespace App.Endpoints;

public static class ProjectEndpoints {
    public static RouteGroupBuilder MapProjectEndpoints(this WebApplication app) {
        const string getProjectEndpointName = "GetProject";

        RouteGroupBuilder group = app.MapGroup("projects").WithParameterValidation();

        // GET
        group.MapGet("/", async (WarehouseDbContext dbContext) => {
            await dbContext.Projects
                .Include(project => project.Components)
                .Select(project => project.ToDto())
                .AsNoTracking()
                .ToListAsync();
        });

        // group.MapGet("/{id:long}", async (long id, WarehouseDbContext dbContext) => {
        //     Project? project = await dbContext.Projects.FindAsync(id);
        //
        //     return project == null ? Results.NotFound() : Results.Ok(project.ToDto());
        // }).WithName(getProjectEndpointName);

        group.MapGet("/{id:long}", async (long id, WarehouseDbContext dbContext) => {
            Project? project = await dbContext.Projects.FindAsync(id);

            if (project == null) return Results.NotFound();

            project.Components = await dbContext.ProjectComponents
                .Where(projectComponent => projectComponent.ProjectId == project.Id)
                .Select(projectComponent => projectComponent)
                .AsNoTracking()
                .ToListAsync();

            return Results.Ok(project.ToDto());
        }).WithName(getProjectEndpointName);

        // POST
        group.MapPost("/", async (CreateProjectDto createProjectDto, WarehouseDbContext dbContext) => {
            Project newProject = createProjectDto.ToEntity();

            await dbContext.Projects.AddAsync(newProject);
            await dbContext.SaveChangesAsync();

            return Results.CreatedAtRoute(getProjectEndpointName, new { id = newProject.Id }, newProject.ToDto());
        });

        // PUT
        group.MapPut("/{id:long}", async (long id, UpdateProjectDto updateProjectDto, WarehouseDbContext dbContext) => {
            Project? existingProject = await dbContext.Projects.FindAsync(id);

            if (existingProject == null) return Results.NotFound();

            dbContext.Entry(existingProject).CurrentValues.SetValues(updateProjectDto.ToEntity(id));
            await dbContext.SaveChangesAsync();

            return Results.NoContent();
        });

        // DELETE
        group.MapDelete("/{id:long}", async (long id, WarehouseDbContext dbContext) => {
            Project? existingProject = await dbContext.Projects.FindAsync(id);

            if (existingProject == null) return Results.NotFound();

            if (existingProject.IsDeleted) return Results.NoContent();

            existingProject.IsDeleted = true;

            dbContext.Entry(existingProject).CurrentValues.SetValues(existingProject);
            await dbContext.SaveChangesAsync();

            return Results.NoContent();
        });

        return group;
    }
}