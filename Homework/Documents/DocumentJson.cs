using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework.Documents
{
	internal static class DocumentJson
	{
		internal static Document ToDocument(string input)
		{
			return JsonConvert.DeserializeObject<Document>(input);
		}

		internal static string ToJson(Document doc)
		{
			return JsonConvert.SerializeObject(doc);
		}
	}
}
