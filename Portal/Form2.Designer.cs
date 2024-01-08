namespace Portal
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label5 = new Label();
            lv_alunos = new ListView();
            Nome = new ColumnHeader();
            Idade = new ColumnHeader();
            Curso = new ColumnHeader();
            contextMenuStrip1 = new ContextMenuStrip(components);
            excluirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            realizarEdiçõesToolStripMenuItem = new ToolStripMenuItem();
            ordenarPorDataToolStripMenuItem = new ToolStripMenuItem();
            dataToolStripMenuItem = new ToolStripMenuItem();
            nomeToolStripMenuItem = new ToolStripMenuItem();
            data = new ColumnHeader();
            panel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lv_alunos);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 451);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(304, 46);
            label5.Name = "label5";
            label5.Size = new Size(196, 37);
            label5.TabIndex = 10;
            label5.Text = "Lista de Alunos";
            // 
            // lv_alunos
            // 
            lv_alunos.Columns.AddRange(new ColumnHeader[] { Nome, Idade, Curso, data });
            lv_alunos.ContextMenuStrip = contextMenuStrip1;
            lv_alunos.Location = new Point(28, 143);
            lv_alunos.MultiSelect = false;
            lv_alunos.Name = "lv_alunos";
            lv_alunos.Size = new Size(731, 259);
            lv_alunos.TabIndex = 9;
            lv_alunos.UseCompatibleStateImageBehavior = false;
            lv_alunos.View = View.Details;
            lv_alunos.SelectedIndexChanged += lv_alunos_SelectedIndexChanged;
            // 
            // Nome
            // 
            Nome.Text = "Nome";
            Nome.Width = 210;
            // 
            // Idade
            // 
            Idade.Text = "Idade";
            Idade.Width = 130;
            // 
            // Curso
            // 
            Curso.Text = "Curso";
            Curso.Width = 210;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { excluirToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(122, 28);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // excluirToolStripMenuItem
            // 
            excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            excluirToolStripMenuItem.Size = new Size(121, 24);
            excluirToolStripMenuItem.Text = "Excluir";
            excluirToolStripMenuItem.Click += excluirToolStripMenuItem_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(797, 28);
            menuStrip2.TabIndex = 10;
            menuStrip2.Text = "menuStrip2";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { realizarEdiçõesToolStripMenuItem, ordenarPorDataToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // realizarEdiçõesToolStripMenuItem
            // 
            realizarEdiçõesToolStripMenuItem.Name = "realizarEdiçõesToolStripMenuItem";
            realizarEdiçõesToolStripMenuItem.Size = new Size(224, 26);
            realizarEdiçõesToolStripMenuItem.Text = "Editar";
            realizarEdiçõesToolStripMenuItem.Click += realizarEdiçõesToolStripMenuItem_Click;
            // 
            // ordenarPorDataToolStripMenuItem
            // 
            ordenarPorDataToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dataToolStripMenuItem, nomeToolStripMenuItem });
            ordenarPorDataToolStripMenuItem.Name = "ordenarPorDataToolStripMenuItem";
            ordenarPorDataToolStripMenuItem.Size = new Size(224, 26);
            ordenarPorDataToolStripMenuItem.Text = "Ordenar por ";
            ordenarPorDataToolStripMenuItem.Click += ordenarPorDataToolStripMenuItem_Click;
            // 
            // dataToolStripMenuItem
            // 
            dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            dataToolStripMenuItem.Size = new Size(224, 26);
            dataToolStripMenuItem.Text = "Data";
            // 
            // nomeToolStripMenuItem
            // 
            nomeToolStripMenuItem.Name = "nomeToolStripMenuItem";
            nomeToolStripMenuItem.Size = new Size(224, 26);
            nomeToolStripMenuItem.Text = "Nome";
            nomeToolStripMenuItem.Click += nomeToolStripMenuItem_Click;
            // 
            // data
            // 
            data.Text = "Data de modificação";
            data.Width = 180;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 449);
            Controls.Add(menuStrip2);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private ListView lv_alunos;
        private ColumnHeader Nome;
        private ColumnHeader Idade;
        private ColumnHeader Curso;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem excluirToolStripMenuItem;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem realizarEdiçõesToolStripMenuItem;
        private ToolStripMenuItem ordenarPorDataToolStripMenuItem;
        private ToolStripMenuItem dataToolStripMenuItem;
        private ToolStripMenuItem nomeToolStripMenuItem;
        private ColumnHeader data;
    }
}