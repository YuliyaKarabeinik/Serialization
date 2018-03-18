using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace tempForDelegate
{
    public delegate string Deleg(int numb);
    class Program
    {

        /// <summary>
        /// DELAGATES
        /// </summary>
        /// <param name="args"></param>
       /* static void Main(string[] args)
        {
            Deleg del =M1;
            string res = del(3);
            Console.WriteLine(res);
            Console.ReadKey();
        }

        public static string M1(int numb) => (numb*numb).ToString();*/

        static void Main(string[] args)
        {
            var serializer = new XmlSerializer(typeof(Catalog));
            var catalog = serializer.Deserialize(new FileStream("Books.xml", FileMode.Open)) as Catalog;
            Console.WriteLine(catalog);
            Console.ReadKey();

            var stream = new FileStream("NewBooks.xml", FileMode.Create);
            serializer.Serialize(stream, catalog);
            stream.Close();
        }


    }
}
