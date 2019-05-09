using System;
using System.Collections.Generic;
using ElDorado.Data.Acces;
using ElDorado.Data.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ElDorado.Repository.Test
{
    [TestClass]
    public class HabitacionRepositoryTest
    {
        [TestMethod]
        public void HabitacionCountUW()
        {
            var count = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                count = unitofwork.HabitacionRepository.Count();
            }
            Assert.IsTrue(count > 0);
        }
        [TestMethod]
        public void HabitacionInsertUW()
        {
            int result = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                var entity = new Habitacion();
                entity.Num_hab = "F101";
                entity.Cod_tip_hab = 2;
                entity.Cod_est_hab = 2;
                unitofwork.HabitacionRepository.Add(entity);
                result = unitofwork.Complete();

            }
            Assert.IsTrue(result > 0);
        }


        [TestMethod]
        public void HabitacionUpdateUW()
        {
            int result = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                var entity = new Habitacion();
                entity.Cod_hab = 9;
                entity.Num_hab = "F103";
                entity.Cod_tip_hab = 2;
                entity.Cod_est_hab = 2;
                unitofwork.HabitacionRepository.Update(entity);
                result = unitofwork.Complete();

            }
            Assert.IsTrue(result > 0);
        }
        [TestMethod]
        public void HabitacionDeleteUW()
        {
            int result = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                var entity = new Habitacion();
                entity.Cod_hab = 18;
                unitofwork.HabitacionRepository.Remove(entity);
                result = unitofwork.Complete();

            }
            Assert.IsTrue(result > 0);
        }
        [TestMethod]
        public void HabitacionGetUW()
        {
            Habitacion result = null;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                result = unitofwork.HabitacionRepository.GetById<int>(1);
            }
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void HabitacionGetAllUW()
        {
            List<Habitacion> result = null;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                result = unitofwork.HabitacionRepository.GetAll();
            }
            Assert.IsNotNull(result);

        }
    }
}
