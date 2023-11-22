using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaKhoa.Employee_form
{
    public partial class Emp_Main : Form
    {
        public string CurrentEmp { get; set; } = string.Empty;
        public Emp_Main()
        {
            InitializeComponent();
        }
    }
}
