using Sushi.BL;
ISushiSetService setCollectionService = new SushiSetService();

#region logic
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



setCollectionService.AddSet(sushiSet);
setCollectionService.AddSet(sushiSet2);

#endregion

var userWantExit = false;
while (!userWantExit) 
{
    Console.WriteLine("Нажмите 1 для вывода меню суши сетов.");
    Console.WriteLine("Нажмите 2 для просмотра заказов в корзине.");
    Console.WriteLine("Нажмите 3 для оформления заказа.");
    Console.WriteLine("Нажмите 4 для выхода.");
    var choose = int.Parse(Console.ReadKey().KeyChar.ToString());
    MainMenuHandle(choose, ref userWantExit);
}

void MainMenuHandle(int key,ref bool userWantExit) 
{
    Console.WriteLine("\n************************************");
    switch (key)
    {
        case 1: DisplaySushiSetHandle();
            break;
        case 2: DisplayOrderHandle();
            break;
        case 3: CheckoutHandle();
            break;
        case 4: ExistHandle(ref userWantExit);
            break;
        default:
            Console.WriteLine("Вы сделали неправильный выбор.");
            break;
    }
}

void DisplaySushiSetHandle() 
{
    var isBack = false;
    while (!isBack)
    {
        Console.WriteLine("\nМеню суши сетов.");
        var sushiSetList = setCollectionService.GetSushiList();
        foreach (var item in sushiSetList)
        {
            Console.WriteLine(item.ToString());
        }
        Console.WriteLine("Выберете номер суши-сета для добавения его в корзину заказов.");
        Console.WriteLine("Нажмите 0 для выхода из меню.");
        var choose = int.Parse(Console.ReadKey().KeyChar.ToString());
        if (choose == 0)
        {
            isBack = true;
        }
        else
        {
            var order = setCollectionService.AddSushiToOrder(choose);
            isBack = true;
            Console.WriteLine( "\nСуши-сет добавлен в заказ.\n");
        }
    }
    
}

void DisplayOrderHandle() 
{
    Console.WriteLine("\nВы выбрали просмотр корзины.");

    var order = setCollectionService.GetOrder(1);
    
    var sushiSetOrder = order.SushiSet;
    foreach (var item in sushiSetOrder) 
    {
        Console.WriteLine(item.ToString());
    }
}

void CheckoutHandle() 
{
    Console.WriteLine("\nВы перешли к заказу суши-сета.\n");

    var order = setCollectionService.GetOrder(1);

    Console.WriteLine("Введите Ваше имя.");
    var name = Console.ReadLine();

    Console.WriteLine("Введите Ваш адрес.");
    var adress = Console.ReadLine();

    order.PersonInfo.Name = name;

    order.PersonInfo.Adress = adress;

    Console.WriteLine("Вы оформили заказ, ожидайте доставки.");

    userWantExit = true;
}

void ExistHandle(ref bool userWantExit) 
{ 
    userWantExit = true;
    Console.WriteLine("Вы выбрали выход.");
}