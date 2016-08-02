using QtGui;
using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QtSharpDemoApplication.media;

namespace QtSharpDemoApplication.Widgets
{
    /// <summary>
    /// More info on [QStatusBar](http://doc.qt.io/qt-5/qstatusbar.html#details)
    /// </summary>
    public static class MyStatusBarHelper
    {
        public static void InitStatusBarUI(QStatusBar statusBar)
        {
            statusBar.SizeGripEnabled = true;
            statusBar.ShowMessage("program ready");
        }

    }
}
