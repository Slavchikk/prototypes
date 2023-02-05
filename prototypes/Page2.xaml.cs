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

namespace prototypes
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        string word = "";
        int count;
      
        public Page2()
        {
            InitializeComponent();
            Random rnd = new Random();

            // создание линии, координаты задаются рандомно:
            Line l = new Line()
            {
                X1 = rnd.Next(0, 100),
                Y1 = rnd.Next(0, 100),
                X2 = rnd.Next(0, 300),
                Y2 = rnd.Next(0, 200),
                Stroke = Brushes.Black,
            };

            Line l1 = new Line()
            {
                X1 = rnd.Next(0, 100),
                Y1 = rnd.Next(0, 100),
                X2 = rnd.Next(0, 300),
                Y2 = rnd.Next(0, 200),
                Stroke = Brushes.Black,
            };

            Line l2 = new Line()
            {
                X1 = rnd.Next(0, 100),
                Y1 = rnd.Next(0, 100),
                X2 = rnd.Next(0, 300),
                Y2 = rnd.Next(0, 200),
                Stroke = Brushes.Black,
            };

            Line l3 = new Line()
            {
                X1 = rnd.Next(0, 100),
                Y1 = rnd.Next(0, 100),
                X2 = rnd.Next(0, 300),
                Y2 = rnd.Next(0, 200),
                Stroke = Brushes.Black,
            };

            Line l4 = new Line()
            {
                X1 = rnd.Next(0, 100),
                Y1 = rnd.Next(0, 100),
                X2 = rnd.Next(0, 300),
                Y2 = rnd.Next(0, 200),
                Stroke = Brushes.Black,
            };





            // добавление линии внутрь контейнера Canvas (can - имя контейнера):
            can.Children.Add(l);
            can.Children.Add(l1);
            can.Children.Add(l2);
            can.Children.Add(l3);
            can.Children.Add(l4);
            // программное создание TextBlock:
            //TextBlock txt = new TextBlock()
            //{
            //    Text = "33333333",
            //    Padding = new Thickness(50, 100, 10, 10),
            //    FontSize = 26,
            //    FontStyle = FontStyles.Italic,
            //    FontWeight = FontWeights.Bold,

            //};

            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            // Создаем генератор случайных чисел.
            Random rand = new Random();
            List<string> lstWords = new List<string>();
            // Делаем слова.
             count = rand.Next(7, 10);
            int wordOrNum = 0;
            int randNum = 0;
            
            for (int j = 1; j <= count; j++)
            {
                wordOrNum = rand.Next(1, 3);
                // Выбор случайного числа от 0 до 25
                // для выбора буквы из массива букв.
                if (wordOrNum == 1)
                {
                    int letter_num = rand.Next(0, letters.Length - 1);

                    // Добавить письмо.
                    word += letters[letter_num];
                }
                else
                {
                    randNum = rand.Next(0, 9);
                    word += randNum.ToString();
                }
            }
            char[] arrCh = word.ToCharArray();

            int widhts = 0;
            int heiugh = 0;
            int maxRastWid = 0;
            maxRastWid = (int)(250 / count);
            int pred = 0;
            int sled = 0;
            for (int i = 0; i < count; i++)
            {
                if (i == 0)
                {
                    widhts = rand.Next(0, maxRastWid);
                    pred = maxRastWid;
                }
                else
                {
                    sled = pred + maxRastWid;
                    widhts = rand.Next(pred, sled);
                    if (widhts - pred < 15 && widhts + 15 < 250) // чтобы было видно расстояние в случае если оно слишком мало
                    {
                        widhts += 15;
                    }
                    pred = widhts;
                }
                heiugh = rand.Next(0, 100);

                int design = rand.Next(1, 3);

                if (design == 1)
                {
                    TextBlock txt1 = new TextBlock()
                    {
                        Text = arrCh[i].ToString(),
                        Padding = new Thickness(widhts, heiugh, 0, 0),
                        FontSize = 26,
                        FontStyle = FontStyles.Italic,


                    };
                    can.Children.Add(txt1);
                }
                else if (design == 2)
                {
                    TextBlock txt1 = new TextBlock()
                    {
                        Text = arrCh[i].ToString(),
                        Padding = new Thickness(widhts, heiugh, 0, 0),
                        FontSize = 26,

                        FontWeight = FontWeights.Bold,

                    };
                    can.Children.Add(txt1);
                }
                else
                {
                    TextBlock txt1 = new TextBlock()
                    {
                        Text = arrCh[i].ToString(),
                        Padding = new Thickness(widhts, heiugh, 0, 0),
                        FontSize = 26,
                        FontStyle = FontStyles.Italic,
                        FontWeight = FontWeights.Bold,

                    };
                    can.Children.Add(txt1);
                }

            }




            //TextBlock textBlock = new TextBlock()
            //{
            //    Text = "33",

            //}
            // добавление текста внутрь контейнера Canvas (can - имя контейнера):
            // can.Children.Add(txt);





        }

        private void btnVvod(object sender, TextChangedEventArgs e)
        {
            string wordTest = Cod.Text;
            int str = Cod.Text.Length;
            if (str == count)
            {
                if (word == wordTest)
                {
                    MessageBox.Show("Вход выполнен");
                }
                else if (Frameclass.tryVvod ==0)
                {
                    MessageBox.Show("Код введен не верно, попробуйте еще раз");
                    Frameclass.tryVvod = 1;
                    Frameclass.MainFrame.Navigate(new Page2());
                 
                }
                else
                {
                    MessageBox.Show("вы не смогли войти");
                    Content = null;
                }
            }
        }
    }
}
