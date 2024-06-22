using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
	}
}
