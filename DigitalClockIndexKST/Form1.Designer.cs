namespace DigitalClockIndexKST
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AlarmInput = new System.Windows.Forms.MaskedTextBox();
            this.Alarm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.DaysLater = new System.Windows.Forms.Label();
            this.fluff = new System.Windows.Forms.Label();
            this.AlarmSounds = new System.Windows.Forms.ListBox();
            this.ListLabel = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.RmvBtn = new System.Windows.Forms.Button();
            this.InputTxt = new System.Windows.Forms.TextBox();
            this.PC = new System.Windows.Forms.Button();
            this.UTC = new System.Windows.Forms.Button();
            this.EST = new System.Windows.Forms.Button();
            this.KST = new System.Windows.Forms.Button();
            this.CST = new System.Windows.Forms.Button();
            this.PT = new System.Windows.Forms.Button();
            this.Remnant = new System.Windows.Forms.Button();
            this.Ind = new System.Windows.Forms.Button();
            this.Bri = new System.Windows.Forms.Button();
            this.Xiao = new System.Windows.Forms.Button();
            this.YiSang = new System.Windows.Forms.Button();
            this.Ace = new System.Windows.Forms.Button();
            this.Turanic = new System.Windows.Forms.Button();
            this.GWF = new System.Windows.Forms.Button();
            this.Dok = new System.Windows.Forms.Button();
            this.XCOM = new System.Windows.Forms.Button();
            this.AmbSnd = new System.Windows.Forms.CheckBox();
            this.AnimationTimer = new System.Windows.Forms.Timer(this.components);
            this.CheeseTimer = new System.Windows.Forms.Timer(this.components);
            this.IndexTimer = new System.Windows.Forms.Timer(this.components);
            this.FadeOutTimer = new System.Windows.Forms.Timer(this.components);
            this.SlowAFTimer = new System.Windows.Forms.Timer(this.components);
            this.StarsectorTimer = new System.Windows.Forms.Timer(this.components);
            this.upsideDownTriangularButton1 = new UpsideDownTriangularButton.UpsideDownTriangularButton();
            this.triangularButton2 = new TriangularButton.TriangularButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(449, -80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(868, 696);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loading....";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AlarmInput
            // 
            this.AlarmInput.BeepOnError = true;
            this.AlarmInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmInput.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.AlarmInput.HideSelection = false;
            this.AlarmInput.Location = new System.Drawing.Point(24, 162);
            this.AlarmInput.Mask = "00:00:00";
            this.AlarmInput.Name = "AlarmInput";
            this.AlarmInput.RejectInputOnFirstFailure = true;
            this.AlarmInput.Size = new System.Drawing.Size(197, 62);
            this.AlarmInput.TabIndex = 1;
            this.AlarmInput.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.AlarmInput_TypeValidationCompleted);
            // 
            // Alarm
            // 
            this.Alarm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Alarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alarm.ForeColor = System.Drawing.Color.Red;
            this.Alarm.Location = new System.Drawing.Point(247, 178);
            this.Alarm.Name = "Alarm";
            this.Alarm.Size = new System.Drawing.Size(75, 44);
            this.Alarm.TabIndex = 2;
            this.Alarm.Text = "Start";
            this.Alarm.UseVisualStyleBackColor = false;
            this.Alarm.Click += new System.EventHandler(this.Alarm_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(681, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(515, 147);
            this.label2.TabIndex = 4;
            this.label2.Text = "Loading...";
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.ForeColor = System.Drawing.Color.Red;
            this.StopButton.Location = new System.Drawing.Point(247, 178);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 44);
            this.StopButton.TabIndex = 5;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Visible = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // DaysLater
            // 
            this.DaysLater.BackColor = System.Drawing.Color.Transparent;
            this.DaysLater.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DaysLater.Location = new System.Drawing.Point(50, 303);
            this.DaysLater.Name = "DaysLater";
            this.DaysLater.Size = new System.Drawing.Size(106, 46);
            this.DaysLater.TabIndex = 9;
            this.DaysLater.Text = "0";
            this.DaysLater.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fluff
            // 
            this.fluff.BackColor = System.Drawing.Color.Transparent;
            this.fluff.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fluff.Location = new System.Drawing.Point(140, 303);
            this.fluff.Name = "fluff";
            this.fluff.Size = new System.Drawing.Size(213, 54);
            this.fluff.TabIndex = 10;
            this.fluff.Text = "days later";
            // 
            // AlarmSounds
            // 
            this.AlarmSounds.FormattingEnabled = true;
            this.AlarmSounds.HorizontalScrollbar = true;
            this.AlarmSounds.Location = new System.Drawing.Point(12, 491);
            this.AlarmSounds.Name = "AlarmSounds";
            this.AlarmSounds.Size = new System.Drawing.Size(291, 199);
            this.AlarmSounds.TabIndex = 11;
            this.AlarmSounds.DoubleClick += new System.EventHandler(this.AlarmSounds_DoubleClick);
            // 
            // ListLabel
            // 
            this.ListLabel.AutoEllipsis = true;
            this.ListLabel.BackColor = System.Drawing.Color.White;
            this.ListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListLabel.ForeColor = System.Drawing.Color.Black;
            this.ListLabel.Location = new System.Drawing.Point(42, 429);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(228, 33);
            this.ListLabel.TabIndex = 12;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.White;
            this.AddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddBtn.BackgroundImage")));
            this.AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Location = new System.Drawing.Point(12, 429);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(31, 33);
            this.AddBtn.TabIndex = 13;
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RmvBtn
            // 
            this.RmvBtn.BackColor = System.Drawing.Color.White;
            this.RmvBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RmvBtn.BackgroundImage")));
            this.RmvBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RmvBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RmvBtn.Location = new System.Drawing.Point(267, 429);
            this.RmvBtn.Name = "RmvBtn";
            this.RmvBtn.Size = new System.Drawing.Size(36, 33);
            this.RmvBtn.TabIndex = 14;
            this.RmvBtn.UseVisualStyleBackColor = false;
            this.RmvBtn.Click += new System.EventHandler(this.RmvBtn_Click);
            // 
            // InputTxt
            // 
            this.InputTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTxt.Location = new System.Drawing.Point(13, 465);
            this.InputTxt.Name = "InputTxt";
            this.InputTxt.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.InputTxt.Size = new System.Drawing.Size(290, 29);
            this.InputTxt.TabIndex = 15;
            // 
            // PC
            // 
            this.PC.BackColor = System.Drawing.Color.White;
            this.PC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PC.ForeColor = System.Drawing.Color.Black;
            this.PC.Location = new System.Drawing.Point(328, 632);
            this.PC.Name = "PC";
            this.PC.Size = new System.Drawing.Size(111, 55);
            this.PC.TabIndex = 16;
            this.PC.Text = "PC Time";
            this.PC.UseVisualStyleBackColor = false;
            this.PC.Click += new System.EventHandler(this.PC_Click);
            // 
            // UTC
            // 
            this.UTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UTC.ForeColor = System.Drawing.Color.Black;
            this.UTC.Location = new System.Drawing.Point(486, 632);
            this.UTC.Name = "UTC";
            this.UTC.Size = new System.Drawing.Size(111, 55);
            this.UTC.TabIndex = 17;
            this.UTC.Text = "UTC";
            this.UTC.UseVisualStyleBackColor = true;
            this.UTC.Click += new System.EventHandler(this.UTC_Click);
            // 
            // EST
            // 
            this.EST.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EST.ForeColor = System.Drawing.Color.Black;
            this.EST.Location = new System.Drawing.Point(646, 632);
            this.EST.Name = "EST";
            this.EST.Size = new System.Drawing.Size(111, 55);
            this.EST.TabIndex = 18;
            this.EST.Text = "EST";
            this.EST.UseVisualStyleBackColor = true;
            this.EST.Click += new System.EventHandler(this.EST_Click);
            // 
            // KST
            // 
            this.KST.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KST.ForeColor = System.Drawing.Color.Black;
            this.KST.Location = new System.Drawing.Point(806, 632);
            this.KST.Name = "KST";
            this.KST.Size = new System.Drawing.Size(111, 55);
            this.KST.TabIndex = 19;
            this.KST.Text = "KST";
            this.KST.UseVisualStyleBackColor = true;
            this.KST.Click += new System.EventHandler(this.KST_Click);
            // 
            // CST
            // 
            this.CST.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CST.ForeColor = System.Drawing.Color.Black;
            this.CST.Location = new System.Drawing.Point(964, 632);
            this.CST.Name = "CST";
            this.CST.Size = new System.Drawing.Size(111, 55);
            this.CST.TabIndex = 20;
            this.CST.Text = "CST";
            this.CST.UseVisualStyleBackColor = true;
            this.CST.Click += new System.EventHandler(this.CST_Click);
            // 
            // PT
            // 
            this.PT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PT.ForeColor = System.Drawing.Color.Black;
            this.PT.Location = new System.Drawing.Point(1125, 632);
            this.PT.Name = "PT";
            this.PT.Size = new System.Drawing.Size(111, 55);
            this.PT.TabIndex = 21;
            this.PT.Text = "PT";
            this.PT.UseVisualStyleBackColor = true;
            this.PT.Click += new System.EventHandler(this.GMT_Click);
            // 
            // Remnant
            // 
            this.Remnant.BackColor = System.Drawing.Color.Transparent;
            this.Remnant.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Remnant.BackgroundImage")));
            this.Remnant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Remnant.ForeColor = System.Drawing.Color.Transparent;
            this.Remnant.Location = new System.Drawing.Point(24, 64);
            this.Remnant.Name = "Remnant";
            this.Remnant.Size = new System.Drawing.Size(89, 57);
            this.Remnant.TabIndex = 22;
            this.Remnant.UseVisualStyleBackColor = false;
            this.Remnant.Click += new System.EventHandler(this.Remnant_Click);
            // 
            // Ind
            // 
            this.Ind.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Ind.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Ind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ind.BackgroundImage")));
            this.Ind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Ind.Location = new System.Drawing.Point(149, 64);
            this.Ind.Name = "Ind";
            this.Ind.Size = new System.Drawing.Size(89, 57);
            this.Ind.TabIndex = 23;
            this.Ind.Text = " ";
            this.Ind.UseVisualStyleBackColor = false;
            this.Ind.Click += new System.EventHandler(this.Ind_Click);
            // 
            // Bri
            // 
            this.Bri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bri.BackgroundImage")));
            this.Bri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bri.Location = new System.Drawing.Point(277, 64);
            this.Bri.Name = "Bri";
            this.Bri.Size = new System.Drawing.Size(89, 57);
            this.Bri.TabIndex = 24;
            this.Bri.UseVisualStyleBackColor = true;
            this.Bri.Click += new System.EventHandler(this.Bri_Click);
            // 
            // Xiao
            // 
            this.Xiao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Xiao.BackgroundImage")));
            this.Xiao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Xiao.Location = new System.Drawing.Point(406, 64);
            this.Xiao.Name = "Xiao";
            this.Xiao.Size = new System.Drawing.Size(89, 57);
            this.Xiao.TabIndex = 25;
            this.Xiao.UseVisualStyleBackColor = true;
            this.Xiao.Click += new System.EventHandler(this.Xiao_Click);
            // 
            // YiSang
            // 
            this.YiSang.BackColor = System.Drawing.SystemColors.GrayText;
            this.YiSang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("YiSang.BackgroundImage")));
            this.YiSang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.YiSang.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.YiSang.Location = new System.Drawing.Point(535, 64);
            this.YiSang.Name = "YiSang";
            this.YiSang.Size = new System.Drawing.Size(89, 57);
            this.YiSang.TabIndex = 26;
            this.YiSang.UseVisualStyleBackColor = false;
            this.YiSang.Click += new System.EventHandler(this.YiSang_Click);
            // 
            // Ace
            // 
            this.Ace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ace.BackgroundImage")));
            this.Ace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Ace.Location = new System.Drawing.Point(668, 64);
            this.Ace.Name = "Ace";
            this.Ace.Size = new System.Drawing.Size(89, 57);
            this.Ace.TabIndex = 27;
            this.Ace.UseVisualStyleBackColor = true;
            this.Ace.Click += new System.EventHandler(this.Ace_Click);
            // 
            // Turanic
            // 
            this.Turanic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Turanic.BackgroundImage")));
            this.Turanic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Turanic.Location = new System.Drawing.Point(797, 64);
            this.Turanic.Name = "Turanic";
            this.Turanic.Size = new System.Drawing.Size(89, 57);
            this.Turanic.TabIndex = 28;
            this.Turanic.UseVisualStyleBackColor = true;
            this.Turanic.Click += new System.EventHandler(this.Turanic_Click);
            // 
            // GWF
            // 
            this.GWF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GWF.BackgroundImage")));
            this.GWF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GWF.Location = new System.Drawing.Point(924, 64);
            this.GWF.Name = "GWF";
            this.GWF.Size = new System.Drawing.Size(89, 57);
            this.GWF.TabIndex = 29;
            this.GWF.UseVisualStyleBackColor = true;
            this.GWF.Click += new System.EventHandler(this.GWF_Click);
            // 
            // Dok
            // 
            this.Dok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Dok.BackgroundImage")));
            this.Dok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Dok.Location = new System.Drawing.Point(1054, 64);
            this.Dok.Name = "Dok";
            this.Dok.Size = new System.Drawing.Size(89, 57);
            this.Dok.TabIndex = 30;
            this.Dok.UseVisualStyleBackColor = true;
            this.Dok.Click += new System.EventHandler(this.Dok_Click);
            // 
            // XCOM
            // 
            this.XCOM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("XCOM.BackgroundImage")));
            this.XCOM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.XCOM.Location = new System.Drawing.Point(1181, 64);
            this.XCOM.Name = "XCOM";
            this.XCOM.Size = new System.Drawing.Size(89, 57);
            this.XCOM.TabIndex = 31;
            this.XCOM.UseVisualStyleBackColor = true;
            this.XCOM.Click += new System.EventHandler(this.XCOM_Click);
            // 
            // AmbSnd
            // 
            this.AmbSnd.BackColor = System.Drawing.Color.Transparent;
            this.AmbSnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmbSnd.ForeColor = System.Drawing.Color.AliceBlue;
            this.AmbSnd.Location = new System.Drawing.Point(1139, 22);
            this.AmbSnd.Name = "AmbSnd";
            this.AmbSnd.Size = new System.Drawing.Size(131, 27);
            this.AmbSnd.TabIndex = 32;
            this.AmbSnd.Text = "Ambient Sound";
            this.AmbSnd.UseVisualStyleBackColor = false;
            this.AmbSnd.CheckedChanged += new System.EventHandler(this.AmbSnd_CheckedChanged);
            // 
            // AnimationTimer
            // 
            this.AnimationTimer.Interval = 50;
            this.AnimationTimer.Tick += new System.EventHandler(this.AnimationTimer_Tick);
            // 
            // CheeseTimer
            // 
            this.CheeseTimer.Interval = 1;
            this.CheeseTimer.Tick += new System.EventHandler(this.CheeseTimer_Tick);
            // 
            // IndexTimer
            // 
            this.IndexTimer.Interval = 250;
            this.IndexTimer.Tick += new System.EventHandler(this.IndexTimer_Tick);
            // 
            // FadeOutTimer
            // 
            this.FadeOutTimer.Interval = 750;
            this.FadeOutTimer.Tick += new System.EventHandler(this.FadeOutTimer_Tick);
            // 
            // SlowAFTimer
            // 
            this.SlowAFTimer.Interval = 750;
            this.SlowAFTimer.Tick += new System.EventHandler(this.SlowAFTimer_Tick);
            // 
            // StarsectorTimer
            // 
            this.StarsectorTimer.Interval = 33;
            this.StarsectorTimer.Tick += new System.EventHandler(this.StarsectorTimer_Tick);
            // 
            // upsideDownTriangularButton1
            // 
            this.upsideDownTriangularButton1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.upsideDownTriangularButton1.Location = new System.Drawing.Point(68, 352);
            this.upsideDownTriangularButton1.Name = "upsideDownTriangularButton1";
            this.upsideDownTriangularButton1.Size = new System.Drawing.Size(67, 55);
            this.upsideDownTriangularButton1.TabIndex = 8;
            this.upsideDownTriangularButton1.Text = "upsideDownTriangularButton1";
            this.upsideDownTriangularButton1.UseVisualStyleBackColor = false;
            this.upsideDownTriangularButton1.Click += new System.EventHandler(this.upsideDownTriangularButton1_Click);
            this.upsideDownTriangularButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.upsideDownTriangularButton1_MouseClick);
            this.upsideDownTriangularButton1.MouseLeave += new System.EventHandler(this.upsideDownTriangularButton1_MouseLeave);
            this.upsideDownTriangularButton1.MouseHover += new System.EventHandler(this.upsideDownTriangularButton1_MouseHover);
            // 
            // triangularButton2
            // 
            this.triangularButton2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.triangularButton2.Location = new System.Drawing.Point(68, 245);
            this.triangularButton2.Name = "triangularButton2";
            this.triangularButton2.Size = new System.Drawing.Size(67, 55);
            this.triangularButton2.TabIndex = 7;
            this.triangularButton2.Text = "triangularButton2";
            this.triangularButton2.UseVisualStyleBackColor = false;
            this.triangularButton2.Click += new System.EventHandler(this.triangularButton2_Click);
            this.triangularButton2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.triangularButton2_MouseClick);
            this.triangularButton2.MouseLeave += new System.EventHandler(this.triangularButton2_MouseLeave);
            this.triangularButton2.MouseHover += new System.EventHandler(this.triangularButton2_MouseHover);
            this.triangularButton2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.triangularButton2_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = global::DigitalClockIndexKST.Resource1.BlackBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1308, 699);
            this.Controls.Add(this.AmbSnd);
            this.Controls.Add(this.XCOM);
            this.Controls.Add(this.Dok);
            this.Controls.Add(this.GWF);
            this.Controls.Add(this.Turanic);
            this.Controls.Add(this.Ace);
            this.Controls.Add(this.YiSang);
            this.Controls.Add(this.Xiao);
            this.Controls.Add(this.Bri);
            this.Controls.Add(this.Ind);
            this.Controls.Add(this.Remnant);
            this.Controls.Add(this.PT);
            this.Controls.Add(this.CST);
            this.Controls.Add(this.KST);
            this.Controls.Add(this.EST);
            this.Controls.Add(this.UTC);
            this.Controls.Add(this.PC);
            this.Controls.Add(this.InputTxt);
            this.Controls.Add(this.RmvBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.ListLabel);
            this.Controls.Add(this.AlarmSounds);
            this.Controls.Add(this.fluff);
            this.Controls.Add(this.DaysLater);
            this.Controls.Add(this.upsideDownTriangularButton1);
            this.Controls.Add(this.triangularButton2);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Alarm);
            this.Controls.Add(this.AlarmInput);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MaskedTextBox AlarmInput;
        private System.Windows.Forms.Button Alarm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StopButton;
        private TriangularButton.TriangularButton triangularButton2;
        private UpsideDownTriangularButton.UpsideDownTriangularButton upsideDownTriangularButton1;
        private System.Windows.Forms.Label DaysLater;
        private System.Windows.Forms.Label fluff;
        private System.Windows.Forms.ListBox AlarmSounds;
        private System.Windows.Forms.Label ListLabel;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button RmvBtn;
        private System.Windows.Forms.TextBox InputTxt;
        private System.Windows.Forms.Button PC;
        private System.Windows.Forms.Button UTC;
        private System.Windows.Forms.Button EST;
        private System.Windows.Forms.Button KST;
        private System.Windows.Forms.Button CST;
        private System.Windows.Forms.Button PT;
        private System.Windows.Forms.Button Remnant;
        private System.Windows.Forms.Button Ind;
        private System.Windows.Forms.Button Bri;
        private System.Windows.Forms.Button Xiao;
        private System.Windows.Forms.Button YiSang;
        private System.Windows.Forms.Button Ace;
        private System.Windows.Forms.Button Turanic;
        private System.Windows.Forms.Button GWF;
        private System.Windows.Forms.Button Dok;
        private System.Windows.Forms.Button XCOM;
        private System.Windows.Forms.CheckBox AmbSnd;
        private System.Windows.Forms.Timer AnimationTimer;
        private System.Windows.Forms.Timer CheeseTimer;
        private System.Windows.Forms.Timer IndexTimer;
        private System.Windows.Forms.Timer FadeOutTimer;
        private System.Windows.Forms.Timer SlowAFTimer;
        private System.Windows.Forms.Timer StarsectorTimer;
    }
}

