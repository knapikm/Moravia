using Homework.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
	internal static class Utils
	{
		public static DocumentType GetDocumentType(string fileExtension)
		{
			DocumentType type;
			Enum.TryParse(fileExtension.ToUpper().Replace(".", ""), out type);
			return type;
		}
	}
}
