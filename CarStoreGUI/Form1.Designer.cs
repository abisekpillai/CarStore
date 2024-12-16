namespace CarStoreGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btn_create_car = new Button();
            txt_price = new TextBox();
            txt_model = new TextBox();
            txt_make = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lst_inventory = new ListBox();
            groupBox3 = new GroupBox();
            lst_cart = new ListBox();
            btn_add_to_cart = new Button();
            btn_checkout = new Button();
            label4 = new Label();
            lbl_totalcost = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_create_car);
            groupBox1.Controls.Add(txt_price);
            groupBox1.Controls.Add(txt_model);
            groupBox1.Controls.Add(txt_make);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(216, 224);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create Car";
            // 
            // btn_create_car
            // 
            btn_create_car.Location = new Point(50, 171);
            btn_create_car.Name = "btn_create_car";
            btn_create_car.Size = new Size(94, 29);
            btn_create_car.TabIndex = 1;
            btn_create_car.Text = "Create";
            btn_create_car.UseVisualStyleBackColor = true;
            btn_create_car.Click += btn_create_car_Click;
            // 
            // txt_price
            // 
            txt_price.Location = new Point(62, 121);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(125, 27);
            txt_price.TabIndex = 5;
            // 
            // txt_model
            // 
            txt_model.Location = new Point(62, 84);
            txt_model.Name = "txt_model";
            txt_model.Size = new Size(125, 27);
            txt_model.TabIndex = 4;
            // 
            // txt_make
            // 
            txt_make.Location = new Point(62, 43);
            txt_make.Name = "txt_make";
            txt_make.Size = new Size(125, 27);
            txt_make.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 124);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 3;
            label3.Text = "Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 84);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 2;
            label2.Text = "Model:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 46);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 1;
            label1.Text = "Make:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lst_inventory);
            groupBox2.Location = new Point(251, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(237, 458);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Car Inventory";
            // 
            // lst_inventory
            // 
            lst_inventory.FormattingEnabled = true;
            lst_inventory.Location = new Point(6, 26);
            lst_inventory.Name = "lst_inventory";
            lst_inventory.Size = new Size(224, 424);
            lst_inventory.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lst_cart);
            groupBox3.Location = new Point(628, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(236, 359);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Shopping Cart";
            // 
            // lst_cart
            // 
            lst_cart.FormattingEnabled = true;
            lst_cart.Location = new Point(6, 26);
            lst_cart.Name = "lst_cart";
            lst_cart.Size = new Size(224, 324);
            lst_cart.TabIndex = 0;
            // 
            // btn_add_to_cart
            // 
            btn_add_to_cart.Location = new Point(511, 183);
            btn_add_to_cart.Name = "btn_add_to_cart";
            btn_add_to_cart.Size = new Size(94, 29);
            btn_add_to_cart.TabIndex = 3;
            btn_add_to_cart.Text = "Add to Cart";
            btn_add_to_cart.UseVisualStyleBackColor = true;
            btn_add_to_cart.Click += btn_add_to_cart_Click;
            // 
            // btn_checkout
            // 
            btn_checkout.Location = new Point(702, 388);
            btn_checkout.Name = "btn_checkout";
            btn_checkout.Size = new Size(94, 29);
            btn_checkout.TabIndex = 4;
            btn_checkout.Text = "Checkout";
            btn_checkout.UseVisualStyleBackColor = true;
            btn_checkout.Click += btn_checkout_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(634, 435);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 5;
            label4.Text = "Total Cost:";
            // 
            // lbl_totalcost
            // 
            lbl_totalcost.AutoSize = true;
            lbl_totalcost.Location = new Point(718, 435);
            lbl_totalcost.Name = "lbl_totalcost";
            lbl_totalcost.Size = new Size(35, 20);
            lbl_totalcost.TabIndex = 6;
            lbl_totalcost.Text = "Rs.0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 492);
            Controls.Add(lbl_totalcost);
            Controls.Add(label4);
            Controls.Add(btn_checkout);
            Controls.Add(btn_add_to_cart);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "BeepKart";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_create_car;
        private TextBox txt_price;
        private TextBox txt_model;
        private TextBox txt_make;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private ListBox lst_inventory;
        private GroupBox groupBox3;
        private ListBox lst_cart;
        private Button btn_add_to_cart;
        private Button btn_checkout;
        private Label label4;
        private Label lbl_totalcost;
    }
}
