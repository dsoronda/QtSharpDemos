using QtGui;
using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtSharpDemos.GuiExample
{
    public class LabelDemo : QtWidgets.QWidget
    {
        public LabelDemo()
        {
            WindowTitle = "Label demo";

            InitUI();

            Resize(250, 150);
            Move(300, 300);
            Show();
        }

        public void InitUI()
        {
            string text = @"To be or not to be,
is that a question ?";

            var label = new QLabel(text, this);
            label.Font = new QFont("Purisa", 9);

            var vbox = new QVBoxLayout();
            vbox.AddWidget(label);
            Layout = vbox;
        }
    }
}
