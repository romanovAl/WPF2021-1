using System;
using System.Windows;
using System.Windows.Input;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_01_020_InheritTheWin
{
    class InheritTheWin :   Window
    {
        
        [STAThread]
        public static void Main()
        {    
            Console.WriteLine("Введите ширину окна в аппаратно независимых единицах: ");
            int WidthX = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту окна в аппаратно независимых единицах: ");
            int HeightY = int.Parse(Console.ReadLine());
            Application app = new Application();
            app.Run(new InheritTheWin(WidthX, HeightY));
        }

        /// <summary>
        /// Размер окна по пользовательским данным ( Width, Height )
        /// </summary>
        /// <param Ширина="WidthX"></param>
        /// <param Высота="HeightY"></param>
        public InheritTheWin(int WidthX, int HeightY)
        {
            //Размеры окна
            Width = WidthX;
            Height = HeightY;
            // Размещение окна по центру 
            Left = (SystemParameters.WorkArea.Width - Width) / 2 +
                SystemParameters.WorkArea.Left;
            Top = (SystemParameters.WorkArea.Height - Height) / 2 +
                SystemParameters.WorkArea.Top;
            // Название окна
            Title = "Inherit The Win";
            // выведет нули
            //Console.WriteLine("Размеры окна: " + ActualHeight + "  " + ActualWidth);
        }
        /// <summary>
        /// Стандартный конструктор 
        /// </summary>
        public InheritTheWin()
        {
            Title = "Inherit The Win";
        }
    }
}
