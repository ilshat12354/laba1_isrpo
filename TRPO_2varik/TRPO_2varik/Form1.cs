using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace TRPO_2varik
{
    public partial class Form1 : Form
    {
        int i;
        int sum = 0;
        double water = 25;
        int conditition = 0;
        Timer timer = new Timer();
        Timer making_timer = new Timer();
        Product[] products = new Product[4];

        private class Product
        {
            int quantity;
            int cost;

            public Product()
            {
                this.quantity = 0;
                this.cost = 0;
            }

            public Product(int quantity, int cost)
            {
                this.quantity = quantity;
                this.cost = cost;
            }

            public int Get_Quantity()
            {
                return this.quantity;
            }

            public int Get_Cost()
            {
                return this.cost;
            }

            public void Set_Quantity(int quantity)
            {
                this.quantity = quantity;
            }
        }
        public Form1()
        {
            InitializeComponent();

            timer.Interval = 10000;
            timer.Tick += Timer_Tick;

            making_timer.Interval = 5000;
            making_timer.Tick += Making_Timer_Tick;

            Products_Initialize(products);
            Begin_Condition();
            label4.Text = water.ToString() + "л";
        }
        private void Making_Timer_Tick(object sender, EventArgs e)
        {
            screen.Text = "Возьмите воду";
            conditition = 5;
            product_button.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (sum != 0)
            {
                screen.Text = "Заберите деньги: " + sum + "p";
                sum = 0;
            }
            else
                Begin_Condition();
        }

        private void Begin_Condition()
        {
            cancel_button.Enabled = true;
            change_button.Enabled = false;
            product_button.Enabled = false;
            next_button.Enabled = true;
            timer.Stop();
            sum = 0;
            i = 0;
            conditition = 0;

            if (Water_Check())
            {
                screen.Text = "Выберите объем воды";
                conditition = 1;
            }
            else if (!Water_Check())
            {
                screen.Text = "Нет воды!\n\nИзвините!";
            }
        }

        private void five_lirte_change()
        {
            water -= 5;
        }

        private void ten_lirte_change()
        {
            water -= 10;
        }

        private void fifteen_lirte_change()
        {
            water -= 15;
        }

        private void twenty_lirte_change()
        {
            water -= 20;
        }

        private void Making()
        {
            screen.Text = "Вода наливается...";

            product_button.Enabled = false;
            cancel_button.Enabled = false;
            change_button.Enabled = false;
            next_button.Enabled = false;
        }

        private void Chek()
        {
            string s = "Чек\n" + products[i].Get_Quantity() + " литров: " + products[i].Get_Cost() + "р\nНаличные: " + sum + "р\nСдача: " + Change_computation() + "р";
            byte[] sb = Encoding.Default.GetBytes(s);
            FileStream file = new FileStream("chek.txt", FileMode.OpenOrCreate);
            file.Write(sb, 0, sb.Length);
            file.Close();
        }

        private void Products_Initialize(Product[] products)
        {
            products[0] = new Product(5, 20);
            products[1] = new Product(10, 40);
            products[2] = new Product(15, 60);
            products[3] = new Product(20, 80);
        }

        private bool Water_Check()
        {
            if (water < 10 || (water - products[i].Get_Quantity()) < 0)
            {
                screen.Text = "Нет хватает воды!\n\nИзвините!";
                return false;
            }
            else
                return true;
        }

        private int Change_computation()
        {
            return sum - products[i].Get_Cost();
        }

        private void five_litre_button_Click(object sender, EventArgs e)
        {
            if (conditition == 1 || conditition == 2)
            {
                screen.Text = products[0].Get_Quantity() + " литров: " + products[0].Get_Cost() + "p\n\nНажмите далее";
                i = 0;
                conditition = 2;
            }
            timer.Start();
        }

        private void ten_litre_button_Click(object sender, EventArgs e)
        {
            if (conditition == 1 || conditition == 2)
            {
                screen.Text = products[1].Get_Quantity() + " литров: " + products[1].Get_Cost() + "p\n\nНажмите далее";
                i = 1;
                conditition = 2;
            }
            timer.Start();
        }

        private void fifteen_litre_button_Click(object sender, EventArgs e)
        {
            if (conditition == 1 || conditition == 2)
            {
                screen.Text = products[2].Get_Quantity() + " литров: " + products[2].Get_Cost() + "p\n\nНажмите далее";
                i = 2;
                conditition = 2;
            }
            timer.Start();
        }

        private void twenty_litre_button_Click(object sender, EventArgs e)
        {
            if (conditition == 1 || conditition == 2)
            {
                screen.Text = products[3].Get_Quantity() + " литров: " + products[3].Get_Cost() + "p\n\nНажмите далее";
                i = 3;
                conditition = 2;
            }
            timer.Start();
        }

        private void money100_button_Click(object sender, EventArgs e)
        {
            timer.Stop();
            if (conditition == 3)
            {
                change_button.Enabled = true;
                sum += 100;
                conditition = 3;
                screen.Text = "Баланс: " + sum + "p\n\nНажмите Далее";
            }
            timer.Start();
        }

        private void money50_button_Click(object sender, EventArgs e)
        {
            timer.Stop();
            if (conditition == 3)
            {
                change_button.Enabled = true;
                sum += 50;
                conditition = 3;
                screen.Text = "Баланс: " + sum + "p\n\nНажмите Далее";
            }
            timer.Start();
        }

        private void money10_button_Click(object sender, EventArgs e)
        {
            timer.Stop();
            if (conditition == 3)
            {
                change_button.Enabled = true;
                sum += 10;
                conditition = 3;
                screen.Text = "Баланс: " + sum + "p\n\nНажмите Далее";
            }
            timer.Start();
        }

        private void money5_button_Click(object sender, EventArgs e)
        {
            timer.Stop();
            if (conditition == 3)
            {
                change_button.Enabled = true;
                sum += 5;
                conditition = 3;
                screen.Text = "Баланс: " + sum + "p\n\nНажмите Далее";
            }
            timer.Start();
        }

        private void money2_button_Click(object sender, EventArgs e)
        {
            timer.Stop();
            if (conditition == 3)
            {
                change_button.Enabled = true;
                sum += 2;
                conditition = 3;
                screen.Text = "Баланс: " + sum + "p\n\nНажмите Далее";
            }
            timer.Start();
        }

        private void money1_button_Click(object sender, EventArgs e)
        {
            timer.Stop();
            if (conditition == 3)
            {
                change_button.Enabled = true;
                sum += 1;
                conditition = 3;
                screen.Text = "Баланс: " + sum + "p\n\nНажмите Далее";
            }
            timer.Start();
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            timer.Stop();
            if (conditition == 2 && products[i].Get_Quantity() > 0)
            {
                if (Water_Check())
                {
                    screen.Text = "Внесите наличные";
                    conditition = 3;
                }
            }
            else if (conditition == 3 && products[i].Get_Cost() <= sum)
            {
                if (Change_computation() != 0)
                {
                    screen.Text = "Сдача: " + Change_computation() + "p\n\nВозьмите сдачу";
                    conditition = 4;
                }
                else
                {
                    conditition = 4;
                    next_button_Click(sender, e);
                }
            }
            else if (conditition == 4 && products[i].Get_Quantity() == 5)
            {
                if (Water_Check())
                {
                    Making();
                    five_lirte_change();
                    Chek();
                    making_timer.Start();
                }
            }
            else if (conditition == 4 && products[i].Get_Quantity() == 10)
            {
                if (Water_Check())
                {
                    Making();
                    ten_lirte_change();
                    Chek();
                    making_timer.Start();
                }
            }
            else if (conditition == 4 && products[i].Get_Quantity() == 15)
            {
                if (Water_Check())
                {
                    Making();
                    fifteen_lirte_change();
                    Chek();
                    making_timer.Start();
                }
            }
            else if (conditition == 4 && products[i].Get_Quantity() == 20)
            {
                if (Water_Check())
                {
                    Making();
                    twenty_lirte_change();
                    Chek();
                    making_timer.Start();
                }
            }
            else if (conditition == 3 && products[i].Get_Cost() > sum)
            {
                screen.Text = products[i].Get_Quantity() + " " + products[i].Get_Cost() + "p\nНедостаточно средств\nБаланс: " + sum + "p";
            }
            label4.Text = water.ToString() + "л";
            timer.Start();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            timer.Stop();
            if (sum != 0)
            {
                screen.Text = "Заберите деньги: " + sum + "p";
                sum = 0;
                timer.Start();
            }
            else
                Begin_Condition();
        }

        private void change_button_Click(object sender, EventArgs e)
        {
            timer.Stop();
            if (conditition == 4)
            {
                next_button_Click(sender, e);
            }
            if (conditition == 3)
            {
                Begin_Condition();
            }
            timer.Start();
        }

        private void product_button_Click(object sender, EventArgs e)
        {
            making_timer.Stop();
            timer.Stop();
            if (conditition == 5)
            {
                screen.Text = "Возьмите чек\n\nСпасибо за покупку!";
                sum = 0;
                i = 0;
                conditition = 0;
            }
            timer.Start();
        }
    }
}