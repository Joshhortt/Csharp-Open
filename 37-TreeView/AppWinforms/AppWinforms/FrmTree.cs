using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
			treeView1.Nodes.Clear();  // Limpa todos os nos de forma manual feitos anteriormente.
			treeView1.Nodes.Add("Scrimba");  // Aqui vou criar o diretorio de raiz Scrimba
			var node = treeView1.Nodes[0];  // Mando como referencia 
			loadDiretorios(@"D:\PROGRAMAR\Scrimba", ref node);  // Referencia do metodo criado

		}

		private void loadDiretorios(string diretorio, ref TreeNode node)  // Criar metodo com referencia
		{
			string[] arquivos = Directory.GetFiles(diretorio);  // Verifica todos os arquivos que estao dentro desse diretorio que retorna um array de arquivos
			foreach(string arquivo in arquivos) // Dentro desse array de arquivos eu pego nesse nome de arquivo
			{
				node.Nodes.Add(Path.GetFileName(arquivo)); // Dentro do node eu adiciono node e adiciono o nome do arquivo que eu achei la no diretorio
			}


			// Percorrer subdiretórios deste diretório
			string[] subdiretorios = Directory.GetDirectories(diretorio);
			foreach(string subdiretorio in subdiretorios)
			{
				TreeNode n = new TreeNode(Path.GetFileName(subdiretorio));
				loadDiretorios(subdiretorio, ref n);
				node.Nodes.Add(n);
			}
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
