using BookStore.Data;
using BookStore.Dto.Publisher;
using BookStore.Entities;
using BookStore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Endpoints;

public static class PublishersEndpoints {
    private const string GetPublisherEndpoint = "GetPublisher";

    public static RouteGroupBuilder MapPublishersEndpoints(this WebApplication app) {
        // Define groups of endpoints with a common prefix
        RouteGroupBuilder group = app.MapGroup("publishers").WithParameterValidation();

        // Get /publishers
        group.MapGet("/", async (BookStoreContext dbContext) => {
            return await dbContext.Publisher
                .Select(publisher => publisher.ToDto())
                .AsNoTracking()
                .ToListAsync();
        });

        // Get /publishers/id
        group.MapGet("/{id:int}", async (int id, BookStoreContext dbContext) => {
            Publisher? publisher = await dbContext.Publisher.FindAsync(id);

            return publisher == null ? Results.NotFound() : Results.Ok(publisher.ToDto());
        }).WithName(GetPublisherEndpoint);

        // Post /publishers
        group.MapPost("/", async (CreatePublisherDto newPublisher, BookStoreContext dbContext) => {
            Publisher? existingPublisher =
                await dbContext.Publisher.FirstOrDefaultAsync(publisher => publisher.Name == newPublisher.Name);

            if (existingPublisher != null) return Results.Conflict("Publisher already exists");

            Publisher publisher = newPublisher.ToEntity();

            dbContext.Publisher.Add(publisher);
            await dbContext.SaveChangesAsync();

            return Results.CreatedAtRoute(GetPublisherEndpoint, new { id = publisher.Id }, publisher.ToDto());
        });

        // Put /publishers/id
        group.MapPut("/{id:int}", async (int id, UpdatePublisherDto updatedPublisher, BookStoreContext dbContext) => {
            Publisher? existingPublisher = await dbContext.Publisher.FindAsync(id);

            if (existingPublisher == null) return Results.NotFound();

            dbContext.Publisher.Entry(existingPublisher).CurrentValues.SetValues(updatedPublisher.ToEntity(id));
            await dbContext.SaveChangesAsync();

            return Results.NoContent();
        });

        // Delete /publishers/id
        group.MapDelete("/{id:int}", async (int id, BookStoreContext dbContext) => {
            await dbContext.Publisher.Where(publisher => publisher.Id == id).ExecuteDeleteAsync();

            return Results.NoContent();
        });

        return group;
    }
}