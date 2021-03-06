using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace DataBinding
{
	public class PriceToBackgroundConverter : IValueConverter
	{
		public decimal MinimumPriceToHighlight
		{
			get;
			set;
		}

		public Brush HighlightBrush
		{
			get;
			set;
		}

		public Brush DefaultBrush
		{
			get;
			set;
		}

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			decimal price = (decimal)value;
			if (price >= MinimumPriceToHighlight)
				return HighlightBrush;
			else
				return DefaultBrush;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotSupportedException();
		}
	}


}
