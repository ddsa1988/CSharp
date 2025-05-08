using SimpleToDoList.Dto;

namespace SimpleToDoList.Utils;

public static class ToDoList {
    public static List<ToDoDto> Create() {
        List<ToDoDto> toDoList = [
            new ToDoDto(1, "Go to the mall", false),
            new ToDoDto(2, "Study programming", false),
            new ToDoDto(3, "Buy some eggs", false)
        ];

        return toDoList;
    }
}