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
            txtCursoId = new MaskedTextBox();
            txtCursoDescricao = new TextBox();
            btnAdicionarCurso = new Button();
            txtDisciplinaId = new MaskedTextBox();
            txtDisciplinaDescricao = new TextBox();
            cmbCursos = new ComboBox();
            btnAdicionarDisciplina = new Button();
            txtAlunoId = new MaskedTextBox();
            txtAlunoNome = new TextBox();
            cmbDisciplinas = new ComboBox();
            btnMatricularAluno = new Button();
            btnExcluirCurso = new Button();
            btnExcluirDisciplina = new Button();
            btnExcluirAluno = new Button();
            btnDesmatricularAluno = new Button();
            txtPesquisarCurso = new TextBox();
            btnPesquisarCurso = new Button();
            txtPesquisarDisciplina = new TextBox();
            btnPesquisarDisciplina = new Button();
            txtPesquisarAluno = new TextBox();
            btnPesquisarAluno = new Button();
            SuspendLayout();
            // 
            // txtCursoId
            // 
            txtCursoId.Location = new Point(12, 12);
            txtCursoId.Mask = "00000";
            txtCursoId.Name = "txtCursoId";
            txtCursoId.Size = new Size(100, 23);
            txtCursoId.TabIndex = 0;
            txtCursoId.ValidatingType = typeof(int);
            // 
            // txtCursoDescricao
            // 
            txtCursoDescricao.Location = new Point(12, 38);
            txtCursoDescricao.Name = "txtCursoDescricao";
            txtCursoDescricao.PlaceholderText = "Descrição do Curso";
            txtCursoDescricao.Size = new Size(100, 23);
            txtCursoDescricao.TabIndex = 1;
            // 
            // btnAdicionarCurso
            // 
            btnAdicionarCurso.Location = new Point(12, 64);
            btnAdicionarCurso.Name = "btnAdicionarCurso";
            btnAdicionarCurso.Size = new Size(100, 23);
            btnAdicionarCurso.TabIndex = 2;
            btnAdicionarCurso.Text = "Adicionar Curso";
            btnAdicionarCurso.UseVisualStyleBackColor = true;
            btnAdicionarCurso.Click += btnAdicionarCurso_Click;
            // 
            // txtDisciplinaId
            // 
            txtDisciplinaId.Location = new Point(12, 93);
            txtDisciplinaId.Mask = "00000";
            txtDisciplinaId.Name = "txtDisciplinaId";
            txtDisciplinaId.Size = new Size(100, 23);
            txtDisciplinaId.TabIndex = 3;
            // 
            // txtDisciplinaDescricao
            // 
            txtDisciplinaDescricao.Location = new Point(12, 119);
            txtDisciplinaDescricao.Name = "txtDisciplinaDescricao";
            txtDisciplinaDescricao.PlaceholderText = "Descrição da Disciplina";
            txtDisciplinaDescricao.Size = new Size(100, 23);
            txtDisciplinaDescricao.TabIndex = 4;
            // 
            // cmbCursos
            // 
            cmbCursos.FormattingEnabled = true;
            cmbCursos.Location = new Point(12, 145);
            cmbCursos.Name = "cmbCursos";
            cmbCursos.Size = new Size(100, 23);
            cmbCursos.TabIndex = 5;
            // 
            // btnAdicionarDisciplina
            // 
            btnAdicionarDisciplina.Location = new Point(12, 172);
            btnAdicionarDisciplina.Name = "btnAdicionarDisciplina";
            btnAdicionarDisciplina.Size = new Size(100, 23);
            btnAdicionarDisciplina.TabIndex = 6;
            btnAdicionarDisciplina.Text = "Adicionar Disciplina";
            btnAdicionarDisciplina.UseVisualStyleBackColor = true;
            btnAdicionarDisciplina.Click += btnAdicionarDisciplina_Click;
            // 
            // txtAlunoId
            // 
            txtAlunoId.Location = new Point(12, 201);
            txtAlunoId.Mask = "00000";
            txtAlunoId.Name = "txtAlunoId";
            txtAlunoId.Size = new Size(100, 23);
            txtAlunoId.TabIndex = 7;
            txtAlunoId.ValidatingType = typeof(int);
            // 
            // txtAlunoNome
            // 
            txtAlunoNome.Location = new Point(12, 227);
            txtAlunoNome.Name = "txtAlunoNome";
            txtAlunoNome.PlaceholderText = "Nome do Aluno";
            txtAlunoNome.Size = new Size(100, 23);
            txtAlunoNome.TabIndex = 8;
            // 
            // cmbDisciplinas
            // 
            cmbDisciplinas.FormattingEnabled = true;
            cmbDisciplinas.Location = new Point(12, 253);
            cmbDisciplinas.Name = "cmbDisciplinas";
            cmbDisciplinas.Size = new Size(100, 23);
            cmbDisciplinas.TabIndex = 9;
            // 
            // btnMatricularAluno
            // 
            btnMatricularAluno.Location = new Point(12, 280);
            btnMatricularAluno.Name = "btnMatricularAluno";
            btnMatricularAluno.Size = new Size(100, 23);
            btnMatricularAluno.TabIndex = 10;
            btnMatricularAluno.Text = "Matricular Aluno";
            btnMatricularAluno.UseVisualStyleBackColor = true;
            btnMatricularAluno.Click += btnMatricularAluno_Click;
            // 
            // btnExcluirCurso
            // 
            btnExcluirCurso.Location = new Point(130, 64);
            btnExcluirCurso.Name = "btnExcluirCurso";
            btnExcluirCurso.Size = new Size(100, 23);
            btnExcluirCurso.TabIndex = 11;
            btnExcluirCurso.Text = "Excluir Curso";
            btnExcluirCurso.UseVisualStyleBackColor = true;
            btnExcluirCurso.Click += btnExcluirCurso_Click;
            // 
            // btnExcluirDisciplina
            // 
            btnExcluirDisciplina.Location = new Point(130, 172);
            btnExcluirDisciplina.Name = "btnExcluirDisciplina";
            btnExcluirDisciplina.Size = new Size(100, 23);
            btnExcluirDisciplina.TabIndex = 12;
            btnExcluirDisciplina.Text = "Excluir Disciplina";
            btnExcluirDisciplina.UseVisualStyleBackColor = true;
            btnExcluirDisciplina.Click += btnExcluirDisciplina_Click;
            // 
            // btnExcluirAluno
            // 
            btnExcluirAluno.Location = new Point(130, 280);
            btnExcluirAluno.Name = "btnExcluirAluno";
            btnExcluirAluno.Size = new Size(100, 23);
            btnExcluirAluno.TabIndex = 13;
            btnExcluirAluno.Text = "Excluir Aluno";
            btnExcluirAluno.UseVisualStyleBackColor = true;
            btnExcluirAluno.Click += btnExcluirAluno_Click;
            // 
            // btnDesmatricularAluno
            // 
            btnDesmatricularAluno.Location = new Point(130, 309);
            btnDesmatricularAluno.Name = "btnDesmatricularAluno";
            btnDesmatricularAluno.Size = new Size(100, 23);
            btnDesmatricularAluno.TabIndex = 14;
            btnDesmatricularAluno.Text = "Desmatricular Aluno";
            btnDesmatricularAluno.UseVisualStyleBackColor = true;
            btnDesmatricularAluno.Click += btnDesmatricularAluno_Click;
            // 
            // txtPesquisarCurso
            // 
            txtPesquisarCurso.Location = new Point(12, 338);
            txtPesquisarCurso.Name = "txtPesquisarCurso";
            txtPesquisarCurso.PlaceholderText = "Pesquisar Curso";
            txtPesquisarCurso.Size = new Size(100, 23);
            txtPesquisarCurso.TabIndex = 15;
            // 
            // btnPesquisarCurso
            // 
            btnPesquisarCurso.Location = new Point(130, 338);
            btnPesquisarCurso.Name = "btnPesquisarCurso";
            btnPesquisarCurso.Size = new Size(100, 23);
            btnPesquisarCurso.TabIndex = 16;
            btnPesquisarCurso.Text = "Nome Curso";
            btnPesquisarCurso.UseVisualStyleBackColor = true;
            btnPesquisarCurso.Click += btnPesquisarCurso_Click;
            // 
            // txtPesquisarDisciplina
            // 
            txtPesquisarDisciplina.Location = new Point(12, 367);
            txtPesquisarDisciplina.Name = "txtPesquisarDisciplina";
            txtPesquisarDisciplina.PlaceholderText = "Nome Disciplina";
            txtPesquisarDisciplina.Size = new Size(100, 23);
            txtPesquisarDisciplina.TabIndex = 17;
            // 
            // btnPesquisarDisciplina
            // 
            btnPesquisarDisciplina.Location = new Point(130, 367);
            btnPesquisarDisciplina.Name = "btnPesquisarDisciplina";
            btnPesquisarDisciplina.Size = new Size(100, 23);
            btnPesquisarDisciplina.TabIndex = 18;
            btnPesquisarDisciplina.Text = "Nome Disciplina";
            btnPesquisarDisciplina.UseVisualStyleBackColor = true;
            btnPesquisarDisciplina.Click += btnPesquisarDisciplina_Click;
            // 
            // txtPesquisarAluno
            // 
            txtPesquisarAluno.Location = new Point(12, 396);
            txtPesquisarAluno.Name = "txtPesquisarAluno";
            txtPesquisarAluno.PlaceholderText = "Nome Aluno";
            txtPesquisarAluno.Size = new Size(100, 23);
            txtPesquisarAluno.TabIndex = 19;
            // 
            // btnPesquisarAluno
            // 
            btnPesquisarAluno.Location = new Point(130, 396);
            btnPesquisarAluno.Name = "btnPesquisarAluno";
            btnPesquisarAluno.Size = new Size(100, 23);
            btnPesquisarAluno.TabIndex = 20;
            btnPesquisarAluno.Text = "Pesquisar Aluno";
            btnPesquisarAluno.UseVisualStyleBackColor = true;
            btnPesquisarAluno.Click += btnPesquisarAluno_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(471, 517);
            Controls.Add(txtPesquisarCurso);
            Controls.Add(btnPesquisarCurso);
            Controls.Add(txtPesquisarDisciplina);
            Controls.Add(btnPesquisarDisciplina);
            Controls.Add(txtPesquisarAluno);
            Controls.Add(btnPesquisarAluno);
            Controls.Add(btnDesmatricularAluno);
            Controls.Add(btnExcluirAluno);
            Controls.Add(btnExcluirDisciplina);
            Controls.Add(btnExcluirCurso);
            Controls.Add(btnMatricularAluno);
            Controls.Add(cmbDisciplinas);
            Controls.Add(txtAlunoNome);
            Controls.Add(txtAlunoId);
            Controls.Add(btnAdicionarDisciplina);
            Controls.Add(cmbCursos);
            Controls.Add(txtDisciplinaDescricao);
            Controls.Add(txtDisciplinaId);
            Controls.Add(btnAdicionarCurso);
            Controls.Add(txtCursoDescricao);
            Controls.Add(txtCursoId);
            Name = "Form1";
            Text = "Gerenciamento de Cursos";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
