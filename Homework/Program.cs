using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml.Linq;
using Homework;
using Homework.Documents;
using Homework.Storages;
using Newtonsoft.Json;

namespace Moravia.Homework
{
	class Program
	{
		static void Main(string[] args)
		{
			var sourceFileName = Path.Combine(Environment.CurrentDirectory, "..\\..\\..\\SourceFiles\\Document2.json");
			var targetFileName = Path.Combine(Environment.CurrentDirectory, "..\\..\\..\\TargetFiles\\Document2.xml");

			var input = Storage.ReadSource(sourceFileName, StorageType.FS);

			var sourceType = Utils.GetDocumentType(sourceFileName);
			var document = Document.FromSource(input, sourceType);

			var targetType = Utils.GetDocumentType(targetFileName);
			var output = Document.ToTarget(document, targetType);

			Storage.WriteTarget(output, targetFileName, StorageType.FS);

			//Console.ReadLine();
		}
	}
}