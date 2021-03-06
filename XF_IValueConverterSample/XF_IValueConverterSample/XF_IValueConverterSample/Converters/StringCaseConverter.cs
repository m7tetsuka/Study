﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Xamarin.Forms;

namespace XF_IValueConverterSample.Converters
{
    class StringCaseConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // 例えば ConverterParameter=true とすると、parameter に string "true" が入ります。
            if (value == null)
                return 0;

            // parameter に "True" が指定されると ToUpper します。
            // TODO: parameter に switch の bool 値を参照させる
            if (System.Convert.ToBoolean(parameter))
            {
                return value.ToString().ToUpper();
            }
            else
            {
                return value.ToString().ToLower();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
