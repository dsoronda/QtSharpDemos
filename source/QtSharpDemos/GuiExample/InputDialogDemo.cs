using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QtCore;
using QtGui;

namespace QtSharpDemos.GuiExample
{
    public class InputDialogDemo : QtWidgets.QWidget
    {
        QLineEdit edit;

        /// <summary>
        /// This program shows text which is entered in a QLineEdit widget in a QLabel widget.
        /// </summary>
        public InputDialogDemo()
        {
            WindowTitle = "InputDialog Demo";

            InitUI();

            Resize(350, 150);
            Move(300, 300);
            Show();
        }

        public void InitUI()
        {
            QPushButton show = new QPushButton("Dialog", this);
            show.Clicked += Show_Clicked;

            show.FocusPolicy = QtCore.Qt.FocusPolicy.NoFocus;
            show.Move(20, 20);

            edit = new QLineEdit(this);
            edit.Move(130, 22);
        }

        private void Show_Clicked(bool obj)
        {
            String text = QInputDialog.GetText(this, "Input Dialog", "Enter something");

            if (!string.IsNullOrWhiteSpace(text))
            {
                edit.Text = text;
            }
        }
       
    }
}