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
            panel1 = new Panel();
            btn_delete = new Button();
            box_filter = new ComboBox();
            label5 = new Label();
            lv_alunos = new ListView();
            Nome = new ColumnHeader();
            Idade = new ColumnHeader();
            Curso = new ColumnHeader();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_delete);
            panel1.Controls.Add(box_filter);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lv_alunos);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 451);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // btn_delete
            // 
            btn_delete.Font = new Font("Segoe UI", 7F);
            btn_delete.Location = new Point(700, 408);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(69, 29);
            btn_delete.TabIndex = 11;
            btn_delete.Text = "Excluir";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // box_filter
            // 
            box_filter.Font = new Font("Segoe UI", 7F);
            box_filter.FormattingEnabled = true;
            box_filter.Location = new Point(700, 95);
            box_filter.Name = "box_filter";
            box_filter.Size = new Size(69, 23);
            box_filter.TabIndex = 9;
            box_filter.Text = "Filtrar";
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
            lv_alunos.Columns.AddRange(new ColumnHeader[] { Nome, Idade, Curso });
            lv_alunos.Location = new Point(28, 143);
            lv_alunos.Name = "lv_alunos";
            lv_alunos.Size = new Size(741, 259);
            lv_alunos.TabIndex = 9;
            lv_alunos.UseCompatibleStateImageBehavior = false;
            lv_alunos.View = View.Details;
            // 
            // Nome
            // 
            Nome.Text = "Nome";
            Nome.Width = 300;
            // 
            // Idade
            // 
            Idade.Text = "Idade";
            Idade.Width = 150;
            // 
            // Curso
            // 
            Curso.Text = "Curso";
            Curso.Width = 300;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 449);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox box_filter;
        private Label label5;
        private ListView lv_alunos;
        private ColumnHeader Nome;
        private ColumnHeader Idade;
        private ColumnHeader Curso;
        private Button btn_delete;
    }
}