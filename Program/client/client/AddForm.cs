using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class AddForm : Form
    {
        RestClient client = null;
        RestRequest request = null;
        RestResponse response = null;
        Response res = null;
        public AddForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void openScannerFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScannerForm scanForm = new ScannerForm();
            scanForm.Show();
        }
        //!Regex.IsMatch(input, "^[a - zA - Z0 - 9] +$")
        private void btnSend_Click(object sender, EventArgs e)
        {
            string input = tbHashValue.Text;
            string failMessage = "Addition failed";
            string successMessage = "Success";
            if (!Regex.IsMatch(input, "^[a-zA-Z0-9]+$") || input.Length != 32 || input == "")
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = failMessage;
            }
            else
            {
                try
                {
                    client = new RestClient("http://localhost:3001/hash/create");
                    request = new RestRequest();
                    request.Method = Method.Post;
                    request.RequestFormat = RestSharp.DataFormat.Json;
                    request.AddBody(new
                    {
                        value = input,
                    });
                    response = client.Execute(request);
                    res = JsonSerializer.Deserialize<Response>(response.Content);
                    if (response.StatusCode == HttpStatusCode.Forbidden)
                    {
                        lblStatus.ForeColor = Color.Red;
                        lblStatus.Text = res.message;
                    } 
                    else
                    {
                        lblStatus.ForeColor = Color.Green;
                        lblStatus.Text = res.message;
                    }
                }
                catch
                {
                    res = JsonSerializer.Deserialize<Response>(response.Content);
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = res.message;
                }
            }
        }

        private void openUpdateFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateForm updateForm = new UpdateForm();
            updateForm.Show();
        }
        
        private void openDeleteFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.Show();
        }
    }
}
