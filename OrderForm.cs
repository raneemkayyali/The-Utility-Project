/* Author: Raneem Kayyali
 * Date: 11/27/2017
 * The U-tility Project: Order Form
 */
using System;
using System.Windows.Forms;

namespace The_Utility_Project
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();

        }

        private void summaryBtn_Click(object sender, EventArgs e)
        {
            // Tries to successfully run through the following code
            try
            {
                // Declare array for item prices
                double[] itemPrices = new double[] { 14.00, 20.00, 15.00, 48.50, 27.20,
            22.00, 18.00, 25.00, 16.00, 14.20, 23.00, 6.20, 53.00, 4.50, 46.50, 46.50, 72.00,
            19.00, 24.00, 30.00};

                // Declare array for item names
                string[] itemNames = new string[] { "Sinker Nails", "Conco Exterior", "Conco Flat Int.",
            "Conco PVA Primer", "LVL 1.9E", "SPF 2x6-12", "SPF 2x6-8", "SPF 2x4-104", "Easy Sand 90",
            "OSB Flakeboard", "Galv Box Nails", "G90 Galv Hanger", "Gyps FC Drywall",
            "Poly Adhesive", "R-25 EasyTouch", "AC2 Treated", "Unfaced Insulation", "RIM Board",
            "StraitFlex Tape", "I-Joist 2.5x11x20"};

                // Declare integer variables for quantity entry 
                int numOfSinkers;
                int numOfConExterior;
                int numOfConInterior;
                int numOfConPrimer;
                int numOfLVLe;
                int numOfSPF12;
                int numOfSPF8;
                int numOfSPF104;
                int numOfEasy;
                int numOfOSB;
                int numOfGalv;
                int numOfG90;
                int numOfGyps;
                int numOfPoly;
                int numOfR25;
                int numOfAC2;
                int numOfUnfaced;
                int numOfRIM;
                int numOfStrait;
                int numOfJoist;

                // Declare double variables for labor and tax percent
                double laborCost = 85.25;
                double taxPercent = .07;

                // Allow user to enter integers in quanitity textbox
                numOfSinkers = Convert.ToInt16(numSinker.Text);
                numOfConExterior = Convert.ToInt16(numConExt.Text);
                numOfConInterior = Convert.ToInt16(numConFlatInt.Text);
                numOfConPrimer = Convert.ToInt16(numConPrimerPVA.Text);
                numOfLVLe = Convert.ToInt16(numLVLE.Text);
                numOfSPF12 = Convert.ToInt16(numSPF12.Text);
                numOfSPF8 = Convert.ToInt16(numSPF8.Text);
                numOfSPF104 = Convert.ToInt16(numSPF104.Text);
                numOfEasy = Convert.ToInt16(numEasySand.Text);
                numOfOSB = Convert.ToInt16(numOSB.Text);
                numOfGalv = Convert.ToInt16(numGalvNails.Text);
                numOfG90 = Convert.ToInt16(numG90.Text);
                numOfGyps = Convert.ToInt16(numGypsFC.Text);
                numOfPoly = Convert.ToInt16(numPolyAd.Text);
                numOfR25 = Convert.ToInt16(numR25.Text);
                numOfAC2 = Convert.ToInt16(numAC2.Text);
                numOfUnfaced = Convert.ToInt16(numUnfaced.Text);
                numOfRIM = Convert.ToInt16(numRIM.Text);
                numOfStrait = Convert.ToInt16(numStrait.Text);
                numOfJoist = Convert.ToInt16(numJoist.Text);

                // Calculates total price for each individual item
                // by multiplying quantity of item by item price
                double totalSinkers = numOfSinkers * itemPrices[0];
                double totalConExt = numOfConExterior * itemPrices[1];
                double totalConInt = numOfConInterior * itemPrices[2];
                double totalConPrimer = numOfConPrimer * itemPrices[3];
                double totalLVLe = numOfLVLe * itemPrices[4];
                double totalSPF12 = numOfSPF12 * itemPrices[5];
                double totalSPF8 = numOfSPF8 * itemPrices[6];
                double totalSPF104 = numOfSPF104 * itemPrices[7];
                double totalEasy = numOfEasy * itemPrices[8];
                double totalOSB = numOfOSB * itemPrices[9];
                double totalGalv = numOfGalv * itemPrices[10];
                double totalG90 = numOfG90 * itemPrices[11];
                double totalGyps = numOfGyps * itemPrices[12];
                double totalPoly = numOfPoly * itemPrices[13];
                double totalR25 = numOfR25 * itemPrices[14];
                double totalAC2 = numOfAC2 * itemPrices[15];
                double totalUnfaced = numOfUnfaced * itemPrices[16];
                double totalRIM = numOfRIM * itemPrices[17];
                double totalStrait = numOfStrait * itemPrices[18];
                double totalJoist = numOfJoist * itemPrices[19];

                // Calculates subtotal
                double subtotal = totalSinkers + totalConExt + totalConInt +
                totalConPrimer + totalLVLe + totalSPF12 + totalSPF8 + totalSPF104 + totalEasy +
                totalOSB + totalGalv + totalG90 + totalGyps + totalPoly + totalR25 + totalAC2 +
                totalUnfaced + totalRIM + totalStrait + totalJoist;

                // Calculates tax amount
                double taxAmount = taxPercent * subtotal;

                // Access Summary Form also referred to as the receipt
                SummaryForm receipt = new SummaryForm();

                // Check if all items are equal to zero 
                if (numOfSinkers == 0 && numOfConExterior == 0 && numOfConInterior == 0 &&
                   numOfConPrimer == 0 && numOfLVLe == 0 && numOfSPF12 == 0 && numOfSPF8 == 0 && 
                   numOfSPF104 == 0 && numOfEasy == 0 && numOfOSB == 0 && numOfGalv == 0 &&
                   numOfG90 == 0 && numOfGyps == 0 && numOfPoly == 0 && numOfR25 == 0 && numOfAC2 == 0 &&
                   numOfUnfaced == 0 && numOfRIM == 0 && numOfStrait == 0 && numOfJoist == 0)
                {   // If all item quantities are  equal to zero, display error requiring user
                    // to enter an item quantity greater than zero for at least one item
                    string message = "Please enter a quantity value greater than zero " +
                    "for at least one item in order to continue";
                    string caption = "Attention";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;

                    result = MessageBox.Show(message, caption, buttons);
                }
                // Check if each of the items is less than zero
                if (numOfSinkers < 0 || numOfConExterior < 0 || numOfConInterior < 0 ||
                   numOfConPrimer < 0 || numOfLVLe < 0 || numOfSPF12 < 0 ||
                   numOfSPF8 < 0 || numOfSPF104 < 0 || numOfEasy < 0 || numOfOSB < 0 || numOfGalv < 0 ||
                   numOfG90 < 0 || numOfGyps < 0 || numOfPoly < 0 || numOfR25 < 0 || numOfAC2 < 0 ||
                   numOfUnfaced < 0 || numOfRIM < 0 || numOfStrait < 0 || numOfJoist < 0)
                {   // If any item is less than zero display error message requiring user to enter
                    // a whole number greater than zero for the item quantity
                    string message = "Please enter a whole number greater than zero for item quantity.";
                    string caption = "Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;

                    result = MessageBox.Show(message, caption, buttons);
                }
                // Checks if the quantitiy for the following item is greater than or equal to zero
                if (numOfSinkers >= 0)
                {
                    if (numOfSinkers == 0)
                    {
                        // If equal to zero do nothing
                    }
                    // Else if any other item is less than zero display error message
                    else if (numOfConExterior < 0 || numOfConInterior < 0 || numOfConPrimer < 0 || 
                        numOfLVLe < 0 || numOfSPF12 < 0 || numOfSPF8 < 0 || numOfSPF104 < 0 || 
                        numOfEasy < 0 || numOfOSB < 0 || numOfGalv < 0 || numOfG90 < 0 || 
                        numOfGyps < 0 || numOfPoly < 0 || numOfR25 < 0 || numOfAC2 < 0 ||
                        numOfUnfaced < 0 || numOfRIM < 0 || numOfStrait < 0 || numOfJoist < 0)
                    {
                        string message = "Please enter a whole number greater " +
                            "than zero for item quantity.";
                        string caption = "Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;

                        result = MessageBox.Show(message, caption, buttons);
                    }
                    // Else open and display the item information on the Summary Form
                    else
                    {
                        receipt.SetOrderTextBox(numOfSinkers.ToString("0"), itemNames[0],
                            totalSinkers.ToString("c2"));
                        receipt.Show();
                    }
                }

                if (numOfConExterior >= 0)
                {
                    if (numOfConExterior == 0)
                    {
                        // If equal to zero do nothing
                    }
                    else if (numOfSinkers < 0 || numOfConInterior < 0 || numOfConPrimer < 0 || 
                        numOfLVLe < 0 || numOfSPF12 < 0 || numOfSPF8 < 0 || numOfSPF104 < 0 || 
                        numOfEasy < 0 || numOfOSB < 0 || numOfGalv < 0 || numOfG90 < 0 || 
                        numOfGyps < 0 || numOfPoly < 0 || numOfR25 < 0 || numOfAC2 < 0 ||
                        numOfUnfaced < 0 || numOfRIM < 0 || numOfStrait < 0 || numOfJoist < 0)
                    {
                        string message = "Please enter a whole number greater " +
                            "than zero for item quantity.";
                        string caption = "Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;

                        result = MessageBox.Show(message, caption, buttons);
                    }
                    else
                    {
                        receipt.SetOrderTextBox(numOfConExterior.ToString("0"), itemNames[1],
                            totalConExt.ToString("c2"));
                        receipt.Show();
                    }
                }

                if (numOfConInterior >= 0)
                {
                    if (numOfConInterior == 0)
                    {
                        // If equal to zero do nothing
                    }
                    else if (numOfSinkers < 0 || numOfConExterior < 0 || numOfConPrimer < 0 ||
                   numOfLVLe < 0 || numOfSPF12 < 0 || numOfSPF8 < 0 || numOfSPF104 < 0 || 
                   numOfEasy < 0 || numOfOSB < 0 || numOfGalv < 0 || numOfG90 < 0 || numOfGyps < 0 || 
                   numOfPoly < 0 || numOfR25 < 0 || numOfAC2 < 0 || numOfUnfaced < 0 || numOfRIM < 0 || 
                   numOfStrait < 0 || numOfJoist < 0)
                    {
                        string message = "Please enter a whole number greater " +
                            "than zero for item quantity.";
                        string caption = "Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;

                        result = MessageBox.Show(message, caption, buttons);
                    }
                    else
                    {
                        receipt.SetOrderTextBox(numOfConInterior.ToString("0"), itemNames[2],
                            totalConInt.ToString("c2"));
                        receipt.Show();
                    }
                }

                if (numOfConPrimer >= 0)
                {
                    if (numOfConPrimer == 0)
                    {
                        // If equal to zero do nothing
                    }
                    else if (numOfSinkers < 0 || numOfConExterior < 0 || numOfConInterior < 0 ||
                   numOfLVLe < 0 || numOfSPF12 < 0 || numOfSPF8 < 0 || numOfSPF104 < 0 || 
                   numOfEasy < 0 || numOfOSB < 0 || numOfGalv < 0 || numOfG90 < 0 || numOfGyps < 0 || 
                   numOfPoly < 0 || numOfR25 < 0 || numOfAC2 < 0 || numOfUnfaced < 0 || numOfRIM < 0 || 
                   numOfStrait < 0 || numOfJoist < 0)
                    {
                        string message = "Please enter a whole number greater " +
                            "than zero for item quantity.";
                        string caption = "Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;

                        result = MessageBox.Show(message, caption, buttons);
                    }
                    else
                    {
                        receipt.SetOrderTextBox(numOfConPrimer.ToString("0"), itemNames[3],
                            totalConPrimer.ToString("c2"));
                        receipt.Show();
                    }
                }

                if (numOfLVLe >= 0)
                {
                    if (numOfLVLe == 0)
                    {
                        // If equal to zero do nothing
                    }
                    else if (numOfSinkers < 0 || numOfConExterior < 0 || numOfConInterior < 0 ||
                   numOfConPrimer < 0 || numOfSPF12 < 0 || numOfSPF8 < 0 || numOfSPF104 < 0 || 
                   numOfEasy < 0 || numOfOSB < 0 || numOfGalv < 0 || numOfG90 < 0 || numOfGyps < 0 || 
                   numOfPoly < 0 || numOfR25 < 0 || numOfAC2 < 0 || numOfUnfaced < 0 || numOfRIM < 0 || 
                   numOfStrait < 0 || numOfJoist < 0)
                    {
                        string message = "Please enter a whole number greater " +
                            "than zero for item quantity.";
                        string caption = "Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;

                        result = MessageBox.Show(message, caption, buttons);
                    }
                    else
                    {
                        receipt.SetOrderTextBox(numOfLVLe.ToString("0"), itemNames[4],
                            totalLVLe.ToString("c2"));
                        receipt.Show();
                    }
                }

                if (numOfSPF12 >= 0)
                {
                    if (numOfSPF12 == 0)
                    {
                        // If equal to zero do nothing
                    }
                    else if (numOfSinkers < 0 || numOfConExterior < 0 || numOfConInterior < 0 ||
                   numOfConPrimer < 0 || numOfLVLe < 0 || numOfSPF8 < 0 || numOfSPF104 < 0 || 
                   numOfEasy < 0 || numOfOSB < 0 || numOfGalv < 0 || numOfG90 < 0 || numOfGyps < 0 || 
                   numOfPoly < 0 || numOfR25 < 0 || numOfAC2 < 0 || numOfUnfaced < 0 || numOfRIM < 0 || 
                   numOfStrait < 0 || numOfJoist < 0)
                    {
                        string message = "Please enter a whole number greater " +
                            "than zero for item quantity.";
                        string caption = "Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;

                        result = MessageBox.Show(message, caption, buttons);
                    }
                    else
                    {
                        receipt.SetOrderTextBox(numOfSPF12.ToString("0"), itemNames[5],
                            totalSPF12.ToString("c2"));
                        receipt.Show();
                    }
                }

                if (numOfSPF8 >= 0)
                {
                    if (numOfSPF8 == 0)
                    {
                        // If equal to zero do nothing
                    }
                    else if (numOfSinkers < 0 || numOfConExterior < 0 || numOfConInterior < 0 ||
                   numOfConPrimer < 0 || numOfLVLe < 0 || numOfSPF12 < 0 || numOfSPF104 < 0 || 
                   numOfEasy < 0 || numOfOSB < 0 || numOfGalv < 0 || numOfG90 < 0 || numOfGyps < 0 || 
                   numOfPoly < 0 || numOfR25 < 0 || numOfAC2 < 0 || numOfUnfaced < 0 || numOfRIM < 0 || 
                   numOfStrait < 0 || numOfJoist < 0)
                    {
                        string message = "Please enter a whole number greater " +
                            "than zero for item quantity.";
                        string caption = "Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;

                        result = MessageBox.Show(message, caption, buttons);
                    }
                    else
                    {
                        receipt.SetOrderTextBox(numOfSPF8.ToString("0"), itemNames[6],
                            totalSPF8.ToString("c2"));
                        receipt.Show();
                    }
                }

                if (numOfSPF104 >= 0)
                {
                    if (numOfSPF104 == 0)
                    {
                        // If equal to zero do nothing
                    }
                    else if (numOfSinkers < 0 || numOfConExterior < 0 || numOfConInterior < 0 ||
                   numOfConPrimer < 0 || numOfLVLe < 0 || numOfSPF12 < 0 || numOfSPF8 < 0 || 
                   numOfEasy < 0 || numOfOSB < 0 || numOfGalv < 0 || numOfG90 < 0 || numOfGyps < 0 || 
                   numOfPoly < 0 || numOfR25 < 0 || numOfAC2 < 0 || numOfUnfaced < 0 || numOfRIM < 0 || 
                   numOfStrait < 0 || numOfJoist < 0)
                    {
                        string message = "Please enter a whole number greater " +
                            "than zero for item quantity.";
                        string caption = "Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;

                        result = MessageBox.Show(message, caption, buttons);
                    }
                    else
                    {
                        receipt.SetOrderTextBox(numOfSPF104.ToString("0"), itemNames[7],
                            totalSPF104.ToString("c2"));
                        receipt.Show();
                    }
                }

                if (numOfEasy >= 0)
                {
                    if (numOfEasy == 0)
                    {
                        // If equal to zero do nothing
                    }
                    else if (numOfSinkers < 0 || numOfConExterior < 0 || numOfConInterior < 0 ||
                   numOfConPrimer < 0 || numOfLVLe < 0 || numOfSPF12 < 0 || numOfSPF8 < 0 || 
                   numOfSPF104 < 0 || numOfOSB < 0 || numOfGalv < 0 || numOfG90 < 0 || numOfGyps < 0 || 
                   numOfPoly < 0 || numOfR25 < 0 || numOfAC2 < 0 || numOfUnfaced < 0 || numOfRIM < 0 || 
                   numOfStrait < 0 || numOfJoist < 0)
                    {
                        string message = "Please enter a whole number greater " +
                            "than zero for item quantity.";
                        string caption = "Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;

                        result = MessageBox.Show(message, caption, buttons);
                    }
                    else
                    {
                        receipt.SetOrderTextBox(numOfEasy.ToString("0"), itemNames[8],
                            totalEasy.ToString("c2"));
                        receipt.Show();
                    }
                }

                if (numOfOSB >= 0)
                {
                    if (numOfOSB == 0)
                    {
                        // If equal to zero do nothing
                    }
                    else if (numOfSinkers < 0 || numOfConExterior < 0 || numOfConInterior < 0 ||
                   numOfConPrimer < 0 || numOfLVLe < 0 || numOfSPF12 < 0 || numOfSPF8 < 0 || 
                   numOfSPF104 < 0 || numOfEasy < 0 || numOfGalv < 0 || numOfG90 < 0 || numOfGyps < 0 ||
                   numOfPoly < 0 || numOfR25 < 0 || numOfAC2 < 0 || numOfUnfaced < 0 || numOfRIM < 0 || 
                   numOfStrait < 0 || numOfJoist < 0)
                    {
                        string message = "Please enter a whole number greater " +
                            "than zero for item quantity.";
                        string caption = "Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;

                        result = MessageBox.Show(message, caption, buttons);
                    }
                    else
                    {
                        receipt.SetOrderTextBox(numOfOSB.ToString("0"), itemNames[9],
                            totalOSB.ToString("c2"));
                        receipt.Show();
                    }
                }

                if (numOfGalv >= 0)
                {
                    if (numOfGalv == 0)
                    {
                        // If equal to zero do nothing
                    }
                    else if (numOfSinkers < 0 || numOfConExterior < 0 || numOfConInterior < 0 ||
                   numOfConPrimer < 0 || numOfLVLe < 0 || numOfSPF12 < 0 || numOfSPF8 < 0 || 
                   numOfSPF104 < 0 || numOfEasy < 0 || numOfOSB < 0 || numOfG90 < 0 || numOfGyps < 0 || 
                   numOfPoly < 0 || numOfR25 < 0 || numOfAC2 < 0 || numOfUnfaced < 0 || numOfRIM < 0 || 
                   numOfStrait < 0 || numOfJoist < 0)
                    {
                        string message = "Please enter a whole number greater " +
                            "than zero for item quantity.";
                        string caption = "Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;

                        result = MessageBox.Show(message, caption, buttons);
                    }
                    else
                    {
                        receipt.SetOrderTextBox(numOfGalv.ToString("0"), itemNames[10],
                            totalGalv.ToString("c2"));
                        receipt.Show();
                    }
                }

                if (numOfG90 >= 0)
                {
                    if (numOfG90 == 0)
                    {
                        // If equal to zero do nothing
                    }
                    else if (numOfSinkers < 0 || numOfConExterior < 0 || numOfConInterior < 0 ||
                   numOfConPrimer < 0 || numOfLVLe < 0 || numOfSPF12 < 0 || numOfSPF8 < 0 || 
                   numOfSPF104 < 0 || numOfEasy < 0 || numOfOSB < 0 || numOfGalv < 0 || numOfGyps < 0 ||
                   numOfPoly < 0 || numOfR25 < 0 || numOfAC2 < 0 || numOfUnfaced < 0 || numOfRIM < 0 || 
                   numOfStrait < 0 || numOfJoist < 0)
                    {
                        string message = "Please enter a whole number greater " +
                            "than zero for item quantity.";
                        string caption = "Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;

                        result = MessageBox.Show(message, caption, buttons);
                    }
                    else
                    {
                        receipt.SetOrderTextBox(numOfG90.ToString("0"), itemNames[11],
                            totalG90.ToString("c2"));
                        receipt.Show();
                    }
                }

                if (numOfGyps >= 0)
                {
                    if (numOfGyps == 0)
                    {
                        // If equal to zero do nothing
                    }
                    else if (numOfSinkers < 0 || numOfConExterior < 0 || numOfConInterior < 0 ||
                   numOfConPrimer < 0 || numOfLVLe < 0 || numOfSPF12 < 0 || numOfSPF8 < 0 || 
                   numOfSPF104 < 0 || numOfEasy < 0 || numOfOSB < 0 || numOfGalv < 0 || numOfG90 < 0 || 
                   numOfPoly < 0 || numOfR25 < 0 || numOfAC2 < 0 || numOfUnfaced < 0 || numOfRIM < 0 || 
                   numOfStrait < 0 || numOfJoist < 0)
                    {
                        string message = "Please enter a whole number greater " +
                            "than zero for item quantity.";
                        string caption = "Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;

                        result = MessageBox.Show(message, caption, buttons);
                    }
                    else
                    {
                        receipt.SetOrderTextBox(numOfGyps.ToString("0"), itemNames[12],
                            totalGyps.ToString("c2"));
                        receipt.Show();
                    }
                }

                if (numOfPoly >= 0)
                {
                    if (numOfPoly == 0)
                    {
                        // If equal to zero do nothing
                    }
                    else if (numOfSinkers < 0 || numOfConExterior < 0 || numOfConInterior < 0 ||
                   numOfConPrimer < 0 || numOfLVLe < 0 || numOfSPF12 < 0 || numOfSPF8 < 0 || 
                   numOfSPF104 < 0 || numOfEasy < 0 || numOfOSB < 0 || numOfGalv < 0 || numOfG90 < 0 || 
                   numOfGyps < 0 || numOfR25 < 0 || numOfAC2 < 0 || numOfUnfaced < 0 || numOfRIM < 0 ||
                   numOfStrait < 0 || numOfJoist < 0)
                    {
                        string message = "Please enter a whole number greater " +
                            "than zero for item quantity.";
                        string caption = "Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;

                        result = MessageBox.Show(message, caption, buttons);
                    }
                    else
                    {
                        receipt.SetOrderTextBox(numOfPoly.ToString("0"), itemNames[13],
                            totalPoly.ToString("c2"));
                        receipt.Show();
                    }
                }

                if (numOfR25 >= 0)
                {
                    if (numOfR25 == 0)
                    {
                        // If equal to zero do nothing
                    }
                    else if (numOfSinkers < 0 || numOfConExterior < 0 || numOfConInterior < 0 ||
                   numOfConPrimer < 0 || numOfLVLe < 0 || numOfSPF12 < 0 || numOfSPF8 < 0 || 
                   numOfSPF104 < 0 || numOfEasy < 0 || numOfOSB < 0 || numOfGalv < 0 || numOfG90 < 0 || 
                   numOfGyps < 0 || numOfPoly < 0 || numOfAC2 < 0 || numOfUnfaced < 0 || numOfRIM < 0 ||
                   numOfStrait < 0 || numOfJoist < 0)
                    {
                        string message = "Please enter a whole number greater " +
                            "than zero for item quantity.";
                        string caption = "Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;

                        result = MessageBox.Show(message, caption, buttons);
                    }
                    else
                    {
                        receipt.SetOrderTextBox(numOfR25.ToString("0"), itemNames[14],
                        totalR25.ToString("c2"));
                        receipt.Show();
                    }
                }

                if (numOfAC2 >= 0)
                {
                    if (numOfAC2 == 0)
                    {
                        // If equal to zero do nothing
                    }
                    else if (numOfSinkers < 0 || numOfConExterior < 0 || numOfConInterior < 0 ||
                   numOfConPrimer < 0 || numOfLVLe < 0 || numOfSPF12 < 0 || numOfSPF8 < 0 || 
                   numOfSPF104 < 0 || numOfEasy < 0 || numOfOSB < 0 || numOfGalv < 0 || numOfG90 < 0 || 
                   numOfGyps < 0 || numOfPoly < 0 || numOfR25 < 0 || numOfUnfaced < 0 || numOfRIM < 0 ||
                   numOfStrait < 0 || numOfJoist < 0)
                    {
                        string message = "Please enter a whole number greater " +
                            "than zero for item quantity.";
                        string caption = "Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;

                        result = MessageBox.Show(message, caption, buttons);
                    }
                    else
                    {
                        receipt.SetOrderTextBox(numOfAC2.ToString("0"), itemNames[15],
                            totalAC2.ToString("c2"));
                        receipt.Show();
                    }
                }

                if (numOfUnfaced >= 0)
                {
                    if (numOfUnfaced == 0)
                    {
                        // If equal to zero do nothing
                    }
                    else if (numOfSinkers < 0 || numOfConExterior < 0 || numOfConInterior < 0 ||
                   numOfConPrimer < 0 || numOfLVLe < 0 || numOfSPF12 < 0 || numOfSPF8 < 0 || 
                   numOfSPF104 < 0 || numOfEasy < 0 || numOfOSB < 0 || numOfGalv < 0 || numOfG90 < 0 ||
                   numOfGyps < 0 || numOfPoly < 0 || numOfR25 < 0 || numOfAC2 < 0 || numOfRIM < 0 || 
                   numOfStrait < 0 || numOfJoist < 0)
                    {
                        string message = "Please enter a whole number greater " +
                            "than zero for item quantity.";
                        string caption = "Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;

                        result = MessageBox.Show(message, caption, buttons);
                    }
                    else
                    {
                        receipt.SetOrderTextBox(numOfUnfaced.ToString("0"), itemNames[16],
                            totalUnfaced.ToString("c2"));
                        receipt.Show();
                    }
                }

                if (numOfRIM >= 0)
                {
                    if (numOfRIM == 0)
                    {
                        // If equal to zero do nothing
                    }
                    else if (numOfSinkers < 0 || numOfConExterior < 0 || numOfConInterior < 0 ||
                   numOfConPrimer < 0 || numOfLVLe < 0 || numOfSPF12 < 0 || numOfSPF8 < 0 || 
                   numOfSPF104 < 0 || numOfEasy < 0 || numOfOSB < 0 || numOfGalv < 0 || numOfG90 < 0 || 
                   numOfGyps < 0 || numOfPoly < 0 || numOfR25 < 0 || numOfAC2 < 0 || numOfUnfaced < 0 ||
                   numOfStrait < 0 || numOfJoist < 0)
                    {
                        string message = "Please enter a whole number greater " +
                            "than zero for item quantity.";
                        string caption = "Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;

                        result = MessageBox.Show(message, caption, buttons);
                    }
                    else
                    {
                        receipt.SetOrderTextBox(numOfRIM.ToString("0"), itemNames[17],
                        totalRIM.ToString("c2"));
                        receipt.Show();
                    }
                }

                if (numOfStrait >= 0)
                {
                    if (numOfStrait == 0)
                    {
                        // If equal to zero do nothing
                    }
                    else if (numOfSinkers < 0 || numOfConExterior < 0 || numOfConInterior < 0 ||
                   numOfConPrimer < 0 || numOfLVLe < 0 || numOfSPF12 < 0 || numOfSPF8 < 0 || 
                   numOfSPF104 < 0 || numOfEasy < 0 || numOfOSB < 0 || numOfGalv < 0 || numOfG90 < 0 ||
                   numOfGyps < 0 || numOfPoly < 0 || numOfR25 < 0 || numOfAC2 < 0 || numOfUnfaced < 0 ||
                   numOfRIM < 0 || numOfJoist < 0)
                    {
                        string message = "Please enter a whole number greater " +
                            "than zero for item quantity.";
                        string caption = "Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;

                        result = MessageBox.Show(message, caption, buttons);
                    }
                    else
                    {
                        receipt.SetOrderTextBox(numOfStrait.ToString("0"), itemNames[18],
                            totalStrait.ToString("c2"));
                        receipt.Show();
                    }
                }

                if (numOfJoist >= 0)
                {
                    if (numOfJoist == 0)
                    {
                        // If equal to zero do nothing
                    }
                    else if (numOfSinkers < 0 || numOfConExterior < 0 || numOfConInterior < 0 ||
                     numOfConPrimer < 0 || numOfLVLe < 0 || numOfSPF12 < 0 || numOfSPF8 < 0 || 
                     numOfSPF104 < 0 || numOfEasy < 0 || numOfOSB < 0 || numOfGalv < 0 || numOfG90 < 0 ||
                     numOfGyps < 0 || numOfPoly < 0 || numOfR25 < 0 || numOfAC2 < 0 || 
                     numOfUnfaced < 0 || numOfRIM < 0 || numOfStrait < 0)
                    {
                        string message = "Please enter a whole number greater " +
                            "than zero for item quantity.";
                        string caption = "Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;

                        result = MessageBox.Show(message, caption, buttons);
                    }
                    else
                    {
                        receipt.SetOrderTextBox(numOfJoist.ToString("0"), itemNames[19],
                            totalJoist.ToString("c2"));
                        receipt.Show();
                    }
                }

                // If user checks company service apply labor fee and display it in 
                // the labor textbox in Summary Form, else the labor cost displayed is zero
                if (companyRadiobtn.Checked)
                {

                    receipt.SetLaborTextBox(laborCost.ToString("c2"));
                }
                else
                {
                    laborCost = 0.00;
                    receipt.SetLaborTextBox(laborCost.ToString("c2"));
                }

                // Calculates grand total        
                double total = taxAmount + subtotal + laborCost;

                // Display tax, subtotal, and grand total in their proper textboxes
                // in the Summary Form
                receipt.SetTaxTextBox(taxAmount.ToString("c2"));
                receipt.SetSubtotalTextBox(subtotal.ToString("c2"));
                receipt.SetTotalTextBox(total.ToString("c2"));

            }
            // Catch any format errors that occur in the Order Form and display error message
            // to notify user to input accepted values only
            catch (FormatException)
            {
                string message = "Please enter whole numbers only for item quantity.";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
            }

        }

        private void detailsBtn_Click(object sender, EventArgs e)
        {
            // Access and display the Details Form that is connected to the database
            Details display = new Details();
            display.Show();
        }
    }

}
