using alive_85.Models;

namespace alive_85.Services;

public class ProductService
{
    private static readonly List<Product> Products =
    [
        new()
        {
            Id = "karate-kid-vhs",
            Name = "The Karate Kid VHS (1984, RCA/Columbia)",
            Description = "Original RCA/Columbia Pictures UK release, catalog 20471. Clamshell case with full cover art, tape in great shape. A must for any 80s movie shelf.",
            Price = 34.99m,
            Tag = "Vintage Original",
            Emoji = "\U0001f4fc",
            ImagePath = "/images/products/karate-kid-vhs.jpg",
            DetailDescription = "The original RCA/Columbia Pictures UK release of The Karate Kid (catalog 20471). Housed in its full clamshell case with original cover art front and back, and a tape that plays beautifully. A genuine piece of 1984 movie history — wax on, wax off.",
            Features =
            [
                "Original 1984 RCA/Columbia Pictures UK release",
                "Catalog number 20471",
                "Clamshell case with complete cover art",
                "Tape tested and in great playing condition",
                "A centerpiece for any 80s movie collection"
            ]
        },
        new()
        {
            Id = "sony-walkman",
            Name = "Sony FM/AM Walkman Cassette Player",
            Description = "Classic 80s Sony Walkman with FM/AM radio and original Sony foam headphones. Tested and working. Silver and black body with that iconic blue logo.",
            Price = 149.00m,
            Tag = "Vintage Original",
            Emoji = "\U0001f3a7",
            ImagePath = "/images/products/walkman.jpg",
            DetailDescription = "A classic 1980s Sony Walkman personal cassette player with built-in FM/AM radio, paired with its original Sony foam-padded headphones. Tested and fully working. The silver-and-black body wears that unmistakable blue Sony logo — pure analog nostalgia you can carry in your pocket.",
            Features =
            [
                "Genuine 80s Sony Walkman cassette player",
                "Built-in FM/AM radio tuner",
                "Includes original Sony foam headphones",
                "Tested and confirmed working",
                "Iconic silver/black body with blue logo"
            ]
        },
        new()
        {
            Id = "casio-ca53w-watch",
            Name = "Casio CA-53W Calculator Watch",
            Description = "The calculator watch made famous by Marty McFly. Alarm, chronograph, and full calculator keypad. Clean display, working perfectly.",
            Price = 59.99m,
            Tag = "Vintage Original",
            Emoji = "\u231a",
            ImagePath = "/images/products/casio_watch.jpg",
            DetailDescription = "The Casio CA-53W — the calculator watch immortalized on the wrist of Marty McFly. Featuring a daily alarm, chronograph, and a full working calculator keypad, all under a clean, crisp LCD display. Keeping perfect time and ready for the next adventure, past or future.",
            Features =
            [
                "Iconic CA-53W calculator watch",
                "Full working 8-digit calculator keypad",
                "Daily alarm and chronograph",
                "Clean, clear LCD display",
                "Keeping accurate time"
            ]
        },
        new()
        {
            Id = "hall-oates-tee",
            Name = "Hall & Oates 'You Make My Dreams' Tee",
            Description = "Soft seafoam cotton tee with a vintage-style Hall & Oates portrait print. New condition, printed to look and feel like an 80s original.",
            Price = 32.00m,
            Tag = "Retro Reissue",
            Emoji = "\U0001f455",
            ImagePath = "/images/products/hall-and-oates-tee.webp",
            DetailDescription = "A soft seafoam-green cotton tee celebrating one of the 80s' greatest duos. The chest features a vintage-style Hall & Oates portrait print with a worn-in, sun-faded finish. Brand new and printed to look and feel exactly like an 80s tour original.",
            Features =
            [
                "Soft seafoam-green cotton",
                "Vintage-style Hall & Oates portrait print",
                "Sun-faded, worn-in print finish",
                "New condition, retro reissue",
                "Relaxed unisex fit"
            ]
        }
    ];

    public List<Product> GetAll() => Products;

    public Product? GetById(string id) => Products.Find(p => p.Id == id);
}
