using Sushi.BL;

var sushiSet = new SushiSet()
{
    Name = "СУПЕР ФИЛАДЕЛЬФИЯ СЕТ",

    Description = "Суши-сет из трех роллов Филадельфия с огурцом, Филадельфия Нью, Филадельфия Фреш.",

    Weight = 900,

    Prace = 42.90M
};

var sushiSet2 = new SushiSet()
{
    Name = "ШОУ-РОЛЛЗ",

    Description = "Суши-сет из шести роллов: Филадельфия мини, Ролл с лососем и авокадо, Коста, Сезам с чука, Тигра, Гринвуд.",

    Weight = 1200,

    Prace = 62.90M
};

ISushiSetCollection setCollection = new SushiSetCollection();

setCollection.AddSet(sushiSet);
setCollection.AddSet(sushiSet2);

Console.WriteLine("Return all Sushi Set.");

var sushiSets = setCollection.GetSushiList();

foreach (var item in sushiSets)
{
    Console.WriteLine(item.ToString());
}