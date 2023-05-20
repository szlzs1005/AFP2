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

        
    }
}
