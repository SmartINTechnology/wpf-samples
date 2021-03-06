﻿using System;
using System.Windows.Data;

namespace IGShowcase.AirplaneSeatingChart.Converters
{
	/// <summary>
	/// Returns the resource URI for the different icons on the map
	/// </summary>
	public class AreaImageSourceConverter : IValueConverter
	{
		#region IValueConverter Members

		/// <summary>
		/// Modifies the source data before passing it to the target for display in the UI.
		/// </summary>
		/// <param name="value">The source data being passed to the target.</param>
		/// <param name="targetType">The <see cref="T:System.Type"/> of data expected by the target dependency property.</param>
		/// <param name="parameter">An optional parameter to be used in the converter logic.</param>
		/// <param name="culture">The culture of the conversion.</param>
		/// <returns>
		/// The value to be passed to the target dependency property.
		/// </returns>
		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
            var iconType = value as string;

            if (!string.IsNullOrEmpty(iconType))
            {

                switch (iconType)
                {
                    case "Lavatory":
                        return "/IGShowcase.AirplaneSeatingChart;component/Assets/Images/Lavatory.png";
                    case "Galley":
                        return "/IGShowcase.AirplaneSeatingChart;component/Assets/Images/Galley.png";
                    case "ExitLeft":
                        return "/IGShowcase.AirplaneSeatingChart;component/Assets/Images/ExitLeft.png";
                    case "ExitRight":
                        return "/IGShowcase.AirplaneSeatingChart;component/Assets/Images/ExitRight.png";
                }
            }
            return null;
		}

		/// <summary>
		/// Modifies the target data before passing it to the source object.  This method is called only in <see cref="F:System.Windows.Data.BindingMode.TwoWay"/> bindings.
		/// </summary>
		/// <param name="value">The target data being passed to the source.</param>
		/// <param name="targetType">The <see cref="T:System.Type"/> of data expected by the source object.</param>
		/// <param name="parameter">An optional parameter to be used in the converter logic.</param>
		/// <param name="culture">The culture of the conversion.</param>
		/// <returns>
		/// The value to be passed to the source object.
		/// </returns>
		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
