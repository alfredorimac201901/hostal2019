namespace ElDorado.Data.Acces
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [DataContract]
    [Table("Tipo_habitacion")]
    public partial class Tipo_habitacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tipo_habitacion()
        {
            Habitacion = new HashSet<Habitacion>();
        }

        [DataMember]
        [Key]
        public int Cod_tip_hab { get; set; }

        [DataMember]
        [StringLength(100)]
        public string Des_tip_hab { get; set; }

        [DataMember]
        public int? Pre_tip_hab { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Habitacion> Habitacion { get; set; }
    }
}
