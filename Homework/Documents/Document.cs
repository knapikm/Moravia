using Newtonsoft.Json;
using System.Xml;
using System.Xml.Serialization;

namespace Homework.Documents
{
	public enum DocumentType { JSON, XML };

	public class Document
	{
		[JsonProperty("title")]
		[XmlElement("title")]
		public string Title { get; set; }

		[JsonProperty("text")]
		[XmlElement("text")]
		public string Text { get; set; }

		public Document()
		{
		}

		public static Document FromInput(string input, DocumentType inputType)
		{
			switch (inputType)
			{
				case DocumentType.JSON: 
					return DocumentJson.ToDocument(input);

				case DocumentType.XML:
					return DocumentXml.ToDocument(input);

				// TODO: another formats....

				default:
					return null;
			}
		}
		
		public static string ToOutput(Document doc, DocumentType outputType)
		{
			switch (outputType)
			{
				case DocumentType.JSON:
					return DocumentJson.ToJson(doc);

				case DocumentType.XML:
					return DocumentXml.ToXml(doc);

				// TODO: another formats....
				
				default:
					return null;
			}
		}
	}
}