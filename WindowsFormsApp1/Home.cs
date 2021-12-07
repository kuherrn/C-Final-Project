using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Home : Form {

        static Home _obj;
        public static Home Instance {
            get {
                if (_obj == null) {
                    _obj = new Home();
                }
                return _obj;
            }
        }

        public Panel PnlContainer {
            get { return MainScreen; }
            set { MainScreen = value; }
        }
       
        public Home() {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e) {
            if (!PnlContainer.Controls.ContainsKey("AddDealership")) {
                AddDealership newDealership = new AddDealership();
                newDealership.Dock = DockStyle.Fill;
                PnlContainer.Controls.Add(newDealership);
            }
            PnlContainer.Controls["AddDealership"].BringToFront();
        }

        private void addDeapership1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            if (!PnlContainer.Controls.ContainsKey("HomeView")) {
                HomeView home = new HomeView();
                home.Dock = DockStyle.Fill;
                PnlContainer.Controls.Add(home);
            }
            PnlContainer.Controls["HomeView"].BringToFront();
        }

        private void Home_Load(object sender, EventArgs e) {
            _obj = this;
            
        }
    }
}
