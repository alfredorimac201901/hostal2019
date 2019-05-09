using System;
using System.Collections.Generic;
using ElDorado.Data.Acces;
using ElDorado.Data.Repository;
using ElDorado.Data.Repository.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ElDorado.Repository.Test
{
    [TestClass]
    public class ClienteRepositoryTest
    {
        [TestMethod]
        public void ClienteCount()
        {
            var _context = new DatoModelo();
            IClienteRepository rep = new ClienteRepository(_context);
            var count = rep.Count();
            Assert.IsTrue(count > 0);
          }
        [TestMethod]
        public void ClienteUW()
        {
            var count = 0;
            using (var unitofwork=new ElDoradoUnitOfWork())
            {
                count = unitofwork.ClienteRepository.Count();
            }
            Assert.IsTrue(count > 0);
        }
        [TestMethod]
        public void ClienteInsertUW()
        {
            int result = 0;
            using (var unitofwork=  new ElDoradoUnitOfWork())
            {
                var entity = new Cliente();
                entity.Nom_cli = "Carmen";
                entity.Ape_pat_cli = "lopez";
                entity.Ape_mat_cli = "Urquizo";
                entity.Dir_cli = "Av. olivar";
                entity.Dis_cli = "Pueblo Libre";
                entity.Dep_cli = "Lima";
                entity.Pai_cli = "Peru";
                entity.Cod_tip_doc = 1;
                entity.Fec_nac_cli = Convert.ToDateTime("2010-01-01");
                entity.Cel_cli = 963421061;
                entity.Ema_cli = "maria@hotmail.com";
                unitofwork.ClienteRepository.Add(entity);
                result = unitofwork.Complete();
            }
            Assert.IsTrue(result > 0);

        }
        [TestMethod]
        public void ClienteUpdateUW()
        {
            int result = 0;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                var entity = new Cliente();
                entity.Cod_cli = 5;
                entity.Nom_cli = "Maria";
                entity.Ape_pat_cli = "lopez";
                entity.Ape_mat_cli = "Urquizo";
                entity.Dir_cli = "Av. olivar";
                entity.Dis_cli = "Pueblo Libre";
                entity.Dep_cli = "Lima";
                entity.Pai_cli = "Peru";
                entity.Cod_tip_doc = 1;
                entity.Fec_nac_cli = Convert.ToDateTime("2010-01-01");
                entity.Cel_cli = 963421061;
                entity.Ema_cli = "maria@hotmail.com";
                unitofwork.ClienteRepository.Update(entity);
                result = unitofwork.Complete();
            }
            Assert.IsTrue(result > 0);

        }
        [TestMethod]
        public void ClienteDeleteUW()
        {
            int result = 0;
            using (var unitofwork=new ElDoradoUnitOfWork())
            {
                var entity = new Cliente();
                entity.Cod_cli = 5;
                unitofwork.ClienteRepository.Remove(entity);
                result = unitofwork.Complete();

            }
            Assert.IsTrue(result > 0);
        }
        [TestMethod]
        public void ClienteGetUW()
        {
            Cliente result = null;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                result = unitofwork.ClienteRepository.GetById<int>(1);
            }
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void ClienteGetAllUW()
        {
            List<Cliente> result = null;
            using (var unitofwork = new ElDoradoUnitOfWork())
            {
                result = unitofwork.ClienteRepository.GetAll();
            }
            Assert.IsNotNull(result);

        }

    }
}