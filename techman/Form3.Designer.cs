namespace techman
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.tela = new System.Windows.Forms.DataGridView();
            this.Imagem = new System.Windows.Forms.DataGridViewImageColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentario = new System.Windows.Forms.DataGridViewImageColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ListaComentarios = new System.Windows.Forms.GroupBox();
            this.telaComentario = new System.Windows.Forms.DataGridView();
            this.perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentaario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AddComentarios = new System.Windows.Forms.GroupBox();
            this.textoComentario = new System.Windows.Forms.TextBox();
            this.cadastrarComentario = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tela)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ListaComentarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telaComentario)).BeginInit();
            this.AddComentarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // tela
            // 
            this.tela.AllowUserToAddRows = false;
            this.tela.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tela.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Imagem,
            this.Nome,
            this.Descricao,
            this.Comentario,
            this.Excluir});
            this.tela.Location = new System.Drawing.Point(0, 63);
            this.tela.Name = "tela";
            this.tela.Size = new System.Drawing.Size(802, 387);
            this.tela.TabIndex = 0;
            this.tela.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tela_CellClick);
            // 
            // Imagem
            // 
            this.Imagem.HeaderText = "Imagem";
            this.Imagem.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Imagem.Name = "Imagem";
            this.Imagem.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descricao.DefaultCellStyle = dataGridViewCellStyle12;
            this.Descricao.FillWeight = 300F;
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 80;
            // 
            // Comentario
            // 
            this.Comentario.FillWeight = 20F;
            this.Comentario.HeaderText = "Comentario";
            this.Comentario.Image = global::techman.Properties.Resources.comentario;
            this.Comentario.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Comentario.Name = "Comentario";
            this.Comentario.ReadOnly = true;
            this.Comentario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Excluir
            // 
            this.Excluir.FillWeight = 20F;
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.Image = global::techman.Properties.Resources.deletar;
            this.Excluir.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Comentario";
            this.dataGridViewImageColumn1.Image = global::techman.Properties.Resources.comentario;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Excluir";
            this.dataGridViewImageColumn2.Image = global::techman.Properties.Resources.deletar;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Intel_Core_i9.png");
            this.imageList1.Images.SetKeyName(1, "Monitor_Dell.png");
            this.imageList1.Images.SetKeyName(2, "Mouse_Razer.png");
            this.imageList1.Images.SetKeyName(3, "Teclado_Microsoft.png");
            this.imageList1.Images.SetKeyName(4, "Torno_Mecanico_500mm.png");
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, -1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(801, 66);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(767, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(621, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Novo equipamento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ListaComentarios
            // 
            this.ListaComentarios.Controls.Add(this.AddComentarios);
            this.ListaComentarios.Controls.Add(this.button1);
            this.ListaComentarios.Controls.Add(this.button2);
            this.ListaComentarios.Controls.Add(this.telaComentario);
            this.ListaComentarios.Location = new System.Drawing.Point(88, 99);
            this.ListaComentarios.Name = "ListaComentarios";
            this.ListaComentarios.Size = new System.Drawing.Size(598, 262);
            this.ListaComentarios.TabIndex = 3;
            this.ListaComentarios.TabStop = false;
            // 
            // telaComentario
            // 
            this.telaComentario.AllowUserToAddRows = false;
            this.telaComentario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.telaComentario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.telaComentario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.telaComentario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perfil,
            this.data,
            this.comentaario});
            this.telaComentario.Location = new System.Drawing.Point(0, 0);
            this.telaComentario.Name = "telaComentario";
            this.telaComentario.Size = new System.Drawing.Size(598, 227);
            this.telaComentario.TabIndex = 4;
            // 
            // perfil
            // 
            this.perfil.HeaderText = "Perfil";
            this.perfil.Name = "perfil";
            // 
            // data
            // 
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            // 
            // comentaario
            // 
            this.comentaario.HeaderText = "Comentário";
            this.comentaario.Name = "comentaario";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(348, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Fechar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Adicionar Comentário";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddComentarios
            // 
            this.AddComentarios.Controls.Add(this.textBox2);
            this.AddComentarios.Controls.Add(this.textBox1);
            this.AddComentarios.Controls.Add(this.cadastrarComentario);
            this.AddComentarios.Controls.Add(this.textoComentario);
            this.AddComentarios.Location = new System.Drawing.Point(94, 19);
            this.AddComentarios.Name = "AddComentarios";
            this.AddComentarios.Size = new System.Drawing.Size(391, 196);
            this.AddComentarios.TabIndex = 7;
            this.AddComentarios.TabStop = false;
            // 
            // textoComentario
            // 
            this.textoComentario.Location = new System.Drawing.Point(39, 138);
            this.textoComentario.Name = "textoComentario";
            this.textoComentario.Size = new System.Drawing.Size(100, 20);
            this.textoComentario.TabIndex = 0;
            this.textoComentario.TextChanged += new System.EventHandler(this.textoComentario_TextChanged);
            // 
            // cadastrarComentario
            // 
            this.cadastrarComentario.Location = new System.Drawing.Point(253, 167);
            this.cadastrarComentario.Name = "cadastrarComentario";
            this.cadastrarComentario.Size = new System.Drawing.Size(75, 23);
            this.cadastrarComentario.TabIndex = 1;
            this.cadastrarComentario.Text = "Adicionar";
            this.cadastrarComentario.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(39, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListaComentarios);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tela);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tela)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ListaComentarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.telaComentario)).EndInit();
            this.AddComentarios.ResumeLayout(false);
            this.AddComentarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tela;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridViewImageColumn Imagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewImageColumn Comentario;
        private System.Windows.Forms.DataGridViewImageColumn Excluir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox ListaComentarios;
        private System.Windows.Forms.DataGridView telaComentario;
        private System.Windows.Forms.DataGridViewTextBoxColumn perfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentaario;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox AddComentarios;
        private System.Windows.Forms.TextBox textoComentario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cadastrarComentario;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}