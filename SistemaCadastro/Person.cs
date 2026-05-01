using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastro
{
    internal class Person
    {
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string Telephone { get; set; }
        public char Sex { get; set; }
        public bool IsOwnHome { get; set; }
        public bool IsOwnVehicle { get; set; }
    }
}
