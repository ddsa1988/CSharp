using Microsoft.EntityFrameworkCore;

namespace App.Data;

public static class DataExtensions {
    public static async Task MigrateDbAsync(this WebApplication app) {
        using IServiceScope scope = app.Services.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<WarehouseDbContext>();
        await db.Database.MigrateAsync();
    }
}