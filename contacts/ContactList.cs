using System;
using System.Collections;

namespace EMail.Contacts
{
	/// <summary>
	/// Lista de contactos
	/// </summary>
	public class ContactList
	{
		private ArrayList list;

		public ContactList()
		{
			list = new ArrayList();
		}

		
		public Contact this[int x] {
			get { return (Contact) list[x]; }
			set { list[x] = value; }				
		}

		public Contact[] Contacts {
			get { return (Contact[]) list.ToArray( typeof(Contact) ); }
			set { list = new ArrayList(value); }
		}

		public void Add (Contact contact) 
		{
			list.Add(contact);
		}

		public void Remove (Contact contact) {
			list.Remove(contact);
		}
	}
}
