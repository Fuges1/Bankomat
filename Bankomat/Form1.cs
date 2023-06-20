using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Bankomat
{
    public partial class Form1 : Form
    {
        private int balance = 1000; // начальный баланс

        public Form1()
        {
            InitializeComponent();
        }


        private void buttonDeposit_Click_1(object sender, EventArgs e)
        {
            button4.Visible = true;
            textBoxAmount.Visible = true;
            label2.Visible = true;
            button1.Visible = false;
            buttonDeposit.Visible = false;
            button2.Visible = false;
            labelBalance.Visible = false;
            label1.Visible = true;
            label3.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ваш баланс: " + balance + " руб."); // выводим информацию о балансе
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            buttonDeposit.Visible = false;
            label2.Visible = true;
            button3.Visible = true;
            button2.Visible = false;
            textBoxAmount.Visible = true;
            labelBalance.Visible = false;
            label1.Visible = true;
            label3.Visible = true;

        }
        private void panel1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.bankomaе_blize;
            panel1.Visible = false;
            panel2.Visible = true;

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.BackColor = Color.Black;
            panel2.Visible = false;
            buttonDeposit.Visible = true;
            button1.Visible = true;
            button2.Visible = true;

            labelBalance.Visible = true;
           
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textBoxAmount.Text == "")
            {
                MessageBox.Show("Введите сумму", "Ошибка");
            }
            else
            {
                int chisl = Convert.ToInt32(textBoxAmount.Text);
                if (textBoxAmount.Text == "0" || chisl < 0)
                {
                    MessageBox.Show("Извините, но нельзя снять 0 руб или отрицательную сумму", "Ошибка");

                }
                else
                {
                    int amount = Convert.ToInt32(textBoxAmount.Text);
                    if (amount <= balance) // проверяем, достаточно ли средств на счете
                    {

                        balance -= amount; // списываем сумму со счета

                        MessageBox.Show("Вы успешно сняли " + amount + " руб."); // выводим сообщение об успешной операции
                        button5.Visible = true;
                        
                    }
                    else
                    {
                        MessageBox.Show("На вашем счете недостаточно средств."); // выводим сообщение об ошибке
                        button5.Visible = true;
                    }

                }
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (textBoxAmount.Text == "")
            {
                MessageBox.Show("Введите сумму", "Ошибка");
            }
            else
            {
                int chisl = Convert.ToInt32(textBoxAmount.Text);
                if (textBoxAmount.Text == "0" || chisl < 0)
                {
                    MessageBox.Show("Извините, но нельзя внести 0 руб или отрицательную сумму", "Ошибка");
                }
                else
                {
                    int amount = Convert.ToInt32(textBoxAmount.Text);
                    balance += amount; // добавляем сумму на счет

                    MessageBox.Show("Вы успешно внесли " + amount + " руб."); // выводим сообщение об успешной операции
                    button5.Visible = true;
                  
                }
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            textBoxAmount.Visible = false;
            label2.Visible = false;
            buttonDeposit.Visible = true;
            button1.Visible = true;
            button2.Visible = true;

            labelBalance.Visible = true;
            button5.Visible = false;
            button3.Visible = false;
            labelBalance.Visible = true;
            label1.Visible = false;
            label3.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}