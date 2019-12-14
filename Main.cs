using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace OCE
{
    public partial class Main : Form
    {
        #region Variables
        public string work = "work";
        private int counter = 0;
        private static readonly PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        private static readonly PerformanceCounter ramCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");
        #endregion
        public Main()
        {
            InitializeComponent();
        }
        private void ProgramSelection_Load(object sender, EventArgs e)
        {
            try
            {
                cpuTim.Start();

            }
            catch (Exception ex)
            {
                Error err = new Error("Couldn't get CPU stats", ex.ToString());
                err.ShowDialog();
            }
            try
            {
                ramTim.Start();

            }
            catch (Exception ex)
            {
                Error err = new Error("Couldn't get RAM stats", ex.ToString());
                err.ShowDialog();
            }
            try
            {
                data.Start();

            }
            catch (Exception ex)
            {
                Error err = new Error("Couldn't get time", ex.ToString());
                err.ShowDialog();
            }
            try
            {
                if (counter == 0)
                {
                    counter++;
                    DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs");
                    FileInfo[] Files = directoryInfo.GetFiles();
                    foreach (FileInfo file in Files)
                    {
                        if (file.ToString() != "desktop.ini")
                        {
                            string tmp = file.ToString();
                            tmp = tmp.Replace(".lnk", "");
                            tmp = tmp.Replace(".url", "");
                            Console.WriteLine(file + "  " + tmp);
                            programs.Items.Add(tmp);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                programs.Items.Add("No programs!");
                Error err = new Error(@"Couldn't get progam list from C:\ProgramData\Microsoft\Windows\Start Menu\Programs", ex.ToString());
                err.ShowDialog();
            }
        }
        private void Runprogram(object sender, MouseEventArgs e)
        {
            string tmp = programs.SelectedItem.ToString();
            Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\" + tmp);
        }
        private void Shutdown_Click(object sender, EventArgs e)
        {
            var shutdown = new ProcessStartInfo("shutdown", "/s /t 0")
            {
                CreateNoWindow = true,
                UseShellExecute = false
            };
            Process.Start(shutdown);
        }
        private void Reboot_Click(object sender, EventArgs e)
        {
            var shutdown = new ProcessStartInfo("shutdown", "/r /t 0")
            {
                CreateNoWindow = true,
                UseShellExecute = false
            };
            Process.Start(shutdown);
        }
        private void SetDate(string date)
        {
            datatest.Text = date;
        }
        private void CpuTim_Tick(object sender, EventArgs e)
        {
            float fcpu = cpuCounter.NextValue();
            if (Convert.ToInt32(fcpu) < 30)
            {
                cpuPB.ForeColor = Color.LimeGreen;
            }
            if (Convert.ToInt32(fcpu) > 30 && Convert.ToInt32(fcpu) < 40)
            {
                cpuPB.ForeColor = Color.GreenYellow;
            }
            if (Convert.ToInt32(fcpu) > 40 && Convert.ToInt32(fcpu) < 70)
            {
                cpuPB.ForeColor = Color.Yellow;
            }
            if (Convert.ToInt32(fcpu) > 70 && Convert.ToInt32(fcpu) < 100)
            {
                cpuPB.ForeColor = Color.Red;
            }
            cpuPB.Value = Convert.ToInt32(fcpu) / 2;
        }
        private void RamTim_Tick(object sender, EventArgs e)
        {
            float fram = ramCounter.NextValue();
            string tmpRam = fram.ToString();
            tmpRam = tmpRam.Remove(tmpRam.IndexOf(','));
            ramPercentage.Text = tmpRam + "%";
            if (Convert.ToInt32(fram) < 30)
            {
                ramPB.ForeColor = Color.LimeGreen;
            }
            if (Convert.ToInt32(fram) > 30 && Convert.ToInt32(fram) < 40)
            {
                ramPB.ForeColor = Color.GreenYellow;
            }
            if (Convert.ToInt32(fram) > 40 && Convert.ToInt32(fram) < 70)
            {
                ramPB.ForeColor = Color.Yellow;
            }
            if (Convert.ToInt32(fram) > 70 && Convert.ToInt32(fram) < 100)
            {
                ramPB.ForeColor = Color.Red;
            }
            ramPB.Value = Convert.ToInt32(fram);
        }
        private void Data_Tick(object sender, EventArgs e)
        {
            string dataS = DateTime.Now.ToString("MMMM dd");
            SetDate(dataS);
            string ora = DateTime.Now.ToString("HH");
            h.Text = ora;
            string minS = DateTime.Now.ToString("mm");
            min.Text = minS;
        }
        #region Buttons
        private void ExBTN_Click(object sender, EventArgs e)
        {
            Process.Start("explorer");
        }
        private void CmdBTN_Click(object sender, EventArgs e)
        {
            Process.Start("cmd");
        }
        private void PanelBTN_Click(object sender, EventArgs e)
        {
            Process.Start("control");
        }
        private void Website_Click(object sender, EventArgs e)
        {
            Process.Start("https://marcoceccon.github.io/");
        }
        #endregion
    }
}