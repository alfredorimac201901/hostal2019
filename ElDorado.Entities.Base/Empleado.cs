namespace ElDorado.Data.Acces
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [DataContract]
    [Table("Empleado")]
    public partial class Empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleado()
        {
            Venta = new HashSet<Venta>();
        }

        [DataMember]
        [Key]
        public int Cod_emp { get; set; }

        [DataMember]
        public int? Cod_tip_emp { get; set; }

        [DataMember]
        [StringLength(50)]
        public string Nom_emp { get; set; }

        [DataMember]
        [StringLength(50)]
        public string Ape_pat_emp { get; set; }

        [DataMember]
        [StringLength(50)]
        public string Ape_mat_emp { get; set; }

        [DataMember]
        [StringLength(50)]
        public string Dir_emp { get; set; }

        [DataMember]
        [StringLength(50)]
        public string Dis_emp { get; set; }

        [DataMember]
        [StringLength(50)]
        public string Dep_emp { get; set; }

        [DataMember]
        [Column(TypeName = "date")]
        public DateTime? Fec_emp { get; set; }

        [DataMember]   
        public int? Cod_tip_doc { get; set; }

        [DataMember]
        public int? Cel_emp { get; set; }

        [DataMember]
        public virtual Tipo_empleado Tipo_empleado { get; set; }

        [DataMember]
        public virtual Tipo_documento Tipo_documento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
