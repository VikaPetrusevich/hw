using Motorcycle.BL;

var motoModel = new MotoModel()
{
    Id = Guid.NewGuid(),
    Name = "BMV",
    Model = "X350",
    Year = 2021,
    Odometer = 65
};

var motoModel2 = new MotoModel()
{
    Id = Guid.NewGuid(),
    Name = "Honda",
    Model = "M666",
    Year = 2020,
    Odometer = 90
};

var motoModel3 = new MotoModel()
{
    Id = Guid.NewGuid(),
    Name = "Suzuki",
    Model = "KL80",
    Year = 2021,
    Odometer = 70
};

var motoModel4 = new MotoModel()
{
    Id = Guid.NewGuid(),
    Name = "Yamaha",
    Model = "S500",
    Year = 2022,
    Odometer = 20
};

var motoModel5 = new MotoModel()
{
    Id = Guid.NewGuid(),
    Name = "Kawasaki",
    Model = "JK450",
    Year = 2020,
    Odometer = 90
};

IStoreService service = new StoreServis();

service.AddMoto(motoModel);
service.AddMoto(motoModel2);
service.AddMoto(motoModel3);
service.AddMoto(motoModel4);
service.AddMoto(motoModel5);

Console.WriteLine("Return all.");

var motos = service.GetMotoList();

foreach (var item in motos)
{
    Console.WriteLine(item.ToString());
}

Console.WriteLine("Return by Id.");

var motoById = service.GetMotoById(motoModel3.Id);

Console.WriteLine(motoById);

Console.WriteLine("Delete by Id.");

service.Delete(motoModel5.Id);

motos = service.GetMotoList();

foreach (var item in motos)
{
    Console.WriteLine(item.ToString());
}

Console.WriteLine("Update moto by Id.");

var motoModel6 = new MotoModel()
{
    Id = motoModel4.Id,
    Name = "Minsk",
    Model = "A100",
    Year = 2020,
    Odometer = 100
};

service.Update(motoModel6);

motos = service.GetMotoList();

foreach (var item in motos)
{
    Console.WriteLine(item.ToString());
}