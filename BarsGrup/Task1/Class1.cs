using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Class1
    {
        public event EventHandler<char>? OnKeyPressed;
        public void Run()
        {
            bool exitPressed = true;
            while (exitPressed)
            {
                var button = Console.ReadKey();
                OnKeyPressed?.Invoke(this, button.KeyChar);
                switch (char.ToLower(button.KeyChar))
                {
                    case 'c':
                        exitPressed = false;
                        break;
                    case 'с':
                        exitPressed = false;
                        break;
                }
            }
        }
    }
}
