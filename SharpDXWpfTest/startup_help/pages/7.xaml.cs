﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SharpDXWpfTest.startup_help.pages
{
    /// <summary>
    /// Interaction logic for _7.xaml
    /// </summary>
    public partial class _7 : Page
    {
        public _7()
        {
            InitializeComponent();
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            image_match.startup_help.startup_help wnd = Window.GetWindow(this) as image_match.startup_help.startup_help;
            wnd.navigate(e.Uri.ToString());
            e.Handled = true;
            return;
        }
    }
}
