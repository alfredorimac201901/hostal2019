namespace ElDorado.Data.Acces
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [DataContract]
    [Table("Tipo_pago")]
    public partial class Tipo_pago
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tipo_pago()
        {
            Venta = new HashSet<Venta>();
        }

        [DataMember]
        [Key]
        public int Cod_tip_pag { get; set; }

        [DataMember]
        [StringLength(40)]
        public string Des_tip_pag { get; set; }

        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
