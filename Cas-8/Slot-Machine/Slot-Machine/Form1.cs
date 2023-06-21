using System.Reflection.Metadata.Ecma335;

namespace Slot_Machine
{
    public partial class SlotMachine : Form
    {
        public int Counter { get; set; } = 30;
        public int DisplayOne { get; set; }
        public int DisplayTwo { get; set; }
        public int DisplayThree { get; set; }

        public SlotMachine()
        {
            InitializeComponent();

            label1.Text = "Пробајте си ја среќата!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //flip na racka 1 nacin
            //button1.Location = new Point(619, 253);

            //var slika = new Bitmap(button1.BackgroundImage, new Size(button1.BackgroundImage.Width, button1.BackgroundImage.Height));

            //slika.RotateFlip(RotateFlipType.Rotate180FlipX);

            //button1.BackgroundImage = slika;

            button1.Visible = false;
            button2.Visible = true;
            button2.Enabled = false;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Counter--;
            label1.Text = "......";
            var random = new Random();

            if(Counter > 0)
            {
                DisplayOne = random.Next(1, 4);
                DisplayTwo = random.Next(1, 4);
                DisplayThree = random.Next(1, 4);

                switch (DisplayOne)
                {
                    case 1:
                        pictureBox1.Image = Image.FromFile(@"..\..\..\..\..\images\2_apple.jpg");
                        break;
                    case 2:
                        pictureBox1.Image = Image.FromFile(@"..\..\..\..\..\images\3_cherry.png");
                        break;
                    case 3:
                        pictureBox1.Image = Image.FromFile(@"..\..\..\..\..\images\4_grapes.jpg");
                        break;
                }

                switch (DisplayTwo)
                {
                    case 1:
                        pictureBox2.Image = Image.FromFile(@"..\..\..\..\..\images\2_apple.jpg");
                        break;
                    case 2:
                        pictureBox2.Image = Image.FromFile(@"..\..\..\..\..\images\3_cherry.png");
                        break;
                    case 3:
                        pictureBox2.Image = Image.FromFile(@"..\..\..\..\..\images\4_grapes.jpg");
                        break;
                }

                switch (DisplayThree)
                {
                    case 1:
                        pictureBox3.Image = Image.FromFile(@"..\..\..\..\..\images\2_apple.jpg");
                        break;
                    case 2:
                        pictureBox3.Image = Image.FromFile(@"..\..\..\..\..\images\3_cherry.png");
                        break;
                    case 3:
                        pictureBox3.Image = Image.FromFile(@"..\..\..\..\..\images\4_grapes.jpg");
                        break;
                }
            }
            else
            {
                timer1.Stop();
                button1.Visible = true;
                button2.Visible = false;
                Counter = 30;

                if (DisplayOne == DisplayTwo && DisplayOne == DisplayThree)
                {
                    label1.Text = "JackPot! Освоивте 1.000.000 денари!";
                    pictureBox4.Image = Image.FromFile(@"..\..\..\..\..\images\coins.png");
                }
                else
                {
                    label1.Text = "Немавте среќа, обидете се повторно!";
                }
            }
        }
    }
}