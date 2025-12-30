using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace JsonToXmlConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Путь к входному JSON файлу
            var pathInpJson = Path.Combine(Environment.CurrentDirectory.Replace("bin\\Debug\\net9.0", "inputJSON"), "Super hero squad.json");

            //Console.WriteLine(pathInpJson);

            Squad? squad1;

            // Десериализация из JSON
            using (FileStream fsInpJson = new FileStream(pathInpJson, FileMode.Open))
            {
                /*byte[] buffer = new byte[fs.Length];
                fs.ReadExactly(buffer);
                string textFromFile = Encoding.Default.GetString(buffer);
                Console.WriteLine($"{textFromFile}");*/

                squad1 = JsonSerializer.Deserialize<Squad>(fsInpJson);
            }
            
            squad1.Print();

            // Путь к исходящему XML файлу
            var pathOutXml = Path.Combine(Environment.CurrentDirectory.Replace("bin\\Debug\\net9.0", "outputXML"), "Super hero squad.xml");

            // передали в конструктор тип класса Squad
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Squad));

            // Сериализация в XML
            using (FileStream fsOutXml = new FileStream(pathOutXml, FileMode.Create))
            {
                /*byte[] buffer = new byte[fs.Length];
                fs.ReadExactly(buffer);
                string textFromFile = Encoding.Default.GetString(buffer);
                Console.WriteLine($"{textFromFile}");*/

                xmlSerializer.Serialize(fsOutXml, squad1);
                
            }
            Console.WriteLine("готово");
        }
    }
}