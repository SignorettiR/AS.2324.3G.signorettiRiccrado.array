﻿namespace AS._2324._3G.signorettiRiccrado.array;
class Program
{
    static void Main(string[] args)
    {
        int numPersone;
        Console.Write("Inserisci il numero di persone da caricare: ");
        numPersone = int.Parse(Console.ReadLine());
        double[] pesi = new double[numPersone];
        int[] eta = new int[numPersone];
        

        

        CaricaVettori(ref pesi, ref eta, numPersone);

        double media, min, max;
        Statistiche(pesi, out media, out min, out max);

        Console.WriteLine("\nStatistiche dei pesi:");
        Console.WriteLine($"Media: {media}");
        Console.WriteLine($"Minimo: {min}");
        Console.WriteLine($"Massimo: {max}");

        Ordina(ref pesi, ref eta, numPersone);

        Console.WriteLine("\nElenco ordinato per età:");
        for (int i = 0; i < numPersone; i++)
        {
            Console.WriteLine($"Eta: {eta[i]}, Peso: {pesi[i]}");
        }
        Console.ReadLine();

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
        min = pesi[0];
        max = pesi[0];
        for (int i = 0; i < pesi.Length; i++)
        {
            
            media += pesi[i];
            if (pesi[i] < min)
                min = pesi[i];
            if (pesi[i] > max)
                max = pesi[i];
        }

        media /= pesi.Length;

    }
    static void Ordina(ref double[] pesi, ref int[] eta, int numPersone)
    {
        for (int i = 0; i < numPersone - 1; i++)
        {
            for (int j = i + 1; j < numPersone; j++)
            {
                if (eta[i] > eta[j])
                {

                    int tempEta = eta[i];
                    eta[i] = eta[j];
                    eta[j] = tempEta;


                    double tempPeso = pesi[i];
                    pesi[i] = pesi[j];
                    pesi[j] = tempPeso;
                }
            }
        }


    }
}