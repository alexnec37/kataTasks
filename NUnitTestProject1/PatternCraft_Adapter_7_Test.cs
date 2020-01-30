using PatternCraft_Adapter_7;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1
{
    [TestFixture]
    public class PatternCraft_Adapter_7_Test
    {
        [Test]
        public void _0_MarioAdapter_Can_Attack()
        {
            var marioAdapter = new MarioAdapter(new Mario());
            var target = new Target { Health = 33 };

            marioAdapter.Attack(target);

            Assert.AreEqual(30, target.Health);
        }
    }
}
