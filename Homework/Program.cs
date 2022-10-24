using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml.Linq;
using Homework.Documents;
using Newtonsoft.Json;

namespace Moravia.Homework
{
	class Program
	{
		static void Main(string[] args)
		{
			var sourceFileName = Path.Combine(Environment.CurrentDirectory, "..\\..\\..\\SourceFiles\\Document1.xml");
			var targetFileName = Path.Combine(Environment.CurrentDirectory, "..\\..\\..\\TargetFiles\\Document1.json");

			// TODO: move read away
			string input;
			try
			{
				FileStream sourceStream = File.Open(sourceFileName, FileMode.Open);
				var reader = new StreamReader(sourceStream);
				input = reader.ReadToEnd();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

			var sourceExtension = Path.GetExtension(sourceFileName);
			var document = Document.FromSource(input, sourceExtension);


			var targetExtension = Path.GetExtension(targetFileName);
			var serializedDoc = Document.ToTarget(document, targetExtension);

			// TODO: move write away
			var targetStream = File.Open(targetFileName, FileMode.Create, FileAccess.Write);
			var sw = new StreamWriter(targetStream);
			sw.Write(serializedDoc);
			sw.Close();

			//Console.ReadLine();
		}
	}
}