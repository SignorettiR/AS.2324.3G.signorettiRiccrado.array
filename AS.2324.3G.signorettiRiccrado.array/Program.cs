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

        double media, min, max;
        Statistiche(pesi, out media, out min, out max);

        Console.WriteLine("\nStatistiche dei pesi:");
        Console.WriteLine($"Media: {media}");
        Console.WriteLine($"Minimo: {min}");
        Console.WriteLine($"Massimo: {max}");


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
    static void Statistiche(double[] pesi, out double media, out double min, out double max)
    {
        media = 0;
        min = double.MaxValue;
        max = double.MinValue;

        foreach (var peso in pesi)
        {
            media += peso;
            if (peso < min)
                min = peso;
            if (peso > max)
                max = peso;
        }

        media /= pesi.Length;
    }


}