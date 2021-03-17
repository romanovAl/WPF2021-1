using System; // Cодержит фундаментальные и базовые классы
using System.Windows; // Предоставляет несколько важных классов базовых элементов WPF
using System.Windows.Input; // Предоставляет типы для поддержки системы ввода WPF
using System.Windows.Media; // Предоставляет типы, обеспечивающие интеграцию мультимедийных данных

namespace Petzold.FollowTheRainbow
{
    class FollowTheRainbow : Window // Создание класса FollowTheRainbow, наследника Window
    {
        [STAThread] // атрибут, который показывает, что управление программой осуществляется одним главным потоком
        public static void Main() // точка входа выполняемой программы
        {
            Application app = new Application(); // создание нового приложения
            app.Run(new FollowTheRainbow()); // обработка и отправка сообщений между приложением и операционной системой
        }
        public FollowTheRainbow()
        {
            Title = "Follow the Rainbow";
            LinearGradientBrush brush = new LinearGradientBrush(); // Класс, который закрашивает область с линейным градиентом
            brush.StartPoint = new Point(0, 0); // Задаёт начальные двумерные координаты для линейного градиента
            brush.EndPoint = new Point(1, 0); // Задает конечные двумерные координаты для линейного градиента
            Background = brush; // Свойство, которое задаёт характеристики фона
                                // Rainbow mnemonic is the name Roy G. Biv.
                                // GradientStops - это свойство, которое задаёт ограничение градиента
            brush.GradientStops.Add(new GradientStop(Colors.Red, 0));
            brush.GradientStops.Add(new GradientStop(Colors.Orange, .17));
            brush.GradientStops.Add(new GradientStop(Colors.Yellow, .33));
            brush.GradientStops.Add(new GradientStop(Colors.Green, .5));
            brush.GradientStops.Add(new GradientStop(Colors.Blue, .67));
            brush.GradientStops.Add(new GradientStop(Colors.Indigo, .84));
            brush.GradientStops.Add(new GradientStop(Colors.Violet, 1));
        }
    }
}