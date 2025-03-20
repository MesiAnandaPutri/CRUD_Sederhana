using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD_Sederhana
{
    public partial class Form1 : Form
    {
        private string ConnectionString = "Data Source = LAPTOP-4FJGLBGI\\NANDA;" + "Initial Catalog =OrganisasiMahasiswa;" + "Integrated Security = true";
        public Form1()
        {
            InitializeComponent();
        }
