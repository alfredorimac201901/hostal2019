using ElDorado.Data.Acces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ElDorado.Service.WCFLib.Interface
{
    
    public partial interface IMantenimientoService
    {
        [OperationContract]
        IEnumerable<Tipo_habitacion> GetTipo_HabitacionAll(string nombre);

        [OperationContract]
        Tipo_habitacion GetTipo_Habitacion(int id);

        [OperationContract]
        bool SaveTipoHabitacion(Tipo_habitacion entity);

        [OperationContract]
        bool DeleteTipoHabitacion(int id);


    }
}
