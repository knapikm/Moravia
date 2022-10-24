using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Homework.Documents
{
	public class Document
	{
		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("text")]
		public string Text { get; set; }

		public Document()
		{
		}

		#region JSON
		public static Document FromJson(string input)
		{
			return JsonConvert.DeserializeObject<Document>(input);
		}

		public static string ToJson(Document value)
		{
			return JsonConvert.SerializeObject(value);
		}
		#endregion

		#region XML
		public static Document FromXml(string input)
		{
			var xDoc = XDocument.Parse(input);

			return new Document
			{
				Title = xDoc.Root.Element("title").Value,
				Text = xDoc.Root.Element("text").Value
			};
		}

		public static string ToXml(Document doc)
		{
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
		#endregion
	}
}