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
        IEnumerable<Tipo_comprobante> GetTipo_ComprobanteAll(string nombre);

        [OperationContract]
        Tipo_comprobante GetTipo_Comprobante(int id);

        [OperationContract]
        bool SaveTipoComprobante(Tipo_comprobante entity);

        [OperationContract]
        bool DeleteTipoComprobante(int id);


    }
}
