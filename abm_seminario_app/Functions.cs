using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abm_seminario_app
{
	public class Functions
	{
		public static void clean_fields()
		{
			Variables.selectedClient.dni = null;
			Variables.selectedClient.firstName = null;
			Variables.selectedClient.lastName = null;
			Variables.selectedClient.adress = null;
			Variables.selectedClient.phone = null; 
			Variables.selectedClient.birthday = null;
		}

		public static void send_message(string phoneNumber, string message)
		{
			string url = $"https://api.whatsapp.com/send?phone={phoneNumber}&text={Uri.EscapeDataString(message)}";
			try
			{
				System.Diagnostics.Process.Start(url);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al abrir WhatsApp: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
