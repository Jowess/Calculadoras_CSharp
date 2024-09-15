
namespace Calculadoras_CSharp_Jw
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.pnlBarraRolagem = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.btnIMC = new System.Windows.Forms.Button();
            this.btnCombustivel = new System.Windows.Forms.Button();
            this.btnFolhaPagamento = new System.Windows.Forms.Button();
            this.btnTaxaFrequencia = new System.Windows.Forms.Button();
            this.btnConversor = new System.Windows.Forms.Button();
            this.btnAgua = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlBarraRolagem.SuspendLayout();
            this.flpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraRolagem
            // 
            this.pnlBarraRolagem.Controls.Add(this.label1);
            this.pnlBarraRolagem.Controls.Add(this.btnSair);
            this.pnlBarraRolagem.Controls.Add(this.pictureBox1);
            this.pnlBarraRolagem.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBarraRolagem.Location = new System.Drawing.Point(857, 0);
            this.pnlBarraRolagem.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBarraRolagem.Name = "pnlBarraRolagem";
            this.pnlBarraRolagem.Size = new System.Drawing.Size(188, 799);
            this.pnlBarraRolagem.TabIndex = 0;
            this.pnlBarraRolagem.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBarraRolagem_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 298);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seja Bem Vindo";
            // 
            // flpMenu
            // 
            this.flpMenu.AutoScroll = true;
            this.flpMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flpMenu.Controls.Add(this.btnCalculadora);
            this.flpMenu.Controls.Add(this.btnIMC);
            this.flpMenu.Controls.Add(this.btnCombustivel);
            this.flpMenu.Controls.Add(this.btnFolhaPagamento);
            this.flpMenu.Controls.Add(this.btnTaxaFrequencia);
            this.flpMenu.Controls.Add(this.btnConversor);
            this.flpMenu.Controls.Add(this.btnAgua);
            this.flpMenu.Location = new System.Drawing.Point(13, 46);
            this.flpMenu.Margin = new System.Windows.Forms.Padding(4);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Size = new System.Drawing.Size(823, 717);
            this.flpMenu.TabIndex = 1;
            this.flpMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCalculadora.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalculadora.BackgroundImage")));
            this.btnCalculadora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCalculadora.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculadora.ForeColor = System.Drawing.Color.White;
            this.btnCalculadora.Location = new System.Drawing.Point(4, 4);
            this.btnCalculadora.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(256, 311);
            this.btnCalculadora.TabIndex = 5;
            this.btnCalculadora.Text = "Calculadora";
            this.btnCalculadora.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalculadora.UseVisualStyleBackColor = false;
            // 
            // btnIMC
            // 
            this.btnIMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIMC.BackgroundImage = global::Calculadoras_CSharp_Jw.Properties.Resources._357_exercise_i_1024082;
            this.btnIMC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIMC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIMC.ForeColor = System.Drawing.Color.White;
            this.btnIMC.Location = new System.Drawing.Point(268, 4);
            this.btnIMC.Margin = new System.Windows.Forms.Padding(4);
            this.btnIMC.Name = "btnIMC";
            this.btnIMC.Size = new System.Drawing.Size(256, 306);
            this.btnIMC.TabIndex = 6;
            this.btnIMC.Text = "IMC";
            this.btnIMC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIMC.UseVisualStyleBackColor = false;
            // 
            // btnCombustivel
            // 
            this.btnCombustivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCombustivel.BackgroundImage = global::Calculadoras_CSharp_Jw.Properties.Resources.petrol_can_icon_2275532;
            this.btnCombustivel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCombustivel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCombustivel.ForeColor = System.Drawing.Color.White;
            this.btnCombustivel.Location = new System.Drawing.Point(532, 4);
            this.btnCombustivel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCombustivel.Name = "btnCombustivel";
            this.btnCombustivel.Size = new System.Drawing.Size(260, 306);
            this.btnCombustivel.TabIndex = 7;
            this.btnCombustivel.Text = "Combustivel";
            this.btnCombustivel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCombustivel.UseVisualStyleBackColor = false;
            // 
            // btnFolhaPagamento
            // 
            this.btnFolhaPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFolhaPagamento.BackgroundImage = global::Calculadoras_CSharp_Jw.Properties.Resources.payment_pay_check_icon_1432781;
            this.btnFolhaPagamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFolhaPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFolhaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFolhaPagamento.ForeColor = System.Drawing.Color.White;
            this.btnFolhaPagamento.Location = new System.Drawing.Point(4, 323);
            this.btnFolhaPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.btnFolhaPagamento.Name = "btnFolhaPagamento";
            this.btnFolhaPagamento.Size = new System.Drawing.Size(256, 311);
            this.btnFolhaPagamento.TabIndex = 8;
            this.btnFolhaPagamento.Text = "Folha de Pagamento";
            this.btnFolhaPagamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFolhaPagamento.UseVisualStyleBackColor = false;
            // 
            // btnTaxaFrequencia
            // 
            this.btnTaxaFrequencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTaxaFrequencia.BackgroundImage = global::Calculadoras_CSharp_Jw.Properties.Resources.freelance_freelancer_occupation_job_worker_icon_1422641;
            this.btnTaxaFrequencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTaxaFrequencia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTaxaFrequencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaxaFrequencia.ForeColor = System.Drawing.Color.White;
            this.btnTaxaFrequencia.Location = new System.Drawing.Point(268, 323);
            this.btnTaxaFrequencia.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaxaFrequencia.Name = "btnTaxaFrequencia";
            this.btnTaxaFrequencia.Size = new System.Drawing.Size(256, 311);
            this.btnTaxaFrequencia.TabIndex = 9;
            this.btnTaxaFrequencia.Text = "Taxa de Frequência";
            this.btnTaxaFrequencia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTaxaFrequencia.UseVisualStyleBackColor = false;
            // 
            // btnConversor
            // 
            this.btnConversor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConversor.BackgroundImage = global::Calculadoras_CSharp_Jw.Properties.Resources.coins_icon_1294791;
            this.btnConversor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConversor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConversor.ForeColor = System.Drawing.Color.White;
            this.btnConversor.Location = new System.Drawing.Point(532, 323);
            this.btnConversor.Margin = new System.Windows.Forms.Padding(4);
            this.btnConversor.Name = "btnConversor";
            this.btnConversor.Size = new System.Drawing.Size(260, 311);
            this.btnConversor.TabIndex = 10;
            this.btnConversor.Text = "Conversor de Moeda";
            this.btnConversor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConversor.UseVisualStyleBackColor = false;
            // 
            // btnAgua
            // 
            this.btnAgua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgua.BackgroundImage = global::Calculadoras_CSharp_Jw.Properties.Resources.water_climate_forecast_weather_sea_ocean_low_tide_icon_2266132;
            this.btnAgua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgua.ForeColor = System.Drawing.Color.White;
            this.btnAgua.Location = new System.Drawing.Point(4, 642);
            this.btnAgua.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgua.Name = "btnAgua";
            this.btnAgua.Size = new System.Drawing.Size(256, 311);
            this.btnAgua.TabIndex = 11;
            this.btnAgua.Text = "Folha de Pagamento";
            this.btnAgua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgua.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.BackgroundImage = global::Calculadoras_CSharp_Jw.Properties.Resources.exit_icon_143601;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Location = new System.Drawing.Point(43, 680);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(104, 60);
            this.btnSair.TabIndex = 5;
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.ErrorImage = global::Calculadoras_CSharp_Jw.Properties.Resources.Calculator_Icon_icon_icons_com_76430;
            this.pictureBox1.Image = global::Calculadoras_CSharp_Jw.Properties.Resources.c_letter_letters_alphabet_icon_208972;
            this.pictureBox1.Location = new System.Drawing.Point(15, 145);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1045, 799);
            this.Controls.Add(this.flpMenu);
            this.Controls.Add(this.pnlBarraRolagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.Text = "Calculadoras";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlBarraRolagem.ResumeLayout(false);
            this.pnlBarraRolagem.PerformLayout();
            this.flpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraRolagem;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculadora;
        private System.Windows.Forms.Button btnIMC;
        private System.Windows.Forms.Button btnCombustivel;
        private System.Windows.Forms.Button btnFolhaPagamento;
        private System.Windows.Forms.Button btnTaxaFrequencia;
        private System.Windows.Forms.Button btnConversor;
        private System.Windows.Forms.Button btnAgua;
    }
}

