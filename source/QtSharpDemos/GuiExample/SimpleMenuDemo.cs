using QtGui;
using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtSharpDemos.GuiExample
{
    public class MenuToolbarDemo : QtWidgets.QWidget
    {
        public MenuToolbarDemo()
        {
            WindowTitle = "Simple menu demo";

            InitUI();

            Resize(250, 200);
            Move(100, 100);
            Show();
        }

        private void InitUI()
        {
            // load icons
            // all icons in project should have "Copy to Output Directory" set to Copy...;
            var mediaPath = @"media\icons";
            var newpix = new QIcon($@"{mediaPath}\document-new.png");
            var openpix = new QIcon($@"{mediaPath}\document-open.png");
            var quitpix = new QIcon($@"{mediaPath}\system-log-out.png");
            var filepix = new QIcon($@"{mediaPath}\preferences-system.png");
            var importpix = new QIcon($@"{mediaPath}\package-x-generic.png");

            // Create main menu
            var menuToolbar = new QMenuBar(this);
            var file = menuToolbar.AddMenu("&File");

            file.AddAction(newpix, "New File");
            file.AddAction(openpix, "Open File");


            // create new Import sub menu
            //var importMenu = new QMenu("Import");
            var importMenu = file.AddMenu(openpix, "&Import");
            // create new actions
            var seeds = new QAction("Import news feed...", this);
            var marks = new QAction("Import bookmarks...", this);
            var mail = new QAction("Import mail...", this);
            // add actions to menu
            importMenu.AddAction(seeds);
            importMenu.AddAction(marks);
            importMenu.AddAction(mail);

            // add Import to main menu
            file.AddMenu(importMenu);

            // create sub menu
            var quit = new QAction(quitpix, "&Quit", this);
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
