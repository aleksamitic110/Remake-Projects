using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
		private int currentButtonAnswer;	// Making track of index in which button next letter should be added
		public WordsForm()
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

		}


		#region BUTTON CLICK

		//Back to main form
		private void buttonBack_Click(object sender, EventArgs e)
		{
			Program.MainForm.Show();
			this.Close();
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
			if (this.currentButtonAnswer > 0) {

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
	}
	#endregion


}
