
namespace CrudInstrumentos
{
    partial class CrudWFInstrumentos
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtInstrumentos = new System.Windows.Forms.DataGridView();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtInstrumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(258, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Instrumentos";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPreco.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPreco.Location = new System.Drawing.Point(138, 221);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(72, 30);
            this.lblPreco.TabIndex = 1;
            this.lblPreco.Text = "Preço";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCod.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCod.Location = new System.Drawing.Point(123, 105);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(87, 30);
            this.lblCod.TabIndex = 1;
            this.lblCod.Text = "Codigo";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDesc.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDesc.Location = new System.Drawing.Point(97, 162);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(113, 30);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Descrição";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUrl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblUrl.Location = new System.Drawing.Point(65, 275);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(145, 30);
            this.lblUrl.TabIndex = 3;
            this.lblUrl.Text = "URL Imagem";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(236, 101);
            this.txtCod.Multiline = true;
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(660, 34);
            this.txtCod.TabIndex = 4;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(236, 275);
            this.txtUrl.Multiline = true;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(660, 79);
            this.txtUrl.TabIndex = 7;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(236, 158);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(660, 34);
            this.txtDesc.TabIndex = 8;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(236, 217);
            this.txtPreco.Multiline = true;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(660, 34);
            this.txtPreco.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(65, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnCadastrar);
            // 
            // dtInstrumentos
            // 
            this.dtInstrumentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtInstrumentos.BackgroundColor = System.Drawing.Color.White;
            this.dtInstrumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtInstrumentos.Location = new System.Drawing.Point(65, 433);
            this.dtInstrumentos.MultiSelect = false;
            this.dtInstrumentos.Name = "dtInstrumentos";
            this.dtInstrumentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtInstrumentos.RowTemplate.Height = 25;
            this.dtInstrumentos.RowTemplate.ReadOnly = true;
            this.dtInstrumentos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtInstrumentos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtInstrumentos.Size = new System.Drawing.Size(831, 200);
            this.dtInstrumentos.TabIndex = 11;
            this.dtInstrumentos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtInstrumentos_CellMouseDoubleClick);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Purple;
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAlterar.Location = new System.Drawing.Point(385, 376);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(191, 36);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.Purple;
            this.btnDeletar.Enabled = false;
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletar.ForeColor = System.Drawing.Color.White;
            this.btnDeletar.Location = new System.Drawing.Point(705, 376);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(191, 36);
            this.btnDeletar.TabIndex = 13;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // CrudWFInstrumentos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(940, 645);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dtInstrumentos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.label1);
            this.Name = "CrudWFInstrumentos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtInstrumentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtInstrumentos;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDeletar;
    }
}

