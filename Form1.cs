namespace Rock_paper_scissors
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int computerTurn = random.Next(1,4);
            int playerTurn = random.Next(1,4);

            switch(computerTurn)
            {
                case 1:
                    pictureBox1.ImageLocation = @"C:\Users\brand\OneDrive\Documents\Visual Programming class\Class pojects\week 10\rock.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox1.ImageLocation = @"C:\Users\brand\OneDrive\Documents\Visual Programming class\Class pojects\week 10\paper.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox1.ImageLocation = @"C:\Users\brand\OneDrive\Documents\Visual Programming class\Class pojects\week 10\scissros.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pictureBox1.ImageLocation = @"C:\Users\brand\OneDrive\Documents\Visual Programming class\Class pojects\week 10\rock.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
            switch (playerTurn)
            {
                case 1:
                    pictureBox2.ImageLocation = @"C:\Users\brand\OneDrive\Documents\Visual Programming class\Class pojects\week 10\rock.jpg";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox2.ImageLocation = @"C:\Users\brand\OneDrive\Documents\Visual Programming class\Class pojects\week 10\paper.jpg";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox2.ImageLocation = @"C:\Users\brand\OneDrive\Documents\Visual Programming class\Class pojects\week 10\scissros.jpg";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pictureBox2.ImageLocation = @"C:\Users\brand\OneDrive\Documents\Visual Programming class\Class pojects\week 10\rock.jpg";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
        }
    }
}