namespace WindowsFormsApplication1
{
    partial class PizzaParty
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.boxPepperoni = new System.Windows.Forms.CheckBox();
            this.boxSausage = new System.Windows.Forms.CheckBox();
            this.boxChicken = new System.Windows.Forms.CheckBox();
            this.boxOnions = new System.Windows.Forms.CheckBox();
            this.boxMushrooms = new System.Windows.Forms.CheckBox();
            this.boxBlackOlives = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.boxSoda = new System.Windows.Forms.CheckBox();
            this.boxCheeseBread = new System.Windows.Forms.CheckBox();
            this.boxBrownie = new System.Windows.Forms.CheckBox();
            this.boxCookie = new System.Windows.Forms.CheckBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lstOrderSummary = new System.Windows.Forms.ListBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtFinalTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // cboSize
            // 
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Location = new System.Drawing.Point(28, 42);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(121, 21);
            this.cboSize.TabIndex = 0;
            this.cboSize.Text = "Select a Size";
            // 
            // boxPepperoni
            // 
            this.boxPepperoni.AutoSize = true;
            this.boxPepperoni.Location = new System.Drawing.Point(6, 19);
            this.boxPepperoni.Name = "boxPepperoni";
            this.boxPepperoni.Size = new System.Drawing.Size(74, 17);
            this.boxPepperoni.TabIndex = 0;
            this.boxPepperoni.Text = "Pepperoni";
            this.boxPepperoni.UseVisualStyleBackColor = true;
            // 
            // boxSausage
            // 
            this.boxSausage.AutoSize = true;
            this.boxSausage.Location = new System.Drawing.Point(6, 42);
            this.boxSausage.Name = "boxSausage";
            this.boxSausage.Size = new System.Drawing.Size(68, 17);
            this.boxSausage.TabIndex = 1;
            this.boxSausage.Text = "Sausage";
            this.boxSausage.UseVisualStyleBackColor = true;
            // 
            // boxChicken
            // 
            this.boxChicken.AutoSize = true;
            this.boxChicken.Location = new System.Drawing.Point(6, 65);
            this.boxChicken.Name = "boxChicken";
            this.boxChicken.Size = new System.Drawing.Size(65, 17);
            this.boxChicken.TabIndex = 2;
            this.boxChicken.Text = "Chicken";
            this.boxChicken.UseVisualStyleBackColor = true;
            // 
            // boxOnions
            // 
            this.boxOnions.AutoSize = true;
            this.boxOnions.Location = new System.Drawing.Point(105, 19);
            this.boxOnions.Name = "boxOnions";
            this.boxOnions.Size = new System.Drawing.Size(59, 17);
            this.boxOnions.TabIndex = 3;
            this.boxOnions.Text = "Onions";
            this.boxOnions.UseVisualStyleBackColor = true;
            // 
            // boxMushrooms
            // 
            this.boxMushrooms.AutoSize = true;
            this.boxMushrooms.Location = new System.Drawing.Point(105, 42);
            this.boxMushrooms.Name = "boxMushrooms";
            this.boxMushrooms.Size = new System.Drawing.Size(80, 17);
            this.boxMushrooms.TabIndex = 4;
            this.boxMushrooms.Text = "Mushrooms";
            this.boxMushrooms.UseVisualStyleBackColor = true;
            // 
            // boxBlackOlives
            // 
            this.boxBlackOlives.AutoSize = true;
            this.boxBlackOlives.Location = new System.Drawing.Point(105, 65);
            this.boxBlackOlives.Name = "boxBlackOlives";
            this.boxBlackOlives.Size = new System.Drawing.Size(85, 17);
            this.boxBlackOlives.TabIndex = 5;
            this.boxBlackOlives.Text = "Black Olives";
            this.boxBlackOlives.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boxPepperoni);
            this.groupBox1.Controls.Add(this.boxBlackOlives);
            this.groupBox1.Controls.Add(this.boxSausage);
            this.groupBox1.Controls.Add(this.boxMushrooms);
            this.groupBox1.Controls.Add(this.boxChicken);
            this.groupBox1.Controls.Add(this.boxOnions);
            this.groupBox1.Location = new System.Drawing.Point(170, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 135);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toppings $0.50";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.boxSoda);
            this.groupBox2.Controls.Add(this.boxCheeseBread);
            this.groupBox2.Controls.Add(this.boxBrownie);
            this.groupBox2.Controls.Add(this.boxCookie);
            this.groupBox2.Location = new System.Drawing.Point(430, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 135);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extras $1.50";
            // 
            // boxSoda
            // 
            this.boxSoda.AutoSize = true;
            this.boxSoda.Location = new System.Drawing.Point(18, 88);
            this.boxSoda.Name = "boxSoda";
            this.boxSoda.Size = new System.Drawing.Size(51, 17);
            this.boxSoda.TabIndex = 3;
            this.boxSoda.Text = "Soda";
            this.boxSoda.UseVisualStyleBackColor = true;
            // 
            // boxCheeseBread
            // 
            this.boxCheeseBread.AutoSize = true;
            this.boxCheeseBread.Location = new System.Drawing.Point(18, 65);
            this.boxCheeseBread.Name = "boxCheeseBread";
            this.boxCheeseBread.Size = new System.Drawing.Size(93, 17);
            this.boxCheeseBread.TabIndex = 2;
            this.boxCheeseBread.Text = "Cheese Bread";
            this.boxCheeseBread.UseVisualStyleBackColor = true;
            // 
            // boxBrownie
            // 
            this.boxBrownie.AutoSize = true;
            this.boxBrownie.Location = new System.Drawing.Point(18, 42);
            this.boxBrownie.Name = "boxBrownie";
            this.boxBrownie.Size = new System.Drawing.Size(64, 17);
            this.boxBrownie.TabIndex = 1;
            this.boxBrownie.Text = "Brownie";
            this.boxBrownie.UseVisualStyleBackColor = true;
            // 
            // boxCookie
            // 
            this.boxCookie.AutoSize = true;
            this.boxCookie.Location = new System.Drawing.Point(18, 20);
            this.boxCookie.Name = "boxCookie";
            this.boxCookie.Size = new System.Drawing.Size(59, 17);
            this.boxCookie.TabIndex = 0;
            this.boxCookie.Text = "Cookie";
            this.boxCookie.UseVisualStyleBackColor = true;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(417, 213);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(75, 23);
            this.btnAddOrder.TabIndex = 3;
            this.btnAddOrder.Text = "Add to Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(417, 252);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(129, 23);
            this.btnCheckout.TabIndex = 4;
            this.btnCheckout.Text = "Proceed to Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // lstOrderSummary
            // 
            this.lstOrderSummary.FormattingEnabled = true;
            this.lstOrderSummary.Location = new System.Drawing.Point(28, 213);
            this.lstOrderSummary.Name = "lstOrderSummary";
            this.lstOrderSummary.Size = new System.Drawing.Size(363, 147);
            this.lstOrderSummary.TabIndex = 12;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(82, 378);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 13;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(417, 438);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtFinalTotal
            // 
            this.txtFinalTotal.Location = new System.Drawing.Point(82, 431);
            this.txtFinalTotal.Name = "txtFinalTotal";
            this.txtFinalTotal.Size = new System.Drawing.Size(100, 20);
            this.txtFinalTotal.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Subtotal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tax:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Total:";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(84, 404);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(98, 20);
            this.txtTax.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Kayla, Tyler, Heather, Jason";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(417, 296);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(63, 28);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear Order";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // PizzaParty
            // 
            this.AcceptButton = this.btnAddOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(622, 470);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFinalTotal);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lstOrderSummary);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboSize);
            this.Controls.Add(this.label1);
            this.Name = "PizzaParty";
            this.Text = "Pizza Party";
            this.Load += new System.EventHandler(this.frmPizzaParty_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.CheckBox boxPepperoni;
        private System.Windows.Forms.CheckBox boxSausage;
        private System.Windows.Forms.CheckBox boxChicken;
        private System.Windows.Forms.CheckBox boxOnions;
        private System.Windows.Forms.CheckBox boxMushrooms;
        private System.Windows.Forms.CheckBox boxBlackOlives;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox boxSoda;
        private System.Windows.Forms.CheckBox boxCheeseBread;
        private System.Windows.Forms.CheckBox boxBrownie;
        private System.Windows.Forms.CheckBox boxCookie;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.ListBox lstOrderSummary;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtFinalTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClear;
    }
}

