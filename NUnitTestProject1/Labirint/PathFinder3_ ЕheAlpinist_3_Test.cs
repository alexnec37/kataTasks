using codewars.Labirint;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1.Labirint
{
    [TestFixture]
    public class PathFinder3__ЕheAlpinist_3_Test
    {
        [Test]
        public void SampleTests()
        {

            string a = "000\n" +
                       "000\n" +
                       "000",

                   b = "010\n" +
                       "010\n" +
                       "010",

                   c = "010\n" +
                       "101\n" +
                       "010",

                   d = "0707\n" +
                       "7070\n" +
                       "0707\n" +
                       "7070",

                   e = "700000\n" +
                       "077770\n" +
                       "077770\n" +
                       "077770\n" +
                       "077770\n" +
                       "000007",

                   f = "777000\n" +
                       "007000\n" +
                       "007000\n" +
                       "007000\n" +
                       "007000\n" +
                       "007777",

                   g = "000000\n" +
                       "000000\n" +
                       "000000\n" +
                       "000010\n" +
                       "000109\n" +
                       "001010",

                   //h = "026\n" +
                   //    "493\n" +
                   //    "175",

                   h = "041\n" +
                       "297\n" +
                       "635",

                   i = "1165\n" +
                       "0854\n" +
                       "2365\n" +
                       "2106",

            k = "746605500709711736\n" +
                "969074854695160637\n" +
                "483887753873967904\n" +
                "967285191553818425\n" +
                "217232108072826677\n" +
                "020869529995544278\n" +
                "673408702963724030\n" +
                "544860210252865790\n" +
                "351116665626141362\n" +
                "470228744010893478\n" +
                "833829569401049221\n" +
                "913246164482277253\n" +
                "965076924397167246\n" +
                "558666508713478526\n" +
                "583632286721502170\n" +
                "529956810091863066\n" +
                "281648978620130800\n" +
                "652782118486844589",

            //            6264007484
            //0623611406
            //5621624430
            //9972054761
            //1277193361
            //7841700487
            //5217509931
            //7489428406
            //9181315640
            //5988581020

            //                36 - 38

            l = "492833\n" +
                        "809087\n" +
                        "849795\n" +
                        "504221\n" +
                        "664954\n" +
                        "348260",

            m = "30404\n" +
                "31584\n" +
                "45242\n" +
                "04343\n" +
                "97294";

            // 20 - 24

            Assert.AreEqual(7, PathFinder3__ЕheAlpinist_3.PathFinder(m));
            Assert.AreEqual(54, PathFinder3__ЕheAlpinist_3.PathFinder(k));
            Assert.AreEqual(20, PathFinder3__ЕheAlpinist_3.PathFinder(l));
            Assert.AreEqual(11, PathFinder3__ЕheAlpinist_3.PathFinder(h));
            Assert.AreEqual(9, PathFinder3__ЕheAlpinist_3.PathFinder(i));
            Assert.AreEqual(0, PathFinder3__ЕheAlpinist_3.PathFinder(a));
            Assert.AreEqual(2, PathFinder3__ЕheAlpinist_3.PathFinder(b));
            Assert.AreEqual(4, PathFinder3__ЕheAlpinist_3.PathFinder(c));
            Assert.AreEqual(42, PathFinder3__ЕheAlpinist_3.PathFinder(d));
            Assert.AreEqual(14, PathFinder3__ЕheAlpinist_3.PathFinder(e));
            Assert.AreEqual(0, PathFinder3__ЕheAlpinist_3.PathFinder(f));
            Assert.AreEqual(4, PathFinder3__ЕheAlpinist_3.PathFinder(g));
        }
    }
}
