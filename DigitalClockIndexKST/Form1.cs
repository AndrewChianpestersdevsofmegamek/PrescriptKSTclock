using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using NAudio.Wave;
using System.Diagnostics.Eventing.Reader;
using DigitalClockIndexKST.Properties;
namespace DigitalClockIndexKST

{

    public partial class Form1 : Form
    {
        String AlarmDate;
        String WantedDate = DateTime.Now.ToString("M/dd/yyyy");
        String XDayslater;
        DateTime Utc = DateTime.UtcNow;
        bool AlarmActive = false;
        bool PCtime = true;
        bool UTCtime = false;
        bool ESTtime = false;
        bool KSTtime = false;
        bool CSTtime = false;
        bool PTtime = false;
        WaveOutEvent OutputDevice =new WaveOutEvent();
        Image CurrImg = Resource1.BlackBg;
        Image NewImg = null;
        Image WaitingImg = null;
        int CurtainSpeed = 1;
        bool Background_change = false;
        bool Background_switch = false;
        String DisplayName;
        WaveOutEvent AmbientMusic = new WaveOutEvent();
        string Ambient = null;
        AudioFileReader Reader = null;
        bool StylePress = false;
        float FormWidth = 1324f;
        float FormHeight = 738f;
        bool PrescriptDisplayed = false;
        Random Rnd = new Random();
        bool Background_finished = false;
        bool StopRolling = false;
        int PrescriptAngle = 0;
        float PrescriptScale= 1f;
        int PrescriptFontSize = 30;
        float PrescriptY = 352f;
        float PrescriptX = 100f;
        bool PrescriptExpandL = false;
        int PrescriptIndex = 0;
        int PrescriptOpacity = 0;
        int PrescriptExpandSpeed = 0;
        bool FadeOut;
        bool AlarmFlash = false;
        bool AlarmPlaying = false;
        string[] PrescriptsList = {Properties.Resources.Prescript1, Properties.Resources.Prescript2, Properties.Resources.Prescript3,
        Properties.Resources.Prescript4, Properties.Resources.Prescript5, Properties.Resources.Prescript6, Properties.Resources.Prescript7,
        Properties.Resources.Prescript8, Properties.Resources.Prescript9, Properties.Resources.Prescript10, Properties.Resources.Prescript11,
        Properties.Resources.Prescript12, Properties.Resources.Prescript13, Properties.Resources.Prescript14, Properties.Resources.Prescript15,
        Properties.Resources.Prescript16, Properties.Resources.Prescript17, Properties.Resources.Prescript18,Properties.Resources.Prescript19,
        Properties.Resources.Prescript20};
        Image[] StarsectorSpaceships = {Resource1.Invictus__2_, Resource1.Conquest1, Resource1.Vangaurd, Resource1.Aurora, Resource1.Pegasus,
        Resource1.Dominator, Resource1.Eagle, Resource1.Sunder, Resource1.Manticore, Resource1.Odyssey, Resource1.Medusa, Resource1.Buffalo,
        Resource1.Radiant, Resource1.Retribution, Resource1.Paragon, Resource1.Eradicator, Resource1.FuelBig, Resource1.Fuelsmall,
        Resource1.Legion, Resource1.Executor, Resource1.Omen};
        int PrescriptListIndex;
        int StarsectorShipIndex;
        float ShipX = 100f;
        float ShipY = 700f;
        float ShipVelocity = 0.66f;
        int ShipAngle;
        bool ShipDisplayed = false;
        




        
        //To Do:
        //Button responsivity


        public Form1()
        {
            InitializeComponent();
            AlarmInput.ValidatingType = typeof(System.DateTime);
            AddBtn.FlatAppearance.BorderColor = Color.Gray;
            AddBtn.FlatAppearance.BorderSize = 2;
            RmvBtn.FlatAppearance.BorderColor = Color.Gray;
            RmvBtn.FlatAppearance.BorderSize = 2;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint|ControlStyles.OptimizedDoubleBuffer, true);
             



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            AnimationTimer.Enabled = true;
            CheeseTimer.Enabled = true;
            IndexTimer.Enabled = true;
            FadeOutTimer.Enabled = true;
            SlowAFTimer.Enabled = true;
            StarsectorTimer.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Reader != null)
            {
                LoopAmbient(Reader, AmbientMusic);
            }

            
                
            if (Background_change == true)
            {
                if (CurtainSpeed < this.Width / 2)
                {
                    CurtainSpeed += 50;
                }
                else
                {
                    Background_change = false;
                    Background_finished = true;
                }


            }
            if (Background_switch == true)
            {
                if (CurtainSpeed > 1)
                {
                    CurtainSpeed -= 50;
                }
                else
                {
                    Background_change = true;
                    Background_switch = false;
                    NewImg = WaitingImg;
                }
            }
            
            if (PCtime == true)
            {
                label1.Text = DateTime.Now.ToString("HH:mm:ss");
                label2.Text = DateTime.Now.ToString("M/dd/yyyy");
            }
            if (UTCtime == true)
            {
                label1.Text = DateTime.UtcNow.ToString("HH:mm:ss");
                label2.Text = DateTime.UtcNow.ToString("M/dd/yyyy");
            }
            if (ESTtime == true)
            {
                TimeSpan subtractor = TimeSpan.FromHours(4);
                DateTime Est = DateTime.UtcNow.Subtract(subtractor);
                label1.Text = Est.ToString("HH:mm:ss");
                label2.Text = Est.ToString("M/dd/yyyy");
            }
            if (KSTtime == true)
            {
                TimeSpan summer = TimeSpan.FromHours(9);
                DateTime Kst = DateTime.UtcNow.Add(summer);
                label1.Text = Kst.ToString("HH:mm:ss");
                label2.Text = Kst.ToString("M/dd/yyyy");
            }
            if (CSTtime == true)
            {
                TimeSpan summer = TimeSpan.FromHours(8);
                DateTime Cst = DateTime.UtcNow.Add(summer);
                label1.Text = Cst.ToString("HH:mm:ss");
                label2.Text = Cst.ToString("M/dd/yyyy");
            }
            if (PTtime == true)
            {
                TimeSpan subtractor = TimeSpan.FromHours(7);
                DateTime Pt = DateTime.UtcNow.Subtract(subtractor);
                label1.Text = Pt.ToString("HH:mm:ss");
                label2.Text = Pt.ToString("M/dd/yyyy");
            }


