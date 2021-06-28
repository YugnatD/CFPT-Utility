using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Tempo_Timer : Form
    {
        public Tempo_Timer()
        {
            InitializeComponent();
            SelectPrediv.SelectedIndex = 0;
            ModeTimer.SelectedIndex = 0;
            fmtTempo.SelectedIndex = 0;
            ModeTimer1.SelectedIndex = 0;
            fmtTempo1.SelectedIndex = 0;
            if (CheckBoxTimer1.Checked)
            {
                ModeTimer1.Enabled = true;
                Temporisation1.Enabled = true;
                fmtTempo1.Enabled = true;
            }
            else
            {
                ModeTimer1.Enabled = false;
                Temporisation1.Enabled = false;
                fmtTempo1.Enabled = false;
            }
            if (CheckBoxTimer.Checked)
            {
                ModeTimer.Enabled = true;
                Temporisation.Enabled = true;
                fmtTempo.Enabled = true;
            }
            else
            {
                ModeTimer.Enabled = false;
                Temporisation.Enabled = false;
                fmtTempo.Enabled = false;
            }
        }

        private void Calcul_Click(object sender, EventArgs e)
        {
            actuCode();
        }

        private void actuCode()
        {
            double mode = 0;
            double mode1 = 0;
            double prediv = 0;
            double clock = 0;
            double tempoCible = 0;
            double tempoCible1 = 0;
            double resultat = 0;
            double resultat1 = 0;
            string HexString = "";
            if ((CheckBoxTimer1.Checked) && (CheckBoxTimer.Checked))
            {
                mode = Math.Pow(2, Convert.ToDouble(ModeTimer.Text));
                mode1 = Math.Pow(2, Convert.ToDouble(ModeTimer1.Text));
                prediv = Convert.ToDouble(SelectPrediv.Text);
                clock = Convert.ToDouble(ClockFrequency.Value);
                tempoCible = Convert.ToDouble(Temporisation.Value);
                tempoCible1 = Convert.ToDouble(Temporisation1.Value);
                switch (fmtTempo.Text)
                {
                    case "-":

                        break;
                    case "milli":
                        tempoCible = tempoCible * Math.Pow(10, -3);
                        break;
                    case "micro":
                        tempoCible = tempoCible * Math.Pow(10, -6);
                        break;
                    case "nano":
                        tempoCible = tempoCible * Math.Pow(10, -9);
                        break;
                }
                switch (fmtTempo1.Text)
                {
                    case "-":

                        break;
                    case "milli":
                        tempoCible1 = tempoCible1 * Math.Pow(10, -3);
                        break;
                    case "micro":
                        tempoCible1 = tempoCible1 * Math.Pow(10, -6);
                        break;
                    case "nano":
                        tempoCible1 = tempoCible1 * Math.Pow(10, -9);
                        break;
                }
                resultat = mode - (tempoCible / (prediv / clock));
                resultat1 = mode1 - (tempoCible1 / (prediv / clock));
                resultat = Math.Round(resultat);
                resultat1 = Math.Round(resultat1);
                if (resultat < 0)
                {
                    LabelErreur.Text = "ERREUR";
                    LabelErreur.ForeColor = Color.Red;
                }
                else
                {
                    LabelErreur.Text = "OK";
                    LabelErreur.ForeColor = Color.Blue;
                }
                if (resultat1 < 0)
                {
                    LabelErreur1.Text = "ERREUR";
                    LabelErreur1.ForeColor = Color.Red;
                }
                else
                {
                    LabelErreur1.Text = "OK";
                    LabelErreur1.ForeColor = Color.Blue;
                }
                if ((resultat < 0) || (resultat1 < 0))
                {
                    Copy.Enabled = false;
                }
                else
                {
                    Copy.Enabled = true;
                }
                ResultatLoadValue.Text = Convert.ToString(resultat);
                ResultatLoadValue1.Text = Convert.ToString(resultat1);
                TextCode.Text = "";
                TextCode.Text += "EA=1;//Autorise toutes les interruption" + Environment.NewLine;
                TextCode.Text += "TR0 = 1;//lance le timer 0" + Environment.NewLine;
                TextCode.Text += "TR1 = 1;//lance le timer 1" + Environment.NewLine + Environment.NewLine;
                TextCode.Text += "void TimerInit();" + Environment.NewLine + Environment.NewLine;
                TextCode.Text += "/*---------------------------------------------------------------------------*-" + Environment.NewLine;
                TextCode.Text += "TimerInit ()" + Environment.NewLine;
                TextCode.Text += "-----------------------------------------------------------------------------"+ Environment.NewLine;
                TextCode.Text += "Descriptif:" + Environment.NewLine;
                TextCode.Text += "Timer 0 : "+"Mode "+ ModeTimer.Text+"bit - Prediv "+ SelectPrediv.Text+" - tempo "+ Temporisation.Value.ToString()+ fmtTempo.Text + Environment.NewLine;
                TextCode.Text += "Timer 1 : " + "Mode " + ModeTimer1.Text + "bit - Prediv " + SelectPrediv.Text + " - tempo " + Temporisation1.Value.ToString() + fmtTempo1.Text + Environment.NewLine;
                TextCode.Text += "Entree    : --" + Environment.NewLine;
                TextCode.Text += "Sortie    : --" + Environment.NewLine;
                TextCode.Text += "-*---------------------------------------------------------------------------*/" + Environment.NewLine;
                TextCode.Text += "void TimerInit()" + Environment.NewLine;
                TextCode.Text += "{" + Environment.NewLine;
                TextCode.Text += "TR0 = 0;//Stop le timer 0" + Environment.NewLine;
                TextCode.Text += "TR1 = 0;//Stop le timer 1" + Environment.NewLine;
                TextCode.Text += "ET0 = 0;//Desactive l'interruption du timer 0" + Environment.NewLine;
                TextCode.Text += "ET1 = 0;//Desactive l'interruption du timer 1" + Environment.NewLine;
                TextCode.Text += "TMOD &= ~0xFF;//Clear le registre des mode" + Environment.NewLine;
                TextCode.Text += "             // +-------- Timer 1 Gate Control" + Environment.NewLine;
                TextCode.Text += "             // |+------- Counter/Timer1 Select" + Environment.NewLine;
                TextCode.Text += "             // ||++----- choix du mode du timer 1" + Environment.NewLine;
                TextCode.Text += "             // ||||+---- Timer 0 Gate Control" + Environment.NewLine;
                TextCode.Text += "             // |||||+--- Counter/Timer0 Select" + Environment.NewLine;
                TextCode.Text += "             // ||||||++- choix du mode du timer 0" + Environment.NewLine;
                TextCode.Text += "             // ||||||||  (00 : Mode 0, 13-bit Counter/Timer)" + Environment.NewLine;
                TextCode.Text += "             // ||||||||  (01 : Mode 1, 16-bit Counter/Timer)" + Environment.NewLine;
                TextCode.Text += "             // ||||||||  (10 : Mode 2, 8-bit Counter/Timer with Auto-Reload)" + Environment.NewLine;
                TextCode.Text += "             // ||||||||  (11 : Mode 3, Two 8-bit Counter/Timers)  " + Environment.NewLine;    
                TextCode.Text += "TMOD |= ";
                switch (ModeTimer1.Text)
                {
                    case "8":
                        HexString = "2";
                        TextCode.Text += "0x2";
                        break;
                    case "16":
                        HexString = "1";
                        TextCode.Text += "0x1";
                        break;
                    case "13":
                        HexString = "0";
                        TextCode.Text += "0x0";
                        break;
                }
                switch (ModeTimer.Text)
                {
                    case "8":
                        HexString += "2";
                        TextCode.Text += "2;// " + Convert.ToString(Convert.ToInt64(HexString, 16), 2).PadLeft(8, '0') + Environment.NewLine;
                        break;
                    case "16":
                        HexString += "1";
                        TextCode.Text += "1;// " + Convert.ToString(Convert.ToInt64(HexString, 16), 2).PadLeft(8, '0') + Environment.NewLine;
                        break;
                    case "13":
                        HexString += "0";
                        TextCode.Text += "0;// "+ Convert.ToString(Convert.ToInt64(HexString, 16), 2).PadLeft(8, '0') + Environment.NewLine;
                        break;
                }
                TextCode.Text += "CKCON &= ~0x07;//clear les bit de selection pour les timer 0 et 1 et le prescalaire" + Environment.NewLine;
                TextCode.Text += "              // +-------- Timer 3 High Byte Clock Select." + Environment.NewLine;
                TextCode.Text += "              // |+------- Timer 3 Low Byte Clock Select." + Environment.NewLine;
                TextCode.Text += "              // ||+------ Timer 2 High Byte Clock Select" + Environment.NewLine;
                TextCode.Text += "              // |||+----- Timer 2 Low Byte Clock Select." + Environment.NewLine;
                TextCode.Text += "              // ||||+---- Timer 1 Clock Select." + Environment.NewLine;
                TextCode.Text += "              // |||||+--- Timer 0 Clock Select." + Environment.NewLine;
                TextCode.Text += "              // ||||||++- Timer 0/1 Prescale Bits." + Environment.NewLine;
                TextCode.Text += "              // ||||||||  (00: System clock divided by 12)" + Environment.NewLine;
                TextCode.Text += "              // ||||||||  (01: System clock divided by 4)" + Environment.NewLine;
                TextCode.Text += "              // ||||||||  (10: System clock divided by 48)" + Environment.NewLine;
                TextCode.Text += "              // ||||||||  (11: External clock divided by 8 (synchronized with the system clock))  " + Environment.NewLine;
                TextCode.Text += "CKCON |= ";
                switch (SelectPrediv.Text)
                {
                    case "48":
                        HexString = "02";
                        TextCode.Text += "0x02;// " + Convert.ToString(Convert.ToInt64("02", 16), 2).PadLeft(8, '0') + Environment.NewLine;
                        break;
                    case "12":
                        HexString = "00";
                        TextCode.Text += "0x00;// " + Convert.ToString(Convert.ToInt64("00", 16), 2).PadLeft(8, '0') + Environment.NewLine;
                        break;
                    case "4":
                        HexString = "01";
                        TextCode.Text += "0x01;// " + Convert.ToString(Convert.ToInt64("01", 16), 2).PadLeft(8, '0') + Environment.NewLine;
                        break;
                }
                switch (ModeTimer.Text)
                {
                    case "8":
                        TextCode.Text += "TL0=TH0=" + ResultatLoadValue.Text + ";//Charge la valeur du timer 0" + Environment.NewLine;
                        break;
                    case "16":
                        TextCode.Text += "TH0=" + ResultatLoadValue.Text + "/256;//Charge la valeur dans le registre MSB du timer 0" + Environment.NewLine;
                        TextCode.Text += "TL0=" + ResultatLoadValue.Text + "%256;//Charge la valeur dans le registre LSB du timer 0" + Environment.NewLine;
                        break;
                    case "13":
                        TextCode.Text += "VOIRE DATASHEET !!!;" + Environment.NewLine;
                        break;
                }
                switch (ModeTimer1.Text)
                {
                    case "8":
                        TextCode.Text += "TL1=TH1=" + ResultatLoadValue1.Text + ";//Charge la valeur du timer 1" + Environment.NewLine;
                        break;
                    case "16":
                        TextCode.Text += "TH1=" + ResultatLoadValue1.Text + "/256;//Charge la valeur dans le registre MSB du timer 1" + Environment.NewLine;
                        TextCode.Text += "TL1=" + ResultatLoadValue1.Text + "%256;//Charge la valeur dans le registre LSB du timer 1" + Environment.NewLine;
                        break;
                    case "13":
                        TextCode.Text += "VOIRE DATASHEET !!!;" + Environment.NewLine;
                        break;
                }
                TextCode.Text += "TF0 = 0;//clear le flag d'interruption du timer 0" + Environment.NewLine;
                TextCode.Text += "TF1 = 0;//clear le flag d'interruption du timer 1" + Environment.NewLine;
                TextCode.Text += "ET0 = 1;//Autorise l'interruption du timer 0" + Environment.NewLine;
                TextCode.Text += "ET1 = 1;//Autorise l'interruption du timer 1" + Environment.NewLine;
                TextCode.Text += "}" + Environment.NewLine + Environment.NewLine;
            }
            if ((CheckBoxTimer.Checked == true) && (CheckBoxTimer1.Checked == false))
            {
                mode = Math.Pow(2, Convert.ToDouble(ModeTimer.Text));
                prediv = Convert.ToDouble(SelectPrediv.Text);
                clock = Convert.ToDouble(ClockFrequency.Value);
                tempoCible = Convert.ToDouble(Temporisation.Value);
                switch (fmtTempo.Text)
                {
                    case "-":

                        break;
                    case "milli":
                        tempoCible = tempoCible * Math.Pow(10, -3);
                        break;
                    case "micro":
                        tempoCible = tempoCible * Math.Pow(10, -6);
                        break;
                    case "nano":
                        tempoCible = tempoCible * Math.Pow(10, -9);
                        break;
                }
                resultat = mode - (tempoCible / (prediv / clock));
                //resultat = Math.Round(resultat);
                if (resultat < 0)
                {
                    LabelErreur.Text = "ERREUR";
                    LabelErreur.ForeColor = Color.Red;
                    Copy.Enabled = false;
                }
                else
                {
                    LabelErreur.Text = "OK";
                    LabelErreur.ForeColor = Color.Blue;
                    Copy.Enabled = true;
                }
                ResultatLoadValue.Text = Convert.ToString(resultat)+" Arrondie : "+ Convert.ToString(Math.Round(resultat));
                TextCode.Text = "";
                TextCode.Text += "EA=1;//Autorise toutes les interruption" + Environment.NewLine;
                TextCode.Text += "TR0 = 1;//lance le timer 0" + Environment.NewLine;
                TextCode.Text += "void TimerInit();" + Environment.NewLine + Environment.NewLine;
                TextCode.Text += "/*---------------------------------------------------------------------------*-" + Environment.NewLine;
                TextCode.Text += "TimerInit ()" + Environment.NewLine;
                TextCode.Text += "-----------------------------------------------------------------------------" + Environment.NewLine;
                TextCode.Text += "Descriptif:" + Environment.NewLine;
                TextCode.Text += "Timer 0 : " + "Mode " + ModeTimer.Text + "bit - Prediv " + SelectPrediv.Text + " - tempo " + Temporisation.Value.ToString() + fmtTempo.Text + Environment.NewLine;
                TextCode.Text += "Entree    : --" + Environment.NewLine;
                TextCode.Text += "Sortie    : --" + Environment.NewLine;
                TextCode.Text += "-*---------------------------------------------------------------------------*/" + Environment.NewLine;
                TextCode.Text += "void TimerInit()" + Environment.NewLine;
                TextCode.Text += "{" + Environment.NewLine;
                TextCode.Text += "TR0 = 0;//Stop le timer 0" + Environment.NewLine;
                TextCode.Text += "ET0 = 0;//Desactive l'interruption du timer 0" + Environment.NewLine;
                TextCode.Text += "TMOD &= ~0x0F;//Clear le registre du mode 0" + Environment.NewLine;
                TextCode.Text += "             // +-------- Timer 1 Gate Control" + Environment.NewLine;
                TextCode.Text += "             // |+------- Counter/Timer1 Select" + Environment.NewLine;
                TextCode.Text += "             // ||++----- choix du mode du timer 1" + Environment.NewLine;
                TextCode.Text += "             // ||||+---- Timer 0 Gate Control" + Environment.NewLine;
                TextCode.Text += "             // |||||+--- Counter/Timer0 Select" + Environment.NewLine;
                TextCode.Text += "             // ||||||++- choix du mode du timer 0" + Environment.NewLine;
                TextCode.Text += "             // ||||||||  (00 : Mode 0, 13-bit Counter/Timer)" + Environment.NewLine;
                TextCode.Text += "             // ||||||||  (01 : Mode 1, 16-bit Counter/Timer)" + Environment.NewLine;
                TextCode.Text += "             // ||||||||  (10 : Mode 2, 8-bit Counter/Timer with Auto-Reload)" + Environment.NewLine;
                TextCode.Text += "             // ||||||||  (11 : Mode 3, Two 8-bit Counter/Timers)  " + Environment.NewLine;
                TextCode.Text += "TMOD |= ";
                switch (ModeTimer.Text)
                {
                    case "8":
                        TextCode.Text += "0x02;// " + Convert.ToString(Convert.ToInt64("02", 16), 2).PadLeft(8, '0') + Environment.NewLine;
                        break;
                    case "16":
                        TextCode.Text += "0x01;// " + Convert.ToString(Convert.ToInt64("01", 16), 2).PadLeft(8, '0') + Environment.NewLine;
                        break;
                    case "13":
                        TextCode.Text += "0x00;// " + Convert.ToString(Convert.ToInt64("00", 16), 2).PadLeft(8, '0') + Environment.NewLine;
                        break;
                }



                TextCode.Text += "CKCON &= ~0x07;//clear les bit de selection pour les timer 0 et 1 et le prescalaire" + Environment.NewLine;
                TextCode.Text += "              // +-------- Timer 3 High Byte Clock Select." + Environment.NewLine;
                TextCode.Text += "              // |+------- Timer 3 Low Byte Clock Select." + Environment.NewLine;
                TextCode.Text += "              // ||+------ Timer 2 High Byte Clock Select" + Environment.NewLine;
                TextCode.Text += "              // |||+----- Timer 2 Low Byte Clock Select." + Environment.NewLine;
                TextCode.Text += "              // ||||+---- Timer 1 Clock Select." + Environment.NewLine;
                TextCode.Text += "              // |||||+--- Timer 0 Clock Select." + Environment.NewLine;
                TextCode.Text += "              // ||||||++- Timer 0/1 Prescale Bits." + Environment.NewLine;
                TextCode.Text += "              // ||||||||  (00: System clock divided by 12)" + Environment.NewLine;
                TextCode.Text += "              // ||||||||  (01: System clock divided by 4)" + Environment.NewLine;
                TextCode.Text += "              // ||||||||  (10: System clock divided by 48)" + Environment.NewLine;
                TextCode.Text += "              // ||||||||  (11: External clock divided by 8 (synchronized with the system clock))  " + Environment.NewLine;
                TextCode.Text += "CKCON |= ";
                switch (SelectPrediv.Text)
                {
                    case "48":
                        TextCode.Text += "0x02;// " + Convert.ToString(Convert.ToInt64("02", 16), 2).PadLeft(8, '0') + Environment.NewLine;
                        break;
                    case "12":
                        TextCode.Text += "0x00;// " + Convert.ToString(Convert.ToInt64("00", 16), 2).PadLeft(8, '0') + Environment.NewLine;
                        break;
                    case "4":
                        TextCode.Text += "0x01;// " + Convert.ToString(Convert.ToInt64("01", 16), 2).PadLeft(8, '0') + Environment.NewLine;
                        break;
                }
                switch (ModeTimer.Text)
                {
                    case "8":
                        TextCode.Text += "TL0=TH0=" + Convert.ToString(Math.Round(resultat)) + ";//Charge la valeur du timer 0" + Environment.NewLine;
                        break;
                    case "16":
                        TextCode.Text += "TH0=" + Convert.ToString(Math.Round(resultat)) + "/256;//Charge la valeur dans le registre MSB du timer 0" + Environment.NewLine;
                        TextCode.Text += "TL0=" + Convert.ToString(Math.Round(resultat)) + "%256;//Charge la valeur dans le registre LSB du timer 0" + Environment.NewLine;
                        break;
                    case "13":
                        TextCode.Text += "VOIRE DATASHEET !!!;" + Environment.NewLine;
                        break;
                }
                TextCode.Text += "TF0 = 0;//clear le flag d'interruption du timer 0" + Environment.NewLine;
                TextCode.Text += "ET0 = 1;//Autorise l'interruption du timer 0" + Environment.NewLine;
                TextCode.Text += "}" + Environment.NewLine + Environment.NewLine;
            }
            if ((CheckBoxTimer.Checked == false) && (CheckBoxTimer1.Checked == true))
            {
                mode1 = Math.Pow(2, Convert.ToDouble(ModeTimer1.Text));
                prediv = Convert.ToDouble(SelectPrediv.Text);
                clock = Convert.ToDouble(ClockFrequency.Value);
                tempoCible1 = Convert.ToDouble(Temporisation1.Value);
                switch (fmtTempo1.Text)
                {
                    case "-":

                        break;
                    case "milli":
                        tempoCible1 = tempoCible1 * Math.Pow(10, -3);
                        break;
                    case "micro":
                        tempoCible1 = tempoCible1 * Math.Pow(10, -6);
                        break;
                    case "nano":
                        tempoCible1 = tempoCible1 * Math.Pow(10, -9);
                        break;
                }
                resultat1 = mode1 - (tempoCible1 / (prediv / clock));
                //resultat1 = Math.Round(resultat1);
                if (resultat1 < 0)
                {
                    LabelErreur1.Text = "ERREUR";
                    LabelErreur1.ForeColor = Color.Red;
                    Copy.Enabled = false;
                }
                else
                {
                    LabelErreur1.Text = "OK";
                    LabelErreur1.ForeColor = Color.Blue;
                    Copy.Enabled = true;
                }
                ResultatLoadValue1.Text = Convert.ToString(resultat1)+" Arrondie : "+ Convert.ToString(Math.Round(resultat1));
                TextCode.Text = "";
                TextCode.Text += "EA=1;//Autorise toutes les interruption" + Environment.NewLine;
                TextCode.Text += "TR1 = 1;//lance le timer 1" + Environment.NewLine + Environment.NewLine;
                TextCode.Text += "void TimerInit();" + Environment.NewLine + Environment.NewLine;
                TextCode.Text += "/*---------------------------------------------------------------------------*-" + Environment.NewLine;
                TextCode.Text += "TimerInit ()" + Environment.NewLine;
                TextCode.Text += "-----------------------------------------------------------------------------" + Environment.NewLine;
                TextCode.Text += "Descriptif:" + Environment.NewLine;
                TextCode.Text += "Timer 1 : " + "Mode " + ModeTimer1.Text + "bit - Prediv " + SelectPrediv.Text + " - tempo " + Temporisation1.Value.ToString() + fmtTempo1.Text + Environment.NewLine;
                TextCode.Text += "Entree    : --" + Environment.NewLine;
                TextCode.Text += "Sortie    : --" + Environment.NewLine;
                TextCode.Text += "-*---------------------------------------------------------------------------*/" + Environment.NewLine;
                TextCode.Text += "void TimerInit()" + Environment.NewLine;
                TextCode.Text += "{" + Environment.NewLine;
                TextCode.Text += "TR1 = 0;//Stop le timer 1" + Environment.NewLine;
                TextCode.Text += "ET1 = 0;//Desactive l'interruption du timer 1" + Environment.NewLine;
                TextCode.Text += "TMOD &= ~0x0F;" + Environment.NewLine;
                TextCode.Text += "             // +-------- Timer 1 Gate Control" + Environment.NewLine;
                TextCode.Text += "             // |+------- Counter/Timer1 Select" + Environment.NewLine;
                TextCode.Text += "             // ||++----- choix du mode du timer 1" + Environment.NewLine;
                TextCode.Text += "             // ||||+---- Timer 0 Gate Control" + Environment.NewLine;
                TextCode.Text += "             // |||||+--- Counter/Timer0 Select" + Environment.NewLine;
                TextCode.Text += "             // ||||||++- choix du mode du timer 0" + Environment.NewLine;
                TextCode.Text += "             // ||||||||  (00 : Mode 0, 13-bit Counter/Timer)" + Environment.NewLine;
                TextCode.Text += "             // ||||||||  (01 : Mode 1, 16-bit Counter/Timer)" + Environment.NewLine;
                TextCode.Text += "             // ||||||||  (10 : Mode 2, 8-bit Counter/Timer with Auto-Reload)" + Environment.NewLine;
                TextCode.Text += "             // ||||||||  (11 : Mode 3, Two 8-bit Counter/Timers)  " + Environment.NewLine;
                TextCode.Text += "TMOD |= ";
                switch (ModeTimer1.Text)
                {
                    case "8":
                        TextCode.Text += "0x20;// " + Convert.ToString(Convert.ToInt64("20", 16), 2).PadLeft(8, '0') + Environment.NewLine;
                        break;
                    case "16":
                        TextCode.Text += "0x10;// " + Convert.ToString(Convert.ToInt64("10", 16), 2).PadLeft(8, '0') + Environment.NewLine;
                        break;
                    case "13":
                        TextCode.Text += "0x00;// " + Convert.ToString(Convert.ToInt64("00", 16), 2).PadLeft(8, '0') + Environment.NewLine;
                        break;
                }
                TextCode.Text += "CKCON &= ~0x07;" + Environment.NewLine;
                TextCode.Text += "              // +-------- Timer 3 High Byte Clock Select." + Environment.NewLine;
                TextCode.Text += "              // |+------- Timer 3 Low Byte Clock Select." + Environment.NewLine;
                TextCode.Text += "              // ||+------ Timer 2 High Byte Clock Select" + Environment.NewLine;
                TextCode.Text += "              // |||+----- Timer 2 Low Byte Clock Select." + Environment.NewLine;
                TextCode.Text += "              // ||||+---- Timer 1 Clock Select." + Environment.NewLine;
                TextCode.Text += "              // |||||+--- Timer 0 Clock Select." + Environment.NewLine;
                TextCode.Text += "              // ||||||++- Timer 0/1 Prescale Bits." + Environment.NewLine;
                TextCode.Text += "              // ||||||||  (00: System clock divided by 12)" + Environment.NewLine;
                TextCode.Text += "              // ||||||||  (01: System clock divided by 4)" + Environment.NewLine;
                TextCode.Text += "              // ||||||||  (10: System clock divided by 48)" + Environment.NewLine;
                TextCode.Text += "              // ||||||||  (11: External clock divided by 8 (synchronized with the system clock))  " + Environment.NewLine;
                TextCode.Text += "CKCON |= ";
                switch (SelectPrediv.Text)
                {
                    case "48":
                        TextCode.Text += "0x02;// " + Convert.ToString(Convert.ToInt64("02", 16), 2).PadLeft(8, '0') + Environment.NewLine;
                        break;
                    case "12":
                        TextCode.Text += "0x00;// " + Convert.ToString(Convert.ToInt64("00", 16), 2).PadLeft(8, '0') + Environment.NewLine;
                        break;
                    case "4":
                        TextCode.Text += "0x01;// " + Convert.ToString(Convert.ToInt64("01", 16), 2).PadLeft(8, '0') + Environment.NewLine;
                        break;
                }
                switch (ModeTimer1.Text)
                {
                    case "8":
                        TextCode.Text += "TL1=TH1=" + Convert.ToString(Math.Round(resultat1)) + ";//Charge la valeur du timer 1" + Environment.NewLine;
                        break;
                    case "16":
                        TextCode.Text += "TH1=" + Convert.ToString(Math.Round(resultat1)) + "/256;//Charge la valeur dans le registre MSB du timer 1" + Environment.NewLine;
                        TextCode.Text += "TL1=" + Convert.ToString(Math.Round(resultat1)) + "%256;//Charge la valeur dans le registre LSB du timer 1" + Environment.NewLine;
                        break;
                    case "13":
                        TextCode.Text += "VOIRE DATASHEET !!!;" + Environment.NewLine;
                        break;
                }
                TextCode.Text += "TF1 = 0;//clear le flag d'interruption du timer 1" + Environment.NewLine;
                TextCode.Text += "ET1 = 1;//Autorise l'interruption du timer 1" + Environment.NewLine;
                TextCode.Text += "}" + Environment.NewLine + Environment.NewLine;
            }

            if (CheckBoxTimer.Checked == true)
            {
                TextCode.Text += "/*---------------------------------------------------------------------------*-" + Environment.NewLine;
                TextCode.Text += "timer0()" + Environment.NewLine;
                TextCode.Text += "-----------------------------------------------------------------------------" + Environment.NewLine;
                TextCode.Text += "Descriptif: Fonction d'interruption Timer0 vecteur 1" + Environment.NewLine;
                TextCode.Text += "          Temporisation de "+Temporisation.Value+fmtTempo.Text + Environment.NewLine;
                TextCode.Text += "          Mode : "+ModeTimer.Text+"bit"+Environment.NewLine;
                TextCode.Text += "Entree    : --" + Environment.NewLine;
                TextCode.Text += "Sortie    : --" + Environment.NewLine;
                TextCode.Text += "-*---------------------------------------------------------------------------*/" + Environment.NewLine;
                TextCode.Text += "void timer0() interrupt 1" + Environment.NewLine;
                TextCode.Text += "{" + Environment.NewLine;
                TextCode.Text += "" + Environment.NewLine;
                TextCode.Text += "}" + Environment.NewLine;
            }

            if (CheckBoxTimer1.Checked == true)
            {
                TextCode.Text += "/*---------------------------------------------------------------------------*-" + Environment.NewLine;
                TextCode.Text += "timer1()" + Environment.NewLine;
                TextCode.Text += "-----------------------------------------------------------------------------" + Environment.NewLine;
                TextCode.Text += "Descriptif: Fonction d'interruption Timer1 vecteur 3" + Environment.NewLine;
                TextCode.Text += "          Temporisation de " + Temporisation1.Value + fmtTempo1.Text + Environment.NewLine;
                TextCode.Text += "          Mode : " + ModeTimer.Text + "bit" + Environment.NewLine;
                TextCode.Text += "Entree    : --" + Environment.NewLine;
                TextCode.Text += "Sortie    : --" + Environment.NewLine;
                TextCode.Text += "-*---------------------------------------------------------------------------*/" + Environment.NewLine;
                TextCode.Text += "void timer1() interrupt 3" + Environment.NewLine;
                TextCode.Text += "{" + Environment.NewLine;
                TextCode.Text += "" + Environment.NewLine;
                TextCode.Text += "}" + Environment.NewLine;
            }
            if ((CheckBoxTimer.Checked == false) && (CheckBoxTimer1.Checked == false))
            {
                TextCode.Text = "Veuilez activer un timer";
            }
        }

        private void TextCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckBoxTimer1_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckBoxTimer1.Checked)
            {
                ModeTimer1.Enabled = true;
                Temporisation1.Enabled = true;
                fmtTempo1.Enabled = true;
            }
            else
            {
                ModeTimer1.Enabled = false;
                Temporisation1.Enabled = false;
                fmtTempo1.Enabled = false;
            }
            actuCode();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            //Clipboard.SetText(TextCode.Text);
            string textforClipboard = TextCode.Text.Replace("\n", Environment.NewLine);
            if(textforClipboard!="")
            {
                Clipboard.Clear();
                Clipboard.SetText(textforClipboard);
            }
        }

        private void checkBoxTimer0_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxTimer.Checked)
            {
                ModeTimer.Enabled = true;
                Temporisation.Enabled = true;
                fmtTempo.Enabled = true;
            }
            else
            {
                ModeTimer.Enabled = false;
                Temporisation.Enabled = false;
                fmtTempo.Enabled = false;
            }
            actuCode();
        }

        private void timerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void interruptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interruption_Form InterruptionForm;
            InterruptionForm = new Interruption_Form();
            InterruptionForm.Show();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info_Form InfoForm;
            InfoForm = new Info_Form();
            InfoForm.Show();
        }

        private void SelectPrediv_SelectedIndexChanged(object sender, EventArgs e)
        {
            actuCode();
        }

        private void ModeTimer_SelectedIndexChanged(object sender, EventArgs e)
        {
            actuCode();
        }

        private void ClockFrequency_ValueChanged(object sender, EventArgs e)
        {
            actuCode();
        }

        private void Temporisation_ValueChanged(object sender, EventArgs e)
        {
            actuCode();
        }

        private void fmtTempo_SelectedIndexChanged(object sender, EventArgs e)
        {
            actuCode();
        }

        private void ModeTimer1_SelectedIndexChanged(object sender, EventArgs e)
        {
            actuCode();
        }

        private void Temporisation1_ValueChanged(object sender, EventArgs e)
        {
            actuCode();
        }

        private void fmtTempo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            actuCode();
        }

        private void Tempo_Timer_Load(object sender, EventArgs e)
        {

        }
    }
}
