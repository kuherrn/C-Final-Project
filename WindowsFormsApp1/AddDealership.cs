using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {

    public class DealershipArgs : EventArgs {
        public AddDealership Dealer { get; set; }
    }

    //public delegate void MyEventHandler(object source, string s);
    public partial class AddDealership : UserControl {

        public event EventHandler<DealershipArgs> Dealership;
        protected virtual void OnDealershipName(AddDealership dealer) {
            if (Dealership != null)
                Dealership(this, new DealershipArgs() { Dealer = dealer });
        }
        public AddDealership() {
            InitializeComponent();
        }

        public void button2_Click(object sender, EventArgs e) {
            this.label1.Text = "";
            this.label2.Text = "";
            int fields = 0;
            int logo = 0;
            List<TextBox> myTextBoxes = new List<TextBox>();
            foreach (Control c in Controls) {
                if (c is TextBox)
                    myTextBoxes.Add((TextBox)c);
            }


            foreach (TextBox txtbox in myTextBoxes) {
                if (string.IsNullOrWhiteSpace(txtbox.Text)) {
                    fields++;
                    this.label1.Text = $"All fields must be filled!";
                }
            }

            if (pictureBox1.Image == null) {
                logo++;
                this.label2.Text = "Please upload Company Logo";
            }

            if (logo == 0 && fields == 0) {
                TextInfo input = new CultureInfo("en-US", false).TextInfo;
                string dealership = input.ToTitleCase(dealershipInput.Text);

                if (!Directory.Exists($"./Dealerships/{dealership}")) {
                    Directory.CreateDirectory($"./Dealerships/{dealership}");
                    using (FileStream fs = new FileStream($"./Dealerships/{dealership}/{dealership}_info.txt", FileMode.Append, FileAccess.Write)) {
                        StreamWriter streamWriter = new StreamWriter(fs);
                        streamWriter.Write($"Dealership Name: {dealership}\n" +
                            $"Address\n" +
                            $"\tStreet Name: {streetNameInput.Text}\n" +
                            $"\tCity: {cityInput.Text}\n" +
                            $"\tProvince: {provinceInput.Text}\n" +
                            $"\tPostal Code: {postalCodeInput.Text}");
                        streamWriter.Flush();
                        streamWriter.Close();
                        fs.Close();
                    }
                    // Change to 'AddVehicle' Panel
                    if (!Home.Instance.PnlContainer.Controls.ContainsKey("AddVehicle")) {
                        AddVehicle newVehicle = new AddVehicle();
                        newVehicle.Dock = DockStyle.Fill;
                        Home.Instance.PnlContainer.Controls.Add(newVehicle);
                        Console.WriteLine("Here");
                    }
                    OnDealershipName(this);
                    Home.Instance.PnlContainer.Controls["AddVehicle"].BringToFront();
                } else {
                    label1.Text = $"{dealershipInput.Text} already exists!";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Image Files (*.jpg;*.jpeg;)|*.jpg;*.jpeg;";
            if (fd.ShowDialog() == DialogResult.OK) {
                pictureBox1.Image = new Bitmap(fd.FileName);
            }
        }

        
    }
}
