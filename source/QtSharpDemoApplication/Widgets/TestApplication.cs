using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtSharpDemoApplication.Widgets
{
    class TestApplication : QtWidgets.QWidget
    {
        public TestApplication()
        {
            WindowTitle = "Test application";

            var vboxLayout = GetLayout();
            this.Layout = vboxLayout;

            Resize(250, 150);
            Show();

            // Add Buttons toolbar
            // Spliter with panels
        }

        /// <summary>
		/// Gets VBoxLayout with label
		/// </summary>
		/// <returns>The layout.</returns>
		QLayout GetLayout()
        {
            var vbox = new QVBoxLayout();
            // Add Menu bar
            var menu = new MyMenuBar();
			vbox.AddWidget(menu);

            return vbox;
        }

        void InitMenu()
        {

        }

    }
}
