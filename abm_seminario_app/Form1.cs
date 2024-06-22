using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abm_seminario_app
{
	public partial class form_principal : Form
	{
		public form_principal()
		{
			InitializeComponent();
		}

	
	

		private void form_principal_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void OnRecordCreated(object sender, EventArgs e)
		{
			LoadData();
		}

		private void LoadData()
		{
			try
			{
				Queries queries = new Queries();
				dgv_data.DataSource = queries.LeerRegistros();

				// Sacar la ultima fila que viene por defecto
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btn_newUser_Click(object sender, EventArgs e)
		{
			DataEntry formData = new DataEntry();
			formData.RecordCreated += new DataEntry.RecordCreatedEventHandler(this.OnRecordCreated);
			formData.ShowDialog();
		}

		private void btn_deleteUser_Click(object sender, EventArgs e)
		{
			System.Media.SystemSounds.Question.Play();
			try
			{
				Queries queries = new Queries();
				bool response = queries.delete_register(Variables.selectedClient.dni); // Querie al metodo para eliminar, pasando el dni como paremetro. 

				if (response) {
					MessageBox.Show("Cliente eliminado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
			
					LoadData(); //
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ha ocurrido un error: " + ex.Message);
				System.Media.SystemSounds.Hand.Play();
			}
		}
			
		

		private void row_selectionChanged(object sender, EventArgs e)
		{
			if (dgv_data.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dgv_data.SelectedRows[0];
				string birthdayString = selectedRow.Cells["FechNac"].Value.ToString();

				Variables.selectedClient.dni = Convert.ToInt32(selectedRow.Cells["dni"].Value);
				Variables.selectedClient.firstName = selectedRow.Cells["Nombre"].Value.ToString();
				Variables.selectedClient.lastName = selectedRow.Cells["Apellido"].Value.ToString();
				Variables.selectedClient.phone = Convert.ToInt32(selectedRow.Cells["Telefono"].Value);
				Variables.selectedClient.adress = selectedRow.Cells["Direccion"].Value.ToString();
				Variables.selectedClient.birthday = DateTime.Parse(birthdayString);
			}
		}
	}
}

















//Colors Palette: 
// 	RGB(7; 19; 21)		#071315		Fondo oscuro
// RGB(20; 55; 59)		#14373B		Fondo Claro
// RGB(33; 91; 97)		#215B61		Bordes Oscuro
// RGB(45; 128; 136)	#2D8088		Bordes claro
// RGB(56; 165; 176)	#38A5B0		Texto 