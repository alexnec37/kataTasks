using AdapterPattern_GeeseToDucks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1
{
    [TestFixture]
    class AdapterPattern_GeeseToDucksTest
    {
        [Test]
        public void Test1()
        {
            Goose goose = new Goose();
            GooseToIDuckAdapter adapter = new GooseToIDuckAdapter(goose);

            Assert.AreEqual(adapter.Quack(), goose.Honk());
        }
    }
}
