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
        IEnumerable<Habitacion> GetHabitacionAll(string nombre);

        [OperationContract]
        Habitacion GetHabitacion(int id);

        [OperationContract]
        bool SaveHabitacion(Habitacion entity);

        [OperationContract]
        bool DeleteHabitacion(int id);


    }
}
