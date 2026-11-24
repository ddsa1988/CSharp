using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkCore.Models.Blogging;

internal class Blog {
    public int BlogId { get; init; }
    [MaxLength(50)] public string Url { get; init; } = string.Empty;
    public List<Post> Posts { get; } = [];

    public override string ToString() {
        return Posts.Count == 0
            ? $"Blog [{nameof(BlogId)} = {BlogId}, {nameof(Url)} = {Url}]"
            : $"Blog [{nameof(BlogId)} = {BlogId}, {nameof(Url)} = {Url}, {nameof(Posts)} = {string.Join(", ", Posts)}";
    }
}