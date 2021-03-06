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

namespace FileAndFolderDialog.Wpf.Samples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void SelectFileButton_Click(object sender, RoutedEventArgs e)
        {

            //this is just a sample so don't go hatin' on my failure to use an IoC container and that i'm not using a ViewModel to ViewModel Navigation Model
            var vm = new ViewModels.SelectFileDialogExampleViewModel(new FileAndFolderDialog.Wpf.FileDialogService());
            var w = new Views.SelectFileDialogExampleView();
            w.DataContext = vm;
            w.ShowDialog();
        }

        private void SaveFileButton_Click(object sender, RoutedEventArgs e)
        {

            //this is just a sample so don't go hatin' on my failure to use an IoC container and that i'm not using a ViewModel to ViewModel Navigation Model
            var vm = new ViewModels.SaveFileDialogExampleViewModel(new FileAndFolderDialog.Wpf.FileDialogService());
            var w = new Views.SaveFileDialogExampleView();
            w.DataContext = vm;
            w.ShowDialog();
        }

        private void SelectFolderButton_Click(object sender, RoutedEventArgs e)
        {
            //this is just a sample so don't go hatin' on my failure to use an IoC container and that i'm not using a ViewModel to ViewModel Navigation Model
            var vm = new ViewModels.SelectFolderDialogExampleViewModel(new FileAndFolderDialog.Wpf.FolderDialogService());
            var w = new Views.SelectFolderDialogExampleView();
            w.DataContext = vm;
            w.ShowDialog();
        }
    }
}
