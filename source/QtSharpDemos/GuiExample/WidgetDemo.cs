using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtSharpDemos.GuiExample
{
    /// <summary>
    /// Create simple Qt widget control.
    /// </summary>
    class WidgetDemo : QtWidgets.QWidget
    {
        const int WIDTH = 300;
        const int HEIGHT = 200;

        public WidgetDemo()
        {
            WindowTitle = "QtWidget Demo";
            ToolTip = "This is QT Qwidget";
            Resize(WIDTH, HEIGHT);
            Center();
            Show();
        }

        /// <summary>
        /// Center control on screen
        /// </summary>
        private void Center()
        {
            var desktopWidget = new QDesktopWidget();

            int screenWidth = desktopWidget.Width;
            int screenHeight = desktopWidget.Height;

            int centerX = (screenWidth - WIDTH) / 2;
            int centerY = (screenHeight - HEIGHT) / 2;

            Move(centerX, centerY);
        }

    }
}
