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

		private void btnChecados_Click(object sender, EventArgs e)  // Metodo do Botao Checados
		{
			MessageBox.Show(lerChecados(treeView1.Nodes[0])); // No load mostra numa MessageBox o node0 como default
		}
		private string lerChecados(TreeNode node, string checkeds = "")  // Função recursiva e string inicialmente vazia
		{
			foreach(TreeNode n in node.Nodes)  // Foreach de todos os nós
			{
				if(n.Checked)  // Verfica de esta checked ou seja true.
				{
					checkeds += n.Text + ", ";  // Acresenta uma virgula depois de node checado como true.
				}
				checkeds = lerChecados(n, checkeds);    // Função recursiva (é chamada dentro dela mesma)
			}
			return checkeds;
		}
	}
}
