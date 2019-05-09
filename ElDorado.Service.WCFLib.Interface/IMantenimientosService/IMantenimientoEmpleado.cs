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
        IEnumerable<Empleado> GetEmpleadoAll(string nombre);

        [OperationContract]
        Empleado GetEmpleado(int id);

        [OperationContract]
        bool SaveEmpleado(Empleado entity);

        [OperationContract]
        bool DeleteEmpleado(int id);


    }
}
