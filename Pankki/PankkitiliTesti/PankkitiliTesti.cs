using Pankki;
namespace PankkitiliTesti
{
    [TestClass]
    public class PankkitiliTesti
    {
        [TestMethod]
        public void TestMethod1()
        {
            double alkusaldo = 11.99;
            double ottoSumma = 4.55;
            double oletettu = 7.44;
            Pankkitili pt = new Pankkitili("Jani Kekäläinen,", alkusaldo);

            pt.Otto(ottoSumma);

            double todellinen = pt.Saldo;
            Assert.AreEqual(oletettu, todellinen, 0.001, "tililtä otto ei onnistunut");
        }
    }
}