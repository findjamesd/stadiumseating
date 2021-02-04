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
            
            tbTotalTicketsClassA.Content = classATotal.ToString("C");
            
            tbTotalTicketsClassB.Content = classBTotal.ToString("C");
            
            tbTotalTicketsClassC.Content = classCTotal.ToString("C");
            
            tbTotalRevenueGenerated.Content = 0.ToString("C");
        }

        static int EmptyStringChecker(string currentValue)
        {
            return currentValue == "" ? 0 : int.Parse(currentValue);
        }

        private void CalcTotalIncomeGenerated()
        {
            int totalTicketsSold = classATickets + classBTickets + classCTickets;

            int totalIncomeGenerated = classATotal + classBTotal + classCTotal;

            tbTotalTicketsSold.Content = totalTicketsSold.ToString();

            tbTotalRevenueGenerated.Content = totalIncomeGenerated.ToString("C");
        }

        private void CalcOnTextChange(object sender, RoutedEventArgs e)
        {
            try
            {
                if (sender.Equals(txtTicketForClassA))
                {

                    int userInput = EmptyStringChecker(txtTicketForClassA.Text);

                    classATotal = userInput * 15;

                    classATickets = userInput;

                    tbTotalTicketsClassA.Content = classATotal.ToString("C");

                    errorMessageForClassA.Content = "";

                    CalcTotalIncomeGenerated();

                }
                else if (sender.Equals(txtTicketForClassB))
                {

                    int userInput = EmptyStringChecker(txtTicketForClassB.Text);

                    classBTotal = userInput * 12;

                    classBTickets = userInput;

                    tbTotalTicketsClassB.Content = classBTotal.ToString("C");

                    errorMessageForClassB.Content = "";

                    CalcTotalIncomeGenerated();

                }
                else
                {

                    int userInput = EmptyStringChecker(txtTicketForClassC.Text);

                    classCTotal = userInput * 9;

                    classCTickets = userInput;

                    tbTotalTicketsClassC.Content = classCTotal.ToString("C");

                    errorMessageForClassC.Content = "";

                    CalcTotalIncomeGenerated();

                }
            }
            catch
            {
                if (sender.Equals(txtTicketForClassA))
                {
                    errorMessageForClassA.Content = "Invalid input on Class A";

                    classATotal = 0;

                    classATickets = 0;

                    tbTotalTicketsClassA.Content = classATotal.ToString("C");

                    CalcTotalIncomeGenerated();

                }
                else if (sender.Equals(txtTicketForClassB))
                {
                    errorMessageForClassB.Content = "Invalid input on Class B";

                    classBTotal = 0;

                    classBTickets = 0;

                    tbTotalTicketsClassB.Content = classBTotal.ToString("C");

                    CalcTotalIncomeGenerated();
                }
                else
                {
                    errorMessageForClassC.Content = "Invalid input on Class C";

                    classCTotal = 0;

                    classCTickets = 0;

                    tbTotalTicketsClassC.Content = classCTotal.ToString("C");

                    CalcTotalIncomeGenerated();
                }
            }
        }
    }
}
