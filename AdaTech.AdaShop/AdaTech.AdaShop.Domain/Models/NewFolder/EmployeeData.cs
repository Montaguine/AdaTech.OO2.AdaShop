using AdaTech.AdaShop.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.AdaShop.Domain.Models.NewFolder
{
    public abstract class EmployeeData : IEntity
    {
        public static int IdCount;
        public string ID { get; private set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Niss { get; set; }

        //CONTRUTOR INCREMENTAR IdCount e atribuir a ID

        public EmployeeData(string name, string cpf, string niss) 
        {
            IdCount++;
            ID = IdCount.ToString();
            Name = name;
            CPF = cpf;
            Niss = niss;
        }
    }
}
