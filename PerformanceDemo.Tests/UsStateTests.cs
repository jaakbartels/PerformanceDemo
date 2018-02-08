using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PerformanceDemo.Tests
{
    [TestClass]
    public class UsStateTests
    {
        [TestMethod]
        public void Static_members_do_not_new_up_items_when_used()
        {
            Assert.IsTrue(ReferenceEquals(UsState.AK, UsState.AK));
        }

        [TestMethod]
        public void All_does_not_construct_list_when_used()
        {
            Assert.IsTrue(ReferenceEquals(UsState.All, UsState.All));
        }

        [TestMethod]
        public void FromCode_is_case_insensitive()
        {
            Assert.IsTrue(UsState.FromCode("ak").Code == "AK");
        }
    }
}
