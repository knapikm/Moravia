using Newtonsoft.Json;
using System.Xml;
using System.Xml.Serialization;

namespace Homework.Documents
{
	public enum DocumentType { JSON, XML }; // TODO: another formats....

	public class Document
	{
		// TODO: this also could be done other way, in App.config eg.
		private const string TITLE = "title";
		private const string TEXT = "text";

		[JsonProperty(TITLE)]
		[XmlElement(TITLE)]
		public string Title { get; set; }

		[JsonProperty(TEXT)]
		[XmlElement(TEXT)]
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