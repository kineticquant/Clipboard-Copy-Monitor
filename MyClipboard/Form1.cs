using System.IO;
using System.Runtime.InteropServices;

namespace MyClipboard
{
    public partial class Form1 : Form
    {
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);

        private const int WM_DRAWCLIPBOARD = 0x0308; // Message
        private IntPtr _clipboardViewerNext;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _clipboardViewerNext = SetClipboardViewer(this.Handle);
            label1.Text = "Loading";
            richTextBox1.Clear();
            var dir = @"C:\MyClipboard\";
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            if (Directory.Exists(dir))
                label1.Text = "Autosave Enabled";

        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_DRAWCLIPBOARD)
            {
                IDataObject iData = Clipboard.GetDataObject(); // CB Data

                if (iData.GetDataPresent(DataFormats.Text))
                {
                    var dir = @"C:\MyClipboard\";
                    string text = (string)iData.GetData(DataFormats.Text);
                    richTextBox1.AppendText(String.Format(Environment.NewLine + " "));
                    //richTextBox1.AppendText(String.Format(Environment.NewLine + "--------"));
                    richTextBox1.AppendText(String.Format(Environment.NewLine + "Time: " + DateTime.Now.ToString()) + ": ");
                    //richTextBox1.AppendText(String.Format(Environment.NewLine + " "));
                    richTextBox1.AppendText(Environment.NewLine + text);
                    //richTextBox1.AppendText(String.Format(Environment.NewLine + " "));
                    //richTextBox1.AppendText(String.Format(Environment.NewLine + "--------"));
                    //richTextBox1.AppendText(String.Format(Environment.NewLine + " "));
                    //System.IO.File.WriteAllText(@"C:\PIFLogger\logger.txt", richTextBox1.Text);
                    if (Directory.Exists(dir))
                        //System.IO.File.WriteAllText(@"C:\MyClipboard\log.txt", text);
                        //System.IO.File.AppendText(@"C:\MyClipboard\log.txt", text);
                        using (StreamWriter sw = File.AppendText(dir + "log.txt"))
                        {
                            sw.WriteLine("Time:" + DateTime.Now.ToString() + ": ");
                            sw.WriteLine(text);
                        }
                    label1.Text = "Autosaved";

                    richTextBox1.SelectionStart = richTextBox1.Text.Length;
                    richTextBox1.ScrollToCaret();


                }
                else if (iData.GetDataPresent(DataFormats.Bitmap))
                {
                    Bitmap image = (Bitmap)iData.GetData(DataFormats.Bitmap); // Images
                    //pictureBox1 = new PictureBox();
                    //pictureBox1.Image = image;
                    this.pictureBox1.Image = (Bitmap)Clipboard.GetDataObject().GetData(DataFormats.Bitmap);
                }

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChangeClipboardChain(this.Handle, _clipboardViewerNext);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            Environment.Exit(0);
            return;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to clear the textbox and image box?", "Warning - Loss of data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                richTextBox1.Clear();
                pictureBox1.Image = null;
            }
            else if (dialogResult == DialogResult.No)
            {
                //
            }
            //richTextBox1.Clear();
            //pictureBox1.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to clear the textbox and image box?", "Warning - Loss of data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                richTextBox1.Clear();
                pictureBox1.Image = null;
            }
            else if (dialogResult == DialogResult.No)
            {
                //
            }
            //richTextBox1.Clear();
            //pictureBox1.Image = null;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Captures text & images from clipboard."
                + Environment.NewLine + "Developed by Michael Mooney"
                + Environment.NewLine + ""
                + Environment.NewLine + "Version 23.09.14.a.2", "Clipboard Monitoring Tool", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}