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
    public partial class AddVehicle : UserControl {
        public AddVehicle() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {
            int logo = 0;
            int counter = 0;
            List<Label> myErrorLabels = new List<Label>
            { label1, label2 };
            List<TextBox> inputTextBoxes = new List<TextBox> { Make, Model, Condition, Color, Price };
            List<NumericUpDown> inputNumbers = new List<NumericUpDown> { Cylinders, Doors };

            foreach (Label l in myErrorLabels) {
                l.Text = "";
            }

            foreach (TextBox tb in inputTextBoxes) {
                if (string.IsNullOrWhiteSpace(tb.Text)) {
                    label2.Text = $"{tb.Name} field cannot be empty!";
                    counter++;
                    break;
                }
            }

            foreach (NumericUpDown ud in inputNumbers) {
                if (ud.Value <= 0) {
                    label2.Text = $"{ud.Name} field must be a positive number";
                    counter++;
                    break;
                }
            }

            if (pictureBox1.Image == null) {
                logo++;
                this.label1.Text = "Please upload Company Logo";
            }

            if (logo == 0 && counter == 0) {
                // Save to file
                TextInfo input = new CultureInfo("en-US", false).TextInfo;

                using (FileStream fs = new FileStream($"./Dealerships/{dealership}/{dealerhship}_inventory.txt", FileMode.Append, FileAccess.Write)) {
                    string dateSold = checkBox1.Checked ? "NOT SOLD" : dateTimePicker2.Value.ToString();
                    string condition = string.Concat(Condition.Text[0].ToString().ToUpper(), Condition.Text.Substring(1));
                    StreamWriter streamWriter = new StreamWriter(fs);
                    streamWriter.Write(
                        $"\nMake: {this.Make.Text}\n" +
                        $"Model: {this.Model.Text}\n" +
                        $"Condition: {condition}\n" +
                        $"No. Engine Cylinders: {this.Cylinders.Value}\n" +
                        $"Build Year: {this.dateTimePicker1.Value}\n" +
                        $"No. Doors: {this.Doors.Value}\n" +
                        $"Price: {this.Price.Text}\n" +
                        $"Color: {Color.Text}\n" +
                        $"Date Sold: {dateSold}\n");
                    streamWriter.Flush();
                    streamWriter.Close();
                    fs.Close();
                }
                label2.Text = $"{Make.Text} saved successfully!";
            }

            public void OnDealershipInput (object source, DealershipArgs args) {
                dealership = args.
            }
        }
    }
}
