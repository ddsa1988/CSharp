using SimpleToDoList.Dto;

namespace SimpleToDoList.Utils;

public static class ToDoList {
    public static List<ToDoDto> Create() {
        List<ToDoDto> toDoList = [
            new ToDoDto(1, "Go to the mall"),
            new ToDoDto(2, "Study programming"),
            new ToDoDto(3, "Buy some eggs")
        ];

        return toDoList;
    }
}