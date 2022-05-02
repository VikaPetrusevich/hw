using Sushi.BL;

var sushiSet = new SushiSet()
{
    Id = 1,

    Name = "СУПЕР ФИЛАДЕЛЬФИЯ СЕТ",

    Description = "Суши-сет из трех роллов Филадельфия с огурцом, Филадельфия Нью, Филадельфия Фреш.",

    Weight = 900,

    Price = 42.90M
};

var sushiSet2 = new SushiSet()
{
    Id = 2,
    
    Name = "ШОУ-РОЛЛЗ",

    Description = "Суши-сет из шести роллов: Филадельфия мини, Ролл с лососем и авокадо, Коста, Сезам с чука, Тигра, Гринвуд.",

    Weight = 1200,

    Price = 62.90M
};

ISushiSetService setCollection = new SushiSetService();

setCollection.AddSet(sushiSet);
setCollection.AddSet(sushiSet2);

Console.WriteLine("Return all Sushi Set.");

var sushiSets = setCollection.GetSushiList();

foreach (var item in sushiSets)
{
    Console.WriteLine(item.ToString());
}