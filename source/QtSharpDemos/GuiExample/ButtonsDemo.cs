using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QtCore;
using QtWidgets;
using QtCore.Qt;

namespace QtSharpDemos.GuiExample
{
    class ButtonsDemo : QtWidgets.QWidget
    {
        public ButtonsDemo()
        {
            WindowTitle = "Buttons demo";

            InitUI();

            Resize(300, 150);
            Move(300, 300);
            Show();
        }

        void InitUI()
        {
            var vbox = new QVBoxLayout(this);
            var hbox = new QHBoxLayout();

            var ok = new QPushButton("OK", this);
            var apply = new QPushButton("Apply", this);

            hbox.AddWidget(ok, 1, AlignmentFlag.AlignRight);
            hbox.AddWidget(apply);

            vbox.AddStretch(1);
            vbox.AddLayout(hbox);
        }
    }
}
