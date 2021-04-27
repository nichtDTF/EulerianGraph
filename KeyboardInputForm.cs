using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EulerianGraph
{
    public partial class KeyboardInputForm : Form
    {
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public KeyboardInputForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Конструктор с параметром
        /// </summary>
        /// <param name="eurelian">Текущий граф</param>
        public KeyboardInputForm(Eurelian.Graph eurelian)
        {
            InitializeComponent();
            Curr = eurelian;
        }

        /// <summary>
        /// Временный массив для ввода ФО представления матрицы вручную
        /// </summary>
        public int[] Array { get; set; }        

        /// <summary>
        /// Экземпляр текущего графа
        /// </summary>
        public Eurelian.Graph Curr;
       
        /// <summary>
        /// Ввод информации с помощью клавиатуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Check_button_Click(object sender, EventArgs e)
        {
            MassivTextBox.BackColor = Color.White;

            string AllText = MassivTextBox.Text;

            List<string> tmp = new List<string>();
            string[] ArrayWithData = new string[120];

            List<int> OutputArray = new List<int>();

            try
            {
                ArrayWithData = AllText.Split(' ');
                Array = new int[ArrayWithData.Length];
                for (int i = 0; i < ArrayWithData.Length; i++)
                {
                    OutputArray.Add(Convert.ToInt32(ArrayWithData[i]));
                }
                MassivTextBox.BackColor = Color.Green;

                Curr.FO = OutputArray;
            }
            catch (Exception)
            {
                MassivTextBox.BackColor = Color.Red;
            }
        }
    }
}
