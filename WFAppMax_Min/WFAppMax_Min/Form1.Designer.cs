namespace WFAppMax_Min
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
            this.panelHolst = new System.Windows.Forms.Panel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelNpoints = new System.Windows.Forms.Label();
            this.comboBoxPoints = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // panelHolst
            // 
            this.panelHolst.BackColor = System.Drawing.SystemColors.Window;
            this.panelHolst.Location = new System.Drawing.Point(269, 2);
            this.panelHolst.Name = "panelHolst";
            this.panelHolst.Size = new System.Drawing.Size(843, 599);
            this.panelHolst.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(51, 423);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(167, 81);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelStatus.Location = new System.Drawing.Point(86, 546);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(117, 20);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "Recalculation...";
            // 
            // labelNpoints
            // 
            this.labelNpoints.AutoSize = true;
            this.labelNpoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNpoints.Location = new System.Drawing.Point(47, 115);
            this.labelNpoints.Name = "labelNpoints";
            this.labelNpoints.Size = new System.Drawing.Size(134, 20);
            this.labelNpoints.TabIndex = 5;
            this.labelNpoints.Text = "Number of points:";
            // 
            // comboBoxPoints
            // 
            this.comboBoxPoints.DisplayMember = "int";
            this.comboBoxPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPoints.FormattingEnabled = true;
            this.comboBoxPoints.Items.AddRange(new object[] {
            "20",
            "50",
            "100",
            "150",
            "1000",
            "5000",
            "25000",
            "50000"});
            this.comboBoxPoints.Location = new System.Drawing.Point(51, 150);
            this.comboBoxPoints.Name = "comboBoxPoints";
            this.comboBoxPoints.Size = new System.Drawing.Size(167, 28);
            this.comboBoxPoints.TabIndex = 7;
            this.comboBoxPoints.ValueMember = "int";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 602);
            this.Controls.Add(this.comboBoxPoints);
            this.Controls.Add(this.labelNpoints);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.panelHolst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.Text = "Maximin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panelHolst;
        private System.Windows.Forms.Button buttonStart;
        public System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelNpoints;
        private System.Windows.Forms.ComboBox comboBoxPoints;
    }
}

