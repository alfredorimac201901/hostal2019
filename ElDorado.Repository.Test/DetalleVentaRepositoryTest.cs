using System;
using System.Collections.Generic;
using ElDorado.Data.Acces;
using ElDorado.Data.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ElDorado.Repository.Test
{
    [TestClass]
    public class DetalleVentaRepositoryTest
    {
        [TestMethod]
        public void DetalleVentaCountUW()
        {
            var count = 0;
            using (var unitOfWork = new ElDoradoUnitOfWork())
            {
                count = unitOfWork.DetalleVentaRepository.Count();
            }
            Assert.IsTrue(count > 0);
        }
        [TestMethod]
        public void DetalleVentaInsertUW()
        {
            int result = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                var entity = new Detalle_venta();
                entity.Cod_ven = 2;
                entity.Cod_hab = 2;
                entity.Cant_dia_det_ven = 3;
                entity.Hor_ing_det_ven = "11:30";
                entity.Hor_sal_det_ven = "20";
                unitofwork.DetalleVentaRepository.Add(entity);
                result = unitofwork.Complete();

            }
            Assert.IsTrue(result > 0);
        }
        [TestMethod]
        public void DetalleVentaUpdateUW()
        {
            int result = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                var entity = new Detalle_venta();
                entity.Ite_det_ven = 4;
                entity.Cod_ven = 1;
                entity.Cod_hab = 1;
                entity.Cant_dia_det_ven = 3;
                entity.Hor_ing_det_ven = "08:20";
                entity.Hor_sal_det_ven = "11:20";
                unitofwork.DetalleVentaRepository.Update(entity);
                result = unitofwork.Complete();

            }
            Assert.IsTrue(result > 0);
        }
        [TestMethod]
        public void DetalleVentaDeleteUW()
        {
            int result = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                var entity = new Detalle_venta();
                entity.Ite_det_ven = 5;
                unitofwork.DetalleVentaRepository.Remove(entity);
                result = unitofwork.Complete();

            }
            Assert.IsTrue(result > 0);
        }
        [TestMethod]
        public void DetalleVentaGetUW()
        {
            Detalle_venta result = null;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                result = unitofwork.DetalleVentaRepository.GetById<int>(1);
            }
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void DetalleVentaGetAllUW()
        {
            List<Detalle_venta> result = null;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                result = unitofwork.DetalleVentaRepository.GetAll();
            }
            Assert.IsNotNull(result);

        }
    }
}
