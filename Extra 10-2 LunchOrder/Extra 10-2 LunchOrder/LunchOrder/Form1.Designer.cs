namespace LunchOrder
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
            if (disposing && (components != null))
            {
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
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.gbxAddOnItems = new System.Windows.Forms.GroupBox();
            this.chkAddOn3 = new System.Windows.Forms.CheckBox();
            this.chkAddOn2 = new System.Windows.Forms.CheckBox();
            this.chkAddOn1 = new System.Windows.Forms.CheckBox();
            this.gbxMainCourse = new System.Windows.Forms.GroupBox();
            this.rdoSalad = new System.Windows.Forms.RadioButton();
            this.rdoHamburger = new System.Windows.Forms.RadioButton();
            this.rdoPizza = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.gbxAddOnItems.SuspendLayout();
            this.gbxMainCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPlaceOrder.Location = new System.Drawing.Point(265, 142);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(88, 23);
            this.btnPlaceOrder.TabIndex = 17;
            this.btnPlaceOrder.Text = "Place &Order";
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.lblOrderTotal);
            this.GroupBox1.Controls.Add(this.lblSalesTax);
            this.GroupBox1.Controls.Add(this.lblSubtotal);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(17, 134);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(224, 104);
            this.GroupBox1.TabIndex = 21;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Order total";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrderTotal.Location = new System.Drawing.Point(104, 72);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(88, 20);
            this.lblOrderTotal.TabIndex = 5;
            this.lblOrderTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalesTax.Location = new System.Drawing.Point(104, 48);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(88, 20);
            this.lblSalesTax.TabIndex = 4;
            this.lblSalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubtotal.Location = new System.Drawing.Point(104, 24);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(88, 20);
            this.lblSubtotal.TabIndex = 3;
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(16, 72);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(80, 16);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Order total:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(16, 48);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(80, 16);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Tax (7.75%):";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(80, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Subtotal:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbxAddOnItems
            // 
            this.gbxAddOnItems.Controls.Add(this.chkAddOn3);
            this.gbxAddOnItems.Controls.Add(this.chkAddOn2);
            this.gbxAddOnItems.Controls.Add(this.chkAddOn1);
            this.gbxAddOnItems.Location = new System.Drawing.Point(169, 14);
            this.gbxAddOnItems.Name = "gbxAddOnItems";
            this.gbxAddOnItems.Size = new System.Drawing.Size(184, 104);
            this.gbxAddOnItems.TabIndex = 20;
            this.gbxAddOnItems.TabStop = false;
            this.gbxAddOnItems.Text = "Add-on items ($.75/each) ";
            // 
            // chkAddOn3
            // 
            this.chkAddOn3.Location = new System.Drawing.Point(8, 72);
            this.chkAddOn3.Name = "chkAddOn3";
            this.chkAddOn3.Size = new System.Drawing.Size(168, 20);
            this.chkAddOn3.TabIndex = 2;
            this.chkAddOn3.Text = "French fries";
            this.chkAddOn3.CheckedChanged += new System.EventHandler(this.ChangeAddOns);
            // 
            // chkAddOn2
            // 
            this.chkAddOn2.Location = new System.Drawing.Point(8, 48);
            this.chkAddOn2.Name = "chkAddOn2";
            this.chkAddOn2.Size = new System.Drawing.Size(168, 20);
            this.chkAddOn2.TabIndex = 1;
            this.chkAddOn2.Text = "Ketchup, mustard, and mayo";
            this.chkAddOn2.CheckedChanged += new System.EventHandler(this.ChangeAddOns);
            // 
            // chkAddOn1
            // 
            this.chkAddOn1.Location = new System.Drawing.Point(8, 24);
            this.chkAddOn1.Name = "chkAddOn1";
            this.chkAddOn1.Size = new System.Drawing.Size(168, 20);
            this.chkAddOn1.TabIndex = 0;
            this.chkAddOn1.Text = "Lettuce, tomato, and onions";
            this.chkAddOn1.CheckedChanged += new System.EventHandler(this.ChangeAddOns);
            // 
            // gbxMainCourse
            // 
            this.gbxMainCourse.Controls.Add(this.rdoSalad);
            this.gbxMainCourse.Controls.Add(this.rdoHamburger);
            this.gbxMainCourse.Controls.Add(this.rdoPizza);
            this.gbxMainCourse.Location = new System.Drawing.Point(17, 14);
            this.gbxMainCourse.Name = "gbxMainCourse";
            this.gbxMainCourse.Size = new System.Drawing.Size(144, 104);
            this.gbxMainCourse.TabIndex = 19;
            this.gbxMainCourse.TabStop = false;
            this.gbxMainCourse.Text = "Main course";
            // 
            // rdoSalad
            // 
            this.rdoSalad.Location = new System.Drawing.Point(8, 72);
            this.rdoSalad.Name = "rdoSalad";
            this.rdoSalad.Size = new System.Drawing.Size(128, 20);
            this.rdoSalad.TabIndex = 2;
            this.rdoSalad.Text = "Salad - $4.95";
            this.rdoSalad.CheckedChanged += new System.EventHandler(this.MainCourse_CheckedChanged);
            // 
            // rdoHamburger
            // 
            this.rdoHamburger.Checked = true;
            this.rdoHamburger.Location = new System.Drawing.Point(8, 24);
            this.rdoHamburger.Name = "rdoHamburger";
            this.rdoHamburger.Size = new System.Drawing.Size(128, 20);
            this.rdoHamburger.TabIndex = 0;
            this.rdoHamburger.TabStop = true;
            this.rdoHamburger.Text = "Hamburger - $6.95";
            this.rdoHamburger.CheckedChanged += new System.EventHandler(this.MainCourse_CheckedChanged);
            // 
            // rdoPizza
            // 
            this.rdoPizza.Location = new System.Drawing.Point(8, 48);
            this.rdoPizza.Name = "rdoPizza";
            this.rdoPizza.Size = new System.Drawing.Size(128, 20);
            this.rdoPizza.TabIndex = 1;
            this.rdoPizza.Text = "Pizza - $5.95";
            this.rdoPizza.CheckedChanged += new System.EventHandler(this.MainCourse_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(265, 214);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 23);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnPlaceOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(377, 251);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.gbxAddOnItems);
            this.Controls.Add(this.gbxMainCourse);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lunch Order";
            this.GroupBox1.ResumeLayout(false);
            this.gbxAddOnItems.ResumeLayout(false);
            this.gbxMainCourse.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnPlaceOrder;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label lblOrderTotal;
        internal System.Windows.Forms.Label lblSalesTax;
        internal System.Windows.Forms.Label lblSubtotal;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox gbxAddOnItems;
        internal System.Windows.Forms.CheckBox chkAddOn3;
        internal System.Windows.Forms.CheckBox chkAddOn2;
        internal System.Windows.Forms.CheckBox chkAddOn1;
        internal System.Windows.Forms.GroupBox gbxMainCourse;
        internal System.Windows.Forms.RadioButton rdoSalad;
        internal System.Windows.Forms.RadioButton rdoHamburger;
        internal System.Windows.Forms.RadioButton rdoPizza;
        internal System.Windows.Forms.Button btnExit;
    }
}

