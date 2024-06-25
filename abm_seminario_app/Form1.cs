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
				dgv_data.DataSource = queries.read_registers();
				dgv_data.RowPostPaint += new DataGridViewRowPostPaintEventHandler(dgv_data_RowPostPaint);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ha ocurrido un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void btn_newUser_Click(object sender, EventArgs e)
		{
			Functions.clean_fields();
			DataEntry formData = new DataEntry();
			formData.RecordCreated += new DataEntry.RecordCreatedEventHandler(this.OnRecordCreated);
			formData.ShowDialog();
		}
		private void btn_deleteUser_Click(object sender, EventArgs e)
		{
			try
			{
				Queries queries = new Queries();
				bool response = queries.delete_register((int)Variables.selectedClient.dni); // Querie al metodo para eliminar, pasando el dni como paremetro. 

				if (response) {
				
			
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
				Variables.selectedClient.phone = selectedRow.Cells["Telefono"].Value.ToString();
				Variables.selectedClient.adress = selectedRow.Cells["Direccion"].Value.ToString();
				Variables.selectedClient.birthday = DateTime.Parse(birthdayString);

			}

			if (dgv_data.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dgv_data.SelectedRows[0];
				string birthdayString = selectedRow.Cells["FechNac"].Value.ToString();

				Variables.selectedClient.dni = Convert.ToInt32(selectedRow.Cells["dni"].Value);
				Variables.selectedClient.firstName = selectedRow.Cells["Nombre"].Value.ToString();
				Variables.selectedClient.lastName = selectedRow.Cells["Apellido"].Value.ToString();
				Variables.selectedClient.phone = selectedRow.Cells["Telefono"].Value.ToString();
				Variables.selectedClient.adress = selectedRow.Cells["Direccion"].Value.ToString();

				// Asegurarse de convertir correctamente el string a DateTime
				Variables.selectedClient.birthday = DateTime.Parse(birthdayString);

				// Verificar si birthday tiene valor y extraer año, mes y día
				if (Variables.selectedClient.birthday.HasValue)
				{
					DateTime birthday = Variables.selectedClient.birthday.Value;
					int year = birthday.Year;
					int month = birthday.Month;
					int day = birthday.Day;

					// Asignar los valores a las variables correspondientes
					Variables.selectedClient.year = year.ToString();
					Variables.selectedClient.month = month.ToString();
					Variables.selectedClient.day = day.ToString();
				}
				else
				{
					// Manejar el caso cuando birthday no tiene valor
					Variables.selectedClient.year = null;
					Variables.selectedClient.month = null;
					Variables.selectedClient.day = null;
				}
			}
		}
		private void btn_updateUser_Click(object sender, EventArgs e)
		{
			DataEntry formData = new DataEntry(true); // true indica modo edición
			formData.RecordCreated += new DataEntry.RecordCreatedEventHandler(this.OnRecordCreated);
			formData.ShowDialog();
		}

		private void dgv_data_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
		{
			using (Pen pen = new Pen(Color.FromArgb(26, 27, 63)))
			{
				int rowIndex = e.RowIndex;
				DataGridViewRow row = dgv_data.Rows[rowIndex];
				Rectangle rowBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, e.RowBounds.Width, e.RowBounds.Height);

				e.Graphics.DrawLine(pen, rowBounds.Left, rowBounds.Bottom - 1, rowBounds.Right, rowBounds.Bottom - 1);
			}
		}

		private void btn_sendMessage_Click(object sender, EventArgs e)
		{
			if (dgv_data.SelectedRows.Count > 0)
			{
				var selectedRow = dgv_data.SelectedRows[0];
				string phoneNumber = selectedRow.Cells["Telefono"].Value.ToString();
				Functions.send_message(phoneNumber, "Esto es un mensaje personalizado...");
			}
			else
			{
				MessageBox.Show("Seleccione un cliente de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dgv_data_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0) 
			{
				dgv_data.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 63 );
			}
		}

		private void dgv_data_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0) 
			{
				dgv_data.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(35, 35, 79);
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