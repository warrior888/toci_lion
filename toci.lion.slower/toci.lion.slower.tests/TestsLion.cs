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
            containsTestsEntity = new ContainsTestEntity[10];

            containsTestsEntity[0] = new ContainsTestEntity() { Candidate = "slowo", Cont = "ow", IsContaining = true };
            containsTestsEntity[1] = new ContainsTestEntity() { Candidate = "slowo", Cont = "owr", IsContaining = false };
            containsTestsEntity[2] = new ContainsTestEntity() { Candidate = "viewer", Cont = "vie", IsContaining = true };
            containsTestsEntity[3] = new ContainsTestEntity() { Candidate = "mleko", Cont = "mle", IsContaining = true };
            containsTestsEntity[4] = new ContainsTestEntity() { Candidate = "vr", Cont = "vie", IsContaining = false };
            containsTestsEntity[5] = new ContainsTestEntity() { Candidate = "pije whisky", Cont = "pij", IsContaining = true };
            containsTestsEntity[6] = new ContainsTestEntity() { Candidate = "lubieplacki", Cont = "nielubie", IsContaining = false };
            containsTestsEntity[7] = new ContainsTestEntity() { Candidate = "marcin", Cont = "cjn", IsContaining = false };
            containsTestsEntity[8] = new ContainsTestEntity() { Candidate = "przemek", Cont = "eme", IsContaining = true };
            containsTestsEntity[9] = new ContainsTestEntity() { Candidate = "rower", Cont = "rów", IsContaining = false };
        }
        [TestMethod]
        public void ContainsTest()
        {
            //Program.Contains
            Init();

            foreach (ContainsTestEntity item in containsTestsEntity)
            {
                Assert.AreEqual(item.IsContaining, Program.Contains(item.Candidate, item.Cont));
            }

            for (int i = 0; i < containsTestsEntity.Length; i++)
            {
                Assert.AreEqual(containsTestsEntity[i].IsContaining, Program.Contains(containsTestsEntity[i].Candidate, containsTestsEntity[i].Cont));

            }
        }
    }
}
