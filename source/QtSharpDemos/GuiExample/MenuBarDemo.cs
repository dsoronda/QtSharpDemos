using QtGui;
using QtSharpDemos.media;
using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtSharpDemos.GuiExample
{
    public class MenuBarDemo : QtWidgets.QWidget
    {
        public MenuBarDemo()
        {
            WindowTitle = "Simple Toolbar Demo";

            InitUI(this);

            Resize(250, 200);
            Move(100, 100);
            Show();
        }

        public void InitUI(QWidget parentWidget)
        {
            var mediaPath = @"media\icons";

            // load icons
            // NOTE : all icons in project should have "Copy to Output Directory" set to Copy...;

            //var filepix = new QIcon($@"{mediaPath}\preferences-system.png");
            //var importpix = new QIcon($@"{mediaPath}\package-x-generic.png");

            // Create main menu
            var menuToolbar = new QMenuBar(parentWidget);
            var file = menuToolbar.AddMenu("&File");
            
            file.AddAction(MediaIconHelper.NewDocumentIcon, "New File");
            file.AddAction(MediaIconHelper.OpenDocumentIcon, "Open File");

            // create new Import sub menu
            //var importMenu = new QMenu("Import");
            var importMenu = file.AddMenu(MediaIconHelper.OpenDocumentIcon, "&Import");
            importMenu.AddAction(new QAction("Import news feed...", null));
            importMenu.AddAction(new QAction("Import bookmarks...", null));
            importMenu.AddAction(new QAction("Import mail...", null));

            // create sub menu
            var quit = new QAction(MediaIconHelper.SystemLogOugIcon, "&Quit", null);
            // add it to main menu
            file.AddAction(quit);

            // Menus are displayed in created order
            quit.Triggered += Quit_Triggered;
        }

        private void Quit_Triggered(bool obj)
        {
            this.Close();
        }

    }
}
