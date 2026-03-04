namespace alive_85.Models;

public class Product
{
    public required string Id { get; init; }
    public required string Name { get; init; }
    public required string Description { get; init; }
    public required decimal Price { get; init; }
    public string? PriceSuffix { get; init; }
    public string? Tag { get; init; }
    public required string Emoji { get; init; }
    public string? ImagePath { get; init; }
    public required string DetailDescription { get; init; }
    public required List<string> Features { get; init; }
}
