
namespace EulerianGraph
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Check_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.InfoG1_button = new System.Windows.Forms.Button();
            this.InputG1_button = new System.Windows.Forms.Button();
            this.CleanG1_button = new System.Windows.Forms.Button();
            this.SettingBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.graph2checkBox = new System.Windows.Forms.CheckBox();
            this.graph1checkBox = new System.Windows.Forms.CheckBox();
            this.FromKeyboard_radioButton = new System.Windows.Forms.RadioButton();
            this.FromFile_radioButton = new System.Windows.Forms.RadioButton();
            this.SaveData_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InfoG2_button = new System.Windows.Forms.Button();
            this.InputG2_button = new System.Windows.Forms.Button();
            this.CleanG2_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.GeneralInfo_button = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SettingBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Check_button
            // 
            this.Check_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Check_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Check_button.Location = new System.Drawing.Point(1192, 268);
            this.Check_button.Name = "Check_button";
            this.Check_button.Size = new System.Drawing.Size(200, 54);
            this.Check_button.TabIndex = 0;
            this.Check_button.Text = "Сравнить";
            this.Check_button.UseVisualStyleBackColor = true;
            this.Check_button.Click += new System.EventHandler(this.Check_button_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.InfoG1_button);
            this.panel2.Controls.Add(this.InputG1_button);
            this.panel2.Controls.Add(this.CleanG1_button);
            this.panel2.Location = new System.Drawing.Point(170, 482);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 60);
            this.panel2.TabIndex = 9;
            // 
            // InfoG1_button
            // 
            this.InfoG1_button.Cursor = System.Windows.Forms.Cursors.Help;
            this.InfoG1_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InfoG1_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoG1_button.Image = ((System.Drawing.Image)(resources.GetObject("InfoG1_button.Image")));
            this.InfoG1_button.Location = new System.Drawing.Point(109, 7);
            this.InfoG1_button.Name = "InfoG1_button";
            this.InfoG1_button.Size = new System.Drawing.Size(43, 47);
            this.InfoG1_button.TabIndex = 8;
            this.InfoG1_button.UseVisualStyleBackColor = true;
            this.InfoG1_button.Click += new System.EventHandler(this.InfoG1_button_Click);
            // 
            // InputG1_button
            // 
            this.InputG1_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InputG1_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InputG1_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputG1_button.Image = ((System.Drawing.Image)(resources.GetObject("InputG1_button.Image")));
            this.InputG1_button.Location = new System.Drawing.Point(9, 7);
            this.InputG1_button.Name = "InputG1_button";
            this.InputG1_button.Size = new System.Drawing.Size(43, 47);
            this.InputG1_button.TabIndex = 7;
            this.InputG1_button.UseVisualStyleBackColor = true;
            this.InputG1_button.Click += new System.EventHandler(this.InputG1_button_Click);
            // 
            // CleanG1_button
            // 
            this.CleanG1_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CleanG1_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CleanG1_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CleanG1_button.Image = ((System.Drawing.Image)(resources.GetObject("CleanG1_button.Image")));
            this.CleanG1_button.Location = new System.Drawing.Point(59, 7);
            this.CleanG1_button.Name = "CleanG1_button";
            this.CleanG1_button.Size = new System.Drawing.Size(43, 47);
            this.CleanG1_button.TabIndex = 6;
            this.CleanG1_button.UseVisualStyleBackColor = true;
            this.CleanG1_button.Click += new System.EventHandler(this.CleanG1_button_Click);
            // 
            // SettingBox
            // 
            this.SettingBox.Controls.Add(this.label1);
            this.SettingBox.Controls.Add(this.graph2checkBox);
            this.SettingBox.Controls.Add(this.graph1checkBox);
            this.SettingBox.Controls.Add(this.FromKeyboard_radioButton);
            this.SettingBox.Controls.Add(this.FromFile_radioButton);
            this.SettingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingBox.Location = new System.Drawing.Point(1192, 12);
            this.SettingBox.Name = "SettingBox";
            this.SettingBox.Size = new System.Drawing.Size(200, 250);
            this.SettingBox.TabIndex = 13;
            this.SettingBox.TabStop = false;
            this.SettingBox.Text = "Настройки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Какие графы сохранить?";
            // 
            // graph2checkBox
            // 
            this.graph2checkBox.AutoSize = true;
            this.graph2checkBox.Location = new System.Drawing.Point(6, 186);
            this.graph2checkBox.Name = "graph2checkBox";
            this.graph2checkBox.Size = new System.Drawing.Size(80, 21);
            this.graph2checkBox.TabIndex = 5;
            this.graph2checkBox.Text = "Граф 2";
            this.graph2checkBox.UseVisualStyleBackColor = true;
            // 
            // graph1checkBox
            // 
            this.graph1checkBox.AutoSize = true;
            this.graph1checkBox.Location = new System.Drawing.Point(6, 165);
            this.graph1checkBox.Name = "graph1checkBox";
            this.graph1checkBox.Size = new System.Drawing.Size(80, 21);
            this.graph1checkBox.TabIndex = 4;
            this.graph1checkBox.Text = "Граф 1";
            this.graph1checkBox.UseVisualStyleBackColor = true;
            // 
            // FromKeyboard_radioButton
            // 
            this.FromKeyboard_radioButton.AutoSize = true;
            this.FromKeyboard_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FromKeyboard_radioButton.Location = new System.Drawing.Point(25, 59);
            this.FromKeyboard_radioButton.Name = "FromKeyboard_radioButton";
            this.FromKeyboard_radioButton.Size = new System.Drawing.Size(151, 21);
            this.FromKeyboard_radioButton.TabIndex = 3;
            this.FromKeyboard_radioButton.Text = "Ввод с клавиатуры";
            this.FromKeyboard_radioButton.UseVisualStyleBackColor = true;
            // 
            // FromFile_radioButton
            // 
            this.FromFile_radioButton.AutoSize = true;
            this.FromFile_radioButton.Checked = true;
            this.FromFile_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FromFile_radioButton.Location = new System.Drawing.Point(25, 32);
            this.FromFile_radioButton.Name = "FromFile_radioButton";
            this.FromFile_radioButton.Size = new System.Drawing.Size(124, 21);
            this.FromFile_radioButton.TabIndex = 2;
            this.FromFile_radioButton.TabStop = true;
            this.FromFile_radioButton.Text = "Ввод из файла";
            this.FromFile_radioButton.UseVisualStyleBackColor = true;
            // 
            // SaveData_button
            // 
            this.SaveData_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveData_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveData_button.Location = new System.Drawing.Point(1192, 328);
            this.SaveData_button.Name = "SaveData_button";
            this.SaveData_button.Size = new System.Drawing.Size(200, 54);
            this.SaveData_button.TabIndex = 16;
            this.SaveData_button.Text = "Сохранить информацию";
            this.SaveData_button.UseVisualStyleBackColor = true;
            this.SaveData_button.Click += new System.EventHandler(this.SaveData_button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.InfoG2_button);
            this.panel1.Controls.Add(this.InputG2_button);
            this.panel1.Controls.Add(this.CleanG2_button);
            this.panel1.Location = new System.Drawing.Point(808, 482);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 60);
            this.panel1.TabIndex = 10;
            // 
            // InfoG2_button
            // 
            this.InfoG2_button.Cursor = System.Windows.Forms.Cursors.Help;
            this.InfoG2_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InfoG2_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoG2_button.Image = ((System.Drawing.Image)(resources.GetObject("InfoG2_button.Image")));
            this.InfoG2_button.Location = new System.Drawing.Point(109, 7);
            this.InfoG2_button.Name = "InfoG2_button";
            this.InfoG2_button.Size = new System.Drawing.Size(43, 47);
            this.InfoG2_button.TabIndex = 8;
            this.InfoG2_button.UseVisualStyleBackColor = true;
            this.InfoG2_button.Click += new System.EventHandler(this.InfoG2_button_Click);
            // 
            // InputG2_button
            // 
            this.InputG2_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InputG2_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InputG2_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputG2_button.Image = ((System.Drawing.Image)(resources.GetObject("InputG2_button.Image")));
            this.InputG2_button.Location = new System.Drawing.Point(9, 7);
            this.InputG2_button.Name = "InputG2_button";
            this.InputG2_button.Size = new System.Drawing.Size(43, 47);
            this.InputG2_button.TabIndex = 7;
            this.InputG2_button.UseVisualStyleBackColor = true;
            this.InputG2_button.Click += new System.EventHandler(this.InputG2_button_Click);
            // 
            // CleanG2_button
            // 
            this.CleanG2_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CleanG2_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CleanG2_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CleanG2_button.Image = ((System.Drawing.Image)(resources.GetObject("CleanG2_button.Image")));
            this.CleanG2_button.Location = new System.Drawing.Point(59, 7);
            this.CleanG2_button.Name = "CleanG2_button";
            this.CleanG2_button.Size = new System.Drawing.Size(43, 47);
            this.CleanG2_button.TabIndex = 6;
            this.CleanG2_button.UseVisualStyleBackColor = true;
            this.CleanG2_button.Click += new System.EventHandler(this.CleanG2_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(560, 433);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 464);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Граф 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(597, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(579, 464);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Граф 2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(6, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(560, 433);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // GeneralInfo_button
            // 
            this.GeneralInfo_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GeneralInfo_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GeneralInfo_button.Location = new System.Drawing.Point(1192, 412);
            this.GeneralInfo_button.Name = "GeneralInfo_button";
            this.GeneralInfo_button.Size = new System.Drawing.Size(200, 54);
            this.GeneralInfo_button.TabIndex = 22;
            this.GeneralInfo_button.Text = "Просмотреть инструкцию";
            this.GeneralInfo_button.UseVisualStyleBackColor = true;
            this.GeneralInfo_button.Click += new System.EventHandler(this.GeneralInfo_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 569);
            this.Controls.Add(this.GeneralInfo_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SaveData_button);
            this.Controls.Add(this.SettingBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Check_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Сравнение эйлеровости графов";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.SettingBox.ResumeLayout(false);
            this.SettingBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Check_button;
        private System.Windows.Forms.Button CleanG1_button;
        private System.Windows.Forms.Button InfoG1_button;
        private System.Windows.Forms.GroupBox SettingBox;
        private System.Windows.Forms.Button SaveData_button;
        private System.Windows.Forms.Button InfoG2_button;
        private System.Windows.Forms.Button CleanG2_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox graph2checkBox;
        private System.Windows.Forms.CheckBox graph1checkBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GeneralInfo_button;
        public System.Windows.Forms.RadioButton FromKeyboard_radioButton;
        public System.Windows.Forms.RadioButton FromFile_radioButton;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button InputG1_button;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button InputG2_button;
    }
}

