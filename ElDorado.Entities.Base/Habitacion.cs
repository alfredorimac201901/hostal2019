namespace ElDorado.Data.Acces
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [DataContract]
    [Table("Habitacion")]
    public partial class Habitacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Habitacion()
        {
            Detalle_venta = new HashSet<Detalle_venta>();
        }

        [DataMember]
        [Key]
        public int Cod_hab { get; set; }

        [DataMember]
        [StringLength(30)]
        public string Num_hab { get; set; }

        [DataMember]
        public int? Cod_tip_hab { get; set; }

        public int? Cod_est_hab { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_venta> Detalle_venta { get; set; }

        [DataMember]
        public virtual Estado_habitacion Estado_habitacion { get; set; }

        [DataMember]
        public virtual Tipo_habitacion Tipo_habitacion { get; set; }
    }
}
