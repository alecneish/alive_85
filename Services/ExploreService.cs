using alive_85.Models;

namespace alive_85.Services;

public class ExploreService
{
    private static readonly Dictionary<string, ExploreCategory> Categories = new()
    {
        ["movies"] = new ExploreCategory
        {
            Slug = "movies", Name = "Movies", Emoji = "\U0001f3ac",
            Tagline = "The decade that defined blockbusters",
            Description = "From sci-fi epics to teen comedies, the 80s gave us films that shaped every genre. Here are the ones that still hit.",
            Items =
            [
                new() { Title = "Blade Runner", Year = "1982", Emoji = "\U0001f5fc", Tag = "Sci-Fi",
                    Description = "Ridley Scott's neon-drenched vision of 2019 LA. Replicants, rain, and Rutger Hauer's tears in the rain monologue." },
                new() { Title = "The Breakfast Club", Year = "1985", Emoji = "\U0001f393", Tag = "Classic",
                    Description = "Five high schoolers. One Saturday detention. John Hughes defined a generation with this one." },
                new() { Title = "Back to the Future", Year = "1985", Emoji = "\u26a1", Tag = "Essential",
                    Description = "Marty McFly, a DeLorean, and 1.21 gigawatts. The most rewatchable film of the decade." },
                new() { Title = "Ghostbusters", Year = "1984", Emoji = "\U0001f47b",
                    Description = "Who you gonna call? Bill Murray, Dan Aykroyd, and the Stay Puft Marshmallow Man." },
                new() { Title = "E.T. the Extra-Terrestrial", Year = "1982", Emoji = "\U0001f6f8",
                    Description = "Spielberg made the whole world cry over a wrinkly alien with a glowing finger." },
                new() { Title = "Die Hard", Year = "1988", Emoji = "\U0001f4a5", Tag = "Action",
                    Description = "Bruce Willis in a tank top vs. Alan Rickman in a suit. Yes, it's a Christmas movie." },
                new() { Title = "Ferris Bueller's Day Off", Year = "1986", Emoji = "\U0001f3b6",
                    Description = "Life moves pretty fast. If you don't stop and look around once in a while, you could miss it." },
                new() { Title = "The Terminator", Year = "1984", Emoji = "\U0001f916",
                    Description = "He said he'd be back. James Cameron launched a franchise and made Schwarzenegger a legend." }
            ]
        },
        ["music"] = new ExploreCategory
        {
            Slug = "music", Name = "Music", Emoji = "\U0001f3b5",
            Tagline = "Synths, power ballads, and MTV",
            Description = "The 80s invented the music video, perfected the synth pop hook, and gave us hair that defied gravity. These are the tracks and artists that defined the sound.",
            Items =
            [
                new() { Title = "Thriller — Michael Jackson", Year = "1982", Emoji = "\U0001f3a4", Tag = "Essential",
                    Description = "The best-selling album of all time. Thriller, Billie Jean, Beat It — every track a smash." },
                new() { Title = "Purple Rain — Prince", Year = "1984", Emoji = "\U0001f7e3",
                    Description = "Part album, part film, all genius. Prince at his most iconic and unapologetic." },
                new() { Title = "Sweet Child O' Mine — Guns N' Roses", Year = "1987", Emoji = "\U0001f3b8", Tag = "Rock",
                    Description = "That opening riff. Slash made it look effortless, Axl made it sound dangerous." },
                new() { Title = "Take On Me — a-ha", Year = "1985", Emoji = "\U0001f3b9",
                    Description = "The synth riff that launched a thousand covers, and a music video that was pure rotoscoped art." },
                new() { Title = "Don't Stop Believin' — Journey", Year = "1981", Emoji = "\u2728",
                    Description = "A small-town girl, a city boy, and the most karaoke'd song in human history." },
                new() { Title = "Blue Monday — New Order", Year = "1983", Emoji = "\U0001f4bf", Tag = "Synth",
                    Description = "The best-selling 12-inch single of all time. Electronic music's ground zero." },
                new() { Title = "Under Pressure — Queen & David Bowie", Year = "1981", Emoji = "\U0001f451",
                    Description = "Two legends in the studio, one unforgettable bassline. Collaboration doesn't get better." }
            ]
        },
        ["fashion"] = new ExploreCategory
        {
            Slug = "fashion", Name = "Fashion", Emoji = "\U0001f457",
            Tagline = "Neon, denim, and zero subtlety",
            Description = "80s fashion was loud, layered, and unapologetically bold. From power suits to leg warmers, here's what defined the look of the decade.",
            Items =
            [
                new() { Title = "Power Suits", Year = "1980s", Emoji = "\U0001f454", Tag = "Iconic",
                    Description = "Shoulder pads wide enough to land a plane on. The power suit said 'I'm in charge' before you opened your mouth." },
                new() { Title = "Acid-Wash Denim", Year = "1986", Emoji = "\U0001f456",
                    Description = "Jeans, jackets, even skirts — if it was denim, it got the acid wash treatment." },
                new() { Title = "Neon Everything", Year = "1980s", Emoji = "\U0001f7e2", Tag = "Trend",
                    Description = "Hot pink, electric green, blazing orange. The 80s believed in being seen from space." },
                new() { Title = "Members Only Jackets", Year = "1983", Emoji = "\U0001f9e5",
                    Description = "The jacket that said you were somebody — even if nobody knew who." },
                new() { Title = "Leg Warmers", Year = "1983", Emoji = "\U0001f9e6",
                    Description = "Thanks to Flashdance, everyone wore leg warmers. To the gym, to school, to literally everywhere." },
                new() { Title = "Ray-Ban Wayfarers", Year = "1982", Emoji = "\U0001f576\uFE0F", Tag = "Classic",
                    Description = "Tom Cruise in Risky Business saved this frame from extinction. Sales jumped 2000%." },
                new() { Title = "High-Top Sneakers", Year = "1985", Emoji = "\U0001f45f",
                    Description = "Air Jordans dropped in '85 and sneaker culture was born. Your shoes became your identity." }
            ]
        },
        ["gaming"] = new ExploreCategory
        {
            Slug = "gaming", Name = "Gaming", Emoji = "\U0001f579\uFE0F",
            Tagline = "Quarters, cartridges, and high scores",
            Description = "The 80s built gaming from the ground up — arcades on every corner, the NES in every living room. These are the games and moments that started it all.",
            Items =
            [
                new() { Title = "Pac-Man", Year = "1980", Emoji = "\U0001f7e1", Tag = "Legendary",
                    Description = "Wakka wakka. The yellow circle that ate ghosts and quarters in equal measure. Gaming's first icon." },
                new() { Title = "Super Mario Bros.", Year = "1985", Emoji = "\U0001f344", Tag = "Essential",
                    Description = "A plumber, a princess, and a kingdom of pipes. Nintendo saved the gaming industry with this one." },
                new() { Title = "The Legend of Zelda", Year = "1986", Emoji = "\u2694\uFE0F",
                    Description = "An open world before 'open world' existed. Link's first quest set the template for adventure games." },
                new() { Title = "Tetris", Year = "1984", Emoji = "\U0001f9e9",
                    Description = "Soviet-born, globally beloved. The most addictive puzzle game ever made — and it's just blocks." },
                new() { Title = "Donkey Kong", Year = "1981", Emoji = "\U0001f412",
                    Description = "Mario's origin story. Jump over barrels, save the girl, and meet gaming's first villain." },
                new() { Title = "Space Invaders", Year = "1980", Emoji = "\U0001f47e", Tag = "Arcade",
                    Description = "The alien invasion that caused a coin shortage in Japan. Pure, distilled arcade tension." },
                new() { Title = "Frogger", Year = "1981", Emoji = "\U0001f438",
                    Description = "Get the frog across the road. Sounds simple. It wasn't. Millions of digital frogs died trying." },
                new() { Title = "OutRun", Year = "1986", Emoji = "\U0001f3ce\uFE0F",
                    Description = "Blue skies, palm trees, a red Ferrari, and a blonde in the passenger seat. The coolest racing game ever." }
            ]
        },
        ["tv-culture"] = new ExploreCategory
        {
            Slug = "tv-culture", Name = "TV & Culture", Emoji = "\U0001f4fa",
            Tagline = "The shows, ads, and moments we lived",
            Description = "Before streaming, before DVR — you watched it live or you missed it. The 80s gave us sitcoms, Saturday morning cartoons, and cultural moments that united the entire country.",
            Items =
            [
                new() { Title = "Miami Vice", Year = "1984", Emoji = "\U0001f334", Tag = "Iconic",
                    Description = "Pastel suits, no socks, Phil Collins on the soundtrack. Don Johnson made crime-fighting look like a fashion show." },
                new() { Title = "The Cosby Show", Year = "1984", Emoji = "\U0001f4fa",
                    Description = "The #1 show in America for five straight years. Changed the sitcom landscape." },
                new() { Title = "MTV Launch", Year = "1981", Emoji = "\U0001f4f1", Tag = "Moment",
                    Description = "'Ladies and gentlemen, rock and roll.' MTV launched with Video Killed the Radio Star and changed music forever." },
                new() { Title = "Transformers", Year = "1984", Emoji = "\U0001f916",
                    Description = "Robots in disguise. The cartoon that sold a billion toys and spawned a franchise that won't quit." },
                new() { Title = "Cheers", Year = "1982", Emoji = "\U0001f37a",
                    Description = "Where everybody knows your name. Sam, Diane, Norm — the bar sitcom perfected." },
                new() { Title = "The A-Team", Year = "1983", Emoji = "\U0001f4a5",
                    Description = "I love it when a plan comes together. Mr. T, explosions, and zero casualties. Peak 80s TV." },
                new() { Title = "Live Aid", Year = "1985", Emoji = "\U0001f30d", Tag = "Moment",
                    Description = "1.9 billion viewers across 150 countries. Queen's set at Wembley is still the greatest live performance ever." }
            ]
        }
    };

    public ExploreCategory? GetCategory(string slug) =>
        Categories.GetValueOrDefault(slug);

    public List<ExploreCategory> GetAll() =>
        Categories.Values.ToList();
}
