
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;

	using EMail.Contacts;

	/// <summary>
	///		Descripci�n breve de ContactEditor.
	/// </summary>
	public partial class ContactEditor : System.Web.UI.UserControl
	{
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Introducir aqu� el c�digo de usuario para inicializar la p�gina
		}

		
		public Contact DisplayedContact {

			get { return UpdatedContact(); }
			set { ViewState["contact"] = value; UpdateUI(); }
		}

		private void UpdateUI () {

			Contact contact = (Contact) ViewState["contact"];

			if (contact!=null) {
				TextBoxName.Text = contact.Name;
				TextBoxEMail.Text = contact.EMail;
				TextBoxTelephone.Text = contact.Telephone;
				TextBoxMobile.Text = contact.Mobile;
				TextBoxFax.Text = contact.Fax;
				TextBoxAddress.Text = contact.Address;
				TextBoxComments.Text = contact.Comments;
				ImagePhoto.ImageUrl = "contacts/"+contact.ImageURL;
			}
		}

		private Contact UpdatedContact () {

			Contact contact = (Contact) ViewState["contact"];

			if (contact!=null) {
				contact.Name = TextBoxName.Text;
				contact.EMail = TextBoxEMail.Text;
				contact.Telephone = TextBoxTelephone.Text;
				contact.Mobile = TextBoxMobile.Text;
				contact.Fax = TextBoxFax.Text;
				contact.Address = TextBoxAddress.Text;
				contact.Comments = TextBoxComments.Text;


				if ((FilePhoto.PostedFile != null) && (FilePhoto.PostedFile.ContentLength>0)) {

					// File name

					string filename = Utils.GetRightFileName(contact.Name);
					string extension = "";

					if (FilePhoto.PostedFile.ContentType.IndexOf("jpeg")>-1)
						extension = "jpg";
					else if (FilePhoto.PostedFile.ContentType.IndexOf("gif")>-1)
						extension = "gif";
					else if (FilePhoto.PostedFile.ContentType.IndexOf("png")>-1)
						extension = "png";
								
					string path =  Server.MapPath("contacts/image")+"/"+filename+"."+extension;

					// Upload

					try {
						FilePhoto.PostedFile.SaveAs(path);
						contact.ImageURL = "image/"+filename+"."+extension;
					} catch {
					}
				
				} 
			}

			return contact;
		}



		#region C�digo generado por el Dise�ador de Web Forms
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: llamada requerida por el Dise�ador de Web Forms ASP.NET.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		///		M�todo necesario para admitir el Dise�ador. No se puede modificar
		///		el contenido del m�todo con el editor de c�digo.
		/// </summary>
		private void InitializeComponent()
		{
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}

