using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
namespace Petzold.VaryTheBackground
{
    public class VaryTheBackground : Window // Наследование от класса Window
    {
        SolidColorBrush brush = new SolidColorBrush(Colors.Black); // Создаем объект кисти
        [STAThread] // Основной программный поток не должен использовать многопоточность. Иначе комплиятор будет ругаться
        public static void Main()
        {
            // Запускаем цикл для получения ввода с клавиатуры, мыши, стилусов и т.д. В нашем случае пригодится информация только с мыши
            Application app = new Application(); 
            app.Run(new VaryTheBackground());
        }
        public VaryTheBackground()
        {
            // Определяем название титула, размеры. Определяем свойство Background экземпляром класса SolidColorBrush, который, в свою очередь,
            Title = "Vary the Background";                                                             // является производном от класса Brush
            Width = 384;
            Height = 384;
            Background = brush;
        }
        protected override void OnMouseMove(MouseEventArgs args)
        {
            // Определяем размер клиентской области. Вычет из ActualWidth И ActualHeight размеров рамки и заголовка.
            double width = ActualWidth - 2 * SystemParameters.ResizeFrameVerticalBorderWidth;
            double height = ActualHeight - 2 * SystemParameters.ResizeFrameHorizontalBorderHeight - SystemParameters.CaptionHeight;

            Point ptMouse = args.GetPosition(this); // Получение координат указателя мыши
            Point ptCenter = new Point(width / 2, height / 2); // Получение координат центра клиентской области
            Vector vectMouse = ptMouse - ptCenter; // Согласно документации, разность поинтов даст вектор. 
            double angle = Math.Atan2(vectMouse.Y, vectMouse.X); // Вычисление угла вектора vectMuse. Угол задаёт направление вектора

            //  На основе вычесленного угла вычисляем новый вектор - расстояние от центра клиент. обл. до точки эллипса, заполняющего клиентскую область 
            Vector vectEllipse = new Vector(width / 2 * Math.Cos(angle), height / 2 * Math.Sin(angle));

            // На основе отношений длин двух векторов формируем оттенок серого и, собственно, задаём итоговый цвет
            Byte byLevel = (byte)(255 * (1 - Math.Min(1, vectMouse.Length / vectEllipse.Length)));
            Color clr = brush.Color;
            clr.R = clr.G = clr.B = byLevel; 
            brush.Color = clr;
        }
    }
}