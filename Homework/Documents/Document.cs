using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
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

		public static Document FromSource(string input, DocumentType sourceType)
		{
			switch (sourceType)
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
		
		public static string ToTarget(Document document, DocumentType targetType)
		{
			switch (targetType)
			{
				case DocumentType.JSON:
					return DocumentJson.ToJson(document);

				case DocumentType.XML:
					return DocumentXml.ToXml(document);

				// TODO: another formats....
				
				default:
					return null;
			}
		}
	}
}