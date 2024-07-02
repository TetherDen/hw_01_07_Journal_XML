using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace hw_01_07_
{
    internal static class JournalFIleManager
    {
        public static void Serialize(List<Journal> obj)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Journal>));
            using (FileStream fs = new FileStream(@"../../../journals.xml", FileMode.Create))
            {
                serializer.Serialize(fs, obj);
            }
        }

        public static List<Journal> Deserialize()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Journal>));
            using (FileStream fs = new FileStream(@"../../../journals.xml", FileMode.Open))
            {
                List<Journal> jl = (List<Journal>)serializer.Deserialize(fs);
                return jl;
            }
        }
    }
}
