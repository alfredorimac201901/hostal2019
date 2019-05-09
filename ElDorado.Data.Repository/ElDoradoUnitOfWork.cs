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
    public class ElDoradoUnitOfWork : IElDoradoUnitofWork
    {
        private readonly DbContext _context;
        public IClienteRepository ClienteRepository { get ; set; }
        public IDetalleVentaRepository DetalleVentaRepository { get; set; }
        public IEmpleadoRepository EmpleadoRepository { get; set; }
        public IEstadoHabitacionRepository EstadoHabitacionRepository { get; set; }
        public IHabitacionRepository HabitacionRepository { get; set; }
        public ITipoComprobanteRepository TipoComprobanteRepository { get; set; }
        public ITipoDocumentoRepository TipoDocumentoRepository { get; set; }
        public ITipoEmpleadoRepository TipoEmpleadoRepository { get; set; }
        public ITipoHabitacionRepository TipoHabitacionRepository { get; set; }
        public ITipoPagoRepository TipoPagoRepository { get; set; }
        public IVentaRepository VentaRepository { get; set; }

        public ElDoradoUnitOfWork()
        {
            _context = new DatoModelo();
            this.ClienteRepository = new ClienteRepository(_context);
            this.DetalleVentaRepository = new DetalleVentaRepository(_context);
            this.EmpleadoRepository = new EmpleadoRepository(_context);
            this.EstadoHabitacionRepository = new EstadoHabitacionRepository(_context);
            this.HabitacionRepository = new HabitacionRepository(_context);
            this.TipoComprobanteRepository = new TipoComprobanteRepository(_context);
            this.TipoDocumentoRepository = new TipoDocumentoRepository(_context);
            this.TipoEmpleadoRepository = new TipoEmpleadoRepository(_context);
            this.TipoHabitacionRepository = new TipoHabitacionRepository(_context);
            this.TipoPagoRepository = new TipoPagoRepository(_context);
            this.VentaRepository = new VentaRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
