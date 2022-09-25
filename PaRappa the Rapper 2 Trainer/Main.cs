using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;
using System.Configuration;

namespace PaRappa_the_Rapper_2_Trainer
{
    public partial class Main : Form
    {
        public Mem m = new Mem();
        public bool processOpen = false;
        public string region = "pal";
        public int curPage = 1;
        public int pageIndex = 0;
        public int maxPages = 2;
        public Panel[] pagePanels = new Panel[2];
        public bool advancedMode = false;

        public readonly static string INFO_DONE_LOAD = "Everything has loaded correctly! Welcome to the PaRappa the Rapper 2 Trainer!";

        public Main()
        {
            InitializeComponent();

            barLabel.Enabled = true;
            barLabel.Visible = false;
            barPanel.Enabled = true;
            barPanel.Visible = false;

            regionLabel.Text = "Current Region: " + region.ToUpper();

            pageLabel.Text = "Page: " + curPage + "/" + maxPages;

            pagePanels[0] = page1Panel;
            pagePanels[1] = page2Panel;

            foreach (var panel in pagePanels)
            {
                panel.Visible = false;
                panel.Enabled = false;
            }

            pagePanels[0].Visible = true;
            pagePanels[0].Enabled = true;

            customModeBox.Visible = false;
            btnSetCustomMode.Visible = false;

            advancedMode = Properties.Settings.Default.AdvancedMode;
            cbAdvancedMode.Checked = Properties.Settings.Default.AdvancedMode;

            region = Properties.Settings.Default.Region;

            processNameBox.Text = Properties.Settings.Default.PCSX2Name;
            ChangeRegion(true);
            switch (region)
            {
                case "pal":
                    europeRadio.Checked = true;
                    break;
                case "ntsc-u":
                    usaRadio.Checked = true;
                    break;
                case "ntsc-j":
                    japanRadio.Checked = true;
                    break;
            }

            // ShowInfo(INFO_DONE_LOAD);
        }

        private void BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // open process and inject
            processOpen = m.OpenProcess(processNameBox.Text);
            Thread.Sleep(100);
            
            // advanced mode values set before returning
            Thread tAdvanced = new Thread(new ThreadStart(SetAdvancedValues));
            tAdvanced.Start();

            if (!processOpen)
            {
                BGWorker.ReportProgress(0);
                return;
            }

            // real-time score counting
            try
            {
                if (region == "pal")
                    // curScoreLabel.Text = "Current Score: " + m.ReadInt("201898B8");
                    curScoreLabel.Invoke((MethodInvoker)(() => curScoreLabel.Text = "Current Score: " + m.ReadInt("201898B8")));
                else if (region == "ntsc-u")
                    // curScoreLabel.Text = "Current Score: " + m.ReadInt("20189338");
                    curScoreLabel.Invoke((MethodInvoker)(() => curScoreLabel.Text = "Current Score: " + m.ReadInt("20189338")));
                else if (region == "ntsc-j")
                    // curScoreLabel.Text = "Current Score: " + m.ReadInt("2017A638");
                    curScoreLabel.Invoke((MethodInvoker)(() => curScoreLabel.Text = "Current Score: " + m.ReadInt("2017A638")));
            }
            catch (Exception err)
            {
                Console.WriteLine(err.InnerException + ": " + err.Message);
            }

            if (cbPaRappaAI.Checked)
            {
                if (region == "pal")
                    m.WriteMemory("201898A0", "int", "3");
                else if (region == "ntsc-u")
                    m.WriteMemory("20189320", "int", "3");
                else if (region == "ntsc-j")
                    m.WriteMemory("2017A620", "int", "3");
            }
            else
            {
                if (region == "pal")
                    m.WriteMemory("201898A0", "int", "0");
                else if (region == "ntsc-u")
                    m.WriteMemory("20189320", "int", "0");
                else if (region == "ntsc-j")
                    m.WriteMemory("2017A620", "int", "0");
            }
            if (cbTeacherAI.Checked)
            {
                if (region == "pal")
                    m.WriteMemory("20189958", "int", "3");
                else if (region == "ntsc-u")
                    m.WriteMemory("201893D8", "int", "3");
                else if (region == "ntsc-j")
                    m.WriteMemory("2017A6D8", "int", "3");
            }
            else
            {
                if (region == "pal")
                    m.WriteMemory("20189958", "int", "0");
                else if (region == "ntsc-u")
                    m.WriteMemory("201893D8", "int", "0");
                else if (region == "ntsc-j")
                    m.WriteMemory("2017A6D8", "int", "0");
            }

            Thread.Sleep(200);
            BGWorker.ReportProgress(0);
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        private void BGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (processNameBox.Text.ToLower() == "parappa the rapper 2 trainer")
            {
                isProcessOpen.ForeColor = Color.Red;
                isProcessOpen.Text = "Very funny.";
                return;
            }
            
            if (processOpen)
            {
                isProcessOpen.ForeColor = Color.Green;
                isProcessOpen.Text = m.theProc.ProcessName + " (injected)";
            }
            else
            {
                isProcessOpen.ForeColor = Color.Red;
                isProcessOpen.Text = "N/A";
            }
        }

