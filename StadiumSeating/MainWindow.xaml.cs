// James Odeyale - Group 1
using System.Windows;

namespace StadiumSeating
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int classATotal = 0, classBTotal = 0, classCTotal = 0;
        int classATickets = 0, classBTickets = 0, classCTickets = 0;
        public MainWindow()
        {
            InitializeComponent();
            tbTotalTicketsClassA.Content = "$" + classATotal.ToString("n2");
            tbTotalTicketsClassB.Content = "$" + classBTotal.ToString("n2");
            tbTotalTicketsClassC.Content = "$" + classCTotal.ToString("n2");
            tbTotalRevenueGenerated.Content = "$" + 0.ToString("n2");
        }


        private void CalcOnTextChange(object sender, RoutedEventArgs e)
        {
            try
            {
                if (sender.Equals(txtTicketForClassA))
                {
                    if (txtTicketForClassA.Text.Length > 0)
                    {
                        classATotal = int.Parse(txtTicketForClassA.Text) * 15;

                        classATickets = int.Parse(txtTicketForClassA.Text);

                        tbTotalTicketsClassA.Content = "$" + classATotal.ToString("n2");

                        errorMessageForClassA.Content = "";

                        CalcTotalIncomeGenerated();

                    }
                    else
                    {
                        classATotal = 0;

                        classATickets = 0;

                        tbTotalTicketsClassA.Content = "$" + classATotal.ToString("n2");

                        errorMessageForClassA.Content = "";

                        CalcTotalIncomeGenerated();
                    }
                }
                else if (sender.Equals(txtTicketForClassB))
                {
                    if (txtTicketForClassB.Text.Length > 0)
                    {
                        classBTotal = int.Parse(txtTicketForClassB.Text) * 12;

                        classBTickets = int.Parse(txtTicketForClassB.Text);

                        tbTotalTicketsClassB.Content = "$" + classBTotal.ToString("n2");

                        errorMessageForClassB.Content = "";

                        CalcTotalIncomeGenerated();
                    }
                    else
                    {
                        classBTotal = 0;

                        classBTickets = 0;

                        tbTotalTicketsClassB.Content = "$" + classBTotal.ToString("n2");

                        errorMessageForClassB.Content = "";

                        CalcTotalIncomeGenerated();
                    }
                }
                else
                {
                    if (txtTicketForClassC.Text.Length > 0)
                    {
                        classCTotal = int.Parse(txtTicketForClassC.Text) * 9;

                        classCTickets = int.Parse(txtTicketForClassC.Text);

                        tbTotalTicketsClassC.Content = "$" + classCTotal.ToString("n2");

                        errorMessageForClassC.Content = "";

                        CalcTotalIncomeGenerated();
                    }
                    else
                    {
                        classCTotal = 0;

                        classCTickets = 0;

                        tbTotalTicketsClassC.Content = "$" + classCTotal.ToString("n2");

                        errorMessageForClassC.Content = "";

                        CalcTotalIncomeGenerated();
                    }
                }
            }
            catch
            {
                if (sender.Equals(txtTicketForClassA))
                {
                    errorMessageForClassA.Content = "Invalid input on Class A";

                    classATotal = 0;

                    classATickets = 0;

                    tbTotalTicketsClassA.Content = "$" + classATotal.ToString("n2");

                    CalcTotalIncomeGenerated();

                }
                else if (sender.Equals(txtTicketForClassB))
                {
                    errorMessageForClassB.Content = "Invalid input on Class B";

                    classBTotal = 0;

                    classBTickets = 0;

                    tbTotalTicketsClassB.Content = "$" + classBTotal.ToString("n2");

                    CalcTotalIncomeGenerated();
                }
                else
                {
                    errorMessageForClassC.Content = "Invalid input on Class C";

                    classCTotal = 0;

                    classCTickets = 0;

                    tbTotalTicketsClassC.Content = "$" + classCTotal.ToString("n2");

                    CalcTotalIncomeGenerated();
                }
            }
        }

        private void CalcTotalIncomeGenerated()
        {
            int totalTicketsSold = classATickets + classBTickets + classCTickets;

            int totalIncomeGenerated = classATotal + classBTotal + classCTotal;

            tbTotalTicketsSold.Content = totalTicketsSold.ToString();

            tbTotalRevenueGenerated.Content = "$" + totalIncomeGenerated.ToString("n2");
        }


        // I commented this out because the function was complicating the app so maybe if anyone else can help make it make sense...lol please feel free to break the app down further

        /* private void DisplayCalculation(string classType, int cost, int classTotal, int classTotalTickets, object classTotalText, object classErrorMessage)
         {

             classTotalText = "$" + classTotal.ToString("n2");

             classErrorMessage = "";

             CalcTotalIncomeGenerated();
         }*/
    }
}
