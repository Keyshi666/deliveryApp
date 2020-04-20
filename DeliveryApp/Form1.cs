using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using BL.Creators;

namespace DeliveryApp
{

    public partial class Form1 : Form
    {
        private const string HeavyProductText = "Тяжелый товар";
        private const string LightProductText = "Легкий товар";
        private const string ExpressProductText = "Экспресс-доставка";
        double index = 2;
        public string delivery;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            delivery = (string) dropdownDelivery.SelectedItem;
            switch (delivery) 
            {
                case HeavyProductText:
                    Product HeavyProduct = new HeavyProductCreator().Create(Convert.ToDouble(textBox_cost.Text), Convert.ToDouble(textBox_weight.Text));
                    result.Text = Convert.ToString(new Calculator().deliveryCost(HeavyProduct, (string) dropdown_destination.SelectedItem));
                    break;
                case LightProductText:
                    Product LightProduct = new LightProductCreator().Create(Convert.ToDouble(textBox_cost.Text));
                    result.Text = Convert.ToString(new Calculator().deliveryCost(LightProduct, (string)dropdown_destination.SelectedItem));
                    break;
                case ExpressProductText:
                    Product ExpressProduct = new ExpressProductCreator().Create(Convert.ToDouble(textBox_cost.Text), this.index);
                    result.Text = Convert.ToString(new Calculator().deliveryCost(ExpressProduct, (string)dropdown_destination.SelectedItem));
                    break;


            }
               
        }

        private void dropdownDelivery_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            delivery = (string) dropdownDelivery.SelectedItem;
            if (delivery == "Тяжелый товар")
            {
                textBox_weight.Enabled = true;
            }
            else
            {
                textBox_weight.Enabled = false;
                textBox_weight.Text = "";
            }
        }

        private void InitializeComboBox()
        {
            //this.dropdownDelivery = new System.Windows.Forms.ComboBox();
            //string[] delivery = new string[]{"Легкий продукт", "Тяжелый продукт",
            //    "Экспресс-доставка"};
            //dropdownDelivery.Items.AddRange(delivery);
        }
    }
}
