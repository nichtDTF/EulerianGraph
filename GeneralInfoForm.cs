using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EulerianGraph
{
    public partial class GeneralInfoForm : Form
    {
        /// <summary>
        /// Счетчик, используемый при пролистывании формы
        /// </summary>
        private int a = 0;
        
        /// <summary>
        /// Список для хранения всех изображений
        /// </summary>
        private List<Image> images = new List<Image>();

        public GeneralInfoForm()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

            pictureBox1.Image = Image.FromFile("D:\\khai\\2_KURS\\Курсовой\\proj\\General_info4.png");
            images.Add(pictureBox1.Image);

            pictureBox1.Image = Image.FromFile("D:\\khai\\2_KURS\\Курсовой\\proj\\General_info3.png");
            images.Add(pictureBox1.Image);

            pictureBox1.Image = Image.FromFile("D:\\khai\\2_KURS\\Курсовой\\proj\\General_info.png");
            images.Add(pictureBox1.Image);

            pictureBox1.Image = Image.FromFile("D:\\khai\\2_KURS\\Курсовой\\proj\\General_info2.png");
            images.Add(pictureBox1.Image);


        }

        /// <summary>
        /// Кнопка для отображения следующего элемента инструкции
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Next_button_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = images[a%4];
            a++;
        }
    }
}
