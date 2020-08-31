using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFPT_Utility
{
    public partial class ADC : Form
    {
        public ADC()
        {
            InitializeComponent();
        }

        private void ADC_Load(object sender, EventArgs e)
        {
            cmbEntreeN.SelectedIndex=22;
            cmbEntreeP.SelectedIndex = 0;
            cmbStartConv.SelectedIndex = 0;
            cmbReference.SelectedIndex = 1;
            cmbGain.SelectedIndex = 1;
            chkbInternalRegulator.Checked = true;
        }

        private void ActuCode()
        {
            int ADC0CF = 0x00;
            int ADC0CN = 0x00;
            int REF0CN = 0x00;
            string hexString ="" ;
            TextCode.Text = "";
            TextCode.Text += "void ADCInit();" + Environment.NewLine + Environment.NewLine;
            if(chkbInterruptADC.Checked)
            {
                TextCode.Text += "EADC0=1;//autorise l'interruption de l'ADC0 (EIE1.3)" + Environment.NewLine;
                TextCode.Text += "EA=1;//autorise les interruption" + Environment.NewLine;
            }
            
            TextCode.Text += "/*---------------------------------------------------------------------------*-" + Environment.NewLine;
            TextCode.Text += "ADCInit()" + Environment.NewLine;
            TextCode.Text += "-----------------------------------------------------------------------------" + Environment.NewLine;
            TextCode.Text += "Descriptif:" + Environment.NewLine;
            TextCode.Text += "Pin + : "+cmbEntreeP.Text+Environment.NewLine;
            TextCode.Text += "Pin - : "+ cmbEntreeN.Text + Environment.NewLine;
            if(chkbGauche.Checked)
            {
                TextCode.Text += "Aligner a Gauche" + Environment.NewLine;
            }
            else
            {
                TextCode.Text += "Aligner a Droite" + Environment.NewLine;
            }
            TextCode.Text += "Conversion sur : " + cmbStartConv.Text + Environment.NewLine;
            TextCode.Text += "Clock SAR : " + nudSARFrequency.Value.ToString() + Environment.NewLine;
            TextCode.Text += "Entree    : --" + Environment.NewLine;
            TextCode.Text += "Sortie    : --" + Environment.NewLine;
            TextCode.Text += "-*---------------------------------------------------------------------------*/" + Environment.NewLine;
            TextCode.Text += "void ADCInit()" + Environment.NewLine;
            TextCode.Text += "{" + Environment.NewLine;
            if (cmbEntreeP.SelectedIndex <= 20)
            {
                TextCode.Text += "AMX0P=0x" + Convert.ToString(cmbEntreeP.SelectedIndex, 16).PadLeft(2, '0').ToUpper() + ";//Entree positive sur " + cmbEntreeP.SelectedItem + Environment.NewLine;
            }
            else
            {
                TextCode.Text += "AMX0P=0x" + Convert.ToString(cmbEntreeP.SelectedIndex+9, 16).PadLeft(2, '0').ToUpper() + ";//Entree positive sur " + cmbEntreeP.SelectedItem + Environment.NewLine;
            }
            if (cmbEntreeN.SelectedIndex <= 20)
            {
                TextCode.Text += "AMX0N=0x" + Convert.ToString(cmbEntreeN.SelectedIndex, 16).PadLeft(2, '0').ToUpper() + ";//Entree positive sur " + cmbEntreeN.SelectedItem + Environment.NewLine;
            }
            else
            {
                TextCode.Text += "AMX0N=0x" + Convert.ToString(cmbEntreeN.SelectedIndex + 9, 16).PadLeft(2, '0').ToUpper() + ";//Entree negative sur " + cmbEntreeN.SelectedItem + Environment.NewLine;
            }
            TextCode.Text += "          //   +++++----- ADC0 SAR Conversion Clock Period Bits." + Environment.NewLine;
            TextCode.Text += "          //   |||||+---- AD0LJST ajustement a droite" + Environment.NewLine;
            TextCode.Text += "          //   ||||||++-- Reserver" + Environment.NewLine;
            TextCode.Text += "          //   ||||||||  " + Environment.NewLine;
            if(chkbGauche.Checked)
            {
                ADC0CF += 4; 
            }
            nudSARFrequency.Minimum = nudClockFrequency.Value / 32;
            nudSARFrequency.Maximum = nudClockFrequency.Maximum;
            ADC0CF += Convert.ToInt16(((nudClockFrequency.Value / nudSARFrequency.Value) - 1) * 8);
            hexString = Convert.ToString(ADC0CF, 16).PadLeft(2, '0');
            TextCode.Text += "ADC0CF=0x" + hexString.ToUpper() + ";// " + Convert.ToString(Convert.ToInt64(hexString, 16), 2).PadLeft(8, '0') + " - clk SAR de "+nudSARFrequency.Value.ToString()+"Hz ";
            TextCode.Text += "";
            if (chkbGauche.Checked)
            {
                TextCode.Text += "aligner a gauche";
            }
            else
            {
                TextCode.Text += "aligner a droite";
            }
            TextCode.Text += Environment.NewLine;
            TextCode.Text += "            // +--------  ADC0 Enable Bit" + Environment.NewLine;
            TextCode.Text += "            // |+-------  ADC0 Track Mode Bit." + Environment.NewLine;
            TextCode.Text += "            // ||+------- AD0INT ADC0 Conversion Complete Interrupt Flag" + Environment.NewLine;
            TextCode.Text += "            // |||+------ AD0BUSY" + Environment.NewLine;
            TextCode.Text += "            // ||||+----- ADC0 Window Compare Interrupt Flag" + Environment.NewLine;
            TextCode.Text += "            // |||||+++-- ADC0 Start of Conversion Mode Select" + Environment.NewLine;
            TextCode.Text += "            // ||||||||  " + Environment.NewLine;
            ADC0CN = cmbStartConv.SelectedIndex;
            if(chkbLowPower.Checked)
            {
                ADC0CN += 0x40;
            }
            ADC0CN += 0x80;
            hexString = Convert.ToString(ADC0CN, 16).PadLeft(2, '0');
            TextCode.Text += "ADC0CN=0x" + hexString.ToUpper()+";// "+ Convert.ToString(Convert.ToInt64(hexString, 16), 2).PadLeft(8, '0')+Environment.NewLine;
            TextCode.Text += "            // +--------- Reference Buffer Gain Select." + Environment.NewLine;
            TextCode.Text += "            // |++------- Unused" + Environment.NewLine;
            TextCode.Text += "            // |||+------ Regulator Reference Override" + Environment.NewLine;
            TextCode.Text += "            // ||||+----- Voltage Reference Select." + Environment.NewLine;
            TextCode.Text += "            // |||||+---- Temperature Sensor Enable Bit" + Environment.NewLine;
            TextCode.Text += "            // ||||||+--- Internal Analog Bias Generator Enable Bit." + Environment.NewLine;
            TextCode.Text += "            // |||||||+-- On-chip Reference Buffer Enable Bit." + Environment.NewLine;
            TextCode.Text += "            // ||||||||  " + Environment.NewLine;


            REF0CN = 0x00;
            if(chkbTempSensor.Checked)
            {
                REF0CN += 4;
            }
            if(chkbBiasGenerator.Checked)
            {
                REF0CN += 2;
            }
            if (chkbInternalRegulator.Checked)
            {
                REF0CN += 0x10;
                if(cmbGain.SelectedIndex==0)
                {
                    lblTensionVref.Text = "1.2V";
                    REF0CN += 0x80;
                }
                else
                {
                    lblTensionVref.Text = "2.4V";
                }
            }
            else
            {
                if(cmbReference.SelectedIndex==0)//sur VDD
                {
                    REF0CN += 8;
                    lblTensionVref.Text="3.3V";
                }
                else
                {
                    lblTensionVref.Text = "Pin Externe VREF";
                }
            }
            if(chkbBuffer.Checked)
            {
                REF0CN += 1;
            }

            hexString = Convert.ToString(REF0CN, 16).PadLeft(2, '0');
            TextCode.Text +="REF0CN=0x" +hexString.ToUpper() + ";// " + Convert.ToString(Convert.ToInt64(hexString, 16), 2).PadLeft(8, '0') + Environment.NewLine; ;
            TextCode.Text += "}"+Environment.NewLine+Environment.NewLine;

            if(chkbInterruptADC.Checked)
            {
                TextCode.Text += "/*---------------------------------------------------------------------------*-" + Environment.NewLine;
                TextCode.Text += "ADCComplete()" + Environment.NewLine;
                TextCode.Text += "-----------------------------------------------------------------------------" + Environment.NewLine;
                TextCode.Text += "Descriptif: fonction d'interruption de fin de conversion de l'ADC vecteur 10" + Environment.NewLine;
                TextCode.Text += "Pin + : " + cmbEntreeP.Text + Environment.NewLine;
                TextCode.Text += "Pin - : " + cmbEntreeN.Text + Environment.NewLine;
                if (chkbGauche.Checked)
                {
                    TextCode.Text += "Aligner a Gauche" + Environment.NewLine;
                }
                else
                {
                    TextCode.Text += "Aligner a Droite" + Environment.NewLine;
                }
                TextCode.Text += "Conversion sur : " + cmbStartConv.Text + Environment.NewLine;
                TextCode.Text += "Clock SAR : " + nudSARFrequency.Value.ToString() + Environment.NewLine;
                TextCode.Text += "Entree    : --" + Environment.NewLine;
                TextCode.Text += "Sortie    : --" + Environment.NewLine;
                TextCode.Text += "-*---------------------------------------------------------------------------*/" + Environment.NewLine;
                TextCode.Text += "void ADCComplete() interrupt 10" + Environment.NewLine;
                TextCode.Text += "{" + Environment.NewLine;
                TextCode.Text += "unsigned int valADC=0;"+Environment.NewLine;
                TextCode.Text += "valADC=(ADC0H<<8)+ADC0L;" + Environment.NewLine;
                TextCode.Text += "AD0INT=0;//clear le flag d'interruption" + Environment.NewLine;
                TextCode.Text += "}" + Environment.NewLine;
            }

        }

        private void cmbEntreeP_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActuCode();
        }

        private void cmbEntreeN_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActuCode();
        }

        private void chkbGauche_CheckedChanged(object sender, EventArgs e)
        {
            ActuCode();
        }

        private void nudClockFrequency_ValueChanged(object sender, EventArgs e)
        {
            ActuCode();
        }

        private void nudSARFrequency_ValueChanged(object sender, EventArgs e)
        {
            ActuCode();
        }

        private void btnCopyText_Click(object sender, EventArgs e)
        {
            ActuCode();
            string textforClipboard = TextCode.Text.Replace("\n", Environment.NewLine);
            if (textforClipboard != "")
            {
                Clipboard.Clear();
                Clipboard.SetText(textforClipboard);
            }
        }

        private void btnCalcule_Click(object sender, EventArgs e)
        {
            ActuCode();
        }

        private void cmbStartConv_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActuCode();
        }

        private void chkbLowPower_CheckedChanged(object sender, EventArgs e)
        {
            ActuCode();
        }

        private void chkbInternalRegulator_CheckedChanged(object sender, EventArgs e)
        {
            cmbReference.Enabled = !chkbInternalRegulator.Checked;
            cmbGain.Enabled= chkbInternalRegulator.Checked;
            ActuCode();
        }

        private void chkbTempSensor_CheckedChanged(object sender, EventArgs e)
        {
            ActuCode();
        }

        private void chkbBiasGenerator_CheckedChanged(object sender, EventArgs e)
        {
            ActuCode();
        }

        private void chkbBuffer_CheckedChanged(object sender, EventArgs e)
        {
            ActuCode();
        }

        private void cmbGain_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActuCode();
        }

        private void cmbReference_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActuCode();
        }

        private void chkbInterruptADC_CheckedChanged(object sender, EventArgs e)
        {
            ActuCode();
        }
    }
}
