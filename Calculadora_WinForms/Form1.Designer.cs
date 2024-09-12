namespace Calculadora_WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            txt_OpBox = new TextBox();
            txt_SNumber = new TextBox();
            btn_7 = new Button();
            btn_8 = new Button();
            btn_9 = new Button();
            btn_4 = new Button();
            btn_5 = new Button();
            btn_6 = new Button();
            btn_1 = new Button();
            btn_2 = new Button();
            btn_3 = new Button();
            btn_0 = new Button();
            btn_Div = new Button();
            btn_Mult = new Button();
            btn_Sub = new Button();
            btn_Soma = new Button();
            btn_Virgula = new Button();
            btn_Equals = new Button();
            btn_Backspace = new Button();
            btn_Clear = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(txt_OpBox);
            panel1.Controls.Add(txt_SNumber);
            panel1.Location = new Point(12, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 86);
            panel1.TabIndex = 0;
            // 
            // txt_OpBox
            // 
            txt_OpBox.BackColor = SystemColors.GradientInactiveCaption;
            txt_OpBox.BorderStyle = BorderStyle.None;
            txt_OpBox.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_OpBox.Location = new Point(0, -1);
            txt_OpBox.Name = "txt_OpBox";
            txt_OpBox.ReadOnly = true;
            txt_OpBox.Size = new Size(266, 14);
            txt_OpBox.TabIndex = 1;
            // 
            // txt_SNumber
            // 
            txt_SNumber.BackColor = SystemColors.GradientInactiveCaption;
            txt_SNumber.BorderStyle = BorderStyle.None;
            txt_SNumber.Font = new Font("Arial", 25F);
            txt_SNumber.Location = new Point(3, 16);
            txt_SNumber.Multiline = true;
            txt_SNumber.Name = "txt_SNumber";
            txt_SNumber.ReadOnly = true;
            txt_SNumber.Size = new Size(260, 67);
            txt_SNumber.TabIndex = 0;
            txt_SNumber.TextAlign = HorizontalAlignment.Right;
            txt_SNumber.TextChanged += txt_SNumber_TextChanged;
            // 
            // btn_7
            // 
            btn_7.Location = new Point(14, 154);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(50, 50);
            btn_7.TabIndex = 1;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += btn_7_Click;
            // 
            // btn_8
            // 
            btn_8.Location = new Point(81, 154);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(50, 50);
            btn_8.TabIndex = 2;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += btn_8_Click;
            // 
            // btn_9
            // 
            btn_9.Location = new Point(149, 154);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(50, 50);
            btn_9.TabIndex = 3;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += btn_9_Click;
            // 
            // btn_4
            // 
            btn_4.Location = new Point(14, 220);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(50, 50);
            btn_4.TabIndex = 4;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += btn_4_Click;
            // 
            // btn_5
            // 
            btn_5.Location = new Point(81, 220);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(50, 50);
            btn_5.TabIndex = 5;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += btn_5_Click;
            // 
            // btn_6
            // 
            btn_6.Location = new Point(149, 220);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(50, 50);
            btn_6.TabIndex = 6;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += btn_6_Click;
            // 
            // btn_1
            // 
            btn_1.Location = new Point(14, 287);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(50, 50);
            btn_1.TabIndex = 7;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += btn_1_Click;
            // 
            // btn_2
            // 
            btn_2.Location = new Point(81, 287);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(50, 50);
            btn_2.TabIndex = 8;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += btn_2_Click;
            // 
            // btn_3
            // 
            btn_3.Location = new Point(149, 287);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(50, 50);
            btn_3.TabIndex = 9;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += btn_3_Click;
            // 
            // btn_0
            // 
            btn_0.Location = new Point(81, 358);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(50, 50);
            btn_0.TabIndex = 10;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += btn_0_Click;
            // 
            // btn_Div
            // 
            btn_Div.Location = new Point(228, 154);
            btn_Div.Name = "btn_Div";
            btn_Div.Size = new Size(50, 50);
            btn_Div.TabIndex = 11;
            btn_Div.Text = "/";
            btn_Div.UseVisualStyleBackColor = true;
            btn_Div.Click += btn_Div_Click;
            // 
            // btn_Mult
            // 
            btn_Mult.Location = new Point(228, 220);
            btn_Mult.Name = "btn_Mult";
            btn_Mult.Size = new Size(50, 50);
            btn_Mult.TabIndex = 12;
            btn_Mult.Text = "X";
            btn_Mult.UseVisualStyleBackColor = true;
            btn_Mult.Click += btn_Mult_Click;
            // 
            // btn_Sub
            // 
            btn_Sub.Location = new Point(228, 287);
            btn_Sub.Name = "btn_Sub";
            btn_Sub.Size = new Size(50, 50);
            btn_Sub.TabIndex = 13;
            btn_Sub.Text = "-";
            btn_Sub.UseVisualStyleBackColor = true;
            btn_Sub.Click += btn_Sub_Click;
            // 
            // btn_Soma
            // 
            btn_Soma.Location = new Point(228, 358);
            btn_Soma.Name = "btn_Soma";
            btn_Soma.Size = new Size(50, 50);
            btn_Soma.TabIndex = 14;
            btn_Soma.Text = "+";
            btn_Soma.UseVisualStyleBackColor = true;
            btn_Soma.Click += btn_Soma_Click;
            // 
            // btn_Virgula
            // 
            btn_Virgula.Location = new Point(14, 358);
            btn_Virgula.Name = "btn_Virgula";
            btn_Virgula.Size = new Size(50, 50);
            btn_Virgula.TabIndex = 15;
            btn_Virgula.Text = ",";
            btn_Virgula.UseVisualStyleBackColor = true;
            btn_Virgula.Click += btn_Virgula_Click;
            // 
            // btn_Equals
            // 
            btn_Equals.Location = new Point(149, 358);
            btn_Equals.Name = "btn_Equals";
            btn_Equals.Size = new Size(50, 50);
            btn_Equals.TabIndex = 16;
            btn_Equals.Text = "=";
            btn_Equals.UseVisualStyleBackColor = true;
            btn_Equals.Click += btn_Equals_Click;
            // 
            // btn_Backspace
            // 
            btn_Backspace.Location = new Point(228, 120);
            btn_Backspace.Name = "btn_Backspace";
            btn_Backspace.Size = new Size(50, 28);
            btn_Backspace.TabIndex = 17;
            btn_Backspace.Text = "⌫";
            btn_Backspace.UseVisualStyleBackColor = true;
            btn_Backspace.Click += btn_Backspace_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(149, 120);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(50, 28);
            btn_Clear.TabIndex = 18;
            btn_Clear.Text = "C";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 415);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Backspace);
            Controls.Add(btn_Equals);
            Controls.Add(btn_Virgula);
            Controls.Add(btn_Soma);
            Controls.Add(btn_Sub);
            Controls.Add(btn_Mult);
            Controls.Add(btn_Div);
            Controls.Add(btn_0);
            Controls.Add(btn_3);
            Controls.Add(btn_2);
            Controls.Add(btn_1);
            Controls.Add(btn_6);
            Controls.Add(btn_5);
            Controls.Add(btn_4);
            Controls.Add(btn_9);
            Controls.Add(btn_8);
            Controls.Add(btn_7);
            Controls.Add(panel1);
            MaximizeBox = false;
            MaximumSize = new Size(306, 454);
            MinimumSize = new Size(306, 454);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_7;
        private Button btn_8;
        private Button btn_9;
        private Button btn_4;
        private Button btn_5;
        private Button btn_6;
        private Button btn_1;
        private Button btn_2;
        private Button btn_3;
        private Button btn_0;
        private Button btn_Div;
        private Button btn_Mult;
        private Button btn_Sub;
        private Button btn_Soma;
        private Button btn_Virgula;
        private Button btn_Equals;
        private Button btn_Backspace;
        private TextBox txt_SNumber;
        private TextBox txt_OpBox;
        private Button btn_Clear;
    }
}
