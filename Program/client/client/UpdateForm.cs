using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class UpdateForm : Form
    {
        RestClient client = null;
        RestRequest request = null;
        RestResponse<List<Hash>> response = null;
        RestResponse updateResponse = null;
        Hash hash = null;
        Response res = null;
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        
        private void openScannerFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScannerForm scanForm = new ScannerForm();
            scanForm.Show();
        }

        private void openAddFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddForm crudForm = new AddForm();
            crudForm.Show();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (tbOld.Text == "")
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Please add hash value";
                btnUpdate.Enabled = false;
                return;
            }
            client = new RestClient("http://localhost:3001/hash/read");
            request = new RestRequest();
            request.Method = Method.Get;
            response = client.Execute<List<Hash>>(request);
            bool found = false;
            foreach (Hash hash in response.Data)
            {
                if (hash.value == tbOld.Text)
                {
                    found = true;
                    this.hash = hash;
                    break;
                }
            }
            if (found)
            {
                lblStatus.ForeColor = Color.Green;
                lblStatus.Text = "Hash value found";
                btnUpdate.Enabled = true;
                tbNew.Enabled = true;
            }
            else
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Hash value not found";
                btnUpdate.Enabled = false;
                tbNew.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string newValue = tbNew.Text;
            if (!Regex.IsMatch(newValue, "^[a-zA-Z0-9]+$") || newValue.Length != 32 || newValue == "")
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Please enter a new hash value";
            }
            else
            {
                try
                {                    
                    client = new RestClient("http://localhost:3001/hash/update/" + hash.id);
                    request = new RestRequest();
                    request.Method = Method.Patch;
                    request.RequestFormat = RestSharp.DataFormat.Json;
                    request.AddBody(new
                    {
                        value = newValue,
                    });
                    updateResponse = client.Execute(request);
                    res = JsonSerializer.Deserialize<Response>(updateResponse.Content);
                    if (updateResponse.StatusCode == HttpStatusCode.Forbidden)
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
                    res = JsonSerializer.Deserialize<Response>(updateResponse.Content);
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = res.message;
                }
            }
        }
 
        private void openDeleteFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.Show();
        }
    }
}
