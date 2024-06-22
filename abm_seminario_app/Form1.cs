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



		private void btn_newUser_Click(object sender, EventArgs e)
		{
			DataEntry formData = new DataEntry();
			formData.ShowDialog();
		}

		private void form_principal_Load(object sender, EventArgs e)
		{
			try
			{
				Queries queries = new Queries();
				dgv_data.DataSource = queries.LeerRegistros();
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.ToString());
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