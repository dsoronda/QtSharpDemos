using QtGui;
using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtSharpDemos.GuiExample
{
    public class SimpleMenuDemo : QtWidgets.QWidget
    {
        public SimpleMenuDemo()
        {
            WindowTitle = "Simple menu demo";

            InitUI();

            Resize(250, 200);
            Move(100, 100);
            Show();
        }

        private void InitUI()
        {
            var quit = new QAction("&Quit", this);
            var menu = new QMenuBar(this);

            var file = menu.AddMenu("&File");
            file.AddAction(quit);

            quit.Triggered += Quit_Triggered;
        }

        private void Quit_Triggered(bool obj)
        {
            this.Close();
        }

    }
}
