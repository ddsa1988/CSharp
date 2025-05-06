using Microsoft.EntityFrameworkCore;

namespace GameStore.Data;

public static class DataExtensions {
    public static async Task MigrateDbAsync(this WebApplication app) {
        using IServiceScope scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<GameStoreContext>();
        await dbContext.Database.MigrateAsync();
    }
}