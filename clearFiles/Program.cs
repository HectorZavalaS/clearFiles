using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clearFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            String path = @"C:\SIIXAPPS\aprinting\Labels";
            try
            {
                if (Directory.Exists(path))
                {
                    Console.WriteLine("Entrando en directorio: " + path);
                    DirectoryInfo dir = new DirectoryInfo(path);
                    foreach (FileInfo file in dir.GetFiles())
                    {
                        Console.WriteLine("Borrando archivo: " + file.Name);
                        file.Delete();
                    }
                }
                else
                {
                    Console.WriteLine("No existe el directorio");
                    Console.Write("Press any key to continue . . .");
                    Console.ReadKey(true);
                }

               // DirectoryInfo di = Directory.CreateDirectory(path);
            }
            catch (Exception e)
            {
                //MessageBox.Show("Ocurrio un error al crear el directorio:" + e.Message);
                // return false;
                Console.Write("Press any key to continue . . .");
                Console.ReadKey(true);
                Console.WriteLine("Fallo el proceso");
            }
        }
    }
}
