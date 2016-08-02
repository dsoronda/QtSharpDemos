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
    public static class MyMenuBarHelper
    {
        public static void InitMenuBarUI(QMenuBar parendWidget)
        {
            var fileRootMenuItem = parendWidget.AddMenu("&File");

            fileRootMenuItem.AddAction(MediaIconHelper.NewDocumentIcon, "New File");
            fileRootMenuItem.AddAction(MediaIconHelper.OpenDocumentIcon, "Open File");


            // create new Import sub menu
            //var importMenu = new QMenu("Import");
            var importMenu = fileRootMenuItem.AddMenu(MediaIconHelper.OpenDocumentIcon, "&Import");

            // add actions to menu
            importMenu.AddAction(new QAction("Import news feed...", null));
            importMenu.AddAction(new QAction("Import bookmarks...", null));
            importMenu.AddAction(new QAction("Import mail...", null));

            // add Import to main menu
            fileRootMenuItem.AddMenu(importMenu);

            // create sub menu
            var quit = new QAction(MediaIconHelper.SystemLogOugIcon, "&Quit", fileRootMenuItem);
            // add it to main menu

            fileRootMenuItem.AddAction(quit);

            // Menus are displayed in created order
            quit.Triggered += Quit_Triggered;
        }

        private static void Quit_Triggered(bool obj)
        {
            QApplication.CloseAllWindows();
            //QApplication.Exit();
        }

    }

}
