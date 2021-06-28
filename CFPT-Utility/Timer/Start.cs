using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Runtime.InteropServices;


namespace Timer
{

    public partial class Start : Form
    {
        delegate void AddMessage(string message);
        bool FlagMyMessage=false;
        bool HorsLigne = true;
        int port = 54545;
        const string broadcastAddress = "255.255.255.255";
        string oldUserName;

        UdpClient receivingClient;
        UdpClient sendingClient;

        Thread receivingThread;

        public Start()
        {
            InitializeComponent();
            //ValPort.Value = 54545;
            ValPort.Enabled = false;
            //InitializeSender();
            //InitializeReceiver();
            UserName.Text = Environment.UserName;
            oldUserName=UserName.Text;
            UserName.Enabled = false;
            MessageText.Select();
        }
        public static class FlashWindow
        {
            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            private static extern bool FlashWindowEx(ref FLASHWINFO pwfi);

            [StructLayout(LayoutKind.Sequential)]
            private struct FLASHWINFO
            {
                /// <summary>
                /// The size of the structure in bytes.
                /// </summary>
                public uint cbSize;
                /// <summary>
                /// A Handle to the Window to be Flashed. The window can be either opened or minimized.
                /// </summary>
                public IntPtr hwnd;
                /// <summary>
                /// The Flash Status.
                /// </summary>
                public uint dwFlags;
                /// <summary>
                /// The number of times to Flash the window.
                /// </summary>
                public uint uCount;
                /// <summary>
                /// The rate at which the Window is to be flashed, in milliseconds. If Zero, the function uses the default cursor blink rate.
                /// </summary>
                public uint dwTimeout;
            }

            /// <summary>
            /// Stop flashing. The system restores the window to its original stae.
            /// </summary>
            public const uint FLASHW_STOP = 0;

            /// <summary>
            /// Flash the window caption.
            /// </summary>
            public const uint FLASHW_CAPTION = 1;

            /// <summary>
            /// Flash the taskbar button.
            /// </summary>
            public const uint FLASHW_TRAY = 2;

            /// <summary>
            /// Flash both the window caption and taskbar button.
            /// This is equivalent to setting the FLASHW_CAPTION | FLASHW_TRAY flags.
            /// </summary>
            public const uint FLASHW_ALL = 3;

            /// <summary>
            /// Flash continuously, until the FLASHW_STOP flag is set.
            /// </summary>
            public const uint FLASHW_TIMER = 4;

            /// <summary>
            /// Flash continuously until the window comes to the foreground.
            /// </summary>
            public const uint FLASHW_TIMERNOFG = 12;


            /// <summary>
            /// Flash the spacified Window (Form) until it recieves focus.
            /// </summary>
            /// <param name="form">The Form (Window) to Flash.</param>
            /// <returns></returns>
            public static bool Flash(System.Windows.Forms.Form form)
            {
                // Make sure we're running under Windows 2000 or later
                if (Win2000OrLater)
                {
                    FLASHWINFO fi = Create_FLASHWINFO(form.Handle, FLASHW_ALL | FLASHW_TIMERNOFG, uint.MaxValue, 0);
                    return FlashWindowEx(ref fi);
                }
                return false;
            }

            private static FLASHWINFO Create_FLASHWINFO(IntPtr handle, uint flags, uint count, uint timeout)
            {
                FLASHWINFO fi = new FLASHWINFO();
                fi.cbSize = Convert.ToUInt32(Marshal.SizeOf(fi));
                fi.hwnd = handle;
                fi.dwFlags = flags;
                fi.uCount = count;
                fi.dwTimeout = timeout;
                return fi;
            }

            /// <summary>
            /// Flash the specified Window (form) for the specified number of times
            /// </summary>
            /// <param name="form">The Form (Window) to Flash.</param>
            /// <param name="count">The number of times to Flash.</param>
            /// <returns></returns>
            public static bool Flash(System.Windows.Forms.Form form, uint count)
            {
                if (Win2000OrLater)
                {
                    FLASHWINFO fi = Create_FLASHWINFO(form.Handle, FLASHW_ALL, count, 0);
                    return FlashWindowEx(ref fi);
                }
                return false;
            }

            /// <summary>
            /// Start Flashing the specified Window (form)
            /// </summary>
            /// <param name="form">The Form (Window) to Flash.</param>
            /// <returns></returns>
            public static bool Start(System.Windows.Forms.Form form)
            {
                if (Win2000OrLater)
                {
                    FLASHWINFO fi = Create_FLASHWINFO(form.Handle, FLASHW_ALL, uint.MaxValue, 0);
                    return FlashWindowEx(ref fi);
                }
                return false;
            }

            /// <summary>
            /// Stop Flashing the specified Window (form)
            /// </summary>
            /// <param name="form"></param>
            /// <returns></returns>
            public static bool Stop(System.Windows.Forms.Form form)
            {
                if (Win2000OrLater)
                {
                    FLASHWINFO fi = Create_FLASHWINFO(form.Handle, FLASHW_STOP, uint.MaxValue, 0);
                    return FlashWindowEx(ref fi);
                }
                return false;
            }

            /// <summary>
            /// A boolean value indicating whether the application is running on Windows 2000 or later.
            /// </summary>
            private static bool Win2000OrLater
            {
                get { return System.Environment.OSVersion.Version.Major >= 5; }
            }
        }

