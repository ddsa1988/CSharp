using GameStore.Data;
using GameStore.Entities;
using GameStore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Endpoints;

public static class GenresEndpoints {
    public static RouteGroupBuilder MapGenresEndpoints(this WebApplication app) {
        RouteGroupBuilder group = app.MapGroup("genres");

        group.MapGet("/", async (GameStoreContext dbContext) => await dbContext.Genres
            .Select(genre => genre.ToDto())
            .AsNoTracking()
            .ToListAsync());

        return group;
    }
}