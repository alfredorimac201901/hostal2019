using System;
using System.Collections.Generic;
using ElDorado.Data.Acces;
using ElDorado.Data.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ElDorado.Repository.Test
{
    [TestClass]
    public class EmpleadoRepositoryTest
    {
        [TestMethod]
        public void EmpleadoCountUW()
        {
            var count = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                count = unitofwork.EmpleadoRepository.Count();
            }
            Assert.IsTrue(count > 0);
        }

        [TestMethod]
        public void EmpleadoInsertUW()
        {
            int result = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                var entity = new Empleado();
                entity.Cod_tip_emp = 1;
                entity.Nom_emp = "Andres";
                entity.Ape_pat_emp = "Bello";
                entity.Ape_mat_emp = "Dios";
                entity.Dir_emp = "Los alisos";
                entity.Dis_emp = "La Perla";
                entity.Dep_emp = "Callao";
                entity.Fec_emp = Convert.ToDateTime("2016-01-01");
                entity.Cod_tip_emp = 2;
                entity.Cel_emp = 963421061;
                unitofwork.EmpleadoRepository.Add(entity);
                result = unitofwork.Complete();

            }
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void EmpleadoUpdateUW()
        {
            int result = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                var entity = new Empleado();
                entity.Cod_emp = 1;
                entity.Cod_tip_emp = 1;
                entity.Nom_emp = "Maria";
                entity.Ape_pat_emp = "Bello";
                entity.Ape_mat_emp = "Dios";
                entity.Dir_emp = "Los alisos";
                entity.Dis_emp = "La Perla";
                entity.Dep_emp = "Callao";
                entity.Fec_emp = Convert.ToDateTime("2016-01-01");
                entity.Cod_tip_emp = 2;
                entity.Cel_emp = 963421061;
                unitofwork.EmpleadoRepository.Update(entity);
                result = unitofwork.Complete();

            }
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void EmpleadoDeleteUW()
        {
            int result = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                var entity = new Empleado();
                entity.Cod_emp = 5;
                unitofwork.EmpleadoRepository.Remove(entity);
                result = unitofwork.Complete();

            }
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void EmpleadoGetUW()
        {
            Empleado result = null;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                result = unitofwork.EmpleadoRepository.GetById<int>(1);
            }
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void EmpleadoGetAllUW()
        {
            List<Empleado> result = null;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                result = unitofwork.EmpleadoRepository.GetAll();
            }
            Assert.IsNotNull(result);

        }
    }
}
