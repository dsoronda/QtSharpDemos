using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QtCore;
using QtGui;
using QtWidgets;

namespace QtSharpDemos.GuiExample
{
    class AbsolutePositionDemo : QtWidgets.QWidget
    {
        public AbsolutePositionDemo()
        {
            WindowTitle = "Absolute position demo";

            InitUI();

            Resize(300, 280);
            Move(300, 300);
            Show();
        }

        void InitUI()
        {
            StyleSheet = "QWidget { background-color: #414141 }";

            var qt_icon = new QPixmap(@"media\gfx\Apps-Qt-icon.png");
            //var rotunda = new QPixmap("rotunda.jpg");
            //var mincol = new QPixmap("mincol.jpg");

            var barLabel = new QLabel(this);
            barLabel.Pixmap = qt_icon;
            barLabel.Move(20, 20);

            var rotLabel = new QLabel(this);
            rotLabel.Pixmap = qt_icon;
            rotLabel.Move(40, 160);

            var minLabel = new QLabel(this);
            minLabel.Pixmap = qt_icon;
            minLabel.Move(170, 50);
        }

    }
}
