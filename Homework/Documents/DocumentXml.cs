using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml;

namespace Homework.Documents
{
	internal static class DocumentXml
	{
		internal static Document ToDocument(string input)
		{
			var xDoc = XDocument.Parse(input);

			return new Document
			{
				Title = xDoc.Root.Element("title").Value,
				Text = xDoc.Root.Element("text").Value
			};
		}

		internal static string ToXml(Document doc)
		{
			Console.WriteLine(doc.GetType());
			var xmlSerializer = new XmlSerializer(typeof(Document));
			var xml = "";

			using (var stringWriter = new StringWriter())
			{
				using (XmlWriter writer = XmlWriter.Create(stringWriter))
				{
					xmlSerializer.Serialize(writer, doc);
					xml = stringWriter.ToString();
				}
			}
			return xml;
		}
	}
}
