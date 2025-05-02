using Microsoft.EntityFrameworkCore;

namespace GameStore.Data;

public static class DataExtensions {
    public static void MigrateDb(this WebApplication app) {
        using IServiceScope scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<GameStoreContext>();
        dbContext.Database.Migrate();
    }
}