using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace tempForDelegate
{
    [Serializable, XmlRoot("catalog", Namespace = "http://library.by/catalog")]
    public class Catalog
    {
        [XmlElement("book")]
        public List<Book> Books { get; set; }

        [XmlAttribute("date")]
        public DateTime date { get; set; }

        Catalog()
        {
            Books=new List<Book>();
        }

        public override string ToString()
        {
            return Books.ExtensionToString(); ;
        }
    }
}
