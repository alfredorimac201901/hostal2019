using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDorado.Data.Repository.Interface
{
   public interface IElDoradoUnitofWork :IDisposable
    {
        int Complete();
        IClienteRepository ClienteRepository { get; set; }
        IDetalleVentaRepository DetalleVentaRepository { get; set; }
        IEmpleadoRepository EmpleadoRepository { get; set; }
        IEstadoHabitacionRepository EstadoHabitacionRepository { get; set; }
        IHabitacionRepository HabitacionRepository { get; set; }
        ITipoComprobanteRepository TipoComprobanteRepository { get; set; }
        ITipoDocumentoRepository TipoDocumentoRepository { get; set; }
        ITipoEmpleadoRepository TipoEmpleadoRepository { get; set; }
        ITipoHabitacionRepository TipoHabitacionRepository { get; set; }
        ITipoPagoRepository TipoPagoRepository { get; set; }
        IVentaRepository VentaRepository { get; set; }

    }
}
