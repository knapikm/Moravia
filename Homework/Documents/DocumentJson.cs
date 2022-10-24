using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework.Documents
{
	public class DocumentJson : Document
	{
		private DocumentJson()
		{
		}
		public static Document FromJson(string input)
		{
			return JsonConvert.DeserializeObject<Document>(input);
		}

		public static string ToJson(Document value)
		{
			return JsonConvert.SerializeObject(value);
		}
	}
}
