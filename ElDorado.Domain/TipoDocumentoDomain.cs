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
    public class TipoDocumentoDomain : ITipoDocumentoDomain
    {
        public bool DeleteTipoDocumento(int id)
        {
            using (var uw = new ElDoradoUnitOfWork())
            {
                return uw.TipoDocumentoRepository.Remove(new Tipo_documento { Cod_tip_doc = id });
            }
        }

        public Tipo_documento GetTipoDocumentoById(int id)
        {
            using (var uw = new ElDoradoUnitOfWork())
            {
                return uw.TipoDocumentoRepository.GetById<int>(id);
            }
        }

        public IEnumerable<Tipo_documento> GetTipo_Documentos(string nombre)
        {
            using (var uw = new ElDoradoUnitOfWork())
            {
                return uw.TipoDocumentoRepository.GetAll();
            }
        }

        public bool SaveTipoDocumento(Tipo_documento entity)
        {
            bool result = false;
            try
            {
                using (var uw = new ElDoradoUnitOfWork())
                {
                    if (entity.Cod_tip_doc == 0)
                    {
                        uw.TipoDocumentoRepository.Add(entity);
                    }
                    else
                    {
                        uw.TipoDocumentoRepository.Update(entity);
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
