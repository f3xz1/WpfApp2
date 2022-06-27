﻿
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Examen;
namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            //View
            var view = new MainWindow();
            //Model
            var model = new FakeGradeModel();
            //Presenter
            var presenter = new GradePresenter(model, view);

            this.MainWindow = view;
            this.MainWindow.ShowDialog();
        }
    }
}
