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
using System.Windows.Shapes;

namespace NuGet.Packaging.VisualStudio
{
	/// <summary>
	/// Interaction logic for AddPlatformImplementationView.xaml
	/// </summary>
	public partial class AddPlatformImplementationView : Window
	{
		public AddPlatformImplementationView()
		{
			InitializeComponent();
		}

		void OnAcceptButtonClick(object sender, RoutedEventArgs e)
		{
			DialogResult = true;
			Close();
		}

		void OnCancelButtonClick(object sender, RoutedEventArgs e)
		{
			DialogResult = false;
			Close();
		}
	}
}
