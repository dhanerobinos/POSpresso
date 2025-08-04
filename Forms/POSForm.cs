using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSpresso.Domain.DTO;
using POSpresso.Domain.Entities;
using POSpresso.Services;

namespace POSpresso.Forms
{
    public partial class POSForm : Form
    {
        private readonly ProductService _productService;
        public POSForm(ProductService productService)
        {
            InitializeComponent();
            _productService = productService;
        }
       

    }
}
