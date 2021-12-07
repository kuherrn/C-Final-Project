
namespace WindowsFormsApp1 {
    partial class AddDealership {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this._dealership = new System.Windows.Forms.Label();
            this._address = new System.Windows.Forms.Label();
            this._street = new System.Windows.Forms.Label();
            this._city = new System.Windows.Forms.Label();
            this._province = new System.Windows.Forms.Label();
            this._postal = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dealershipInput = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.streetNameInput = new System.Windows.Forms.TextBox();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.provinceInput = new System.Windows.Forms.TextBox();
            this.postalCodeInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(429, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "Upload Picture";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _dealership
            // 
            this._dealership.AutoSize = true;
            this._dealership.Location = new System.Drawing.Point(236, 456);
            this._dealership.Name = "_dealership";
            this._dealership.Size = new System.Drawing.Size(207, 29);
            this._dealership.TabIndex = 2;
            this._dealership.Text = "Dealership Name:";
            // 
            // _address
            // 
            this._address.AutoSize = true;
            this._address.Location = new System.Drawing.Point(236, 503);
            this._address.Name = "_address";
            this._address.Size = new System.Drawing.Size(102, 29);
            this._address.TabIndex = 3;
            this._address.Text = "Address";
            // 
            // _street
            // 
            this._street.AutoSize = true;
            this._street.Location = new System.Drawing.Point(288, 551);
            this._street.Name = "_street";
            this._street.Size = new System.Drawing.Size(154, 29);
            this._street.TabIndex = 4;
            this._street.Text = "Street Name:";
            // 
            // _city
            // 
            this._city.AutoSize = true;
            this._city.Location = new System.Drawing.Point(288, 598);
            this._city.Name = "_city";
            this._city.Size = new System.Drawing.Size(59, 29);
            this._city.TabIndex = 5;
            this._city.Text = "City:";
            // 
            // _province
            // 
            this._province.AutoSize = true;
            this._province.Location = new System.Drawing.Point(289, 646);
            this._province.Name = "_province";
            this._province.Size = new System.Drawing.Size(113, 29);
            this._province.TabIndex = 6;
            this._province.Text = "Province:";
            // 
            // _postal
            // 
            this._postal.AutoSize = true;
            this._postal.Location = new System.Drawing.Point(288, 694);
            this._postal.Name = "_postal";
            this._postal.Size = new System.Drawing.Size(151, 29);
            this._postal.TabIndex = 7;
            this._postal.Text = "Postal Code:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(294, 749);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 63);
            this.button2.TabIndex = 8;
            this.button2.Text = "Create";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dealershipInput
            // 
            this.dealershipInput.Location = new System.Drawing.Point(618, 459);
            this.dealershipInput.Name = "dealershipInput";
            this.dealershipInput.Size = new System.Drawing.Size(251, 35);
            this.dealershipInput.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // streetNameInput
            // 
            this.streetNameInput.Location = new System.Drawing.Point(618, 551);
            this.streetNameInput.Name = "streetNameInput";
            this.streetNameInput.Size = new System.Drawing.Size(251, 35);
            this.streetNameInput.TabIndex = 11;
            // 
            // cityInput
            // 
            this.cityInput.Location = new System.Drawing.Point(618, 598);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(251, 35);
            this.cityInput.TabIndex = 12;
            // 
            // provinceInput
            // 
            this.provinceInput.Location = new System.Drawing.Point(618, 646);
            this.provinceInput.Name = "provinceInput";
            this.provinceInput.Size = new System.Drawing.Size(251, 35);
            this.provinceInput.TabIndex = 13;
            // 
            // postalCodeInput
            // 
            this.postalCodeInput.Location = new System.Drawing.Point(618, 694);
            this.postalCodeInput.Name = "postalCodeInput";
            this.postalCodeInput.Size = new System.Drawing.Size(251, 35);
            this.postalCodeInput.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(613, 766);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 16;
            // 
            // AddDealership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.postalCodeInput);
            this.Controls.Add(this.provinceInput);
            this.Controls.Add(this.cityInput);
            this.Controls.Add(this.streetNameInput);
            this.Controls.Add(this.dealershipInput);
            this.Controls.Add(this.button2);
            this.Controls.Add(this._postal);
            this.Controls.Add(this._province);
            this.Controls.Add(this._city);
            this.Controls.Add(this._street);
            this.Controls.Add(this._address);
            this.Controls.Add(this._dealership);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddDealership";
            this.Size = new System.Drawing.Size(1131, 978);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label _dealership;
        private System.Windows.Forms.Label _address;
        private System.Windows.Forms.Label _street;
        private System.Windows.Forms.Label _city;
        private System.Windows.Forms.Label _province;
        private System.Windows.Forms.Label _postal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox dealershipInput;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox streetNameInput;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.TextBox provinceInput;
        private System.Windows.Forms.TextBox postalCodeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
