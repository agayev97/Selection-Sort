using System;
public class Example
{
    static void Main(string[] args)
    {
        int[] a;
        Console.WriteLine("Massivin olcusunu daxil edin:\n");
        int n = Convert.ToInt32(Console.ReadLine());
        a = new int[n];
        Console.WriteLine("Massivin elementlerini daxil edin:\n");
        for (int i = 0; i < n; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("Daxil etdiyimiz massiv :");
        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + "  ");
        }
        int x, k;
        bool swaped = false;
        for (int i = 0; i < n - 1; i++)
        {
            k = i;
            swaped = false;
            for (int j = i + 1; j < n; j++)
            {
                if (a[j] < a[k])
                {
                    swaped = true;
                    k = j;
                }
            }
            x = a[k];
            a[k] = a[i];
            a[i] = x;
        }
        Console.WriteLine();
        Console.Write("Sıralanan massiv: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + "  ");
        }
    }
}