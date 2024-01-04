namespace Portal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_nome = new TextBox();
            txt_idade = new TextBox();
            txt_curso = new TextBox();
            btn_add = new Button();
            alunoBindingSource = new BindingSource(components);
            button_consulta = new Button();
            ((System.ComponentModel.ISupportInitialize)alunoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(279, 58);
            label1.Name = "label1";
            label1.Size = new Size(237, 37);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Aluno";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(198, 128);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(198, 179);
            label3.Name = "label3";
            label3.Size = new Size(65, 28);
            label3.TabIndex = 2;
            label3.Text = "Idade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(198, 235);
            label4.Name = "label4";
            label4.Size = new Size(66, 28);
            label4.TabIndex = 3;
            label4.Text = "Curso:";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(274, 129);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(304, 27);
            txt_nome.TabIndex = 4;
            // 
            // txt_idade
            // 
            txt_idade.Location = new Point(274, 183);
            txt_idade.Name = "txt_idade";
            txt_idade.Size = new Size(304, 27);
            txt_idade.TabIndex = 5;
            // 
            // txt_curso
            // 
            txt_curso.Location = new Point(274, 239);
            txt_curso.Name = "txt_curso";
            txt_curso.Size = new Size(304, 27);
            txt_curso.TabIndex = 6;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(347, 295);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(117, 29);
            btn_add.TabIndex = 7;
            btn_add.Text = "Adicionar";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // alunoBindingSource
            // 
            alunoBindingSource.DataSource = typeof(Aluno);
            // 
            // button_consulta
            // 
            button_consulta.Location = new Point(347, 339);
            button_consulta.Name = "button_consulta";
            button_consulta.Size = new Size(117, 29);
            button_consulta.TabIndex = 0;
            button_consulta.Text = "Lista de Alunos";
            button_consulta.Click += button_consulta_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 450);
            Controls.Add(button_consulta);
            Controls.Add(btn_add);
            Controls.Add(txt_curso);
            Controls.Add(txt_idade);
            Controls.Add(txt_nome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)alunoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_nome;
        private TextBox txt_idade;
        private TextBox txt_curso;
        private Button btn_add;
        private BindingSource alunoBindingSource;
        private Button button_consulta;
    }
}
