using System; // Cодержит фундаментальные и базовые классы
using System.Windows; // Предоставляет несколько важных классов базовых элементов WPF
using System.Windows.Input; // Предоставляет типы для поддержки системы ввода WPF

namespace Petzold.InheritTheApp
{
    class InheritTheApp : Application // создание класса InheritTheApp, который наследует от Application и переопределяет методы
                                      // OnStartup и OnSessionEnding, определяемые в классе Application

    {
        [STAThread] // управление программой осуществляется одним главным потоком
        public static void Main() // точка входа выполняемой программы
        {
            InheritTheApp app = new InheritTheApp(); // создаётся объект app типа InheritTheApp
            app.Run();
        }
        protected override void OnStartup(StartupEventArgs args) // переопределяем метод OnStartup
        {
            base.OnStartup(args); // ключевое слово base используется для вызова метода из базового класса
            Window win = new Window(); // создаётся объект Window
            win.Title = "Inherit the App";
            win.Show(); // отображается объект Window
        }
        protected override void OnSessionEnding(SessionEndingCancelEventArgs args) // переопределяем метод OnSessionEnding

        {
            base.OnSessionEnding(args); // base используется для вызова метода из базового класса
            MessageBoxResult result =
            MessageBox.Show("Do you want to save your data?",
            MainWindow.Title, MessageBoxButton.YesNoCancel,
            MessageBoxImage.Question, MessageBoxResult.Yes);

             // выводит окно сообщения с кнопками Yes, No, Cancel; заголовок окна сообщения заполняется текстом MainWindow.Title

            args.Cancel = (result == MessageBoxResult.Cancel);

        } 
        
        // т.к у программы нет данных для сохранения, она игнорирует кнопки Yes и No,
        // разрешая приложению завершиться, а системе Windows продолжить завершение сеанса пользователя

        // если была выбрана кнопка Cancel, программа устанавливает флаг Cancel объекта SessionEndingCancelEventArgs;
        // это запрещает выключение компьютера или завершение сеанса
    }
}