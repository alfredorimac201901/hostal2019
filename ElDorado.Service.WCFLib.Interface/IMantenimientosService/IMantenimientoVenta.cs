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
        IEnumerable<Venta> GetVentaAll(string nombre);

        [OperationContract]
        Venta GetVenta(int id);

        [OperationContract]
        bool SaveVenta(Venta entity);

        [OperationContract]
        bool DeleteVenta(int id);

    }
}
