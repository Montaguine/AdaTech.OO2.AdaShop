using AdaTech.AdaShop.Domain.Contracts;
using AdaTech.AdaShop.Domain.Models.NewFolder;

namespace AdaTech.AdaShop.Domain.Models.Order
{
    //Emploee herda de uma interface IEntity, logo é obrigado a seguir o contrato de IEntity.
    //Ou seja, deve implementar os métodos e propriedade da interface IEntity
    public class Employee : EmployeeData
    {
        public Employee(string name, string cpf, string niss) : base(name, cpf, niss)
        {
        }
    }
}