namespace Slagalica.Forms
{
	partial class WordsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordsForm));
			labelWordsHeader = new Label();
			Panel_Letters = new Panel();
			buttonDeleteAllLetters = new Button();
			buttonBackspaceLetter = new Button();
			buttonAcceptWord = new Button();
			buttonAnswerLetter12 = new Button();
			buttonAnswerLetter11 = new Button();
			buttonAnswerLetter10 = new Button();
			buttonAnswerLetter9 = new Button();
			buttonAnswerLetter8 = new Button();
			buttonAnswerLetter7 = new Button();
			buttonAnswerLetter6 = new Button();
			buttonAnswerLetter5 = new Button();
			buttonAnswerLetter4 = new Button();
			buttonAnswerLetter3 = new Button();
			buttonAnswerLetter2 = new Button();
			buttonAnswerLetter1 = new Button();
			buttonLetter12 = new Button();
			buttonLetter11 = new Button();
			buttonLetter10 = new Button();
			buttonLetter9 = new Button();
			buttonLetter8 = new Button();
			buttonLetter7 = new Button();
			buttonLetter6 = new Button();
			buttonLetter5 = new Button();
			buttonLetter4 = new Button();
			buttonLetter3 = new Button();
			buttonLetter2 = new Button();
			buttonLetter1 = new Button();
			buttonBack = new Button();
			Panel_Letters.SuspendLayout();
			SuspendLayout();
			// 
			// labelWordsHeader
			// 
			labelWordsHeader.AutoSize = true;
			labelWordsHeader.Font = new Font("Yu Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			labelWordsHeader.Location = new Point(310, 9);
			labelWordsHeader.Name = "labelWordsHeader";
			labelWordsHeader.Size = new Size(189, 61);
			labelWordsHeader.TabIndex = 0;
			labelWordsHeader.Text = "SLOVA";
			// 
			// Panel_Letters
			// 
			Panel_Letters.Controls.Add(buttonDeleteAllLetters);
			Panel_Letters.Controls.Add(buttonBackspaceLetter);
			Panel_Letters.Controls.Add(buttonAcceptWord);
			Panel_Letters.Controls.Add(buttonAnswerLetter12);
			Panel_Letters.Controls.Add(buttonAnswerLetter11);
			Panel_Letters.Controls.Add(buttonAnswerLetter10);
			Panel_Letters.Controls.Add(buttonAnswerLetter9);
			Panel_Letters.Controls.Add(buttonAnswerLetter8);
			Panel_Letters.Controls.Add(buttonAnswerLetter7);
			Panel_Letters.Controls.Add(buttonAnswerLetter6);
			Panel_Letters.Controls.Add(buttonAnswerLetter5);
			Panel_Letters.Controls.Add(buttonAnswerLetter4);
			Panel_Letters.Controls.Add(buttonAnswerLetter3);
			Panel_Letters.Controls.Add(buttonAnswerLetter2);
			Panel_Letters.Controls.Add(buttonAnswerLetter1);
			Panel_Letters.Controls.Add(buttonLetter12);
			Panel_Letters.Controls.Add(buttonLetter11);
			Panel_Letters.Controls.Add(buttonLetter10);
			Panel_Letters.Controls.Add(buttonLetter9);
			Panel_Letters.Controls.Add(buttonLetter8);
			Panel_Letters.Controls.Add(buttonLetter7);
			Panel_Letters.Controls.Add(buttonLetter6);
			Panel_Letters.Controls.Add(buttonLetter5);
			Panel_Letters.Controls.Add(buttonLetter4);
			Panel_Letters.Controls.Add(buttonLetter3);
			Panel_Letters.Controls.Add(buttonLetter2);
			Panel_Letters.Controls.Add(buttonLetter1);
			Panel_Letters.Location = new Point(12, 73);
			Panel_Letters.Name = "Panel_Letters";
			Panel_Letters.Size = new Size(776, 386);
			Panel_Letters.TabIndex = 1;
			// 
			// buttonDeleteAllLetters
			// 
			buttonDeleteAllLetters.BackgroundImageLayout = ImageLayout.Stretch;
			buttonDeleteAllLetters.FlatAppearance.MouseOverBackColor = Color.Red;
			buttonDeleteAllLetters.FlatStyle = FlatStyle.Flat;
			buttonDeleteAllLetters.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonDeleteAllLetters.Location = new Point(584, 321);
			buttonDeleteAllLetters.Name = "buttonDeleteAllLetters";
			buttonDeleteAllLetters.Size = new Size(177, 55);
			buttonDeleteAllLetters.TabIndex = 26;
			buttonDeleteAllLetters.Text = "Delete all";
			buttonDeleteAllLetters.UseVisualStyleBackColor = true;
			buttonDeleteAllLetters.Click += buttonDeleteAllLetters_Click;
			// 
			// buttonBackspaceLetter
			// 
			buttonBackspaceLetter.BackgroundImageLayout = ImageLayout.Stretch;
			buttonBackspaceLetter.FlatAppearance.MouseDownBackColor = Color.Yellow;
			buttonBackspaceLetter.FlatAppearance.MouseOverBackColor = Color.Yellow;
			buttonBackspaceLetter.FlatStyle = FlatStyle.Flat;
			buttonBackspaceLetter.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonBackspaceLetter.Location = new Point(584, 260);
			buttonBackspaceLetter.Name = "buttonBackspaceLetter";
			buttonBackspaceLetter.Size = new Size(177, 55);
			buttonBackspaceLetter.TabIndex = 25;
			buttonBackspaceLetter.Text = "Backspace";
			buttonBackspaceLetter.UseVisualStyleBackColor = true;
			buttonBackspaceLetter.Click += buttonBackspaceLetter_Click;
			// 
			// buttonAcceptWord
			// 
			buttonAcceptWord.BackgroundImageLayout = ImageLayout.Stretch;
			buttonAcceptWord.FlatAppearance.MouseDownBackColor = Color.Lime;
			buttonAcceptWord.FlatAppearance.MouseOverBackColor = Color.Lime;
			buttonAcceptWord.FlatStyle = FlatStyle.Flat;
			buttonAcceptWord.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonAcceptWord.Location = new Point(279, 283);
			buttonAcceptWord.Name = "buttonAcceptWord";
			buttonAcceptWord.Size = new Size(238, 55);
			buttonAcceptWord.TabIndex = 24;
			buttonAcceptWord.Text = "Accept word";
			buttonAcceptWord.UseVisualStyleBackColor = true;
			// 
			// buttonAnswerLetter12
			// 
			buttonAnswerLetter12.BackColor = Color.SteelBlue;
			buttonAnswerLetter12.FlatStyle = FlatStyle.Flat;
			buttonAnswerLetter12.Font = new Font("Yu Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonAnswerLetter12.Location = new Point(706, 189);
			buttonAnswerLetter12.Name = "buttonAnswerLetter12";
			buttonAnswerLetter12.Size = new Size(55, 65);
			buttonAnswerLetter12.TabIndex = 23;
			buttonAnswerLetter12.TabStop = false;
			buttonAnswerLetter12.UseVisualStyleBackColor = false;
			// 
			// buttonAnswerLetter11
			// 
			buttonAnswerLetter11.BackColor = Color.SteelBlue;
			buttonAnswerLetter11.FlatStyle = FlatStyle.Flat;
			buttonAnswerLetter11.Font = new Font("Yu Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonAnswerLetter11.Location = new Point(645, 189);
			buttonAnswerLetter11.Name = "buttonAnswerLetter11";
			buttonAnswerLetter11.Size = new Size(55, 65);
			buttonAnswerLetter11.TabIndex = 22;
			buttonAnswerLetter11.TabStop = false;
			buttonAnswerLetter11.UseVisualStyleBackColor = false;
			// 
			// buttonAnswerLetter10
			// 
			buttonAnswerLetter10.BackColor = Color.SteelBlue;
			buttonAnswerLetter10.FlatStyle = FlatStyle.Flat;
			buttonAnswerLetter10.Font = new Font("Yu Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonAnswerLetter10.Location = new Point(584, 189);
			buttonAnswerLetter10.Name = "buttonAnswerLetter10";
			buttonAnswerLetter10.Size = new Size(55, 65);
			buttonAnswerLetter10.TabIndex = 21;
			buttonAnswerLetter10.TabStop = false;
			buttonAnswerLetter10.UseVisualStyleBackColor = false;
			// 
			// buttonAnswerLetter9
			// 
			buttonAnswerLetter9.BackColor = Color.SteelBlue;
			buttonAnswerLetter9.FlatStyle = FlatStyle.Flat;
			buttonAnswerLetter9.Font = new Font("Yu Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonAnswerLetter9.Location = new Point(523, 189);
			buttonAnswerLetter9.Name = "buttonAnswerLetter9";
			buttonAnswerLetter9.Size = new Size(55, 65);
			buttonAnswerLetter9.TabIndex = 20;
			buttonAnswerLetter9.TabStop = false;
			buttonAnswerLetter9.UseVisualStyleBackColor = false;
			// 
			// buttonAnswerLetter8
			// 
			buttonAnswerLetter8.BackColor = Color.SteelBlue;
			buttonAnswerLetter8.FlatStyle = FlatStyle.Flat;
			buttonAnswerLetter8.Font = new Font("Yu Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonAnswerLetter8.Location = new Point(462, 189);
			buttonAnswerLetter8.Name = "buttonAnswerLetter8";
			buttonAnswerLetter8.Size = new Size(55, 65);
			buttonAnswerLetter8.TabIndex = 19;
			buttonAnswerLetter8.TabStop = false;
			buttonAnswerLetter8.UseVisualStyleBackColor = false;
			// 
			// buttonAnswerLetter7
			// 
			buttonAnswerLetter7.BackColor = Color.SteelBlue;
			buttonAnswerLetter7.FlatStyle = FlatStyle.Flat;
			buttonAnswerLetter7.Font = new Font("Yu Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonAnswerLetter7.Location = new Point(401, 189);
			buttonAnswerLetter7.Name = "buttonAnswerLetter7";
			buttonAnswerLetter7.Size = new Size(55, 65);
			buttonAnswerLetter7.TabIndex = 18;
			buttonAnswerLetter7.TabStop = false;
			buttonAnswerLetter7.UseVisualStyleBackColor = false;
			// 
			// buttonAnswerLetter6
			// 
			buttonAnswerLetter6.BackColor = Color.SteelBlue;
			buttonAnswerLetter6.FlatStyle = FlatStyle.Flat;
			buttonAnswerLetter6.Font = new Font("Yu Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonAnswerLetter6.Location = new Point(340, 189);
			buttonAnswerLetter6.Name = "buttonAnswerLetter6";
			buttonAnswerLetter6.Size = new Size(55, 65);
			buttonAnswerLetter6.TabIndex = 17;
			buttonAnswerLetter6.TabStop = false;
			buttonAnswerLetter6.UseVisualStyleBackColor = false;
			// 
			// buttonAnswerLetter5
			// 
			buttonAnswerLetter5.BackColor = Color.SteelBlue;
			buttonAnswerLetter5.FlatStyle = FlatStyle.Flat;
			buttonAnswerLetter5.Font = new Font("Yu Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonAnswerLetter5.Location = new Point(279, 189);
			buttonAnswerLetter5.Name = "buttonAnswerLetter5";
			buttonAnswerLetter5.Size = new Size(55, 65);
			buttonAnswerLetter5.TabIndex = 16;
			buttonAnswerLetter5.TabStop = false;
			buttonAnswerLetter5.UseVisualStyleBackColor = false;
			// 
			// buttonAnswerLetter4
			// 
			buttonAnswerLetter4.BackColor = Color.SteelBlue;
			buttonAnswerLetter4.FlatStyle = FlatStyle.Flat;
			buttonAnswerLetter4.Font = new Font("Yu Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonAnswerLetter4.Location = new Point(218, 189);
			buttonAnswerLetter4.Name = "buttonAnswerLetter4";
			buttonAnswerLetter4.Size = new Size(55, 65);
			buttonAnswerLetter4.TabIndex = 15;
			buttonAnswerLetter4.TabStop = false;
			buttonAnswerLetter4.UseVisualStyleBackColor = false;
			// 
			// buttonAnswerLetter3
			// 
			buttonAnswerLetter3.BackColor = Color.SteelBlue;
			buttonAnswerLetter3.FlatStyle = FlatStyle.Flat;
			buttonAnswerLetter3.Font = new Font("Yu Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonAnswerLetter3.Location = new Point(157, 189);
			buttonAnswerLetter3.Name = "buttonAnswerLetter3";
			buttonAnswerLetter3.Size = new Size(55, 65);
			buttonAnswerLetter3.TabIndex = 14;
			buttonAnswerLetter3.TabStop = false;
			buttonAnswerLetter3.UseVisualStyleBackColor = false;
			// 
			// buttonAnswerLetter2
			// 
			buttonAnswerLetter2.BackColor = Color.SteelBlue;
			buttonAnswerLetter2.FlatStyle = FlatStyle.Flat;
			buttonAnswerLetter2.Font = new Font("Yu Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonAnswerLetter2.Location = new Point(96, 189);
			buttonAnswerLetter2.Name = "buttonAnswerLetter2";
			buttonAnswerLetter2.Size = new Size(55, 65);
			buttonAnswerLetter2.TabIndex = 13;
			buttonAnswerLetter2.TabStop = false;
			buttonAnswerLetter2.UseVisualStyleBackColor = false;
			// 
			// buttonAnswerLetter1
			// 
			buttonAnswerLetter1.BackColor = Color.SteelBlue;
			buttonAnswerLetter1.FlatStyle = FlatStyle.Flat;
			buttonAnswerLetter1.Font = new Font("Yu Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonAnswerLetter1.Location = new Point(35, 189);
			buttonAnswerLetter1.Name = "buttonAnswerLetter1";
			buttonAnswerLetter1.Size = new Size(55, 65);
			buttonAnswerLetter1.TabIndex = 12;
			buttonAnswerLetter1.TabStop = false;
			buttonAnswerLetter1.UseVisualStyleBackColor = false;
			// 
			// buttonLetter12
			// 
			buttonLetter12.BackColor = Color.SteelBlue;
			buttonLetter12.FlatAppearance.MouseDownBackColor = Color.Cyan;
			buttonLetter12.FlatAppearance.MouseOverBackColor = Color.Cyan;
			buttonLetter12.FlatStyle = FlatStyle.Flat;
			buttonLetter12.Font = new Font("Yu Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonLetter12.Location = new Point(560, 93);
			buttonLetter12.Name = "buttonLetter12";
			buttonLetter12.Size = new Size(78, 67);
			buttonLetter12.TabIndex = 11;
			buttonLetter12.TabStop = false;
			buttonLetter12.Text = "D";
			buttonLetter12.UseVisualStyleBackColor = false;
			buttonLetter12.MouseClick += buttonLetter_Click;
			// 
			// buttonLetter11
			// 
			buttonLetter11.BackColor = Color.SteelBlue;
			buttonLetter11.FlatAppearance.MouseDownBackColor = Color.Cyan;
			buttonLetter11.FlatAppearance.MouseOverBackColor = Color.Cyan;
			buttonLetter11.FlatStyle = FlatStyle.Flat;
			buttonLetter11.Font = new Font("Yu Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonLetter11.Location = new Point(476, 93);
			buttonLetter11.Name = "buttonLetter11";
			buttonLetter11.Size = new Size(78, 67);
			buttonLetter11.TabIndex = 10;
			buttonLetter11.TabStop = false;
			buttonLetter11.Text = "K";
			buttonLetter11.UseVisualStyleBackColor = false;
			buttonLetter11.MouseClick += buttonLetter_Click;
			// 
			// buttonLetter10
			// 
			buttonLetter10.BackColor = Color.SteelBlue;
			buttonLetter10.FlatAppearance.MouseDownBackColor = Color.Cyan;
			buttonLetter10.FlatAppearance.MouseOverBackColor = Color.Cyan;
			buttonLetter10.FlatStyle = FlatStyle.Flat;
			buttonLetter10.Font = new Font("Yu Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonLetter10.Location = new Point(392, 93);
			buttonLetter10.Name = "buttonLetter10";
			buttonLetter10.Size = new Size(78, 67);
			buttonLetter10.TabIndex = 9;
			buttonLetter10.TabStop = false;
			buttonLetter10.Text = "D";
			buttonLetter10.UseVisualStyleBackColor = false;
			buttonLetter10.MouseClick += buttonLetter_Click;
			// 
			// buttonLetter9
			// 
			buttonLetter9.BackColor = Color.SteelBlue;
			buttonLetter9.FlatAppearance.MouseDownBackColor = Color.Cyan;
			buttonLetter9.FlatAppearance.MouseOverBackColor = Color.Cyan;
			buttonLetter9.FlatStyle = FlatStyle.Flat;
			buttonLetter9.Font = new Font("Yu Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonLetter9.Location = new Point(308, 93);
			buttonLetter9.Name = "buttonLetter9";
			buttonLetter9.Size = new Size(78, 67);
			buttonLetter9.TabIndex = 8;
			buttonLetter9.TabStop = false;
			buttonLetter9.Text = "I";
			buttonLetter9.UseVisualStyleBackColor = false;
			buttonLetter9.MouseClick += buttonLetter_Click;
			// 
			// buttonLetter8
			// 
			buttonLetter8.BackColor = Color.SteelBlue;
			buttonLetter8.FlatAppearance.MouseDownBackColor = Color.Cyan;
			buttonLetter8.FlatAppearance.MouseOverBackColor = Color.Cyan;
			buttonLetter8.FlatStyle = FlatStyle.Flat;
			buttonLetter8.Font = new Font("Yu Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonLetter8.Location = new Point(224, 93);
			buttonLetter8.Name = "buttonLetter8";
			buttonLetter8.Size = new Size(78, 67);
			buttonLetter8.TabIndex = 7;
			buttonLetter8.TabStop = false;
			buttonLetter8.Text = "H";
			buttonLetter8.UseVisualStyleBackColor = false;
			buttonLetter8.MouseClick += buttonLetter_Click;
			// 
			// buttonLetter7
			// 
			buttonLetter7.BackColor = Color.SteelBlue;
			buttonLetter7.FlatAppearance.MouseDownBackColor = Color.Cyan;
			buttonLetter7.FlatAppearance.MouseOverBackColor = Color.Cyan;
			buttonLetter7.FlatStyle = FlatStyle.Flat;
			buttonLetter7.Font = new Font("Yu Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonLetter7.Location = new Point(140, 93);
			buttonLetter7.Name = "buttonLetter7";
			buttonLetter7.Size = new Size(78, 67);
			buttonLetter7.TabIndex = 6;
			buttonLetter7.TabStop = false;
			buttonLetter7.Text = "G";
			buttonLetter7.UseVisualStyleBackColor = false;
			buttonLetter7.MouseClick += buttonLetter_Click;
			// 
			// buttonLetter6
			// 
			buttonLetter6.BackColor = Color.SteelBlue;
			buttonLetter6.FlatAppearance.MouseDownBackColor = Color.Cyan;
			buttonLetter6.FlatAppearance.MouseOverBackColor = Color.Cyan;
			buttonLetter6.FlatStyle = FlatStyle.Flat;
			buttonLetter6.Font = new Font("Yu Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonLetter6.Location = new Point(560, 20);
			buttonLetter6.Name = "buttonLetter6";
			buttonLetter6.Size = new Size(78, 67);
			buttonLetter6.TabIndex = 5;
			buttonLetter6.TabStop = false;
			buttonLetter6.Text = "F";
			buttonLetter6.UseVisualStyleBackColor = false;
			buttonLetter6.MouseClick += buttonLetter_Click;
			// 
			// buttonLetter5
			// 
			buttonLetter5.BackColor = Color.SteelBlue;
			buttonLetter5.FlatAppearance.MouseDownBackColor = Color.Cyan;
			buttonLetter5.FlatAppearance.MouseOverBackColor = Color.Cyan;
			buttonLetter5.FlatStyle = FlatStyle.Flat;
			buttonLetter5.Font = new Font("Yu Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonLetter5.Location = new Point(476, 20);
			buttonLetter5.Name = "buttonLetter5";
			buttonLetter5.Size = new Size(78, 67);
			buttonLetter5.TabIndex = 4;
			buttonLetter5.TabStop = false;
			buttonLetter5.Text = "E";
			buttonLetter5.UseVisualStyleBackColor = false;
			buttonLetter5.MouseClick += buttonLetter_Click;
			// 
			// buttonLetter4
			// 
			buttonLetter4.BackColor = Color.SteelBlue;
			buttonLetter4.FlatAppearance.MouseDownBackColor = Color.Cyan;
			buttonLetter4.FlatAppearance.MouseOverBackColor = Color.Cyan;
			buttonLetter4.FlatStyle = FlatStyle.Flat;
			buttonLetter4.Font = new Font("Yu Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonLetter4.Location = new Point(392, 20);
			buttonLetter4.Name = "buttonLetter4";
			buttonLetter4.Size = new Size(78, 67);
			buttonLetter4.TabIndex = 3;
			buttonLetter4.TabStop = false;
			buttonLetter4.Text = "D";
			buttonLetter4.UseVisualStyleBackColor = false;
			buttonLetter4.MouseClick += buttonLetter_Click;
			// 
			// buttonLetter3
			// 
			buttonLetter3.BackColor = Color.SteelBlue;
			buttonLetter3.FlatAppearance.MouseDownBackColor = Color.Cyan;
			buttonLetter3.FlatAppearance.MouseOverBackColor = Color.Cyan;
			buttonLetter3.FlatStyle = FlatStyle.Flat;
			buttonLetter3.Font = new Font("Yu Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonLetter3.Location = new Point(308, 20);
			buttonLetter3.Name = "buttonLetter3";
			buttonLetter3.Size = new Size(78, 67);
			buttonLetter3.TabIndex = 2;
			buttonLetter3.TabStop = false;
			buttonLetter3.Text = "C";
			buttonLetter3.UseVisualStyleBackColor = false;
			buttonLetter3.MouseClick += buttonLetter_Click;
			// 
			// buttonLetter2
			// 
			buttonLetter2.BackColor = Color.SteelBlue;
			buttonLetter2.FlatAppearance.MouseDownBackColor = Color.Cyan;
			buttonLetter2.FlatAppearance.MouseOverBackColor = Color.Cyan;
			buttonLetter2.FlatStyle = FlatStyle.Flat;
			buttonLetter2.Font = new Font("Yu Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonLetter2.Location = new Point(224, 20);
			buttonLetter2.Name = "buttonLetter2";
			buttonLetter2.Size = new Size(78, 67);
			buttonLetter2.TabIndex = 1;
			buttonLetter2.TabStop = false;
			buttonLetter2.Text = "B";
			buttonLetter2.UseVisualStyleBackColor = false;
			buttonLetter2.MouseClick += buttonLetter_Click;
			// 
			// buttonLetter1
			// 
			buttonLetter1.BackColor = Color.SteelBlue;
			buttonLetter1.FlatAppearance.MouseDownBackColor = Color.Cyan;
			buttonLetter1.FlatAppearance.MouseOverBackColor = Color.Cyan;
			buttonLetter1.FlatStyle = FlatStyle.Flat;
			buttonLetter1.Font = new Font("Yu Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonLetter1.Location = new Point(140, 20);
			buttonLetter1.Name = "buttonLetter1";
			buttonLetter1.Size = new Size(78, 67);
			buttonLetter1.TabIndex = 0;
			buttonLetter1.TabStop = false;
			buttonLetter1.Text = "A";
			buttonLetter1.UseVisualStyleBackColor = false;
			buttonLetter1.MouseClick += buttonLetter_Click;
			// 
			// buttonBack
			// 
			buttonBack.BackgroundImage = (Image)resources.GetObject("buttonBack.BackgroundImage");
			buttonBack.BackgroundImageLayout = ImageLayout.Stretch;
			buttonBack.FlatStyle = FlatStyle.Flat;
			buttonBack.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonBack.Location = new Point(12, 9);
			buttonBack.Name = "buttonBack";
			buttonBack.Size = new Size(90, 55);
			buttonBack.TabIndex = 2;
			buttonBack.UseVisualStyleBackColor = true;
			buttonBack.Click += buttonBack_Click;
			// 
			// WordsForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.SteelBlue;
			ClientSize = new Size(800, 471);
			Controls.Add(buttonBack);
			Controls.Add(Panel_Letters);
			Controls.Add(labelWordsHeader);
			FormBorderStyle = FormBorderStyle.None;
			KeyPreview = true;
			Name = "WordsForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "WordsForm";
			Panel_Letters.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label labelWordsHeader;
		private Panel Panel_Letters;
		private Button buttonLetter1;
		private Button buttonLetter11;
		private Button buttonLetter10;
		private Button buttonLetter9;
		private Button buttonLetter8;
		private Button buttonLetter7;
		private Button buttonLetter6;
		private Button buttonLetter5;
		private Button buttonLetter4;
		private Button buttonLetter3;
		private Button buttonLetter2;
		private Button buttonLetter12;
		private Button buttonBack;
		private Button buttonAnswerLetter12;
		private Button buttonAnswerLetter11;
		private Button buttonAnswerLetter10;
		private Button buttonAnswerLetter9;
		private Button buttonAnswerLetter8;
		private Button buttonAnswerLetter7;
		private Button buttonAnswerLetter6;
		private Button buttonAnswerLetter5;
		private Button buttonAnswerLetter4;
		private Button buttonAnswerLetter3;
		private Button buttonAnswerLetter2;
		private Button buttonAnswerLetter1;
		private Button buttonAcceptWord;
		private Button buttonDeleteAllLetters;
		private Button buttonBackspaceLetter;
	}
}