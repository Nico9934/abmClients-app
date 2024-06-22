using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace abm_seminario_app
{
	public class Validations
	{
		public static bool Complete(object obj)
		{
			foreach (PropertyInfo property in obj.GetType().GetProperties())
				{
					var value = property.GetValue(obj);
					if (value == null)
						return false;
					if (property.PropertyType == typeof(string) && string.IsNullOrWhiteSpace(value as string))
						return false;
					if (typeof(IEnumerable<object>).IsAssignableFrom(property.PropertyType) && !((IEnumerable<object>)value).Any())
						return false;
				}
			return true;
		}


		public static bool NameLastName(string nombreApellido)
		{
			string patron = @"^[a-zA-Z\s-]{1,50}$";
			return Regex.IsMatch(nombreApellido, patron);
		}
		public static bool Phone(string telefono)
		{
			string patron = @"^[0-9\s\-\(\)]{7,15}$";
			return Regex.IsMatch(telefono, patron);
		}
		public static bool Dni(string dni)
		{
			string patron = @"^\d{7,8}$";
			return Regex.IsMatch(dni, patron);
		}
		public static bool Email(string email)
		{
			string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
			return Regex.IsMatch(email, patron);
		}
		public static bool CreditCard(string numeroTarjeta)
		{
			string patron = @"^\d{16}$";
			return Regex.IsMatch(numeroTarjeta, patron);
		}

	}
}
