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
            var fileRootMenu = parendWidget.AddMenu("&File");
            InitFileMenu(fileRootMenu);

            var aboutRootMenu = parendWidget.AddMenu("&Help");
            InitAboutMenu(aboutRootMenu);
        }

        private static void InitAboutMenu(QMenu rootMenu)
        {
            rootMenu.AddAction( MediaIconHelper.HelpIcon, "Help");
            rootMenu.AddSeparator();
            rootMenu.AddAction(MediaIconHelper.NewDocumentIcon, "About");
        }

        private static void InitFileMenu(QMenu rootMenu)
        {
            rootMenu.AddAction(MediaIconHelper.NewDocumentIcon, "New File");
            rootMenu.AddAction(MediaIconHelper.OpenDocumentIcon, "Open File");

            // create new Import sub menu
            //var importMenu = new QMenu("Import");
            var importMenu = rootMenu.AddMenu(MediaIconHelper.OpenDocumentIcon, "&Import");

            // add actions to menu
            importMenu.AddAction(new QAction("Import news feed...", null));
            importMenu.AddAction(new QAction("Import bookmarks...", null));
            importMenu.AddAction(new QAction("Import mail...", null));

            // add Import to main menu
            rootMenu.AddMenu(importMenu);

            // Add separator line
            rootMenu.AddSeparator();

            // create sub menu
            var quit = new QAction(MediaIconHelper.SystemLogOugIcon, "&Quit", rootMenu);
            // add it to main menu

            rootMenu.AddAction(quit);

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
