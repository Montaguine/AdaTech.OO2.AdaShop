using AdaTech.AdaShop.Domain.Contracts;
using System.Reflection.Metadata.Ecma335;

namespace AdaTech.AdaShop.Domain.Models.Order
{
    public class Customer : IEntity
    {
        public string ID { get; private set; }
        public string CPF { get => CPF; private set { CPF = value; ID = value; } }
        public string Name { get; private set; }


        public Customer(string cpf, string name)
        {
            CPF = cpf;
            Name = name;
        }

        //Podem ser adicionadas:
        //DATA NASCIMENTO
        //ENDERECO
    }
}