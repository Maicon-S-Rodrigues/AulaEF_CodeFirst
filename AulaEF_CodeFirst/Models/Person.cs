using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaEF_CodeFirst.Context
{
    internal class Person
    {
        public int    Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Mail { get; set; }

        public override string ToString()
        {
            return $"ID: {this.Id}" +
                 $"\nNome: {this.Name}" +
                 $"\nTelefone {this.Phone}" +
                 $"\nCelular: {this.Mobile}" +
                 $"\nE-mail: {this.Mail}";
        }
    }
}
