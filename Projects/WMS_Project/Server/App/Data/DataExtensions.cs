using Microsoft.EntityFrameworkCore;

namespace App.Data;

public static class DataExtensions {
    public static void MigrateDb(this WebApplication app) {
        using IServiceScope scope = app.Services.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<WarehouseDbContext>();
        db.Database.Migrate();
    }
}