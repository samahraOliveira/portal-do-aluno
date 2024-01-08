namespace Portal
{
    partial class Form3
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
            lv_alunos2 = new ListView();
            Nome = new ColumnHeader();
            Idade = new ColumnHeader();
            Curso = new ColumnHeader();
            txt_CursoAtual = new TextBox();
            txt_IdadeAtual = new TextBox();
            txt_NomeAtual = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_atualizar = new Button();
            SuspendLayout();
            // 
            // lv_alunos2
            // 
            lv_alunos2.Columns.AddRange(new ColumnHeader[] { Nome, Idade, Curso });
            lv_alunos2.Location = new Point(321, 122);
            lv_alunos2.MultiSelect = false;
            lv_alunos2.Name = "lv_alunos2";
            lv_alunos2.Size = new Size(442, 277);
            lv_alunos2.TabIndex = 0;
            lv_alunos2.UseCompatibleStateImageBehavior = false;
            lv_alunos2.View = View.Details;
            lv_alunos2.ItemSelectionChanged += lv_alunos2_ItemSelectionChanged;
            // 
            // Nome
            // 
            Nome.Text = "Nome";
            Nome.Width = 160;
            // 
            // Idade
            // 
            Idade.Text = "Idade";
            Idade.Width = 100;
            // 
            // Curso
            // 
            Curso.Text = "Curso";
            Curso.Width = 180;
            // 
            // txt_CursoAtual
            // 
            txt_CursoAtual.Location = new Point(114, 237);
            txt_CursoAtual.Name = "txt_CursoAtual";
            txt_CursoAtual.Size = new Size(125, 27);
            txt_CursoAtual.TabIndex = 1;
            // 
            // txt_IdadeAtual
            // 
            txt_IdadeAtual.Location = new Point(114, 180);
            txt_IdadeAtual.Name = "txt_IdadeAtual";
            txt_IdadeAtual.Size = new Size(125, 27);
            txt_IdadeAtual.TabIndex = 2;
            // 
            // txt_NomeAtual
            // 
            txt_NomeAtual.Location = new Point(114, 126);
            txt_NomeAtual.Name = "txt_NomeAtual";
            txt_NomeAtual.Size = new Size(125, 27);
            txt_NomeAtual.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(42, 236);
            label4.Name = "label4";
            label4.Size = new Size(66, 28);
            label4.TabIndex = 6;
            label4.Text = "Curso:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(42, 179);
            label3.Name = "label3";
            label3.Size = new Size(65, 28);
            label3.TabIndex = 5;
            label3.Text = "Idade:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(42, 122);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 4;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(260, 40);
            label1.Name = "label1";
            label1.Size = new Size(253, 35);
            label1.TabIndex = 7;
            label1.Text = "Atualização de dados";
            label1.Click += label1_Click;
            // 
            // btn_atualizar
            // 
            btn_atualizar.Font = new Font("Segoe UI", 8F);
            btn_atualizar.Location = new Point(141, 301);
            btn_atualizar.Name = "btn_atualizar";
            btn_atualizar.Size = new Size(69, 26);
            btn_atualizar.TabIndex = 8;
            btn_atualizar.Text = "Salvar";
            btn_atualizar.UseVisualStyleBackColor = true;
            btn_atualizar.Click += btn_atualizar_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_atualizar);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_NomeAtual);
            Controls.Add(txt_IdadeAtual);
            Controls.Add(txt_CursoAtual);
            Controls.Add(lv_alunos2);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lv_alunos2;
        private ColumnHeader Nome;
        private ColumnHeader Idade;
        private ColumnHeader Curso;
        private TextBox txt_CursoAtual;
        private TextBox txt_IdadeAtual;
        private TextBox txt_NomeAtual;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_atualizar;
    }
}