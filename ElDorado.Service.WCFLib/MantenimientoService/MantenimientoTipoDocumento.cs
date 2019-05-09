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
       public IEnumerable<Tipo_documento> GetTipo_DocumentoAll(string nombre)
        {
            ITipoDocumentoDomain domain = new TipoDocumentoDomain();
            return domain.GetTipo_Documentos(nombre);
        }
         public Tipo_documento GetTipo_Documento(int id)
        {
            ITipoDocumentoDomain domain = new TipoDocumentoDomain();
            return domain.GetTipoDocumentoById(id);
        }
    
        public bool SaveTipoDocumento(Tipo_documento entity)
        {
        ITipoDocumentoDomain domain = new TipoDocumentoDomain();
        return domain.SaveTipoDocumento(entity);
         }
        public bool DeleteTipoDocumento(int id)
        {
            ITipoDocumentoDomain domain = new TipoDocumentoDomain();
            return domain.DeleteTipoDocumento(id);
        }
    }
}
