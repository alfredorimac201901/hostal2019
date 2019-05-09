namespace ElDorado.Data.Acces
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [DataContract]
    [Table("Tipo_comprobante")]
    public partial class Tipo_comprobante
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tipo_comprobante()
        {
            Venta = new HashSet<Venta>();
        }

        [DataMember]
        [Key]
        public int Cod_tip_com { get; set; }

        [DataMember]
        [StringLength(60)]
        public string Des_tip_com { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
