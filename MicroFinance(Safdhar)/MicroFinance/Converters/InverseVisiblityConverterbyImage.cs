﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace MicroFinance.Converters
{
    class InverseVisiblityConverterbyImage : IValueConverter
    {
        public InverseVisiblityConverterbyImage()
        {

        }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            
            if ((BitmapImage)value == null)
            {
                return Visibility.Visible;
            }
            else
            {
                return Visibility.Hidden;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}