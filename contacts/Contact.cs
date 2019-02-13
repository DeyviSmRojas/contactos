using System;

namespace EMail.Contacts
{
	/// <summary>
	/// Contacto
	/// </summary>
	
	[Serializable]
	public class Contact
	{
		public string Name;
		public string EMail;
		public string Telephone;
		public string Mobile;
		public string Fax;
		public string Address;
		public string Comments;
		public string ImageURL;
		
		public Contact()
		{
		}
	}
}
