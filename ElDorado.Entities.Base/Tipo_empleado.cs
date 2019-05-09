namespace ElDorado.Data.Acces
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [DataContract]
    [Table("Tipo_empleado")]
    public partial class Tipo_empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tipo_empleado()
        {
            Empleado = new HashSet<Empleado>();
        }

        [DataMember]
        [Key]
        public int Cod_tip_emp { get; set; }

        [DataMember]
        [StringLength(50)]
        public string Des_tip_emp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empleado> Empleado { get; set; }
    }
}
