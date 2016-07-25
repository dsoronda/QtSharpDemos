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
            Resize(800, 600);
            Show();
        }

        void InitUI()
        {
            StyleSheet = "QWidget { background-color: #7e7e7e }";

            var sky1_icon = new QPixmap(@"media\gfx\sky1.jpg");
            var sky2_icon = new QPixmap(@"media\gfx\sky2.jpg");
            var pancake_icon = new QPixmap(@"media\gfx\pancake.jpg");

            var pancakeLabel = new QLabel(this);
            pancakeLabel.Pixmap = pancake_icon.ScaledToHeight(320);
            pancakeLabel.Resize(pancakeLabel.Pixmap.Size);
            pancakeLabel.Move(170, 50);

            var skyLabel = new QLabel(this);
            skyLabel.Pixmap = sky1_icon.ScaledToHeight(160);
            skyLabel.Resize(skyLabel.Pixmap.Size);
            skyLabel.Move(20, 20);

            var sky2Label = new QLabel(this);
            sky2Label.Pixmap = sky2_icon.ScaledToHeight(120); ;
            sky2Label.Resize(sky2Label.Pixmap.Size);
            sky2Label.Move(40, 180);

 
        }

    }
}
