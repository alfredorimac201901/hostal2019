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
        IEnumerable<Tipo_documento> GetTipo_DocumentoAll(string nombre);

        [OperationContract]
        Tipo_documento GetTipo_Documento(int id);

        [OperationContract]
        bool SaveTipoDocumento(Tipo_documento entity);

        [OperationContract]
        bool DeleteTipoDocumento(int id);


    }
}
