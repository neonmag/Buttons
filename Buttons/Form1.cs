using System.Drawing.Text;
using System;
using System.Windows.Forms;
namespace Buttons
{
    public partial class Form1 : Form
    {
        int M;
        int N;
        int widthBetween;
        int widthAndHeight;
        int posInY = 0;
        int posInX = 0;
        int counter = 1;
        Random randomColor = new Random();
        private void ButtonAction(object Sender, EventArgs e)
        {
            Button button = (Button)Sender;
            button.Visible = false;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            M = Convert.ToInt32(textBox1.Text);
            N = Convert.ToInt32(textBox2.Text);
            widthBetween = Convert.ToInt32(textBox4.Text);
            widthAndHeight = Convert.ToInt32(textBox3.Text);
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            button1.Visible = false;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Button button = new Button();
                    button.Text = Convert.ToString(counter);
                    button.Size = new Size(widthAndHeight, widthAndHeight);
                    button.Location = new Point(posInX, posInY);
                    button.BackColor = Color.FromArgb(randomColor.Next(0, 255), randomColor.Next(0, 255), randomColor.Next(0, 255));
                    this.Controls.Add(button);
                    counter++;
                    button.Click += new EventHandler(ButtonAction);

                    posInX = posInX + widthAndHeight + widthBetween;
                }
                posInX = 0;
                posInY += widthBetween;
            }
        }
    }
}