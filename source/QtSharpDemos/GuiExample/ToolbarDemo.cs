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
    public class ToolbarDemo : QtWidgets.QWidget
    {
        public ToolbarDemo()
        {
            WindowTitle = "Simple menu demo";

            InitUI();

            Resize(250, 200);
            Move(100, 100);
            Show();
        }

        private void InitUI()
        {
            // Create main toolbar 

            var toolbar = new QToolBar("main toolbar", this);

            toolbar.AddAction(MediaIconHelper.NewDocumentIcon, "New File");
            toolbar.AddAction(MediaIconHelper.OpenDocumentIcon, "Open File");
            toolbar.AddSeparator();
            QAction quit = toolbar.AddAction(MediaIconHelper.SystemLogOugIcon, "Quit Application");

            quit.Triggered += Quit_Triggered;
        }
        
        private void Quit_Triggered(bool obj)
        {
            this.Close();
           // QApplication.Quit();
        }

    }
}
