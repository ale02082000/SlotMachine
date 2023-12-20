# SlotMachine
***
- Realizzare una libreria di classi C# con le classi relative alla SlotMachine
- Realizzare un programma WPF che usa la libreria di classi
- Realizzare un programma Console che usa la stessa libreria di classi
 ***
*** 
<img src="https://github.com/ale02082000/SlotMachine/assets/127590077/47dd18a9-3e04-4580-be4b-7f0dd95431c9">

***



``` c#

 private void Coppia()
        {
            if (Simbolo1 == Simbolo2 || Simbolo2 == Simbolo3 || Simbolo1 == Simbolo3)
            {
                moneteVinte += 1;
            }
        }

        private void Jackpot()
        {
            if (Simbolo1 == Simbolo2 && Simbolo2 == Simbolo3)
            {
                moneteVinte += PosizioneInOrdineAlfabetico(Simbolo1);
            }
        }

        private void MoneteInSeguito()
        {
            if (PosizioneInOrdineAlfabetico(Simbolo2) == PosizioneInOrdineAlfabetico(Simbolo1) + 1 &&
                PosizioneInOrdineAlfabetico(Simbolo3) == PosizioneInOrdineAlfabetico(Simbolo2) + 1)
            {
                moneteVinte += 50;
            }
        }

        private void JackpotZ()
        {
            if (Simbolo1 == 'Z' && Simbolo2 == 'Z' && Simbolo3 == 'Z')
            {
                moneteVinte += 100;
            }
        }

        private int PosizioneInOrdineAlfabetico(char lettera)
        {
            const char primaLettera = 'A';
            return lettera - primaLettera + 1;
        }

        private void RiscattaVincite()
        {
            Credito += moneteVinteDaRiscattare;
            moneteVinteTotali += moneteVinteDaRiscattare;
            moneteVinteDaRiscattare = 0;
            moneteRiscattate = false;
        }

        public int GetMoneteVinte()
        {
            return moneteVinte;
        }

        public char GetRandomLetter()
        {
            int randomIndex = random.Next(alfabeto.Length);
            return alfabeto[randomIndex];
        }

        public int GetMoneteVinteDaRiscattare()
        {
            return moneteVinteDaRiscattare;
        }

        public int GetMoneteVinteTotali()
        {
            return moneteVinteTotali;
        }

        public void RiscattaMoneteVinte()
        {
            if (moneteVinte > 0)
            {
                moneteRiscattate = true;
                AggiungiMoneteAlCredito(moneteVinte);
                RiscattaVincite();
                moneteVinte = 0;
            }
        }

```
***
In questo codice i metodi implementati gestiscono diverse condizioni di vincita.
Il metodo Coppia incrementa le monete se almeno due simboli sono uguali, il metodo Jackpot assegna monete basate sulla posizione alfabetica se tutti e tre i simboli sono uguali. MoneteInSeguito incrementa le monete se i simboli sono consecutivi nell'alfabeto, e JackpotZ assegna monete se tutti e tre i simboli sono 'Z'. La funzione PosizioneInOrdineAlfabetico restituisce la posizione di una lettera nell'alfabeto. Il metodo RiscattaVincite gestisce il riscatto delle monete vinte, implementato poi da altri metodi.
***





``` c#

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
                Spin.Visibility = Visibility.Hidden;
                textBoxCredits.Text = "Hai terminato i crediti! = " + slotMachine.Credito.ToString();
            }
        }

```

***
Il metodo Spin_Click gestisce l'evento di click associato al pulsante "Spin".
Innanzitutto, la slot machine è fatta giocare mediante l'invocazione del metodo Gioca(). Successivamente, viene verificato se il numero totale di giocate è un multiplo di 3. Se questa condizione è soddisfatta, tre checkbox associate a potenziali fermate dei simboli vengono deselezionate.
I risultati della giocata, ovvero i simboli ottenuti nella slot machine, vengono quindi visualizzati nelle caselle di testo textBoxLett1, textBoxLett2, e textBoxLett3. Inoltre, il testo delle caselle textBoxResult e textBoxCredits viene aggiornato per riflettere la vincita ottenuta e il credito rimanente nella slot machine.
Infine, viene verificato se il credito della slot machine è pari a zero. Se si, il pulsante "Spin" viene nascosto e il testo nella casella textBoxCredits viene modificato per indicare che i crediti sono esauriti.
***


