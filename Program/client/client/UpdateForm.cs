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
    }
}
