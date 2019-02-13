
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;

	using EMail.Contacts;

	/// <summary>
	///		Descripción breve de Contact.
	/// </summary>
	public partial class ContactViewer : System.Web.UI.UserControl
	{
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Introducir aquí el código de usuario para inicializar la página
		}

		public Contact DisplayedContact {
			get { return (Contact) ViewState["contact"]; }
			set { ViewState["contact"] = value; UpdateUI(); }
		}

		private void UpdateUI () {

			Contact contact = (Contact) ViewState["contact"];

			if (contact!=null) {
				LabelName.Text = contact.Name;
				LinkEMail.Text = contact.EMail;
				LinkEMail.NavigateUrl = "mailto:"+contact.EMail;
				LabelTelephone.Text = contact.Telephone;
				LabelMobile.Text = contact.Mobile;
				LabelFax.Text = contact.Fax;
				LabelAddress.Text = contact.Address.Replace("\n","<br>");
				LabelComments.Text = contact.Comments;

				ImagePhoto.ImageUrl = "contacts/"+contact.ImageURL;
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
		///		Método necesario para admitir el Diseñador. No se puede modificar
		///		el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}

