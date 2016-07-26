using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtSharpDemos.GuiExample
{
    public class LineEditDemo : QtWidgets.QWidget
    {
        QLabel label;

        /// <summary>
        /// This program shows text which is entered in a QLineEdit widget in a QLabel widget.
        /// </summary>
        public LineEditDemo()
        {
            WindowTitle = "LineEdit demo";

            InitUI();

            Resize(250, 150);
            Move(300, 300);
            Show();
        }

        public void InitUI()
        {
            label = new QLabel(this);

            QLineEdit edit = new QLineEdit(this);
            edit.TextChanged += OnChanged;
            edit.Text = "LineEdit demo";

            edit.Move(60, 100);
            label.Move(60, 40);
        }

        public void OnChanged(string text)
        {
            label.Text = text;
            label.AdjustSize();
        }
    }
}