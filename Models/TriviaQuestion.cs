namespace alive_85.Models;

public class TriviaQuestion
{
    public required int Id { get; init; }
    public required string Question { get; init; }
    public required List<string> Options { get; init; }
    public required int CorrectIndex { get; init; }
    public required string Explanation { get; init; }
}
