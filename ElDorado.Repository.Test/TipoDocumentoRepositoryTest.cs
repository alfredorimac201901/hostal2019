using System;
using System.Collections.Generic;
using ElDorado.Data.Acces;
using ElDorado.Data.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ElDorado.Repository.Test
{
    [TestClass]
    public class TipoDocumentoRepositoryTest
    {
        [TestMethod]
        public void TipoDocumentoCountUW()
        {
            var count = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                count = unitofwork.TipoDocumentoRepository.Count();
            }
            Assert.IsTrue(count > 0);
        }

        [TestMethod]
        public void TipoDocumentoInsertUW()
        {
            int result = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                var entity = new Tipo_documento();
                entity.Des_tip_doc = "PPT";
                unitofwork.TipoDocumentoRepository.Add(entity);
                result = unitofwork.Complete();

            }
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void TipoDocumentoUpdateUW()
        {
            int result = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                var entity = new Tipo_documento();
                entity.Cod_tip_doc = 9;
                entity.Des_tip_doc = "CEDULA";
                unitofwork.TipoDocumentoRepository.Update(entity);
                result = unitofwork.Complete();

            }
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void TipoDocumentoDeleteUW()
        {
            int result = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                var entity = new Tipo_documento();
                entity.Cod_tip_doc = 9;
                unitofwork.TipoDocumentoRepository.Remove(entity);
                result = unitofwork.Complete();

            }
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void TipoDocumentoGetUW()
        {
            Tipo_documento result = null;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                result = unitofwork.TipoDocumentoRepository.GetById<int>(1);
            }
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TipoDocumentoGetAllUW()
        {
            List<Tipo_documento> result = null;


            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                result = unitofwork.TipoDocumentoRepository.GetAll();
            }
            Assert.IsNotNull(result);
        }


    }
}
