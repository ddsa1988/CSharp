using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkCore.Models.Blogging;

internal class Blog {
    public int BlogId { get; init; }
    [MaxLength(50)] public string Url { get; init; } = string.Empty;

    public List<Post> Posts { get; } = [];
}