        private void BGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        private void btnSetPoints_Click(object sender, EventArgs e)
        {
            try {
                if (region == "pal")
                    m.WriteMemory("201898B8", "int", pointsBox.Text);
                else if (region == "ntsc-u")
                    m.WriteMemory("20189338", "int", pointsBox.Text);
                else if (region == "ntsc-j")
                    m.WriteMemory("2017A638", "int", pointsBox.Text);
            } catch (Exception err)
            {
                MessageBox.Show("An error occured. Please report this to a developer.\n" + err.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In order to use the Real COOL Mode hack, press the \"Enable\" button and pass a line normally. Then, press the \"Display COOL\" to restore the normal display.");
        }

        private void btnDisplayCOOL_Click(object sender, EventArgs e)
        {
            if (region == "pal")
                m.WriteMemory("2018989C", "int", "0");
            else if (region == "ntsc-u")
                m.WriteMemory("2018931C", "int", "0");
            else if (region == "ntsc-j")
                m.WriteMemory("2017A61C", "int", "0");
        }

        private void btnEnableRealCOOLMode_Click(object sender, EventArgs e)
        {
            if (region == "pal")
                m.WriteMemory("2018989C", "int", "11");
            else if (region == "ntsc-u")
                m.WriteMemory("2018931C", "int", "11");
            else if (region == "ntsc-j")
                m.WriteMemory("2017A61C", "int", "11");
        }

        private void europeRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (!europeRadio.Checked)
                return;
            
            region = "pal";

            Properties.Settings.Default.Region = region;
            Properties.Settings.Default.Save();

            ChangeRegion();
        }

        private void usaRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (!usaRadio.Checked)
                return;

            region = "ntsc-u";

            Properties.Settings.Default.Region = region;
            Properties.Settings.Default.Save();

