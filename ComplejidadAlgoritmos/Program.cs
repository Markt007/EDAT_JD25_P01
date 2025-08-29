internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Complejidad de algoritmos\n");
        Console.WriteLine("Complejidad Big O(1)");

        //var nombres = new List<string>() { "Ileny", "Alondra", "José", "Juan", "Alejandro", "Karla" };
        //var nombres = new List<string>();
        //var primero = ( List<string> arreglo) => arreglo != null && arreglo.Count > 0 ?
        //        arreglo[1] : "Lista vacia";

        //Console.WriteLine(primero(nombres));




        var numeros = new List<int>() { 5,2,53,500,2000,10000,0,1};
        //var numeros = new List<int>();

        var numeroMayor = (List<int> arreglo) =>
        {
            
            if (arreglo == null || arreglo.Count == 0)
            {
                return 0;
            }
            int may = arreglo[0];
            for (int i = 0; i < arreglo.Count; i++)
            {
                if (arreglo[i] > may)
                {
                    may = arreglo[i];
                }
            }
            return may;
        };

        int may = numeroMayor(numeros);
        Console.WriteLine(may);


        Console.ReadKey();
    }
}