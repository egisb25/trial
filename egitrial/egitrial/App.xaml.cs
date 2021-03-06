﻿using System;
using System.IO;
using Xamarin.Forms;

namespace egitrial
{
    public partial class App : Application
    {
        public static string FolderPath { get; private set; }

        public App()
        {
            InitializeComponent();
            Plugin.Media.CrossMedia.Current.Initialize();
            FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
            MainPage = new NavigationPage(new NotesPage());
        }
        // ...
    }
}