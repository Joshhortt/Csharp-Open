using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWinforms
{
	public partial class FrmTree : Form
	{
		public FrmTree()
		{
			InitializeComponent();
		}

		private void FrmTree_Load(object sender, EventArgs e)
		{

		}

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			MessageBox.Show(e.Node.Text);
		}
	}
}
