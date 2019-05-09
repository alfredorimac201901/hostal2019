using System;
using System.Collections.Generic;
using ElDorado.Data.Acces;
using ElDorado.Data.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ElDorado.Repository.Test
{
    [TestClass]
    public class TipoPagoRepositoryTest
    {
        [TestMethod]
        public void TipoPagoCountUW()
        {
            var count = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                count = unitofwork.TipoPagoRepository.Count();
            }
            Assert.IsTrue(count > 0);
        }

        [TestMethod]
        public void TipoPagoInsertUW()
        {
            int result = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                var entity = new Tipo_pago();
                entity.Des_tip_pag = "Trueque";
                unitofwork.TipoPagoRepository.Add(entity);
                result = unitofwork.Complete();

            }
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void TipoPagoUpdatetUW()
        {
            int result = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                var entity = new Tipo_pago();
                entity.Cod_tip_pag = 3;
                entity.Des_tip_pag = "Fiado";
                unitofwork.TipoPagoRepository.Update(entity);
                result = unitofwork.Complete();

            }
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void TipoPagoGetUW()
        {
            Tipo_pago result = null;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                result = unitofwork.TipoPagoRepository.GetById<int>(2);
            }
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TipoPagoGetAllUW()
        {
            List<Tipo_pago> result = null;


            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                result = unitofwork.TipoPagoRepository.GetAll();
            }
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TipoPagoDeleteUW()
        {
            int result = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                var entity = new Tipo_pago();
                entity.Cod_tip_pag = 5;
                unitofwork.TipoPagoRepository.Remove(entity);
                result = unitofwork.Complete();

            }
            Assert.IsTrue(result > 0);
        }

    }
}
