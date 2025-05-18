using Microsoft.EntityFrameworkCore;

namespace SimpleToDoList.Data;

public static class DataExtension {
    public static void MigrateDatabase(this WebApplication app) {
        using IServiceScope scope = app.Services.CreateScope();
        var toDoListContext = scope.ServiceProvider.GetRequiredService<ToDoListContext>();
        toDoListContext.Database.Migrate();
    }
}