using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab3_question1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
      
        double tax = 0.00;
        const double HST = 0.18;
        int lego = 0;
        int barbie = 0;
        int lol = 0;

        int watch=0;
        int earrings = 0;
        int neckless = 0;
        int bracelet = 0;

        int book1 = 0;
        int book2 = 0;
        int book3 = 0;

        int electronics1 = 0;
        int electronics2 = 0;
        int electronics3 = 0;
        int electronics4 = 0;



        public MainWindow()
        {
            DataContext = this; //SGJ
            InitializeComponent();
        }

        private void cmbElectronics_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            Electronics el = cmbElectronics.SelectedItem as Electronics;

            if (el.Item == "Smart Watch")
            {
                electronics1++;
                bool contains = false;
                for (int i = 0; i < listItems.Items.Count; i++)
                {
                    string s = listItems.Items[i] as string;
                    if (s.Contains("Smart Watch"))
                    {
                        listItems.Items[i] = (el.Item + " : $" + el.Price + " (" + electronics1 + ")");
                        contains = true;
                    }
                }
                if (contains == false)
                {
                    listItems.Items.Add(el.Item + " : $" + el.Price + " (" + electronics1 + ")");
                }


            }
            if (el.Item == "Polaroid Go")
            {
                electronics2++;
                bool contains = false;
                for (int i = 0; i < listItems.Items.Count; i++)
                {
                    string s = listItems.Items[i] as string;
                    if (s.Contains("Polaroid Go"))
                    {
                        listItems.Items[i] = (el.Item + " : $" + el.Price + " (" + electronics2 + ")");
                        contains = true;
                    }
                }
                if (contains == false)
                {
                    listItems.Items.Add(el.Item + " : $" + el.Price + " (" + electronics2 + ")");
                }


            }

            if (el.Item == "Wireless Earbuds")
            {
                electronics3++;
                bool contains = false;
                for (int i = 0; i < listItems.Items.Count; i++)
                {
                    string s = listItems.Items[i] as string;
                    if (s.Contains("Wireless Earbuds"))
                    {
                        listItems.Items[i] = (el.Item + " : $" + el.Price + " (" + electronics3 + ")");
                        contains = true;
                    }
                }
                if (contains == false)
                {
                    listItems.Items.Add(el.Item + " : $" + el.Price + " (" + electronics3 + ")");
                }


            }

            if (el.Item == "Bluetooth Speaker")
            {
                electronics4++;
                bool contains = false;
                for (int i = 0; i < listItems.Items.Count; i++)
                {
                    string s = listItems.Items[i] as string;
                    if (s.Contains("Bluetooth Speaker"))
                    {
                        listItems.Items[i] = (el.Item + " : $" + el.Price + " (" + electronics4 + ")");
                        contains = true;
                    }
                }
                if (contains == false)
                {
                    listItems.Items.Add(el.Item + " : $" + el.Price + " (" + electronics4 + ")");
                }


            }

            double price = double.Parse(el.Price.ToString());
            tax = price * HST;
            lblTax.Content = ((double.Parse(lblTax.Content.ToString()) + tax)).ToString("0.00");
            lblSubtotal.Content = ((double.Parse(lblSubtotal.Content.ToString()) + price)).ToString("0.00");
            lblTotal.Content = ((double.Parse(lblTotal.Content.ToString()) + price*1.18)).ToString("0.00");
        }


        private void cmbBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            Books bk = cmbBooks.SelectedItem as Books;

            if (bk.Item == "The Duke And I")
            {
                book1++;
                bool contains = false;
                for (int i = 0; i < listItems.Items.Count; i++)
                {
                    string s = listItems.Items[i] as string;
                    if (s.Contains("The Duke And I"))
                    {
                        listItems.Items[i] = (bk.Item + " : $" + bk.Price + " (" + book1 + ")");
                        contains = true;
                    }
                }
                if (contains == false)
                {
                    listItems.Items.Add(bk.Item + " : $" + bk.Price + " (" + book1 + ")");
                }


            }

            if (bk.Item == "Twilight Saga")
            {
                book2++;
                bool contains = false;
                for (int i = 0; i < listItems.Items.Count; i++)
                {
                    string s = listItems.Items[i] as string;
                    if (s.Contains("Twilight Saga"))
                    {
                        listItems.Items[i] = (bk.Item + " : $" + bk.Price + " (" + book2 + ")");
                        contains = true;
                    }
                }
                if (contains == false)
                {
                    listItems.Items.Add(bk.Item + " : $" + bk.Price + " (" + book2 + ")");
                }


            }

            if (bk.Item == "Emma")
            {
                book3++;
                bool contains = false;
                for (int i = 0; i < listItems.Items.Count; i++)
                {
                    string s = listItems.Items[i] as string;
                    if (s.Contains("Emma"))
                    {
                        listItems.Items[i] = (bk.Item + " : $" + bk.Price + " (" + book3 + ")");
                        contains = true;
                    }
                }
                if (contains == false)
                {
                    listItems.Items.Add(bk.Item + " : $" + bk.Price + " (" + book3 + ")");
                }


            }
            double price = double.Parse(bk.Price.ToString());
            tax = price * HST;
            lblTax.Content = ((double.Parse(lblTax.Content.ToString()) + tax)).ToString("0.00");
            lblSubtotal.Content = ((double.Parse(lblSubtotal.Content.ToString()) + price)).ToString("0.00");
            lblTotal.Content = ((double.Parse(lblTotal.Content.ToString()) + price * 1.18)).ToString("0.00");
        }



        private void cmbJewelry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            Jewelry jl = cmbJewelry.SelectedItem as Jewelry;

            if (jl.Item == "Watch")
            {
                watch++;
                bool contains = false;
                for (int i = 0; i < listItems.Items.Count; i++)
                {
                    string s = listItems.Items[i] as string;
                    if (s.Contains("Watch"))
                    {
                        listItems.Items[i] = (jl.Item + " : $" + jl.Price + " (" + watch + ")");
                        contains = true;
                    }
                }
                if (contains == false)
                {
                    listItems.Items.Add(jl.Item + " : $" + jl.Price + " (" + watch + ")");
                }


            }

            if (jl.Item == "Earrings")
            {
                earrings++;
                bool contains = false;
                for (int i = 0; i < listItems.Items.Count; i++)
                {
                    string s = listItems.Items[i] as string;
                    if (s.Contains("Earrings"))
                    {
                        listItems.Items[i] = (jl.Item + " : $" + jl.Price + " (" + earrings + ")");
                        contains = true;
                    }
                }
                if (contains == false)
                {
                    listItems.Items.Add(jl.Item + " : $" + jl.Price + " (" + earrings + ")");
                }


            }

            if (jl.Item == "Neckless")
            {
                neckless++;
                bool contains = false;
                for (int i = 0; i < listItems.Items.Count; i++)
                {
                    string s = listItems.Items[i] as string;
                    if (s.Contains("Neckless"))
                    {
                        listItems.Items[i] = (jl.Item + " : $" + jl.Price + " (" + neckless + ")");
                        contains = true;
                    }
                }
                if (contains == false)
                {
                    listItems.Items.Add(jl.Item + " : $" + jl.Price + " (" + neckless + ")");
                }


            }

            if (jl.Item == "Bracelet")
            {
                bracelet++;
                bool contains = false;
                for (int i = 0; i < listItems.Items.Count; i++)
                {
                    string s = listItems.Items[i] as string;
                    if (s.Contains("Bracelet"))
                    {
                        listItems.Items[i] = (jl.Item + " : $" + jl.Price + " (" + bracelet + ")");
                        contains = true;
                    }
                }
                if (contains == false)
                {
                    listItems.Items.Add(jl.Item + " : $" + jl.Price + " (" + bracelet + ")");
                }


            }

            double price = double.Parse(jl.Price.ToString());
            tax = price * HST;
            lblTax.Content = ((double.Parse(lblTax.Content.ToString()) + tax)).ToString("0.00");
            lblSubtotal.Content = ((double.Parse(lblSubtotal.Content.ToString()) + price)).ToString("0.00");
            lblTotal.Content = ((double.Parse(lblTotal.Content.ToString()) + price * 1.18)).ToString("0.00");
        }


        private void cmbToys_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            Toys to = cmbToys.SelectedItem as Toys;
            if (to.Item == "Lego")
            {
                lego++;
                bool contains = false;
                for(int i=0; i< listItems.Items.Count;i++)
                {
                    string s = listItems.Items[i] as string;
                    if (s.Contains("Lego"))
                        {
                        listItems.Items[i]=(to.Item + " : $" + to.Price + " (" + lego + ")");
                        contains = true;
                    }
                }
                if (contains == false)
                {
                    listItems.Items.Add(to.Item + " : $" + to.Price + " (" + lego + ")");
                }
                

            }

            if (to.Item == "Barbie")
            {
                barbie++;
                bool contains = false;
                for (int i = 0; i < listItems.Items.Count; i++)
                {
                    string s = listItems.Items[i] as string;
                    if (s.Contains("Barbie"))
                    {
                        listItems.Items[i] = (to.Item + " : $" + to.Price + " (" + barbie + ")");
                        contains = true;
                    }
                }
                if (contains == false)
                {
                    listItems.Items.Add(to.Item + " : $" + to.Price + " (" + barbie + ")");
                }


            }
            if (to.Item == "LOL Doll")
            {
                lol++;
                bool contains = false;
                for (int i = 0; i < listItems.Items.Count; i++)
                {
                    string s = listItems.Items[i] as string;
                    if (s.Contains("LOL Doll"))
                    {
                        listItems.Items[i] = (to.Item + " : $" + to.Price + " (" + lol + ")");
                        contains = true;
                    }
                }
                if (contains == false)
                {
                    listItems.Items.Add(to.Item + " : $" + to.Price + " (" + lol + ")");
                }


            }


            // listItems.Items.Add(to.Item + " : $" + to.Price + " (" + quantity + ")");
            double price = double.Parse(to.Price.ToString());
            tax = price * HST;
            lblTax.Content = ((double.Parse(lblTax.Content.ToString()) + tax)).ToString("0.00");
            lblSubtotal.Content=((double.Parse(lblSubtotal.Content.ToString()) + price)).ToString("0.00");
            lblTotal.Content = ((double.Parse(lblTotal.Content.ToString()) + price * 1.18)).ToString("0.00");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listItems.Items.Clear();
            lblTotal.Content = "0";
            lblTax.Content = "0";
            lblSubtotal.Content = "0";
            cmbElectronics.SelectedIndex = 0;
            cmbBooks.SelectedIndex = 0;
            cmbJewelry.SelectedIndex = 0;
            cmbToys.SelectedIndex = 0;
        }

       
    }
}
