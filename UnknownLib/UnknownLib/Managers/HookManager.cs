using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnknownLib.Hooks;

namespace UnknownLib.Managers
{
    public class HookManager
    {
        private KeyboardHook _keyboardhook = new KeyboardHook();

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
    }
}
