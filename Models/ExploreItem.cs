namespace alive_85.Models;

public class ExploreItem
{
    public required string Title { get; init; }
    public required string Year { get; init; }
    public required string Description { get; init; }
    public required string Emoji { get; init; }
    public string? Tag { get; init; }
}

public class ExploreCategory
{
    public required string Slug { get; init; }
    public required string Name { get; init; }
    public required string Emoji { get; init; }
    public required string Tagline { get; init; }
    public required string Description { get; init; }
    public required List<ExploreItem> Items { get; init; }
}
