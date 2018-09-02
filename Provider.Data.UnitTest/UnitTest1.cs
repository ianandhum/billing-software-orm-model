using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Provider.Data;
using System.Data.SQLite;

namespace Provider.Data.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Context()
        {
            
            DataContext dataContext = new DataContext(connectionString);
            
        }

    }
}
