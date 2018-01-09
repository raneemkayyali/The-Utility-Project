/* Author: Raneem Kayyali
 * Date: 11/27/2017
 * The U-tility Project: Summary Form
 */
using System;
using System.Windows.Forms;
using System.Net.Mail;

namespace The_Utility_Project
{
    public partial class SummaryForm : Form
    {
        public SummaryForm()
        {
            InitializeComponent();
        }
        // Inputs values from OrderForm to be displayed in the subtotal textbox
        public void SetSubtotalTextBox(string text)
        {
            this.subtotalTextBox.Text = text;
        }
        // Inputs values from OrderForm to be displayed in the labor textbox
        public void SetLaborTextBox(string text) {

            this.laborTextBox.Text = text;
        }
        // Inputs values from OrderForm to be displayed in the tax textbox
        public void SetTaxTextBox(string text)
        {
            this.taxTextBox.Text = text;
        }
        // Inputs values from OrderForm to be displayed in the total textbox
        public void SetTotalTextBox(string text)
        {
            this.totalTextBox.Text = text;
        }
        // Inputs values from OrderForm to be displayed in the order textbox
        public void SetOrderTextBox(string text, string text2, string text3)
        {
            this.orderTextBox.Text += ( text + "  " + text2 + "   " + 
                text3 + "\r\n" );

        }
        // Input validation for the first name textbox to ensure the user may only enter
        // letters.
        private void firstNameTxtBox_KeyPress(object sender, KeyPressEventArgs e)

        {

            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))

                e.Handled = true;

        }
        // Input validation for the last name textbox to ensure the user may only enter
        // letters.
        private void lastNameTxtBox_KeyPress(object sender, KeyPressEventArgs e)

        {

            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))

                e.Handled = true;

        }
        
        private void submitBtn_Click(object sender, EventArgs e)
        {   // Tries to successfully run through the following code
            try
            {   // Email validation using .NET  
                var email = new MailAddress(emailTxtBox.Text);

                // Display message box upon clicking the submit button to confirm order
                string message = "Are you sure you want to continue with this order?";
                string caption = "Order Confirmation";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox
                result = MessageBox.Show(message, caption, buttons);

                // If user selects yes, a thank you messagebox will be displayed
                // otherwise they will return back to the order form
                if (result == DialogResult.Yes)
                {
                    string thankyou = "Your order has been submitted. Thank you!";
                    DialogResult thanks;
                    thanks = MessageBox.Show(thankyou);

                    // Closes the parent form.
                    this.Close();

                }
            }
            // Catches FormatExceptions for the email textbox and displays error message
            catch (FormatException)
            {
                string errorMessage = "Please enter a valid email address";
                string errorCaption = "Error";
                MessageBoxButtons errorButtons = MessageBoxButtons.OK;
                DialogResult errorResult;

                errorResult = MessageBox.Show(errorMessage, errorCaption, errorButtons);
            }
            // Catches ArgumentException for the email textbox and displays error message
            catch (ArgumentException)
            {
                string errorMessage = "Please enter a valid email address";
                string errorCaption = "Error";
                MessageBoxButtons errorButtons = MessageBoxButtons.OK;
                DialogResult errorResult;

                errorResult = MessageBox.Show(errorMessage, errorCaption, errorButtons);
            }
        }
            
    }
}
