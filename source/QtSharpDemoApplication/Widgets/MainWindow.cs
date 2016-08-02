using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtSharpDemoApplication.Widgets
{
    /// <summary>
    /// This is main application window
    /// More info here [QMainWindow](http://doc.qt.io/qt-5/qmainwindow.html#details)
    /// </summary>
    public class MainWindow : QtWidgets.QMainWindow
    {
        public MainWindow()
        {
            WindowTitle = "Test application";

            // main window already have QMenuBar
            MyMenuBarHelper.InitMenuBarUI(this.MenuBar);

            // We may have more than one Toolbar, so we create one and add it to main window
            this.AddToolBar(new MyToolbar());

            // main window already have status bar, 
            // it's not displayed until we reference it linke in next line
            MyStatusBarHelper.InitStatusBarUI(this.StatusBar);

            // NOTE : Central widget is required !
            this.CentralWidget = new QLabel("Hello world");
            Resize(640, 480);
            Show();
        }

    }
}
