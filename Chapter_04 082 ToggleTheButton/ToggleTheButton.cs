using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
namespace Petzold.ToggleTheButton
{ 
    public class ToggleTheButton : Window 
    {
        [STAThread] 
        public static void Main() 
        { 
            Application app = new Application(); 
            app.Run(new ToggleTheButton()); 
        } 
        public ToggleTheButton() 
        { 
            Title = "Toggle the Button"; // создание заголовка для окна 
            ToggleButton btn = new ToggleButton(); // создан экземпляр класса ToggleButton
            btn.Content = "Can _Resize"; // название кнопки
            btn.HorizontalAlignment = HorizontalAlignment.Center; // установка разположения кнопки (по горизонтали)
            btn.VerticalAlignment = VerticalAlignment.Center; // установка расположения кнопки (по вертикали) 
            btn.IsChecked = (ResizeMode == ResizeMode.CanResize); // для свойства IsChecked изначально устанавливается истина если окно находится в состоянии CanResize
            btn.Checked += ButtonOnChecked; // с помощью функции ButtonOnChecked инициализируется одно из событий  Checked или Unchecked
            btn.Unchecked += ButtonOnChecked; // см. прошлый комментарий 
            Content = btn; // объект Button задаётся свойству Content объекта Window
        } 
        void ButtonOnChecked(object sender, RoutedEventArgs args) 
        { 
            ToggleButton btn = sender as ToggleButton; 
            ResizeMode = (bool)btn.IsChecked ? ResizeMode.CanResize : ResizeMode.NoResize; // свойству IsChecked приведённому к типу bool задаётся значение в зависимомти от текущего состояния окна (ResizeMode)
        } 
    } 
}