using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QtCore;

namespace QtSharpDemos.GuiExample
{
    class QuitButtonDemo : QtWidgets.QWidget
    {
        public QuitButtonDemo()
        {
            WindowTitle = "Quit button";

            InitUI();

            Resize(300, 200);
            Move(200, 200);
            Show();
        }

        public void InitUI()
        {
            var quitButton = new QtWidgets.QPushButton("Quit", this);

            var method = new QtCore.QMetaMethod();
            quitButton.Clicked += QuitButton_Clicked;
            quitButton.SetGeometry(50, 50, 80, 30);
        }

        private void QuitButton_Clicked(bool obj)
        {
            this.Close();
        }
    }
}
