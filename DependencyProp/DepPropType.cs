using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace DependencyProp
{
    public class DepPropType : DependencyObject
    {


        public string SetText
        {
            get { return (string)GetValue(SetTextProperty); }
            set { SetValue(SetTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SetText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SetTextProperty =
            DependencyProperty.Register("SetText", typeof(string), typeof(DepPropType), new PropertyMetadata("", new PropertyChangedCallback(OnSetTextChanged)));

        private static void OnSetTextChanged(DependencyObject d,
         DependencyPropertyChangedEventArgs e)
        {
            DepPropType UserControl1Control = d as DepPropType;
            UserControl1Control.OnSetTextChanged(e);
        }

        private void OnSetTextChanged(DependencyPropertyChangedEventArgs e)
        {
            Text = e.NewValue.ToString();
        }

    }
}
