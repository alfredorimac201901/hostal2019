using System;
using System.Collections.Generic;
using ElDorado.Data.Acces;
using ElDorado.Data.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ElDorado.Repository.Test
{
    [TestClass]
    public class TipoEmpleadoRepositoryTest
    {
        [TestMethod]
        public void TipoEmpleadoCountUW()
        {
            var count = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                count = unitofwork.TipoEmpleadoRepository.Count();
            }
            Assert.IsTrue(count > 0);
        }

        [TestMethod]
        public void TipoEmpleadoInsertUW()
        {
            int result = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                var entity = new Tipo_empleado();
                entity.Des_tip_emp = "Chacalon";
                unitofwork.TipoEmpleadoRepository.Add(entity);
                result = unitofwork.Complete();

            }
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void TipoEmpleadoUpdateUW()
        {
            int result = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                var entity = new Tipo_empleado();
                entity.Cod_tip_emp = 4;
                entity.Des_tip_emp = "Chacal";
                unitofwork.TipoEmpleadoRepository.Update(entity);
                result = unitofwork.Complete();

            }
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void TipoEmpleadoDeleteUW()
        {
            int result = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                var entity = new Tipo_empleado();
                entity.Cod_tip_emp = 4;
                unitofwork.TipoEmpleadoRepository.Remove(entity);
                result = unitofwork.Complete();

            }
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void TipoEmpleadoGetUW()
        {
            Tipo_empleado result = null;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                result = unitofwork.TipoEmpleadoRepository.GetById<int>(1);
            }
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TipoEmpleadoGetAllUW()
        {
            List<Tipo_empleado> result = null;


            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                result = unitofwork.TipoEmpleadoRepository.GetAll();
            }
            Assert.IsNotNull(result);
        }



    }
}
