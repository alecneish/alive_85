var triviaData = (function () {
  var all = [
    { id: 1, question: "What year was the original Nintendo Entertainment System released in North America?",
      options: ["1983", "1985", "1987", "1984"], correctIndex: 1,
      explanation: "The NES launched in North America in October 1985." },
    { id: 2, question: "Which 1984 film features the line 'I'll be back'?",
      options: ["RoboCop", "Predator", "The Terminator", "Rambo"], correctIndex: 2,
      explanation: "Arnold Schwarzenegger said it in The Terminator (1984)." },
    { id: 3, question: "What was the first music video played on MTV?",
      options: ["Thriller", "Video Killed the Radio Star", "Take On Me", "Girls Just Want to Have Fun"], correctIndex: 1,
      explanation: "The Buggles' 'Video Killed the Radio Star' was MTV's first video on August 1, 1981." },
    { id: 4, question: "Which arcade game caused a coin shortage in Japan upon release?",
      options: ["Pac-Man", "Donkey Kong", "Space Invaders", "Galaga"], correctIndex: 2,
      explanation: "Space Invaders (1978, popular into the 80s) caused a 100-yen coin shortage in Japan." },
    { id: 5, question: "What year did the DeLorean time machine travel to in Back to the Future?",
      options: ["1945", "1965", "1955", "1960"], correctIndex: 2,
      explanation: "Marty McFly traveled back to November 5, 1955." },
    { id: 6, question: "Which band performed the Live Aid concert at Wembley in 1985, widely regarded as the greatest live set ever?",
      options: ["U2", "The Who", "Led Zeppelin", "Queen"], correctIndex: 3,
      explanation: "Queen's 20-minute set at Live Aid is legendary, featuring Bohemian Rhapsody and Radio Ga Ga." },
    { id: 7, question: "What was the name of the Ghostbusters' car?",
      options: ["The Ghost Mobile", "Ecto-1", "Phantom Cruiser", "Spirit Wagon"], correctIndex: 1,
      explanation: "Ecto-1 was a converted 1959 Cadillac Miller-Meteor ambulance." },
    { id: 8, question: "Which shoe brand released the Air Jordan 1 in 1985?",
      options: ["Adidas", "Reebok", "Puma", "Nike"], correctIndex: 3,
      explanation: "Nike released the Air Jordan 1 in 1985, designed for Michael Jordan." },
    { id: 9, question: "What is the name of the mall in 'Back to the Future' where Marty meets Doc Brown?",
      options: ["Hill Valley Mall", "Twin Pines Mall", "Lone Pine Mall", "Sunset Mall"], correctIndex: 1,
      explanation: "Twin Pines Mall (which becomes Lone Pine Mall after Marty runs over one of the pine trees)." },
    { id: 10, question: "Which 1982 film features a lovable alien who wants to 'phone home'?",
      options: ["Close Encounters", "Alien", "E.T.", "Cocoon"], correctIndex: 2,
      explanation: "E.T. the Extra-Terrestrial, directed by Steven Spielberg." },
    { id: 11, question: "What color is Pac-Man?",
      options: ["Red", "Blue", "Yellow", "Green"], correctIndex: 2,
      explanation: "Pac-Man is yellow, inspired by a pizza with a slice removed." },
    { id: 12, question: "Which 80s TV show featured a talking car named KITT?",
      options: ["The A-Team", "Airwolf", "Knight Rider", "Miami Vice"], correctIndex: 2,
      explanation: "Knight Rider (1982-1986) starred David Hasselhoff and KITT, a Pontiac Trans Am." },
    { id: 13, question: "What year was Tetris created?",
      options: ["1980", "1982", "1984", "1986"], correctIndex: 2,
      explanation: "Tetris was created in 1984 by Alexey Pajitnov in the Soviet Union." },
    { id: 14, question: "Which 1985 film features a group of kids searching for pirate treasure?",
      options: ["Stand By Me", "The Goonies", "The Lost Boys", "Explorers"], correctIndex: 1,
      explanation: "The Goonies (1985), directed by Richard Donner and produced by Steven Spielberg." },
    { id: 15, question: "What was the best-selling album of the 1980s?",
      options: ["Born in the U.S.A.", "Purple Rain", "Thriller", "Back in Black"], correctIndex: 2,
      explanation: "Michael Jackson's Thriller (1982) is the best-selling album of all time." },
    { id: 16, question: "Which 80s sitcom is set in a Boston bar 'where everybody knows your name'?",
      options: ["Cheers", "Family Ties", "Night Court", "Taxi"], correctIndex: 0,
      explanation: "Cheers ran from 1982 to 1993 and was set in a Boston bar." },
    { id: 17, question: "What was the first commercially successful handheld game console?",
      options: ["Sega Game Gear", "Atari Lynx", "Nintendo Game Boy", "Neo Geo Pocket"], correctIndex: 2,
      explanation: "The Game Boy launched in 1989 and sold over 118 million units." },
    { id: 18, question: "Which 1983 film featured a computer that nearly starts World War III?",
      options: ["Tron", "WarGames", "Blade Runner", "Electric Dreams"], correctIndex: 1,
      explanation: "WarGames (1983) starred Matthew Broderick as a teen hacker who accidentally accesses a military supercomputer." },
    { id: 19, question: "What was Madonna's first #1 hit single?",
      options: ["Material Girl", "Like a Virgin", "Papa Don't Preach", "Into the Groove"], correctIndex: 1,
      explanation: "Like a Virgin reached #1 on the Billboard Hot 100 in December 1984." },
    { id: 20, question: "Which 80s toy line featured heroes and villains fighting over Castle Grayskull?",
      options: ["G.I. Joe", "Transformers", "Thundercats", "He-Man"], correctIndex: 3,
      explanation: "He-Man and the Masters of the Universe battled over Castle Grayskull." }
  ];

  function shuffle(arr) {
    for (var i = arr.length - 1; i > 0; i--) {
      var j = Math.floor(Math.random() * (i + 1));
      var tmp = arr[i]; arr[i] = arr[j]; arr[j] = tmp;
    }
    return arr;
  }

  return shuffle(all.slice()).slice(0, 5);
})();
