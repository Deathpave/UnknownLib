﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using UnknownLib.Hooks;

namespace LibTesterUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        KeyboardHook hook = new KeyboardHook();
        public MainWindow()
        {
            InitializeComponent();
            KeyboardHook.KeyPressed += Test();
            hook.StartHook();
        }

        public void Test()
        {
            Textyblock.Text = hook.Returnkey();
        }
    }
}
