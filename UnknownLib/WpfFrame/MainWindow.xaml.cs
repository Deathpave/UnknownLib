using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using UnknownLib.Hooks;
using UnknownLib.Managers;

namespace WpfFrame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //KeyboardHook hook = new KeyboardHook();
        HookManager hookManager = new HookManager();
        public MainWindow()
        {
            InitializeComponent();
            hookManager.KeyPressed += Test;
            hookManager.StartKeyboardHook();
            //KeyboardHook.KeyPressed += Test;
            //hook.StartHook();
        }

        public void Test(object sender, PropertyChangedEventArgs e)
        {
            //TextyBlock.Text = hook.Returnkey();
            TextyBlock.Text = hookManager.GetKeyboardKey();
        }
    }
}
