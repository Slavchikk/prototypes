using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace prototypes
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
      
        //ViewModel VM = new ViewModel();
        DispatcherTimer timer = new DispatcherTimer();
        DispatcherTimer timer1 = new DispatcherTimer();
        int cor = 10;
        public MainPage()
        {
            InitializeComponent();
        }
        public MainPage(int a)
        {
            InitializeComponent();
            timeZap.Visibility = Visibility.Visible;
            //DataContext = VM;  // добавление объекта VievModel в ресурсы страницы
            //  CommandBindings.Add(VM.bind);  // добавление объекта привязки на страницу
            timerrr();
           

        }


       void timerrr()
        {

           //timer.Interval = new TimeSpan(0, 0, 10);
           // timer.Start();
            //timer.Tick += new EventHandler(close_timer1);

            // cor -= 1;
            
            timer1.Interval = TimeSpan.FromSeconds(1);
            timer1.Tick += timer_Tick;
            timer1.Start();

        }
        //void close_timer1(object sender, EventArgs e)
        //{
        //    timer.Stop();
        //    timer1.Stop();
        //    timeZap.Visibility=Visibility.Hidden;
        //}
        void timer_Tick(object sender, EventArgs e)
        {
            if(cor == 0)
                timer1.Stop();
            cor--;
            timeZap.Text = cor.ToString();
        }
        private void ClosePage(object sender, EventArgs e)
        {
            Content = null;
        }


        private void Btn_registration(object sender, RoutedEventArgs e)
        {
            //Создание объекта для генерации чисел
            Random rnd = new Random();

            //Получить случайное число (в диапазоне от 0 до 10)
            int value = rnd.Next(10000, 99999);
            Frameclass.globalInt = value;
            if (TbLoginReg.Text == "admin" && TbPasReg.Text == "admin")
            {
                if (MessageBox.Show("Код для входа:  " + value,
                     "Код",
                     MessageBoxButton.OKCancel,
                     MessageBoxImage.Question) == MessageBoxResult.OK)
                {
                    Frameclass.MainFrame.Navigate(new Page1());
                }




                //MessageBox.Show("Код для входа:  " + value);

            }
            else MessageBox.Show("Пароль или логин введен неверно");
        }

        private void btn_newCode(object sender, RoutedEventArgs e)
        {

        }
    }
}
