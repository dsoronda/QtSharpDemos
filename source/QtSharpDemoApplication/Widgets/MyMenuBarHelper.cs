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
            // load icons
            // all icons in project should have "Copy to Output Directory" set to Copy...;
            var mediaPath = @"media\icons";


            var file = parendWidget.AddMenu("&File");

            file.AddAction(MediaIconHelper.NewDocumentIcon, "New File");
            file.AddAction(MediaIconHelper.OpenDocumentIcon, "Open File");


            // create new Import sub menu
            //var importMenu = new QMenu("Import");
            var importMenu = file.AddMenu(MediaIconHelper.OpenDocumentIcon, "&Import");

            // add actions to menu
            importMenu.AddAction(new QAction("Import news feed...", null));
            importMenu.AddAction(new QAction("Import bookmarks...", null));
            importMenu.AddAction(new QAction("Import mail...", null));

            // add Import to main menu
            file.AddMenu(importMenu);

            // create sub menu
            var quit = new QAction(new QIcon($@"{mediaPath}\system-log-out.png"), "&Quit", file);
            // add it to main menu

            file.AddAction(quit);

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
