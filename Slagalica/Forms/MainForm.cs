using System.Runtime.CompilerServices;
namespace Slagalica.Forms
{
	public partial class MainForm : Form
	{

		private Font? originalFont; // Used for hover effects on buttons
		public String language; // Used for language selection
		public MainForm()
		{
			InitializeComponent();
			this.rdButtonSrpski.Checked = true; // Default language is Serbian
			this.language = "sr";
		}

		//This code makes logic and style for buttons when hovered
		#region BUTTON_HOVER_STYLE
		private void Button_Hover_Enter(object sender, EventArgs e)
		{
			Button? button = sender as Button;
			if (button != null)
			{
				this.originalFont = button.Font;
				button.Font = new Font(button.Font.FontFamily, button.Font.Size + 3);
				button.ForeColor = Color.Green;
			}
		}

		private void Button_Hover_Leave(object sender, EventArgs e)
		{
			Button? button = sender as Button;
			if (button != null)
			{
				button.Font = originalFont;
				button.ForeColor = Color.Black;
			}
		}
		#endregion


		//This region contains all buttonClick functions
		#region BUTTON_CLICK
		private void buttonStartGame_Click(object sender, EventArgs e)
		{
			if (this.rdBtnEnglish.Checked)
				this.language = "en";

			WordsForm WordsForm = new WordsForm(this.language);
			WordsForm.Show();
			this.Hide();
		}
		#endregion

		private void buttonExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
