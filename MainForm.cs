using System;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace EulerianGraph
{
    public partial class MainForm : Form
    {
        //Экземпляр графа 1
        EulerianGraph.Eurelian.Graph graph1;
        //Экземпляр графа 2
        EulerianGraph.Eurelian.Graph graph2;

        /// <summary>
        /// Форма с общей инструкцией 
        /// </summary>
        GeneralInfoForm infoForm = new GeneralInfoForm();

        /// <summary>
        /// Конструктор для главной формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            graph1 = new Eurelian.Graph();
            graph2 = new Eurelian.Graph();

            //создание полотна для графа 1
            graph1.G = new Eurelian.DrawGraph(pictureBox1.Width, pictureBox1.Height, graph1);
            pictureBox1.Image = graph1.G.GetBitmap();

            //создание полотна для графа 2
            graph2.G = new Eurelian.DrawGraph(pictureBox2.Width, pictureBox2.Height, graph2);
            pictureBox2.Image = graph2.G.GetBitmap();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="graph"></param>
        private void Input(EulerianGraph.Eurelian.Graph graph, PictureBox picture, string name)
        {
            picture.Hide();
            graph.ClearAllData();
            //Если нажата радиокнопка "ввести из файла"
            if (FromFile_radioButton.Checked)
            {
                //Если загрузка из файла прошла успешно и файл оказался FO массивом, выполнять все последующие операции
                if (graph.ReadFromFile())
                {
                    //Проверка графа на эйлеровость
                    graph.EulerianOrNot();
                    //Отображение picterbox
                    picture.Show();
                    //Очистка полотна
                    graph.G.clearSheet();
                    //Визуализиация графа 
                    graph.Visualize();
                    //Если граф эйлеров, отображение пути
                    if (graph.IsEulerian)
                    {
                        //Очистка полотна
                        graph.G.clearSheet();
                        //Рисование пути
                        graph.DrawWay();
                    }
                }
            }
            //Если нажата радиокнопка "ввести вручную"
            else
            {
                //Создать форму для ввода с клавиатуры
                KeyboardInputForm form = new KeyboardInputForm(graph);
                form.groupBox1.Text += name;
                //Вывести форму для ввода с клавиатуры в модальном режиме
                form.ShowDialog();
                try
                {
                    graph.ConvertFOtoMatrix();
                    //Проверка графа на эйлеровость
                    graph.EulerianOrNot();
                    //Отображение picterbox
                    picture.Show();
                    //Очистка полотна
                    graph.G.clearSheet();
                    //Визуализиация графа 
                    graph.Visualize();
                    //Если граф эйлеров, отображение пути
                    if (graph.IsEulerian)
                    {
                        //Очистка полотна
                        graph.G.clearSheet();
                        //Рисование пути
                        graph.DrawWay();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Данные не введены или введены неверно", "Ошибка");
                }
            }
        }

        /// <summary>
        /// Кнопка для загрузки информации в экземпляр класса Граф1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputG1_button_Click(object sender, EventArgs e)
        {
            Input(graph1, pictureBox1, " для графа 1");

            //pictureBox1.Hide();
            //graph1.ClearAllData();
            ////Если нажата радиокнопка "ввести из файла"
            //if (FromFile_radioButton.Checked)
            //{
            //    //Если загрузка из файла прошла успешно и файл оказался FO массивом, выполнять все последующие операции
            //    if (graph1.ReadFromFile())
            //    {
            //        //Проверка графа на эйлеровость
            //        graph1.EulerianOrNot();
            //        //Отображение picterbox
            //        pictureBox1.Show();
            //        //Очистка полотна
            //        graph1.G.clearSheet();
            //        //Визуализиация графа 
            //        graph1.Visualize();
            //        //Если граф эйлеров, отображение пути
            //        if (graph1.IsEulerian)
            //        {
            //            //Очистка полотна
            //            graph1.G.clearSheet();
            //            //Рисование пути
            //            graph1.DrawWay();
            //        }
            //    }
            //}
            ////Если нажата радиокнопка "ввести вручную"
            //else
            //{
            //    //Создать форму для ввода с клавиатуры
            //    KeyboardInputForm form = new KeyboardInputForm(graph1);
            //    form.groupBox1.Text += " для графа 1";
            //    //Вывести форму для ввода с клавиатуры в модальном режиме
            //    form.ShowDialog();
            //    try
            //    {
            //        graph1.ConvertFOtoMatrix();
            //        //Проверка графа на эйлеровость
            //        graph1.EulerianOrNot();
            //        //Отображение picterbox
            //        pictureBox1.Show();
            //        //Очистка полотна
            //        graph1.G.clearSheet();
            //        //Визуализиация графа 
            //        graph1.Visualize();
            //        //Если граф эйлеров, отображение пути
            //        if (graph1.IsEulerian)
            //        {
            //            //Очистка полотна
            //            graph1.G.clearSheet();
            //            //Рисование пути
            //            graph1.DrawWay();
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show("Данные не введены или введены неверно", "Ошибка");
            //    }
            //}          
        }

        /// <summary>
        /// Кнопка для загрузки информации в экземпляр класса Граф2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputG2_button_Click(object sender, EventArgs e)
        {
            pictureBox2.Hide();
            graph2.ClearAllData();
            //Если нажата радиокнопка "ввести из файла"
            if (FromFile_radioButton.Checked)
            {
                //Если загрузка из файла прошла успешно и файл оказался FO массивом, выполнять все последующие операции
                if (graph2.ReadFromFile())
                {
                    //Проверка графа на эйлеровость
                    graph2.EulerianOrNot();
                    //Отображение picterbox
                    pictureBox2.Show();
                    //Очистка полотна
                    graph2.G.clearSheet();
                    //Визуализиация графа 
                    graph2.Visualize();
                    //Если граф эйлеров, отображение пути
                    if (graph2.IsEulerian)
                    {
                        //Очистка полотна
                        graph2.G.clearSheet();
                        //Рисование пути
                        graph2.DrawWay();
                    }
                }
            }
            //Если нажата радиокнопка "ввести вручную"
            else
            {
                //Создать форму для ввода с клавиатуры
                KeyboardInputForm form = new KeyboardInputForm(graph2);
                form.groupBox1.Text += " для графа 2";
                //Вывести форму для ввода с клавиатуры в модальном режиме
                form.ShowDialog();
                try
                {
                    graph2.ConvertFOtoMatrix();
                    //Проверка графа на эйлеровость
                    graph2.EulerianOrNot();
                    //Отображение picterbox
                    pictureBox2.Show();
                    //Очистка полотна
                    graph2.G.clearSheet();
                    //Визуализиация графа 
                    graph2.Visualize();
                    //Если граф эйлеров, отображение пути
                    if (graph2.IsEulerian)
                    {
                        //Очистка полотна
                        graph2.G.clearSheet();
                        //Рисование пути
                        graph2.DrawWay();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Данные не введены или введены неверно", "Ошибка");
                }
            }
        }

        /// <summary>
        /// Кнопка для вывода информации о Граф1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InfoG1_button_Click(object sender, EventArgs e)
        {
            InformationForm form = new InformationForm();
            form.Show();
            form.Text += " о Графе 1";
            if (graph1.Name == null)
                form.NameTextBox.Text = "Данные введены вручную";
            else
                form.NameTextBox.Text = graph1.Name;

            form.NumDTextBox.Text = Convert.ToString(graph1.NumberOfDots);
            form.NumLTextBox.Text = Convert.ToString(graph1.NumberOfLine);
            form.EureTextBox.Text = Convert.ToString(graph1.IsEulerian);

            if (graph1.IsEulerian)
            {
                form.WayLabel.Visible = true;
                form.WayTextBox.Visible = true;
                string str = "";
                foreach (var item in graph1.Way)
                {
                    str += Convert.ToString(item)  + " ";
                }
                form.WayTextBox.Text = str;
            }
            else
            {
                form.WayLabel.Visible = false;
                form.WayTextBox.Visible = false;
                form.WayTextBox.Text = "";
            }
        }

        /// <summary>
        /// Кнопка для вывода информации о Граф2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InfoG2_button_Click(object sender, EventArgs e)
        {
            InformationForm form = new InformationForm();
            form.Show();
            form.Text += " о Графе 2";
            if (graph2.Name == null)
            {
                form.NameTextBox.Text = "Данные введены вручную";
            }
            else
                form.NameTextBox.Text = graph2.Name;

            form.NumDTextBox.Text = Convert.ToString(graph2.NumberOfDots);
            form.NumLTextBox.Text = Convert.ToString(graph2.NumberOfLine);
            form.EureTextBox.Text = Convert.ToString(graph2.IsEulerian);

            if (graph2.IsEulerian)
            {
                form.WayLabel.Visible = true;
                form.WayTextBox.Visible = true;
                string str = "";
                foreach (var item in graph2.Way)
                {
                    str += Convert.ToString(item) + " ";
                }
                form.WayTextBox.Text = str;
            }
            else
            {
                form.WayLabel.Visible = false;
                form.WayTextBox.Visible = false;
                form.WayTextBox.Text = "";
            }
        }

        /// <summary>
        /// Кнопка выполняющая сравнение двух графов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Check_button_Click(object sender, EventArgs e)
        {
            //Если оба графа эйлеровы, вывод сообщения об эйлеровости
            if (graph1.IsEulerian && graph2.IsEulerian)
                MessageBox.Show("Оба графы эйлеровы, следовательно равны!\n","Результаты сравнения");
            //Если хотя бы один граф не есть эйлеровым, вывод соответствующего сообщения о разности
            else
                MessageBox.Show("Графы не равны", "Результаты сравнения");  
        }

        /// <summary>
        /// Кнопка для очистки данных о графе 1 и рисунка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CleanG1_button_Click(object sender, EventArgs e)
        {
            graph1.ClearAllData();
            pictureBox1.Image = graph1.G.GetBitmap();
        }

        /// <summary>
        /// Кнопка для очистки данных о графе 2 и рисунка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CleanG2_button_Click(object sender, EventArgs e)
        {
            graph2.ClearAllData();
            pictureBox2.Image = graph2.G.GetBitmap();
        }

        /// <summary>
        /// Кнопка для сохранения изображений графов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveData_button_Click(object sender, EventArgs e)
        {
            if (graph1checkBox.Checked)
                graph1.SaveToFile("граф 1");
            
            if (graph2checkBox.Checked)
                graph2.SaveToFile("граф 2");
        }

        /// <summary>
        /// Задание параметров при загрузке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            infoForm.ShowDialog();

            ToolTip tip = new ToolTip();
            tip.SetToolTip(InputG1_button, "Ввести информацию для графа 1");
            tip.SetToolTip(InputG2_button, "Ввести информацию для графа 2");
            tip.SetToolTip(CleanG1_button, "Очистить всю информацию о графе 1");
            tip.SetToolTip(CleanG2_button, "Очистить всю информацию о графе 2");
            tip.SetToolTip(InfoG1_button, "Получить подробную информацию о графе 1: кол-во вершин и ребер, название файла и информацию о эйлеровости графа");
            tip.SetToolTip(InfoG2_button, "Получить подробную информацию о графе 1: кол-во вершин и ребер, название файла и информацию о эйлеровости графа");
            tip.SetToolTip(Check_button, "Сравнить два графа на эйлеровость");
            tip.SetToolTip(SaveData_button, "Сохранить изображения выбранных графов");
            tip.SetToolTip(GeneralInfo_button, "Посмотреть общую инструкцию управления программой");
        }

        /// <summary>
        /// Кнопка для просмотра общей инструкции
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GeneralInfo_button_Click(object sender, EventArgs e)
        {
            infoForm.ShowDialog();
        }
    }   
}
