namespace PlaneTicket
{
	partial class Form1
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
			if (disposing && (components != null)) {
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
			this.DestinationSelector = new System.Windows.Forms.ComboBox();
			this.UpDwnAdults = new System.Windows.Forms.NumericUpDown();
			this.txtName = new System.Windows.Forms.TextBox();
			this.dateTimeDOB = new System.Windows.Forms.DateTimePicker();
			this.UpDwnExtraBags = new System.Windows.Forms.NumericUpDown();
			this.dateTimeDeparture = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.UpDwnChild = new System.Windows.Forms.NumericUpDown();
			this.UpDwnOAP = new System.Windows.Forms.NumericUpDown();
			this.lblName = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lblCost = new System.Windows.Forms.Label();
			this.btnGetCost = new System.Windows.Forms.Button();
			this.checkExtraBags = new System.Windows.Forms.CheckBox();
			this.checkReturn = new System.Windows.Forms.CheckBox();
			this.CheckFrequent = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.UpDwnAdults)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UpDwnExtraBags)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UpDwnChild)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UpDwnOAP)).BeginInit();
			this.SuspendLayout();
			// 
			// DestinationSelector
			// 
			this.DestinationSelector.FormattingEnabled = true;
			this.DestinationSelector.Location = new System.Drawing.Point(118, 48);
			this.DestinationSelector.Name = "DestinationSelector";
			this.DestinationSelector.Size = new System.Drawing.Size(121, 21);
			this.DestinationSelector.TabIndex = 0;
			// 
			// UpDwnAdults
			// 
			this.UpDwnAdults.Location = new System.Drawing.Point(118, 87);
			this.UpDwnAdults.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.UpDwnAdults.Name = "UpDwnAdults";
			this.UpDwnAdults.Size = new System.Drawing.Size(120, 20);
			this.UpDwnAdults.TabIndex = 1;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(118, 179);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(100, 20);
			this.txtName.TabIndex = 2;
			// 
			// dateTimeDOB
			// 
			this.dateTimeDOB.Location = new System.Drawing.Point(119, 205);
			this.dateTimeDOB.Name = "dateTimeDOB";
			this.dateTimeDOB.Size = new System.Drawing.Size(220, 20);
			this.dateTimeDOB.TabIndex = 3;
			// 
			// UpDwnExtraBags
			// 
			this.UpDwnExtraBags.Location = new System.Drawing.Point(219, 241);
			this.UpDwnExtraBags.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
			this.UpDwnExtraBags.Name = "UpDwnExtraBags";
			this.UpDwnExtraBags.Size = new System.Drawing.Size(120, 20);
			this.UpDwnExtraBags.TabIndex = 5;
			// 
			// dateTimeDeparture
			// 
			this.dateTimeDeparture.Location = new System.Drawing.Point(119, 276);
			this.dateTimeDeparture.Name = "dateTimeDeparture";
			this.dateTimeDeparture.Size = new System.Drawing.Size(220, 20);
			this.dateTimeDeparture.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Destination";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(345, 15);
			this.label2.TabIndex = 10;
			this.label2.Text = "Safe-ish Airlines -- Where your safety is sometimes considered";
			// 
			// UpDwnChild
			// 
			this.UpDwnChild.Location = new System.Drawing.Point(117, 113);
			this.UpDwnChild.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.UpDwnChild.Name = "UpDwnChild";
			this.UpDwnChild.Size = new System.Drawing.Size(120, 20);
			this.UpDwnChild.TabIndex = 11;
			// 
			// UpDwnOAP
			// 
			this.UpDwnOAP.Location = new System.Drawing.Point(118, 139);
			this.UpDwnOAP.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.UpDwnOAP.Name = "UpDwnOAP";
			this.UpDwnOAP.Size = new System.Drawing.Size(120, 20);
			this.UpDwnOAP.TabIndex = 12;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(12, 89);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(69, 13);
			this.lblName.TabIndex = 14;
			this.lblName.Text = "Adult Tickets";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 13);
			this.label3.TabIndex = 15;
			this.label3.Text = "Child Tickets";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 141);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 13);
			this.label4.TabIndex = 16;
			this.label4.Text = "OAP Tickets";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 182);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 13);
			this.label5.TabIndex = 17;
			this.label5.Text = "Full Name";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 206);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 13);
			this.label6.TabIndex = 18;
			this.label6.Text = "Adult\'s Date of Birth";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 276);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(92, 13);
			this.label7.TabIndex = 19;
			this.label7.Text = "Date of Departure";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 241);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(77, 13);
			this.label8.TabIndex = 20;
			this.label8.Text = "Extra Baggage";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(140, 243);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(41, 13);
			this.label9.TabIndex = 21;
			this.label9.Text = "Weight";
			// 
			// lblCost
			// 
			this.lblCost.AutoSize = true;
			this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCost.Location = new System.Drawing.Point(204, 371);
			this.lblCost.Name = "lblCost";
			this.lblCost.Size = new System.Drawing.Size(33, 15);
			this.lblCost.TabIndex = 23;
			this.lblCost.Text = "cost";
			// 
			// btnGetCost
			// 
			this.btnGetCost.Location = new System.Drawing.Point(103, 368);
			this.btnGetCost.Name = "btnGetCost";
			this.btnGetCost.Size = new System.Drawing.Size(75, 23);
			this.btnGetCost.TabIndex = 24;
			this.btnGetCost.Text = "Get Cost";
			this.btnGetCost.UseVisualStyleBackColor = true;
			this.btnGetCost.Click += new System.EventHandler(this.btnGetCost_Click);
			// 
			// checkExtraBags
			// 
			this.checkExtraBags.AutoSize = true;
			this.checkExtraBags.Location = new System.Drawing.Point(119, 243);
			this.checkExtraBags.Name = "checkExtraBags";
			this.checkExtraBags.Size = new System.Drawing.Size(15, 14);
			this.checkExtraBags.TabIndex = 25;
			this.checkExtraBags.UseVisualStyleBackColor = true;
			// 
			// checkReturn
			// 
			this.checkReturn.AutoSize = true;
			this.checkReturn.Location = new System.Drawing.Point(117, 307);
			this.checkReturn.Name = "checkReturn";
			this.checkReturn.Size = new System.Drawing.Size(58, 17);
			this.checkReturn.TabIndex = 26;
			this.checkReturn.Text = "Return";
			this.checkReturn.UseVisualStyleBackColor = true;
			// 
			// CheckFrequent
			// 
			this.CheckFrequent.AutoSize = true;
			this.CheckFrequent.Location = new System.Drawing.Point(117, 330);
			this.CheckFrequent.Name = "CheckFrequent";
			this.CheckFrequent.Size = new System.Drawing.Size(58, 17);
			this.CheckFrequent.TabIndex = 27;
			this.CheckFrequent.Text = "Return";
			this.CheckFrequent.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(381, 415);
			this.Controls.Add(this.CheckFrequent);
			this.Controls.Add(this.checkReturn);
			this.Controls.Add(this.checkExtraBags);
			this.Controls.Add(this.btnGetCost);
			this.Controls.Add(this.lblCost);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.UpDwnOAP);
			this.Controls.Add(this.UpDwnChild);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dateTimeDeparture);
			this.Controls.Add(this.UpDwnExtraBags);
			this.Controls.Add(this.dateTimeDOB);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.UpDwnAdults);
			this.Controls.Add(this.DestinationSelector);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.UpDwnAdults)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UpDwnExtraBags)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UpDwnChild)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UpDwnOAP)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox DestinationSelector;
		private System.Windows.Forms.NumericUpDown UpDwnAdults;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.DateTimePicker dateTimeDOB;
		private System.Windows.Forms.NumericUpDown UpDwnExtraBags;
		private System.Windows.Forms.DateTimePicker dateTimeDeparture;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown UpDwnChild;
		private System.Windows.Forms.NumericUpDown UpDwnOAP;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lblCost;
		private System.Windows.Forms.Button btnGetCost;
		private System.Windows.Forms.CheckBox checkExtraBags;
		private System.Windows.Forms.CheckBox checkReturn;
		private System.Windows.Forms.CheckBox CheckFrequent;
	}
}

