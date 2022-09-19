namespace TRPO_2varik
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.change_button = new System.Windows.Forms.Button();
            this.product_button = new System.Windows.Forms.Button();
            this.next_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.screen = new System.Windows.Forms.Label();
            this.Making_Timer_tick = new System.Windows.Forms.Timer(this.components);
            this.Timer_tick = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Объем воды";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "5 литров 20р";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.five_litre_button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "10 литров 40р";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ten_litre_button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(33, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "15 литров 60р";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.fifteen_litre_button_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(33, 255);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "20 литров 80р";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.twenty_litre_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Наличные";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(160, 167);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(39, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "50р";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.money50_button_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(206, 166);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(44, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "100р";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.money100_button_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(160, 197);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(39, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "10р";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.money10_button_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(206, 197);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(33, 23);
            this.button8.TabIndex = 9;
            this.button8.Text = "5р";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.money5_button_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(246, 197);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(31, 23);
            this.button9.TabIndex = 10;
            this.button9.Text = "2р";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.money2_button_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(283, 197);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(32, 23);
            this.button10.TabIndex = 11;
            this.button10.Text = "1р";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.money1_button_Click);
            // 
            // change_button
            // 
            this.change_button.Location = new System.Drawing.Point(160, 238);
            this.change_button.Name = "change_button";
            this.change_button.Size = new System.Drawing.Size(99, 23);
            this.change_button.TabIndex = 12;
            this.change_button.Text = "взять сдачу";
            this.change_button.UseVisualStyleBackColor = true;
            this.change_button.Click += new System.EventHandler(this.change_button_Click);
            // 
            // product_button
            // 
            this.product_button.Location = new System.Drawing.Point(160, 268);
            this.product_button.Name = "product_button";
            this.product_button.Size = new System.Drawing.Size(99, 23);
            this.product_button.TabIndex = 13;
            this.product_button.Text = "взять воду";
            this.product_button.UseVisualStyleBackColor = true;
            this.product_button.Click += new System.EventHandler(this.product_button_Click);
            // 
            // next_button
            // 
            this.next_button.Location = new System.Drawing.Point(198, 65);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(74, 23);
            this.next_button.TabIndex = 14;
            this.next_button.Text = "далее";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(198, 94);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(74, 23);
            this.cancel_button.TabIndex = 15;
            this.cancel_button.Text = "отмена";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.AliceBlue;
            this.screen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.screen.Font = new System.Drawing.Font("Arial", 10F);
            this.screen.Location = new System.Drawing.Point(12, 39);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(161, 75);
            this.screen.TabIndex = 16;
            this.screen.Text = "screen";
            this.screen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Making_Timer_tick
            // 
            this.Making_Timer_tick.Tick += new System.EventHandler(this.Making_Timer_Tick);
            // 
            // Timer_tick
            // 
            this.Timer_tick.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lime;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(303, 58);
            this.label4.MinimumSize = new System.Drawing.Size(50, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 31);
            this.label4.TabIndex = 20;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Оставшаяся вода";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(278, 317);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 22;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.product_button);
            this.Controls.Add(this.change_button);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button change_button;
        private System.Windows.Forms.Button product_button;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label screen;
        private System.Windows.Forms.Timer Making_Timer_tick;
        private System.Windows.Forms.Timer Timer_tick;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button11;
    }
}

