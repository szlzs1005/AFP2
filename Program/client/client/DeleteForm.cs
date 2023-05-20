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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class DeleteForm : Form
    {
        RestClient client = null;
        RestRequest request = null;
        RestResponse<List<Hash>> response = null;
        RestResponse deleteResponse = null;
        Hash hash = null;
        Response res = null;
        public DeleteForm()
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

        private void openUpdateFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateForm updateForm = new UpdateForm();
            updateForm.Show();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (tbValue.Text == "")
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Please add hash value";
                btnDelete.Enabled = false;
                return;
            }
            client = new RestClient("http://localhost:3001/hash/read");
            request = new RestRequest();
            request.Method = Method.Get;
            response = client.Execute<List<Hash>>(request);
            bool found = false;
            foreach (Hash hash in response.Data)
            {
                if (hash.value == tbValue.Text)
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
                btnDelete.Enabled = true;
            }
            else
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Hash value not found";
                btnDelete.Enabled = false;
            }
        }
    }
}
