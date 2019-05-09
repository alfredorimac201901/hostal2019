namespace ElDorado.Data.Acces
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [DataContract]
    [Table("Detalle_venta")]
    public partial class Detalle_venta
    {
        [DataMember]
        [Key]
        public int Ite_det_ven { get; set; }
        [DataMember]
        public int? Cod_ven { get; set; }
        [DataMember]
        public int? Cod_hab { get; set; }
        [DataMember]
        public int? Cant_dia_det_ven { get; set; }
        [DataMember]
        [StringLength(50)]
        public string Hor_ing_det_ven { get; set; }
        [DataMember]
        [StringLength(50)]
        public string Hor_sal_det_ven { get; set; }
        [DataMember]
        public virtual Habitacion Habitacion { get; set; }
        [DataMember]
        public virtual Venta Venta { get; set; }
    }
}
