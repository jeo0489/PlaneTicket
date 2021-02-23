using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaneTicket {
	public partial class Form1 : Form {
		private string[] destinations = {
			"Munich (MUC)",
			"London Heathrow (LHR)",
			"Liverpool J. Lennon (LVP)"
		};

		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			DestinationSelector.Items.AddRange(destinations);
			dateTimeDOB.MinDate = new DateTime(1900, 1, 1);
			dateTimeDOB.MaxDate = new DateTime(2004, 12, 12);
			dateTimeDeparture.MinDate = DateTime.Today;
		}

		private bool validLocation() {
			foreach (string dest in DestinationSelector.Items) {
				if (dest == DestinationSelector.Text) {
					return true;
				}
			}

			MessageBox.Show("Invalid Airport!");
			DestinationSelector.Text = "";
			return false;
		}

		private bool validTicketNum() {
			if (UpDwnAdults.Value < 1) {
				MessageBox.Show("No Adult tickets!");
				return false;
			} else if (UpDwnAdults.Value > 50 || UpDwnChild.Value > 50 || UpDwnOAP.Value > 50) {
				MessageBox.Show("No ticket order > 50!");
				return false;
			} else {
				return true;
			}
		}

		private bool validName() {
			if (Regex.IsMatch(txtName.Text, @"^\[0-9]+$")) {
				MessageBox.Show("Numeric names are not allowed!");
				return false;
			} else {
				return true;
			}
		}

		private bool validExtraBag() {
			if (radioExtraBags.Checked && UpDwnExtraBags.Value <= 0) {
				MessageBox.Show("The extra bagagge amount (in kg) must be > 0!");
				return false;
			} else if (radioExtraBags.Checked && UpDwnExtraBags.Value > 25) {
				MessageBox.Show("The extra bagagge amount (in kg) must be <= 25!");
				return false;
			}
			return true;
		}

		private bool allValid() {
			if (validLocation() && validTicketNum() && validName() && validExtraBag()) {
				return true;
			} else {
				return false;
			}
		}

		int getRate() {
			switch (DestinationSelector.Text) {
				case "Munich (MUC)":
					return 90;
				case "London Heathrow (LHR)":
					return 35;
				case "Liverpool J. Lennon (LVP)":
					return 55;
			}
			return -1;
		}

		private float discountForX(int X) {
			// Returns a multiplier for the cost of an individual to be multiplied by
			float mult = 1f;

			if(X == 1) { // Gets child discount
				mult = mult - 0.15f;			// 15 percent off
			} else if (X == 2) { // Gets OAP discount
				mult = mult = 0.1f;				// 10 percent off
			}
			
			return mult;
		}

		private float finalDiscount() {
			// Returns a multiplier for the total cost to be multiplied by
			/* Global Discounts include:
			 *		
			 * 
			 */
			float mult = 1f;
			return mult;
		}

		private float costForX(int X, int numOfX) {
			if (X > 2 || X < 0) {
				Console.WriteLine("invalid value of X - out of range");
				return -1;
			}

			// X signifies either Adult (0), Child (1) or OAP (2) - Use enum next time
			switch (X) {
				case 0:
					return (getRate() * discountForX(0)) * numOfX;
				case 1:
					return (getRate() * discountForX(1)) * numOfX;
				case 2:
					return (getRate() * discountForX(2)) * numOfX;
			}
			return -1.0f;
		}

		private void showCost(float cost) {
			lblCost.Text = "";
		}

		void btnGetCost_Click(object sender, EventArgs e) {
			/* 
			 * adult's cost at index 0
			 * children's cost at index 1
			 * OAP's cost at index 2
			 */
			int passengers = (int)UpDwnAdults.Value + (int)UpDwnChild.Value + (int)UpDwnOAP.Value;
			int numOfAdults = (int)UpDwnAdults.Value, numOfChildren = (int)UpDwnChild.Value, numOfOAP = (int)UpDwnOAP.Value;
			float totalCost;
			float[] individualCosts = { 0.0f, 0.0f, 0.0f };
			individualCosts[0] = costForX(0, numOfAdults);
			individualCosts[1] = costForX(1, numOfChildren);
			individualCosts[2] = costForX(2, numOfOAP);

			if (allValid()) {

				totalCost = individualCosts.Sum() * finalDiscount();
				showCost(totalCost);
			}
		}
	}
}