using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dessin
{
    public partial class LCD_DOG : Form
    {
        int iLigne;
        int iColonne;
        int valByte = 0;
        int decalMultiple = 1;
        int compteByte = 0;
        int compteImageAnim = 0;
        bool pressed;
        Color couleurDessin = Color.Black;
        int numberOfFile = 0;
        //OpenFileDialog dlg = new OpenFileDialog();
        string[] files = new string[15];
        public LCD_DOG()
        {
            InitializeComponent();
            DessinBox.Image = new Bitmap(DessinBox.Image.Width, DessinBox.Image.Height);
            Couleur.SelectedIndex=0;
            progressCode.Maximum = 1024;
            progressCode.Step = 1;
            CheckOpti.Checked = true;
            ChecknonOpti.Checked = false;
            Code.Enabled = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear.PerformClick();
        }

        private void DessinBox_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.X < 640) && (e.Y < 320) && (e.X > 0) && (e.Y > 0))
            {
                try
                {
                    ((Bitmap)DessinBox.Image).SetPixel(e.X / 5, e.Y / 5, couleurDessin);
                    pressed = true;
                }
                catch
                {
                    MessageBox.Show("Image non modifiable");
                    pressed = false;
                }
                DessinBox.Refresh();
            }
        }

        private void DessinBox_MouseUp(object sender, MouseEventArgs e)
        {
            pressed = false;
        }

        private void DessinBox_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.X < 640) && (e.Y < 320) && (e.X >0) && (e.Y > 0))
            {
                if (pressed == true)
                {
                    try
                    {
                        ((Bitmap)DessinBox.Image).SetPixel(e.X / 5, e.Y / 5, couleurDessin);
                    }
                    catch
                    {
                        MessageBox.Show("Erreur");
                        pressed = false;
                    }
                    DessinBox.Refresh();
                }
            }
            PixelX.Text = Convert.ToString(e.X/5);
            PixelY.Text = Convert.ToString(e.Y/5);
        }

        private void Generer_button_Click(object sender, EventArgs e)
        {
            iLigne=0;
            iColonne=0;
            valByte = 0;
            decalMultiple = 1;
            compteByte = 0;
            compteImageAnim = 0;
            progressCode.Value = 0;
            Code.Text = "";
            CodeOpti.Text = "";
            progressCode.Maximum = 0;
            if (CheckOpti.Checked == true)
            {
                if (numberOfFile > 1)
                {
                    progressCode.Maximum += numberOfFile * 1024;
                }
                else
                {
                    progressCode.Maximum += 1024;
                }

            }
            if (ChecknonOpti.Checked == true)
            {
                progressCode.Maximum += 8192;
            }

            if (ChecknonOpti.Checked == true)
            {
                //code non opti
                try
                {
                    for (iColonne = 0; iColonne < 128; iColonne++)
                    {
                        for (iLigne = 0; iLigne < 64; iLigne++)
                        {
                            if (InvertColor.Checked == true)
                            {
                                if (((Bitmap)DessinBox.Image).GetPixel(iColonne, (iLigne * 8) + compteByte) == Color.FromArgb(255, 255, 255, 255))
                                {
                                    valByte = valByte + decalMultiple;
                                }
                            }
                            else
                            {
                                if (((Bitmap)DessinBox.Image).GetPixel(iColonne, (iLigne * 8) + compteByte) == Color.FromArgb(255, 0, 0, 0))
                                {
                                    valByte = valByte + decalMultiple;
                                }
                            }
                            decalMultiple = decalMultiple * 2;
                            if (decalMultiple > 128)
                            {
                                if (valByte > 0)
                                {
                                    Code.Text += "SelectPosLiCo(" + Convert.ToString(iLigne / 8) + "," + Convert.ToString(iColonne) + ");" + Environment.NewLine;
                                    Code.Text += "AfficherByte(" + Convert.ToString(valByte) + ");" + Environment.NewLine;
                                }
                                valByte = 0;
                                decalMultiple = 1;
                            }
                            progressCode.PerformStep();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Une erreur inconnue c'est produite");
                }
               
            }
            if (CheckOpti.Checked == true)
            {
                //code opti a peu pres
                iLigne = 0;
                iColonne = 0;
                valByte = 0;
                decalMultiple = 1;
                compteByte = 0;
                if (numberOfFile > 1)
                {
                    CodeOpti.Text = "";
                    CodeOpti.Text += "void Animation(unsigned int delai_image);" + Environment.NewLine;
                    CodeOpti.Text += "void Animation(unsigned int delai_image)" + Environment.NewLine;
                    CodeOpti.Text += "{" + Environment.NewLine;
                    for (compteImageAnim = 0; compteImageAnim < numberOfFile; compteImageAnim++)
                    {
                        DessinBox.Image = new Bitmap(files[compteImageAnim]);
                        DessinBox.Refresh();
                        CodeOpti.Text += "unsigned char code image" + Convert.ToString(compteImageAnim) + " [8][128]={{";
                        for (iLigne = 0; iLigne < 8; iLigne++)
                        {
                            for (iColonne = 0; iColonne < 128; iColonne++)
                            {
                                for (compteByte = 0; compteByte < 8; compteByte++)
                                {
                                    if (InvertColor.Checked == true)
                                    {
                                        if (((Bitmap)DessinBox.Image).GetPixel(iColonne, (iLigne * 8) + compteByte) == Color.FromArgb(255, 255, 255, 255))
                                        {
                                            valByte = valByte + decalMultiple;
                                        }
                                    }
                                    else
                                    {
                                        if (((Bitmap)DessinBox.Image).GetPixel(iColonne, (iLigne * 8) + compteByte) == Color.FromArgb(255, 0, 0, 0))
                                        {
                                            valByte = valByte + decalMultiple;
                                        }
                                    }

                                    decalMultiple = decalMultiple * 2;
                                    if (decalMultiple > 128)
                                    {
                                        if (iColonne == 127)
                                        {
                                            CodeOpti.Text += Convert.ToString(valByte);
                                        }
                                        else
                                        {
                                            CodeOpti.Text += Convert.ToString(valByte) + ",";
                                        }
                                        valByte = 0;
                                        decalMultiple = 1;
                                        progressCode.PerformStep();
                                    }

                                }

                            }
                            if (iLigne == 7)
                            {
                                CodeOpti.Text += "}};" + Environment.NewLine;
                            }
                            else
                            {
                                CodeOpti.Text += "}" + "," + "{";
                            }

                        }
                    }
                    CodeOpti.Text += Environment.NewLine + "unsigned char x,y;" + Environment.NewLine;
                    //CodeOpti.Text += "for(z=0;z<" + Convert.ToString(numberOfFile) + ";z++)" + Environment.NewLine;
                    //CodeOpti.Text += "{" + Environment.NewLine;
                    //CodeOpti.Text += "Delay_1ms(3000);" + Environment.NewLine;
                    for (compteImageAnim = 0; compteImageAnim < numberOfFile; compteImageAnim++)
                    {
                        CodeOpti.Text += "for(x=0;x<8;x++)" + Environment.NewLine;
                        CodeOpti.Text += "{" + Environment.NewLine;
                        CodeOpti.Text += "for(y=0;y<128;y++)" + Environment.NewLine;
                        CodeOpti.Text += "{" + Environment.NewLine;
                        CodeOpti.Text += "SelectPosLiCo(x,y);" + Environment.NewLine;
                        CodeOpti.Text += "AfficherByte(image" + Convert.ToString(compteImageAnim) + "[x][y]);" + Environment.NewLine;
                        CodeOpti.Text += "}" + Environment.NewLine;
                        CodeOpti.Text += "}" + Environment.NewLine;
                        CodeOpti.Text += "Delay_1ms(delai_image);" + Environment.NewLine;
                    }

                    CodeOpti.Text += "}" + Environment.NewLine;
                    //CodeOpti.Text += "}" + Environment.NewLine;

                }
                else
                {
                    CodeOpti.Text = "";
                    CodeOpti.Text += "void AfficheImage();" + Environment.NewLine;
                    CodeOpti.Text += "void AfficheImage()" + Environment.NewLine;
                    CodeOpti.Text += "{" + Environment.NewLine;
                    CodeOpti.Text += "unsigned char code image [8][128]={{";
                    for (iLigne = 0; iLigne < 8; iLigne++)
                    {
                        for (iColonne = 0; iColonne < 128; iColonne++)
                        {
                            for (compteByte = 0; compteByte < 8; compteByte++)
                            {
                                if (InvertColor.Checked == true)
                                {
                                    if (((Bitmap)DessinBox.Image).GetPixel(iColonne, (iLigne * 8) + compteByte) == Color.FromArgb(255, 255, 255, 255))
                                    {
                                        valByte = valByte + decalMultiple;
                                    }
                                }
                                else
                                {
                                    if (((Bitmap)DessinBox.Image).GetPixel(iColonne, (iLigne * 8) + compteByte) == Color.FromArgb(255, 0, 0, 0))
                                    {
                                        valByte = valByte + decalMultiple;
                                    }
                                }
                                decalMultiple = decalMultiple * 2;
                                if (decalMultiple > 128)
                                {
                                    if (iColonne == 127)
                                    {
                                        CodeOpti.Text += Convert.ToString(valByte);
                                    }
                                    else
                                    {
                                        CodeOpti.Text += Convert.ToString(valByte) + ",";
                                    }
                                    valByte = 0;
                                    decalMultiple = 1;
                                    progressCode.PerformStep();
                                }

                            }

                        }
                        if (iLigne == 7)
                        {
                            CodeOpti.Text += "}};";
                        }
                        else
                        {
                            CodeOpti.Text += "}" + "," + "{";
                        }

                    }
                    CodeOpti.Text += "unsigned char x,y;" + Environment.NewLine;
                    CodeOpti.Text += "for(x=0;x<8;x++)" + Environment.NewLine;
                    CodeOpti.Text += "{" + Environment.NewLine;
                    CodeOpti.Text += "for(y=0;y<128;y++)" + Environment.NewLine;
                    CodeOpti.Text += "{" + Environment.NewLine;
                    CodeOpti.Text += "SelectPosLiCo(x,y);" + Environment.NewLine;
                    CodeOpti.Text += "AfficherByte(image[x][y]);" + Environment.NewLine;
                    CodeOpti.Text += "}" + Environment.NewLine;
                    CodeOpti.Text += "}" + Environment.NewLine;
                    CodeOpti.Text += "}" + Environment.NewLine;
                }

            }


        }

        private void Copy_Click(object sender, EventArgs e)
        {
            string textforClipboard = Code.Text.Replace("\n", Environment.NewLine);
            if (textforClipboard != "")
            {
                Clipboard.Clear();
                Clipboard.SetText(textforClipboard);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            int iLigne2;
            int iColonne2;
            DessinBox.Image = DessinBox.InitialImage;
            DessinBox.Refresh();
            for (iColonne2 = 0; iColonne2 < 128; iColonne2++)
            {
                for (iLigne2 = 0; iLigne2 < 64; iLigne2++)
                {
                    ((Bitmap)DessinBox.Image).SetPixel(iColonne2, iLigne2, Color.White);
                }
            }
            DessinBox.Refresh();
            Code.Text = "";
            CodeOpti.Text = "";
            listImage.Items.Clear();
            numberOfFile = 0;
            DessinBox.Enabled = true;
        }

        private void DessinBox_MouseLeave(object sender, EventArgs e)
        {
            //DessinBox.Enabled = false;
        }

        private void Couleur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Couleur.Text=="Blanc")
            {
                couleurDessin = Color.White;
            }
            if (Couleur.Text == "Noir")
            {
                couleurDessin = Color.Black;
            }
        }

        private void Copy_opti_Click(object sender, EventArgs e)
        {
            string textforClipboard = CodeOpti.Text.Replace("\n", Environment.NewLine);
            if (textforClipboard != "")
            {
                Clipboard.Clear();
                Clipboard.SetText(textforClipboard);
            }
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            int compteNumberFile=0;
            //listFileName.Text = "";
            listImage.Items.Clear();
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Multiselect = true;
                dlg.Title = "Open Image 128x64 (Bitmap Monochrome Recommander)";
                dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg)|*.BMP;*.JPG;*.JPEG"; ;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    PictureBox PictureBox1 = new PictureBox();
                    PictureBox1.Image = new Bitmap(dlg.FileName);
                    if ((PictureBox1.Image.Width==128)&&(PictureBox1.Image.Height == 64))
                    {
                        numberOfFile = dlg.FileNames.Length;
                        if (numberOfFile>1)
                        {
                            if(numberOfFile<15)
                            {
                                for (compteNumberFile = 0; compteNumberFile < numberOfFile; compteNumberFile++)
                                {
                                    files[compteNumberFile] = dlg.FileNames[compteNumberFile];
                                    //listFileName.Text += dlg.SafeFisleNames[compteNumberFile] + Environment.NewLine;
                                    listImage.Items.Add(dlg.SafeFileNames[compteNumberFile]);
                                }
                                DessinBox.Image = new Bitmap(files[0]);
                            }
                            else
                            {
                                MessageBox.Show("Veuillez selectionner moins de 15 image");
                            }
                           
                            
                        }
                        else
                        {
                            string ext = Path.GetExtension(dlg.FileName);
                            listImage.Items.Add(dlg.SafeFileName);
                            DessinBox.Image = new Bitmap(dlg.FileName);
                            DessinBox.Refresh();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Mauvais format/dimension");
                    }
                }
            }
        }

        private void ChecknonOpti_CheckedChanged(object sender, EventArgs e)
        {
            if (ChecknonOpti.Checked == true)
            {
                Code.Enabled = true;
            }
            else
            {
                Code.Enabled = false;
            }
            Code.Text = "";
        }

        private void CheckOpti_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckOpti.Checked == true)
            {
                CodeOpti.Enabled = true;
            }
            else
            {
                CodeOpti.Enabled = false;
            }
            CodeOpti.Text = "";
         }

        private void DessinBox_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void InvertColor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listImage_SelectedValueChanged(object sender, EventArgs e)
        {
            if(numberOfFile>1)
            {
                DessinBox.Image = new Bitmap(files[listImage.SelectedIndex]);
                DessinBox.Refresh();
            }
        }
    }
}
