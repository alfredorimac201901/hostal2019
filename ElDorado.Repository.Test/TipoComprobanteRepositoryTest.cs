using System;
using System.Collections.Generic;
using ElDorado.Data.Acces;
using ElDorado.Data.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ElDorado.Repository.Test
{
    [TestClass]
    public class TipoComprobanteRepositoryTest
    {
        [TestMethod]
        public void TipoComprobanteCountUW()
        {
            var count = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                count = unitofwork.TipoComprobanteRepository.Count();
            }
            Assert.IsTrue(count > 0);
        }

        [TestMethod]
        public void TipoComprobanteInsertUW()
        {
            int result = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                var entity = new Tipo_comprobante();
                entity.Des_tip_com = "Ticket";
                unitofwork.TipoComprobanteRepository.Add(entity);
                result = unitofwork.Complete();

            }
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void TipoComprobanteUpdateUW()
        {
            int result = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                var entity = new Tipo_comprobante();
                entity.Cod_tip_com = 3;
                entity.Des_tip_com = "Amore";
                unitofwork.TipoComprobanteRepository.Update(entity);
                result = unitofwork.Complete();

            }
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void TipoComprobanteDeleteUW()
        {
            int result = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                var entity = new Tipo_comprobante();
                entity.Cod_tip_com = 3;
                unitofwork.TipoComprobanteRepository.Remove(entity);
                result = unitofwork.Complete();

            }
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void TipoComprobanteGetUW()
        {
            Tipo_comprobante result = null;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                result = unitofwork.TipoComprobanteRepository.GetById<int>(1);
            }
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TipoComprobanteGetAllUW()
        {
            List<Tipo_comprobante> result = null;


            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                result = unitofwork.TipoComprobanteRepository.GetAll();
            }
            Assert.IsNotNull(result);
        }
    }
}
