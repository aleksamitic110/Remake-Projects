namespace Slagalica.Forms
{
    partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			Panel_Main_Welcom = new Panel();
			pictureBoxStartingImage = new PictureBox();
			labelMainHeader = new Label();
			buttonStartGame = new Button();
			buttonTraining = new Button();
			buttonExplanation = new Button();
			buttonExit = new Button();
			rdButtonSrpski = new RadioButton();
			rdBtnEnglish = new RadioButton();
			Panel_Main_Welcom.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBoxStartingImage).BeginInit();
			SuspendLayout();
			// 
			// Panel_Main_Welcom
			// 
			Panel_Main_Welcom.Controls.Add(pictureBoxStartingImage);
			Panel_Main_Welcom.Controls.Add(labelMainHeader);
			Panel_Main_Welcom.Location = new Point(12, 12);
			Panel_Main_Welcom.Name = "Panel_Main_Welcom";
			Panel_Main_Welcom.Size = new Size(528, 210);
			Panel_Main_Welcom.TabIndex = 0;
			// 
			// pictureBoxStartingImage
			// 
			pictureBoxStartingImage.BackgroundImageLayout = ImageLayout.Stretch;
			pictureBoxStartingImage.Image = (Image)resources.GetObject("pictureBoxStartingImage.Image");
			pictureBoxStartingImage.Location = new Point(186, 72);
			pictureBoxStartingImage.Name = "pictureBoxStartingImage";
			pictureBoxStartingImage.Size = new Size(155, 118);
			pictureBoxStartingImage.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBoxStartingImage.TabIndex = 1;
			pictureBoxStartingImage.TabStop = false;
			// 
			// labelMainHeader
			// 
			labelMainHeader.AutoSize = true;
			labelMainHeader.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelMainHeader.Location = new Point(154, 9);
			labelMainHeader.Name = "labelMainHeader";
			labelMainHeader.Size = new Size(226, 60);
			labelMainHeader.TabIndex = 0;
			labelMainHeader.Text = "SLAGALICA";
			labelMainHeader.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// buttonStartGame
			// 
			buttonStartGame.FlatStyle = FlatStyle.Flat;
			buttonStartGame.Font = new Font("MV Boli", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			buttonStartGame.Location = new Point(133, 237);
			buttonStartGame.Name = "buttonStartGame";
			buttonStartGame.Size = new Size(288, 68);
			buttonStartGame.TabIndex = 1;
			buttonStartGame.Text = "Start game";
			buttonStartGame.UseVisualStyleBackColor = true;
			buttonStartGame.Click += buttonStartGame_Click;
			buttonStartGame.MouseEnter += Button_Hover_Enter;
			buttonStartGame.MouseLeave += Button_Hover_Leave;
			// 
			// buttonTraining
			// 
			buttonTraining.FlatStyle = FlatStyle.Flat;
			buttonTraining.Font = new Font("MV Boli", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			buttonTraining.Location = new Point(133, 327);
			buttonTraining.Name = "buttonTraining";
			buttonTraining.Size = new Size(288, 68);
			buttonTraining.TabIndex = 2;
			buttonTraining.Text = "Training";
			buttonTraining.UseVisualStyleBackColor = true;
			buttonTraining.MouseEnter += Button_Hover_Enter;
			buttonTraining.MouseLeave += Button_Hover_Leave;
			// 
			// buttonExplanation
			// 
			buttonExplanation.FlatStyle = FlatStyle.Flat;
			buttonExplanation.Font = new Font("MV Boli", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			buttonExplanation.Location = new Point(133, 417);
			buttonExplanation.Name = "buttonExplanation";
			buttonExplanation.Size = new Size(288, 68);
			buttonExplanation.TabIndex = 3;
			buttonExplanation.Text = "Explanation ";
			buttonExplanation.UseVisualStyleBackColor = true;
			buttonExplanation.MouseEnter += Button_Hover_Enter;
			buttonExplanation.MouseLeave += Button_Hover_Leave;
			// 
			// buttonExit
			// 
			buttonExit.FlatStyle = FlatStyle.Flat;
			buttonExit.Font = new Font("MV Boli", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			buttonExit.Location = new Point(133, 551);
			buttonExit.Name = "buttonExit";
			buttonExit.Size = new Size(288, 68);
			buttonExit.TabIndex = 4;
			buttonExit.Text = "Exit";
			buttonExit.UseVisualStyleBackColor = true;
			buttonExit.Click += buttonExit_Click;
			// 
			// rdButtonSrpski
			// 
			rdButtonSrpski.AutoSize = true;
			rdButtonSrpski.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			rdButtonSrpski.Location = new Point(133, 500);
			rdButtonSrpski.Name = "rdButtonSrpski";
			rdButtonSrpski.Size = new Size(91, 34);
			rdButtonSrpski.TabIndex = 5;
			rdButtonSrpski.TabStop = true;
			rdButtonSrpski.Text = "Srpski";
			rdButtonSrpski.UseVisualStyleBackColor = true;
			// 
			// rdBtnEnglish
			// 
			rdBtnEnglish.AutoSize = true;
			rdBtnEnglish.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			rdBtnEnglish.Location = new Point(319, 500);
			rdBtnEnglish.Name = "rdBtnEnglish";
			rdBtnEnglish.Size = new Size(102, 34);
			rdBtnEnglish.TabIndex = 6;
			rdBtnEnglish.TabStop = true;
			rdBtnEnglish.Text = "English";
			rdBtnEnglish.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			BackColor = Color.SteelBlue;
			ClientSize = new Size(552, 631);
			ControlBox = false;
			Controls.Add(rdBtnEnglish);
			Controls.Add(rdButtonSrpski);
			Controls.Add(buttonExit);
			Controls.Add(buttonExplanation);
			Controls.Add(buttonTraining);
			Controls.Add(buttonStartGame);
			Controls.Add(Panel_Main_Welcom);
			ForeColor = SystemColors.ActiveCaptionText;
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Slagalica";
			TransparencyKey = Color.Cyan;
			Panel_Main_Welcom.ResumeLayout(false);
			Panel_Main_Welcom.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBoxStartingImage).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel Panel_Main_Welcom;
		private Label labelMainHeader;
		private PictureBox pictureBoxStartingImage;
		private Button buttonStartGame;
		private Button buttonTraining;
		private Button buttonExplanation;
		private Button buttonExit;
		private RadioButton rdButtonSrpski;
		private RadioButton rdBtnEnglish;
	}
}
