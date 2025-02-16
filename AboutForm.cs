/**
 * (c) 2025 theonlyasdk
 * About form for this application.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Task_Dialog_Generator
{
    public partial class AboutForm : Form
    {
        public static Dictionary<string, string> CONTRIBUTORS = new Dictionary<string, string>
        {
            { "ThioJoe - Author", "https://github.com/ThioJoe" },
            { "Segilmez06", "https://github.com/Segilmez06" },
            { "theonlyasdk", "https://github.com/theonlyasdk" },
        };

        public static string GITHUB_REPO = "https://github.com/ThioJoe/Modern-Windows-Message-Box-Generator";

        public AboutForm()
        {
            InitializeComponent();

            lblVersion.Text = "Version: " + DetermineVersion();

            foreach (var contributor in CONTRIBUTORS)
            {
                lbCredits.Items.Add(contributor.Key);
            }

            // Open the contributor's GitHub page when the item is clicked
            lbCredits.Click += (sender, e) =>
            {
                if (lbCredits.SelectedItem != null)
                {
                    string? contributor = lbCredits.SelectedItem?.ToString();
                    if (contributor != null && CONTRIBUTORS.TryGetValue(contributor, out string? value))
                    {
                        // enclose in try catch to prevent crashes
                        try
                        {
                            System.Diagnostics.Process.Start(value);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed to open the link: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            };
        }

        private static string DetermineVersion()
        {
            string version = Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "Unknown Version";

            // If the last digit is zero, remove it
            if (version.EndsWith(".0"))
            {
                version = version.Substring(0, version.Length - 2);
            }

            return version;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(GITHUB_REPO);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open the link: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}