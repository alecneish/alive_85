using alive_85.Models;

namespace alive_85.Services;

public class ProductService
{
    private static readonly List<Product> Products =
    [
        new()
        {
            Id = "neon-nights-tee",
            Name = "Neon Nights Tee",
            Description = "Premium cotton, glow-in-dark print",
            Price = 34.00m,
            Tag = "New",
            Emoji = "\U0001f303",
            ImagePath = "/images/products/neon-nights-tee.svg",
            DetailDescription = "Step into the neon glow with this premium heavyweight cotton tee. Features a glow-in-the-dark cityscape print that comes alive when the lights go out — just like the 80s nightlife it celebrates.",
            Features =
            [
                "100% heavyweight cotton (220gsm)",
                "Glow-in-the-dark screen print",
                "Relaxed unisex fit",
                "Preshrunk and enzyme-washed",
                "Printed in limited runs of 200"
            ]
        },
        new()
        {
            Id = "the-85-crate",
            Name = "The 85 Crate",
            Description = "Monthly mystery box — curated 80s goods",
            Price = 49.00m,
            PriceSuffix = "/mo",
            Tag = "Hot",
            Emoji = "\U0001f4fc",
            ImagePath = "/images/products/the-85-crate.svg",
            DetailDescription = "Every month, a curated box of 80s nostalgia lands at your door. From vintage-style accessories and retro candy to exclusive alive85 merch and surprise collectibles — no two crates are the same.",
            Features =
            [
                "5-7 curated 80s items per crate",
                "Exclusive alive85 merch in every box",
                "Retro snacks and candy",
                "Vintage-style accessories",
                "Cancel anytime, no commitment"
            ]
        },
        new()
        {
            Id = "arcade-nights-hoodie",
            Name = "Arcade Nights Hoodie",
            Description = "Heavyweight fleece, embroidered patch",
            Price = 62.00m,
            Emoji = "\U0001f579\uFE0F",
            ImagePath = "/images/products/arcade-nights-hoodie.svg",
            DetailDescription = "Built for late-night arcade sessions and early-morning nostalgia. This heavyweight fleece hoodie features a hand-embroidered joystick patch on the chest and ribbed cuffs that actually stay tight.",
            Features =
            [
                "400gsm heavyweight fleece",
                "Hand-embroidered arcade patch",
                "Double-lined hood with drawcord",
                "Kangaroo pocket with hidden media port",
                "Ribbed cuffs and waistband"
            ]
        },
        new()
        {
            Id = "boombox-poster-set",
            Name = "Boombox Poster Set",
            Description = "3-print series, A2 size, matte finish",
            Price = 28.00m,
            Tag = "Ltd",
            Emoji = "\U0001f3a7",
            ImagePath = "/images/products/boombox-poster-set.svg",
            DetailDescription = "Three museum-quality A2 prints celebrating the boombox era. Each poster features a different iconic boombox design rendered in neon wireframe style on deep black stock. Limited edition of 500 sets.",
            Features =
            [
                "3 x A2 (420 x 594mm) prints",
                "Museum-quality matte paper (200gsm)",
                "Neon wireframe art style",
                "Numbered limited edition of 500",
                "Ships flat in rigid mailer"
            ]
        },
        new()
        {
            Id = "synthwave-vinyl-lp",
            Name = "Synthwave Vinyl LP",
            Description = "Original synthwave compilation on vinyl",
            Price = 22.00m,
            Tag = "New",
            Emoji = "\U0001f3b5",
            ImagePath = "/images/products/synthwave-vinyl-lp.svg",
            DetailDescription = "A carefully curated compilation of original synthwave tracks pressed on translucent pink vinyl. Twelve tracks of pure 80s-inspired electronic bliss, mastered for analog warmth.",
            Features =
            [
                "12 original synthwave tracks",
                "Translucent pink 180g vinyl",
                "Gatefold sleeve with retro artwork",
                "Includes digital download code",
                "Mastered at 45 RPM for extra clarity"
            ]
        },
        new()
        {
            Id = "retro-cassette-wallet",
            Name = "Retro Cassette Wallet",
            Description = "Compact bifold shaped like a cassette",
            Price = 18.00m,
            Emoji = "\U0001f4be",
            ImagePath = "/images/products/retro-cassette-wallet.svg",
            DetailDescription = "This compact bifold wallet is designed to look like a classic cassette tape — complete with printed label art and realistic detailing. Functional nostalgia that fits in your back pocket.",
            Features =
            [
                "Faux leather with cassette print",
                "6 card slots + bill compartment",
                "RFID blocking lining",
                "Compact bifold design",
                "Comes in retro blister packaging"
            ]
        },
        new()
        {
            Id = "chrome-aviator-shades",
            Name = "Chrome Aviator Shades",
            Description = "Mirrored lenses, chrome wire frame",
            Price = 42.00m,
            Tag = "Hot",
            Emoji = "\U0001f576\uFE0F",
            ImagePath = "/images/products/chrome-aviator-shades.svg",
            DetailDescription = "Channel your inner Top Gun with these chrome-finish aviator sunglasses. Mirrored blue lenses, ultra-thin wire frame, and spring hinges that actually fit. The 80s called — they said keep them.",
            Features =
            [
                "Mirrored blue gradient lenses",
                "Chrome wire frame with spring hinges",
                "UV400 protection",
                "Includes retro hard case",
                "Adjustable nose pads"
            ]
        },
        new()
        {
            Id = "pixel-art-pin-set",
            Name = "Pixel Art Enamel Pin Set",
            Description = "6 retro pixel art pins, hard enamel",
            Price = 16.00m,
            Emoji = "\U0001f3ae",
            ImagePath = "/images/products/pixel-art-pin-set.svg",
            DetailDescription = "Six hard enamel pins featuring iconic 80s pixel art: a boombox, joystick, cassette tape, CRT TV, Rubik's cube, and DeLorean. Each pin is die-struck with polished nickel plating.",
            Features =
            [
                "6 hard enamel pins per set",
                "Die-struck polished nickel",
                "Butterfly clutch backs (x2 each)",
                "Each pin approx. 30mm",
                "Packaged on retro display card"
            ]
        }
    ];

    public List<Product> GetAll() => Products;

    public Product? GetById(string id) => Products.Find(p => p.Id == id);
}
