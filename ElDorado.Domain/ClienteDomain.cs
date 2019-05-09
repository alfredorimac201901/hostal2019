using ElDorado.Data.Acces;
using ElDorado.Data.Repository;
using ElDorado.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDorado.Domain
{
    public class ClienteDomain : IClienteDomain
    {
        public bool DeleteCliente(int id)
        {
            using (var uw = new ElDoradoUnitOfWork())
            {
                return uw.ClienteRepository.Remove(new Cliente() { Cod_cli = id });
            }
        }

        public Cliente GetClienteById(int id)
        {
            using (var uw = new ElDoradoUnitOfWork())
            {
                return uw.ClienteRepository.GetById<int>(id);
            }
        }

        public IEnumerable<Cliente> GetClientes(string nombre)
        {
            using (var uw = new ElDoradoUnitOfWork())
            {
                return uw.ClienteRepository.GetAll();
            }
        }

        public bool SaveCliente(Cliente entity)
        {
            bool result = false;
            try
            {
                using (var uw = new ElDoradoUnitOfWork())
                {
                    //nuevo registro
                    if (entity.Cod_cli == 0)
                    {
                        uw.ClienteRepository.Add(entity);
                    }
                    else
                    {
                        uw.ClienteRepository.Update(entity);
                    }
                    uw.Complete();
                }
                result = true;
            }
            catch (Exception ex)
            {


            }
            return result;
        }
    }
}
