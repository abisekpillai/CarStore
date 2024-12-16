using CarClassLibrary;

namespace CarStoreGUI
{
    public partial class Form1 : Form
    {

        Store myStore = new Store();
        BindingSource carInventoryBindingSource = new BindingSource();
        BindingSource cartBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_create_car_Click(object sender, EventArgs e)
        {
            Car c = new Car(txt_make.Text, txt_model.Text, decimal.Parse(txt_price.Text));
            
            myStore.CarList.Add(c);
            carInventoryBindingSource.ResetBindings(false);
            txt_make.Text = "";
            txt_model.Text = "";
            txt_price.Text = "";

        }

        private void btn_add_to_cart_Click(object sender, EventArgs e)
        {
            Car selectedCar = (Car)lst_inventory.SelectedItem;
            myStore.ShoppingList.Add(selectedCar);
            cartBindingSource.ResetBindings(false);
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            decimal totalCost = myStore.Checkout();
            lbl_totalcost.Text = "Rs."+ totalCost.ToString();

            cartBindingSource.ResetBindings(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carInventoryBindingSource.DataSource = myStore.CarList;
            cartBindingSource.DataSource = myStore.ShoppingList;

            lst_inventory.DataSource = carInventoryBindingSource;
            lst_inventory.DisplayMember = ToString();

            lst_cart.DataSource = cartBindingSource;
            lst_cart.DisplayMember = ToString();
        }
    }
}
