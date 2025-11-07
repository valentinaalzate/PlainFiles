using PlainFires.core;
using System.ComponentModel.Design;
using System.IO;

var textFile = new SimpleTextFile("data.txt");



// tolist convierte un array en una lista
// porque en una lista es más fácil manipular los datos
var lines = textFile.ReadAllLines().ToList();
var opc = string.Empty;

do
{
    opc = Menu();

    switch (opc)
    {
        case "1":
            Console.WriteLine("\nContenido del archivo:");
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
            if (lines.Count == 0)
                Console.WriteLine("(Archivo vacío)");
            Console.WriteLine();
            break;

        case "2":
            Console.Write("\nIngrese una nueva línea de texto: ");
            var newLine = Console.ReadLine();
            if (!string.IsNullOrEmpty(newLine))
            {
                lines.Add(newLine);
                Console.WriteLine("Línea agregada.\n");
            }
            else
            {
                Console.WriteLine("No se agregó ninguna línea.\n");
            }
            break;

        case "3":
            // convertir a un array para guardarlo
            textFile.WriteAllLines(lines.ToArray());
            Console.WriteLine("Archivo guardado.\n");
            break;

     
        case "0":
            Console.WriteLine("Saliendo...");
            break;

        default:
            Console.WriteLine("Opción no válida. Intente de nuevo.\n");
            break;
    }

} while (opc != "0");
textFile.WriteAllLines(lines.ToArray());
string Menu()
{
    Console.WriteLine("===== MENÚ =====");
    Console.WriteLine("1. Mostrar contenido");
    Console.WriteLine("2. Adicionar línea");
    Console.WriteLine("3. Guardar archivo");

    Console.WriteLine("0. Salir");
    Console.Write("Su opción es: ");
    return Console.ReadLine() ?? string.Empty;
}
