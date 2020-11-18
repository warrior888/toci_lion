using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace toci.lion.slower.tests
{
    public class ContainsTestEntity
    {
        public string Candidate; // slowo
        public string Cont; // ow
        public bool IsContaining; // true
    }
    [TestClass]
    public class TestsLion
    {
        protected ContainsTestEntity[] containsTestsEntity;

        protected void Init()
        {
            containsTestsEntity = new ContainsTestEntity[5];

            containsTestsEntity[0] = new ContainsTestEntity() { Candidate = "slowo", Cont = "ow", IsContaining = true };
            containsTestsEntity[1] = new ContainsTestEntity() { Candidate = "slowo", Cont = "owr", IsContaining = false };
            containsTestsEntity[2] = new ContainsTestEntity() { Candidate = "viewer", Cont = "vie", IsContaining = true };
        }
        [TestMethod]
        public void ContainsTest()
        {
            //Program.Contains
            Init();

            foreach (ContainsTestEntity item in containsTestsEntity)
            {
                //Assert.AreEqual(item.IsContaining, Program.Contains(item.Candidate, item.Cont));
            }

            for (int i = 0; i < containsTestsEntity.Length; i++)
            {
                Assert.AreEqual(containsTestsEntity[i].IsContaining, Program.Contains(containsTestsEntity[i].Candidate, containsTestsEntity[i].Cont));

            }
        }
    }
}
