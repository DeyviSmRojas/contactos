using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

using System.IO;
using EMail.Contacts;


	/// <summary>
	/// Descripción breve de Contacts.
	/// </summary>
	public partial class Contacts : System.Web.UI.Page
	{

		private void Page_Load(object sender, System.EventArgs e)
		{
			if (!Page.IsPostBack) {
				UpdateList();
				ResetUI();
			}
		}

		private void ResetUI () 
		{
			Contact contact = GetSelectedContact();

			ShowContact(contact);
			/*
			Header.Visible = false;
			ContactView.Visible = false;
			ContactEdit.Visible = false;
			ButtonSave.Visible = false;
			ButtonEdit.Visible = false;
			ButtonDelete.Visible = false;
			*/
		}

		private void UpdateList () {

			DirectoryInfo di;
			SortedList    list = new SortedList();
			FileInfo[]    fi;
			Contact       contact;

			di = new DirectoryInfo( Server.MapPath("contacts") );
						
			if (di!=null) {

				fi = di.GetFiles();
				
				foreach (FileInfo file in fi) {
					contact = GetContact( file.Name );				

					if (contact!=null)
						list.Add(contact.Name, file.Name);
				}

				ContactList.Items.Clear();
				ContactList.DataSource = list;
				ContactList.DataTextField = "Key";
				ContactList.DataValueField = "Value";
				ContactList.DataBind();

				Header.Visible = false;
			}
		}

		#region Código generado por el Diseñador de Web Forms
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: llamada requerida por el Diseñador de Web Forms ASP.NET.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{    
			this.ButtonShow.Click += new System.EventHandler(this.ButtonShow_Click);
			this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
			this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
			this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
			this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
			this.ContactList.SelectedIndexChanged += new System.EventHandler(this.ContactList_SelectedIndexChanged);
			this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void ContactList_SelectedIndexChanged(object sender, System.EventArgs e) 
		{
			Contact contact = GetSelectedContact();
			ShowContact(contact);
		}	

		private Contact GetSelectedContact () 
		{
			string  filename;
			Contact contact = null;
			
			if (ContactList.SelectedItem!=null) {
				filename = ContactList.SelectedItem.Value;
				contact = GetContact(filename);				
			}

			return contact;
		}

		private void SetSelectedContact (Contact contact) {

			int i;

			for (i=0; i<ContactList.Items.Count; i++)
				if (ContactList.Items[i].Text == contact.Name)
					ContactList.SelectedIndex = i;
		}

		private void SaveContact (Contact contact) {

			DeleteContact(LabelContact.Text);  // Name change -> File name change
			StoreContact(contact);

			UpdateList();
			SetSelectedContact(contact);
		}

		private void ShowContact (Contact contact) 
		{
			if (contact!=null) {
				ContactView.DisplayedContact = contact;
				LabelContact.Text = contact.Name;
				Header.Visible = true;
				ContactView.Visible = true;
				ContactEdit.Visible = false;
				ButtonSave.Visible = false;
				ButtonDelete.Visible = false;
				ButtonCancel.Visible = false;
				ButtonEdit.Visible = true;
			}
		}

		private void EditContact (Contact contact) {

			if (contact!=null) {
				ContactEdit.DisplayedContact = contact;
				LabelContact.Text = contact.Name;
				Header.Visible = true;
				ContactView.Visible = false;
				ContactEdit.Visible = true;
				ButtonSave.Visible = true;
				ButtonDelete.Visible = true;
				ButtonCancel.Visible = true;
				ButtonEdit.Visible = false;
			}
		}

		// Contact file management

		private string ContactFileName (string contactName) 
		{
			return Utils.GetRightFileName(contactName)+".xml";
		}

		private Contact GetContact (string filename) 
		{
			string path = Server.MapPath("contacts")+"/"+filename;
			FileInfo fi = new FileInfo ( path );

			if (fi.Exists)
			    return (Contact) Utils.Deserialize(typeof(Contact), fi.FullName );
			else
				return null;
		}

		private void DeleteContact (string contactName) 
		{
			string filename = ContactFileName(contactName);
			string path = Server.MapPath("contacts")+"/"+filename;

			try {
				File.Delete(path);
			} catch {
			}
		}

		private void StoreContact (Contact contact) 
		{
			string filename = ContactFileName(contact.Name);
			string path = Server.MapPath("contacts")+"/"+filename;
			
			Utils.Serialize(contact, path);
		}

		// CRUD

		private void ButtonEdit_Click(object sender, System.EventArgs e) {
			Contact contact = ContactView.DisplayedContact;
			EditContact(contact);		
		}

		private void ButtonShow_Click(object sender, System.EventArgs e) {
			
			Contact contact = GetSelectedContact();
			ShowContact(contact);
		}
		
		private void ButtonCreate_Click(object sender, System.EventArgs e) {
			Contact contact = new Contact();
			contact.Name = "Nuevo contacto";
			EditContact(contact);
		}

		private void ButtonSave_Click(object sender, System.EventArgs e) {
			Contact contact = ContactEdit.DisplayedContact;
			SaveContact(contact);
			ShowContact(contact);
		}

		private void ButtonDelete_Click(object sender, System.EventArgs e) 
		{
			DeleteContact (LabelContact.Text);
			UpdateList();
			ResetUI();
		}

		private void ButtonCancel_Click(object sender, System.EventArgs e) {
			Contact contact = GetSelectedContact();
			ShowContact(contact);
		}

	}
