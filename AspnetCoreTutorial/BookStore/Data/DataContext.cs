using Microsoft.EntityFrameworkCore;

namespace BookStore.Data;

public static class DataExtension {
    public static async Task MigrateDatabaseAsync(this WebApplication app) {
        using IServiceScope scope = app.Services.CreateScope();
        var bookStoreContext = scope.ServiceProvider.GetRequiredService<BookStoreContext>();
        await bookStoreContext.Database.MigrateAsync();
    }
}