using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Slagalica;

namespace Slagalica.Forms
{

	/* TODOS
		TODO: Look for better word lists/make those have only letters
	*/

	public partial class WordsForm : Form
	{
		private List<Button> buttonsLetters; // List of buttons that sotres all the buttons of possible letters
		private List<Button> buttonsAnswers; // Listo of buttons that stores all the buttons of answer lettres
		private int currentButtonAnswer;    // Making track of index in which button next letter should be added
		private String language; // Language of the game
		private String computerWord; // Word that computer made
		private char currentChar_Animation = 'A'; // Current letter that is being displayed in the animation
		private string shuffledWordLetters_Animation; // Shuffled letters of the word that is being displayed in the animation
		private SoundPlayer musicPlayer; // Music player for the game
		public WordsForm(String language)
		{
			InitializeComponent();

			//Adding all buttons to lists of buttons so that they are grouped
			#region ADDING_BUTTONS_TO_LISTS
			//Adding buttons to list of letters
			this.buttonsLetters = new List<Button>();
			this.buttonsLetters.Add(this.buttonLetter1);
			this.buttonsLetters.Add(this.buttonLetter2);
			this.buttonsLetters.Add(this.buttonLetter3);
			this.buttonsLetters.Add(this.buttonLetter4);
			this.buttonsLetters.Add(this.buttonLetter5);
			this.buttonsLetters.Add(this.buttonLetter6);
			this.buttonsLetters.Add(this.buttonLetter7);
			this.buttonsLetters.Add(this.buttonLetter8);
			this.buttonsLetters.Add(this.buttonLetter9);
			this.buttonsLetters.Add(this.buttonLetter10);
			this.buttonsLetters.Add(this.buttonLetter11);
			this.buttonsLetters.Add(this.buttonLetter12);

			//Adding buttons to list of answers
			this.buttonsAnswers = new List<Button>();
			this.buttonsAnswers.Add(this.buttonAnswerLetter1);
			this.buttonsAnswers.Add(this.buttonAnswerLetter2);
			this.buttonsAnswers.Add(this.buttonAnswerLetter3);
			this.buttonsAnswers.Add(this.buttonAnswerLetter4);
			this.buttonsAnswers.Add(this.buttonAnswerLetter5);
			this.buttonsAnswers.Add(this.buttonAnswerLetter6);
			this.buttonsAnswers.Add(this.buttonAnswerLetter7);
			this.buttonsAnswers.Add(this.buttonAnswerLetter8);
			this.buttonsAnswers.Add(this.buttonAnswerLetter9);
			this.buttonsAnswers.Add(this.buttonAnswerLetter10);
			this.buttonsAnswers.Add(this.buttonAnswerLetter11);
			this.buttonsAnswers.Add(this.buttonAnswerLetter12);
			#endregion
			this.currentButtonAnswer = 0;
			this.language = language;
			this.buttonAcceptWord.Visible = false; // Accepting word button is not visible at the beginning
			this.computerWord = "";
			this.shuffledWordLetters_Animation = "";
			if (language == "en")
			{
				this.labelWordsHeader.Text = "WORDS";
				this.labelComputerWord.Location = new Point(300, 9);
			}
			this.musicPlayer = new SoundPlayer(Path.Combine(Application.StartupPath, "Resources", "Slova_Recources", "Words_music.wav"));
		}
		private void WordsForm_Load(object sender, EventArgs e)
		{

			//Setting up the form and music
			this.textForComputerWord.Visible = false;
			this.buttonNextGame.Visible = false;
			musicPlayer.PlayLooping();
			
			//Get computer word but shuffled for Animation
			this.shuffledWordLetters_Animation = makeComputerWord();
			this.buttonStop.Tag = 0;

			//Making animation
			letterTimer.Interval = 50;
			letterTimer.Tick += LetterTimer_Tick;
			letterTimer.Start();

			//At start all buttons unclickable until animaiton is over
			foreach (Button button in this.buttonsLetters)
				button.Enabled = false;
		}

		//Buttons clicks
		#region BUTTON CLICK

		//Back to main form
		private void buttonBack_Click(object sender, EventArgs e)
		{
			Program.MainForm.Show();
			this.Close();
		}

		//Make computer word and return shuffled word of size 12
		private string makeComputerWord()
		{

			//Checking language
			string wordsFilePath = "";
			if (this.language == "sr")
				wordsFilePath = Path.Combine(Application.StartupPath, "Resources", "Slova_Recources", "Words_List_Serbian.txt");
			else
				wordsFilePath = Path.Combine(Application.StartupPath, "Resources", "Slova_Recources", "Words_List_English.txt");

			// Filter valid words
			var validWords = File.ReadLines(wordsFilePath)
									.Where(w => w.Length >= 9 && w.Length <= 12)
									.ToList();

			// Pick a random word
			Random random = new Random();
			if (validWords.Count > 0)
			{
				string randomWord = validWords[random.Next(validWords.Count)];
				this.computerWord = randomWord.ToUpper();
			}

			//Shuffling the word and add letters to the size of 12
			List<char> shuffledWord = this.computerWord.ToList();
			shuffledWord = shuffledWord.OrderBy(x => random.Next()).ToList();

			while (shuffledWord.Count != 12)
				shuffledWord.Add((char)random.Next('A', 'Z' + 1));

			

			return new string(shuffledWord.ToArray());

		}

