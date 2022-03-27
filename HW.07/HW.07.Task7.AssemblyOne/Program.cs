using HW._07.Task7.AssemblyOne;

var moto = new Motorcycle();

ushort maxSpeedPublic = Motorcycle.MaxSpeedPublic;
//ushort maxSpeedProtected = Motorcycle.MaxSpeedProtected; is inaccessible due to its protection level
ushort maxSpeedInternal = Motorcycle.MaxSpeedInternal;
ushort maxSpeedProtectedInternal = Motorcycle.MaxSpeedProtectedInternal;
//ushort maxSpeedPrivate = Motorcycle.MaxSpeedPrivate; is inaccessible due to its protection level
//ushort maxSpeedPrivateProtected = Motorcycle.MaxSpeedPrivateProtected; is inaccessible due to its protection level

moto.MakePublic = "Harley Davidson";
//moto.MakeProtected = "Harley Davidson"; is inaccessible due to its protection level
moto.MakeInternal = "Harley Davidson";
moto.MakeProtectedInternal = "Harley Davidson";
//moto.MakePrivate = "Harley Davidson"; is inaccessible due to its protection level
//moto.MakePrivateProtected = "Harley Davidson"; is inaccessible due to its protection level

moto.ModelYearPublic = "2020";
//moto.ModelYearProtected = "2020"; is inaccessible due to its protection level
moto.ModelYearInternal = "2020";
moto.ModelYearProtectedInternal = "2020";
//moto.ModelYearPrivate = "2020"; is inaccessible due to its protection level
//moto.ModelYearPrivateProtected = "2020"; is inaccessible due to its protection level

moto.StartEnginerPublic();
//moto.StartEnginerProtected(); is inaccessible due to its protection level
moto.StartEnginerInternal();
moto.StartEnginerProtectedInternal();
//moto.StartEnginerPrivate(); is inaccessible due to its protection level
//moto.StartEnginerPrivateProtected(); is inaccessible due to its protection level

var roadBike = new RoadBike();
