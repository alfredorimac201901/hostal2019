namespace ElDorado.Data.Acces
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [DataContract]
    [Table("Venta")]
    public partial class Venta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Venta()
        {
            Detalle_venta = new HashSet<Detalle_venta>();
        }

        [DataMember]
        [Key]
        public int Cod_ven { get; set; }

        [DataMember]
        public int? Cod_tip_com { get; set; }

        [DataMember]
        public int? Cod_cli { get; set; }

        [DataMember]
        public int? Cod_emp { get; set; }

        [DataMember]
        public int? Cod_tip_pag { get; set; }

        [DataMember]
        [Column(TypeName = "date")]
        public DateTime? Fec_ven { get; set; }

        [DataMember]
        public decimal? Tot_ven { get; set; }

        [DataMember]
        [StringLength(40)]
        public string Est_ven { get; set; }

        [DataMember]
        public decimal? Sub__tot_ven { get; set; }

        [DataMember]
        public decimal? Igv_ven { get; set; }

        [DataMember]
        public virtual Cliente Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_venta> Detalle_venta { get; set; }

        [DataMember]
        public virtual Empleado Empleado { get; set; }

        [DataMember]
        public virtual Tipo_comprobante Tipo_comprobante { get; set; }

        [DataMember]
        public virtual Tipo_pago Tipo_pago { get; set; }
    }
}
