using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetPacker
{
    public partial class ASCIIForm : Form
    {
        public Model.Asset Asset { get; set; }

        public ASCIIForm()
        {
            InitializeComponent();

            Asset = new Model.Asset();
        }
    }
}
