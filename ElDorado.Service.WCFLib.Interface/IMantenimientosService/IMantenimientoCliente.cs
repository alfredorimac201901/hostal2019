using ElDorado.Data.Acces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ElDorado.Service.WCFLib.Interface
{
    
    public partial interface IMantenimientoService
    {
        [OperationContract]
        IEnumerable<Cliente> GetClientesAll(string nombre);

        [OperationContract]
        Cliente GetCliente(int id);

        [OperationContract]
        bool SaveCliente(Cliente entity);

        [OperationContract]
        bool DeleteCliente(int id);



    }
}
