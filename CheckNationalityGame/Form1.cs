using CheckNationalityGame.Repositories;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CheckNationalityGame
{
    public partial class CheckNationalityGame : Form
    {
        Services _services;
        private Point locMouseClicked;
        private Point startLocRandomPic;
        private int MouseClickedCount = 0;
        private bool MouseClicked = false;
        private int MouseNotClickedCount = 0;
        private int PictureGenerationCount = 0;
        private bool CurrectSelected = false;


        public CheckNationalityGame()
        {
            InitializeComponent();
            _services = new Services(JapanesePicBox.Location, ChinesePicBox.Location, KoreanPicBox.Location, ThaiPicBox.Location);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Providers _providers = new Providers();
            RandomPic.ImageLocation = _providers.GenerateRandomPic();
            startLocRandomPic = RandomPic.Location;
            RandomPic.Visible = true;
            RandomPic.AllowDrop = true;
            PictureGenerationCount++;
            RepeatTimer.Start();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            CheckNationalityGame GeneratedNewForm = new CheckNationalityGame();
            GeneratedNewForm.Show();
            this.Dispose(false);
        }

        private void RandomPic_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                RandomPic.Left = e.X + RandomPic.Left - locMouseClicked.X;
                RandomPic.Top = e.Y + RandomPic.Top - locMouseClicked.Y;
            }
        }

        private void RandomPic_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseClicked = true;
                locMouseClicked = e.Location;
            }
        }

        private void RepeatTimer_Tick(object sender, EventArgs e)
        {

            if (PictureGenerationCount > 10)
            {
                ResetValues();
                RepeatTimer.Stop();
                return;
            }

            if (MouseClicked == true)
            {
                switch (_services.GetCorrectDirection(RandomPic.Location))
                {
                    case "LocChinese":
                        CurrectSelected = _services.CorrectSelected(RandomPic.ImageLocation, "Chinese");
                        RandomPic.Location = new Point((RandomPic.Location.X - 10), (RandomPic.Location.Y - 10));
                        break;
                    case "LocJapanese":
                        CurrectSelected = _services.CorrectSelected(RandomPic.ImageLocation, "Japanese");
                        RandomPic.Location = new Point((RandomPic.Location.X + 10), (RandomPic.Location.Y - 10));
                        break;
                    case "LocKorean":
                        CurrectSelected = _services.CorrectSelected(RandomPic.ImageLocation, "Korean");
                        RandomPic.Location = new Point((RandomPic.Location.X - 10), (RandomPic.Location.Y + 10));
                        break;
                    case "LocThai":
                        CurrectSelected = _services.CorrectSelected(RandomPic.ImageLocation, "Thai");
                        RandomPic.Location = new Point((RandomPic.Location.X + 10), (RandomPic.Location.Y + 10));
                        break;
                }

                if (MouseClickedCount == 15)
                {
                    RepeatTimer.Stop();
                    Providers _providers = new Providers();
                    RandomPic.ImageLocation = _providers.GenerateRandomPic();
                    RandomPic.Location = startLocRandomPic;
                    lblRating.Text = _services.CalculateRating(Int32.Parse(lblRating.Text), CurrectSelected);
                    MouseClickedCount = 0;
                    MouseClicked = false;
                    PictureGenerationCount++;
                    RepeatTimer.Start();
                }
                MouseClickedCount++;
            }
            else
            {
                RandomPic.Location = new Point(RandomPic.Location.X, RandomPic.Location.Y + 10);
                if (MouseNotClickedCount == 35)
                {
                    Providers _providers = new Providers();
                    RandomPic.ImageLocation = _providers.GenerateRandomPic();
                    RandomPic.Location = startLocRandomPic;
                    MouseNotClickedCount = 0;
                }
                MouseNotClickedCount++;
            }
        }
        private void ResetValues()
        {
            PictureGenerationCount = 0;
            MouseClickedCount = 0;
            MouseNotClickedCount = 0;
            RandomPic.Visible = false;
        }
    }
}