		//Stopping letters
		private void buttonStop_Click(object sender, EventArgs e)
		{
			// Counting and incrementing number of stops
			if (this.buttonStop.Tag == null)
				this.buttonStop.Tag = 0;
			int countStops = (int)this.buttonStop.Tag;
			

			this.buttonsLetters[(int)this.buttonStop.Tag].Text = this.shuffledWordLetters_Animation[(int)this.buttonStop.Tag].ToString();
			this.buttonStop.Tag = countStops + 1;

			//If all letters are stopped show button AcceptWord and start game timer
			if ((int)this.buttonStop.Tag == 12)
			{

				foreach (Button button in this.buttonsLetters)
					button.Enabled = true;

				this.buttonStop.Visible = false;
				this.buttonAcceptWord.Visible = true;
				letterTimer.Stop();

				this.gameTimer.Interval = 60_000 / this.panelGameTimer.Width;
				this.gameTimer.Tick += GameTimer_Tick;
				this.gameTimer.Start();
				
			}

		}
		//Timers for game and letters animation
		private void GameTimer_Tick(object? sender, EventArgs e) {
			
			if (this.panelGameTimer.Width < 259)
				this.panelGameTimer.BackColor = Color.Yellow;
		    if (this.panelGameTimer.Width < 129)
				this.panelGameTimer.BackColor = Color.Red;

			if (this.panelGameTimer.Width > 0)
				this.panelGameTimer.Width -= 1;
			else
			{
				this.gameTimer.Stop();
				this.buttonAcceptWord_Click(this.buttonAcceptWord, EventArgs.Empty);
			}
		} 
		private void LetterTimer_Tick(object? sender, EventArgs e)
		{
			if (this.buttonStop.Tag != null)
				this.buttonsLetters[(int)this.buttonStop.Tag].Text = this.currentChar_Animation.ToString();

			if (this.currentChar_Animation == 'Z')
				this.currentChar_Animation = 'A'; // Loop back to A
			else
				this.currentChar_Animation++;
		}


		//Adding letter to answer by click
		private void buttonLetter_Click(object sender, MouseEventArgs e)
		{

			Button? button = sender as Button;

			if (button != null)
			{

				if (this.currentButtonAnswer < 12 && button.ForeColor != Color.Gray)
				{
					button.ForeColor = Color.Gray;
					this.buttonsAnswers[currentButtonAnswer].Text = button.Text;
					this.currentButtonAnswer++;
				}
			}

		}

		//Deleting all Answer letters
		private void buttonDeleteAllLetters_Click(object sender, EventArgs e)
		{
			if (this.currentButtonAnswer > 0)
			{
				for (int i = 0; i < 12; i++)
				{
					this.buttonsAnswers[i].Text = "";
					this.buttonsLetters[i].ForeColor = Color.Black;
				}

				this.currentButtonAnswer = 0;
			}
		}

		//Deleting one by one asnwer letters
		private void buttonBackspaceLetter_Click(object sender, EventArgs e)
		{
			if (this.currentButtonAnswer > 0)
			{

				this.currentButtonAnswer--;
				string letterToDelete = this.buttonsAnswers[this.currentButtonAnswer].Text;
				this.buttonsAnswers[this.currentButtonAnswer].Text = "";
				foreach (Button button in this.buttonsLetters)
				{
					if (button.Text == letterToDelete && button.ForeColor == Color.Gray)
					{
						button.ForeColor = Color.Black;
						break;
					}
				}

			}
		}

		//Does word Exist - Accepting the word
		private void buttonAcceptWord_Click(object sender, EventArgs e)
		{

			//Not allowing to accept word if there are not enough letters
			int count = 0; 
			foreach (Button button in this.buttonsAnswers)
				if (button.Text != "")
					count++;
			if (count < 2 && this.gameTimer.Enabled == true)
				return;

			//Getting word from buttons
			string wordsFilePath = "";
			string word = "";
			foreach (Button button in this.buttonsAnswers)
				if (button.Text != "")
					word += button.Text;
			word = word.ToLower();

			//Checking language
			bool isWord = false;
			if (this.language == "sr")
			{
				this.textForComputerWord.Text = "Kompjuter rec:";
				wordsFilePath = Path.Combine(Application.StartupPath, "Resources", "Slova_Recources", "Words_List_Serbian.txt");
			}
			else
				wordsFilePath = Path.Combine(Application.StartupPath, "Resources", "Slova_Recources", "Words_List_English.txt");

			//Checking if the word exists
			foreach (var line in File.ReadLines(wordsFilePath))
			{
				if (line.Replace("\n", "") == word)
				{
					isWord = true;
					break;
				}
			}

			//Showing result to the user and computer word and stopping the game
			Color color = Color.Green;
			if (!isWord)
				color = Color.Red;

			foreach (Button button in this.buttonsAnswers)
				if (button.Text != "")
					button.BackColor = color;

			
			this.labelComputerWord.Text = this.computerWord;
			this.labelComputerWord.Location = new Point(285, 265);
			if (this.gameTimer.Enabled)
				this.gameTimer.Stop();
			
			this.buttonBackspaceLetter.Visible = false;
			this.buttonDeleteAllLetters.Visible = false;
			this.buttonAcceptWord.Visible = false;
			this.textForComputerWord.Visible = true;
			this.buttonNextGame.Visible = true;
			this.musicPlayer.Stop();
		}

		
	}
	#endregion


}
