using ElDorado.Data.Acces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ElDorado.Service.WCFLib.Interface
{
    
    public partial interface IMantenimientoDetalleVenta
    {
        [OperationContract]
        IEnumerable<Detalle_venta> GetDetalle_VentaAll(string nombre);

        [OperationContract]
        Detalle_venta GetDetalle_Venta(int id);

        [OperationContract]
        bool SaveDetalleVenta(Detalle_venta entity);

        [OperationContract]
        bool DeleteDetalleVenta(int id);


    }
}
