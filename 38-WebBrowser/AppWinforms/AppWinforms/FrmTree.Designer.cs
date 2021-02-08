
namespace AppWinforms
{
	partial class FrmTree
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node5");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node3", new System.Windows.Forms.TreeNode[] {
            treeNode1});
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
            treeNode2});
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node7");
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node6", new System.Windows.Forms.TreeNode[] {
            treeNode4});
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node8");
			System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode5,
            treeNode6});
			System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node9");
			System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode8});
			System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node10");
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.btnChecados = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.CheckBoxes = true;
			this.treeView1.Location = new System.Drawing.Point(12, 12);
			this.treeView1.Name = "treeView1";
			treeNode1.Name = "Node5";
			treeNode1.Text = "Node5";
			treeNode2.Name = "Node3";
			treeNode2.Text = "Node3";
			treeNode3.Name = "Node2";
			treeNode3.Text = "Node2";
			treeNode4.Name = "Node7";
			treeNode4.Text = "Node7";
			treeNode5.Name = "Node6";
			treeNode5.Text = "Node6";
			treeNode6.Name = "Node8";
			treeNode6.Text = "Node8";
			treeNode7.Name = "Node0";
			treeNode7.Text = "Node0";
			treeNode8.Name = "Node9";
			treeNode8.Text = "Node9";
			treeNode9.Name = "Node1";
			treeNode9.Text = "Node1";
			treeNode10.Name = "Node10";
			treeNode10.Text = "Node10";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode9,
            treeNode10});
			this.treeView1.Size = new System.Drawing.Size(801, 446);
			this.treeView1.TabIndex = 0;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			// 
			// btnChecados
			// 
			this.btnChecados.Location = new System.Drawing.Point(21, 475);
			this.btnChecados.Name = "btnChecados";
			this.btnChecados.Size = new System.Drawing.Size(75, 23);
			this.btnChecados.TabIndex = 1;
			this.btnChecados.Text = "Checados";
			this.btnChecados.UseVisualStyleBackColor = true;
			this.btnChecados.Click += new System.EventHandler(this.btnChecados_Click);
			// 
			// FrmTree
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(825, 510);
			this.Controls.Add(this.btnChecados);
			this.Controls.Add(this.treeView1);
			this.Name = "FrmTree";
			this.Text = "FrmTree";
			this.Load += new System.EventHandler(this.FrmTree_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Button btnChecados;
	}
}