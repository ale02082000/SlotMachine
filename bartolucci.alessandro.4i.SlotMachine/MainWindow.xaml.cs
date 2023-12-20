using SlotMachineLib;
using System.Windows;

namespace bartolucci.alessandro._4i.SM
{
    public partial class MainWindow : Window
    {
        private SlotMachineLib.SlotMachine slotMachine;

        public MainWindow()
        {
            InitializeComponent();

            // Inizializzazione della slot machine
            slotMachine = new SlotMachineLib.SlotMachine();
        }

        private void Spin_Click(object sender, RoutedEventArgs e)
        {
            slotMachine.Gioca();

            if (slotMachine.NumGiocata % 3 == 0)
            {
                // Rilascia le checkbox alla fine di ogni serie di tre giocate
                checkBoxStopSimb1.IsChecked = false;
                checkBoxStopSimb2.IsChecked = false;
                checkBoxStopSimb3.IsChecked = false;
            }

            textBoxLett1.Text = slotMachine.Simbolo1.ToString();
            textBoxLett2.Text = slotMachine.Simbolo2.ToString();
            textBoxLett3.Text = slotMachine.Simbolo3.ToString();

            textBoxResult.Text = "Vincita = " + slotMachine.GetMoneteVinte().ToString();
            textBoxCredits.Text = "Crediti = " + slotMachine.Credito.ToString();

            if (slotMachine.Credito == 0)
            {
                Spin.Visibility = System.Windows.Visibility.Hidden;

                textBoxCredits.Text = "Hai terminato i crediti! = " + slotMachine.Credito.ToString();
            }
        }

        private void checkBoxStopSimb1_Checked(object sender, RoutedEventArgs e)
        {
            slotMachine.StopSimbolo1 = true;
        }

        private void checkBoxStopSimb2_Checked(object sender, RoutedEventArgs e)
        {
            slotMachine.StopSimbolo2 = true;
        }

        private void checkBoxStopSimb3_Checked(object sender, RoutedEventArgs e)
        {
            slotMachine.StopSimbolo3 = true;
        }

        private void checkBoxStopSimb1_Unchecked(object sender, RoutedEventArgs e)
        {
            slotMachine.StopSimbolo1 = false;
        }

        private void checkBoxStopSimb2_Unchecked(object sender, RoutedEventArgs e)
        {
            slotMachine.StopSimbolo2 = false;
        }

        private void checkBoxStopSimb3_Unchecked(object sender, RoutedEventArgs e)
        {
            slotMachine.StopSimbolo3 = false;
        }
    }
}
