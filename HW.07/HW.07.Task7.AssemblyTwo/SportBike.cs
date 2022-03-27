using HW._07.Task7.AssemblyOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._07.Task7.AssemblyTwo
{
    internal class SportBike : Motorcycle
    { 
        public SportBike()
        {
            ushort maxSpeedPublic = Motorcycle.MaxSpeedPublic;
            ushort maxSpeedProtected = Motorcycle.MaxSpeedProtected; 
            //ushort maxSpeedInternal = Motorcycle.MaxSpeedInternal; is inaccessible due to its protection level
            ushort maxSpeedProtectedInternal = Motorcycle.MaxSpeedProtectedInternal;
            //ushort maxSpeedPrivate = Motorcycle.MaxSpeedPrivate; is inaccessible due to its protection level
            //ushort maxSpeedPrivateProtected = Motorcycle.MaxSpeedPrivateProtected; is inaccessible due to its protection level


            this.MakePublic = "Harley Davidson";
            this.MakeProtected = "Harley Davidson";
            //this.MakeInternal = "Harley Davidson"; is inaccessible due to its protection level
            this.MakeProtectedInternal = "Harley Davidson";
            //this.MakePrivate = "Harley Davidson";is inaccessible due to its protection level
            //this.MakePrivateProtected = "Harley Davidson"; is inaccessible due to its protection level

            this.ModelYearPublic = "2020";
            this.ModelYearProtected = "2020"; 
            //this.ModelYearInternal = "2020"; is inaccessible due to its protection level
            this.ModelYearProtectedInternal = "2020";
            //this.ModelYearPrivate = "2020"; is inaccessible due to its protection level
            //this.ModelYearPrivateProtected = "2020"; is inaccessible due to its protection level

            StartEnginerPublic();
            StartEnginerProtected(); 
            //StartEnginerInternal(); is inaccessible due to its protection level
            StartEnginerProtectedInternal();
            //StartEnginerPrivate(); is inaccessible due to its protection level
            //StartEnginerPrivateProtected(); is inaccessible due to its protection level
        }
    }
}
