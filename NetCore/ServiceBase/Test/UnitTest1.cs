using System;
using CompanyName.ProjectName.ServiceName.BackServices;
using CompanyName.ProjectName.ServiceName.Repository;
using System.Diagnostics.CodeAnalysis;
using Moq; 

namespace CompanyName.ProjectName.ServiceName.Test
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class UnitTest1
    {
        /// <summary>
        ///A test for IsSurricaldamentoInAumento
        ///</summary> 
        [TestMethod()]
        [ExcludeFromCodeCoverage]
        public void IsMessageCorrect()
        {
            var mockService = new Mock<IYourRepository>();

            String[] listStringa = new String[3] { "Hello Word", "Hello word", "hello Word" };

            foreach (string stringa in listStringa)
            {
                mockService.Setup(service => service.GetMessage()).Returns(stringa);
                string expected = "Messaggio corretto"; // TODO: Initialize to an appropriate value
                string actual = BackServiceName.MethodName(mockService.Object);
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
