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
    public partial class Interruption_Form : Form
    {
        string hexString = "00";


        // Convert.ToString(Convert.ToInt64(HexString, 16), 2).PadLeft(8, '0') + Environment.NewLine;

        public Interruption_Form()
        {
            InitializeComponent();
            Flanc_Select.Enabled = false;
            Port_Select.Enabled = false;
            Flanc_Select1.Enabled = false;
            Port_Select1.Enabled = false;
            Flanc_Select.SelectedIndex = 0;
            Flanc_Select1.SelectedIndex = 0;
            Port_Select.SelectedIndex = 0;
            Port_Select1.SelectedIndex = 0;
        }

        private void checkBox_INT0_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_INT0.Checked)
            {
                Flanc_Select.Enabled = true;
                Port_Select.Enabled = true;
            }
            else
            {
                Flanc_Select.Enabled = false;
                Port_Select.Enabled = false;
            }
            ActuCode();
        }
        private void checkBox_INT1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_INT1.Checked)
            {
                Flanc_Select1.Enabled = true;
                Port_Select1.Enabled = true;
            }
            else
            {
                Flanc_Select1.Enabled = false;
                Port_Select1.Enabled = false;
            }
            ActuCode();
        }
        private void ActuCode()
        {
            TextCode.Text = "";
            TextCode.Text += "void Init_int();" + Environment.NewLine;
            TextCode.Text += "EA=1;//Autorise toutes les interruption" + Environment.NewLine;
            TextCode.Text += "/*---------------------------------------------------------------------------*-" + Environment.NewLine;
            TextCode.Text += "Init_int ()" + Environment.NewLine;
            TextCode.Text += "-----------------------------------------------------------------------------" + Environment.NewLine;
            TextCode.Text += "Descriptif:" + Environment.NewLine;
            if (checkBox_INT0.Checked == true)
            {
                TextCode.Text += "Interruption 0 : "+Port_Select.Text+" - "+Flanc_Select.Text + Environment.NewLine;
            }
            if (checkBox_INT1.Checked == true)
            {
                TextCode.Text += "Interruption 1 : " + Port_Select1.Text + " - " + Flanc_Select1.Text + Environment.NewLine;
            }
            TextCode.Text += "Entree    : --" + Environment.NewLine;
            TextCode.Text += "Sortie    : --" + Environment.NewLine;
            TextCode.Text += "-*---------------------------------------------------------------------------*/" + Environment.NewLine;
            TextCode.Text += "void Init_int()" + Environment.NewLine;
            TextCode.Text += "{" + Environment.NewLine;
            if(checkBox_INT0.Checked==true)
            {
                TextCode.Text += "EX0=0;//Autorise l'interruption externe 0" + Environment.NewLine;
            }
            if (checkBox_INT1.Checked == true)
            {
                TextCode.Text += "EX1=0;//Autorise l'interruption externe 1" + Environment.NewLine;
            }
            if (checkBox_INT0.Checked == true)
            {
                TextCode.Text += "IT0=";
                switch(Flanc_Select.Text)
                {
                    case "Montant":
                        TextCode.Text += "1;//interruption 0 sur flanc" + Environment.NewLine;
                        break;
                    case "Descendant":
                        TextCode.Text += "1;//interruption 0 sur flanc" + Environment.NewLine;
                        break;
                    case "Etat Haut":
                        TextCode.Text += "0;//interruption 0 sur Etat" + Environment.NewLine;
                        break;
                    case "Etat Bas":
                        TextCode.Text += "0;//interruption 0 sur Etat" + Environment.NewLine;
                        break;
                }
            }
            if (checkBox_INT1.Checked == true)
            {
                TextCode.Text += "IT1=";
                switch (Flanc_Select1.Text)
                {
                    case "Montant":
                        TextCode.Text += "1;//interruption 1 sur flanc" + Environment.NewLine;
                        break;
                    case "Descendant":
                        TextCode.Text += "1;//interruption 1 sur flanc" + Environment.NewLine;
                        break;
                    case "Etat Haut":
                        TextCode.Text += "0;//interruption 1 sur Etat" + Environment.NewLine;
                        break;
                    case "Etat Bas":
                        TextCode.Text += "0;//interruption 1 sur Etat" + Environment.NewLine;
                        break;
                }
            }
            TextCode.Text += "IT01CF= IT01CF &~ ";
            if (checkBox_INT1.Checked == true)
            {
                TextCode.Text += "0xF";
                if (checkBox_INT0.Checked == true)
                {
                    TextCode.Text += "F;//Clear le registre des interruption" + Environment.NewLine;
                }
                else
                {
                    TextCode.Text += "0;//Clear le registre de l'interruption 1" + Environment.NewLine;
                }
            }
            else
            {
                if (checkBox_INT0.Checked == true)
                {
                    TextCode.Text += "0x0F;//Clear le registre de l'interruption 0" + Environment.NewLine;
                }
            }
            TextCode.Text += "                      // +-------- INT1 Polarite" + Environment.NewLine;
            TextCode.Text += "                      // |+++----- Selection du canal P0.x de l'interruption 1" + Environment.NewLine;
            TextCode.Text += "                      // ||||+---- INT0 Polarite" + Environment.NewLine;
            TextCode.Text += "                      // |||||+++- Selection du canal P0.x de l'interruption 0" + Environment.NewLine;
            TextCode.Text += "                      // ||||||||  (000: Select P0.0)" + Environment.NewLine;
            TextCode.Text += "                      // ||||||||  ..." + Environment.NewLine;
            TextCode.Text += "                      // ||||||||  ..." + Environment.NewLine;
            TextCode.Text += "                      // ||||||||  (111: Select P0.7)  " + Environment.NewLine;
            TextCode.Text += "IT01CF= IT01CF | ";
            if (checkBox_INT1.Checked == true)
            {
                if((Flanc_Select1.Text=="Descendant") || (Flanc_Select1.Text == "Etat Bas"))
                {
                    switch (Port_Select1.Text)//c'est moche, a ameliorer
                    {
                        case "P0.0":
                            hexString = "0";
                            TextCode.Text += "0x0";
                            break;
                        case "P0.1":
                            hexString = "1";
                            TextCode.Text += "0x1";
                            break;
                        case "P0.2":
                            hexString = "2";
                            TextCode.Text += "0x2";
                            break;
                        case "P0.3":
                            hexString = "3";
                            TextCode.Text += "0x3";
                            break;
                        case "P0.4":
                            hexString = "4";
                            TextCode.Text += "0x4";
                            break;
                        case "P0.5":
                            hexString = "5";
                            TextCode.Text += "0x5";
                            break;
                        case "P0.6":
                            hexString = "6";
                            TextCode.Text += "0x6";
                            break;
                        case "P0.7":
                            hexString = "7";
                            TextCode.Text += "0x7";
                            break;
                    }
                }
                else
                {
                    switch (Port_Select1.Text)
                    {
                        case "P0.0":
                            hexString = "8";
                            TextCode.Text += "0x8";
                            break;
                        case "P0.1":
                            hexString = "9";
                            TextCode.Text += "0x9";
                            break;
                        case "P0.2":
                            hexString = "A";
                            TextCode.Text += "0xA";
                            break;
                        case "P0.3":
                            hexString = "B";
                            TextCode.Text += "0xB";
                            break;
                        case "P0.4":
                            hexString = "C";
                            TextCode.Text += "0xC";
                            break;
                        case "P0.5":
                            hexString = "D";
                            TextCode.Text += "0xD";
                            break;
                        case "P0.6":
                            hexString = "E";
                            TextCode.Text += "0xE";
                            break;
                        case "P0.7":
                            hexString = "F";
                            TextCode.Text += "0xF";
                            break;
                    }
                }
               
                if (checkBox_INT0.Checked == true)
                {
                    if ((Flanc_Select.Text == "Descendant") || (Flanc_Select.Text == "Etat Bas"))
                    {
                        switch (Port_Select.Text)
                        {
                            case "P0.0":
                                hexString += "0";
                                TextCode.Text += "0;";
                                break;
                            case "P0.1":
                                hexString += "1";
                                TextCode.Text += "1;";
                                break;
                            case "P0.2":
                                hexString += "2";
                                TextCode.Text += "2;";
                                break;
                            case "P0.3":
                                hexString += "3";
                                TextCode.Text += "3;";
                                break;
                            case "P0.4":
                                hexString += "4";
                                TextCode.Text += "4;";
                                break;
                            case "P0.5":
                                hexString += "5";
                                TextCode.Text += "5;";
                                break;
                            case "P0.6":
                                hexString += "6";
                                TextCode.Text += "6;";
                                break;
                            case "P0.7":
                                hexString += "7";
                                TextCode.Text += "7;";
                                break;
                        }
                    }
                    else
                    {
                        switch (Port_Select.Text)
                        {
                            case "P0.0":
                                hexString += "8";
                                TextCode.Text += "8;";
                                break;
                            case "P0.1":
                                hexString += "9";
                                TextCode.Text += "9;";
                                break;
                            case "P0.2":
                                hexString += "A";
                                TextCode.Text += "A;";
                                break;
                            case "P0.3":
                                hexString += "B";
                                TextCode.Text += "B;";
                                break;
                            case "P0.4":
                                hexString += "C";
                                TextCode.Text += "C;";
                                break;
                            case "P0.5":
                                hexString += "D";
                                TextCode.Text += "D;";
                                break;
                            case "P0.6":
                                hexString += "E";
                                TextCode.Text += "E;";
                                break;
                            case "P0.7":
                                hexString += "F";
                                TextCode.Text += "F;";
                                break;
                        }
                    }
                }
                else
                {
                    hexString += "0";
                    TextCode.Text += "0;";
                }
            }
            else
            {
                if (checkBox_INT0.Checked == true)
                {
                    if ((Flanc_Select.Text == "Descendant") || (Flanc_Select.Text == "Etat Bas"))
                    {
                        switch (Port_Select.Text)
                        {
                            case "P0.0":
                                hexString = "00";
                                TextCode.Text += "0x00;";
                                break;
                            case "P0.1":
                                hexString = "01";
                                TextCode.Text += "0x01;";
                                break;
                            case "P0.2":
                                hexString = "02";
                                TextCode.Text += "0x02;";
                                break;
                            case "P0.3":
                                hexString = "03";
                                TextCode.Text += "0x03;";
                                break;
                            case "P0.4":
                                hexString = "04";
                                TextCode.Text += "0x04;";
                                break;
                            case "P0.5":
                                hexString = "05";
                                TextCode.Text += "0x05;";
                                break;
                            case "P0.6":
                                hexString = "06";
                                TextCode.Text += "0x06;";
                                break;
                            case "P0.7":
                                hexString = "07";
                                TextCode.Text += "0x07;";
                                break;
                        }
                    }
                    else
                    {
                        switch (Port_Select.Text)
                        {
                            case "P0.0":
                                hexString = "08";
                                TextCode.Text += "0x08;";
                                break;
                            case "P0.1":
                                hexString = "09";
                                TextCode.Text += "0x09;";
                                break;
                            case "P0.2":
                                hexString = "0A";
                                TextCode.Text += "0x0A;";
                                break;
                            case "P0.3":
                                hexString = "0B";
                                TextCode.Text += "0x0B;";
                                break;
                            case "P0.4":
                                hexString = "0C";
                                TextCode.Text += "0x0C;";
                                break;
                            case "P0.5":
                                hexString = "0D";
                                TextCode.Text += "0x0D;";
                                break;
                            case "P0.6":
                                hexString = "0E";
                                TextCode.Text += "0x0E;";
                                break;
                            case "P0.7":
                                hexString = "0F";
                                TextCode.Text += "0x0F;";
                                break;
                        }
                    }
                }
            }
            TextCode.Text+="// " +Convert.ToString(Convert.ToInt64(hexString, 16), 2).PadLeft(8, '0') + Environment.NewLine;
            TextCode.Text += "" + Environment.NewLine;
            if (checkBox_INT0.Checked == true)
            {
                TextCode.Text += "IE0=0; IE0=0; IE0=0;//clear du flag d'interruption 0 (3* pour eviter les bug)" + Environment.NewLine;
            }
            if (checkBox_INT1.Checked == true)
            {
                TextCode.Text += "IE1=0; IE1=0; IE1=0;//clear du flag d'interruption 1 (3* pour eviter les bug)" + Environment.NewLine;
            }
            if (checkBox_INT0.Checked == true)
            {
                TextCode.Text += "EX0=1;//Active l'interruption 0" + Environment.NewLine;
            }
            if (checkBox_INT1.Checked == true)
            {
                TextCode.Text += "EX1=1;//Active l'interruption 1" + Environment.NewLine;
            }
            TextCode.Text += "}" + Environment.NewLine + Environment.NewLine + Environment.NewLine;

            if (checkBox_INT0.Checked == true)
            {
                TextCode.Text += "/*---------------------------------------------------------------------------*-" + Environment.NewLine;
                TextCode.Text += "interruption0()" + Environment.NewLine;
                TextCode.Text += "-----------------------------------------------------------------------------" + Environment.NewLine;
                TextCode.Text += "Descriptif: Fonction d'interruption INT0 vecteur 0" + Environment.NewLine;
                TextCode.Text += "            Pin :"+Port_Select.Text+ " - "+Flanc_Select.Text+ Environment.NewLine;
                TextCode.Text += "Entree    : --" + Environment.NewLine;
                TextCode.Text += "Sortie    : --" + Environment.NewLine;
                TextCode.Text += "-*---------------------------------------------------------------------------*/" + Environment.NewLine;
                TextCode.Text += "void interruption0() interrupt 0" + Environment.NewLine;
                TextCode.Text += "{" + Environment.NewLine;
                TextCode.Text += "" + Environment.NewLine;
                TextCode.Text += "}" + Environment.NewLine;
            }
            if (checkBox_INT1.Checked == true)
            {
                TextCode.Text += "/*---------------------------------------------------------------------------*-" + Environment.NewLine;
                TextCode.Text += "interruption1()" + Environment.NewLine;
                TextCode.Text += "-----------------------------------------------------------------------------" + Environment.NewLine;
                TextCode.Text += "Descriptif: Fonction d'interruption 1 vecteur 2" + Environment.NewLine;
                TextCode.Text += "            Pin :" + Port_Select1.Text + " - " + Flanc_Select1.Text + Environment.NewLine;
                TextCode.Text += "Entree    : --" + Environment.NewLine;
                TextCode.Text += "Sortie    : --" + Environment.NewLine;
                TextCode.Text += "-*---------------------------------------------------------------------------*/" + Environment.NewLine;
                TextCode.Text += "void interruption1() interrupt 2" + Environment.NewLine;
                TextCode.Text += "{" + Environment.NewLine;
                TextCode.Text += "" + Environment.NewLine;
                TextCode.Text += "}" + Environment.NewLine;
            }
        }

        private void Port_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActuCode();
        }

        private void Flanc_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActuCode();
        }

        private void Port_Select1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActuCode();
        }

        private void Flanc_Select1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActuCode();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            string textforClipboard = TextCode.Text.Replace("\n", Environment.NewLine);
            if (textforClipboard != "")
            {
                Clipboard.Clear();
                Clipboard.SetText(textforClipboard);
            }
        }

        private void Interruption_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
