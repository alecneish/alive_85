using alive_85.Models;

namespace alive_85.Services;

public class TriviaService
{
    private static readonly List<TriviaQuestion> Questions =
    [
        new() { Id = 1, Question = "What year was the original Nintendo Entertainment System released in North America?",
            Options = ["1983", "1985", "1987", "1984"], CorrectIndex = 1,
            Explanation = "The NES launched in North America in October 1985." },
        new() { Id = 2, Question = "Which 1984 film features the line 'I'll be back'?",
            Options = ["RoboCop", "Predator", "The Terminator", "Rambo"], CorrectIndex = 2,
            Explanation = "Arnold Schwarzenegger said it in The Terminator (1984)." },
        new() { Id = 3, Question = "What was the first music video played on MTV?",
            Options = ["Thriller", "Video Killed the Radio Star", "Take On Me", "Girls Just Want to Have Fun"], CorrectIndex = 1,
            Explanation = "The Buggles' 'Video Killed the Radio Star' was MTV's first video on August 1, 1981." },
        new() { Id = 4, Question = "Which arcade game caused a coin shortage in Japan upon release?",
            Options = ["Pac-Man", "Donkey Kong", "Space Invaders", "Galaga"], CorrectIndex = 2,
            Explanation = "Space Invaders (1978, popular into the 80s) caused a 100-yen coin shortage in Japan." },
        new() { Id = 5, Question = "What year did the DeLorean time machine travel to in Back to the Future?",
            Options = ["1945", "1965", "1955", "1960"], CorrectIndex = 2,
            Explanation = "Marty McFly traveled back to November 5, 1955." },
        new() { Id = 6, Question = "Which band performed the Live Aid concert at Wembley in 1985, widely regarded as the greatest live set ever?",
            Options = ["U2", "The Who", "Led Zeppelin", "Queen"], CorrectIndex = 3,
            Explanation = "Queen's 20-minute set at Live Aid is legendary, featuring Bohemian Rhapsody and Radio Ga Ga." },
        new() { Id = 7, Question = "What was the name of the Ghostbusters' car?",
            Options = ["The Ghost Mobile", "Ecto-1", "Phantom Cruiser", "Spirit Wagon"], CorrectIndex = 1,
            Explanation = "Ecto-1 was a converted 1959 Cadillac Miller-Meteor ambulance." },
        new() { Id = 8, Question = "Which shoe brand released the Air Jordan 1 in 1985?",
            Options = ["Adidas", "Reebok", "Puma", "Nike"], CorrectIndex = 3,
            Explanation = "Nike released the Air Jordan 1 in 1985, designed for Michael Jordan." },
        new() { Id = 9, Question = "What is the name of the mall in 'Back to the Future' where Marty meets Doc Brown?",
            Options = ["Hill Valley Mall", "Twin Pines Mall", "Lone Pine Mall", "Sunset Mall"], CorrectIndex = 1,
            Explanation = "Twin Pines Mall (which becomes Lone Pine Mall after Marty runs over one of the pine trees)." },
        new() { Id = 10, Question = "Which 1982 film features a lovable alien who wants to 'phone home'?",
            Options = ["Close Encounters", "Alien", "E.T.", "Cocoon"], CorrectIndex = 2,
            Explanation = "E.T. the Extra-Terrestrial, directed by Steven Spielberg." },
        new() { Id = 11, Question = "What color is Pac-Man?",
            Options = ["Red", "Blue", "Yellow", "Green"], CorrectIndex = 2,
            Explanation = "Pac-Man is yellow, inspired by a pizza with a slice removed." },
        new() { Id = 12, Question = "Which 80s TV show featured a talking car named KITT?",
            Options = ["The A-Team", "Airwolf", "Knight Rider", "Miami Vice"], CorrectIndex = 2,
            Explanation = "Knight Rider (1982-1986) starred David Hasselhoff and KITT, a Pontiac Trans Am." },
        new() { Id = 13, Question = "What year was Tetris created?",
            Options = ["1980", "1982", "1984", "1986"], CorrectIndex = 2,
            Explanation = "Tetris was created in 1984 by Alexey Pajitnov in the Soviet Union." },
        new() { Id = 14, Question = "Which 1985 film features a group of kids searching for pirate treasure?",
            Options = ["Stand By Me", "The Goonies", "The Lost Boys", "Explorers"], CorrectIndex = 1,
            Explanation = "The Goonies (1985), directed by Richard Donner and produced by Steven Spielberg." },
        new() { Id = 15, Question = "What was the best-selling album of the 1980s?",
            Options = ["Born in the U.S.A.", "Purple Rain", "Thriller", "Back in Black"], CorrectIndex = 2,
            Explanation = "Michael Jackson's Thriller (1982) is the best-selling album of all time." },
        new() { Id = 16, Question = "Which 80s sitcom is set in a Boston bar 'where everybody knows your name'?",
            Options = ["Cheers", "Family Ties", "Night Court", "Taxi"], CorrectIndex = 0,
            Explanation = "Cheers ran from 1982 to 1993 and was set in a Boston bar." },
        new() { Id = 17, Question = "What was the first commercially successful handheld game console?",
            Options = ["Sega Game Gear", "Atari Lynx", "Nintendo Game Boy", "Neo Geo Pocket"], CorrectIndex = 2,
            Explanation = "The Game Boy launched in 1989 and sold over 118 million units." },
        new() { Id = 18, Question = "Which 1983 film featured a computer that nearly starts World War III?",
            Options = ["Tron", "WarGames", "Blade Runner", "Electric Dreams"], CorrectIndex = 1,
            Explanation = "WarGames (1983) starred Matthew Broderick as a teen hacker who accidentally accesses a military supercomputer." },
        new() { Id = 19, Question = "What was Madonna's first #1 hit single?",
            Options = ["Material Girl", "Like a Virgin", "Papa Don't Preach", "Into the Groove"], CorrectIndex = 1,
            Explanation = "Like a Virgin reached #1 on the Billboard Hot 100 in December 1984." },
        new() { Id = 20, Question = "Which 80s toy line featured heroes and villains fighting over Castle Grayskull?",
            Options = ["G.I. Joe", "Transformers", "Thundercats", "He-Man"], CorrectIndex = 3,
            Explanation = "He-Man and the Masters of the Universe battled over Castle Grayskull." }
    ];

    public List<TriviaQuestion> GetRandomSet(int count = 5)
    {
        var random = new Random();
        return Questions.OrderBy(_ => random.Next()).Take(count).ToList();
    }

    public TriviaQuestion? GetById(int id) =>
        Questions.Find(q => q.Id == id);

    public List<TriviaQuestion> GetAll() => Questions;
}
