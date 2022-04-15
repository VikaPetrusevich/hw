using AvtoStore.BL;

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

IMotoStoreService serviceMoto = new MotoStoreService();

serviceMoto.AddMoto(motoModel);
serviceMoto.AddMoto(motoModel2);
serviceMoto.AddMoto(motoModel3);
serviceMoto.AddMoto(motoModel4);

Console.WriteLine("Return all moto.");

var motos = serviceMoto.GetMotoList();

foreach (var item in motos)
{
    Console.WriteLine(item.ToString());
}

Console.WriteLine("Return moto model №2 by Id.");

var motoById = serviceMoto.GetMotoById(motoModel2.Id);

Console.WriteLine(motoById);

Console.WriteLine("Delete moto model №1 by Id.");

serviceMoto.DeleteMoto(motoModel.Id);

motos = serviceMoto.GetMotoList();

foreach (var item in motos)
{
    Console.WriteLine(item.ToString());
}

Console.WriteLine("Update moto by Id №3.");

var motoModel5 = new MotoModel()
{
    Id = motoModel3.Id,
    Name = "Minsk",
    Model = "A100",
    Year = 2020,
    Odometer = 100
};

serviceMoto.UpdateMoto(motoModel5);

motos = serviceMoto.GetMotoList();

foreach (var item in motos)
{
    Console.WriteLine(item.ToString());
}

var carModel = new CarModel()
{
    Id = Guid.NewGuid(),
    Name = "Skoda",
    Model = "H400X",
    Year = 2022,
    Odometer = 25
};

var carModel2 = new CarModel() 
{
    Id = Guid.NewGuid(),
    Name = "Audi",
    Model = "A100",
    Year = 2020,
    Odometer = 100
};

var carModel3 = new CarModel() 
{
    Id = Guid.NewGuid(),
    Name = "Renault",
    Model = "F850",
    Year = 2021,
    Odometer = 50
};

var carModel4 = new CarModel()
{
    Id = Guid.NewGuid(),
    Name = "Kia",
    Model = "J10AK",
    Year = 2022,
    Odometer = 30
};

ICarStoreService serviceCar = new CarStoreService();

serviceCar.AddCar(carModel);
serviceCar.AddCar(carModel2);
serviceCar.AddCar(carModel3);
serviceCar.AddCar(carModel4);

Console.WriteLine("Return all car.");

var cars = serviceCar.GetCarList();

foreach (var item in cars)
{
    Console.WriteLine(item.ToString());
}

Console.WriteLine("Return car model №3 by Id.");

var carById = serviceCar.GetCarById(carModel3.Id);

Console.WriteLine(carById);

Console.WriteLine("Delete car model №2 by Id.");

serviceCar.DeleteCar(carModel2.Id);

cars = serviceCar.GetCarList();

foreach (var item in cars)
{
    Console.WriteLine(item.ToString());
}

Console.WriteLine("Update car by Id №1.");

var carModel5 = new CarModel()
{
    Id = carModel.Id,
    Name = "Ford",
    Model = "R555",
    Year = 2021,
    Odometer = 80
};

serviceCar.UpdateCar(carModel5);

cars = serviceCar.GetCarList();

foreach (var item in cars)
{
    Console.WriteLine(item.ToString());
}

Console.WriteLine("Catch exception get car by id.");
try
{
    var carByIdException = serviceCar.GetCarById(Guid.NewGuid());
}
catch (TransportNotFoundException ex)
{

    Console.WriteLine(ex.Message);
}

Console.WriteLine("Catch exception update car.");
try
{
    var carModel6 = new CarModel()
    {
        Id = Guid.NewGuid(),
        Name = "Ford",
        Model = "R555",
        Year = 2021,
        Odometer = 80
    };

    serviceCar.UpdateCar(carModel6);
}
catch (TransportNotFoundException ex)
{

    Console.WriteLine(ex.Message);
}