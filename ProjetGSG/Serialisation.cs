using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace ProjetGSG
{
    

    public class Serialisation
    {
        // Méthode pour sérialiser les données du service commercial dans un fichier binaire
        public static void Serialiser(SceCommercial service, string filePath)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                formatter.Serialize(stream, service);
            }
        }

        // Méthode pour désérialiser les données du service commercial depuis un fichier binaire
        public static SceCommercial Deserialiser(string filePath)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                return (SceCommercial)formatter.Deserialize(stream);
            }
        }
    }
}
