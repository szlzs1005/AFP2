﻿using RestSharp;
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


    }
}
