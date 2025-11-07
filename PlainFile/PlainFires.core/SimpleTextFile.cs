
namespace PlainFires.core;


    public class SimpleTextFile
    {
        private readonly string _path;

        //el path es donde voy a almacenar el texto
        public SimpleTextFile(string path)
        {

            if (string.IsNullOrWhiteSpace(path)) { 
        
                throw new ArgumentException("Path cannot be null or whitespace.", nameof(path) );
            }
            _path = path;

            var directory = Path.GetDirectoryName(_path);
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            if (!File.Exists(_path))
            {
                using (File.Create(_path)) { 
                }
             }
        
    }

        //escribir las lineas en el archivo
        //metodo para escribir lineas en el archivo
        public void WriteAllLines(string[] lines)
        {

            // clase file hay un metodo WriteAllLines se le va  a pasar la ruta y se le va  a pasar las lineas que se quiere grabar
            File.WriteAllLines(_path, lines);

        }
        //metodo para leer las lineas del archivo
        public string[] ReadAllLines()
        {
            // clase file hay un metodo ReadAllLines se le va  a pasar la ruta y devuelve un array de string
            return File.ReadAllLines(_path);
        }



    }


