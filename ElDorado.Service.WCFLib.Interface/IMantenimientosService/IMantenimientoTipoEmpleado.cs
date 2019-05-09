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
        IEnumerable<Tipo_empleado> GetTipo_EmpleadoAll(string nombre);

        [OperationContract]
        Tipo_empleado GetTipo_Empleado(int id);

        [OperationContract]
        bool SaveTipoEmpleado(Tipo_empleado entity);

        [OperationContract]
        bool DeleteTipoEmpleado(int id);


    }
}
