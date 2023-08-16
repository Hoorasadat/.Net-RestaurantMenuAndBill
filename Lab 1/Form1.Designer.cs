namespace Lab_1
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
            this.btnOrder = new System.Windows.Forms.Button();
            this.gbCourse = new System.Windows.Forms.GroupBox();
            this.rdbSalad = new System.Windows.Forms.RadioButton();
            this.rdbPizza = new System.Windows.Forms.RadioButton();
            this.rdbHamburger = new System.Windows.Forms.RadioButton();
            this.gbxHamburger = new System.Windows.Forms.GroupBox();
            this.chbxFries = new System.Windows.Forms.CheckBox();
            this.chbxKetchup = new System.Windows.Forms.CheckBox();
            this.chbxLettuce = new System.Windows.Forms.CheckBox();
            this.gbxPizza = new System.Windows.Forms.GroupBox();
            this.chbxOlives = new System.Windows.Forms.CheckBox();
            this.chbxSausage = new System.Windows.Forms.CheckBox();
            this.chbxPepperoni = new System.Windows.Forms.CheckBox();
            this.bdOrder = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.txbTax = new System.Windows.Forms.TextBox();
            this.txbSubtotal = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbxSalad = new System.Windows.Forms.GroupBox();
            this.chbxBread = new System.Windows.Forms.CheckBox();
            this.chbxBacon = new System.Windows.Forms.CheckBox();
            this.chbxCrouton = new System.Windows.Forms.CheckBox();
            this.gbCourse.SuspendLayout();
            this.gbxHamburger.SuspendLayout();
            this.gbxPizza.SuspendLayout();
            this.bdOrder.SuspendLayout();
            this.gbxSalad.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnOrder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOrder.Location = new System.Drawing.Point(560, 289);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(127, 37);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // gbCourse
            // 
            this.gbCourse.BackColor = System.Drawing.SystemColors.Desktop;
            this.gbCourse.Controls.Add(this.rdbSalad);
            this.gbCourse.Controls.Add(this.rdbPizza);
            this.gbCourse.Controls.Add(this.rdbHamburger);
            this.gbCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCourse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbCourse.Location = new System.Drawing.Point(107, 42);
            this.gbCourse.Name = "gbCourse";
            this.gbCourse.Size = new System.Drawing.Size(225, 199);
            this.gbCourse.TabIndex = 1;
            this.gbCourse.TabStop = false;
            this.gbCourse.Text = "Main Course";
            // 
            // rdbSalad
            // 
            this.rdbSalad.AutoSize = true;
            this.rdbSalad.BackColor = System.Drawing.SystemColors.Desktop;
            this.rdbSalad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSalad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdbSalad.Location = new System.Drawing.Point(21, 128);
            this.rdbSalad.Name = "rdbSalad";
            this.rdbSalad.Size = new System.Drawing.Size(136, 28);
            this.rdbSalad.TabIndex = 2;
            this.rdbSalad.TabStop = true;
            this.rdbSalad.Text = "Salad - $4.95";
            this.rdbSalad.UseVisualStyleBackColor = false;
            this.rdbSalad.CheckedChanged += new System.EventHandler(this.rdbSalad_CheckedChanged);
            // 
            // rdbPizza
            // 
            this.rdbPizza.AutoSize = true;
            this.rdbPizza.BackColor = System.Drawing.SystemColors.Desktop;
            this.rdbPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPizza.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdbPizza.Location = new System.Drawing.Point(21, 86);
            this.rdbPizza.Name = "rdbPizza";
            this.rdbPizza.Size = new System.Drawing.Size(133, 28);
            this.rdbPizza.TabIndex = 1;
            this.rdbPizza.TabStop = true;
            this.rdbPizza.Text = "Pizza - $5.95";
            this.rdbPizza.UseVisualStyleBackColor = false;
            this.rdbPizza.CheckedChanged += new System.EventHandler(this.rdbPizza_CheckedChanged);
            // 
            // rdbHamburger
            // 
            this.rdbHamburger.AutoSize = true;
            this.rdbHamburger.BackColor = System.Drawing.SystemColors.Desktop;
            this.rdbHamburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHamburger.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdbHamburger.Location = new System.Drawing.Point(23, 46);
            this.rdbHamburger.Name = "rdbHamburger";
            this.rdbHamburger.Size = new System.Drawing.Size(185, 28);
            this.rdbHamburger.TabIndex = 0;
            this.rdbHamburger.TabStop = true;
            this.rdbHamburger.Text = "Hamburger - $6.95";
            this.rdbHamburger.UseVisualStyleBackColor = false;
            this.rdbHamburger.CheckedChanged += new System.EventHandler(this.rdbHamburger_CheckedChanged);
            // 
            // gbxHamburger
            // 
            this.gbxHamburger.BackColor = System.Drawing.SystemColors.Desktop;
            this.gbxHamburger.Controls.Add(this.chbxFries);
            this.gbxHamburger.Controls.Add(this.chbxKetchup);
            this.gbxHamburger.Controls.Add(this.chbxLettuce);
            this.gbxHamburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxHamburger.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxHamburger.Location = new System.Drawing.Point(377, 42);
            this.gbxHamburger.Name = "gbxHamburger";
            this.gbxHamburger.Size = new System.Drawing.Size(310, 199);
            this.gbxHamburger.TabIndex = 2;
            this.gbxHamburger.TabStop = false;
            this.gbxHamburger.Text = "Add-on items ($0.75/each)";
            // 
            // chbxFries
            // 
            this.chbxFries.AutoSize = true;
            this.chbxFries.BackColor = System.Drawing.SystemColors.Desktop;
            this.chbxFries.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxFries.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chbxFries.Location = new System.Drawing.Point(23, 128);
            this.chbxFries.Name = "chbxFries";
            this.chbxFries.Size = new System.Drawing.Size(129, 28);
            this.chbxFries.TabIndex = 2;
            this.chbxFries.Text = "French fries";
            this.chbxFries.UseVisualStyleBackColor = false;
            // 
            // chbxKetchup
            // 
            this.chbxKetchup.AutoSize = true;
            this.chbxKetchup.BackColor = System.Drawing.SystemColors.Desktop;
            this.chbxKetchup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxKetchup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chbxKetchup.Location = new System.Drawing.Point(23, 86);
            this.chbxKetchup.Name = "chbxKetchup";
            this.chbxKetchup.Size = new System.Drawing.Size(269, 28);
            this.chbxKetchup.TabIndex = 1;
            this.chbxKetchup.Text = "Ketchup, mustard, and mayo";
            this.chbxKetchup.UseVisualStyleBackColor = false;
            // 
            // chbxLettuce
            // 
            this.chbxLettuce.AutoSize = true;
            this.chbxLettuce.BackColor = System.Drawing.SystemColors.Desktop;
            this.chbxLettuce.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxLettuce.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chbxLettuce.Location = new System.Drawing.Point(23, 46);
            this.chbxLettuce.Name = "chbxLettuce";
            this.chbxLettuce.Size = new System.Drawing.Size(247, 28);
            this.chbxLettuce.TabIndex = 0;
            this.chbxLettuce.Text = "Lettuce, omato, and onion";
            this.chbxLettuce.UseVisualStyleBackColor = false;
            // 
            // gbxPizza
            // 
            this.gbxPizza.BackColor = System.Drawing.SystemColors.Desktop;
            this.gbxPizza.Controls.Add(this.chbxOlives);
            this.gbxPizza.Controls.Add(this.chbxPepperoni);
            this.gbxPizza.Controls.Add(this.chbxSausage);
            this.gbxPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPizza.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxPizza.Location = new System.Drawing.Point(377, 42);
            this.gbxPizza.Name = "gbxPizza";
            this.gbxPizza.Size = new System.Drawing.Size(310, 199);
            this.gbxPizza.TabIndex = 6;
            this.gbxPizza.TabStop = false;
            this.gbxPizza.Text = "Add-on items ($0.75/each)";
            // 
            // chbxOlives
            // 
            this.chbxOlives.AutoSize = true;
            this.chbxOlives.BackColor = System.Drawing.SystemColors.Desktop;
            this.chbxOlives.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxOlives.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chbxOlives.Location = new System.Drawing.Point(23, 128);
            this.chbxOlives.Name = "chbxOlives";
            this.chbxOlives.Size = new System.Drawing.Size(81, 28);
            this.chbxOlives.TabIndex = 2;
            this.chbxOlives.Text = "Olives";
            this.chbxOlives.UseVisualStyleBackColor = false;
            // 
            // chbxSausage
            // 
            this.chbxSausage.AutoSize = true;
            this.chbxSausage.BackColor = System.Drawing.SystemColors.Desktop;
            this.chbxSausage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxSausage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chbxSausage.Location = new System.Drawing.Point(23, 87);
            this.chbxSausage.Name = "chbxSausage";
            this.chbxSausage.Size = new System.Drawing.Size(103, 28);
            this.chbxSausage.TabIndex = 1;
            this.chbxSausage.Text = "Sausage";
            this.chbxSausage.UseVisualStyleBackColor = false;
            // 
            // chbxPepperoni
            // 
            this.chbxPepperoni.AutoSize = true;
            this.chbxPepperoni.BackColor = System.Drawing.SystemColors.Desktop;
            this.chbxPepperoni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxPepperoni.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chbxPepperoni.Location = new System.Drawing.Point(23, 46);
            this.chbxPepperoni.Name = "chbxPepperoni";
            this.chbxPepperoni.Size = new System.Drawing.Size(117, 28);
            this.chbxPepperoni.TabIndex = 0;
            this.chbxPepperoni.Text = "Pepperoni";
            this.chbxPepperoni.UseVisualStyleBackColor = false;
            // 
            // bdOrder
            // 
            this.bdOrder.BackColor = System.Drawing.SystemColors.Desktop;
            this.bdOrder.Controls.Add(this.label3);
            this.bdOrder.Controls.Add(this.label2);
            this.bdOrder.Controls.Add(this.label1);
            this.bdOrder.Controls.Add(this.txbTotal);
            this.bdOrder.Controls.Add(this.txbTax);
            this.bdOrder.Controls.Add(this.txbSubtotal);
            this.bdOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bdOrder.Location = new System.Drawing.Point(107, 272);
            this.bdOrder.Name = "bdOrder";
            this.bdOrder.Size = new System.Drawing.Size(328, 162);
            this.bdOrder.TabIndex = 3;
            this.bdOrder.TabStop = false;
            this.bdOrder.Text = "Order Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(60, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Order Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(60, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tax (5 %):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(60, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subtotal:";
            // 
            // txbTotal
            // 
            this.txbTotal.BackColor = System.Drawing.SystemColors.Desktop;
            this.txbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbTotal.Location = new System.Drawing.Point(200, 117);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(100, 29);
            this.txbTotal.TabIndex = 2;
            // 
            // txbTax
            // 
            this.txbTax.BackColor = System.Drawing.SystemColors.Desktop;
            this.txbTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTax.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbTax.Location = new System.Drawing.Point(200, 71);
            this.txbTax.Name = "txbTax";
            this.txbTax.Size = new System.Drawing.Size(100, 29);
            this.txbTax.TabIndex = 1;
            // 
            // txbSubtotal
            // 
            this.txbSubtotal.BackColor = System.Drawing.SystemColors.Desktop;
            this.txbSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSubtotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbSubtotal.Location = new System.Drawing.Point(200, 25);
            this.txbSubtotal.Name = "txbSubtotal";
            this.txbSubtotal.Size = new System.Drawing.Size(100, 29);
            this.txbSubtotal.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReset.Location = new System.Drawing.Point(560, 336);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(127, 37);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(560, 383);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 37);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbxSalad
            // 
            this.gbxSalad.BackColor = System.Drawing.SystemColors.Desktop;
            this.gbxSalad.Controls.Add(this.chbxBread);
            this.gbxSalad.Controls.Add(this.chbxBacon);
            this.gbxSalad.Controls.Add(this.chbxCrouton);
            this.gbxSalad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSalad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxSalad.Location = new System.Drawing.Point(377, 42);
            this.gbxSalad.Name = "gbxSalad";
            this.gbxSalad.Size = new System.Drawing.Size(310, 199);
            this.gbxSalad.TabIndex = 3;
            this.gbxSalad.TabStop = false;
            this.gbxSalad.Text = "Add-on items ($0.75/each)";
            // 
            // chbxBread
            // 
            this.chbxBread.AutoSize = true;
            this.chbxBread.BackColor = System.Drawing.SystemColors.Desktop;
            this.chbxBread.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxBread.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chbxBread.Location = new System.Drawing.Point(23, 128);
            this.chbxBread.Name = "chbxBread";
            this.chbxBread.Size = new System.Drawing.Size(129, 28);
            this.chbxBread.TabIndex = 2;
            this.chbxBread.Text = "Bread sticks";
            this.chbxBread.UseVisualStyleBackColor = false;
            // 
            // chbxBacon
            // 
            this.chbxBacon.AutoSize = true;
            this.chbxBacon.BackColor = System.Drawing.SystemColors.Desktop;
            this.chbxBacon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxBacon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chbxBacon.Location = new System.Drawing.Point(23, 86);
            this.chbxBacon.Name = "chbxBacon";
            this.chbxBacon.Size = new System.Drawing.Size(116, 28);
            this.chbxBacon.TabIndex = 1;
            this.chbxBacon.Text = "Bacon bits";
            this.chbxBacon.UseVisualStyleBackColor = false;
            // 
            // chbxCrouton
            // 
            this.chbxCrouton.AutoSize = true;
            this.chbxCrouton.BackColor = System.Drawing.SystemColors.Desktop;
            this.chbxCrouton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxCrouton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chbxCrouton.Location = new System.Drawing.Point(23, 46);
            this.chbxCrouton.Name = "chbxCrouton";
            this.chbxCrouton.Size = new System.Drawing.Size(105, 28);
            this.chbxCrouton.TabIndex = 0;
            this.chbxCrouton.Text = "Croutons";
            this.chbxCrouton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab_1.Properties.Resources.menu;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(794, 485);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.bdOrder);
            this.Controls.Add(this.gbCourse);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.gbxSalad);
            this.Controls.Add(this.gbxPizza);
            this.Controls.Add(this.gbxHamburger);
            this.Name = "Form1";
            this.Text = "Lunch Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCourse.ResumeLayout(false);
            this.gbCourse.PerformLayout();
            this.gbxHamburger.ResumeLayout(false);
            this.gbxHamburger.PerformLayout();
            this.gbxPizza.ResumeLayout(false);
            this.gbxPizza.PerformLayout();
            this.bdOrder.ResumeLayout(false);
            this.bdOrder.PerformLayout();
            this.gbxSalad.ResumeLayout(false);
            this.gbxSalad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.GroupBox gbCourse;
        private System.Windows.Forms.GroupBox gbxHamburger;
        private System.Windows.Forms.GroupBox bdOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.TextBox txbTax;
        private System.Windows.Forms.TextBox txbSubtotal;
        private System.Windows.Forms.RadioButton rdbHamburger;
        private System.Windows.Forms.RadioButton rdbSalad;
        private System.Windows.Forms.RadioButton rdbPizza;
        private System.Windows.Forms.CheckBox chbxFries;
        private System.Windows.Forms.CheckBox chbxKetchup;
        private System.Windows.Forms.CheckBox chbxLettuce;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbxPizza;
        private System.Windows.Forms.CheckBox chbxOlives;
        private System.Windows.Forms.CheckBox chbxSausage;
        private System.Windows.Forms.CheckBox chbxPepperoni;
        private System.Windows.Forms.GroupBox gbxSalad;
        private System.Windows.Forms.CheckBox chbxBread;
        private System.Windows.Forms.CheckBox chbxBacon;
        private System.Windows.Forms.CheckBox chbxCrouton;
    }
}

