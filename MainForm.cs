using System;
using System.Windows.Forms;

using System.Diagnostics;
using System.Reflection;
using nManager.Helpful;

// ReSharper disable once CheckNamespace
public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // adds plugin version number to title
            DisplayVersionInTitle();
        }

        // used by plugin to show remote control version in title
        private void DisplayVersionInTitle()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            Text += $" - v{fvi.FileMajorPart}.{fvi.FileMinorPart}.{fvi.FileBuildPart}";
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Logging.WritePluginDebug("Logged out", "[Remote Control]");
            // logout
            AuthService.Auth = null;
            Settings.Authed = false;
            // finish logging out

            Hide();
            LoginForm LoginForm = new LoginForm();
            LoginForm.Show();
            Logging.WritePluginDebug("Login form shown", "[Remote Control]");
        }

        private void DiedCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Notify.Died = DiedCheckbox.Checked;
            Logging.WritePluginDebug("Notify on death: " + Notify.Died, "[Remote Control]");
        }

        private void DeathsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Notify.Deaths = DeathsCheckbox.Checked;
            Logging.WritePluginDebug("Notify on deaths: " + Notify.Deaths, "[Remote Control]");
        }

        private void FreeBagSlotsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Notify.BagSlots = FreeBagSlotsCheckbox.Checked;
            Logging.WritePluginDebug("Notify on bag slots: " + Notify.BagSlots, "[Remote Control]");
        }

        private void LatencyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Notify.Latency = LatencyCheckbox.Checked;
            Logging.WritePluginDebug("Notify on latency: " + Notify.Latency, "[Remote Control]");
        }

        private void StuckCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Notify.Stucks = StuckCheckbox.Checked;
            Logging.WritePluginDebug("Notify on stucks: " + Notify.Stucks, "[Remote Control]");
        }

        private void HealthPercentCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Notify.HealthPercent = HealthPercentCheckbox.Checked;
            Logging.WritePluginDebug("Notify on health percent: " + Notify.HealthPercent, "[Remote Control]");
        }

        private void DeathsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Notify.DeathsCount = Convert.ToInt32(DeathsNumericUpDown.Value);
            Logging.WritePluginDebug("Notify on deaths: " + Notify.DeathsCount, "[Remote Control]");
        }

        private void FreeBagSlotsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Notify.BagSlotsCount = Convert.ToInt32(FreeBagSlotsNumericUpDown.Value);
            Logging.WritePluginDebug("Notify on bag slots: " + Notify.BagSlotsCount, "[Remote Control]");
        }

        private void LatencyNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Notify.LatencyCount = Convert.ToInt32(LatencyNumericUpDown.Value);
            Logging.WritePluginDebug("Notify on latency: " + Notify.LatencyCount, "[Remote Control]");
        }

        private void StuckNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Notify.StucksCount = Convert.ToInt32(StuckNumericUpDown.Value);
            Logging.WritePluginDebug("Notify on stucks: " + Notify.StucksCount, "[Remote Control]");
        }

        private void HealthPercentTrackBar_Scroll(object sender, EventArgs e)
        {
            Notify.HealthPercentCount = Convert.ToInt32(HealthPercentTrackBar.Value);
            // Logging.WritePluginDebug("Notify on health percent: " + Notify.HealthPercentCount, "[Remote Control]");
            // this log causes spam
        }
    }

