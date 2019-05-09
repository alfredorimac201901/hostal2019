using System;
using System.Collections.Generic;
using ElDorado.Data.Acces;
using ElDorado.Data.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ElDorado.Repository.Test
{
    [TestClass]
    public class TipoHabitacionRepositoryTest
    {
        [TestMethod]
        public void TipoHabitacionCountUW()
        {
            var count = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                count = unitofwork.TipoHabitacionRepository.Count();
            }
            Assert.IsTrue(count > 0);
        }

        [TestMethod]
        public void TipoHabitacionInsertUW()
        {
            int result = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                var entity = new Tipo_habitacion();
                entity.Des_tip_hab = "Turistas";
                entity.Pre_tip_hab = 80;
                unitofwork.TipoHabitacionRepository.Add(entity);
                result = unitofwork.Complete();

            }
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void TipoHabitacionUpdateUW()
        {
            int result = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                var entity = new Tipo_habitacion();
                entity.Cod_tip_hab = 5;
                entity.Des_tip_hab = "Turistas solas";
                entity.Pre_tip_hab = 70;
                unitofwork.TipoHabitacionRepository.Update(entity);
                result = unitofwork.Complete();

            }
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void TipoHabitacionDeleteUW()
        {
            int result = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                var entity = new Tipo_habitacion();
                entity.Cod_tip_hab = 5;
                unitofwork.TipoHabitacionRepository.Remove(entity);
                result = unitofwork.Complete();

            }
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void TipoHabitacionGetUW()
        {
            Tipo_habitacion result = null;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                result = unitofwork.TipoHabitacionRepository.GetById<int>(1);
            }
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TipoHabitacionGetAllUW()
        {
            List<Tipo_habitacion> result = null;


            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                result = unitofwork.TipoHabitacionRepository.GetAll();
            }
            Assert.IsNotNull(result);
        }
    }
}
