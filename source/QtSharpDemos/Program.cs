using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QtSharpDemos.GuiExample;

namespace QtSharpDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Init QT application
            int count = 0;
            // project-> properties -> allow unsafe code (must ce checked for now)
            try
            {
                // TODO : added try/catch block so we can log exception errors
                unsafe
                {
                    var qtApp = new QApplication(ref count, null);
                }

                var labelDemo = new LabelDemo();

                //var windowsDemo = new WindowsDemo();
                //var widgetDemo = new WidgetDemo();
                //var quitButtonDemo = new QuitButtonDemo();
                //var absolutePositionDemo = new ImagesWithAbsolutePositionDemo();
                //var buttonsDemo = new ButtonsDemo();
                //var checkBoxDemo = new CheckBoxDemo();
                //var lineEditDemo = new LineEditDemo();
                //var togleButtonsDemo = new TogleButtonsDemo();
                //var comboBoxDemo = new ComboBoxDemo();
                //var menuBar = new MenuBarDemo();
                //var menuToolbarDemo = new ToolbarDemo();
                //var messageBoxDemo = new MessageBoxDemo();
                //var inputDialogDemo = new InputDialogDemo();
                //var colorDialogDemo = new ColorDialogDemo();
                //var fontDialogDemo = new FontDialogDemo();


                //var paintDemo = new PaintDemo(); // not working properly, waiting for fix!

                //var panelDemo = new PanelsDemo();

                QApplication.Exec();
            }
            catch (Exception)
            {
                throw;
            }

            Console.WriteLine("All done");
            Console.ReadKey();

        }
    }
}
