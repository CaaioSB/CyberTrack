namespace CYBERTRACK_DESKTOP
{
    partial class FrmCyberTrack
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
            this.flowEventos = new System.Windows.Forms.FlowLayoutPanel();
            this.boxEvento1 = new CSBComponents.Component.BoxEvento();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHDataHora = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.iconArrival = new CSBComponents.Component.uiPicture();
            this.iconDeparture = new CSBComponents.Component.uiPicture();
            this.iconClock = new CSBComponents.Component.uiPicture();
            this.uiFlowPanel4 = new CSBComponents.Component.uiFlowPanel();
            this.uiFlowPanel2 = new CSBComponents.Component.uiFlowPanel();
            this.uiFlowPanel3 = new CSBComponents.Component.uiFlowPanel();
            this.uiHeader1 = new CSBComponents.Component.uiHeader();
            this.btnAdd = new CSBComponents.Component.uiPicture();
            this.txtTitulo = new CSBComponents.Component.uiTextBox();
            this.txtCodigoRastreio = new CSBComponents.Component.uiTextBox();
            this.uiButton1 = new CSBComponents.Component.uiButton();
            this.uiFlowEncomendas = new CSBComponents.Component.uiFlowPanel();
            this.flowEventos.SuspendLayout();
            this.boxEvento1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconArrival)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconDeparture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClock)).BeginInit();
            this.uiHeader1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // flowEventos
            // 
            this.flowEventos.AutoScroll = true;
            this.flowEventos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.flowEventos.Controls.Add(this.boxEvento1);
            this.flowEventos.Location = new System.Drawing.Point(225, 50);
            this.flowEventos.Name = "flowEventos";
            this.flowEventos.Size = new System.Drawing.Size(569, 393);
            this.flowEventos.TabIndex = 4;
            // 
            // boxEvento1
            // 
            this.boxEvento1.BackColor = System.Drawing.Color.White;
            this.boxEvento1.Controls.Add(this.label6);
            this.boxEvento1.Controls.Add(this.label5);
            this.boxEvento1.Controls.Add(this.lblHDataHora);
            this.boxEvento1.Controls.Add(this.label3);
            this.boxEvento1.Controls.Add(this.label2);
            this.boxEvento1.Controls.Add(this.lblDataHora);
            this.boxEvento1.Controls.Add(this.iconArrival);
            this.boxEvento1.Controls.Add(this.iconDeparture);
            this.boxEvento1.Controls.Add(this.iconClock);
            this.boxEvento1.LabelData = "";
            this.boxEvento1.LabelDestino = "";
            this.boxEvento1.LabelOrigem = "";
            this.boxEvento1.LabelStatus = "";
            this.boxEvento1.Location = new System.Drawing.Point(3, 3);
            this.boxEvento1.Name = "boxEvento1";
            this.boxEvento1.Size = new System.Drawing.Size(535, 122);
            this.boxEvento1.TabIndex = 0;
            this.boxEvento1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(307, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "DESTINO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(55, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "ORIGEM";
            // 
            // lblHDataHora
            // 
            this.lblHDataHora.AutoSize = true;
            this.lblHDataHora.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHDataHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblHDataHora.Location = new System.Drawing.Point(55, 27);
            this.lblHDataHora.Name = "lblHDataHora";
            this.lblHDataHora.Size = new System.Drawing.Size(90, 18);
            this.lblHDataHora.TabIndex = 11;
            this.lblHDataHora.Text = "DATA/HORA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 42);
            this.label3.TabIndex = 10;
            this.label3.Text = "DESTINO\r\nDESTINO 2\r\nDESTINO 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "ORIGEM";
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataHora.Location = new System.Drawing.Point(55, 45);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(67, 14);
            this.lblDataHora.TabIndex = 1;
            this.lblDataHora.Text = "DATA/HORA";
            // 
            // iconArrival
            // 
            this.iconArrival.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(94)))), ((int)(((byte)(0)))));
            this.iconArrival.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(94)))), ((int)(((byte)(0)))));
            this.iconArrival.IconChar = FontAwesome.Sharp.IconChar.PlaneArrival;
            this.iconArrival.IconColor = System.Drawing.Color.White;
            this.iconArrival.IconSize = 40;
            this.iconArrival.Location = new System.Drawing.Point(259, 30);
            this.iconArrival.Name = "iconArrival";
            this.iconArrival.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(94)))), ((int)(((byte)(0)))));
            this.iconArrival.Rounded = true;
            this.iconArrival.Size = new System.Drawing.Size(42, 40);
            this.iconArrival.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconArrival.TabIndex = 8;
            this.iconArrival.TabStop = false;
            this.iconArrival.uiSize = 40;
            // 
            // iconDeparture
            // 
            this.iconDeparture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(94)))), ((int)(((byte)(0)))));
            this.iconDeparture.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(94)))), ((int)(((byte)(0)))));
            this.iconDeparture.IconChar = FontAwesome.Sharp.IconChar.PlaneDeparture;
            this.iconDeparture.IconColor = System.Drawing.Color.White;
            this.iconDeparture.IconSize = 40;
            this.iconDeparture.Location = new System.Drawing.Point(7, 76);
            this.iconDeparture.Name = "iconDeparture";
            this.iconDeparture.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(94)))), ((int)(((byte)(0)))));
            this.iconDeparture.Rounded = true;
            this.iconDeparture.Size = new System.Drawing.Size(42, 40);
            this.iconDeparture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconDeparture.TabIndex = 6;
            this.iconDeparture.TabStop = false;
            this.iconDeparture.uiSize = 40;
            // 
            // iconClock
            // 
            this.iconClock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(94)))), ((int)(((byte)(0)))));
            this.iconClock.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(94)))), ((int)(((byte)(0)))));
            this.iconClock.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.iconClock.IconColor = System.Drawing.Color.White;
            this.iconClock.IconSize = 40;
            this.iconClock.Location = new System.Drawing.Point(7, 30);
            this.iconClock.Name = "iconClock";
            this.iconClock.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(94)))), ((int)(((byte)(0)))));
            this.iconClock.Rounded = true;
            this.iconClock.Size = new System.Drawing.Size(42, 40);
            this.iconClock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconClock.TabIndex = 5;
            this.iconClock.TabStop = false;
            this.iconClock.uiSize = 40;
            // 
            // uiFlowPanel4
            // 
            this.uiFlowPanel4.AutoScroll = true;
            this.uiFlowPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(94)))), ((int)(((byte)(0)))));
            this.uiFlowPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiFlowPanel4.FlowPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(94)))), ((int)(((byte)(0)))));
            this.uiFlowPanel4.Location = new System.Drawing.Point(0, 50);
            this.uiFlowPanel4.Name = "uiFlowPanel4";
            this.uiFlowPanel4.Size = new System.Drawing.Size(6, 393);
            this.uiFlowPanel4.TabIndex = 3;
            // 
            // uiFlowPanel2
            // 
            this.uiFlowPanel2.AutoScroll = true;
            this.uiFlowPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(94)))), ((int)(((byte)(0)))));
            this.uiFlowPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiFlowPanel2.FlowPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(94)))), ((int)(((byte)(0)))));
            this.uiFlowPanel2.Location = new System.Drawing.Point(0, 443);
            this.uiFlowPanel2.Name = "uiFlowPanel2";
            this.uiFlowPanel2.Size = new System.Drawing.Size(800, 7);
            this.uiFlowPanel2.TabIndex = 1;
            // 
            // uiFlowPanel3
            // 
            this.uiFlowPanel3.AutoScroll = true;
            this.uiFlowPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(94)))), ((int)(((byte)(0)))));
            this.uiFlowPanel3.FlowPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(94)))), ((int)(((byte)(0)))));
            this.uiFlowPanel3.Location = new System.Drawing.Point(794, 50);
            this.uiFlowPanel3.Name = "uiFlowPanel3";
            this.uiFlowPanel3.Size = new System.Drawing.Size(6, 401);
            this.uiFlowPanel3.TabIndex = 2;
            // 
            // uiHeader1
            // 
            this.uiHeader1.Controls.Add(this.btnAdd);
            this.uiHeader1.Controls.Add(this.txtTitulo);
            this.uiHeader1.Controls.Add(this.txtCodigoRastreio);
            this.uiHeader1.Controls.Add(this.uiButton1);
            this.uiHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiHeader1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(94)))), ((int)(((byte)(0)))));
            this.uiHeader1.HeaderImage = global::CYBERTRACK_DESKTOP.Properties.Resources.CyberTrack;
            this.uiHeader1.HeaderPictureSizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uiHeader1.HeaderRadius = 5;
            this.uiHeader1.Location = new System.Drawing.Point(0, 0);
            this.uiHeader1.Name = "uiHeader1";
            this.uiHeader1.Size = new System.Drawing.Size(800, 50);
            this.uiHeader1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(1)))));
            this.btnAdd.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(1)))));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.btnAdd.IconColor = System.Drawing.Color.White;
            this.btnAdd.IconSize = 23;
            this.btnAdd.Location = new System.Drawing.Point(725, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAdd.Rounded = true;
            this.btnAdd.Size = new System.Drawing.Size(25, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.TabStop = false;
            this.btnAdd.uiSize = 25;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(1)))));
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.LightGray;
            this.txtTitulo.Location = new System.Drawing.Point(339, 14);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PlaceHolder = "DESCRIÇÃO DO OBJETO";
            this.txtTitulo.Size = new System.Drawing.Size(194, 19);
            this.txtTitulo.TabIndex = 4;
            this.txtTitulo.TabStop = false;
            this.txtTitulo.Text = "DESCRIÇÃO DO OBJETO";
            this.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTitulo.ValidadeType = CSBComponents.Component.uiTextBox.Validate.None;
            // 
            // txtCodigoRastreio
            // 
            this.txtCodigoRastreio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(1)))));
            this.txtCodigoRastreio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoRastreio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoRastreio.ForeColor = System.Drawing.Color.LightGray;
            this.txtCodigoRastreio.Location = new System.Drawing.Point(539, 14);
            this.txtCodigoRastreio.Name = "txtCodigoRastreio";
            this.txtCodigoRastreio.PlaceHolder = "CÓDIGO DE RASTREIO";
            this.txtCodigoRastreio.Size = new System.Drawing.Size(182, 19);
            this.txtCodigoRastreio.TabIndex = 1;
            this.txtCodigoRastreio.TabStop = false;
            this.txtCodigoRastreio.Text = "CÓDIGO DE RASTREIO";
            this.txtCodigoRastreio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigoRastreio.ValidadeType = CSBComponents.Component.uiTextBox.Validate.None;
            // 
            // uiButton1
            // 
            this.uiButton1.BorderColor = System.Drawing.Color.Transparent;
            this.uiButton1.BorderRadius = 15;
            this.uiButton1.ButtonColor = System.Drawing.Color.Maroon;
            this.uiButton1.FlatAppearance.BorderSize = 0;
            this.uiButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.uiButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.uiButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiButton1.Location = new System.Drawing.Point(758, 10);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.OnHoverBorderColor = System.Drawing.Color.White;
            this.uiButton1.OnHoverButtonColor = System.Drawing.Color.DarkRed;
            this.uiButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.uiButton1.Size = new System.Drawing.Size(30, 30);
            this.uiButton1.TabIndex = 1;
            this.uiButton1.TextColor = System.Drawing.Color.White;
            this.uiButton1.UseVisualStyleBackColor = true;
            // 
            // uiFlowEncomendas
            // 
            this.uiFlowEncomendas.AutoScroll = true;
            this.uiFlowEncomendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(1)))));
            this.uiFlowEncomendas.FlowPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(1)))));
            this.uiFlowEncomendas.Location = new System.Drawing.Point(6, 50);
            this.uiFlowEncomendas.Name = "uiFlowEncomendas";
            this.uiFlowEncomendas.Size = new System.Drawing.Size(219, 393);
            this.uiFlowEncomendas.TabIndex = 0;
            // 
            // FrmCyberTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowEventos);
            this.Controls.Add(this.uiFlowPanel4);
            this.Controls.Add(this.uiFlowPanel2);
            this.Controls.Add(this.uiFlowPanel3);
            this.Controls.Add(this.uiHeader1);
            this.Controls.Add(this.uiFlowEncomendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCyberTrack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCyberTrack_Load);
            this.flowEventos.ResumeLayout(false);
            this.boxEvento1.ResumeLayout(false);
            this.boxEvento1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconArrival)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconDeparture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClock)).EndInit();
            this.uiHeader1.ResumeLayout(false);
            this.uiHeader1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CSBComponents.Component.uiHeader uiHeader1;
        private CSBComponents.Component.uiButton uiButton1;
        private CSBComponents.Component.uiFlowPanel uiFlowEncomendas;
        private CSBComponents.Component.uiTextBox txtCodigoRastreio;
        private CSBComponents.Component.uiTextBox txtTitulo;
        private CSBComponents.Component.uiPicture btnAdd;
        private CSBComponents.Component.uiFlowPanel uiFlowPanel2;
        private CSBComponents.Component.uiFlowPanel uiFlowPanel3;
        private CSBComponents.Component.uiFlowPanel uiFlowPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowEventos;
        private CSBComponents.Component.BoxEvento boxEvento1;
        private CSBComponents.Component.uiPicture iconClock;
        private CSBComponents.Component.uiPicture iconDeparture;
        private CSBComponents.Component.uiPicture iconArrival;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHDataHora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

