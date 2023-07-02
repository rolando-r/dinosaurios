internal class Program
{
    private static void Main(string[] args)
    {
        String ? palabra = null; // Del metodo exists, el = null es del metodo find all
        List<String> Dinosaurios = new List<String>();
        List<String> Encontrados = new List<String>(); // Del FindAll y FindLast
        string[] Dinos = {
            "Brachinosaurus",
            "Amargasaurus",
            "Mamenchisaurus"
        };
        // Metodo AddRande
        Dinosaurios.AddRange(Dinos);
        Console.WriteLine("Ingrese el dinosaurio a buscar: ");
        palabra = Console.ReadLine();

        // FindLast
        string ? ultimoEncontrado = Dinosaurios.FindLast(n => n.Contains(palabra ?? String.Empty));
        Console.WriteLine("El ultimo dinosaurio que contiene la letra es : {0}", ultimoEncontrado);

        // FindAll: la diferencia es que busca desde las letras
        /* Encontrados = Dinosaurios.FindAll(n=> n.Contains(palabra ?? String.Empty));
        foreach (String n in Encontrados){
            Console.WriteLine(n);
        } */

        // Find
        /* string ? nombre = Dinosaurios.Find(n => n.StartsWith(palabra ?? String.Empty));
        Console.WriteLine(nombre != null ? "Se encontro el dinosaurio" : "No se encontro el dinosaurio"); */

        // Exists
        /* Console.WriteLine(Dinosaurios.Exists(item => item.Equals(palabra)) ? "Se efncontro el dinosaurio" : "No se encontro el dinosaurio"); */

        // Clear
        /* foreach (String str in Dinosaurios){
            Console.WriteLine(str);
        }
        Dinosaurios.Clear();
        Console.WriteLine("Total de elementos {0} :",Dinosaurios.Count); */
    }
}