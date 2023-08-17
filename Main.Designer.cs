namespace Rupee
{
    partial class MainWin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            GBAO = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            PrivatePort = new TextBox();
            UDPRadioButton = new RadioButton();
            TCPRadioButton = new RadioButton();
            setSeconds = new NumericUpDown();
            setMinutes = new NumericUpDown();
            setHours = new NumericUpDown();
            NewPrivatePort = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            MyIpText = new Label();
            MyPortText = new Label();
            ShowAO = new CheckBox();
            NewPublicPort = new Button();
            PublicPort = new TextBox();
            ToolTipRefresh = new ToolTip(components);
            MyIp = new TextBox();
            OpenPort = new Button();
            ClosePort = new Button();
            RupeeTimer = new System.Windows.Forms.Timer(components);
            RemainingTime = new Label();
            RemainingTimeText = new Label();
            GBAO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)setSeconds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)setMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)setHours).BeginInit();
            SuspendLayout();
            // 
            // GBAO
            // 
            GBAO.Controls.Add(label7);
            GBAO.Controls.Add(label6);
            GBAO.Controls.Add(label1);
            GBAO.Controls.Add(PrivatePort);
            GBAO.Controls.Add(UDPRadioButton);
            GBAO.Controls.Add(TCPRadioButton);
            GBAO.Controls.Add(setSeconds);
            GBAO.Controls.Add(setMinutes);
            GBAO.Controls.Add(setHours);
            GBAO.Controls.Add(NewPrivatePort);
            GBAO.Controls.Add(label4);
            GBAO.Controls.Add(label3);
            GBAO.Controls.Add(label2);
            GBAO.FlatStyle = FlatStyle.Flat;
            GBAO.Location = new Point(35, 128);
            GBAO.Margin = new Padding(3, 2, 3, 2);
            GBAO.Name = "GBAO";
            GBAO.Padding = new Padding(3, 2, 3, 2);
            GBAO.Size = new Size(381, 161);
            GBAO.TabIndex = 0;
            GBAO.TabStop = false;
            GBAO.Text = "Options avancées";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 125);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 10;
            label7.Text = "Secondes";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 100);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 10;
            label6.Text = "Minutes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 76);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 10;
            label1.Text = "Heures";
            // 
            // PrivatePort
            // 
            PrivatePort.BorderStyle = BorderStyle.FixedSingle;
            PrivatePort.Location = new Point(80, 21);
            PrivatePort.Margin = new Padding(3, 2, 3, 2);
            PrivatePort.MaximumSize = new Size(44, 20);
            PrivatePort.MaxLength = 5;
            PrivatePort.Name = "PrivatePort";
            PrivatePort.Size = new Size(44, 20);
            PrivatePort.TabIndex = 7;
            PrivatePort.TabStop = false;
            PrivatePort.Text = "00000";
            PrivatePort.TextAlign = HorizontalAlignment.Center;
            PrivatePort.WordWrap = false;
            PrivatePort.TextChanged += PrivatePort_TextChanged;
            // 
            // UDPRadioButton
            // 
            UDPRadioButton.AutoSize = true;
            UDPRadioButton.Location = new Point(246, 74);
            UDPRadioButton.Margin = new Padding(3, 2, 3, 2);
            UDPRadioButton.Name = "UDPRadioButton";
            UDPRadioButton.Size = new Size(48, 19);
            UDPRadioButton.TabIndex = 9;
            UDPRadioButton.Text = "UDP";
            UDPRadioButton.UseVisualStyleBackColor = true;
            UDPRadioButton.CheckedChanged += UDPRadioButton_CheckedChanged;
            // 
            // TCPRadioButton
            // 
            TCPRadioButton.AutoSize = true;
            TCPRadioButton.Location = new Point(246, 51);
            TCPRadioButton.Margin = new Padding(3, 2, 3, 2);
            TCPRadioButton.Name = "TCPRadioButton";
            TCPRadioButton.Size = new Size(45, 19);
            TCPRadioButton.TabIndex = 8;
            TCPRadioButton.Text = "TCP";
            TCPRadioButton.UseVisualStyleBackColor = true;
            TCPRadioButton.CheckedChanged += TCPRadioButton_CheckedChanged;
            // 
            // setSeconds
            // 
            setSeconds.Location = new Point(80, 124);
            setSeconds.Margin = new Padding(3, 2, 3, 2);
            setSeconds.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            setSeconds.Name = "setSeconds";
            setSeconds.Size = new Size(39, 23);
            setSeconds.TabIndex = 7;
            setSeconds.TabStop = false;
            ToolTipRefresh.SetToolTip(setSeconds, "Secondes");
            // 
            // setMinutes
            // 
            setMinutes.Location = new Point(80, 99);
            setMinutes.Margin = new Padding(3, 2, 3, 2);
            setMinutes.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            setMinutes.Name = "setMinutes";
            setMinutes.Size = new Size(39, 23);
            setMinutes.TabIndex = 7;
            setMinutes.TabStop = false;
            ToolTipRefresh.SetToolTip(setMinutes, "Minutes");
            // 
            // setHours
            // 
            setHours.Location = new Point(80, 74);
            setHours.Margin = new Padding(3, 2, 3, 2);
            setHours.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            setHours.Name = "setHours";
            setHours.Size = new Size(39, 23);
            setHours.TabIndex = 7;
            setHours.TabStop = false;
            ToolTipRefresh.SetToolTip(setHours, "Heures");
            setHours.Value = new decimal(new int[] { 24, 0, 0, 0 });
            // 
            // NewPrivatePort
            // 
            NewPrivatePort.Location = new Point(171, 20);
            NewPrivatePort.Margin = new Padding(3, 2, 3, 2);
            NewPrivatePort.Name = "NewPrivatePort";
            NewPrivatePort.Size = new Size(82, 22);
            NewPrivatePort.TabIndex = 6;
            NewPrivatePort.TabStop = false;
            NewPrivatePort.Text = "Nouveau";
            ToolTipRefresh.SetToolTip(NewPrivatePort, "Choisi un nouveau port disponible aléatoirement");
            NewPrivatePort.UseVisualStyleBackColor = true;
            NewPrivatePort.Click += NewPrivatePort_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(171, 52);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 3;
            label4.Text = "Protocole :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 52);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 2;
            label3.Text = "Durée de validité :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 22);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Port privé :";
            // 
            // MyIpText
            // 
            MyIpText.AutoSize = true;
            MyIpText.Location = new Point(35, 22);
            MyIpText.Name = "MyIpText";
            MyIpText.Size = new Size(51, 15);
            MyIpText.TabIndex = 1;
            MyIpText.Text = "Mon IP :";
            // 
            // MyPortText
            // 
            MyPortText.AutoSize = true;
            MyPortText.Location = new Point(203, 22);
            MyPortText.Name = "MyPortText";
            MyPortText.Size = new Size(71, 15);
            MyPortText.TabIndex = 2;
            MyPortText.Text = "Port public :";
            // 
            // ShowAO
            // 
            ShowAO.AutoSize = true;
            ShowAO.Location = new Point(35, 98);
            ShowAO.Margin = new Padding(3, 2, 3, 2);
            ShowAO.Name = "ShowAO";
            ShowAO.Size = new Size(174, 19);
            ShowAO.TabIndex = 3;
            ShowAO.TabStop = false;
            ShowAO.Text = "Activer les options avancées";
            ShowAO.UseVisualStyleBackColor = true;
            ShowAO.CheckedChanged += ShowAO_CheckedChanged;
            // 
            // NewPublicPort
            // 
            NewPublicPort.Location = new Point(333, 20);
            NewPublicPort.Margin = new Padding(3, 2, 3, 2);
            NewPublicPort.Name = "NewPublicPort";
            NewPublicPort.Size = new Size(82, 22);
            NewPublicPort.TabIndex = 6;
            NewPublicPort.TabStop = false;
            NewPublicPort.Text = "Nouveau";
            ToolTipRefresh.SetToolTip(NewPublicPort, "Choisi un nouveau port disponible aléatoirement");
            NewPublicPort.UseVisualStyleBackColor = true;
            NewPublicPort.Click += NewPublicPort_Click;
            // 
            // PublicPort
            // 
            PublicPort.BorderStyle = BorderStyle.FixedSingle;
            PublicPort.Location = new Point(284, 21);
            PublicPort.Margin = new Padding(3, 2, 3, 2);
            PublicPort.MaximumSize = new Size(44, 20);
            PublicPort.MaxLength = 5;
            PublicPort.Name = "PublicPort";
            PublicPort.ReadOnly = true;
            PublicPort.Size = new Size(44, 20);
            PublicPort.TabIndex = 7;
            PublicPort.TabStop = false;
            PublicPort.Text = "00000";
            PublicPort.TextAlign = HorizontalAlignment.Center;
            PublicPort.WordWrap = false;
            PublicPort.TextChanged += PublicPort_TextChanged;
            // 
            // MyIp
            // 
            MyIp.BorderStyle = BorderStyle.FixedSingle;
            MyIp.Location = new Point(94, 21);
            MyIp.Margin = new Padding(3, 2, 3, 2);
            MyIp.MaximumSize = new Size(104, 20);
            MyIp.MaxLength = 15;
            MyIp.Name = "MyIp";
            MyIp.ReadOnly = true;
            MyIp.Size = new Size(104, 20);
            MyIp.TabIndex = 10;
            MyIp.TabStop = false;
            MyIp.Text = "00.00.000.000";
            MyIp.TextAlign = HorizontalAlignment.Center;
            ToolTipRefresh.SetToolTip(MyIp, "Autorise une IP spécifique (00.00.000.000 pour autoriser toutes les IP)");
            MyIp.WordWrap = false;
            // 
            // OpenPort
            // 
            OpenPort.Location = new Point(108, 60);
            OpenPort.Margin = new Padding(3, 2, 3, 2);
            OpenPort.Name = "OpenPort";
            OpenPort.Size = new Size(114, 22);
            OpenPort.TabIndex = 11;
            OpenPort.Text = "Ouvrir le port";
            OpenPort.UseVisualStyleBackColor = true;
            OpenPort.Click += OpenPort_Click;
            // 
            // ClosePort
            // 
            ClosePort.Location = new Point(239, 60);
            ClosePort.Margin = new Padding(3, 2, 3, 2);
            ClosePort.Name = "ClosePort";
            ClosePort.Size = new Size(114, 22);
            ClosePort.TabIndex = 12;
            ClosePort.Text = "Fermer le port";
            ClosePort.UseVisualStyleBackColor = true;
            ClosePort.Click += ClosePort_Click;
            // 
            // RupeeTimer
            // 
            RupeeTimer.Interval = 1000;
            RupeeTimer.Tick += RupeeTimer_Tick;
            // 
            // RemainingTime
            // 
            RemainingTime.AutoSize = true;
            RemainingTime.Location = new Point(367, 99);
            RemainingTime.Name = "RemainingTime";
            RemainingTime.RightToLeft = RightToLeft.Yes;
            RemainingTime.Size = new Size(49, 15);
            RemainingTime.TabIndex = 14;
            RemainingTime.Text = "00:00:00";
            // 
            // RemainingTimeText
            // 
            RemainingTimeText.AutoSize = true;
            RemainingTimeText.Location = new Point(281, 99);
            RemainingTimeText.Name = "RemainingTimeText";
            RemainingTimeText.Size = new Size(86, 15);
            RemainingTimeText.TabIndex = 15;
            RemainingTimeText.Text = "Temps restant :";
            // 
            // MainWin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 326);
            Controls.Add(RemainingTimeText);
            Controls.Add(RemainingTime);
            Controls.Add(ClosePort);
            Controls.Add(OpenPort);
            Controls.Add(MyIp);
            Controls.Add(PublicPort);
            Controls.Add(NewPublicPort);
            Controls.Add(ShowAO);
            Controls.Add(MyPortText);
            Controls.Add(MyIpText);
            Controls.Add(GBAO);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainWin";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Rupee";
            FormClosing += MainWin_FormClosing;
            Load += Main_Load;
            GBAO.ResumeLayout(false);
            GBAO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)setSeconds).EndInit();
            ((System.ComponentModel.ISupportInitialize)setMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)setHours).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox GBAO;
        private Label MyIpText;
        private Label MyPortText;
        private CheckBox ShowAO;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button NewPrivatePort;
        private Button NewPublicPort;
        private NumericUpDown setSeconds;
        private NumericUpDown setMinutes;
        private NumericUpDown setHours;
        private RadioButton UDPRadioButton;
        private RadioButton TCPRadioButton;
        private TextBox PublicPort;
        private TextBox PrivatePort;
        private ToolTip ToolTipRefresh;
        private TextBox MyIp;
        private Label label7;
        private Label label6;
        private Label label1;
        private Button OpenPort;
        private Button ClosePort;
        private System.Windows.Forms.Timer RupeeTimer;
        private Label RemainingTime;
        private Label RemainingTimeText;
    }
}