using ElDorado.Data.Acces;
using ElDorado.Domain;
using ElDorado.Domain.Interface;
using ElDorado.Service.WCFLib.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDorado.Service.WCFLib
{
    public partial class MantenimientoService : IMantenimientoService
    {
        public bool DeleteCliente(int id)
        {
            IClienteDomain domain = new ClienteDomain();
            return domain.DeleteCliente(id);
        }

        public Cliente GetCliente(int id)
        {
            IClienteDomain domain = new ClienteDomain();
            return domain.GetClienteById(id);
        }

        public IEnumerable<Cliente> GetClientesAll(string nombre)
        {
            IClienteDomain domain = new ClienteDomain();
            return domain.GetClientes(nombre);
        }

        public bool SaveCliente(Cliente entity)
        {
            IClienteDomain domain = new ClienteDomain();
            return domain.SaveCliente(entity);
        }



    }
}
