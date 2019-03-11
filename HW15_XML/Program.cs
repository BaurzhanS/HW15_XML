using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HW15_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            ex2();
        }
        static void ex1()
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "utf-8", null);

            XmlElement music = doc.CreateElement("Music");
            XmlAttribute list = doc.CreateAttribute("MusicName");
            list.InnerText = "Список песен";
            music.Attributes.Append(list);

            XmlElement name = doc.CreateElement("Песня");
            name.InnerText = "Мне больно";
            XmlElement genre = doc.CreateElement("Genre");
            genre.InnerText = "Хипхоп";
            XmlElement rating = doc.CreateElement("Rating");
            rating.InnerText = "8";
            XmlElement body = doc.CreateElement("body");
            body.InnerText = "Песня про любовь";

            music.AppendChild(name);
            music.AppendChild(genre);
            music.AppendChild(rating);
            music.AppendChild(body);
            doc.AppendChild(music);
            doc.Save("music.xml");

            XmlElement name1 = doc.CreateElement("Песня");
            name1.InnerText = "Дай мне слово";
            XmlElement genre1 = doc.CreateElement("Genre");
            genre1.InnerText = "Хипхоп";
            XmlElement rating1 = doc.CreateElement("Rating");
            rating1.InnerText = "5";
            XmlElement body1 = doc.CreateElement("body");
            body1.InnerText = "Песня про слово";

            music.AppendChild(name1);
            music.AppendChild(genre1);
            music.AppendChild(rating1);
            music.AppendChild(body1);
            doc.AppendChild(music);
            doc.Save("music.xml");

            XmlElement name2 = doc.CreateElement("Песня");
            name2.InnerText = "Не говор  нет";
            XmlElement genre2 = doc.CreateElement("Genre");
            genre2.InnerText = "Классика";
            XmlElement rating2 = doc.CreateElement("Rating");
            rating2.InnerText = "4";
            XmlElement body2 = doc.CreateElement("body");
            body2.InnerText = "Песня про классику";

            music.AppendChild(name2);
            music.AppendChild(genre2);
            music.AppendChild(rating2);
            music.AppendChild(body2);
            doc.AppendChild(music);
            doc.Save("music.xml");

            XmlElement name3 = doc.CreateElement("Песня");
            name3.InnerText = "Батяня";
            XmlElement genre3 = doc.CreateElement("Genre");
            genre3.InnerText = "Проза";
            XmlElement rating3 = doc.CreateElement("Rating");
            rating3.InnerText = "6";
            XmlElement body3 = doc.CreateElement("body");
            body3.InnerText = "Песня про войну";

            music.AppendChild(name3);
            music.AppendChild(genre3);
            music.AppendChild(rating3);
            music.AppendChild(body3);
            doc.AppendChild(music);
            doc.Save("music.xml");

            XmlElement name4 = doc.CreateElement("Песня");
            name4.InnerText = "Дочка";
            XmlElement genre4 = doc.CreateElement("Genre");
            genre4.InnerText = "Проза";
            XmlElement rating4 = doc.CreateElement("Rating");
            rating4.InnerText = "7";
            XmlElement body4 = doc.CreateElement("body");
            body4.InnerText = "Песня про дочь";

            music.AppendChild(name4);
            music.AppendChild(genre4);
            music.AppendChild(rating4);
            music.AppendChild(body4);
            doc.AppendChild(music);
            doc.Save("music.xml");
        }

        static void ex2()
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "windows-1251", "yes");

            XmlElement tovar = doc.CreateElement("TOVAR");
            XmlAttribute t1 = doc.CreateAttribute("tovar");
            t1.InnerText = "Список товаров";
            tovar.Attributes.Append(t1);

            XmlElement naim = doc.CreateElement("NAIM");
            naim.InnerText = "Бензин";
            XmlElement price = doc.CreateElement("PRICE");
            price.InnerText = "20";

            tovar.AppendChild(naim);
            tovar.AppendChild(price);

            doc.AppendChild(tovar);
            doc.Save("1.xml");

        }
    }
}
