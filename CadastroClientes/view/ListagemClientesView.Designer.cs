namespace CadastroClientes.view
{
    partial class ListagemClientesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListagemClientesView));
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnRemoverCliente = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(53, 31);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(679, 290);
            this.dgvClientes.TabIndex = 0;
            // 
            // btnRemoverCliente
            // 
            this.btnRemoverCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverCliente.Image")));
            this.btnRemoverCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoverCliente.Location = new System.Drawing.Point(570, 357);
            this.btnRemoverCliente.Name = "btnRemoverCliente";
            this.btnRemoverCliente.Size = new System.Drawing.Size(162, 60);
            this.btnRemoverCliente.TabIndex = 24;
            this.btnRemoverCliente.Text = "Remover";
            this.btnRemoverCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoverCliente.UseVisualStyleBackColor = true;
            this.btnRemoverCliente.Click += new System.EventHandler(this.btnRemoverCliente_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarCliente.Image")));
            this.btnEditarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarCliente.Location = new System.Drawing.Point(329, 357);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(206, 60);
            this.btnEditarCliente.TabIndex = 25;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoCliente.Image")));
            this.btnNovoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoCliente.Location = new System.Drawing.Point(53, 357);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(238, 60);
            this.btnNovoCliente.TabIndex = 26;
            this.btnNovoCliente.Text = "Adicionar Cliente";
            this.btnNovoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoCliente.UseVisualStyleBackColor = true;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // ListagemClientesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNovoCliente);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.btnRemoverCliente);
            this.Controls.Add(this.dgvClientes);
            this.Name = "ListagemClientesView";
            this.Text = "Gerenciar Clientes";
            this.Load += new System.EventHandler(this.ListagemClientesView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnRemoverCliente;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Button btnNovoCliente;
    }
}