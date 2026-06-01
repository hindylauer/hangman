namespace Hangman_App
{
    partial class frmHangman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHangman));
            tblMain = new TableLayoutPanel();
            tblTop = new TableLayoutPanel();
            btnStart = new Button();
            lblLetterAmount = new Label();
            txtLetterAmount = new TextBox();
            lblStatus = new Label();
            tblMiddle = new TableLayoutPanel();
            tblAlphabet = new TableLayoutPanel();
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            btnD = new Button();
            btnE = new Button();
            btnF = new Button();
            btnG = new Button();
            btnH = new Button();
            btnI = new Button();
            btnJ = new Button();
            btnK = new Button();
            btnL = new Button();
            btnM = new Button();
            btnN = new Button();
            btnO = new Button();
            btnP = new Button();
            btnQ = new Button();
            btnR = new Button();
            btnS = new Button();
            btnT = new Button();
            btnU = new Button();
            btnV = new Button();
            btnW = new Button();
            btnX = new Button();
            btnY = new Button();
            btnZ = new Button();
            btnBlank = new Button();
            pnlMan = new Panel();
            picHangman = new PictureBox();
            tblLabels = new TableLayoutPanel();
            tblMain.SuspendLayout();
            tblTop.SuspendLayout();
            tblMiddle.SuspendLayout();
            tblAlphabet.SuspendLayout();
            pnlMan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHangman).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.BackColor = SystemColors.Control;
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(tblTop, 0, 0);
            tblMain.Controls.Add(tblMiddle, 0, 1);
            tblMain.Controls.Add(tblLabels, 0, 2);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 3;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 9.90099049F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 72.27723F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 17.8217831F));
            tblMain.Size = new Size(1027, 640);
            tblMain.TabIndex = 0;
            // 
            // tblTop
            // 
            tblTop.ColumnCount = 4;
            tblTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tblTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            tblTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tblTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51F));
            tblTop.Controls.Add(btnStart, 0, 0);
            tblTop.Controls.Add(lblLetterAmount, 1, 0);
            tblTop.Controls.Add(txtLetterAmount, 2, 0);
            tblTop.Controls.Add(lblStatus, 3, 0);
            tblTop.Dock = DockStyle.Fill;
            tblTop.Location = new Point(3, 3);
            tblTop.Name = "tblTop";
            tblTop.RowCount = 1;
            tblTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblTop.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblTop.Size = new Size(1021, 57);
            tblTop.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.Dock = DockStyle.Fill;
            btnStart.Location = new Point(3, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(147, 51);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // lblLetterAmount
            // 
            lblLetterAmount.Dock = DockStyle.Fill;
            lblLetterAmount.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLetterAmount.Location = new Point(156, 0);
            lblLetterAmount.Name = "lblLetterAmount";
            lblLetterAmount.Size = new Size(239, 57);
            lblLetterAmount.TabIndex = 1;
            lblLetterAmount.Text = "Amount of letters(3-10)";
            lblLetterAmount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtLetterAmount
            // 
            txtLetterAmount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtLetterAmount.Location = new Point(401, 15);
            txtLetterAmount.MaxLength = 2;
            txtLetterAmount.Name = "txtLetterAmount";
            txtLetterAmount.PlaceholderText = "Before Start";
            txtLetterAmount.Size = new Size(96, 27);
            txtLetterAmount.TabIndex = 2;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(503, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(515, 57);
            lblStatus.TabIndex = 3;
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblMiddle
            // 
            tblMiddle.ColumnCount = 2;
            tblMiddle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tblMiddle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tblMiddle.Controls.Add(tblAlphabet, 1, 0);
            tblMiddle.Controls.Add(pnlMan, 0, 0);
            tblMiddle.Dock = DockStyle.Fill;
            tblMiddle.Location = new Point(3, 66);
            tblMiddle.Name = "tblMiddle";
            tblMiddle.RowCount = 2;
            tblMiddle.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMiddle.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMiddle.Size = new Size(1021, 456);
            tblMiddle.TabIndex = 1;
            // 
            // tblAlphabet
            // 
            tblAlphabet.BackColor = SystemColors.Control;
            tblAlphabet.ColumnCount = 9;
            tblAlphabet.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11111F));
            tblAlphabet.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblAlphabet.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblAlphabet.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblAlphabet.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblAlphabet.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblAlphabet.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblAlphabet.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblAlphabet.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblAlphabet.Controls.Add(btnA, 0, 0);
            tblAlphabet.Controls.Add(btnB, 1, 0);
            tblAlphabet.Controls.Add(btnC, 2, 0);
            tblAlphabet.Controls.Add(btnD, 3, 0);
            tblAlphabet.Controls.Add(btnE, 4, 0);
            tblAlphabet.Controls.Add(btnF, 5, 0);
            tblAlphabet.Controls.Add(btnG, 6, 0);
            tblAlphabet.Controls.Add(btnH, 7, 0);
            tblAlphabet.Controls.Add(btnI, 8, 0);
            tblAlphabet.Controls.Add(btnJ, 0, 1);
            tblAlphabet.Controls.Add(btnK, 1, 1);
            tblAlphabet.Controls.Add(btnL, 2, 1);
            tblAlphabet.Controls.Add(btnM, 3, 1);
            tblAlphabet.Controls.Add(btnN, 4, 1);
            tblAlphabet.Controls.Add(btnO, 5, 1);
            tblAlphabet.Controls.Add(btnP, 6, 1);
            tblAlphabet.Controls.Add(btnQ, 7, 1);
            tblAlphabet.Controls.Add(btnR, 8, 1);
            tblAlphabet.Controls.Add(btnS, 0, 2);
            tblAlphabet.Controls.Add(btnT, 1, 2);
            tblAlphabet.Controls.Add(btnU, 2, 2);
            tblAlphabet.Controls.Add(btnV, 3, 2);
            tblAlphabet.Controls.Add(btnW, 4, 2);
            tblAlphabet.Controls.Add(btnX, 5, 2);
            tblAlphabet.Controls.Add(btnY, 6, 2);
            tblAlphabet.Controls.Add(btnZ, 7, 2);
            tblAlphabet.Controls.Add(btnBlank, 8, 2);
            tblAlphabet.Dock = DockStyle.Fill;
            tblAlphabet.Location = new Point(360, 3);
            tblAlphabet.Name = "tblAlphabet";
            tblAlphabet.RowCount = 3;
            tblAlphabet.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblAlphabet.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblAlphabet.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblAlphabet.Size = new Size(658, 222);
            tblAlphabet.TabIndex = 0;
            // 
            // btnA
            // 
            btnA.Dock = DockStyle.Fill;
            btnA.Location = new Point(3, 3);
            btnA.Name = "btnA";
            btnA.Size = new Size(67, 67);
            btnA.TabIndex = 1;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = true;
            // 
            // btnB
            // 
            btnB.Dock = DockStyle.Fill;
            btnB.Location = new Point(76, 3);
            btnB.Name = "btnB";
            btnB.Size = new Size(67, 67);
            btnB.TabIndex = 2;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            btnC.Dock = DockStyle.Fill;
            btnC.Location = new Point(149, 3);
            btnC.Name = "btnC";
            btnC.Size = new Size(67, 67);
            btnC.TabIndex = 3;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            // 
            // btnD
            // 
            btnD.Dock = DockStyle.Fill;
            btnD.Location = new Point(222, 3);
            btnD.Name = "btnD";
            btnD.Size = new Size(67, 67);
            btnD.TabIndex = 4;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = true;
            // 
            // btnE
            // 
            btnE.Dock = DockStyle.Fill;
            btnE.Location = new Point(295, 3);
            btnE.Name = "btnE";
            btnE.Size = new Size(67, 67);
            btnE.TabIndex = 5;
            btnE.Text = "E";
            btnE.UseVisualStyleBackColor = true;
            // 
            // btnF
            // 
            btnF.Dock = DockStyle.Fill;
            btnF.Location = new Point(368, 3);
            btnF.Name = "btnF";
            btnF.Size = new Size(67, 67);
            btnF.TabIndex = 6;
            btnF.Text = "F";
            btnF.UseVisualStyleBackColor = true;
            // 
            // btnG
            // 
            btnG.Dock = DockStyle.Fill;
            btnG.Location = new Point(441, 3);
            btnG.Name = "btnG";
            btnG.Size = new Size(67, 67);
            btnG.TabIndex = 7;
            btnG.Text = "G";
            btnG.UseVisualStyleBackColor = true;
            // 
            // btnH
            // 
            btnH.Dock = DockStyle.Fill;
            btnH.Location = new Point(514, 3);
            btnH.Name = "btnH";
            btnH.Size = new Size(67, 67);
            btnH.TabIndex = 8;
            btnH.Text = "H";
            btnH.UseVisualStyleBackColor = true;
            // 
            // btnI
            // 
            btnI.Dock = DockStyle.Fill;
            btnI.Location = new Point(587, 3);
            btnI.Name = "btnI";
            btnI.Size = new Size(68, 67);
            btnI.TabIndex = 9;
            btnI.Text = "I";
            btnI.UseVisualStyleBackColor = true;
            // 
            // btnJ
            // 
            btnJ.Dock = DockStyle.Fill;
            btnJ.Location = new Point(3, 76);
            btnJ.Name = "btnJ";
            btnJ.Size = new Size(67, 67);
            btnJ.TabIndex = 10;
            btnJ.Text = "J";
            btnJ.UseVisualStyleBackColor = true;
            // 
            // btnK
            // 
            btnK.Dock = DockStyle.Fill;
            btnK.Location = new Point(76, 76);
            btnK.Name = "btnK";
            btnK.Size = new Size(67, 67);
            btnK.TabIndex = 11;
            btnK.Text = "K";
            btnK.UseVisualStyleBackColor = true;
            // 
            // btnL
            // 
            btnL.Dock = DockStyle.Fill;
            btnL.Location = new Point(149, 76);
            btnL.Name = "btnL";
            btnL.Size = new Size(67, 67);
            btnL.TabIndex = 12;
            btnL.Text = "L";
            btnL.UseVisualStyleBackColor = true;
            // 
            // btnM
            // 
            btnM.Dock = DockStyle.Fill;
            btnM.Location = new Point(222, 76);
            btnM.Name = "btnM";
            btnM.Size = new Size(67, 67);
            btnM.TabIndex = 13;
            btnM.Text = "M";
            btnM.UseVisualStyleBackColor = true;
            // 
            // btnN
            // 
            btnN.Dock = DockStyle.Fill;
            btnN.Location = new Point(295, 76);
            btnN.Name = "btnN";
            btnN.Size = new Size(67, 67);
            btnN.TabIndex = 14;
            btnN.Text = "N";
            btnN.UseVisualStyleBackColor = true;
            // 
            // btnO
            // 
            btnO.Dock = DockStyle.Fill;
            btnO.Location = new Point(368, 76);
            btnO.Name = "btnO";
            btnO.Size = new Size(67, 67);
            btnO.TabIndex = 15;
            btnO.Text = "O";
            btnO.UseVisualStyleBackColor = true;
            // 
            // btnP
            // 
            btnP.Dock = DockStyle.Fill;
            btnP.Location = new Point(441, 76);
            btnP.Name = "btnP";
            btnP.Size = new Size(67, 67);
            btnP.TabIndex = 16;
            btnP.Text = "P";
            btnP.UseVisualStyleBackColor = true;
            // 
            // btnQ
            // 
            btnQ.Dock = DockStyle.Fill;
            btnQ.Location = new Point(514, 76);
            btnQ.Name = "btnQ";
            btnQ.Size = new Size(67, 67);
            btnQ.TabIndex = 17;
            btnQ.Text = "Q";
            btnQ.UseVisualStyleBackColor = true;
            // 
            // btnR
            // 
            btnR.Dock = DockStyle.Fill;
            btnR.Location = new Point(587, 76);
            btnR.Name = "btnR";
            btnR.Size = new Size(68, 67);
            btnR.TabIndex = 18;
            btnR.Text = "R";
            btnR.UseVisualStyleBackColor = true;
            // 
            // btnS
            // 
            btnS.Dock = DockStyle.Fill;
            btnS.Location = new Point(3, 149);
            btnS.Name = "btnS";
            btnS.Size = new Size(67, 70);
            btnS.TabIndex = 19;
            btnS.Text = "S";
            btnS.UseVisualStyleBackColor = true;
            // 
            // btnT
            // 
            btnT.Dock = DockStyle.Fill;
            btnT.Location = new Point(76, 149);
            btnT.Name = "btnT";
            btnT.Size = new Size(67, 70);
            btnT.TabIndex = 20;
            btnT.Text = "T";
            btnT.UseVisualStyleBackColor = true;
            // 
            // btnU
            // 
            btnU.Dock = DockStyle.Fill;
            btnU.Location = new Point(149, 149);
            btnU.Name = "btnU";
            btnU.Size = new Size(67, 70);
            btnU.TabIndex = 21;
            btnU.Text = "U";
            btnU.UseVisualStyleBackColor = true;
            // 
            // btnV
            // 
            btnV.Dock = DockStyle.Fill;
            btnV.Location = new Point(222, 149);
            btnV.Name = "btnV";
            btnV.Size = new Size(67, 70);
            btnV.TabIndex = 22;
            btnV.Text = "V";
            btnV.UseVisualStyleBackColor = true;
            // 
            // btnW
            // 
            btnW.Dock = DockStyle.Fill;
            btnW.Location = new Point(295, 149);
            btnW.Name = "btnW";
            btnW.Size = new Size(67, 70);
            btnW.TabIndex = 23;
            btnW.Text = "W";
            btnW.UseVisualStyleBackColor = true;
            // 
            // btnX
            // 
            btnX.Dock = DockStyle.Fill;
            btnX.Location = new Point(368, 149);
            btnX.Name = "btnX";
            btnX.Size = new Size(67, 70);
            btnX.TabIndex = 24;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = true;
            // 
            // btnY
            // 
            btnY.Dock = DockStyle.Fill;
            btnY.Location = new Point(441, 149);
            btnY.Name = "btnY";
            btnY.Size = new Size(67, 70);
            btnY.TabIndex = 25;
            btnY.Text = "Y";
            btnY.UseVisualStyleBackColor = true;
            // 
            // btnZ
            // 
            btnZ.Dock = DockStyle.Fill;
            btnZ.Location = new Point(514, 149);
            btnZ.Name = "btnZ";
            btnZ.Size = new Size(67, 70);
            btnZ.TabIndex = 26;
            btnZ.Text = "Z";
            btnZ.UseVisualStyleBackColor = true;
            // 
            // btnBlank
            // 
            btnBlank.Dock = DockStyle.Fill;
            btnBlank.Enabled = false;
            btnBlank.Location = new Point(587, 149);
            btnBlank.Name = "btnBlank";
            btnBlank.Size = new Size(68, 70);
            btnBlank.TabIndex = 27;
            btnBlank.UseVisualStyleBackColor = true;
            // 
            // pnlMan
            // 
            pnlMan.Controls.Add(picHangman);
            pnlMan.Dock = DockStyle.Fill;
            pnlMan.Location = new Point(3, 3);
            pnlMan.Name = "pnlMan";
            tblMiddle.SetRowSpan(pnlMan, 2);
            pnlMan.Size = new Size(351, 450);
            pnlMan.TabIndex = 1;
            // 
            // picHangman
            // 
            picHangman.Dock = DockStyle.Fill;
            picHangman.Location = new Point(0, 0);
            picHangman.Name = "picHangman";
            picHangman.Size = new Size(351, 450);
            picHangman.SizeMode = PictureBoxSizeMode.Zoom;
            picHangman.TabIndex = 0;
            picHangman.TabStop = false;
            // 
            // tblLabels
            // 
            tblLabels.ColumnCount = 1;
            tblLabels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblLabels.Dock = DockStyle.Fill;
            tblLabels.Location = new Point(3, 528);
            tblLabels.Name = "tblLabels";
            tblLabels.RowCount = 1;
            tblLabels.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblLabels.Size = new Size(1021, 109);
            tblLabels.TabIndex = 2;
            // 
            // frmHangman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 640);
            Controls.Add(tblMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmHangman";
            Text = "Hangman";
            tblMain.ResumeLayout(false);
            tblTop.ResumeLayout(false);
            tblTop.PerformLayout();
            tblMiddle.ResumeLayout(false);
            tblAlphabet.ResumeLayout(false);
            pnlMan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picHangman).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblTop;
        private Button btnStart;
        private Label lblLetterAmount;
        private TextBox txtLetterAmount;
        private Label lblStatus;
        private TableLayoutPanel tblMiddle;
        private TableLayoutPanel tblAlphabet;
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private Button btnE;
        private Button btnF;
        private Button btnG;
        private Button btnH;
        private Button btnI;
        private Button btnJ;
        private Button btnK;
        private Button btnL;
        private Button btnM;
        private Button btnN;
        private Button btnO;
        private Button btnP;
        private Button btnQ;
        private Button btnR;
        private Button btnS;
        private Button btnT;
        private Button btnU;
        private Button btnV;
        private Button btnW;
        private Button btnX;
        private Button btnY;
        private Button btnZ;
        private Button btnBlank;
        private Panel pnlMan;
        private PictureBox picHangman;
        private TableLayoutPanel tblLabels;
    }
}