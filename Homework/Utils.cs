using Homework.Documents;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
	internal static class Utils
	{
		public static DocumentType GetDocumentType(string fileName)
		{
			var extension = Path.GetExtension(fileName);
			DocumentType type;

			Enum.TryParse(extension.ToUpper().Replace(".", ""), out type);
			return type;
		}
	}
}
