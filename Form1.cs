using System.Runtime.InteropServices;

namespace AutoKey
{
    public partial class Form1 : Form
    {
        const int mActionHotKeyID = 1;
        bool activeSpam = false;

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        // Activate an application window.
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        public Form1()
        {
            InitializeComponent();

            RegisterHotKey(Handle, mActionHotKeyID, 0, (int)Keys.F9);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            activeSpam = !activeSpam;
            await Spam(int.Parse(textBox3.Text));
        }

        private Task Spam(int delay)
        {
            for (int i = 0; i < int.Parse(textBox2.Text); i++)
            {
                Thread.Sleep(delay);

                SendKeys.Send(textBox1.Text);
                SendKeys.Send("{ENTER}");
            }

            return Task.CompletedTask;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == mActionHotKeyID)
            {
                button1_Click(this, new EventArgs());
            }
            base.WndProc(ref m);
        }

    }
}
