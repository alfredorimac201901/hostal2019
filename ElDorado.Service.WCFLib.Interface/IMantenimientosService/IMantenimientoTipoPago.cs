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
        IEnumerable<Tipo_pago> GetTipo_pagoAll(string nombre);

        [OperationContract]
        Tipo_pago GetTipo_Pago(int id);

        [OperationContract]
        bool SaveTipoPago(Tipo_pago entity);

        [OperationContract]
        bool DeleteTipoPago(int id);


    }
}
