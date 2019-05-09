using System;
using System.Collections.Generic;
using ElDorado.Data.Acces;
using ElDorado.Data.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ElDorado.Repository.Test
{
    [TestClass]
    public class EstadoHabitacionRepositoryTest
    {
        [TestMethod]
        public void EstadoHabitacionCountUW()
        {
            var count = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                count = unitofwork.EstadoHabitacionRepository.Count();
            }
            Assert.IsTrue(count > 0);
        }

        [TestMethod]
        public void EstadoHabitacionInsertUW()
        {
            int result = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                var entity = new Estado_habitacion();
                entity.Des_est_hab = "Desabilitado";
                unitofwork.EstadoHabitacionRepository.Add(entity);
                result = unitofwork.Complete();

            }
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void EstadoHabitacionUpdateUW()
        {
            int result = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                var entity = new Estado_habitacion();
                entity.Cod_est_hab = 5;
                entity.Des_est_hab = "Casi Listo";
                unitofwork.EstadoHabitacionRepository.Update(entity);
                result = unitofwork.Complete();

            }
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void EstadoHabitacionDeleteUW()
        {
            int result = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                var entity = new Estado_habitacion();
                entity.Cod_est_hab = 5;
                unitofwork.EstadoHabitacionRepository.Remove(entity);
                result = unitofwork.Complete();

            }
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void EstadoHabitacionGetUW()
        {
            Estado_habitacion result = null;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                result = unitofwork.EstadoHabitacionRepository.GetById<int>(1);
            }
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void EstadoHabitacionGetAllUW()
        {
            List<Estado_habitacion> result = null;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                result = unitofwork.EstadoHabitacionRepository.GetAll();
            }
            Assert.IsNotNull(result);

        }

    }
}
