using System;

namespace SlotMachineLib
{
    public class SlotMachine
    {
        private readonly Random random;
        private readonly string alfabeto;
        private int moneteVinte;
        private int moneteVinteDaRiscattare;
        private int moneteVinteTotali;
        private bool moneteRiscattate;

        public int Credito { get; private set; }
        public char Simbolo1 { get; private set; }
        public char Simbolo2 { get; private set; }
        public char Simbolo3 { get; private set; }
        public int NumGiocata { get; private set; }
        public bool StopSimbolo1 { get; set; }
        public bool StopSimbolo2 { get; set; }
        public bool StopSimbolo3 { get; set; }

        public SlotMachine()
        {
            Credito = 10;
            alfabeto = "ABCDEFGHILMNOPQRSTUVZ";
            NumGiocata = 0;
            moneteVinteDaRiscattare = 0;
            moneteVinteTotali = 0;
            random = new Random(DateTime.Now.Millisecond);
            moneteRiscattate = false;
        }

        public void Gioca()
        {
            EseguiPartita();
            NumGiocata++;

            if (NumGiocata == 3)
            {
                StopSimbolo1 = false;
                StopSimbolo2 = false;
                StopSimbolo3 = false;
                NumGiocata = 0;
                RiscattaVincite();
            }
        }

        private void EseguiPartita()
        {
            moneteVinte = 0;

            if (!StopSimbolo1) Simbolo1 = GetRandomLetter();
            if (!StopSimbolo2) Simbolo2 = GetRandomLetter();
            if (!StopSimbolo3) Simbolo3 = GetRandomLetter();

            ValutaPartita();
        }

        private void ValutaPartita()
        {
            Coppia();
            JackpotZ();
            Jackpot();
            MoneteInSeguito();

            if (moneteVinte > 0)
            {
                AggiungiMoneteAlCredito(moneteVinte);
                moneteVinteDaRiscattare += moneteVinte;
            }

            if (NumGiocata % 3 == 2)
            {
                Credito--;
            }
        }


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

        public void AggiungiMoneteAlCredito(int monete)
        {
            Credito += monete;
        }

        public bool HaMoneteRiscattate()
        {
            return moneteRiscattate;
        }
    }
}
