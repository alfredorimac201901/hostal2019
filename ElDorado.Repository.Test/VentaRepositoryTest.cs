using System;
using System.Collections.Generic;
using ElDorado.Data.Acces;
using ElDorado.Data.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ElDorado.Repository.Test
{
    [TestClass]
    public class VentaRepositoryTest
    {
        [TestMethod]
        public void VentaCountUW()
        {
            var count = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                count = unitofwork.VentaRepository.Count();
            }
            Assert.IsTrue(count > 0);
        }

        [TestMethod]
        public void VentaInsertUW()
        {
            int result = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                var entity = new Venta();
                entity.Cod_tip_com = 1;
                entity.Cod_cli = 3;
                entity.Cod_emp = 3;
                entity.Cod_tip_pag = 1;
                entity.Fec_ven = Convert.ToDateTime("2019-02-02");
                entity.Tot_ven = 80;
                entity.Est_ven = "Cancelado";
                entity.Sub__tot_ven = 30;
                entity.Igv_ven = 4;

                unitofwork.VentaRepository.Add(entity);
                result = unitofwork.Complete();

            }
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void VentaUpdateUW()
        {
            int result = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                var entity = new Venta();
                entity.Cod_ven = 4;
                entity.Cod_tip_com = 1;
                entity.Cod_cli = 4;
                entity.Cod_emp = 3;
                entity.Cod_tip_pag = 2;
                entity.Fec_ven = Convert.ToDateTime("2019-03-03");
                entity.Tot_ven = 20;
                entity.Est_ven = "Cancelado";
                entity.Sub__tot_ven = 30;
                entity.Igv_ven = 4;

                unitofwork.VentaRepository.Update(entity);
                result = unitofwork.Complete();

            }
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void VentaDeleteUW()
        {
            int result = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                var entity = new Venta();
                entity.Cod_ven = 5;
                unitofwork.VentaRepository.Remove(entity);
                result = unitofwork.Complete();

            }
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void VentaGetUW()
        {
            Venta result = null;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                result = unitofwork.VentaRepository.GetById<int>(1);
            }
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void VentaGetAllUW()
        {
            List<Venta> result = null;


            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                result = unitofwork.VentaRepository.GetAll();
            }
            Assert.IsNotNull(result);
        }
    }
}
