internal class Program
{
    private static void Main(string[] args)
    {
        int[] a = { 1, 2, 0, 1, 0, 1 };
        int j = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i]!=0)
            {
                a[j] = a[i];
                j++;
            }
        }

        foreach(int ele in a)
        {
            Console.Write(ele + " ");
        }
        Console.ReadLine();
    }
}