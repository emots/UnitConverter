using System;
using System.Collections.Generic;
using System.Linq;
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

namespace unitsConversion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<ListBoxItem> item = new List<ListBoxItem>();

            for (int i = 0; i < Enum.GetNames(typeof(UnitsEnum)).Length; i++)
            {
                item.Add(new ListBoxItem());
                item[i].Content = Enum.GetName(typeof(UnitsEnum), i);
                lsBoxUnits.Items.Add(item[i]);
            }//loads units in listbox

        }

        private void LsBoxUnits_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cbBoxInput.Items.Clear();
            cbBoxOutput.Items.Clear();
            txtBoxInput.Clear();
            txtBoxOutput.Clear();

            switch (((ListBoxItem)lsBoxUnits.SelectedItem).Content.ToString())
            {   // fill comboboxes 
                case "Length":
                    FillBoxes<LengthEnum>();
                    break;
                case "Temperature":
                    FillBoxes<TemperatureEnum>();
                    break;
                case "Mass":
                    FillBoxes<MassEnum>();
                    break;
                default:
                    MessageBox.Show("Error!");
                    break;
            }

        }

        private void BtnConvert_Click(object sender, RoutedEventArgs e)
        {
            Conversion();
        }

        private void CbBoxInput_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtBoxInput.Clear();
            txtBoxOutput.Clear();
        }

        private void CbBoxOutput_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtBoxOutput.Clear();
        }

        private void FillBoxes<T>()
        {
            Type t = typeof(T);
            if (!t.IsEnum)
                throw new InvalidOperationException("Type is not Enum!");

            var names = Enum.GetNames(t);
            foreach (var name in names)
            {
                cbBoxInput.Items.Add(name);
                cbBoxOutput.Items.Add(name);
            }
        }

        private void Conversion()
        {
            double check = 0.0;
            txtBoxOutput.Clear();

            if (txtBoxInput.Text.Length > 0)
            {
                if ((double.TryParse(txtBoxInput.Text.ToString(), out check)) == true) // ckeck if input is a double
                {
                    if (lsBoxUnits.SelectedIndex == -1) // check unit listbox
                    {
                        MessageBox.Show("Please select an Unit first!");
                    }
                    else if (cbBoxInput.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select an input Unit!");
                    }
                    else if (cbBoxOutput.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select an output Unit!");
                    }
                    else
                    {
                        switch (((ListBoxItem)lsBoxUnits.SelectedItem).Content.ToString()) // check what unit is selected
                        {
                            case "Length":
                                txtBoxOutput.Text = (Length.convertLength(Double.Parse(txtBoxInput.Text),
                                    cbBoxInput.Text.ToString(), cbBoxOutput.Text.ToString())).ToString();
                                break;
                            case "Temperature":
                                txtBoxOutput.Text = (Temperature.convertTemperature(Double.Parse(txtBoxInput.Text),
                                    cbBoxInput.Text.ToString(), cbBoxOutput.Text.ToString())).ToString();
                                break;
                            case "Mass":
                                txtBoxOutput.Text = (Mass.convertMass(Double.Parse(txtBoxInput.Text),
                                    cbBoxInput.Text.ToString(), cbBoxOutput.Text.ToString())).ToString();
                                break;
                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Incorect value!");
                }
            }
        }
    }
}
