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
using Slagalica;

namespace Slagalica.Forms
{
	public partial class WordsForm : Form
	{
		private List<Button> buttonsLetters; // List of buttons that sotres all the buttons of possible letters
		private List<Button> buttonsAnswers; // Listo of buttons that stores all the buttons of answer lettres
		private int currentButtonAnswer;    // Making track of index in which button next letter should be added
		private String language; // Language of the game
		private String computerWord; // Word that computer made
		private int currentButtonLetterIndex_Ainmation = 0; // Index of the current letter that animation is being displayed for
		private char currentChar_Animation = 'A'; // Current letter that is being displayed in the animation
		private string shuffledWordLetters_Animation; // Shuffled letters of the word that is being displayed in the animation
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
		}
		private void WordsForm_Load(object sender, EventArgs e)
		{

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
				MessageBox.Show("There is no English version yet"); // To be implemented when english words are found

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

			if ((int)this.buttonStop.Tag == 12)
			{

				foreach (Button button in this.buttonsLetters)
					button.Enabled = true;

				this.buttonStop.Visible = false;
				this.buttonAcceptWord.Visible = true;
				letterTimer.Stop();
				
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
			if (count < 2)
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
				wordsFilePath = Path.Combine(Application.StartupPath, "Resources", "Slova_Recources", "Words_List_Serbian.txt");
			else
				MessageBox.Show("There is no English version yet"); // TODO - English version

			//Checking if the word exists
			foreach (var line in File.ReadLines(wordsFilePath))
			{
				if (line == word)
				{
					isWord = true;
					break;
				}
			}


			//Showing result to the user
			Color color = Color.Green;
			if (!isWord)
				color = Color.Red;

			foreach (Button button in this.buttonsAnswers)
				if (button.Text != "")
					button.BackColor = color;

			//Show computers word
			this.labelComputerWord.Text = this.computerWord;

		}

		
	}
	#endregion


}
