using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abm_seminario_app
{
	public partial class DataEntry : Form
	{
		public DataEntry()
		{
			InitializeComponent();
		}

		private void DataEntry_Load(object sender, EventArgs e)
		{

		}

		private void btn_submit_data_Click(object sender, EventArgs e)
		{
			Queries queries = new Queries();

			Person newPerson = new Person();
			newPerson.dni = Convert.ToInt32(txb_dni.Text);
			newPerson.firstName = txb_firstName.Text;
			newPerson.lastName = txb_lastName.Text;
			newPerson.adress = txb_adress.Text;
			newPerson.phone = Convert.ToInt32(txb_phone.Text); ;
			newPerson.birthday = new DateTime(1950, 5, 18);

			try {
				bool response = queries.create_register(
				newPerson.dni,
				newPerson.firstName,
				newPerson.lastName,
				newPerson.adress,
				newPerson.phone,
				newPerson.birthday
				);

				if ( response ) {
					// Actualizar la tabla.

					// Cerrar el formulario
					this.Close();
					// Limpiar los campos.
					txb_dni.Text = "";
					txb_firstName.Text = "";
					txb_lastName.Text = "";
					txb_adress.Text = "";
					txb_phone.Text = "";
					txb_birthday.Text = ""; 
				}
			}
			catch {
				MessageBox.Show("Ha ocurrido un error..");
			}
			
			
			
		}
	}
}
