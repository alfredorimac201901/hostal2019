using ElDorado.Data.Acces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDorado.Domain.Interface
{
    public interface ITipoDocumentoDomain
    {

        IEnumerable<Tipo_documento> GetTipo_Documentos(string nombre);
        Tipo_documento GetTipoDocumentoById(int id);
        bool SaveTipoDocumento(Tipo_documento entity);
        bool DeleteTipoDocumento(int id);
    }
}
