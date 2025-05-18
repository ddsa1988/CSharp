using SimpleToDoList.Dto;
using SimpleToDoList.Entities;

namespace SimpleToDoList.Mapping;

public static class ToDoMapping {
    public static ToDo ToEntity(this CreateToDoDto todo) {
        return new ToDo() {
            Description = todo.Description,
            IsCompleted = todo.IsCompleted
        };
    }

    public static ToDo ToEntity(this UpdateToDoDto todo, int id) {
        return new ToDo() {
            Id = id,
            Description = todo.Description,
            IsCompleted = todo.IsCompleted
        };
    }

    public static ToDoDto ToDto(this ToDo todo) {
        return new ToDoDto(todo.Id, todo.Description, todo.IsCompleted);
    }
}