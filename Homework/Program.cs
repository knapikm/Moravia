using System;
using System.Collections.Generic;
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

			var document = Document.FromXml(input);
			//var document = Document.FromJson(input);

			//var xdoc = XDocument.Parse(input);
			//var doc = new Document
			//{
			//	Title = xdoc.Root.Element("title").Value,
			//	Text = xdoc.Root.Element("text").Value
			//};

			var serializedDoc = Document.ToJson(document);
			//var serializedDoc = Document.ToXml(document);

			//var serializedDoc = JsonConvert.SerializeObject(document);

			var targetStream = File.Open(targetFileName, FileMode.Create, FileAccess.Write);
			var sw = new StreamWriter(targetStream);
			sw.Write(serializedDoc);
			sw.Close();

			//Console.ReadLine();
		}
	}
}