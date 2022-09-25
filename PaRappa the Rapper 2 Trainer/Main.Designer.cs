
namespace PaRappa_the_Rapper_2_Trainer
{
    partial class Main
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
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.labelProcess = new System.Windows.Forms.Label();
            this.isProcessOpen = new System.Windows.Forms.Label();
            this.pointsBox = new System.Windows.Forms.TextBox();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.btnSetPoints = new System.Windows.Forms.Button();
            this.realCoolModeLabel = new System.Windows.Forms.Label();
            this.btnEnableRealCOOLMode = new System.Windows.Forms.Button();
            this.btnHTURealCOOLMode = new System.Windows.Forms.Button();
            this.btnDisplayCOOL = new System.Windows.Forms.Button();
            this.europeRadio = new System.Windows.Forms.RadioButton();
            this.usaRadio = new System.Windows.Forms.RadioButton();
            this.japanRadio = new System.Windows.Forms.RadioButton();
            this.regionLabel = new System.Windows.Forms.Label();
            this.cbPaRappaAI = new System.Windows.Forms.CheckBox();
            this.cbTeacherAI = new System.Windows.Forms.CheckBox();
            this.curScoreLabel = new System.Windows.Forms.Label();
            this.modeSelectionLabel = new System.Windows.Forms.Label();
            this.btnCoolMode = new System.Windows.Forms.Button();
            this.btnGoodMode = new System.Windows.Forms.Button();
            this.btnBadMode = new System.Windows.Forms.Button();
            this.btnAwfulMode = new System.Windows.Forms.Button();
            this.page1Panel = new System.Windows.Forms.Panel();
            this.diffNumber = new System.Windows.Forms.NumericUpDown();
            this.btnSetDiff = new System.Windows.Forms.Button();
            this.lessonNumLabel = new System.Windows.Forms.Label();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.customModeBox = new System.Windows.Forms.TextBox();
            this.btnUnfreeze = new System.Windows.Forms.Button();
            this.btnSetLesson = new System.Windows.Forms.Button();
            this.btnSetCustomMode = new System.Windows.Forms.Button();
            this.pageLabel = new System.Windows.Forms.Label();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.page2Panel = new System.Windows.Forms.Panel();
            this.labelSuggest = new System.Windows.Forms.Label();
            this.cbAdvancedMode = new System.Windows.Forms.CheckBox();
            this.processNameBox = new System.Windows.Forms.TextBox();
            this.barPanel = new System.Windows.Forms.Panel();
            this.barLabel = new System.Windows.Forms.Label();
            this.btnDetectRegion = new System.Windows.Forms.Button();
            this.page1Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diffNumber)).BeginInit();
            this.page2Panel.SuspendLayout();
            this.barPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            this.BGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorker_RunWorkerCompleted);
            // 
            // labelProcess
            // 
            this.labelProcess.AutoSize = true;
            this.labelProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelProcess.Location = new System.Drawing.Point(13, 13);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(70, 20);
            this.labelProcess.TabIndex = 0;
            this.labelProcess.Text = "Process:";
            // 
            // isProcessOpen
            // 
            this.isProcessOpen.AutoSize = true;
            this.isProcessOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.isProcessOpen.ForeColor = System.Drawing.Color.Red;
            this.isProcessOpen.Location = new System.Drawing.Point(80, 13);
            this.isProcessOpen.Name = "isProcessOpen";
            this.isProcessOpen.Size = new System.Drawing.Size(35, 20);
            this.isProcessOpen.TabIndex = 0;
            this.isProcessOpen.Text = "N/A";
            // 
            // pointsBox
            // 
            this.pointsBox.Location = new System.Drawing.Point(62, 8);
            this.pointsBox.MaxLength = 5;
            this.pointsBox.Name = "pointsBox";
            this.pointsBox.Size = new System.Drawing.Size(100, 20);
            this.pointsBox.TabIndex = 1;
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pointsLabel.Location = new System.Drawing.Point(5, 8);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(51, 20);
            this.pointsLabel.TabIndex = 0;
            this.pointsLabel.Text = "Score";
            // 
            // btnSetPoints
            // 
            this.btnSetPoints.Location = new System.Drawing.Point(168, 8);
            this.btnSetPoints.Name = "btnSetPoints";
            this.btnSetPoints.Size = new System.Drawing.Size(32, 20);
            this.btnSetPoints.TabIndex = 2;
            this.btnSetPoints.Text = "Set";
            this.btnSetPoints.UseVisualStyleBackColor = true;
            this.btnSetPoints.Click += new System.EventHandler(this.btnSetPoints_Click);
            // 
            // realCoolModeLabel
            // 
            this.realCoolModeLabel.AutoSize = true;
            this.realCoolModeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.realCoolModeLabel.Location = new System.Drawing.Point(4, 46);
            this.realCoolModeLabel.Name = "realCoolModeLabel";
            this.realCoolModeLabel.Size = new System.Drawing.Size(134, 20);
            this.realCoolModeLabel.TabIndex = 0;
            this.realCoolModeLabel.Text = "Real COOL Mode";
            // 
            // btnEnableRealCOOLMode
            // 
            this.btnEnableRealCOOLMode.Location = new System.Drawing.Point(145, 46);
            this.btnEnableRealCOOLMode.Name = "btnEnableRealCOOLMode";
            this.btnEnableRealCOOLMode.Size = new System.Drawing.Size(75, 23);
            this.btnEnableRealCOOLMode.TabIndex = 3;
            this.btnEnableRealCOOLMode.Text = "Enable";
            this.btnEnableRealCOOLMode.UseVisualStyleBackColor = true;
            this.btnEnableRealCOOLMode.Click += new System.EventHandler(this.btnEnableRealCOOLMode_Click);
            // 
            // btnHTURealCOOLMode
            // 
            this.btnHTURealCOOLMode.Location = new System.Drawing.Point(338, 46);
            this.btnHTURealCOOLMode.Name = "btnHTURealCOOLMode";
            this.btnHTURealCOOLMode.Size = new System.Drawing.Size(75, 23);
            this.btnHTURealCOOLMode.TabIndex = 3;
            this.btnHTURealCOOLMode.Text = "How to use?";
            this.btnHTURealCOOLMode.UseVisualStyleBackColor = true;
            this.btnHTURealCOOLMode.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDisplayCOOL
            // 
            this.btnDisplayCOOL.Location = new System.Drawing.Point(226, 46);
            this.btnDisplayCOOL.Name = "btnDisplayCOOL";
            this.btnDisplayCOOL.Size = new System.Drawing.Size(106, 23);
            this.btnDisplayCOOL.TabIndex = 3;
            this.btnDisplayCOOL.Text = "Display COOL";
            this.btnDisplayCOOL.UseVisualStyleBackColor = true;
            this.btnDisplayCOOL.Click += new System.EventHandler(this.btnDisplayCOOL_Click);
            // 
            // europeRadio
            // 
            this.europeRadio.AutoSize = true;
            this.europeRadio.Checked = true;
            this.europeRadio.Location = new System.Drawing.Point(314, 16);
            this.europeRadio.Name = "europeRadio";
            this.europeRadio.Size = new System.Drawing.Size(88, 17);
            this.europeRadio.TabIndex = 4;
            this.europeRadio.TabStop = true;
            this.europeRadio.Text = "Europe (PAL)";
            this.europeRadio.UseVisualStyleBackColor = true;
            this.europeRadio.CheckedChanged += new System.EventHandler(this.europeRadio_CheckedChanged);
            // 
            // usaRadio
            // 
            this.usaRadio.AutoSize = true;
            this.usaRadio.Location = new System.Drawing.Point(408, 16);
            this.usaRadio.Name = "usaRadio";
            this.usaRadio.Size = new System.Drawing.Size(85, 17);
            this.usaRadio.TabIndex = 4;
            this.usaRadio.Text = "USA (NTSC)";
            this.usaRadio.UseVisualStyleBackColor = true;
            this.usaRadio.CheckedChanged += new System.EventHandler(this.usaRadio_CheckedChanged);
            // 
            // japanRadio
            // 
            this.japanRadio.AutoSize = true;
            this.japanRadio.Location = new System.Drawing.Point(499, 16);
            this.japanRadio.Name = "japanRadio";
            this.japanRadio.Size = new System.Drawing.Size(100, 17);
            this.japanRadio.TabIndex = 4;
            this.japanRadio.Text = "Japan (NTSC-J)";
            this.japanRadio.UseVisualStyleBackColor = true;
            this.japanRadio.CheckedChanged += new System.EventHandler(this.japanRadio_CheckedChanged);
            // 
            // regionLabel
            // 
            this.regionLabel.AutoSize = true;
            this.regionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.regionLabel.Location = new System.Drawing.Point(12, 478);
            this.regionLabel.Name = "regionLabel";
            this.regionLabel.Size = new System.Drawing.Size(81, 13);
            this.regionLabel.TabIndex = 0;
            this.regionLabel.Text = "Current Region:";
            // 
            // cbPaRappaAI
            // 
            this.cbPaRappaAI.AutoSize = true;
            this.cbPaRappaAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbPaRappaAI.Location = new System.Drawing.Point(8, 86);
            this.cbPaRappaAI.Name = "cbPaRappaAI";
            this.cbPaRappaAI.Size = new System.Drawing.Size(115, 24);
            this.cbPaRappaAI.TabIndex = 5;
            this.cbPaRappaAI.Text = "AI PaRappa";
            this.cbPaRappaAI.UseVisualStyleBackColor = true;
            // 
            // cbTeacherAI
            // 
            this.cbTeacherAI.AutoSize = true;
            this.cbTeacherAI.Checked = true;
            this.cbTeacherAI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTeacherAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbTeacherAI.Location = new System.Drawing.Point(8, 116);
            this.cbTeacherAI.Name = "cbTeacherAI";
            this.cbTeacherAI.Size = new System.Drawing.Size(106, 24);
            this.cbTeacherAI.TabIndex = 5;
            this.cbTeacherAI.Text = "AI Teacher";
            this.cbTeacherAI.UseVisualStyleBackColor = true;
            // 
            // curScoreLabel
            // 
            this.curScoreLabel.AutoSize = true;
            this.curScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.curScoreLabel.Location = new System.Drawing.Point(232, 8);
            this.curScoreLabel.Name = "curScoreLabel";
            this.curScoreLabel.Size = new System.Drawing.Size(141, 20);
            this.curScoreLabel.TabIndex = 0;
            this.curScoreLabel.Text = "Current Score: -----";
            // 
            // modeSelectionLabel
            // 
            this.modeSelectionLabel.AutoSize = true;
            this.modeSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.modeSelectionLabel.Location = new System.Drawing.Point(5, 152);
            this.modeSelectionLabel.Name = "modeSelectionLabel";
            this.modeSelectionLabel.Size = new System.Drawing.Size(232, 20);
            this.modeSelectionLabel.TabIndex = 7;
            this.modeSelectionLabel.Text = "Mode Selector (ONLY VISUAL)";
            // 
            // btnCoolMode
            // 
            this.btnCoolMode.Location = new System.Drawing.Point(9, 175);
            this.btnCoolMode.Name = "btnCoolMode";
            this.btnCoolMode.Size = new System.Drawing.Size(75, 23);
            this.btnCoolMode.TabIndex = 8;
            this.btnCoolMode.Text = "COOL";
            this.btnCoolMode.UseVisualStyleBackColor = true;
            this.btnCoolMode.Click += new System.EventHandler(this.btnCoolMode_Click);
            // 
            // btnGoodMode
            // 
            this.btnGoodMode.Location = new System.Drawing.Point(9, 204);
            this.btnGoodMode.Name = "btnGoodMode";
            this.btnGoodMode.Size = new System.Drawing.Size(75, 23);
            this.btnGoodMode.TabIndex = 8;
            this.btnGoodMode.Text = "GOOD";
            this.btnGoodMode.UseVisualStyleBackColor = true;
            this.btnGoodMode.Click += new System.EventHandler(this.btnGoodMode_Click);
            // 
            // btnBadMode
            // 
            this.btnBadMode.Location = new System.Drawing.Point(9, 233);
            this.btnBadMode.Name = "btnBadMode";
            this.btnBadMode.Size = new System.Drawing.Size(75, 23);
            this.btnBadMode.TabIndex = 8;
            this.btnBadMode.Text = "BAD";
            this.btnBadMode.UseVisualStyleBackColor = true;
            this.btnBadMode.Click += new System.EventHandler(this.btnBadMode_Click);
            // 
            // btnAwfulMode
            // 
            this.btnAwfulMode.Location = new System.Drawing.Point(9, 262);
            this.btnAwfulMode.Name = "btnAwfulMode";
            this.btnAwfulMode.Size = new System.Drawing.Size(75, 23);
            this.btnAwfulMode.TabIndex = 8;
            this.btnAwfulMode.Text = "AWFUL";
            this.btnAwfulMode.UseVisualStyleBackColor = true;
            this.btnAwfulMode.Click += new System.EventHandler(this.btnAwfulMode_Click);
            // 
            // page1Panel
            // 
            this.page1Panel.Controls.Add(this.diffNumber);
            this.page1Panel.Controls.Add(this.btnSetDiff);
            this.page1Panel.Controls.Add(this.lessonNumLabel);
            this.page1Panel.Controls.Add(this.labelDifficulty);
            this.page1Panel.Controls.Add(this.customModeBox);
            this.page1Panel.Controls.Add(this.modeSelectionLabel);
            this.page1Panel.Controls.Add(this.btnAwfulMode);
            this.page1Panel.Controls.Add(this.pointsLabel);
            this.page1Panel.Controls.Add(this.btnBadMode);
            this.page1Panel.Controls.Add(this.curScoreLabel);
            this.page1Panel.Controls.Add(this.btnGoodMode);
            this.page1Panel.Controls.Add(this.realCoolModeLabel);
            this.page1Panel.Controls.Add(this.btnCoolMode);
            this.page1Panel.Controls.Add(this.pointsBox);
            this.page1Panel.Controls.Add(this.btnUnfreeze);
            this.page1Panel.Controls.Add(this.btnSetLesson);
            this.page1Panel.Controls.Add(this.btnSetCustomMode);
            this.page1Panel.Controls.Add(this.btnSetPoints);
            this.page1Panel.Controls.Add(this.btnEnableRealCOOLMode);
            this.page1Panel.Controls.Add(this.cbTeacherAI);
            this.page1Panel.Controls.Add(this.btnDisplayCOOL);
            this.page1Panel.Controls.Add(this.cbPaRappaAI);
            this.page1Panel.Controls.Add(this.btnHTURealCOOLMode);
            this.page1Panel.Location = new System.Drawing.Point(12, 39);
            this.page1Panel.Name = "page1Panel";
            this.page1Panel.Size = new System.Drawing.Size(587, 426);
            this.page1Panel.TabIndex = 9;
            // 
            // diffNumber
            // 
            this.diffNumber.Location = new System.Drawing.Point(130, 330);
            this.diffNumber.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.diffNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.diffNumber.Name = "diffNumber";
            this.diffNumber.Size = new System.Drawing.Size(120, 20);
            this.diffNumber.TabIndex = 16;
            this.diffNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSetDiff
            // 
            this.btnSetDiff.Location = new System.Drawing.Point(257, 330);
            this.btnSetDiff.Name = "btnSetDiff";
            this.btnSetDiff.Size = new System.Drawing.Size(33, 20);
            this.btnSetDiff.TabIndex = 15;
            this.btnSetDiff.Text = "Set";
            this.btnSetDiff.UseVisualStyleBackColor = true;
            // 
            // lessonNumLabel
            // 
            this.lessonNumLabel.AutoSize = true;
            this.lessonNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lessonNumLabel.Location = new System.Drawing.Point(9, 292);
            this.lessonNumLabel.Name = "lessonNumLabel";
            this.lessonNumLabel.Size = new System.Drawing.Size(93, 20);
            this.lessonNumLabel.TabIndex = 10;
            this.lessonNumLabel.Text = "Freeze Line";
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.AutoSize = true;
            this.labelDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDifficulty.Location = new System.Drawing.Point(9, 329);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(115, 20);
            this.labelDifficulty.TabIndex = 14;
            this.labelDifficulty.Text = "Difficulty (1-16)";
            // 
            // customModeBox
            // 
            this.customModeBox.Location = new System.Drawing.Point(236, 152);
            this.customModeBox.Name = "customModeBox";
            this.customModeBox.Size = new System.Drawing.Size(100, 20);
            this.customModeBox.TabIndex = 9;
            this.customModeBox.Visible = false;
            // 
            // btnUnfreeze
            // 
            this.btnUnfreeze.Location = new System.Drawing.Point(182, 292);
            this.btnUnfreeze.Name = "btnUnfreeze";
            this.btnUnfreeze.Size = new System.Drawing.Size(68, 20);
            this.btnUnfreeze.TabIndex = 2;
            this.btnUnfreeze.Text = "Unfreeze";
            this.btnUnfreeze.UseVisualStyleBackColor = true;
            this.btnUnfreeze.Click += new System.EventHandler(this.btnUnfreeze_Click);
            // 
            // btnSetLesson
            // 
            this.btnSetLesson.Location = new System.Drawing.Point(108, 292);
            this.btnSetLesson.Name = "btnSetLesson";
            this.btnSetLesson.Size = new System.Drawing.Size(68, 20);
            this.btnSetLesson.TabIndex = 2;
            this.btnSetLesson.Text = "Freeze";
            this.btnSetLesson.UseVisualStyleBackColor = true;
            this.btnSetLesson.Click += new System.EventHandler(this.btnSetLesson_Click);
            // 
            // btnSetCustomMode
            // 
            this.btnSetCustomMode.Location = new System.Drawing.Point(343, 152);
            this.btnSetCustomMode.Name = "btnSetCustomMode";
            this.btnSetCustomMode.Size = new System.Drawing.Size(32, 20);
            this.btnSetCustomMode.TabIndex = 2;
            this.btnSetCustomMode.Text = "Set";
            this.btnSetCustomMode.UseVisualStyleBackColor = true;
            this.btnSetCustomMode.Visible = false;
            this.btnSetCustomMode.Click += new System.EventHandler(this.btnSetCustomMode_Click);
            // 
            // pageLabel
            // 
            this.pageLabel.AutoSize = true;
            this.pageLabel.Location = new System.Drawing.Point(405, 478);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(35, 13);
            this.pageLabel.TabIndex = 10;
            this.pageLabel.Text = "Page:";
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(527, 473);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(75, 23);
            this.btnNextPage.TabIndex = 11;
            this.btnNextPage.Text = "Next Page";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.NextPageBTN);
            // 
            // page2Panel
            // 
            this.page2Panel.Controls.Add(this.labelSuggest);
            this.page2Panel.Enabled = false;
            this.page2Panel.Location = new System.Drawing.Point(12, 39);
            this.page2Panel.Name = "page2Panel";
            this.page2Panel.Size = new System.Drawing.Size(587, 426);
            this.page2Panel.TabIndex = 9;
            this.page2Panel.Visible = false;
            // 
            // labelSuggest
            // 
            this.labelSuggest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSuggest.AutoSize = true;
            this.labelSuggest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSuggest.Location = new System.Drawing.Point(126, 178);
            this.labelSuggest.Name = "labelSuggest";
            this.labelSuggest.Size = new System.Drawing.Size(339, 20);
            this.labelSuggest.TabIndex = 0;
            this.labelSuggest.Text = "Suggest features in the PTR 2 Modding server!\r\n";
            // 
            // cbAdvancedMode
            // 
            this.cbAdvancedMode.AutoSize = true;
            this.cbAdvancedMode.Location = new System.Drawing.Point(294, 477);
            this.cbAdvancedMode.Name = "cbAdvancedMode";
            this.cbAdvancedMode.Size = new System.Drawing.Size(105, 17);
            this.cbAdvancedMode.TabIndex = 12;
            this.cbAdvancedMode.Text = "Advanced Mode";
            this.cbAdvancedMode.UseVisualStyleBackColor = true;
            this.cbAdvancedMode.CheckedChanged += new System.EventHandler(this.cbAdvancedMode_CheckedChanged);
            // 
            // processNameBox
            // 
            this.processNameBox.Location = new System.Drawing.Point(188, 475);
            this.processNameBox.Name = "processNameBox";
            this.processNameBox.Size = new System.Drawing.Size(100, 20);
            this.processNameBox.TabIndex = 13;
            this.processNameBox.Text = "pcsx2";
            this.processNameBox.Visible = false;
            this.processNameBox.TextChanged += new System.EventHandler(this.processNameBox_TextChanged);
            // 
            // barPanel
            // 
            this.barPanel.BackColor = System.Drawing.Color.Blue;
            this.barPanel.Controls.Add(this.barLabel);
            this.barPanel.Enabled = false;
            this.barPanel.Location = new System.Drawing.Point(-6, 502);
            this.barPanel.Name = "barPanel";
            this.barPanel.Size = new System.Drawing.Size(625, 24);
            this.barPanel.TabIndex = 14;
            // 
            // barLabel
            // 
            this.barLabel.AutoSize = true;
            this.barLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.barLabel.Location = new System.Drawing.Point(12, 5);
            this.barLabel.Name = "barLabel";
            this.barLabel.Size = new System.Drawing.Size(78, 13);
            this.barLabel.TabIndex = 0;
            this.barLabel.Text = "Information Bar";
            this.barLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.barLabel.Visible = false;
            // 
            // btnDetectRegion
            // 
            this.btnDetectRegion.Location = new System.Drawing.Point(259, 13);
            this.btnDetectRegion.Name = "btnDetectRegion";
            this.btnDetectRegion.Size = new System.Drawing.Size(49, 23);
            this.btnDetectRegion.TabIndex = 15;
            this.btnDetectRegion.Text = "Detect";
            this.btnDetectRegion.UseVisualStyleBackColor = true;
            this.btnDetectRegion.Click += new System.EventHandler(this.DetectRegion);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 523);
            this.Controls.Add(this.btnDetectRegion);
            this.Controls.Add(this.barPanel);
            this.Controls.Add(this.processNameBox);
            this.Controls.Add(this.cbAdvancedMode);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.pageLabel);
            this.Controls.Add(this.japanRadio);
            this.Controls.Add(this.usaRadio);
            this.Controls.Add(this.europeRadio);
            this.Controls.Add(this.isProcessOpen);
            this.Controls.Add(this.regionLabel);
            this.Controls.Add(this.labelProcess);
            this.Controls.Add(this.page2Panel);
            this.Controls.Add(this.page1Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "PTR2 Trainer v.1.0";
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.page1Panel.ResumeLayout(false);
            this.page1Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diffNumber)).EndInit();
            this.page2Panel.ResumeLayout(false);
            this.page2Panel.PerformLayout();
            this.barPanel.ResumeLayout(false);
            this.barPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker BGWorker;
        private System.Windows.Forms.Label labelProcess;
        private System.Windows.Forms.Label isProcessOpen;
        private System.Windows.Forms.TextBox pointsBox;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Button btnSetPoints;
        private System.Windows.Forms.Label realCoolModeLabel;
        private System.Windows.Forms.Button btnEnableRealCOOLMode;
        private System.Windows.Forms.Button btnHTURealCOOLMode;
        private System.Windows.Forms.Button btnDisplayCOOL;
        private System.Windows.Forms.RadioButton europeRadio;
        private System.Windows.Forms.RadioButton usaRadio;
        private System.Windows.Forms.RadioButton japanRadio;
        private System.Windows.Forms.Label regionLabel;
        private System.Windows.Forms.CheckBox cbPaRappaAI;
        private System.Windows.Forms.CheckBox cbTeacherAI;
        private System.Windows.Forms.Label curScoreLabel;
        private System.Windows.Forms.Label modeSelectionLabel;
        private System.Windows.Forms.Button btnCoolMode;
        private System.Windows.Forms.Button btnGoodMode;
        private System.Windows.Forms.Button btnBadMode;
        private System.Windows.Forms.Button btnAwfulMode;
        private System.Windows.Forms.Panel page1Panel;
        private System.Windows.Forms.Label pageLabel;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Panel page2Panel;
        private System.Windows.Forms.CheckBox cbAdvancedMode;
        private System.Windows.Forms.TextBox customModeBox;
        private System.Windows.Forms.Button btnSetCustomMode;
        private System.Windows.Forms.Label lessonNumLabel;
        private System.Windows.Forms.Button btnSetLesson;
        private System.Windows.Forms.Button btnUnfreeze;
        private System.Windows.Forms.TextBox processNameBox;
        private System.Windows.Forms.NumericUpDown diffNumber;
        private System.Windows.Forms.Button btnSetDiff;
        private System.Windows.Forms.Label labelDifficulty;
        private System.Windows.Forms.Label labelSuggest;
        private System.Windows.Forms.Panel barPanel;
        private System.Windows.Forms.Label barLabel;
        private System.Windows.Forms.Button btnDetectRegion;
    }
}

