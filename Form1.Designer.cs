namespace ProjetoCursos
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MaskedTextBox txtCursoId;
        private System.Windows.Forms.TextBox txtCursoDescricao;
        private System.Windows.Forms.Button btnAdicionarCurso;
        private System.Windows.Forms.MaskedTextBox txtDisciplinaId;
        private System.Windows.Forms.TextBox txtDisciplinaDescricao;
        private System.Windows.Forms.ComboBox cmbCursos;
        private System.Windows.Forms.Button btnAdicionarDisciplina;
        private System.Windows.Forms.MaskedTextBox txtAlunoId;
        private System.Windows.Forms.TextBox txtAlunoNome;
        private System.Windows.Forms.ComboBox cmbDisciplinas;
        private System.Windows.Forms.Button btnMatricularAluno;
        private System.Windows.Forms.Button btnExcluirCurso;
        private System.Windows.Forms.Button btnExcluirDisciplina;
        private System.Windows.Forms.Button btnExcluirAluno;
        private System.Windows.Forms.Button btnDesmatricularAluno;
        private System.Windows.Forms.TextBox txtPesquisarCurso;
        private System.Windows.Forms.Button btnPesquisarCurso;
        private System.Windows.Forms.TextBox txtPesquisarDisciplina;
        private System.Windows.Forms.Button btnPesquisarDisciplina;
        private System.Windows.Forms.TextBox txtPesquisarAluno;
        private System.Windows.Forms.Button btnPesquisarAluno;

        private void InitializeComponent()
        {
            this.txtCursoId = new System.Windows.Forms.MaskedTextBox();
            this.txtCursoDescricao = new System.Windows.Forms.TextBox();
            this.btnAdicionarCurso = new System.Windows.Forms.Button();
            this.txtDisciplinaId = new System.Windows.Forms.MaskedTextBox();
            this.txtDisciplinaDescricao = new System.Windows.Forms.TextBox();
            this.cmbCursos = new System.Windows.Forms.ComboBox();
            this.btnAdicionarDisciplina = new System.Windows.Forms.Button();
            this.txtAlunoId = new System.Windows.Forms.MaskedTextBox();
            this.txtAlunoNome = new System.Windows.Forms.TextBox();
            this.cmbDisciplinas = new System.Windows.Forms.ComboBox();
            this.btnMatricularAluno = new System.Windows.Forms.Button();
            this.btnExcluirCurso = new System.Windows.Forms.Button();
            this.btnExcluirDisciplina = new System.Windows.Forms.Button();
            this.btnExcluirAluno = new System.Windows.Forms.Button();
            this.btnDesmatricularAluno = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // txtCursoId
            // 
            this.txtCursoId.Location = new System.Drawing.Point(12, 12);
            this.txtCursoId.Mask = "00000";
            this.txtCursoId.Name = "txtCursoId";
            this.txtCursoId.Size = new System.Drawing.Size(100, 20);
            this.txtCursoId.TabIndex = 0;
            this.txtCursoId.ValidatingType = typeof(int);

            // 
            // txtCursoDescricao
            // 
            this.txtCursoDescricao.Location = new System.Drawing.Point(12, 38);
            this.txtCursoDescricao.Name = "txtCursoDescricao";
            this.txtCursoDescricao.Size = new System.Drawing.Size(100, 20);
            this.txtCursoDescricao.TabIndex = 1;
            this.txtCursoDescricao.PlaceholderText = "Descrição do Curso";

            // 
            // btnAdicionarCurso
            // 
            this.btnAdicionarCurso.Location = new System.Drawing.Point(12, 64);
            this.btnAdicionarCurso.Name = "btnAdicionarCurso";
            this.btnAdicionarCurso.Size = new System.Drawing.Size(100, 23);
            this.btnAdicionarCurso.TabIndex = 2;
            this.btnAdicionarCurso.Text = "Adicionar Curso";
            this.btnAdicionarCurso.UseVisualStyleBackColor = true;
            this.btnAdicionarCurso.Click += new System.EventHandler(this.btnAdicionarCurso_Click);

            // 
            // txtDisciplinaId
            // 
            this.txtDisciplinaId.Location = new System.Drawing.Point(12, 93);
            this.txtDisciplinaId.Mask = "00000";
            this.txtDisciplinaId.Name = "txtDisciplinaId";
            this.txtDisciplinaId.Size = new System.Drawing.Size(100, 20);
            this.txtDisciplinaId.TabIndex = 3;


            // 
            // txtDisciplinaDescricao
            // 
            this.txtDisciplinaDescricao.Location = new System.Drawing.Point(12, 119);
            this.txtDisciplinaDescricao.Name = "txtDisciplinaDescricao";
            this.txtDisciplinaDescricao.Size = new System.Drawing.Size(100, 20);
            this.txtDisciplinaDescricao.TabIndex = 4;
            this.txtDisciplinaDescricao.PlaceholderText = "Descrição da Disciplina";

            // 
            // cmbCursos
            // 
            this.cmbCursos.FormattingEnabled = true;
            this.cmbCursos.Location = new System.Drawing.Point(12, 145);
            this.cmbCursos.Name = "cmbCursos";
            this.cmbCursos.Size = new System.Drawing.Size(100, 21);
            this.cmbCursos.TabIndex = 5;

            // 
            // btnAdicionarDisciplina
            // 
            this.btnAdicionarDisciplina.Location = new System.Drawing.Point(12, 172);
            this.btnAdicionarDisciplina.Name = "btnAdicionarDisciplina";
            this.btnAdicionarDisciplina.Size = new System.Drawing.Size(100, 23);
            this.btnAdicionarDisciplina.TabIndex = 6;
            this.btnAdicionarDisciplina.Text = "Adicionar Disciplina";
            this.btnAdicionarDisciplina.UseVisualStyleBackColor = true;
            this.btnAdicionarDisciplina.Click += new System.EventHandler(this.btnAdicionarDisciplina_Click);

            // 
            // txtAlunoId
            // 
            this.txtAlunoId.Location = new System.Drawing.Point(12, 201);
            this.txtAlunoId.Mask = "00000";
            this.txtAlunoId.Name = "txtAlunoId";
            this.txtAlunoId.Size = new System.Drawing.Size(100, 20);
            this.txtAlunoId.TabIndex = 7;
            this.txtAlunoId.ValidatingType = typeof(int);

            // 
            // txtAlunoNome
            // 
            this.txtAlunoNome.Location = new System.Drawing.Point(12, 227);
            this.txtAlunoNome.Name = "txtAlunoNome";
            this.txtAlunoNome.Size = new System.Drawing.Size(100, 20);
            this.txtAlunoNome.TabIndex = 8;
            this.txtAlunoNome.PlaceholderText = "Nome do Aluno";

            // 
            // cmbDisciplinas
            // 
            this.cmbDisciplinas.FormattingEnabled = true;
            this.cmbDisciplinas.Location = new System.Drawing.Point(12, 253);
            this.cmbDisciplinas.Name = "cmbDisciplinas";
            this.cmbDisciplinas.Size = new System.Drawing.Size(100, 21);
            this.cmbDisciplinas.TabIndex = 9;

            // 
            // btnMatricularAluno
            // 
            this.btnMatricularAluno.Location = new System.Drawing.Point(12, 280);
            this.btnMatricularAluno.Name = "btnMatricularAluno";
            this.btnMatricularAluno.Size = new System.Drawing.Size(100, 23);
            this.btnMatricularAluno.TabIndex = 10;
            this.btnMatricularAluno.Text = "Matricular Aluno";
            this.btnMatricularAluno.UseVisualStyleBackColor = true;
            this.btnMatricularAluno.Click += new System.EventHandler(this.btnMatricularAluno_Click);

            // 
            // btnExcluirCurso
            // 
            this.btnExcluirCurso.Location = new System.Drawing.Point(130, 64);
            this.btnExcluirCurso.Name = "btnExcluirCurso";
            this.btnExcluirCurso.Size = new System.Drawing.Size(100, 23);
            this.btnExcluirCurso.TabIndex = 11;
            this.btnExcluirCurso.Text = "Excluir Curso";
            this.btnExcluirCurso.UseVisualStyleBackColor = true;
            this.btnExcluirCurso.Click += new System.EventHandler(this.btnExcluirCurso_Click);

            // 
            // btnExcluirDisciplina
            // 
            this.btnExcluirDisciplina.Location = new System.Drawing.Point(130, 172);
            this.btnExcluirDisciplina.Name = "btnExcluirDisciplina";
            this.btnExcluirDisciplina.Size = new System.Drawing.Size(100, 23);
            this.btnExcluirDisciplina.TabIndex = 12;
            this.btnExcluirDisciplina.Text = "Excluir Disciplina";
            this.btnExcluirDisciplina.UseVisualStyleBackColor = true;
            this.btnExcluirDisciplina.Click += new System.EventHandler(this.btnExcluirDisciplina_Click);

            // 
            // btnExcluirAluno
            // 
            this.btnExcluirAluno.Location = new System.Drawing.Point(130, 280);
            this.btnExcluirAluno.Name = "btnExcluirAluno";
            this.btnExcluirAluno.Size = new System.Drawing.Size(100, 23);
            this.btnExcluirAluno.TabIndex = 13;
            this.btnExcluirAluno.Text = "Excluir Aluno";
            this.btnExcluirAluno.UseVisualStyleBackColor = true;
            this.btnExcluirAluno.Click += new System.EventHandler(this.btnExcluirAluno_Click);

            // 
            // btnDesmatricularAluno
            // 
            this.btnDesmatricularAluno.Location = new System.Drawing.Point(130, 309);
            this.btnDesmatricularAluno.Name = "btnDesmatricularAluno";
            this.btnDesmatricularAluno.Size = new System.Drawing.Size(100, 23);
            this.btnDesmatricularAluno.TabIndex = 14;
            this.btnDesmatricularAluno.Text = "Desmatricular Aluno";
            this.btnDesmatricularAluno.UseVisualStyleBackColor = true;
            this.btnDesmatricularAluno.Click += new System.EventHandler(this.btnDesmatricularAluno_Click);


            // 
            // txtPesquisarCurso
            // 
            this.txtPesquisarCurso = new System.Windows.Forms.TextBox();
            this.txtPesquisarCurso.Location = new System.Drawing.Point(12, 338);
            this.txtPesquisarCurso.Name = "txtPesquisarCurso";
            this.txtPesquisarCurso.Size = new System.Drawing.Size(100, 20);
            this.txtPesquisarCurso.TabIndex = 15;
            this.txtPesquisarCurso.PlaceholderText = "Pesquisar Curso";

            // 
            // btnPesquisarCurso
            // 
            this.btnPesquisarCurso = new System.Windows.Forms.Button();
            this.btnPesquisarCurso.Location = new System.Drawing.Point(130, 338);
            this.btnPesquisarCurso.Name = "btnPesquisarCurso";
            this.btnPesquisarCurso.Size = new System.Drawing.Size(100, 23);
            this.btnPesquisarCurso.TabIndex = 16;
            this.btnPesquisarCurso.Text = "Pesquisar Curso";
            this.btnPesquisarCurso.UseVisualStyleBackColor = true;
            this.btnPesquisarCurso.Click += new System.EventHandler(this.btnPesquisarCurso_Click);

            // 
            // txtPesquisarDisciplina
            // 
            this.txtPesquisarDisciplina = new System.Windows.Forms.TextBox();
            this.txtPesquisarDisciplina.Location = new System.Drawing.Point(12, 367);
            this.txtPesquisarDisciplina.Name = "txtPesquisarDisciplina";
            this.txtPesquisarDisciplina.Size = new System.Drawing.Size(100, 20);
            this.txtPesquisarDisciplina.TabIndex = 17;
            this.txtPesquisarDisciplina.PlaceholderText = "Pesquisar Disciplina";

            // 
            // btnPesquisarDisciplina
            // 
            this.btnPesquisarDisciplina = new System.Windows.Forms.Button();
            this.btnPesquisarDisciplina.Location = new System.Drawing.Point(130, 367);
            this.btnPesquisarDisciplina.Name = "btnPesquisarDisciplina";
            this.btnPesquisarDisciplina.Size = new System.Drawing.Size(100, 23);
            this.btnPesquisarDisciplina.TabIndex = 18;
            this.btnPesquisarDisciplina.Text = "Pesquisar Disciplina";
            this.btnPesquisarDisciplina.UseVisualStyleBackColor = true;
            this.btnPesquisarDisciplina.Click += new System.EventHandler(this.btnPesquisarDisciplina_Click);

            // 
            // txtPesquisarAluno
            // 
            this.txtPesquisarAluno = new System.Windows.Forms.TextBox();
            this.txtPesquisarAluno.Location = new System.Drawing.Point(12, 396);
            this.txtPesquisarAluno.Name = "txtPesquisarAluno";
            this.txtPesquisarAluno.Size = new System.Drawing.Size(100, 20);
            this.txtPesquisarAluno.TabIndex = 19;
            this.txtPesquisarAluno.PlaceholderText = "Pesquisar Aluno";

            // 
            // btnPesquisarAluno
            // 
            this.btnPesquisarAluno = new System.Windows.Forms.Button();
            this.btnPesquisarAluno.Location = new System.Drawing.Point(130, 396);
            this.btnPesquisarAluno.Name = "btnPesquisarAluno";
            this.btnPesquisarAluno.Size = new System.Drawing.Size(100, 23);
            this.btnPesquisarAluno.TabIndex = 20;
            this.btnPesquisarAluno.Text = "Pesquisar Aluno";
            this.btnPesquisarAluno.UseVisualStyleBackColor = true;
            this.btnPesquisarAluno.Click += new System.EventHandler(this.btnPesquisarAluno_Click);


            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 341);
            this.Controls.Add(this.txtPesquisarCurso);
            this.Controls.Add(this.btnPesquisarCurso);
            this.Controls.Add(this.txtPesquisarDisciplina);
            this.Controls.Add(this.btnPesquisarDisciplina);
            this.Controls.Add(this.txtPesquisarAluno);
            this.Controls.Add(this.btnPesquisarAluno);
            this.Controls.Add(this.btnDesmatricularAluno);
            this.Controls.Add(this.btnExcluirAluno);
            this.Controls.Add(this.btnExcluirDisciplina);
            this.Controls.Add(this.btnExcluirCurso);
            this.Controls.Add(this.btnMatricularAluno);
            this.Controls.Add(this.cmbDisciplinas);
            this.Controls.Add(this.txtAlunoNome);
            this.Controls.Add(this.txtAlunoId);
            this.Controls.Add(this.btnAdicionarDisciplina);
            this.Controls.Add(this.cmbCursos);
            this.Controls.Add(this.txtDisciplinaDescricao);
            this.Controls.Add(this.txtDisciplinaId);
            this.Controls.Add(this.btnAdicionarCurso);
            this.Controls.Add(this.txtCursoDescricao);
            this.Controls.Add(this.txtCursoId);
            this.Name = "Form1";
            this.Text = "Gerenciamento de Cursos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