        private void InitializeSender()
        {
            sendingClient = new UdpClient(broadcastAddress, port);
            sendingClient.EnableBroadcast = true;
        }

        private void InitializeReceiver()
        {
            try
            {
                receivingClient = new UdpClient(port);
                ThreadStart start = new ThreadStart(Receiver);
                receivingThread = new Thread(start);
                receivingThread.IsBackground = true;
                receivingThread.Start();
            }
            catch
            {
                MessageBox.Show("Erreur de reseau");
            }
            
        }

        private void Receiver()
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, port);
            AddMessage messageDelegate = MessageReceived;

            while (true)
            {
                byte[] data = receivingClient.Receive(ref endPoint);
                string message = Encoding.UTF32.GetString(data);
                Invoke(messageDelegate, message);
            }
        }

        private void MessageReceived(string message)
        {
            WindowMessage.Text += message + "\n";
            //listViewMessage.Items.Add(message);
            if(FlagMyMessage==false)
            {
                FlashWindow.Flash(this);
            }
            FlagMyMessage = false;
            //listBoxMessage.Selection
            WindowMessage.SelectionStart = WindowMessage.Text.Length;
            WindowMessage.ScrollToCaret();
        }


        private void timerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Tempo_Timer TempoTimer;
            TempoTimer = new Tempo_Timer();
            TempoTimer.Show();
        }

        private void interruptionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Interruption_Form InterruptionForm;
            InterruptionForm = new Interruption_Form();
            InterruptionForm.Show();
        }

        private void infoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Info_Form InfoForm;
            InfoForm = new Info_Form();
            InfoForm.Show();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            using (StartConfig startConfig = new StartConfig())
            {
                if (startConfig.ShowDialog() == DialogResult.OK)
                {
                    HorsLigne = startConfig.HorsLigne;
                }
                else
                {
                    this.Close();
                }
            }
            if (HorsLigne == false)
            {
                InitializeSender();
                InitializeReceiver();
                byte[] data_welcome = Encoding.UTF32.GetBytes(UserName.Text + " A rejoint");
                sendingClient.Send(data_welcome, data_welcome.Length);
                
            }
            else
            {
                Send.Enabled = false;
                MessageText.Enabled = false;
            }
        }

        private void Send_Click(object sender, EventArgs e)
        {
            if(MessageText.Text=="&42&")
            {
                if(UserName.Enabled==true)
                {
                    UserName.Enabled = false;
                    ValPort.Enabled = false;
                }
                else
                {
                    UserName.Enabled = true;
                    ValPort.Enabled = true;
                }
                MessageText.Text = "";
            }
            //if(MessageText.Text=="&43&")
            //{
            //    Start Start_Window;
            //    Start_Window = new Start();
            //    Start_Window.Show();
            //}
            if (!string.IsNullOrEmpty(MessageText.Text))
            {
                string toSend = UserName.Text + ">>> " + MessageText.Text;
                byte[] data = Encoding.UTF32.GetBytes(toSend);
                try
                {
                    sendingClient.Send(data, data.Length);
                    FlagMyMessage = true;
                }
                catch
                {
                    MessageBox.Show("Trop de caractere");
                }
                MessageText.Text = "";
            }
            MessageText.Focus();
            WindowMessage.SelectionStart = WindowMessage.Text.Length;
            WindowMessage.ScrollToCaret();
        }

        private void MessageText_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ValPort_ValueChanged(object sender, EventArgs e)
        {
            //port = Convert.ToInt32(ValPort.Value);
            //InitializeSender();
            //InitializeReceiver();
            if (HorsLigne == false)
            {
                receivingThread.Abort();
                receivingClient.Close();
                sendingClient.Close();

                sendingClient = new UdpClient(broadcastAddress, Convert.ToInt32(ValPort.Value));
                sendingClient.EnableBroadcast = true;
                receivingClient = new UdpClient(Convert.ToInt32(ValPort.Value));

                ThreadStart start = new ThreadStart(Receiver);
                receivingThread = new Thread(start);
                receivingThread.IsBackground = true;
                receivingThread.Start();
                byte[] data_welcomePort = Encoding.UTF32.GetBytes(UserName.Text + " A rejoint");
                sendingClient.Send(data_welcomePort, data_welcomePort.Length);
            }
        }
        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (HorsLigne == false)
            {
                string toSend = UserName.Text + " A Quitter";
                byte[] data = Encoding.UTF32.GetBytes(toSend);
                sendingClient.Send(data, data.Length);
                receivingThread.Abort();
                receivingClient.Close();
                sendingClient.Close();
            }
        }

        private void UserName_Leave(object sender, EventArgs e)
        {
            string toSend = oldUserName + " Est devenu "+UserName.Text;
            byte[] data = Encoding.UTF32.GetBytes(toSend);
            sendingClient.Send(data, data.Length);
            oldUserName = UserName.Text;
        }

        private void lCDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dessin.LCD_DOG LCDDOG;
            LCDDOG = new Dessin.LCD_DOG();
            LCDDOG.Show();
        }

        private void WindowMessage_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void generateurDeTableauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableGenerator formTableGenerator;
            formTableGenerator = new TableGenerator();
            formTableGenerator.Show();
        }

        private void aDCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CFPT_Utility.ADC FormADC = new CFPT_Utility.ADC();
            FormADC.Show();
        }

        private void modelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CFPT_Utility.Model FormModel = new CFPT_Utility.Model();
            FormModel.Show();
        }
    }
}
