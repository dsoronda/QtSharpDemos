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
        // NOTE : This is not proper way to handle actions across Widgets
        // Have to check how Qt examples handle this
        // Just wanted to see if this works
        Dictionary<string, QAction> ActionDictionary = new Dictionary<string, QAction>();

        public MainWindow()
        {
            WindowTitle = "Test application";
            this.ActionDictionary.Add("About", GetAboutActions(this));
            // main window already have QMenuBar
            MyMenuBarHelper.InitMenuBarUI(this.MenuBar, ActionDictionary);
           // this.MenuBar.AddAction();

            // We may have more than one Toolbar, so we create one and add it to main window
            this.AddToolBar(new MyToolbar(ActionDictionary));

            // main window already have status bar, 
            // it's not displayed until we reference it linke in next line
            MyStatusBarHelper.InitStatusBarUI(this.StatusBar);

            // NOTE : Central widget is required !
            this.CentralWidget = new QLabel("Hello world");
            Resize(640, 480);
            Show();
        }

        private QAction GetAboutActions(MainWindow mainWindow)
        {
            var aboutAction = new QAction(media.MediaIconHelper.InformationIcon, "&About", null);

            //aboutAction.SetShortcuts(QKeySequence.Open);
            aboutAction.StatusTip = "Show about dialog";
            aboutAction.Triggered += AboutAction_Triggered;

            //aboutAction(openAct, SIGNAL(triggered()), this, SLOT(open()));

            //fileMenu->addAction(openAct);
            //fileToolBar->addAction(openAct);
            return aboutAction;
        }

        private void AboutAction_Triggered(bool obj)
        {
            // show about dialog
            QMessageBox.About(this, "About", "QtSharp Message box example."); ;
        }
    }
}
