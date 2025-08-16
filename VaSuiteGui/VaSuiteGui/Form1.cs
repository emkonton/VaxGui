using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace VaSuiteGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ipadusin_TextChanged(object sender, EventArgs e)
        {
           

           

        }




        private async void gialsb_Click(object sender, EventArgs e)
        {
            string ip = ipadusin.Text.Trim();
            if (string.IsNullOrEmpty(ip))
            {
                MessageBox.Show("Lütfen geçerli bir IP adresi girin.");
                return;
            }

            try
            {
                rtbOutput.Text = "Sorgulanıyor...";

                var output = await Task.Run(() =>
                {
                    Process p = new Process();
                    p.StartInfo.FileName = "python";
                    p.StartInfo.Arguments = $"ipinfo.py {ip}";
                    p.StartInfo.WorkingDirectory = @"C:\Users\pc\source\repos\VaSuiteGui\VaSuiteGui\pythonScripts";
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.RedirectStandardError = true;
                    p.StartInfo.CreateNoWindow = true;
                    p.Start();

                    string stdOutput = p.StandardOutput.ReadToEnd();
                    string stdError = p.StandardError.ReadToEnd();
                    p.WaitForExit();

                    return string.IsNullOrEmpty(stdError) ? stdOutput : stdError;
                });

                rtbOutput.Text = output;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
        

        private void rtbOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void osint_Click(object sender, EventArgs e)
        {

        }


        private async void SoicalScanBut_Click(object sender, EventArgs e)
        {
            string username = usernamebox.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Lütfen geçerli bir kullanıcı adı girin.");
                return;
            }

            try
            {
                rtbOutput.Text = "Sorgulanıyor...";
                rtbOutput.ForeColor = Color.Black;  // Varsayılan renk

                string scriptDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pythonScripts");
                string scriptPath = Path.Combine(scriptDir, "username_checker.py");

                string jsonOutput = await Task.Run(() =>
                {
                    Process p = new Process();
                    p.StartInfo.FileName = "python";  // Python PATH'te değilse tam yolu ver (ör: @"C:\Python39\python.exe")
                    p.StartInfo.Arguments = $"\"{scriptPath}\" \"{username}\"";
                    p.StartInfo.WorkingDirectory = scriptDir;
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.RedirectStandardError = true;
                    p.StartInfo.CreateNoWindow = true;
                    p.Start();

                    string output = p.StandardOutput.ReadToEnd();
                    string error = p.StandardError.ReadToEnd();
                    p.WaitForExit();

                    return string.IsNullOrEmpty(error) ? output : error;
                });

                // JSON çıktıyı parse et
                dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonOutput);
                rtbOutput.Clear();

                // Bulunanlar
                rtbOutput.SelectionColor = Color.Green;
                rtbOutput.AppendText("----- BULUNAN HESAPLAR -----\n");
                foreach (var site in result.found)
                {
                    rtbOutput.SelectionColor = Color.Blue;
                    rtbOutput.AppendText($"{site.name}: ");
                    rtbOutput.SelectionColor = Color.DarkBlue;
                    rtbOutput.AppendText($"{site.url}\n");
                }

                // Bulunamayanlar
                rtbOutput.SelectionColor = Color.Red;
                rtbOutput.AppendText("\n----- BULUNAMADANLAR -----\n");
                foreach (var site in result.not_found)
                {
                    rtbOutput.AppendText($"{site}\n");
                }

                // Hatalar
                if (result.errors.Count > 0)
                {
                    rtbOutput.SelectionColor = Color.Orange;
                    rtbOutput.AppendText("\n----- HATALAR -----\n");
                    foreach (var error in result.errors)
                    {
                        rtbOutput.AppendText($"{error}\n");
                    }
                }

                // Linkleri tıklanabilir yap
                rtbOutput.DetectUrls = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void checkBoxViewS_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxViewS.Checked)
            {
                checkBoxViewS.ForeColor = Color.LightGreen;


                MessageBox.Show("Destek üzerinde çalışılıyor.");
            }
            else
            {
                checkBoxViewS.ForeColor  = Color.Red;
            }
    }

        private void button1_Click(object sender, EventArgs e)
        {
            aform afrm = new aform();

            afrm.Show();
            this.Hide();

            
        }
    }
}


