using QtGui;
using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QtSharpDemos.media;

namespace QtSharpDemos.GuiExample
{
    /// <summary>
    /// Container for QToolBar
    /// </summary>
    public class ToolbarDemo : QWidget
    {
        public ToolbarDemo()
        {
            WindowTitle = "Simple toolbar demo";
            // add toolbar to widget
            var toolbar = new QToolBar(this);
            InitUI(toolbar);

            Resize(250, 200);
            //Move(100, 100);
            Show();
        }

        private void InitUI(QToolBar toolbar)
        {
            toolbar.AddAction(MediaIconHelper.NewDocumentIcon, "New File");
            toolbar.AddAction(MediaIconHelper.OpenDocumentIcon, "Open File");
            toolbar.AddSeparator();
            QAction quit = toolbar.AddAction(MediaIconHelper.SystemLogOugIcon, "Quit Application");

            quit.Triggered += Quit_Triggered;
        }

        private void Quit_Triggered(bool obj)
        {
            QApplication.CloseAllWindows();
        }

    }
}
