using ElDorado.Data.Acces;
using ElDorado.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDorado.Data.Repository
{
   public class VentaRepository :GeneryRepository<Venta>, IVentaRepository
    {
        public VentaRepository(DbContext context) : base(context)
        {
        }
    }
}
