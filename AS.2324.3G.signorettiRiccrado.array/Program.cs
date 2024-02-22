namespace AS._2324._3G.signorettiRiccrado.array;
class Program
{
    static void Main(string[] args)
    {

        double[] pesi = new double[100];
        int[] eta = new int[100];
        int numPersone;

        Console.Write("Inserisci il numero di persone da caricare: ");
        numPersone = int.Parse(Console.ReadLine());

        CaricaVettori(ref pesi, ref eta, numPersone);

    }
    static void CaricaVettori(ref double[] pesi, ref int[] eta, int numPersone)
    {
        Random rnd = new Random();

        for (int i = 0; i < numPersone; i++)
        {
            pesi[i] = rnd.Next(50, 101);
            eta[i] = rnd.Next(18, 100);
        }
    }

}