using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnknownLib.Hooks;

namespace UnknownLib.Managers
{
    public class HookManager : IDisposable
    {
        private KeyboardHook _keyboardhook = new KeyboardHook();
        public PropertyChangedEventHandler KeyPressed;

        public HookManager()
        {
            KeyboardHook.KeyPressed += Testing;
        }

        public void StartKeyboardHook()
        {
            _keyboardhook.StartHook();
        }

        public void StopKeyboardHook()
        {
            _keyboardhook.StopHook();
        }

        public string GetKeyboardKey()
        {
            return _keyboardhook.Returnkey();
        }

        private void Testing(object sender, PropertyChangedEventArgs e)
        {
            this.KeyPressed?.Invoke(e, null);
        }

        public void Dispose()
        {
            _keyboardhook = null;
            KeyPressed -= Testing;
        }
    }
}
