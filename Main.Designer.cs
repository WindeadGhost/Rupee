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
            GBAO.Location = new Point(40, 170);
            GBAO.Name = "GBAO";
            GBAO.Size = new Size(435, 215);
            GBAO.TabIndex = 0;
            GBAO.TabStop = false;
            GBAO.Text = "Options avancées";
            GBAO.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 167);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 10;
            label7.Text = "Secondes";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 134);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 10;
            label6.Text = "Minutes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 101);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 10;
            label1.Text = "Heures";
            // 
            // PrivatePort
            // 
            PrivatePort.BorderStyle = BorderStyle.FixedSingle;
            PrivatePort.Location = new Point(91, 28);
            PrivatePort.MaxLength = 5;
            PrivatePort.Name = "PrivatePort";
            PrivatePort.Size = new Size(50, 27);
            PrivatePort.TabIndex = 7;
            PrivatePort.TabStop = false;
            PrivatePort.Text = "00000";
            PrivatePort.TextAlign = HorizontalAlignment.Center;
            PrivatePort.WordWrap = false;
            // 
            // UDPRadioButton
            // 
            UDPRadioButton.AutoSize = true;
            UDPRadioButton.Location = new Point(281, 99);
            UDPRadioButton.Name = "UDPRadioButton";
            UDPRadioButton.Size = new Size(59, 24);
            UDPRadioButton.TabIndex = 9;
            UDPRadioButton.Text = "UDP";
            UDPRadioButton.UseVisualStyleBackColor = true;
            UDPRadioButton.CheckedChanged += UDPRadioButton_CheckedChanged;
            // 
            // TCPRadioButton
            // 
            TCPRadioButton.AutoSize = true;
            TCPRadioButton.Location = new Point(281, 68);
            TCPRadioButton.Name = "TCPRadioButton";
            TCPRadioButton.Size = new Size(54, 24);
            TCPRadioButton.TabIndex = 8;
            TCPRadioButton.Text = "TCP";
            TCPRadioButton.UseVisualStyleBackColor = true;
            TCPRadioButton.CheckedChanged += TCPRadioButton_CheckedChanged;
            // 
            // setSeconds
            // 
            setSeconds.Location = new Point(91, 165);
            setSeconds.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            setSeconds.Name = "setSeconds";
            setSeconds.Size = new Size(45, 27);
            setSeconds.TabIndex = 7;
            setSeconds.TabStop = false;
            ToolTipRefresh.SetToolTip(setSeconds, "Secondes");
            // 
            // setMinutes
            // 
            setMinutes.Location = new Point(91, 132);
            setMinutes.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            setMinutes.Name = "setMinutes";
            setMinutes.Size = new Size(45, 27);
            setMinutes.TabIndex = 7;
            setMinutes.TabStop = false;
            ToolTipRefresh.SetToolTip(setMinutes, "Minutes");
            // 
            // setHours
            // 
            setHours.Location = new Point(91, 99);
            setHours.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            setHours.Name = "setHours";
            setHours.Size = new Size(45, 27);
            setHours.TabIndex = 7;
            setHours.TabStop = false;
            ToolTipRefresh.SetToolTip(setHours, "Heures");
            setHours.Value = new decimal(new int[] { 24, 0, 0, 0 });
            // 
            // NewPrivatePort
            // 
            NewPrivatePort.Location = new Point(195, 26);
            NewPrivatePort.Name = "NewPrivatePort";
            NewPrivatePort.Size = new Size(94, 29);
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
            label4.Location = new Point(195, 70);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 3;
            label4.Text = "Protocole :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 70);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 2;
            label3.Text = "Durée de validité :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 30);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Port privé :";
            // 
            // MyIpText
            // 
            MyIpText.AutoSize = true;
            MyIpText.Location = new Point(40, 30);
            MyIpText.Name = "MyIpText";
            MyIpText.Size = new Size(62, 20);
            MyIpText.TabIndex = 1;
            MyIpText.Text = "Mon IP :";
            // 
            // MyPortText
            // 
            MyPortText.AutoSize = true;
            MyPortText.Location = new Point(232, 30);
            MyPortText.Name = "MyPortText";
            MyPortText.Size = new Size(87, 20);
            MyPortText.TabIndex = 2;
            MyPortText.Text = "Port public :";
            // 
            // ShowAO
            // 
            ShowAO.AutoSize = true;
            ShowAO.Location = new Point(40, 130);
            ShowAO.Name = "ShowAO";
            ShowAO.Size = new Size(223, 24);
            ShowAO.TabIndex = 3;
            ShowAO.TabStop = false;
            ShowAO.Text = "Afficher les options avancées";
            ShowAO.UseVisualStyleBackColor = true;
            ShowAO.CheckedChanged += ShowAO_CheckedChanged;
            // 
            // NewPublicPort
            // 
            NewPublicPort.Location = new Point(381, 26);
            NewPublicPort.Name = "NewPublicPort";
            NewPublicPort.Size = new Size(94, 29);
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
            PublicPort.Location = new Point(325, 28);
            PublicPort.MaxLength = 5;
            PublicPort.Name = "PublicPort";
            PublicPort.ReadOnly = true;
            PublicPort.Size = new Size(50, 27);
            PublicPort.TabIndex = 7;
            PublicPort.TabStop = false;
            PublicPort.Text = "00000";
            PublicPort.TextAlign = HorizontalAlignment.Center;
            PublicPort.WordWrap = false;
            // 
            // MyIp
            // 
            MyIp.BorderStyle = BorderStyle.FixedSingle;
            MyIp.Location = new Point(108, 28);
            MyIp.MaxLength = 15;
            MyIp.Name = "MyIp";
            MyIp.ReadOnly = true;
            MyIp.Size = new Size(118, 27);
            MyIp.TabIndex = 10;
            MyIp.TabStop = false;
            MyIp.Text = "00.00.000.000";
            MyIp.TextAlign = HorizontalAlignment.Center;
            ToolTipRefresh.SetToolTip(MyIp, "Autorise une IP spécifique (00.00.000.000 pour autoriser toutes les IP)");
            MyIp.WordWrap = false;
            // 
            // OpenPort
            // 
            OpenPort.Location = new Point(123, 80);
            OpenPort.Name = "OpenPort";
            OpenPort.Size = new Size(130, 29);
            OpenPort.TabIndex = 11;
            OpenPort.Text = "Ouvrir le port";
            OpenPort.UseVisualStyleBackColor = true;
            OpenPort.Click += OpenPort_Click;
            // 
            // ClosePort
            // 
            ClosePort.Location = new Point(273, 80);
            ClosePort.Name = "ClosePort";
            ClosePort.Size = new Size(130, 29);
            ClosePort.TabIndex = 12;
            ClosePort.Text = "Fermer le port";
            ClosePort.UseVisualStyleBackColor = true;
            ClosePort.Click += ClosePort_Click;
            // 
            // MainWin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 428);
            Controls.Add(ClosePort);
            Controls.Add(OpenPort);
            Controls.Add(MyIp);
            Controls.Add(PublicPort);
            Controls.Add(NewPublicPort);
            Controls.Add(ShowAO);
            Controls.Add(MyPortText);
            Controls.Add(MyIpText);
            Controls.Add(GBAO);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainWin";
            Text = "Rupee";
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
    }
}