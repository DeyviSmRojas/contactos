using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace EMail.Contacts
{
	/// <summary>
	/// Descripción breve de Utils.
	/// </summary>
	public class Utils
	{
		public static void Serialize (object obj, string filename) {
			XmlSerializer serializer = new XmlSerializer (obj.GetType());
			TextWriter writer = new StreamWriter(filename, false, System.Text.Encoding.GetEncoding("ISO-8859-1"));
			serializer.Serialize (writer, obj);
			writer.Close();
		}


		public static object Deserialize (Type type, string filename) {

			object obj = null;

			XmlSerializer serializer = new XmlSerializer(type);
			TextReader stream = new StreamReader(filename,System.Text.Encoding.GetEncoding("ISO-8859-1"));
			XmlReader  reader = new XmlTextReader(stream);

			if (serializer.CanDeserialize(reader)) 
				obj = serializer.Deserialize (reader);

			reader.Close();
			stream.Close();
			
			return obj;
		}

		public static string GetRightFileName (string name) {

			string id = name;

			// Forbidden characters: \/:*?"<>|
			id = id.Replace("\\","");
			id = id.Replace("/","");
			id = id.Replace(":","");
			id = id.Replace("*","");
			id = id.Replace("?","");
			id = id.Replace("\"","");
			id = id.Replace("<","");
			id = id.Replace(">","");
			id = id.Replace("|-","");

			return id;
		}
	}
}
