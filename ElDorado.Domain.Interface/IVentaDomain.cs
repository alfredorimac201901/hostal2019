using ElDorado.Data.Acces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDorado.Domain.Interface
{
    public interface IVentaDomain
    {
        IEnumerable<Venta> GetVentas(string nombre);
        Venta GetVentaById(int id);
        bool SaveVenta(Venta entity);
        bool DeleteVenta(int id);
    }
}
