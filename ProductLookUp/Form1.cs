using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProductLookUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Look up product quantity by barcode and store location
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            string scannedItem = textBox1.Text;

            try
            {

                if (scannedItem == "" || scannedItem == null)
                {
                    MessageBox.Show("Please enter an item to search for.");
                }
                else
                {
                    Dictionary<string, string> result = Lookup(scannedItem, comboBox1.Text);

                    // if nothing was returned
                    if (result != null)
                    {
                        MessageBox.Show(String.Format("Location: {0}\nItem: {1}\nIn Stock: {2}\nPrice: {3}",
                                result["StoreCode"], result["ItemName"], result["Quantity"], result["ItemPrice"]));
                    }
                    else
                    {
                        MessageBox.Show(String.Format("No results were returned for item {0}", scannedItem));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("An unexpected error has occured. Please try again.\n\n{0}", ex));
            }

        }

        public Dictionary<string, string> Lookup(string barcode, string store)
        {
            try
            {
                // looks up product info, store id, and quantity for store
                Product product = ItemLookup(barcode);
                int storeId = StoreIdLookUp(store);
                int quantity = QuantityLookup(product.ID, storeId);

                // adds results to dictionary
                Dictionary<string, string> result = new Dictionary<string, string>();

                result.Add("ItemName", product.ItemName);
                result.Add("StoreCode", store);
                result.Add("Quantity", Convert.ToString(quantity));
                result.Add("ItemPrice", Convert.ToString(product.Price));

                return result;
            }
            catch
            {
                return null;
            }
        }

        public Product ItemLookup(string barcode)
        {
            using (DDEntities context = new DDEntities())
            {
                try
                {
                    // finds product info in database
                    Product product = context.Products.FirstOrDefault(x => x.Barcode == barcode);
                    return product;
                }
                catch
                {
                    return null;
                }

            }
        }

        public int StoreIdLookUp(string storeCode)
        {
            using (DDEntities context = new DDEntities())
            {
                try
                {
                    // finds store info in database
                    int storeId = context.Stores.FirstOrDefault(x => x.Code == storeCode).ID;
                    return storeId;
                }
                catch
                {
                    return 0;
                }
            }
        }

        public int QuantityLookup(int itemId, int storeId)
        {
            using (DDEntities context = new DDEntities())
            {
                try
                {
                    // finds quantity info in database
                    int itemQuantity = context.Quantities.FirstOrDefault(x => (x.ItemID == itemId && x.StoreID == storeId)).Quantity1;
                    return itemQuantity;
                }
                catch
                {
                    return 0;
                }
            }
        }

        // add new items to db, may be utilized at a later date
        public void AddProductToDb(string name, string barcode, int price)
        {
            using (DDEntities context = new DDEntities())
            {

                Product product = new Product()
                {
                    ItemName = name,
                    Barcode = barcode,
                    Price = price
                };

                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        
    }


}
