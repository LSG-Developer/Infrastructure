using System;
using CompanyName.ProjectName.ServiceName.BackServices;
using CompanyName.ProjectName.ServiceName.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NMock2;
using System.Diagnostics.CodeAnalysis;

namespace Test
{
    [TestClass]
    public class UnitTest1 
    {
        /// <summary>
        ///A test for IsSurricaldamentoInAumento
        ///</summary> 
        [TestMethod()]
        [ExcludeFromCodeCoverage]
        public void IsMessageCorrect() 
        {
            Mockery mocks = new Mockery();
            IYourRepository mockRepository = mocks.NewMock<IYourRepository>();
            String[] listStringa = new String[3] { "Hello Word", "Hello word", "hello Word" };

            foreach (string stringa in listStringa)
            {
                Expect.Once.On(mockRepository).
                Method("GetMessage").
                Will(Return.Value(stringa));
                string expected = "Messaggio corretto"; // TODO: Initialize to an appropriate value
                string actual;
                actual = BackServiceName.MethodName(mockRepository);
                Assert.AreEqual(expected, actual);
            }
        }

        /// <summary>
        ///A test for IsSurricaldamentoInAumento
        ///</summary> 
        [TestMethod()]
        [ExcludeFromCodeCoverage]
        public void IsMessageNoCorrect()
        {
            Mockery mocks = new Mockery();
            IYourRepository mockRepository = mocks.NewMock<IYourRepository>();
                Expect.Once.On(mockRepository).
                Method("GetMessage").
                Will(Return.Value("messaggio inventato"));
                string expected = "Messaggio ambiguo"; // TODO: Initialize to an appropriate value
                string actual;
                actual = BackServiceName.MethodName(mockRepository);
                Assert.AreEqual(expected, actual);
        
        }

        [TestMethod()]
        [ExcludeFromCodeCoverage]
        [ExpectedException(typeof(ArgumentException))]
        public void IsMessageGenerateException()
        {
            Mockery mocks = new Mockery();
            IYourRepository mockRepository = mocks.NewMock<IYourRepository>();
            Expect.Once.On(mockRepository).
            Method("GetMessage").
            Will(Return.Value(""));
            //string expected = "Messaggio corretto"; // TODO: Initialize to an appropriate value
            string actual;
            actual = BackServiceName.MethodName(mockRepository);
            //Assert.AreEqual(expected, actual);   
        }
    }
}
