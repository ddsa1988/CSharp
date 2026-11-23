using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkCore.Models.Blogging;

internal class Post {
    public int PostId { get; init; }
    [MaxLength(30)] public string Title { get; init; } = string.Empty;
    [MaxLength(100)] public string Content { get; init; } = string.Empty;
    public int BlogId { get; init; }
    public Blog? Blog { get; init; }

    public override string ToString() {
        return $"Post [{nameof(PostId)} = {PostId}, {nameof(Title)} = {Title}, {nameof(Content)} = {Content}]";
    }
}