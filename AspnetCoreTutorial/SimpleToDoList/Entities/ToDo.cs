using System.ComponentModel.DataAnnotations;

namespace SimpleToDoList.Entities;

public class ToDo {
    public int Id;
    [Required] public string Description = string.Empty;
    public bool IsCompleted;
}