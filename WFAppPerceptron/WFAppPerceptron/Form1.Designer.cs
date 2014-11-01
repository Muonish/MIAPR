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
            this.labelNsigns = new System.Windows.Forms.Label();
            this.textBoxNsigns = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxTest = new System.Windows.Forms.TextBox();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxClasses = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            this.textBoxNobjects.Location = new System.Drawing.Point(241, 109);
            this.textBoxNobjects.Name = "textBoxNobjects";
            this.textBoxNobjects.Size = new System.Drawing.Size(59, 24);
            this.textBoxNobjects.TabIndex = 6;
            this.textBoxNobjects.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNclasses_KeyPress);
            // 
            // labelNsigns
            // 
            this.labelNsigns.AutoSize = true;
            this.labelNsigns.BackColor = System.Drawing.Color.Transparent;
            this.labelNsigns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNsigns.ForeColor = System.Drawing.SystemColors.Window;
            this.labelNsigns.Location = new System.Drawing.Point(30, 150);
            this.labelNsigns.Name = "labelNsigns";
            this.labelNsigns.Size = new System.Drawing.Size(144, 20);
            this.labelNsigns.TabIndex = 7;
            this.labelNsigns.Text = "Number of signs:";
            // 
            // textBoxNsigns
            // 
            this.textBoxNsigns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNsigns.Location = new System.Drawing.Point(241, 150);
            this.textBoxNsigns.Name = "textBoxNsigns";
            this.textBoxNsigns.Size = new System.Drawing.Size(59, 24);
            this.textBoxNsigns.TabIndex = 8;
            this.textBoxNsigns.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNclasses_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.textBoxTest);
            this.panel1.Controls.Add(this.labelAnswer);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(619, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 591);
            this.panel1.TabIndex = 9;
            // 
            // textBoxTest
            // 
            this.textBoxTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTest.Location = new System.Drawing.Point(31, 109);
            this.textBoxTest.Name = "textBoxTest";
            this.textBoxTest.Size = new System.Drawing.Size(192, 24);
            this.textBoxTest.TabIndex = 14;
            this.textBoxTest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTest_KeyPress);
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.BackColor = System.Drawing.Color.Transparent;
            this.labelAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAnswer.ForeColor = System.Drawing.SystemColors.Window;
            this.labelAnswer.Location = new System.Drawing.Point(27, 314);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(73, 20);
            this.labelAnswer.TabIndex = 12;
            this.labelAnswer.Text = "Answer:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(31, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "Classify";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(27, 77);
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
            this.Controls.Add(this.textBoxNsigns);
            this.Controls.Add(this.labelNsigns);
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
        private System.Windows.Forms.Label labelNsigns;
        private System.Windows.Forms.TextBox textBoxNsigns;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox textBoxClasses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTest;
        private System.Windows.Forms.Label labelAnswer;
    }
}

