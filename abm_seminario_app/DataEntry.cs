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
				txb_dni.Enabled = false;
				txb_dni.ForeColor = Color.White;
				btn_submit_data.Text = "Guardar cambios";
				btn_submit_data.BackColor = Color.FromArgb(100, 149, 237);

				txb_dni.Text = Variables.selectedClient.dni.ToString();
				txb_firstName.Text = Variables.selectedClient.firstName;
				txb_lastName.Text = Variables.selectedClient.lastName;
				txb_adress.Text = Variables.selectedClient.adress;
				txb_phone.Text = Variables.selectedClient.phone;
				txb_year.Text = Variables.selectedClient.year;
				txb_month.Text = Variables.selectedClient.month; 
				txb_day.Text = Variables.selectedClient.day;
			}
		}

		private void btn_submit_data_Click(object sender, EventArgs e)
		{
			Queries queries = new Queries();

			if (!(Validations.Dni(txb_dni.Text))) error_dni.SetError(txb_dni, "Ingresa un DNI válido");
			else if (!(Validations.NameLastName(txb_firstName.Text))) error_firstName.SetError(txb_firstName, "Ingresa un nombre válido");
			else if (!(Validations.NameLastName(txb_lastName.Text))) error_lastName.SetError(txb_lastName, "Ingresa un apellido válido");
			//else if (Validar Direccion sin caracteres especiales)
			else if (!(Validations.Phone(txb_phone.Text))) error_phone.SetError(txb_phone, "Ingresa un telefono válido");
			else if (!Validations.Birthday(txb_year.Text, txb_month.Text, txb_day.Text)) error_birthday.SetError(txb_year, "Ingresa una fecha correcta");
			else
			{
				Person newPerson = new Person();
				newPerson.dni = Convert.ToInt32(txb_dni.Text);
				newPerson.firstName = txb_firstName.Text;
				newPerson.lastName = txb_lastName.Text;
				newPerson.adress = txb_adress.Text;
				newPerson.phone = txb_phone.Text;
				newPerson.year = txb_year.Text;
				newPerson.month = txb_month.Text;
				newPerson.day = txb_day.Text;

				int year = Convert.ToInt32(newPerson.year);
				int month = Convert.ToInt32(newPerson.month);
				int day = Convert.ToInt32(newPerson.day);

				newPerson.birthday = new DateTime(year, month, day);
				try
				{
					bool response;

					if (isEditMode) response = queries.update_register((int)newPerson.dni, newPerson.firstName, newPerson.lastName, newPerson.adress, newPerson.phone, (DateTime)newPerson.birthday);
					else response = queries.create_register((int)newPerson.dni, newPerson.firstName, newPerson.lastName, newPerson.adress, newPerson.phone, (DateTime)newPerson.birthday);
					
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
}