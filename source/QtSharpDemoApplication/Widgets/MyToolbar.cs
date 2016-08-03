using QtSharpDemoApplication.media;
using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtSharpDemoApplication.Widgets
{
    public class MyToolbar : QToolBar
    {
        public MyToolbar(Dictionary<string, QAction> actions)
        {
            // add toolbar to widget
            //var toolbar = new QToolBar(this);
            InitUI(this, actions);
        }

        private void InitUI(QToolBar toolbar, Dictionary<string, QAction> actions)
        {
            toolbar.AddAction(MediaIconHelper.NewDocumentIcon, "New File");
            toolbar.AddAction(MediaIconHelper.OpenDocumentIcon, "Open File");
            toolbar.AddSeparator();
            toolbar.AddAction(actions["About"]);
      
            QAction quit = toolbar.AddAction(MediaIconHelper.SystemLogOugIcon, "Quit Application");
            quit.Triggered += Quit_Triggered;
        }

        private void Quit_Triggered(bool obj)
        {
            QApplication.CloseAllWindows();
        }

    }
}
