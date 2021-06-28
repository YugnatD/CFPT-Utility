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
    public partial class TableGenerator : Form
    {
        public TableGenerator()
        {
            InitializeComponent();
        }

        private void TableGenerator_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerer_Click(object sender, EventArgs e)
        {
            String[] valeur;
            long valConvertie=0;
            rtbValeur.Text = rtbValeur.Text.TrimEnd('\n');//supprime les dernier retour a la ligne
            int count = rtbValeur.Text.Split('\n').Length;
            rtbResultat.Text = "";
            //determine la nature de la variable
            long min=0;
            long max=0;
            valeur = rtbValeur.Text.Split('\n');
                for (int i = 0; i < count; i++)
                {
                    if (valeur[i] != "")
                    {
                        valConvertie = Convert.ToInt64(valeur[i]);
                        if (valConvertie > max)
                        {
                            max = valConvertie;
                        }
                        if (valConvertie < min)
                        {
                            min = valConvertie;
                        }
                    }
                }
                if (min < 0)//valeur signee
                {

                    if (min >= -127)
                    {
                        //char
                        if (max <= 127)
                        {
                            //char
                            rtbResultat.Text += "char ";
                        }
                        else if ((max > 127) && (max <= 32767))
                        {
                            //int
                            rtbResultat.Text += "int ";
                        }
                        else if ((max > 32767) && (max <= 2147483647))
                        {
                            //long
                            rtbResultat.Text += "long ";
                        }
                    }
                    else if ((min < -127) && (min >= -32767))
                    {
                        //int
                        if ((max > 127) && (max <= 32767))
                        {
                            //int
                            rtbResultat.Text += "int ";
                        }
                        else if ((max > 32767) && (max <= 2147483647))
                        {
                            //long
                            rtbResultat.Text += "long ";
                        }
                        else
                        {
                            rtbResultat.Text += "int ";
                        }
                    }
                    else if ((min < -32767) && (min >= -2147483647))
                    {
                        //long
                        rtbResultat.Text += "long ";
                    }

                }
                else//non signer
                {
                    rtbResultat.Text += "unsigned ";
                    if (max <= 255)
                    {
                        //char
                        rtbResultat.Text += "char ";
                    }
                    else if ((max > 255) && (max <= 65535))
                    {
                        //int
                        rtbResultat.Text += "int ";
                    }
                    else if ((max > 65535) && (max <= 4294967295))
                    {
                        //long
                        rtbResultat.Text += "long ";
                    }

                }
                rtbResultat.Text += tebNom.Text + "[" + count.ToString() + "]" + "={";
                rtbResultat.Text += rtbValeur.Text.Replace("\n", ",");
                rtbResultat.Text += "};";
                rtbResultat.Text = rtbResultat.Text.Replace("\t", "");
        }

        private void btnCopier_Click(object sender, EventArgs e)
        {
            string textforClipboard = rtbResultat.Text.Replace("\n", Environment.NewLine);
            if (textforClipboard != "")
            {
                Clipboard.Clear();
                Clipboard.SetText(textforClipboard);
            }
        }
    }
}
