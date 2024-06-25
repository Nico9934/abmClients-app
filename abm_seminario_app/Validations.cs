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
		public static bool Dni(string dni)
		{
			string patron = @"^\d{7,8}$";
			return Regex.IsMatch(dni, patron);
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

		public static bool Birthday(string year, string month, string day)
		{
			// Verificar que los parámetros no estén vacíos
			if (string.IsNullOrEmpty(year) || string.IsNullOrEmpty(month) || string.IsNullOrEmpty(day))
			{
				return false;
			}

			// Verificar que el año tenga 4 dígitos
			if (year.Length != 4 || !int.TryParse(year, out int yearInt))
			{
				return false;
			}

			// Verificar que el mes sea un número válido y esté entre 1 y 12
			if (!int.TryParse(month, out int monthInt) || monthInt < 1 || monthInt > 12)
			{
				return false;
			}

			// Verificar que el día sea un número válido y esté entre 1 y 31
			if (!int.TryParse(day, out int dayInt) || dayInt < 1 || dayInt > 31)
			{
				return false;
			}

			return true;
		}
	}
}
