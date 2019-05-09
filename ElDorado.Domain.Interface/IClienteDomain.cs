using ElDorado.Data.Acces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDorado.Domain.Interface
{
    public interface IClienteDomain
    {
        IEnumerable<Cliente> GetClientes(string nombre);
        Cliente GetClienteById(int id);
        bool SaveCliente(Cliente entity);
        bool DeleteCliente(int id);
    }
}