            ChangeRegion();
        }

        private void japanRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (!japanRadio.Checked)
                return;

            region = "ntsc-j";

            Properties.Settings.Default.Region = region;
            Properties.Settings.Default.Save();

            ChangeRegion();
        }

        private void ChangeRegion(bool skipMessage = false, bool updRadios = false)
        {
            switch (region)
            {
                case "pal":
                    regionLabel.Text = "Current Region: " + region.ToUpper() + " (Europe)";
                    break;
                case "ntsc-u":
                    regionLabel.Text = "Current Region: " + region.ToUpper() + " (USA)";
                    break;
                case "ntsc-j":
                    regionLabel.Text = "Current Region: " + region.ToUpper() + " (Japan)";
                    break;
                default:
                    regionLabel.Text = "Unknown Region!";
                    break;
            }

            if (updRadios)
            {
                if (region == "pal") europeRadio.Checked = true;
                if (region == "ntsc-u") usaRadio.Checked = true;
                if (region == "ntsc-j") japanRadio.Checked = true;
            }

            //if (!skipMessage) ShowInfo($"Changed region to {region.ToUpper()}!");
        }

        private void btnCoolMode_Click(object sender, EventArgs e)
        {
            if (region == "pal")
                m.WriteMemory("2018989C", "int", "0");
            else if (region == "ntsc-u")
                m.WriteMemory("2018931C", "int", "0");
            else if (region == "ntsc-j")
                m.WriteMemory("2017A61C", "int", "0");
        }

        private void btnGoodMode_Click(object sender, EventArgs e)
        {
            if (region == "pal")
                m.WriteMemory("2018989C", "int", "3");
            else if (region == "ntsc-u")
                m.WriteMemory("2018931C", "int", "3");
            else if (region == "ntsc-j")
                m.WriteMemory("2017A61C", "int", "3");
        }

        private void btnBadMode_Click(object sender, EventArgs e)
        {
            if (region == "pal")
                m.WriteMemory("2018989C", "int", "6");
            else if (region == "ntsc-u")
                m.WriteMemory("2018931C", "int", "6");
            else if (region == "ntsc-j")
                m.WriteMemory("2017A61C", "int", "6");
        }

        private void btnAwfulMode_Click(object sender, EventArgs e)
        {
            if (region == "pal")
                m.WriteMemory("2018989C", "int", "9");
            else if (region == "ntsc-u")
                m.WriteMemory("2018931C", "int", "9");
            else if (region == "ntsc-j")
                m.WriteMemory("2017A61C", "int", "9");
        }

        public void NextPage()
        {
            curPage++;

            if (curPage > maxPages)
                curPage = 1;

            pageIndex = curPage - 1;

            foreach (Panel panel in pagePanels)
            {
                panel.Enabled = false;
                panel.Visible = false;
            }

            pagePanels[pageIndex].Enabled = true;
            pagePanels[pageIndex].Visible = true;

            pageLabel.Text = "Page: " + curPage + "/" + maxPages;
        }

        private void NextPageBTN(object sender, EventArgs e)
        {
            NextPage();
        }

        public void SetDifficulty()
        {
            if (region == "pal")
                m.WriteMemory("20189BA4", "int", diffNumber.Value.ToString());
            else if (region == "ntsc-u")
                m.WriteMemory("20189624", "int", diffNumber.Value.ToString());
            else if (region == "ntsc-j")
                m.WriteMemory("2017A924", "int", diffNumber.Value.ToString());
        }

        private void SetDifficultyBTN(object sender, EventArgs e)
        {
            SetDifficulty();
        }

        private void cbAdvancedMode_CheckedChanged(object sender, EventArgs e)
        {
            // uncomment this to show a warning when turning on
            // MessageBox.Show("This feature is really unsafe! Please only enable it if you know what you're doing.", "Advanced Mode", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            advancedMode = cbAdvancedMode.Checked;
            Properties.Settings.Default.AdvancedMode = cbAdvancedMode.Checked;
            Properties.Settings.Default.Save();
        }

        private void btnSetCustomMode_Click(object sender, EventArgs e)
        {
            if (region == "pal")
                m.WriteMemory("2018989C", "int", customModeBox.Text);
            else if (region == "ntsc-u")
                m.WriteMemory("2018931C", "int", customModeBox.Text);
            else if (region == "ntsc-j")
                m.WriteMemory("2017A61C", "int", customModeBox.Text);
        }

        private string ConvertToYesNo(bool trueOrFalse)
        {
            return trueOrFalse ? "y" : "n";
        }

        public void SetAdvancedValues()
        {
            try
            {
                if (advancedMode)
                {
                    pointsBox.Invoke((MethodInvoker)(() => pointsBox.MaxLength = 32767));
                    // customModeBox.Visible = true;
                    customModeBox.Invoke((MethodInvoker)(() => customModeBox.Visible = true));
                    // btnSetCustomMode.Visible = true;
                    btnSetCustomMode.Invoke((MethodInvoker)(() => btnSetCustomMode.Visible = true));
                    // diffNumber.Maximum = 32767
                    diffNumber.Invoke((MethodInvoker)(() => diffNumber.Maximum = 32767));
                    // processNameBox.Visible = true
                    processNameBox.Invoke((MethodInvoker)(() => processNameBox.Visible = true));
                }
                else
                {
                    pointsBox.Invoke((MethodInvoker)(() => pointsBox.MaxLength = 5));
                    // customModeBox.Visible = false;
                    customModeBox.Invoke((MethodInvoker)(() => customModeBox.Visible = false));
                    // btnSetCustomMode.Visible = false;
                    btnSetCustomMode.Invoke((MethodInvoker)(() => btnSetCustomMode.Visible = false));
                    // diffNumber.Maximum = 16
                    diffNumber.Invoke((MethodInvoker)(() => diffNumber.Maximum = 16));
                    // processNameBox.Visible = true
                    processNameBox.Invoke((MethodInvoker)(() => processNameBox.Visible = false));
                }
            }
            catch(Exception err)
            {
                Console.WriteLine(err.InnerException + ": " + err.Message);
            }
        }

        private void btnSetLesson_Click(object sender, EventArgs e)
        {
            if (region == "pal")
                m.WriteMemory("21C50692", "int", "2");
            else if (region == "ntsc-u")
                m.WriteMemory("201895FC", "int", "2");
            else if (region == "ntsc-j")
                m.WriteMemory("2017A8FC", "int", "2");
        }

        private void btnUnfreeze_Click(object sender, EventArgs e)
        {
            if (region == "pal")
                m.WriteMemory("21C50692", "int", "0");
            else if (region == "ntsc-u")
                m.WriteMemory("201895FC", "int", "0");
            else if (region == "ntsc-j")
                m.WriteMemory("2017A8FC", "int", "0");
        }

        private void processNameBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PCSX2Name = processNameBox.Text;

            Properties.Settings.Default.Save();
        }

        public void ShowInfo(string info)
        {
            barPanel.BackColor = Color.Blue;
            ShowBarLabel(info);
        }

        public void ShowError(string info)
        {
            barPanel.BackColor = Color.Red;
            ShowBarLabel(info);
        }

        public void ShowWarning(string info)
        {
            barPanel.BackColor = Color.Gold;
            ShowBarLabel(info);
        }

        private async void ShowBarLabel(string text)
        {
            barLabel.Invoke((MethodInvoker)(() => barLabel.Text = text));
            barLabel.Enabled = true;
            barLabel.Visible = true;
            barPanel.Enabled = true;
            barPanel.Visible = true;

            await Task.Delay(5000);

            barLabel.Text = "Welcome to the PTR2 Trainer!";
            barLabel.Visible = false;
            barPanel.Visible = false;
        }

        private void DetectRegion(object sender, EventArgs e)
        {
            // pcsx2.exe+2C797BB
            var reg = m.ReadString($"{processNameBox.Text}.exe+2C797BB", "", 3);
            ShowInfo("Automatic check succeeded!");
            region = (reg == "NTS" ? reg + "c-u" : reg).ToLower();
            ChangeRegion(true, true);
        }
    }
}
