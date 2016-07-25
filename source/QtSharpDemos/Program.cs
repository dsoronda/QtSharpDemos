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
                //var w = new QtWidgetDemo1();
                var wuitButtonDemo = new QtQuitButtonDemo1();
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
