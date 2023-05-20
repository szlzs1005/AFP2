using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class ScannerForm : Form
    {
        RestClient client = null;
        RestRequest request = null;
        RestResponse<List<Hash>> response = null;
        string fileName = null;
        public ScannerForm()
        {
            InitializeComponent();
        }

    public string GetMD5FromFile(string filePath)
        {
            using (var md5 = MD5.Create()) 
            { 
                using (var stream = File.OpenRead(filePath)) 
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-",string.Empty).ToLower();
                }
            }
        }

    private void btnScan_Click(object sender, EventArgs e)
        {
            if (tbFilePath.Text == "" || tbMD5.Text == "")
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Please select a file";
                return;
            }
            try
            {
                client = new RestClient("http://localhost:3001/hash/read");
                request = new RestRequest();
                request.Method = Method.Get;
                response = client.Execute<List<Hash>>(request);
                bool infected = false;
                foreach (Hash hash in response.Data)
                {
                    if (hash.value == tbMD5.Text)
                    {
                        infected = true;
                        break;
                    }
                }
                if (infected)
                {
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = "infected";
                    if (MessageBox.Show("Do you want to move the file?", "Infected file", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string path = @tbFilePath.Text;
                        string path2 = @"C:\Users\zsolt\OneDrive\Asztali gép\Egyetem\4. félév\afp2\client\client\infectedFiles\" + fileName;
                        try
                        {
                            File.Move(path, path2);
                            MessageBox.Show(fileName + " moved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbFilePath.Text = "";
                            tbMD5.Text = "";
                            lblStatus.ForeColor = Color.Black;
                            lblStatus.Text = "Status:N/A";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    lblStatus.ForeColor = Color.Green;
                    lblStatus.Text = "clean";
                }
            }
            catch
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Something went wrong";
            }
            
        }
    }
}
