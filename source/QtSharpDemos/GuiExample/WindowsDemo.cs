using QtCore.Qt;
using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtSharpDemos.GuiExample
{
    class WindowsDemo : QtWidgets.QWidget
    {
        /// <summary>
        ///  Demo use box layouts  to create a windows example.
        /// </summary>
        public WindowsDemo()
        {
            WindowTitle = "Window demo";

            InitUI();

            Resize(350, 300);
            Move(300, 300);
            Show();
        }
        void InitUI()
        {
            var vbox = new QVBoxLayout(this);

            var vbox1 = new QVBoxLayout();
            var hbox1 = new QHBoxLayout();
            var hbox2 = new QHBoxLayout();

            var windLabel = new QLabel("Windows", this);
            var edit = new QTextEdit(this);
            edit.Enabled = false;

            var activate = new QPushButton("Activate", this);
            var close = new QPushButton("Close", this);
            var help = new QPushButton("Help", this);
            var ok = new QPushButton("OK", this);

            vbox.AddWidget(windLabel);

            vbox1.AddWidget(activate);
            vbox1.AddWidget(close, 0, AlignmentFlag.AlignTop);
            hbox1.AddWidget(edit);
            hbox1.AddLayout(vbox1);

            vbox.AddLayout(hbox1);

            hbox2.AddWidget(help);
            hbox2.AddStretch(1);
            hbox2.AddWidget(ok);

            vbox.AddLayout(hbox2, 1);

            Layout = vbox;
        }
    }
}
