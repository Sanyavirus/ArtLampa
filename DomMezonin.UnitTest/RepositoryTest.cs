using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Components.DictionaryAdapter;
using DomMezonin.DomainModel.Entity;
using DomMezonin.DomainModel.Repository;
using Microsoft.VisualStudio.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DomMezonin.UnitTest
{
    [TestClass]
    public class RepositoryTest
    {
        private List<EntityBaseNamed> testEntitites = new List<EntityBaseNamed>()
        {
             new EntityBaseNamed() {Id = 200, Name = "Лампа" },
             new EntityBaseNamed() {Id = 100, Name = "Категория Лампы" },
             new EntityBaseNamed() {Id = 33, Name = "Лампа арутюрн" },
             new EntityBaseNamed() {Id = 7, Name = "Грево Лампа" },
             new EntityBaseNamed() {Id = 1, Name = "Китайская лампа" },
        };

        [TestMethod]
        public void Test_Base_Repository_GetSomeEntity()
        {
            Mock<IRepository<EntityBaseNamed>> mock = new Mock<IRepository<EntityBaseNamed>>();
           // mock.Setup(m => m.GetEntities()).Returns(testEntitites);
        }
    }
}
