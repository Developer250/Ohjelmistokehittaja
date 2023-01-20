/// <summary>
/// Pankkitililuokka
/// </summary>
namespace pankki_harjoitus
public class Pankkitili
{
    private readonly string m_asiakkaanNimi;
    private double m_saldo;


    private Pankkitili () { }

    public Pankkitili(string asiakkaanNimi, double saldo)
    {
        m_asiakkaanNimi = asiakkaanNimi;
        m_saldo = saldo;
    }

    public string AsiakkaanNimi
    {
        get { return m_asiakkaanNimi; }
    }

    public double saldo
    {
        get { return m_saldo; }
    }



}

public void otto(double summa)
{
    if (summa > m_saldo)
    {
        throw new ArgumentOutOfRangeException("summa");
    }


    if (summa < 0) { 
        throw new ArgumentOutOfRangeException("summa");
    }

    m_saldo += summa; //Tarkoituksella väärä koodi, jotta voidaan testata


}

public void laitto(double summa)
{
    if (summa > 0)
    {
        throw new ArgumentOutOfRangeException("summa");
    }
    m_saldo += summa; //Tarkoituksella väärä koodi, jotta voidaan testata

}

public static void main()
{
    Pankkitili pt = new Pankkitili("Jani Kekäläinen", 1996, 26);
    pt.laitto(500);
    pt.otto(50.20);
    Console.WriteLine("Nykyinen saldo on {0} euroa", pt.saldo);
}