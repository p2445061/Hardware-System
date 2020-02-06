using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hardware_Testing
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK(){
            clsStaff staff = new clsStaff();

            Assert.IsNotNull(staff);
        }
    }
}
