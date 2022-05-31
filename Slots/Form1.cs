namespace Slots
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int testo = 1;
        int slot1;
        int slot2;
        int slot3;
        private void timer1_Tick(object sender, EventArgs e)
        {

            
            if (testo == -1)
            {
               

                Bitmap b2 = new Bitmap(@"C:\Users\picac\source\repos\Slots\Slots\Properties\leverD.png");
                button_lever.Image = b2;
                testo = 1;
            }
            else
            {
                Bitmap b2 = new Bitmap(@"C:\Users\picac\source\repos\Slots\Slots\Properties\leverU.png");
                button_lever.Image = b2;
            }
            

        }

        private void button_lever_Click(object sender, EventArgs e)
        {
            testo= -1;

           timer2.Enabled = true;
            timer3.Enabled = true;
            label2.Visible = false;

           
        }
               
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            slot1 = rnd.Next(1, 5);
            slot2 = rnd.Next(1, 5);
            slot3 = rnd.Next(1, 5);

            Bitmap w = new Bitmap(@"C:\Users\picac\source\repos\Slots\Slots\Properties\Watermelon.png");
            Bitmap b = new Bitmap(@"C:\Users\picac\source\repos\Slots\Slots\Properties\Banana.png");
            Bitmap o = new Bitmap(@"C:\Users\picac\source\repos\Slots\Slots\Properties\Orange.png");
            Bitmap l = new Bitmap(@"C:\Users\picac\source\repos\Slots\Slots\Properties\Lemon.png");
            Bitmap c = new Bitmap(@"C:\Users\picac\source\repos\Slots\Slots\Properties\Cherry.png");

            if (slot1 == 1)
            {
                pictureBox2.Image = b;
            }
            if (slot1 == 2)
            {
                pictureBox2.Image = w;
            }
            if (slot1 == 3)
            {
                pictureBox2.Image = o;
            }
            if (slot1 == 4)
            {
                pictureBox2.Image = l;
            }
            if (slot1 == 5)
            {
                pictureBox2.Image = c;
            }
            if (slot2 == 1)
            {
                pictureBox3.Image = b;
            }
            if (slot2 == 2)
            {
                pictureBox3.Image = w;
            }
            if (slot2 == 3)
            {
                pictureBox3.Image = o;
            }
            if (slot2 == 4)
            {
                pictureBox3.Image = l;
            }
            if (slot2 == 5)
            {
                pictureBox3.Image = c;
            }
            if (slot3 == 1)
            {
                pictureBox4.Image = b;
            }
            if (slot3 == 2)
            {
                pictureBox4.Image = w;
            }
            if (slot3 == 3)
            {
                pictureBox4.Image = o;
            }
            if (slot3 == 4)
            {
                pictureBox4.Image = l;
            }
            if (slot3 == 5)
            {
                pictureBox4.Image = c;
            }

            

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            timer3.Enabled = false;
            if (slot1==1 && slot2 ==1 && slot3==1)
            {
                label2.Visible = true;
            }
            if (slot1 == 2 && slot2 == 2 && slot3 == 2)
            {
                label2.Visible = true;
            }
            if (slot1 == 3 && slot2 == 3 && slot3 == 3)
            {
                label2.Visible = true;
            }
            if (slot1 == 4 && slot2 == 4 && slot3 == 4)
            {
                label2.Visible = true;
            }
            if (slot1 == 5 && slot2 == 5 && slot3 == 5)
            {
                label2.Visible = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}