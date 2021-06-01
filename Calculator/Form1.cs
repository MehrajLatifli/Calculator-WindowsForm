using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




      
        private void button_Click(object sender, EventArgs e)
        {
            button18.Enabled = true;
            button17.Enabled = true;
            button16.Enabled = true;
            button15.Enabled = true;
            button14.Enabled = true;
            button13.Enabled = true;
            button10.Enabled = true;

            foreach (Control control in Controls)
            {
                if(control is Button buttoncontrol && textBox1.Text=="." && char.IsNumber(Text[0]))
                {
                    buttoncontrol.Enabled = false;
                }
            }

            //if (textBox1.Text == ".")
            //{
            //    button1.Enabled = false;
            //    button2.Enabled = false;
            //    button3.Enabled = false;
            //    button4.Enabled = false;
            //    button5.Enabled = false;
            //    button6.Enabled = false;
            //    button7.Enabled = false;
            //    button8.Enabled = false;
            //    button9.Enabled = false;
            //    button11.Enabled = false;
            //}


            if (isOperationprocess)
            {
                textBox1.Clear();
            }

            if (sender is Button button)
            {

                if (button.Text == ".")
                {
                    if (!textBox1.Text.Contains("."))
                    {

                        textBox1.Text = textBox1.Text + button.Text;
                    }

                }
                if (button.Text != ".")
                {
                    textBox1.Text = textBox1.Text + button.Text;
                }


                if (textBox1.Text.Length > 10)
                {
                    textBox1.Text = "Imposible";
                }

          
                isOperationprocess = false;

            }
        }

        Decimal result = 0.0M;
        string operation = "";
        bool isOperationprocess = false;
       
        private void operator_click(object sender, EventArgs e)
        {

            if (sender is Button button)
            {
           
                isOperationprocess = true;



                switch (operation)
                {
                    case "-":

                        textBox1.Text = (result - Decimal.Parse(textBox1.Text)).ToString();

                        break;
                    case "÷":
                        textBox1.Text = (result / Decimal.Parse(textBox1.Text)).ToString();

                        break;
                    case "✕":
                        textBox1.Text = (result * Decimal.Parse(textBox1.Text)).ToString();

                        break;
                    case "+":
                        textBox1.Text = (result + Decimal.Parse(textBox1.Text)).ToString();

                        break;
                    case "%":

                        result = (Convert.ToDecimal(textBox1.Text) / Convert.ToDecimal(100));
                        textBox1.Text = result.ToString();

                        break;

                    default:
                        break;

                }

    
                    operation = button.Text;

                    result = Decimal.Parse(textBox1.Text);
                

              



            }


        }

        private void clear_Click(object sender, EventArgs e)
        {
            button18.Enabled = false;
            button17.Enabled = false;
            button16.Enabled = false;
            button15.Enabled = false;
            button14.Enabled = false;
            button13.Enabled = false;
            button10.Enabled = false;

            textBox1.Text = "";
            result = 0;
            textBox1.Text.Trim();
          
        }

  



        private void backspace_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length>0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
           
            }


         

            if (textBox1.Text.Length <= 0)
            {
                button18.Enabled = false;
                button17.Enabled = false;
                button16.Enabled = false;
                button15.Enabled = false;
                button14.Enabled = false;
                button13.Enabled = false;
                button10.Enabled = false;
            }

        }

        int counterForCreateToogleButton = 0;
        private void changecolour_Click(object sender, EventArgs e)
        {


            counterForCreateToogleButton++;
        


                if (counterForCreateToogleButton % 2==0)
                {

                    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(216)))), ((int)(((byte)(39)))));
                    button20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(216)))), ((int)(((byte)(39)))));
                    button19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(216)))), ((int)(((byte)(39)))));
                    button12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(216)))), ((int)(((byte)(39)))));
                    button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(216)))), ((int)(((byte)(39)))));
                    button16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(216)))), ((int)(((byte)(39)))));
                    button15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(216)))), ((int)(((byte)(39)))));
                    button14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(216)))), ((int)(((byte)(39)))));
                    button13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(216)))), ((int)(((byte)(39)))));
                    button17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(216)))), ((int)(((byte)(39)))));
                    button18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(216)))), ((int)(((byte)(39)))));
                    button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(216)))), ((int)(((byte)(39)))));
                    button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(216)))), ((int)(((byte)(39)))));
                    button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(216)))), ((int)(((byte)(39)))));
                    button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(216)))), ((int)(((byte)(39)))));
                    button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(216)))), ((int)(((byte)(39)))));
                    button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(216)))), ((int)(((byte)(39)))));
                    button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(216)))), ((int)(((byte)(39)))));
                    button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(216)))), ((int)(((byte)(39)))));
                    button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(216)))), ((int)(((byte)(39)))));
                    button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(216)))), ((int)(((byte)(39)))));

                }

                if (counterForCreateToogleButton % 2 != 0)
                {

                    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
                    button20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
                    button19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
                    button12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
                    button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
                    button16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
                    button15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
                    button14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
                    button13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
                    button17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
                    button18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
                    button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
                    button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
                    button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
                    button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
                    button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
                    button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
                    button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
                    button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
                    button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
                    button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));

                }
            

        }
    }
}
