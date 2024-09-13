
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
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCalculadora = new System.Windows.Forms.Panel();
            this.pnlIMC = new System.Windows.Forms.Panel();
            this.pnlCombustivel = new System.Windows.Forms.Panel();
            this.pnlFolhaPagamento = new System.Windows.Forms.Panel();
            this.pnlTaxaFrequencia = new System.Windows.Forms.Panel();
            this.pnlConversor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIMC = new System.Windows.Forms.Button();
            this.btnCombustivel = new System.Windows.Forms.Button();
            this.btnFolhaPagamento = new System.Windows.Forms.Button();
            this.btnTaxaFrequencia = new System.Windows.Forms.Button();
            this.btnConversorMoedas = new System.Windows.Forms.Button();
            this.btnConsumoAgua = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.pnlBarraRolagem.SuspendLayout();
            this.flpMenu.SuspendLayout();
            this.pnlCalculadora.SuspendLayout();
            this.pnlIMC.SuspendLayout();
            this.pnlCombustivel.SuspendLayout();
            this.pnlFolhaPagamento.SuspendLayout();
            this.pnlTaxaFrequencia.SuspendLayout();
            this.pnlConversor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraRolagem
            // 
            this.pnlBarraRolagem.Controls.Add(this.label1);
            this.pnlBarraRolagem.Controls.Add(this.btnSair);
            this.pnlBarraRolagem.Controls.Add(this.pictureBox1);
            this.pnlBarraRolagem.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBarraRolagem.Location = new System.Drawing.Point(643, 0);
            this.pnlBarraRolagem.Name = "pnlBarraRolagem";
            this.pnlBarraRolagem.Size = new System.Drawing.Size(141, 645);
            this.pnlBarraRolagem.TabIndex = 0;
            this.pnlBarraRolagem.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBarraRolagem_Paint);
            // 
            // flpMenu
            // 
            this.flpMenu.AutoScroll = true;
            this.flpMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flpMenu.Controls.Add(this.pnlCalculadora);
            this.flpMenu.Controls.Add(this.pnlIMC);
            this.flpMenu.Controls.Add(this.pnlCombustivel);
            this.flpMenu.Controls.Add(this.btnFolhaPagamento);
            this.flpMenu.Controls.Add(this.pnlFolhaPagamento);
            this.flpMenu.Controls.Add(this.pnlTaxaFrequencia);
            this.flpMenu.Controls.Add(this.pnlConversor);
            this.flpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMenu.Location = new System.Drawing.Point(0, 0);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Size = new System.Drawing.Size(643, 645);
            this.flpMenu.TabIndex = 1;
            this.flpMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // pnlCalculadora
            // 
            this.pnlCalculadora.Controls.Add(this.btnCalculadora);
            this.pnlCalculadora.Location = new System.Drawing.Point(3, 3);
            this.pnlCalculadora.Name = "pnlCalculadora";
            this.pnlCalculadora.Size = new System.Drawing.Size(202, 315);
            this.pnlCalculadora.TabIndex = 0;
            // 
            // pnlIMC
            // 
            this.pnlIMC.Controls.Add(this.btnIMC);
            this.pnlIMC.Location = new System.Drawing.Point(211, 3);
            this.pnlIMC.Name = "pnlIMC";
            this.pnlIMC.Size = new System.Drawing.Size(202, 315);
            this.pnlIMC.TabIndex = 1;
            // 
            // pnlCombustivel
            // 
            this.pnlCombustivel.Controls.Add(this.btnCombustivel);
            this.pnlCombustivel.Location = new System.Drawing.Point(419, 3);
            this.pnlCombustivel.Name = "pnlCombustivel";
            this.pnlCombustivel.Size = new System.Drawing.Size(202, 315);
            this.pnlCombustivel.TabIndex = 3;
            // 
            // pnlFolhaPagamento
            // 
            this.pnlFolhaPagamento.Controls.Add(this.btnTaxaFrequencia);
            this.pnlFolhaPagamento.Location = new System.Drawing.Point(211, 324);
            this.pnlFolhaPagamento.Name = "pnlFolhaPagamento";
            this.pnlFolhaPagamento.Size = new System.Drawing.Size(202, 315);
            this.pnlFolhaPagamento.TabIndex = 2;
            // 
            // pnlTaxaFrequencia
            // 
            this.pnlTaxaFrequencia.Controls.Add(this.btnConversorMoedas);
            this.pnlTaxaFrequencia.Location = new System.Drawing.Point(419, 324);
            this.pnlTaxaFrequencia.Name = "pnlTaxaFrequencia";
            this.pnlTaxaFrequencia.Size = new System.Drawing.Size(202, 315);
            this.pnlTaxaFrequencia.TabIndex = 5;
            // 
            // pnlConversor
            // 
            this.pnlConversor.Controls.Add(this.btnConsumoAgua);
            this.pnlConversor.Location = new System.Drawing.Point(3, 645);
            this.pnlConversor.Name = "pnlConversor";
            this.pnlConversor.Size = new System.Drawing.Size(202, 315);
            this.pnlConversor.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seja Bem Vindo";
            // 
            // btnIMC
            // 
            this.btnIMC.BackgroundImage = global::Calculadoras_CSharp_Jw.Properties.Resources.exercise_sport_walk_icon_133362;
            this.btnIMC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIMC.Location = new System.Drawing.Point(0, 3);
            this.btnIMC.Name = "btnIMC";
            this.btnIMC.Size = new System.Drawing.Size(202, 315);
            this.btnIMC.TabIndex = 1;
            this.btnIMC.Text = "IMC";
            this.btnIMC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIMC.UseVisualStyleBackColor = true;
            // 
            // btnCombustivel
            // 
            this.btnCombustivel.BackgroundImage = global::Calculadoras_CSharp_Jw.Properties.Resources._42568fuelpump_98960;
            this.btnCombustivel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCombustivel.Location = new System.Drawing.Point(0, 3);
            this.btnCombustivel.Name = "btnCombustivel";
            this.btnCombustivel.Size = new System.Drawing.Size(202, 315);
            this.btnCombustivel.TabIndex = 2;
            this.btnCombustivel.Text = "Combustivel";
            this.btnCombustivel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCombustivel.UseVisualStyleBackColor = true;
            // 
            // btnFolhaPagamento
            // 
            this.btnFolhaPagamento.BackgroundImage = global::Calculadoras_CSharp_Jw.Properties.Resources.payment_pay_check_icon_143278;
            this.btnFolhaPagamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFolhaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFolhaPagamento.Location = new System.Drawing.Point(3, 324);
            this.btnFolhaPagamento.Name = "btnFolhaPagamento";
            this.btnFolhaPagamento.Size = new System.Drawing.Size(202, 315);
            this.btnFolhaPagamento.TabIndex = 3;
            this.btnFolhaPagamento.Text = "Folha de Pagamento";
            this.btnFolhaPagamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFolhaPagamento.UseVisualStyleBackColor = true;
            // 
            // btnTaxaFrequencia
            // 
            this.btnTaxaFrequencia.BackgroundImage = global::Calculadoras_CSharp_Jw.Properties.Resources.freelance_freelancer_occupation_job_worker_icon_142264;
            this.btnTaxaFrequencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTaxaFrequencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaxaFrequencia.Location = new System.Drawing.Point(0, 3);
            this.btnTaxaFrequencia.Name = "btnTaxaFrequencia";
            this.btnTaxaFrequencia.Size = new System.Drawing.Size(202, 315);
            this.btnTaxaFrequencia.TabIndex = 4;
            this.btnTaxaFrequencia.Text = "Taxa de Frequência";
            this.btnTaxaFrequencia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTaxaFrequencia.UseVisualStyleBackColor = true;
            // 
            // btnConversorMoedas
            // 
            this.btnConversorMoedas.BackgroundImage = global::Calculadoras_CSharp_Jw.Properties.Resources.coins_icon_129479;
            this.btnConversorMoedas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConversorMoedas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConversorMoedas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConversorMoedas.Location = new System.Drawing.Point(0, 3);
            this.btnConversorMoedas.Name = "btnConversorMoedas";
            this.btnConversorMoedas.Size = new System.Drawing.Size(202, 315);
            this.btnConversorMoedas.TabIndex = 5;
            this.btnConversorMoedas.Text = "Conversor de Moedas";
            this.btnConversorMoedas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConversorMoedas.UseVisualStyleBackColor = true;
            // 
            // btnConsumoAgua
            // 
            this.btnConsumoAgua.BackgroundImage = global::Calculadoras_CSharp_Jw.Properties.Resources.water_climate_forecast_weather_sea_ocean_low_tide_icon_226613;
            this.btnConsumoAgua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConsumoAgua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsumoAgua.Location = new System.Drawing.Point(0, 3);
            this.btnConsumoAgua.Name = "btnConsumoAgua";
            this.btnConsumoAgua.Size = new System.Drawing.Size(202, 315);
            this.btnConsumoAgua.TabIndex = 6;
            this.btnConsumoAgua.Text = "Consumo de Àgua";
            this.btnConsumoAgua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsumoAgua.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.BackgroundImage = global::Calculadoras_CSharp_Jw.Properties.Resources.exit_icon_143601;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Location = new System.Drawing.Point(13, 546);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(116, 87);
            this.btnSair.TabIndex = 5;
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.ErrorImage = global::Calculadoras_CSharp_Jw.Properties.Resources.Calculator_Icon_icon_icons_com_76430;
            this.pictureBox1.Image = global::Calculadoras_CSharp_Jw.Properties.Resources.c_letter_letters_alphabet_icon_208972;
            this.pictureBox1.Location = new System.Drawing.Point(19, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnCalculadora.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalculadora.BackgroundImage")));
            this.btnCalculadora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCalculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculadora.Location = new System.Drawing.Point(1, 3);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(202, 315);
            this.btnCalculadora.TabIndex = 0;
            this.btnCalculadora.Text = "Calculadora";
            this.btnCalculadora.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalculadora.UseVisualStyleBackColor = false;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 645);
            this.Controls.Add(this.flpMenu);
            this.Controls.Add(this.pnlBarraRolagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.Text = "Calculadoras";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlBarraRolagem.ResumeLayout(false);
            this.pnlBarraRolagem.PerformLayout();
            this.flpMenu.ResumeLayout(false);
            this.pnlCalculadora.ResumeLayout(false);
            this.pnlIMC.ResumeLayout(false);
            this.pnlCombustivel.ResumeLayout(false);
            this.pnlFolhaPagamento.ResumeLayout(false);
            this.pnlTaxaFrequencia.ResumeLayout(false);
            this.pnlConversor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraRolagem;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.Panel pnlCalculadora;
        private System.Windows.Forms.Panel pnlIMC;
        private System.Windows.Forms.Panel pnlCombustivel;
        private System.Windows.Forms.Panel pnlFolhaPagamento;
        private System.Windows.Forms.Panel pnlTaxaFrequencia;
        private System.Windows.Forms.Panel pnlConversor;
        private System.Windows.Forms.Button btnIMC;
        private System.Windows.Forms.Button btnCombustivel;
        private System.Windows.Forms.Button btnFolhaPagamento;
        private System.Windows.Forms.Button btnTaxaFrequencia;
        private System.Windows.Forms.Button btnConversorMoedas;
        private System.Windows.Forms.Button btnConsumoAgua;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculadora;
    }
}

