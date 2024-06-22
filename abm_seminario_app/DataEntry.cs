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
		public delegate void RecordCreatedEventHandler(object sender, EventArgs e);
		public event RecordCreatedEventHandler RecordCreated;
		private bool isEditMode;

		public DataEntry(bool isEditMode = false)
		{
			InitializeComponent();
			this.isEditMode = isEditMode;
			
		}
		private void DataEntry_Load(object sender, EventArgs e)
		{
			if (isEditMode)
			{
				btn_submit_data.Text = "Guardar cambios";
				btn_submit_data.BackColor = Color.FromArgb(100, 149, 237);

				txb_dni.Text = Variables.selectedClient.dni.ToString();
				txb_firstName.Text = Variables.selectedClient.firstName;
				txb_lastName.Text = Variables.selectedClient.lastName;
				txb_adress.Text = Variables.selectedClient.adress;
				txb_phone.Text = Variables.selectedClient.phone.Value.ToString();
				txb_birthday.Text = Variables.selectedClient.birthday.Value.ToString("yyyy-MM-dd");
			}
		}


		private void btn_submit_data_Click(object sender, EventArgs e)
		{
			Queries queries = new Queries();

			Person newPerson = new Person();
			newPerson.dni = Convert.ToInt32(txb_dni.Text);
			newPerson.firstName = txb_firstName.Text;
			newPerson.lastName = txb_lastName.Text;
			newPerson.adress = txb_adress.Text;
			newPerson.phone = Convert.ToInt32(txb_phone.Text);
			newPerson.birthday = DateTime.Parse(txb_birthday.Text);

			try
			{
				bool response;

				if (isEditMode)
				{
					response = queries.create_register(
						(int)newPerson.dni,
						newPerson.firstName,
						newPerson.lastName,
						newPerson.adress,
						(int)newPerson.phone,
						(DateTime)newPerson.birthday
					);
				}
				else
				{
					response = queries.create_register(
						 (int)newPerson.dni,
						newPerson.firstName,
						newPerson.lastName,
						newPerson.adress,
						(int)newPerson.phone,
						(DateTime)newPerson.birthday
					);
				}

				if (response)
				{
					RecordCreated?.Invoke(this, EventArgs.Empty);
					this.Close();

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ha ocurrido un error: " + ex.Message);
			}
		}
	}
}