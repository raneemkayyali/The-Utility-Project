/* Author: Raneem Kayyali
 * Date: 11/27/2017
 * The U-tility Project: Details Form
 */
using System;
using System.Windows.Forms;

namespace The_Utility_Project
{
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        private void Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'utilityDatabaseDataSet.tblProducts' table. You can move, or remove it, as needed.
            this.tblProductsTableAdapter.Fill(this.utilityDatabaseDataSet.tblProducts);

        }
    }
}
