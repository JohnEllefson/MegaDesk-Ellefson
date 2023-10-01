namespace MegaDesk_Ellefson
{
    partial class AddQuote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.desktopMaterialComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rushOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.time3DaysRadioButton = new System.Windows.Forms.RadioButton();
            this.time5DaysRadioButton = new System.Windows.Forms.RadioButton();
            this.time7DaysRadioButton = new System.Windows.Forms.RadioButton();
            this.time14DaysRadioButton = new System.Windows.Forms.RadioButton();
            this.submitQuoteButton = new System.Windows.Forms.Button();
            this.deskWidthTextBox = new System.Windows.Forms.TextBox();
            this.deskDepthTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.todayDateLabel = new System.Windows.Forms.Label();
            this.deskNumOfDrawersUpDown = new System.Windows.Forms.NumericUpDown();
            this.rushOrderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deskNumOfDrawersUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTextBox.Location = new System.Drawing.Point(211, 17);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(120, 21);
            this.customerNameTextBox.TabIndex = 0;
            this.customerNameTextBox.Text = "John Doe";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(266, 276);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Desk Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Desk Depth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Number of Drawers";
            // 
            // desktopMaterialComboBox
            // 
            this.desktopMaterialComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desktopMaterialComboBox.FormattingEnabled = true;
            this.desktopMaterialComboBox.Items.AddRange(new object[] {
            "Pine",
            "Laminate",
            "Veneer",
            "Oak",
            "Rosewood"});
            this.desktopMaterialComboBox.Location = new System.Drawing.Point(211, 133);
            this.desktopMaterialComboBox.Name = "desktopMaterialComboBox";
            this.desktopMaterialComboBox.Size = new System.Drawing.Size(121, 23);
            this.desktopMaterialComboBox.TabIndex = 4;
            this.desktopMaterialComboBox.Text = "Pine";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(100, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Desktop Material";
            // 
            // rushOrderGroupBox
            // 
            this.rushOrderGroupBox.Controls.Add(this.time3DaysRadioButton);
            this.rushOrderGroupBox.Controls.Add(this.time5DaysRadioButton);
            this.rushOrderGroupBox.Controls.Add(this.time7DaysRadioButton);
            this.rushOrderGroupBox.Controls.Add(this.time14DaysRadioButton);
            this.rushOrderGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushOrderGroupBox.Location = new System.Drawing.Point(115, 162);
            this.rushOrderGroupBox.Name = "rushOrderGroupBox";
            this.rushOrderGroupBox.Size = new System.Drawing.Size(133, 108);
            this.rushOrderGroupBox.TabIndex = 5;
            this.rushOrderGroupBox.TabStop = false;
            this.rushOrderGroupBox.Text = "Rush Order";
            // 
            // time3DaysRadioButton
            // 
            this.time3DaysRadioButton.AutoSize = true;
            this.time3DaysRadioButton.Location = new System.Drawing.Point(6, 82);
            this.time3DaysRadioButton.Name = "time3DaysRadioButton";
            this.time3DaysRadioButton.Size = new System.Drawing.Size(62, 19);
            this.time3DaysRadioButton.TabIndex = 8;
            this.time3DaysRadioButton.Text = "3 Days";
            this.time3DaysRadioButton.UseVisualStyleBackColor = true;
            // 
            // time5DaysRadioButton
            // 
            this.time5DaysRadioButton.AutoSize = true;
            this.time5DaysRadioButton.Location = new System.Drawing.Point(6, 61);
            this.time5DaysRadioButton.Name = "time5DaysRadioButton";
            this.time5DaysRadioButton.Size = new System.Drawing.Size(62, 19);
            this.time5DaysRadioButton.TabIndex = 7;
            this.time5DaysRadioButton.Text = "5 Days";
            this.time5DaysRadioButton.UseVisualStyleBackColor = true;
            // 
            // time7DaysRadioButton
            // 
            this.time7DaysRadioButton.AutoSize = true;
            this.time7DaysRadioButton.Location = new System.Drawing.Point(6, 40);
            this.time7DaysRadioButton.Name = "time7DaysRadioButton";
            this.time7DaysRadioButton.Size = new System.Drawing.Size(62, 19);
            this.time7DaysRadioButton.TabIndex = 6;
            this.time7DaysRadioButton.Text = "7 Days";
            this.time7DaysRadioButton.UseVisualStyleBackColor = true;
            // 
            // time14DaysRadioButton
            // 
            this.time14DaysRadioButton.AutoSize = true;
            this.time14DaysRadioButton.Checked = true;
            this.time14DaysRadioButton.Location = new System.Drawing.Point(6, 19);
            this.time14DaysRadioButton.Name = "time14DaysRadioButton";
            this.time14DaysRadioButton.Size = new System.Drawing.Size(121, 19);
            this.time14DaysRadioButton.TabIndex = 5;
            this.time14DaysRadioButton.TabStop = true;
            this.time14DaysRadioButton.Text = "Normal (14 Days)";
            this.time14DaysRadioButton.UseVisualStyleBackColor = true;
            // 
            // submitQuoteButton
            // 
            this.submitQuoteButton.Location = new System.Drawing.Point(347, 276);
            this.submitQuoteButton.Name = "submitQuoteButton";
            this.submitQuoteButton.Size = new System.Drawing.Size(75, 23);
            this.submitQuoteButton.TabIndex = 10;
            this.submitQuoteButton.Text = "Submit";
            this.submitQuoteButton.UseVisualStyleBackColor = true;
            this.submitQuoteButton.Click += new System.EventHandler(this.submitQuoteButton_Click);
            // 
            // deskWidthTextBox
            // 
            this.deskWidthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskWidthTextBox.Location = new System.Drawing.Point(211, 46);
            this.deskWidthTextBox.Name = "deskWidthTextBox";
            this.deskWidthTextBox.Size = new System.Drawing.Size(120, 21);
            this.deskWidthTextBox.TabIndex = 1;
            this.deskWidthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.deskWidthInput_Validating);
            // 
            // deskDepthTextBox
            // 
            this.deskDepthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskDepthTextBox.Location = new System.Drawing.Point(211, 75);
            this.deskDepthTextBox.Name = "deskDepthTextBox";
            this.deskDepthTextBox.Size = new System.Drawing.Size(120, 21);
            this.deskDepthTextBox.TabIndex = 2;
            this.deskDepthTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.deskDepthInputKeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(260, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Today\'s Date:";
            // 
            // todayDateLabel
            // 
            this.todayDateLabel.AutoSize = true;
            this.todayDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayDateLabel.Location = new System.Drawing.Point(273, 211);
            this.todayDateLabel.Name = "todayDateLabel";
            this.todayDateLabel.Size = new System.Drawing.Size(0, 17);
            this.todayDateLabel.TabIndex = 24;
            // 
            // deskNumOfDrawersUpDown
            // 
            this.deskNumOfDrawersUpDown.Location = new System.Drawing.Point(211, 104);
            this.deskNumOfDrawersUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.deskNumOfDrawersUpDown.Name = "deskNumOfDrawersUpDown";
            this.deskNumOfDrawersUpDown.Size = new System.Drawing.Size(121, 20);
            this.deskNumOfDrawersUpDown.TabIndex = 3;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.deskNumOfDrawersUpDown);
            this.Controls.Add(this.todayDateLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deskDepthTextBox);
            this.Controls.Add(this.deskWidthTextBox);
            this.Controls.Add(this.submitQuoteButton);
            this.Controls.Add(this.rushOrderGroupBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.desktopMaterialComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.customerNameTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Quote";
            this.rushOrderGroupBox.ResumeLayout(false);
            this.rushOrderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deskNumOfDrawersUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox desktopMaterialComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox rushOrderGroupBox;
        private System.Windows.Forms.RadioButton time3DaysRadioButton;
        private System.Windows.Forms.RadioButton time5DaysRadioButton;
        private System.Windows.Forms.RadioButton time7DaysRadioButton;
        private System.Windows.Forms.RadioButton time14DaysRadioButton;
        private System.Windows.Forms.Button submitQuoteButton;
        private System.Windows.Forms.TextBox deskWidthTextBox;
        private System.Windows.Forms.TextBox deskDepthTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label todayDateLabel;
        private System.Windows.Forms.NumericUpDown deskNumOfDrawersUpDown;
    }
}