using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_JalynZamora
{
    public partial class AddQuote : Form
    {
        public event System.ComponentModel.CancelEventHandler Validating;

        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void widthInput_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;
            if(!ValidWidth(widthInput.Value, out errorMsg))
            {
                e.Cancel = true;
                widthInput.Select(0, 1);
                //this.errorProvider1.SetError(widthInput, errorMsg);
            }
        }

        private void widthInput_Validated(object sender, System.EventArgs e)
        {
            //errorProvider1.SetError(widthInput, "");
        }

        public bool ValidWidth(decimal width, out string errorMessage)
        {
            if (widthInput.Value < 24)
            {
                errorMessage = "Width of desk must be greater than 24 inches";
                return false;
            }
            if (widthInput.Value > 96)
            {
                errorMessage = "Width of desk must be less than 96 inches.";
                return false;
            }
            errorMessage = "Width must be between 24 and 96 inches.";
            return false;
        }

        private void depthInput_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
