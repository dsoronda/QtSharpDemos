using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QtCore;

namespace QtSharpDemos.GuiExample
{
    class QtQuitButtonDemo1 : QtWidgets.QWidget
    {
        public QtQuitButtonDemo1()
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

            // Connect button signal to appropriate slot
            // This is from : [Qt documentation] (https://wiki.qt.io/How_to_Use_QPushButton)
            //connect(m_button, SIGNAL(released()), this, SLOT(handleButton()));
           // Connect(quitButton, SIGNAL(clicked()), this, SLOT(quit()));
            Connect(quitButton, "clicked()", this.ParentWidget,  "quit()");
            // resize button
            quitButton.SetGeometry(50, 50, 80, 30);
        }
    }
}
