namespace ElDorado.Data.Acces
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DatoModelo : DbContext
    {
        public DatoModelo()
            : base("name=cnxDatoModelo")
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Detalle_venta> Detalle_venta { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Estado_habitacion> Estado_habitacion { get; set; }
        public virtual DbSet<Habitacion> Habitacion { get; set; }
        public virtual DbSet<Tipo_comprobante> Tipo_comprobante { get; set; }
        public virtual DbSet<Tipo_documento> Tipo_documento { get; set; }
        public virtual DbSet<Tipo_empleado> Tipo_empleado { get; set; }
        public virtual DbSet<Tipo_habitacion> Tipo_habitacion { get; set; }
        public virtual DbSet<Tipo_pago> Tipo_pago { get; set; }
        public virtual DbSet<Venta> Venta { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .Property(e => e.Nom_cli)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Ape_pat_cli)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Ape_mat_cli)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Dir_cli)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Dis_cli)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Dep_cli)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Pai_cli)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Ema_cli)
                .IsUnicode(false);

            modelBuilder.Entity<Detalle_venta>()
                .Property(e => e.Hor_ing_det_ven)
                .IsUnicode(false);

            modelBuilder.Entity<Detalle_venta>()
                .Property(e => e.Hor_sal_det_ven)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Nom_emp)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Ape_pat_emp)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Ape_mat_emp)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Dir_emp)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Dis_emp)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Dep_emp)
                .IsUnicode(false);

            modelBuilder.Entity<Estado_habitacion>()
                .Property(e => e.Des_est_hab)
                .IsUnicode(false);

            modelBuilder.Entity<Habitacion>()
                .Property(e => e.Num_hab)
                .IsUnicode(false);

            modelBuilder.Entity<Tipo_comprobante>()
                .Property(e => e.Des_tip_com)
                .IsUnicode(false);

            modelBuilder.Entity<Tipo_documento>()
                .Property(e => e.Des_tip_doc)
                .IsUnicode(false);

            modelBuilder.Entity<Tipo_empleado>()
                .Property(e => e.Des_tip_emp)
                .IsUnicode(false);

            modelBuilder.Entity<Tipo_habitacion>()
                .Property(e => e.Des_tip_hab)
                .IsUnicode(false);

            modelBuilder.Entity<Tipo_pago>()
                .Property(e => e.Des_tip_pag)
                .IsUnicode(false);

            modelBuilder.Entity<Venta>()
                .Property(e => e.Tot_ven)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Venta>()
                .Property(e => e.Est_ven)
                .IsUnicode(false);

            modelBuilder.Entity<Venta>()
                .Property(e => e.Sub__tot_ven)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Venta>()
                .Property(e => e.Igv_ven)
                .HasPrecision(18, 0);
        }
    }
}
