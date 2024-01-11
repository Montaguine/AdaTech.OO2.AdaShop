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
        public static int IdCount = 0;
        public string ID { get; private set; }
        string Nome { get; set; }
        string CPF { get; set; }
        string Niss { get; set; }

        //CONTRUTOR INCREMENTAR IdCount e atribuir a ID
    }
}
