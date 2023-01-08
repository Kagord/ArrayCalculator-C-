using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        //обьект истории последних действий 
        class Memory
        {
            //поля
            public string textboxone;
            public string textboxtwo;
            public string operation;

            //конструктор
            public Memory(string textboxone,string textboxtwo,string operation)
            {
                this.textboxone = textboxone;
                this.textboxtwo = textboxtwo;
                this.operation = operation;
            }
        }

        //списак всех последних операций
        List<Memory> memories = new List<Memory>();

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "1";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text = "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text = "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text = "9";
        }

        //Переменнтая для подсчета кол-во операций
        int count = 0;
        int countlast = 0;

        //прибавление числа к каждому элементу
        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
               
                //вывод в StatusBar кол-во
                count += 1;
                label2.Text = " ";
                label2.Text += (count-countlast)+" из"+count;

            string str = textBox1.Text;

            //перевод из строки в массив int
            var array = str.Split(' ').Select(int.Parse).ToArray();

           

            int[] arrayNew = new int[array.Length];
            textBox1.Clear();
            //добавление числа к набору данных
            for (int i = 0; i < array.Length; i++)
            {
                arrayNew[i] = array[i] + Convert.ToInt32(textBox2.Text);
            }

            //вывод нового массива 
            for (int i = 0; i < arrayNew.Length; i++)
            {
                textBox1.Text += arrayNew[i];
                    if (i == arrayNew.Length-1)
                    {
                        break;
                    }
                textBox1.Text += " ";

            }

                memories.Add(new Memory(textBox1.Text, textBox2.Text, "+"));

            }
            catch
            {
                MessageBox.Show("Вы ввели не корректно. Перезайдите в приложение и попробуйте снова!");
            }

        }
        //вычитание  числа к каждому элементу
        private void button11_Click(object sender, EventArgs e)
        {
            try 
            { 
            //вывод в StatusBar кол-во
            count += 1;
            label2.Text = " ";
            label2.Text += (count - countlast) + " из" + count;

                string str = textBox1.Text;

            //перевод из строки в массив int
            var array = str.Split(' ').Select(int.Parse).ToArray();



            int[] arrayNew = new int[array.Length];
            textBox1.Clear();
            //вычитание числа к набору данных
            for (int i = 0; i < array.Length; i++)
            {
                arrayNew[i] = array[i] - Convert.ToInt32(textBox2.Text);
            }

            //вывод нового массива 
            for (int i = 0; i < arrayNew.Length; i++)
            {
                textBox1.Text += arrayNew[i];
                if (i == arrayNew.Length - 1)
                {
                    break;
                }
                textBox1.Text += " ";
            }

                memories.Add(new Memory(textBox1.Text, textBox2.Text, "-"));
            }
            catch
            {
                MessageBox.Show("Вы ввели не корректно. Перезайдите в приложение и попробуйте снова!");
            }
}
        //умножение  числа к каждому элементу
        private void button12_Click(object sender, EventArgs e)
        {
            try {
            //вывод в StatusBar кол-во
            count += 1;
            label2.Text = " ";
            label2.Text += (count - countlast) + " из" + count;

            string str = textBox1.Text;

            //перевод из строки в массив int
            var array = str.Split(' ').Select(int.Parse).ToArray();



            int[] arrayNew = new int[array.Length];
            textBox1.Clear();
            //умножение числа к набору данных
            for (int i = 0; i < array.Length; i++)
            {
                arrayNew[i] = array[i] * Convert.ToInt32(textBox2.Text);
            }

            //вывод нового массива 
            for (int i = 0; i < arrayNew.Length; i++)
            {
                textBox1.Text += arrayNew[i];
                if (i == arrayNew.Length - 1)
                {
                    break;
                }
                textBox1.Text += " ";
            }
            memories.Add(new Memory(textBox1.Text, textBox2.Text, "*"));
            }
            catch
            {
                MessageBox.Show("Вы ввели не корректно. Перезайдите в приложение и попробуйте снова!");
            }
        }

        //деление  числа к каждому элементу
        private void button13_Click(object sender, EventArgs e)
        {
            try { 
            //вывод в StatusBar кол-во
            count += 1;
            label2.Text = " ";
            label2.Text += (count - countlast) + " из" + count;

            string str = textBox1.Text;

            //перевод из строки в массив int
            var array = str.Split(' ').Select(int.Parse).ToArray();



            int[] arrayNew = new int[array.Length];
            textBox1.Clear();
            //деление числа к набору данных
            for (int i = 0; i < array.Length; i++)
            {
                arrayNew[i] = array[i] / Convert.ToInt32(textBox2.Text);
            }

            //вывод нового массива 
            for (int i = 0; i < arrayNew.Length; i++)
            {
                textBox1.Text += arrayNew[i];
                if (i == arrayNew.Length - 1)
                {
                    break;
                }
                textBox1.Text += " ";
            }
            memories.Add(new Memory(textBox1.Text, textBox2.Text, "/"));
            }
            catch
            {
                MessageBox.Show("Вы ввели не корректно. Перезайдите в приложение и попробуйте снова!");
            }
        }

        //возведение в квадрат
        private void button14_Click(object sender, EventArgs e)
        {
            try { 
            //вывод в StatusBar кол-во
            count += 1;
            label2.Text = " ";
            label2.Text += (count - countlast) + " из" + count;

            string str = textBox1.Text;

            //перевод из строки в массив int
            var array = str.Split(' ').Select(int.Parse).ToArray();



            int[] arrayNew = new int[array.Length];
            textBox1.Clear();
            //возведение в квадрат набор данных
            for (int i = 0; i < array.Length; i++)
            {
                arrayNew[i] = (int)Math.Pow(array[i],2);
            }

            //вывод нового массива 
            for (int i = 0; i < arrayNew.Length; i++)
            {
                textBox1.Text += arrayNew[i];
                if (i == arrayNew.Length - 1)
                {
                    break;
                }
                textBox1.Text += " ";
            }
            memories.Add(new Memory(textBox1.Text, textBox2.Text, "**"));
            }
            catch
            {
                MessageBox.Show("Вы ввели не корректно. Перезайдите в приложение и попробуйте снова!");
            }
        }

        //возыедение в квадрат по заданной степени 
        private void button15_Click(object sender, EventArgs e)
        {
            try { 
            //вывод в StatusBar кол-во
            count += 1;
            label2.Text = " ";
            label2.Text += (count - countlast) + " из" + count;

            string str = textBox1.Text;

            //перевод из строки в массив int
            var array = str.Split(' ').Select(int.Parse).ToArray();



            int[] arrayNew = new int[array.Length];
            textBox1.Clear();
            //возведение в квадрат набор данных в заданую степень
            for (int i = 0; i < array.Length; i++)
            {
                arrayNew[i] = (int)Math.Pow(array[i], Convert.ToInt32(textBox2.Text));
            }

            //вывод нового массива 
            for (int i = 0; i < arrayNew.Length; i++)
            {
                textBox1.Text += arrayNew[i];
                if (i == arrayNew.Length - 1)
                {
                    break;
                }
                textBox1.Text += " ";
            }
            memories.Add(new Memory(textBox1.Text, textBox2.Text, "x*"));
            }
            catch
            {
                MessageBox.Show("Вы ввели не корректно. Перезайдите в приложение и попробуйте снова!");
            }
        }

        //корень набор данных 
        private void button16_Click(object sender, EventArgs e)
        {
            try { 
            //вывод в StatusBar кол-во
            count += 1;
            label2.Text = " ";
            label2.Text += (count - countlast) + " из" + count;

            string str = textBox1.Text;

            //перевод из строки в массив int
            var array = str.Split(' ').Select(int.Parse).ToArray();



            int[] arrayNew = new int[array.Length];
            textBox1.Clear();
            //корень набор данных 
            for (int i = 0; i < array.Length; i++)
            {
                arrayNew[i] = (int)Math.Sqrt(array[i]);
            }

            //вывод нового массива 
            for (int i = 0; i < arrayNew.Length; i++)
            {
                textBox1.Text += arrayNew[i];
                if (i == arrayNew.Length - 1)
                {
                    break;
                }
                textBox1.Text += " ";
            }
            memories.Add(new Memory(textBox1.Text, textBox2.Text, "sqrt"));
            }
            catch
            {
                MessageBox.Show("Вы ввели не корректно. Перезайдите в приложение и попробуйте снова!");
            }
        }

        //корень заданной степени набор данных 
        private void button17_Click(object sender, EventArgs e)
        {
            try { 
            //вывод в StatusBar кол-во
            count += 1;
            label2.Text = " ";
            label2.Text += (count - countlast) + " из" + count;

            string str = textBox1.Text;

            //перевод из строки в массив int
            var array = str.Split(' ').Select(int.Parse).ToArray();



            int[] arrayNew = new int[array.Length];
            textBox1.Clear();
            //корень заданной степени набор данных 
            for (int i = 0; i < array.Length; i++)
            {
                arrayNew[i] = (int)Math.Pow(array[i], 1.0 / Convert.ToInt32(textBox2.Text)); ;
            }

            //вывод нового массива 
            for (int i = 0; i < arrayNew.Length; i++)
            {
                textBox1.Text += arrayNew[i];
                if (i == arrayNew.Length - 1)
                {
                    break;
                }
                textBox1.Text += " ";
            }
            memories.Add(new Memory(textBox1.Text, textBox2.Text, "xsqrt"));
            }
            catch
            {
                MessageBox.Show("Вы ввели не корректно. Перезайдите в приложение и попробуйте снова!");
            }
        }


        //логарифм по основанию 
        private void button18_Click(object sender, EventArgs e)
        {
            try { 
            //вывод в StatusBar кол-во
            count += 1;
            label2.Text = " ";
            label2.Text += (count - countlast) + " из" + count;

            string str = textBox1.Text;

            //перевод из строки в массив int
            var array = str.Split(' ').Select(int.Parse).ToArray();



            int[] arrayNew = new int[array.Length];
            textBox1.Clear();
            //логарифм по основанию 
            for (int i = 0; i < array.Length; i++)
            {
                arrayNew[i] = (int)Math.Log(array[i], Convert.ToInt32(textBox2.Text));
            }

            //вывод нового массива 
            for (int i = 0; i < arrayNew.Length; i++)
            {
                textBox1.Text += arrayNew[i];
                if (i == arrayNew.Length - 1)
                {
                    break;
                }
                textBox1.Text += " ";
            }
            memories.Add(new Memory(textBox1.Text, textBox2.Text, "log"));
            }
            catch
            {
                MessageBox.Show("Вы ввели не корректно. Перезайдите в приложение и попробуйте снова!");
            }
        }

        //Функция вычисления факториала
        int Factorial(int n)
        {
            if (n == 1) return 1;

            return n * Factorial(n - 1);
        }
        //факториал
        private void button19_Click(object sender, EventArgs e)
        {
            try { 
            //вывод в StatusBar кол-во
            count += 1;
            label2.Text = " ";
            label2.Text += (count - countlast) + " из" + count;

            string str = textBox1.Text;

            //перевод из строки в массив int
            var array = str.Split(' ').Select(int.Parse).ToArray();



            int[] arrayNew = new int[array.Length];
            textBox1.Clear();
            //факториал 
            for (int i = 0; i < array.Length; i++)
            {
                arrayNew[i] = Factorial(array[i]);
            }

            //вывод нового массива 
            for (int i = 0; i < arrayNew.Length; i++)
            {
                textBox1.Text += arrayNew[i];
                if (i == arrayNew.Length - 1)
                {
                    break;
                }
                textBox1.Text += " ";
            }
            memories.Add(new Memory(textBox1.Text, textBox2.Text, "fac"));
            }
            catch
            {
                MessageBox.Show("Вы ввели не корректно. Перезайдите в приложение и попробуйте снова!");
            }
        }

        //медиана
        
        private void button20_Click(object sender, EventArgs e)
        {
            try { 
            //вывод в StatusBar кол-во
            count += 1;
            label2.Text = " ";
            label2.Text += (count - countlast) + " из" + count;

            string str = textBox1.Text;

            //перевод из строки в массив int
            var array = str.Split(' ').Select(int.Parse).ToArray();

            //Сортировка массива
            Array.Sort(array);


            textBox1.Clear();

            //медиана
            if (array.Length % 2 == 0)
            {
                textBox1.Text += (array[array.Length / 2] + array[(array.Length / 2) + 1]) / 2;
            }
            else
            {
                textBox1.Text += array[array.Length / 2];
            }
            memories.Add(new Memory(textBox1.Text, textBox2.Text, "med"));
            }
            catch
            {
                MessageBox.Show("Вы ввели не корректно. Перезайдите в приложение и попробуйте снова!");
            }
        }

        //Стандартное отклонение для набора элементов
        private void button21_Click(object sender, EventArgs e)
        {
            try { 
            //вывод в StatusBar кол-во
            count += 1;
            label2.Text = " ";
            label2.Text += (count - countlast) + " из" + count;

            string str = textBox1.Text;

            //перевод из строки в массив int
            var array = str.Split(' ').Select(int.Parse).ToArray();


            textBox1.Clear();
             
            //вычисление стандартного отклонения
            double average = array.Average();
            double sumOfSquaresOfDifferences = array.Select(val => (val - average) * (val - average)).Sum();
            textBox1.Text += Math.Sqrt(sumOfSquaresOfDifferences / array.Length);
            memories.Add(new Memory(textBox1.Text, textBox2.Text, "otc"));
            }
            catch
            {
                MessageBox.Show("Вы ввели не корректно. Перезайдите в приложение и попробуйте снова!");
            }
        }

        //считывание из файла
        private void button24_Click(object sender, EventArgs e)
        {

            //путь к файлу
            string path = @"C:\Users\Кирилл\Desktop\WindowsFormsApp1\WindowsFormsApp1\mass.txt";


            textBox1.Clear();
         
            //получение данных файла
            int[] res = File.ReadAllText(path).Split().Select(int.Parse).ToArray();

            textBox1.Text += string.Join(" ", res);
        }

        //добавлние в файл
        private void button25_Click(object sender, EventArgs e)
        {
            //путь к файлу
            string path = @"C:\Users\Кирилл\Desktop\WindowsFormsApp1\WindowsFormsApp1\mass.txt"; 

            string str = textBox1.Text;

            //перевод из строки в массив int
            var arr = str.Split(' ').Select(int.Parse).ToArray();


            //запись в файл
            File.WriteAllText(path, string.Join(" ", arr));

            MessageBox.Show("набор данных добавлен в файл");
        }

        //кнопка repeat
        private void button23_Click(object sender, EventArgs e)
        {

            string switch_on;
            foreach (var item in memories)
            {

                //сравнение команды и последнее операцией 
                switch_on = item.operation;

                //вызов нужной последней операции
                switch (switch_on)
                {
                    case "+":
                        button10.PerformClick();
                        break;
                    case "-":
                        button11.PerformClick();
                        break;
                    case "*":
                        button12.PerformClick();
                        break;
                    case "/":
                        button13.PerformClick();
                        break;
                    case "**":
                        button14.PerformClick();
                        break;
                    case "x*":
                        button15.PerformClick();
                        break;
                    case "sqrt":
                        button16.PerformClick();
                        break;
                    case "xsqrt":
                        button17.PerformClick();
                        break;
                    case "log":
                        button18.PerformClick();
                        break;
                    case "fac":
                        button19.PerformClick();
                        break;
                    case "med":
                        button20.PerformClick();
                        break;
                    case "otc":
                        button21.PerformClick();
                        break;



                    default:
                        break;


                }
                if (switch_on != null)
                {
                    break;
                }
            }
        }


        //кнопка Undo
        private void button22_Click(object sender, EventArgs e)
        {
            //StatusBar обновление после отмены операции
            countlast += 1;
           
            label2.Text = " ";
            label2.Text += (count - countlast) + " из" + count;


            textBox1.Clear();
            textBox2.Clear();

            //переварот истории к последним 
            memories.Reverse();
            //удаление текущего элемента
            memories.RemoveAt(0);
            foreach (var item in memories)
            {
                //вывод последнего действия  
                textBox1.Text += item.textboxone;
                textBox2.Text += item.textboxtwo;
                break;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вводите числа набора данных через пробел с клавиатуры и в конце заканчивайте цифрой, а не пробелом. Число вводите с кнопок приложения. Нажатие на операцию сразу выдает результат. В поле числа вводится также степень для нужных операций.");
        }
    }
}
