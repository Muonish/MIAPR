namespace WFAppPerceptron
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textBoxNclasses = new System.Windows.Forms.TextBox();
            this.labelN = new System.Windows.Forms.Label();
            this.buttonFindFunctions = new System.Windows.Forms.Button();
            this.textBoxFunctions = new System.Windows.Forms.TextBox();
            this.labelNobjects = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNobjects = new System.Windows.Forms.TextBox();
            this.labelNattributes = new System.Windows.Forms.Label();
            this.textBoxNattributes = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewTest = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.buttonClassify = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxClasses = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTest)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNclasses
            // 
            this.textBoxNclasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNclasses.Location = new System.Drawing.Point(241, 55);
            this.textBoxNclasses.Name = "textBoxNclasses";
            this.textBoxNclasses.Size = new System.Drawing.Size(59, 24);
            this.textBoxNclasses.TabIndex = 0;
            this.textBoxNclasses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNclasses_KeyPress);
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.BackColor = System.Drawing.Color.Transparent;
            this.labelN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelN.ForeColor = System.Drawing.SystemColors.Window;
            this.labelN.Location = new System.Drawing.Point(30, 57);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(162, 20);
            this.labelN.TabIndex = 1;
            this.labelN.Text = "Number of classes:";
            // 
            // buttonFindFunctions
            // 
            this.buttonFindFunctions.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonFindFunctions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFindFunctions.BackgroundImage")));
            this.buttonFindFunctions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFindFunctions.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonFindFunctions.Location = new System.Drawing.Point(34, 195);
            this.buttonFindFunctions.Name = "buttonFindFunctions";
            this.buttonFindFunctions.Size = new System.Drawing.Size(266, 42);
            this.buttonFindFunctions.TabIndex = 2;
            this.buttonFindFunctions.Text = "Find the decision functions";
            this.buttonFindFunctions.UseVisualStyleBackColor = false;
            this.buttonFindFunctions.Click += new System.EventHandler(this.buttonFindFunctions_Click);
            // 
            // textBoxFunctions
            // 
            this.textBoxFunctions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFunctions.Location = new System.Drawing.Point(34, 257);
            this.textBoxFunctions.Multiline = true;
            this.textBoxFunctions.Name = "textBoxFunctions";
            this.textBoxFunctions.ReadOnly = true;
            this.textBoxFunctions.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxFunctions.Size = new System.Drawing.Size(266, 278);
            this.textBoxFunctions.TabIndex = 3;
            this.textBoxFunctions.WordWrap = false;
            // 
            // labelNobjects
            // 
            this.labelNobjects.AutoSize = true;
            this.labelNobjects.BackColor = System.Drawing.Color.Transparent;
            this.labelNobjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNobjects.ForeColor = System.Drawing.SystemColors.Window;
            this.labelNobjects.Location = new System.Drawing.Point(30, 93);
            this.labelNobjects.Name = "labelNobjects";
            this.labelNobjects.Size = new System.Drawing.Size(205, 20);
            this.labelNobjects.TabIndex = 4;
            this.labelNobjects.Text = "Number of objects in the";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(30, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "training set for a class:";
            // 
            // textBoxNobjects
            // 
            this.textBoxNobjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNobjects.Location = new System.Drawing.Point(241, 111);
            this.textBoxNobjects.Name = "textBoxNobjects";
            this.textBoxNobjects.Size = new System.Drawing.Size(59, 24);
            this.textBoxNobjects.TabIndex = 6;
            this.textBoxNobjects.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNclasses_KeyPress);
            // 
            // labelNattributes
            // 
            this.labelNattributes.AutoSize = true;
            this.labelNattributes.BackColor = System.Drawing.Color.Transparent;
            this.labelNattributes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNattributes.ForeColor = System.Drawing.SystemColors.Window;
            this.labelNattributes.Location = new System.Drawing.Point(30, 150);
            this.labelNattributes.Name = "labelNattributes";
            this.labelNattributes.Size = new System.Drawing.Size(179, 20);
            this.labelNattributes.TabIndex = 7;
            this.labelNattributes.Text = "Number of attributes:";
            // 
            // textBoxNattributes
            // 
            this.textBoxNattributes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNattributes.Location = new System.Drawing.Point(241, 150);
            this.textBoxNattributes.Name = "textBoxNattributes";
            this.textBoxNattributes.Size = new System.Drawing.Size(59, 24);
            this.textBoxNattributes.TabIndex = 8;
            this.textBoxNattributes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNclasses_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.dataGridViewTest);
            this.panel1.Controls.Add(this.labelAnswer);
            this.panel1.Controls.Add(this.buttonClassify);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(619, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 591);
            this.panel1.TabIndex = 9;
            // 
            // dataGridViewTest
            // 
            this.dataGridViewTest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTest.ColumnHeadersVisible = false;
            this.dataGridViewTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridViewTest.Location = new System.Drawing.Point(31, 57);
            this.dataGridViewTest.Name = "dataGridViewTest";
            this.dataGridViewTest.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewTest.RowHeadersVisible = false;
            this.dataGridViewTest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewTest.Size = new System.Drawing.Size(192, 132);
            this.dataGridViewTest.TabIndex = 14;
            this.dataGridViewTest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridViewTest_KeyPress);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Width = 192;
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.BackColor = System.Drawing.Color.Transparent;
            this.labelAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAnswer.ForeColor = System.Drawing.SystemColors.Window;
            this.labelAnswer.Location = new System.Drawing.Point(27, 259);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(73, 20);
            this.labelAnswer.TabIndex = 12;
            this.labelAnswer.Text = "Answer:";
            // 
            // buttonClassify
            // 
            this.buttonClassify.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonClassify.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClassify.BackgroundImage")));
            this.buttonClassify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClassify.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonClassify.Location = new System.Drawing.Point(31, 195);
            this.buttonClassify.Name = "buttonClassify";
            this.buttonClassify.Size = new System.Drawing.Size(192, 42);
            this.buttonClassify.TabIndex = 13;
            this.buttonClassify.Text = "Classify";
            this.buttonClassify.UseVisualStyleBackColor = false;
            this.buttonClassify.Click += new System.EventHandler(this.buttonClassify_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(27, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Test sample:";
            // 
            // textBoxClasses
            // 
            this.textBoxClasses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.textBoxClasses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxClasses.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxClasses.Location = new System.Drawing.Point(340, 55);
            this.textBoxClasses.Multiline = true;
            this.textBoxClasses.Name = "textBoxClasses";
            this.textBoxClasses.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxClasses.Size = new System.Drawing.Size(241, 480);
            this.textBoxClasses.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(336, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Classes:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(873, 565);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxClasses);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxNattributes);
            this.Controls.Add(this.labelNattributes);
            this.Controls.Add(this.textBoxNobjects);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNobjects);
            this.Controls.Add(this.textBoxFunctions);
            this.Controls.Add(this.buttonFindFunctions);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.textBoxNclasses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.Text = "Perceptron";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNclasses;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Button buttonFindFunctions;
        public System.Windows.Forms.TextBox textBoxFunctions;
        private System.Windows.Forms.Label labelNobjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNobjects;
        private System.Windows.Forms.Label labelNattributes;
        private System.Windows.Forms.TextBox textBoxNattributes;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox textBoxClasses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonClassify;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.DataGridView dataGridViewTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

