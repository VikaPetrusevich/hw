using HW._10.Task3;
using System.Data.SqlTypes;

MusicFiles musicFile = new MusicFiles()
{
    Name = "Money",
    Code = Guid.NewGuid().ToString(),
    Category = "Rock",
    Size = 10,
    Singer = "ABBA",
    Lenght = 3
};

MusicFiles musicFile2 = new MusicFiles()
{
    Name = "Gummy-gummy",
    Code = Guid.NewGuid().ToString(),
    Category = "Rock",
    Size = 11,
    Singer = "ABBA",
    Lenght = 4
};

Films film = new Films()
{
    Name = "The tourist",
    Code = Guid.NewGuid().ToString(),
    Category = "Thriller",
    Size = 150,
    Director = "Florian Henckel von Donnersmarck",
    MainActor = "Johny Depp",
    MainActress = "Angelina Jolie"
};

Films film2 = new Films()
{
    Name = "Titanic",
    Code = Guid.NewGuid().ToString(),
    Category = "Drama",
    Size = 250,
    Director = "James Cameron",
    MainActor = "Leonardo DiCaprio",
    MainActress = "Kate Winslet"
};

ComputerPrograms computerProgram = new ComputerPrograms()
{
    Name = "Microsoft Word",
    Code = Guid.NewGuid().ToString(),
    Category = "Document editor",
    Size = 25
};

ComputerPrograms computerProgram2 = new ComputerPrograms()
{
    Name = "Microsoft Excel",
    Code = Guid.NewGuid().ToString(),
    Category = "Spreadsheet editor",
    Size = 29
};

var musicFiles = new[] { musicFile, musicFile2 };

foreach (var item in musicFiles) 
{ 
    item.RetrieveInformation();
}


var films = new[] { film, film2 };

foreach (var item in films)
{
    item.RetrieveInformation();
}

var computerPrograms = new[] { computerProgram, computerProgram2 };

foreach (var item in computerPrograms)
{
    item.RetrieveInformation();
}

Console.ReadKey();