using Microsoft.EntityFrameworkCore;

namespace SimpleToDoList.Data;

public static class DataExtension {
    public static async Task MigrateDatabaseAsync(this WebApplication app) {
        using IServiceScope scope = app.Services.CreateScope();
        var toDoListContext = scope.ServiceProvider.GetRequiredService<ToDoListContext>();
        await toDoListContext.Database.MigrateAsync();
    }
}