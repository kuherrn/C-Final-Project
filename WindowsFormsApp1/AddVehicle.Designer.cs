
namespace WindowsFormsApp1 {
    partial class AddVehicle {
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
            this._make = new System.Windows.Forms.Label();
            this._model = new System.Windows.Forms.Label();
            this._condition = new System.Windows.Forms.Label();
            this._cylinder = new System.Windows.Forms.Label();
            this._build = new System.Windows.Forms.Label();
            this._door = new System.Windows.Forms.Label();
            this._price = new System.Windows.Forms.Label();
            this._color = new System.Windows.Forms.Label();
            this._sold = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Make = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Color = new System.Windows.Forms.TextBox();
            this.Condition = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Doors = new System.Windows.Forms.NumericUpDown();
            this.Cylinders = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Doors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cylinders)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(358, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 239);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 61);
            this.button1.TabIndex = 2;
            this.button1.Text = "Upload Picture";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // _make
            // 
            this._make.AutoSize = true;
            this._make.Location = new System.Drawing.Point(148, 445);
            this._make.Name = "_make";
            this._make.Size = new System.Drawing.Size(84, 29);
            this._make.TabIndex = 3;
            this._make.Text = "Make: ";
            // 
            // _model
            // 
            this._model.AutoSize = true;
            this._model.Location = new System.Drawing.Point(148, 494);
            this._model.Name = "_model";
            this._model.Size = new System.Drawing.Size(87, 29);
            this._model.TabIndex = 4;
            this._model.Text = "Model:";
            // 
            // _condition
            // 
            this._condition.AutoSize = true;
            this._condition.Location = new System.Drawing.Point(148, 542);
            this._condition.Name = "_condition";
            this._condition.Size = new System.Drawing.Size(122, 29);
            this._condition.TabIndex = 5;
            this._condition.Text = "Condition:";
            // 
            // _cylinder
            // 
            this._cylinder.AutoSize = true;
            this._cylinder.Location = new System.Drawing.Point(148, 592);
            this._cylinder.Name = "_cylinder";
            this._cylinder.Size = new System.Drawing.Size(246, 29);
            this._cylinder.TabIndex = 6;
            this._cylinder.Text = "No. Engine Cylinders:";
            // 
            // _build
            // 
            this._build.AutoSize = true;
            this._build.Location = new System.Drawing.Point(148, 639);
            this._build.Name = "_build";
            this._build.Size = new System.Drawing.Size(131, 29);
            this._build.TabIndex = 7;
            this._build.Text = "Build Year:";
            // 
            // _door
            // 
            this._door.AutoSize = true;
            this._door.Location = new System.Drawing.Point(148, 688);
            this._door.Name = "_door";
            this._door.Size = new System.Drawing.Size(128, 29);
            this._door.TabIndex = 8;
            this._door.Text = "No. Doors:";
            // 
            // _price
            // 
            this._price.AutoSize = true;
            this._price.Location = new System.Drawing.Point(148, 736);
            this._price.Name = "_price";
            this._price.Size = new System.Drawing.Size(69, 29);
            this._price.TabIndex = 9;
            this._price.Text = "Price";
            // 
            // _color
            // 
            this._color.AutoSize = true;
            this._color.Location = new System.Drawing.Point(148, 783);
            this._color.Name = "_color";
            this._color.Size = new System.Drawing.Size(72, 29);
            this._color.TabIndex = 10;
            this._color.Text = "Color";
            // 
            // _sold
            // 
            this._sold.AutoSize = true;
            this._sold.Location = new System.Drawing.Point(148, 826);
            this._sold.Name = "_sold";
            this._sold.Size = new System.Drawing.Size(125, 29);
            this._sold.TabIndex = 11;
            this._sold.Text = "Date Sold:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(274, 825);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(139, 33);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Not Sold";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Make
            // 
            this.Make.Location = new System.Drawing.Point(681, 442);
            this.Make.Name = "Make";
            this.Make.Size = new System.Drawing.Size(307, 35);
            this.Make.TabIndex = 14;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Color
            // 
            this.Color.Location = new System.Drawing.Point(681, 780);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(307, 35);
            this.Color.TabIndex = 16;
            // 
            // Condition
            // 
            this.Condition.Location = new System.Drawing.Point(681, 539);
            this.Condition.Name = "Condition";
            this.Condition.Size = new System.Drawing.Size(307, 35);
            this.Condition.TabIndex = 17;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(681, 733);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(307, 35);
            this.Price.TabIndex = 18;
            // 
            // Model
            // 
            this.Model.Location = new System.Drawing.Point(681, 491);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(307, 35);
            this.Model.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(788, 634);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 35);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(788, 826);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 35);
            this.dateTimePicker2.TabIndex = 21;
            // 
            // Doors
            // 
            this.Doors.Location = new System.Drawing.Point(868, 686);
            this.Doors.Name = "Doors";
            this.Doors.Size = new System.Drawing.Size(120, 35);
            this.Doors.TabIndex = 22;
            // 
            // Cylinders
            // 
            this.Cylinders.Location = new System.Drawing.Point(868, 590);
            this.Cylinders.Name = "Cylinders";
            this.Cylinders.Size = new System.Drawing.Size(120, 35);
            this.Cylinders.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(728, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 24;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(148, 876);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(212, 63);
            this.save.TabIndex = 25;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(633, 897);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 26;
            // 
            // AddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cylinders);
            this.Controls.Add(this.Doors);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Condition);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.Make);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this._sold);
            this.Controls.Add(this._color);
            this.Controls.Add(this._price);
            this.Controls.Add(this._door);
            this.Controls.Add(this._build);
            this.Controls.Add(this._cylinder);
            this.Controls.Add(this._condition);
            this.Controls.Add(this._model);
            this.Controls.Add(this._make);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddVehicle";
            this.Size = new System.Drawing.Size(1131, 978);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Doors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cylinders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label _make;
        private System.Windows.Forms.Label _model;
        private System.Windows.Forms.Label _condition;
        private System.Windows.Forms.Label _cylinder;
        private System.Windows.Forms.Label _build;
        private System.Windows.Forms.Label _door;
        private System.Windows.Forms.Label _price;
        private System.Windows.Forms.Label _color;
        private System.Windows.Forms.Label _sold;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox Make;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox Color;
        private System.Windows.Forms.TextBox Condition;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Model;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.NumericUpDown Doors;
        private System.Windows.Forms.NumericUpDown Cylinders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label2;
        private string dealership { get; set; }
    }
}
