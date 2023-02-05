using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
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
        //DispatcherTimer timer1 = new DispatcherTimer();
       public int d = 5;
        
        public MainPage()
        {
            InitializeComponent();
            timeBut.Visibility = Visibility.Hidden;
        }
        public MainPage(int a)
        {
            InitializeComponent();
            
            //if(Frameclass.counterDo == 1)
            //{
            //    timeBut.Visibility = Visibility.Visible;
            //}
            if(Frameclass.counterDo == 0) { 
            timeZap.Visibility = Visibility.Visible;
            btnAuto.IsEnabled= false;
            timeBut.Visibility = Visibility.Hidden;
            //DataContext = VM;  // добавление объекта VievModel в ресурсы страницы
            //CommandBindings.Add(VM.bind);  // добавление объекта привязки на страницу
            timer.Interval = new TimeSpan(0, 0, 1);
            timerrr();
            timer.Tick += new EventHandler(close_timer1);
            }
        }
        



        void timerrr()
        {


            timer.Start();
            // cor -= 1;

            //timer1.Interval = TimeSpan.FromSeconds(1);
            //timer1.Tick += timer_Tick;
            //timer1.Start();

            //timeZap.Visibility = Visibility.Visible;


        }
        void close_timer1(object sender, EventArgs e)
        {
           if(d!=0)
            {
               // timeZap.Visibility=Visibility.Visible;
                timeZap.Text = "Получить новый код можно через " + d + " секунд";
                d--;
                
            }
            else
            {
                timeZap.Visibility=Visibility.Hidden;
                timer.Stop();
                //btnAuto.IsEnabled = true;
                timeBut.Visibility=Visibility.Visible;
                Frameclass.counterDo++;
            }
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
            if (TbLoginReg.Text == "admin" && TbPasReg.Password == "admin")
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
            Random rnd = new Random();

            //Получить случайное число (в диапазоне от 0 до 10)
            int value = rnd.Next(10000, 99999);
            Frameclass.globalInt = value;
            if (TbLoginReg.Text == "admin" && TbPasReg.Password == "admin")
            {
                if (MessageBox.Show("Код для входа:  " + value,
                     "Код",
                     MessageBoxButton.OKCancel,
                     MessageBoxImage.Question) == MessageBoxResult.OK)
                {
                    Frameclass.MainFrame.Navigate(new Page1(1));
                }




                //MessageBox.Show("Код для входа:  " + value);

            }
            else MessageBox.Show("Пароль или логин введен неверно");
        }
    }
}
