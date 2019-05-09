namespace ElDorado.Data.Acces
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [DataContract]
    [Table("Cliente")]
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            Venta = new HashSet<Venta>();
        }

        [DataMember]
        [Key]
        public int Cod_cli { get; set; }

        [DataMember]
        [StringLength(50)]
        public string Nom_cli { get; set; }

        [StringLength(50)]
        public string Ape_pat_cli { get; set; }

        [StringLength(50)]
        public string Ape_mat_cli { get; set; }

        [DataMember]
        [StringLength(80)]
        public string Dir_cli { get; set; }

        [DataMember]
        [StringLength(50)]
        public string Dis_cli { get; set; }

        [DataMember]
        [StringLength(50)]
        public string Dep_cli { get; set; }

        [DataMember]
        [StringLength(50)]
        public string Pai_cli { get; set; }


        [DataMember]
        public int? Cod_tip_doc { get; set; }

        [DataMember]
        [Column(TypeName = "date")]
        public DateTime? Fec_nac_cli { get; set; }

        [DataMember]
        public int? Cel_cli { get; set; }

        [DataMember]
        [StringLength(50)]
        public string Ema_cli { get; set; }

        [DataMember]
        public virtual Tipo_documento Tipo_documento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
