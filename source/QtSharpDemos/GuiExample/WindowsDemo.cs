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
            this.Layout = GenerateLayout();

            Resize(350, 300);
            Move(300, 300);
            Show();
        }
        void InitUI()
        {

        }

        /// <summary>
        /// Generate 
        /// </summary>
        /// <returns></returns>
        public static QLayout GenerateLayout()
        {
            //var vbox = new QVBoxLayout(parentWidget);
            var vbox = new QVBoxLayout();

            vbox.AddWidget(new QLabel("Windows"));

            var vbox1 = new QVBoxLayout();
            vbox1.AddWidget(new QPushButton("Activate"));
            vbox1.AddWidget(new QPushButton("Close"), 0, AlignmentFlag.AlignTop);

            var hbox1 = new QHBoxLayout();
            hbox1.AddWidget(new QTextEdit() { Enabled = false });
            hbox1.AddLayout(vbox1);

            vbox.AddLayout(hbox1);

            var hbox2 = new QHBoxLayout();
            hbox2.AddWidget(new QPushButton("Help"));
            hbox2.AddStretch(1);
            hbox2.AddWidget(new QPushButton("OK"));

            vbox.AddLayout(hbox2, 1);

            return vbox;
            //parentWidget.Layout = vbox;
        }
    }
}
