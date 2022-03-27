using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._07.Task7.AssemblyOne
{
    public class Motorcycle
    {

        public const ushort MaxSpeedPublic = 300;
        protected const ushort MaxSpeedProtected = 300;
        internal const ushort MaxSpeedInternal = 300;
        protected internal const ushort MaxSpeedProtectedInternal = 300;
        private const ushort MaxSpeedPrivate = 300;
        private protected const ushort MaxSpeedPrivateProtected = 300;

        public string MakePublic = "Harley Davidson";
        protected string MakeProtected = "Harley Davidson";
        internal string MakeInternal = "Harley Davidson";
        protected internal string MakeProtectedInternal = "Harley Davidson";
        private string MakePrivate = "Harley Davidson";
        private protected string MakePrivateProtected = "Harley Davidson";

        public string ModelYearPublic { get; set; } = "2020";
        protected string ModelYearProtected { get; set; } = "2020";
        internal string ModelYearInternal { get; set; } = "2020";
        protected internal string ModelYearProtectedInternal = "2020";
        private string ModelYearPrivate = "2020";
        private protected string ModelYearPrivateProtected = "2020";

        public void StartEnginerPublic()
        {

        }

        protected void StartEnginerProtected()
        {

        }

        internal void StartEnginerInternal()
        {

        }

        protected internal void StartEnginerProtectedInternal()
        {

        }

        private void StartEnginerPrivate()
        {

        }

        private protected void StartEnginerPrivateProtected()
        {

        }
    }
}
