using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace tempForDelegate
{
    [Serializable, XmlType(TypeName = "book")]
    public  class Book
    {
        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlElement("isbn")]
        public string Isbn { get; set; }

        [XmlElement("author")]
        public string Author { get; set; }

        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("genre")]
        public GenreType Genre { get; set; }

        [XmlElement("publisher")]
        public string Publisher { get; set; }

        [XmlElement("publish_date")]
        public DateTime PublishDate { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("registration_date")]
        public DateTime RegistrationDate
        {
            get; set; 
        }

        public enum GenreType
        {
            [XmlEnum]Computer,
            [XmlEnum]Fantasy,
            [XmlEnum]Romance,
            [XmlEnum]Horror,
            [XmlEnum(Name = "Science Fiction")]ScienceFiction
        }

        public override string ToString()
        {
            return $"Book: {Title}, by {Author}\n" +
                   $"{Genre}. {Description}" +
                   $"{PublishDate}, {Publisher}\n";
        }
    }
}
