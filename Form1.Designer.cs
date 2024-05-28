namespace CadastroAlunos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.l = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt__nome = new System.Windows.Forms.TextBox();
            this.txt__idade = new System.Windows.Forms.TextBox();
            this.txt__curso = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lv_alunos = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.BackColor = System.Drawing.Color.Transparent;
            this.l.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.ForeColor = System.Drawing.Color.White;
            this.l.Location = new System.Drawing.Point(89, 49);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(219, 26);
            this.l.TabIndex = 0;
            this.l.Text = "Formulario de Alunos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(89, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nome:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(89, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Curso:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(91, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Idade:";
            // 
            // txt__nome
            // 
            this.txt__nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt__nome.Location = new System.Drawing.Point(92, 149);
            this.txt__nome.Name = "txt__nome";
            this.txt__nome.Size = new System.Drawing.Size(202, 23);
            this.txt__nome.TabIndex = 4;
            // 
            // txt__idade
            // 
            this.txt__idade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt__idade.Location = new System.Drawing.Point(92, 210);
            this.txt__idade.Name = "txt__idade";
            this.txt__idade.Size = new System.Drawing.Size(202, 23);
            this.txt__idade.TabIndex = 5;
            // 
            // txt__curso
            // 
            this.txt__curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt__curso.Location = new System.Drawing.Point(94, 272);
            this.txt__curso.Name = "txt__curso";
            this.txt__curso.Size = new System.Drawing.Size(202, 23);
            this.txt__curso.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Adicionar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lv_alunos
            // 
            this.lv_alunos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv_alunos.HideSelection = false;
            this.lv_alunos.Location = new System.Drawing.Point(347, 93);
            this.lv_alunos.Name = "lv_alunos";
            this.lv_alunos.Size = new System.Drawing.Size(344, 246);
            this.lv_alunos.TabIndex = 8;
            this.lv_alunos.UseCompatibleStateImageBehavior = false;
            this.lv_alunos.View = System.Windows.Forms.View.Details;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(342, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "Lista de Alunos";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Idade";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Curso";
            this.columnHeader4.Width = 130;
            // 
            // Form1
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(826, 449);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lv_alunos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt__curso);
            this.Controls.Add(this.txt__idade);
            this.Controls.Add(this.txt__nome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.l);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Fomulario de Alunos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_Curso;
        private System.Windows.Forms.TextBox txt_idade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader idade;
        private System.Windows.Forms.ColumnHeader Curso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt__nome;
        private System.Windows.Forms.TextBox txt__idade;
        private System.Windows.Forms.TextBox txt__curso;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView lv_alunos;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label9;
    }
}

