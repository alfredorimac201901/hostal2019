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
        IEnumerable<Estado_habitacion> GetEstado_HabitacionAll(string nombre);

        [OperationContract]
        Estado_habitacion GetEstado_Habitacion(int id);

        [OperationContract]
        bool SaveEstadoHabitacion(Estado_habitacion entity);

        [OperationContract]
        bool DeleteEstadoHabitacion(int id);



    }
}
