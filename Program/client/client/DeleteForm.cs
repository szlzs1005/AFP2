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
    }
}