            if (AlarmDate == DateTime.Now.ToString("M/dd/yyyy HH:mm:ss"))
            {
                DaysLater.Text = "0";
                triangularButton2.Enabled = true;
                upsideDownTriangularButton1.Enabled = true;
                AlarmActive = false;
                AlarmPlaying = true;
                AlarmInput.ReadOnly = false;
                AlarmDate = "";
                if (OutputDevice != null && OutputDevice.PlaybackState == PlaybackState.Playing)
                {
                    OutputDevice.Stop();
                }
                if (ListLabel.Text != "")
                {
                    var AudioFile = new AudioFileReader($@"{ListLabel.Text}".Trim().Replace('\"', ' '));
                    OutputDevice.Init(AudioFile);
                    OutputDevice.Play();
                }

                if (ListLabel.Text == "")
                {
                    SystemSounds.Hand.Play();
                
                }
            }
        }

        private void AlarmInput_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (e.IsValidInput)
            {
                AlarmDate = AlarmInput.Text.ToString();


            }
        }

        private void Alarm_Click(object sender, EventArgs e)
        {
            if (AlarmDate == AlarmInput.Text)
            {
                AlarmDate = WantedDate + " " + AlarmInput.Text;
                AlarmInput.ReadOnly = true;
                triangularButton2.Enabled = false;
                upsideDownTriangularButton1.Enabled = false;
                Alarm.Visible = false;
                StopButton.Visible = true;
                AlarmActive = true;

                


            }
            

            
            
        }

        private void triangularButton2_Click(object sender, EventArgs e)
        {
            XDayslater = DaysLater.Text.ToString();
            int DayIncrement = int.Parse(XDayslater) + 1;
            DaysLater.Text = DayIncrement.ToString();
            DateTime CurrDate = DateTime.Parse(DateTime.Now.ToString("M/dd/yyyy"));
            TimeSpan DayAdd = TimeSpan.FromDays(DayIncrement);
            WantedDate = CurrDate.Add(DayAdd).ToString("M/dd/yyyy");



        }

        private void upsideDownTriangularButton1_Click(object sender, EventArgs e)
        {
            XDayslater = DaysLater.Text.ToString();
            if (int.Parse(XDayslater) > 0)
            {
                int DayIncrement = int.Parse(XDayslater) - 1;
                DaysLater.Text = DayIncrement.ToString();
                TimeSpan DayAdd = TimeSpan.FromDays(DayIncrement);
                DateTime CurrDate = DateTime.Parse(DateTime.Now.ToString("M/dd/yyyy"));
                WantedDate = CurrDate.Add(DayAdd).ToString("M/dd/yyyy");
            }
            
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string FilePath = $@"{InputTxt.Text}".Trim(' ', '"');
            string End = Path.GetExtension(FilePath).ToLower();
            MessageBox.Show($"{End}");
            if (File.Exists(FilePath) == true && (End == ".mp4"|| End == ".mp3"||End == ".m4a"||End == ".aac"||End == ".wav" ))
            {
                AlarmSounds.Items.Add(FilePath);
            }
            else
            {
                SystemSounds.Hand.Play();
            }
        }

        private void RmvBtn_Click(object sender, EventArgs e)
        {
            AlarmSounds.Items.Remove(AlarmSounds.SelectedItem);
        }

        private void AlarmSounds_DoubleClick(object sender, EventArgs e)
        {
            ListLabel.Text = AlarmSounds.SelectedItem.ToString();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StopButton.Visible = false;
            Alarm.Visible = true;
            AlarmActive = false;
            AlarmPlaying = false;
            AlarmInput.Clear();

            
            OutputDevice.Stop();
        }

        private void PC_Click(object sender, EventArgs e)
        {
            PCtime = true;
            UTCtime = false;
            ESTtime = false;
            KSTtime = false;
            CSTtime = false;
            PTtime = false;
        }

        private void UTC_Click(object sender, EventArgs e)
        {
            PCtime = false;
            UTCtime = true;
            ESTtime = false;
            KSTtime = false;
            CSTtime = false;
            PTtime = false;
        }

        private void EST_Click(object sender, EventArgs e)
        {
            PCtime = false;
            UTCtime = false;
            ESTtime = true;
            KSTtime = false;
            CSTtime = false;
            PTtime = false;
        }

        private void KST_Click(object sender, EventArgs e)
        {
            PCtime = false;
            UTCtime = false;
            ESTtime = false;
            KSTtime = true;
            CSTtime = false;
            PTtime = false;
        }

        private void CST_Click(object sender, EventArgs e)
        {
            PCtime = false;
            UTCtime = false;
            ESTtime = false;
            KSTtime = false;
            CSTtime = true;
            PTtime = false;
        }

        private void GMT_Click(object sender, EventArgs e)
        {
            PCtime = false;
            UTCtime = false;
            ESTtime = false;
            KSTtime = false;
            CSTtime = false;
            PTtime = true;
        }

        private void Remnant_Click(object sender, EventArgs e)
        {
            StylePress = true;
            if (NewImg == null)
            {
                StylePress = true;
                NewImg = Resource1.Starsector_background;
                DisplayName = "Starsector";
                Background_change = true;
                Background_switch = false;
                Background_finished = false;
                string Snap = Path.Combine(Environment.CurrentDirectory, "Resources", "LibrarySnap.mp3");
                var click = new AudioFileReader($@"{Snap}");
                if (OutputDevice.PlaybackState == PlaybackState.Stopped )
                {
                    OutputDevice.Init(click);
                    OutputDevice.Play();
                    
                }
                else
                {
                    OutputDevice.Stop();
                    OutputDevice.Init(click);
                    OutputDevice.Play();
                }
                

            }
            else if (DisplayName == "Starsector")
            {

            }
            else
            {
                WaitingImg = Resource1.Starsector_background;
                DisplayName = "Starsector";
                Background_switch = true;
                Background_change = false;
                Background_finished = false;
                string Snap = Path.Combine(Environment.CurrentDirectory, "Resources", "LibrarySnap.mp3");
                var click = new AudioFileReader($@"{Snap}");
                if (OutputDevice.PlaybackState == PlaybackState.Stopped)
                {
                    OutputDevice.Init(click);
                    OutputDevice.Play();

                }
                else
                {
                    OutputDevice.Stop();
                    OutputDevice.Init(click);
                    OutputDevice.Play();
                }
            }
            
        }

        private void Ind_Click(object sender, EventArgs e)
        {
            StylePress = true;
            if (NewImg == null)
            {

                NewImg = Resource1.Yanbg;
                DisplayName = "Yan";
                Background_change = true;
                Background_switch = false;
                Background_finished = false;
                string Snap = Path.Combine(Environment.CurrentDirectory, "Resources", "LibrarySnap.mp3");
                var click = new AudioFileReader($@"{Snap}");
                if (OutputDevice.PlaybackState == PlaybackState.Stopped)
                {
                    OutputDevice.Init(click);
                    OutputDevice.Play();

                }
                else
                {
                    OutputDevice.Stop();
                    OutputDevice.Init(click);
                    OutputDevice.Play();
                }
            }
            else if (DisplayName == "Yan")
            {
            }
            else
            {
                WaitingImg = Resource1.Yanbg;
                DisplayName = "Yan";
                Background_switch = true;
                Background_change = false;
                Background_finished = false;
                string Snap = Path.Combine(Environment.CurrentDirectory, "Resources", "LibrarySnap.mp3");
                var click = new AudioFileReader($@"{Snap}");
                if (OutputDevice.PlaybackState == PlaybackState.Stopped)
                {
                    OutputDevice.Init(click);
                    OutputDevice.Play();

                }
                else
                {
                    OutputDevice.Stop();
                    OutputDevice.Init(click);
                    OutputDevice.Play();
                }
            }

        }

        private void Bri_Click(object sender, EventArgs e)
        {
            StylePress = true;
            if (NewImg == null)
            {
                NewImg = Resource1.brigadorbg;
                DisplayName = "Brigador";
                Background_change = true;
                Background_switch = false;
                Background_finished = false;
                string Snap = Path.Combine(Environment.CurrentDirectory, "Resources", "LibrarySnap.mp3");
                var click = new AudioFileReader($@"{Snap}");
                if (OutputDevice.PlaybackState == PlaybackState.Stopped)
                {
                    OutputDevice.Init(click);
                    OutputDevice.Play();

                }
                else
                {
                    OutputDevice.Stop();
                    OutputDevice.Init(click);
                    OutputDevice.Play();
                }

            }
            else if (DisplayName == "Brigador")
            {
            }
            else
            {
                WaitingImg = Resource1.brigadorbg;
                DisplayName = "Brigador";
                Background_switch = true;
                Background_change = false;
                Background_finished = false;
                string Snap = Path.Combine(Environment.CurrentDirectory, "Resources", "LibrarySnap.mp3");
                var click = new AudioFileReader($@"{Snap}");
                if (OutputDevice.PlaybackState == PlaybackState.Stopped)
                {
                    OutputDevice.Init(click);
                    OutputDevice.Play();

                }
                else
                {
                    OutputDevice.Stop();
                    OutputDevice.Init(click);
                    OutputDevice.Play();
                }
            }
        }

        private void Xiao_Click(object sender, EventArgs e)
        {
            StylePress = true;
            if (NewImg == null)
            {
                NewImg = Resource1.Xiaobg;
                DisplayName = "Xiao";
                Background_change = true;
                Background_switch = false;
                Background_finished = false;
                string Snap = Path.Combine(Environment.CurrentDirectory, "Resources", "LibrarySnap.mp3");
                var click = new AudioFileReader($@"{Snap}");
                if (OutputDevice.PlaybackState == PlaybackState.Stopped)
                {
                    OutputDevice.Init(click);
                    OutputDevice.Play();

                }
                else
                {
                    OutputDevice.Stop();
                    OutputDevice.Init(click);
                    OutputDevice.Play();
                }

            }
            else if (DisplayName == "Xiao")
            {
            }
            else
            {
                WaitingImg = Resource1.Xiaobg;
                DisplayName = "Xiao";
                Background_switch = true;
                Background_change = false;
                Background_finished = false;
                string Snap = Path.Combine(Environment.CurrentDirectory, "Resources", "LibrarySnap.mp3");
                var click = new AudioFileReader($@"{Snap}");
                if (OutputDevice.PlaybackState == PlaybackState.Stopped)
                {
                    OutputDevice.Init(click);
                    OutputDevice.Play();

                }
                else
                {
                    OutputDevice.Stop();
                    OutputDevice.Init(click);
                    OutputDevice.Play();
                }
            }
        }

        private void YiSang_Click(object sender, EventArgs e)
        {
            StylePress = true;
            if (NewImg == null)
            {
                NewImg = Resource1.Wingsbg;
                DisplayName = "Wings";
                Background_change = true;
                Background_switch = false;
                Background_finished = false;
                string Snap = Path.Combine(Environment.CurrentDirectory, "Resources", "LibrarySnap.mp3");
                var click = new AudioFileReader($@"{Snap}");
                if (OutputDevice.PlaybackState == PlaybackState.Stopped)
                {
                    OutputDevice.Init(click);
                    OutputDevice.Play();

                }
                else
                {
                    OutputDevice.Stop();
                    OutputDevice.Init(click);
                    OutputDevice.Play();
                }

            }
            else if (DisplayName == "Wings")
            {
            }
            else
            {
                WaitingImg = Resource1.Wingsbg;
                DisplayName = "Wings";
                Background_switch = true;
                Background_change = false;
                Background_finished = false;
                string Snap = Path.Combine(Environment.CurrentDirectory, "Resources", "LibrarySnap.mp3");
                var click = new AudioFileReader($@"{Snap}");
                if (OutputDevice.PlaybackState == PlaybackState.Stopped)
                {
                    OutputDevice.Init(click);
                    OutputDevice.Play();

                }
                else
                {
                    OutputDevice.Stop();
                    OutputDevice.Init(click);
                    OutputDevice.Play();
                }
            }
        }

        private void Ace_Click(object sender, EventArgs e)
        {
            StylePress = true;
            if (NewImg == null)
            {
                NewImg = Resource1.Alicornbg;
                DisplayName = "1mil";
                Background_change = true;
                Background_switch = false;
                Background_finished = false;
                string Snap = Path.Combine(Environment.CurrentDirectory, "Resources", "LibrarySnap.mp3");
                var click = new AudioFileReader($@"{Snap}");
                if (OutputDevice.PlaybackState == PlaybackState.Stopped)
                {
                    OutputDevice.Init(click);
                    OutputDevice.Play();

                }
                else
                {
                    OutputDevice.Stop();
                    OutputDevice.Init(click);
                    OutputDevice.Play();
                }

            }
            else if (DisplayName == "1mil")
            {
            }
            else
            {
                WaitingImg = Resource1.Alicornbg;
                DisplayName = "1mil";
                Background_switch = true;
                Background_change = false;
                Background_finished = false;
                string Snap = Path.Combine(Environment.CurrentDirectory, "Resources", "LibrarySnap.mp3");
                var click = new AudioFileReader($@"{Snap}");
                if (OutputDevice.PlaybackState == PlaybackState.Stopped)
                {
                    OutputDevice.Init(click);
                    OutputDevice.Play();

                }
                else
                {
                    OutputDevice.Stop();
                    OutputDevice.Init(click);
                    OutputDevice.Play();
                }
            }
        }

        private void Turanic_Click(object sender, EventArgs e)
        {
            StylePress = true;
            if (NewImg == null)
            {
                NewImg = Resource1.Kadeshbg;
                DisplayName = "Garden";
                Background_change = true;
                Background_switch = false;
                Background_finished = false;
                string Snap = Path.Combine(Environment.CurrentDirectory, "Resources", "LibrarySnap.mp3");
                var click = new AudioFileReader($@"{Snap}");
                if (OutputDevice.PlaybackState == PlaybackState.Stopped)
                {
                    OutputDevice.Init(click);
                    OutputDevice.Play();

                }
                else
                {
                    OutputDevice.Stop();
                    OutputDevice.Init(click);
                    OutputDevice.Play();
                }

            }
            else if (DisplayName == "Garden")
            {
            }
            else
            {
                WaitingImg = Resource1.Kadeshbg;
                DisplayName = "Garden";
                Background_switch = true;
                Background_change = false;
                Background_finished = false;
                string Snap = Path.Combine(Environment.CurrentDirectory, "Resources", "LibrarySnap.mp3");
                var click = new AudioFileReader($@"{Snap}");
                if (OutputDevice.PlaybackState == PlaybackState.Stopped)
                {
                    OutputDevice.Init(click);
                    OutputDevice.Play();

                }
                else
                {
                    OutputDevice.Stop();
                    OutputDevice.Init(click);
                    OutputDevice.Play();
                }
            }
        }

        private void GWF_Click(object sender, EventArgs e)
        {
            StylePress = true;
            if (NewImg == null)
            {
                NewImg = Resource1.Faust;
                DisplayName = "Faust";
                Background_change = true;
                Background_switch = false;
                Background_finished = false;
                string Snap = Path.Combine(Environment.CurrentDirectory, "Resources", "LibrarySnap.mp3");
                var click = new AudioFileReader($@"{Snap}");
                if (OutputDevice.PlaybackState == PlaybackState.Stopped)
                {
                    OutputDevice.Init(click);
                    OutputDevice.Play();

                }
                else
                {
                    OutputDevice.Stop();
                    OutputDevice.Init(click);
                    OutputDevice.Play();
                }

            }
            else if (DisplayName == "Faust")
            {
            }
            else
            {
                WaitingImg = Resource1.Faust;
                DisplayName = "Faust";
                Background_switch = true;
                Background_change = false;
                Background_finished = false;
                string Snap = Path.Combine(Environment.CurrentDirectory, "Resources", "LibrarySnap.mp3");
                var click = new AudioFileReader($@"{Snap}");
                if (OutputDevice.PlaybackState == PlaybackState.Stopped)
                {
                    OutputDevice.Init(click);
                    OutputDevice.Play();

                }
                else
                {
                    OutputDevice.Stop();
                    OutputDevice.Init(click);
                    OutputDevice.Play();
                }
            }
        }

        private void Dok_Click(object sender, EventArgs e)
        {
            StylePress = true;
            if (NewImg == null)
            {
                NewImg = Resource1.Gaalsien;
                DisplayName = "Sandskimmer";
                Background_change = true;
                Background_switch = false;
                Background_finished = false;
                string Snap = Path.Combine(Environment.CurrentDirectory, "Resources", "LibrarySnap.mp3");
                var click = new AudioFileReader($@"{Snap}");
                if (OutputDevice.PlaybackState == PlaybackState.Stopped)
                {
                    OutputDevice.Init(click);
                    OutputDevice.Play();

                }
                else
                {
                    OutputDevice.Stop();
                    OutputDevice.Init(click);
                    OutputDevice.Play();
                }

            }
            else if (DisplayName == "Sandskimmer")
            {
            }
            else
            {
                WaitingImg = Resource1.Gaalsien;
                DisplayName = "Sandskimmer";
                Background_switch = true;
                Background_change = false;
                Background_finished = false;
                string Snap = Path.Combine(Environment.CurrentDirectory, "Resources", "LibrarySnap.mp3");
                var click = new AudioFileReader($@"{Snap}");
                if (OutputDevice.PlaybackState == PlaybackState.Stopped)
                {
                    OutputDevice.Init(click);
                    OutputDevice.Play();

                }
                else
                {
                    OutputDevice.Stop();
                    OutputDevice.Init(click);
                    OutputDevice.Play();
                }
            }
        }

        private void XCOM_Click(object sender, EventArgs e)
        {
            StylePress = true;
            if (NewImg == null)
            {
                NewImg = Resource1.Geoscapebg;
                DisplayName = "XCOM";
                Background_change = true;
                Background_switch = false;
                Background_finished = false;
                string Snap = Path.Combine(Environment.CurrentDirectory, "Resources", "LibrarySnap.mp3");
                var click = new AudioFileReader($@"{Snap}");
                if (OutputDevice.PlaybackState == PlaybackState.Stopped)
                {
                    OutputDevice.Init(click);
                    OutputDevice.Play();

                }
                else if (OutputDevice.PlaybackState == PlaybackState.Playing)
                {
                    OutputDevice.Stop();
                    OutputDevice.Init(click);
                    OutputDevice.Play();
                }


            }
            else if (DisplayName == "XCOM")
            {
            }
            else
            {
                WaitingImg = Resource1.Geoscapebg;
                DisplayName = "XCOM";
                Background_switch = true;
                Background_change = false;
                Background_finished = false;
                string Snap = Path.Combine(Environment.CurrentDirectory, "Resources", "LibrarySnap.mp3");
                var click = new AudioFileReader($@"{Snap}");
                if (OutputDevice.PlaybackState == PlaybackState.Stopped)
                {
                    OutputDevice.Init(click);
                    OutputDevice.Play();

                }
                else
                {
                    OutputDevice.Stop();
                    OutputDevice.Init(click);
                    OutputDevice.Play();
                }
            }
        }

        private void AmbSnd_CheckedChanged(object sender, EventArgs e)
        {
            
            if (AmbSnd.Checked == true)
            {
                if (DisplayName == "XCOM")
                {
                    if (AmbientMusic.PlaybackState == PlaybackState.Stopped)
                    {
                        Ambient = Path.Combine(Environment.CurrentDirectory, "Properties", "XCOM.mp3");
                        Reader = new AudioFileReader($@"{Ambient}");
                        AmbientMusic.Init(Reader);
                        AmbientMusic.Play();
                    }
                    else
                    {
                        AmbientMusic.Stop();
                        Ambient = Path.Combine(Environment.CurrentDirectory, "Properties", "XCOM.mp3");
                        Reader = new AudioFileReader($@"{Ambient}");
                        AmbientMusic.Init(Reader);
                        AmbientMusic.Play();
                    }

                }
                if (DisplayName == "Sandskimmer")
                {
                    if (AmbientMusic.PlaybackState == PlaybackState.Stopped)
                    {
                        Ambient = Path.Combine(Environment.CurrentDirectory, "Properties", "DOK.mp3");
                        Reader = new AudioFileReader($@"{Ambient}");
                        AmbientMusic.Init(Reader);
                        AmbientMusic.Play();
                    }
                    else
                    {
                        AmbientMusic.Stop();
                        Ambient = Path.Combine(Environment.CurrentDirectory, "Properties", "DOK.mp3");
                        Reader = new AudioFileReader($@"{Ambient}");
                        AmbientMusic.Init(Reader);
                        AmbientMusic.Play();
                    }
                }

                if (DisplayName == "Faust")
                {
                    if (AmbientMusic.PlaybackState == PlaybackState.Stopped)
                    {
                        Ambient = Path.Combine(Environment.CurrentDirectory, "Properties", "Faust.mp3");
                        Reader = new AudioFileReader($@"{Ambient}");
                        AmbientMusic.Init(Reader);
                        AmbientMusic.Play();
                    }
                    else
                    {
                        AmbientMusic.Stop();
                        Ambient = Path.Combine(Environment.CurrentDirectory, "Properties", "Faust.mp3");
                        Reader = new AudioFileReader($@"{Ambient}");
                        AmbientMusic.Init(Reader);
                        AmbientMusic.Play();
                    }
                }
                if (DisplayName == "Garden")
                {
                    if (AmbientMusic.PlaybackState == PlaybackState.Stopped)
                    {
                        Ambient = Path.Combine(Environment.CurrentDirectory, "Properties", "Homeworld.mp3");
                        Reader = new AudioFileReader($@"{Ambient}");
                        AmbientMusic.Init(Reader);
                        AmbientMusic.Play();
                    }
                    else
                    {
                        AmbientMusic.Stop();
                        Ambient = Path.Combine(Environment.CurrentDirectory, "Properties", "Homeworld.mp3");
                        Reader = new AudioFileReader($@"{Ambient}");
                        AmbientMusic.Init(Reader);
                        AmbientMusic.Play();
                    }
                }
                if (DisplayName == "1mil")
                {
                    if (AmbientMusic.PlaybackState == PlaybackState.Stopped)
                    {
                        Ambient = Path.Combine(Environment.CurrentDirectory, "Properties", "Alicorn.mp3");
                        Reader = new AudioFileReader($@"{Ambient}");
                        AmbientMusic.Init(Reader);
                        AmbientMusic.Play();
                    }
                    else
                    {
                        AmbientMusic.Stop();
                        Ambient = Path.Combine(Environment.CurrentDirectory, "Properties", "Alicorn.mp3");
                        Reader = new AudioFileReader($@"{Ambient}");
                        AmbientMusic.Init(Reader);
                        AmbientMusic.Play();
                    }
                }
                if (DisplayName == "Wings")
                {
                    if (AmbientMusic.PlaybackState == PlaybackState.Stopped)
                    {
                        Ambient = Path.Combine(Environment.CurrentDirectory, "Properties", "YiSang.mp3");
                        Reader = new AudioFileReader($@"{Ambient}");
                        AmbientMusic.Init(Reader);
                        AmbientMusic.Play();
                    }
                    else
                    {
                        AmbientMusic.Stop();
                        Ambient = Path.Combine(Environment.CurrentDirectory, "Properties", "YiSang.mp3");
                        Reader = new AudioFileReader($@"{Ambient}");
                        AmbientMusic.Init(Reader);
                        AmbientMusic.Play();
                    }
                }
                if (DisplayName == "Xiao")
                {
                    if (AmbientMusic.PlaybackState == PlaybackState.Stopped)
                    {
                        Ambient = Path.Combine(Environment.CurrentDirectory, "Properties", "Xiao.mp3");
                        Reader = new AudioFileReader($@"{Ambient}");
                        AmbientMusic.Init(Reader);
                        AmbientMusic.Play();
                    }
                    else
                    {
                        AmbientMusic.Stop();
                        Ambient = Path.Combine(Environment.CurrentDirectory, "Properties", "Xiao.mp3");
                        Reader = new AudioFileReader($@"{Ambient}");
                        AmbientMusic.Init(Reader);
                        AmbientMusic.Play();
                    }
                }
                if (DisplayName == "Brigador")
                {
                    if (AmbientMusic.PlaybackState == PlaybackState.Stopped)
                    {
                        Ambient = Path.Combine(Environment.CurrentDirectory, "Properties", "Brigador.mp3");
                        Reader = new AudioFileReader($@"{Ambient}");
                        AmbientMusic.Init(Reader);
                        AmbientMusic.Play();
                    }
                    else
                    {
                        AmbientMusic.Stop();
                        Ambient = Path.Combine(Environment.CurrentDirectory, "Properties", "Brigador.mp3");
                        Reader = new AudioFileReader($@"{Ambient}");
                        AmbientMusic.Init(Reader);
                        AmbientMusic.Play();
                    }
                }
                if (DisplayName == "Yan")
                {
                    if (AmbientMusic.PlaybackState == PlaybackState.Stopped)
                    {
                        Ambient = Path.Combine(Environment.CurrentDirectory, "Properties", "Yan.mp3");
                        Reader = new AudioFileReader($@"{Ambient}");
                        AmbientMusic.Init(Reader);
                        AmbientMusic.Play();
                    }
                    else
                    {
                        AmbientMusic.Stop();
                        Ambient = Path.Combine(Environment.CurrentDirectory, "Properties", "Yan.mp3");
                        Reader = new AudioFileReader($@"{Ambient}");
                        AmbientMusic.Init(Reader);
                        AmbientMusic.Play();
                    }
                }
                if (DisplayName == "Starsector")
                {
                    if (AmbientMusic.PlaybackState == PlaybackState.Stopped)
                    {
                        Ambient = Path.Combine(Environment.CurrentDirectory, "Properties", "Starsector.mp3");
                        Reader = new AudioFileReader($@"{Ambient}");
                        AmbientMusic.Init(Reader);
                        AmbientMusic.Play();
                    }
                    else
                    {
                        AmbientMusic.Stop();
                        Ambient = Path.Combine(Environment.CurrentDirectory, "Properties", "Starsector.mp3");
                        Reader = new AudioFileReader($@"{Ambient}");
                        AmbientMusic.Init(Reader);
                        AmbientMusic.Play();
                    }
                }


            }
            if (AmbSnd.Checked == false)
            {
                AmbientMusic.Stop();
            }


        }

        private void Background_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            float ScaleX = this.Width / 1324f;
            float ScaleY = this.Height / 738f;
            e.Graphics.ScaleTransform(ScaleX, ScaleY);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            Color PrescriptWhite = Color.FromArgb(PrescriptOpacity, Color.White);
            Color PrescriptRed = Color.FromArgb(PrescriptOpacity, Color.DarkRed);
            Brush PrescriptMain = new SolidBrush(PrescriptWhite);
            Brush PrescriptBorder = new SolidBrush(PrescriptRed);
            Font PrescriptFont = new Font("Consolas", PrescriptFontSize);
            string Prescript = Properties.Resources.Prescript1;
            if (PrescriptScale == 1)
            {
                PrescriptScale = 1.05f;
            }
            else
            {
                PrescriptScale = 1f;
            }
            int Width = this.Width;
            int Height = this.Height;
            Rectangle LRect1 = new Rectangle(Width / 2 - CurtainSpeed, 0, CurtainSpeed, Height);
            Rectangle LRect2 = new Rectangle(Width / 2 - CurtainSpeed, 0, CurtainSpeed, Height);
            Rectangle RRect1 = new Rectangle(Width / 2, 0, CurtainSpeed, Height);
            Rectangle RRect2 = new Rectangle(Width / 2, 0, CurtainSpeed, Height);
            Rectangle FormRect = new Rectangle(0,0, Width, Height);
            if (Background_change == true)
            {
                
                e.Graphics.DrawImage(NewImg, LRect1, LRect2, GraphicsUnit.Pixel);
                e.Graphics.DrawImage(NewImg, RRect1, RRect2, GraphicsUnit.Pixel);

            }
            if (Background_switch == true)
            {
                
                e.Graphics.DrawImage(NewImg, LRect1, LRect2, GraphicsUnit.Pixel);
                e.Graphics.DrawImage(NewImg, RRect1, RRect2, GraphicsUnit.Pixel);
            }
            if (Background_finished == true)
            {
                e.Graphics.DrawImage(NewImg, FormRect);
            }
            if (Background_finished == true && ShipDisplayed == false && DisplayName == "Starsector")
            {
                RandomizeVars();
                Image Starship = StarsectorSpaceships[StarsectorShipIndex];
                e.Graphics.TranslateTransform(ShipX, ShipY);
                e.Graphics.RotateTransform(ShipAngle);
                e.Graphics.DrawImage(Starship, -Starship.Width/2,-Starship.Height/2 );
                float dx = StarsectorAngleCalc(ShipVelocity);
                ShipX += dx;
                ShipY -= ShipVelocity;
                if (ShipY < -200)
                {
                    ShipDisplayed = true;

                }

            }

            if (PrescriptDisplayed == false && Background_finished == true && DisplayName == "Yan")
            {
                Prescript = PrescriptsList[PrescriptListIndex];
                RandomizeVars();

                if (PrescriptIndex < Prescript.Length)
                {
                    float X = PrescriptX;
                    float Y = PrescriptY;

                    for (int i = 0; i < PrescriptIndex; i++)
                    {
                        string Char = Prescript[i].ToString();
                        if (Char == " ")
                        {
                            X += e.Graphics.MeasureString(" ", PrescriptFont).Width;
                            Y += AngularCalc(e.Graphics.MeasureString(" ", PrescriptFont).Width);
                            continue;

                        }
                        SizeF Size = e.Graphics.MeasureString(Char, PrescriptFont);
                        float dy = AngularCalc(Size.Width / 2);
                        e.Graphics.TranslateTransform(X + Size.Width / 2, Y + dy);
                        e.Graphics.RotateTransform(PrescriptAngle);
                        e.Graphics.ScaleTransform(PrescriptScale, PrescriptScale);
                        e.Graphics.DrawString(Char, PrescriptFont, PrescriptBorder, -Size.Width / 2 - 1, -dy / 2);
                        e.Graphics.DrawString(Char, PrescriptFont, PrescriptBorder, -Size.Width / 2, -dy / 2 - 1);
                        e.Graphics.DrawString(Char, PrescriptFont, PrescriptBorder, -Size.Width / 2 + 1, -dy / 2);
                        e.Graphics.DrawString(Char, PrescriptFont, PrescriptBorder, -Size.Width / 2, -dy / 2 + 1);
                        e.Graphics.DrawString(Char, PrescriptFont, PrescriptBorder, -Size.Width / 2 - 1, -dy / 2 - 1);
                        e.Graphics.DrawString(Char, PrescriptFont, PrescriptBorder, -Size.Width / 2 + 1, -dy / 2 + 1);
                        e.Graphics.DrawString(Char, PrescriptFont, PrescriptBorder, -Size.Width / 2 - 1, -dy / 2 + 1);
                        e.Graphics.DrawString(Char, PrescriptFont, PrescriptBorder, -Size.Width / 2 + 1, -dy / 2 - 1);
                        e.Graphics.DrawString(Char, PrescriptFont, PrescriptMain, -Size.Width / 2, -dy / 2);

                        e.Graphics.ResetTransform();
                        X += Size.Width;
                        Y += dy;
                    }
                }
                if (PrescriptIndex == Prescript.Length)
                {
                    float X = PrescriptX;
                    float Y = PrescriptY;
                    FadeOut = true;
                    for (int i = 0; i < PrescriptIndex; i++)
                    {
                        string Char = Prescript[i].ToString();
                        if (Char == " ")
                        {
                            X += e.Graphics.MeasureString(" ", PrescriptFont).Width;
                            Y += AngularCalc(e.Graphics.MeasureString(" ", PrescriptFont).Width);
                            continue;

                        }
                        SizeF Size = e.Graphics.MeasureString(Char, PrescriptFont);
                        float dy = AngularCalc(Size.Width / 2);
                        e.Graphics.TranslateTransform(X + Size.Width / 2, Y + dy);
                        int AngleVar = Rnd.Next(-5, 5);
                        e.Graphics.RotateTransform(PrescriptAngle + AngleVar);
                        e.Graphics.DrawString(Char, PrescriptFont, PrescriptMain, -Size.Width / 2, -dy / 2);
                        e.Graphics.DrawString(Char, PrescriptFont, PrescriptBorder, -Size.Width / 2 - 1, -dy / 2);
                        e.Graphics.DrawString(Char, PrescriptFont, PrescriptBorder, -Size.Width / 2, -dy / 2 - 1);
                        e.Graphics.DrawString(Char, PrescriptFont, PrescriptBorder, -Size.Width / 2 + 1, -dy / 2);
                        e.Graphics.DrawString(Char, PrescriptFont, PrescriptBorder, -Size.Width / 2, -dy / 2 + 1);
                        e.Graphics.DrawString(Char, PrescriptFont, PrescriptBorder, -Size.Width / 2 - 1, -dy / 2 - 1);
                        e.Graphics.DrawString(Char, PrescriptFont, PrescriptBorder, -Size.Width / 2 + 1, -dy / 2 + 1);
                        e.Graphics.DrawString(Char, PrescriptFont, PrescriptBorder, -Size.Width / 2 - 1, -dy / 2 + 1);
                        e.Graphics.DrawString(Char, PrescriptFont, PrescriptBorder, -Size.Width / 2 + 1, -dy / 2 - 1);
                        e.Graphics.DrawString(Char, PrescriptFont, PrescriptMain, -Size.Width / 2, -dy / 2);
                        e.Graphics.ResetTransform();
                        X += Size.Width;
                        Y += dy;
                    }

                }
            }
                
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {

            if (Background_change || Background_switch)
            {
                this.Invalidate();
            }
        }

        private void LoopAmbient(AudioFileReader Reader, WaveOutEvent AmbientMusic)
        {
            if (Reader.Position >= Reader.Length - 4096 && AmbientMusic.PlaybackState != PlaybackState.Stopped)
            {
                Reader.Position = 0;
                AmbientMusic.Stop();
                AmbientMusic.Init(Reader);
                AmbientMusic.Play();
                


            }
        }

        private void CheeseTimer_Tick(object sender, EventArgs e)
        {
            
            if (StylePress == true)
            {
                if (AmbientMusic.PlaybackState != PlaybackState.Playing || OutputDevice.PlaybackState == PlaybackState.Playing )
                {
                    if (AmbSnd.Checked == true)
                    {
                        AmbSnd.Checked = !AmbSnd.Checked;
                        AmbSnd.Checked = !AmbSnd.Checked;
                        StylePress = false;
                    }
                    
                }
                
            }
        }

        private void IndexTimer_Tick(object sender, EventArgs e)
        {
            if (PrescriptDisplayed == false && Background_finished == true && DisplayName == "Yan" && FadeOut == false)
            {
                PrescriptIndex += 1;
               
                if (PrescriptOpacity < 255)
                {

                    PrescriptOpacity += 51;
                }
                this.Invalidate();
                
            }
            if (PrescriptDisplayed == true)
            {
                PrescriptDisplayed = false;
                PrescriptIndex = 0;
            }


        }
        private void RandomizeVars()
        {
            if (StopRolling == false)
            {
                StopRolling = true;
                PrescriptAngle = Rnd.Next(-30, 30);
                PrescriptFontSize = Rnd.Next(10, 24);
                PrescriptListIndex = Rnd.Next(0, 19);
                PrescriptY = Rnd.Next(200, 400);
                PrescriptX = Rnd.Next(100,600);
                ShipX = Rnd.Next(300, 900);
                StarsectorShipIndex = Rnd.Next(0, 20);
                ShipAngle = Rnd.Next(-10,10);
                


            }
        }
        private float AngularCalc(float x)
        {
            double Radian = PrescriptAngle / 180.0 * Math.PI;
            float Scale = (float)Math.Tan(Radian);
            
            return Scale*x;
        }

        private void FadeOutTimer_Tick(object sender, EventArgs e)
        {
            if (FadeOut == true)
            {
                PrescriptOpacity -= 51;
                this.Invalidate();
                if (PrescriptOpacity == 0)
                {
                    FadeOut = false;
                    PrescriptDisplayed = true;
                    PrescriptIndex = 0;
                    StopRolling = false;
                    

                }    
            }
        }

        private void SlowAFTimer_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
            if (AlarmFlash == false && AlarmPlaying == true)
            {
                AlarmInput.BackColor = Color.Red;
                AlarmFlash = true;

            }
            else if (AlarmFlash == true && AlarmPlaying == true)
            {
                AlarmInput.BackColor = Color.White;
                AlarmFlash = false;


            }
        }

        private void StarsectorTimer_Tick(object sender, EventArgs e)
        {
            if (Background_finished == true && ShipDisplayed == false && DisplayName == "Starsector")
            {
                this.Invalidate();
            }
            else if (ShipDisplayed == true)
            {
                ShipDisplayed = false;
                ShipY = 700f;
                StopRolling = false;
            }
        }

        private float StarsectorAngleCalc(float ShipVelocity)
        {
            double Radian = (ShipAngle) / 180.0 * Math.PI;
            float Tan = (float)Math.Tan(Radian);
            return Tan * ShipVelocity;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void triangularButton2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void upsideDownTriangularButton1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void triangularButton2_MouseHover(object sender, EventArgs e)
        {
            triangularButton2.BackColor = Color.LightGray;
        }

        private void triangularButton2_MouseLeave(object sender, EventArgs e)
        {
            triangularButton2.BackColor = Color.White;
        }

        private void triangularButton2_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void upsideDownTriangularButton1_MouseHover(object sender, EventArgs e)
        {
            upsideDownTriangularButton1.BackColor = Color.LightGray;
        }

        private void upsideDownTriangularButton1_MouseLeave(object sender, EventArgs e)
        {
            upsideDownTriangularButton1.BackColor= Color.White;
        }
    }      
}
