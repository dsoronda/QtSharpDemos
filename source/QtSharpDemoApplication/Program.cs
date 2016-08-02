using QtGui;
using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtSharpDemoApplication
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

                // create MainWindow
                var mainWindow = new Widgets.MainWindow();

                // Run the QApplication Process
                QGuiApplication.Exec();

                //QApplication.Exec();
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
