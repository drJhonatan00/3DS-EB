namespace WindowsFormsApp10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRebuild3DS = new System.Windows.Forms.Button();
            this.btnRebuildCIA = new System.Windows.Forms.Button();
            this.btnExtractCIA = new System.Windows.Forms.Button();
            this.btnMassExtract = new System.Windows.Forms.Button();
            this.btnMassRebuild = new System.Windows.Forms.Button();
            this.btnExtractCXI = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnRebuildBanner = new System.Windows.Forms.Button();
            this.btnExtractBanner = new System.Windows.Forms.Button();
            this.btnExtractFilePartition = new System.Windows.Forms.Button();
            this.btnExtractNCCH = new System.Windows.Forms.Button();
            this.txtNomeArquivo = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLang = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(88, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 119);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 64);
            this.button1.TabIndex = 5;
            this.button1.Text = "Extrair arquivo .3DS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRebuild3DS
            // 
            this.btnRebuild3DS.Location = new System.Drawing.Point(265, 57);
            this.btnRebuild3DS.Name = "btnRebuild3DS";
            this.btnRebuild3DS.Size = new System.Drawing.Size(213, 64);
            this.btnRebuild3DS.TabIndex = 6;
            this.btnRebuild3DS.Text = "Compilar arquivo .3DS";
            this.btnRebuild3DS.UseVisualStyleBackColor = true;
            this.btnRebuild3DS.Click += new System.EventHandler(this.btnRebuild3DS_Click);
            // 
            // btnRebuildCIA
            // 
            this.btnRebuildCIA.Location = new System.Drawing.Point(265, 138);
            this.btnRebuildCIA.Name = "btnRebuildCIA";
            this.btnRebuildCIA.Size = new System.Drawing.Size(213, 64);
            this.btnRebuildCIA.TabIndex = 8;
            this.btnRebuildCIA.Text = "Compilar arquivo .CIA";
            this.btnRebuildCIA.UseVisualStyleBackColor = true;
            this.btnRebuildCIA.Click += new System.EventHandler(this.btnRebuildCIA_Click);
            // 
            // btnExtractCIA
            // 
            this.btnExtractCIA.Location = new System.Drawing.Point(34, 138);
            this.btnExtractCIA.Name = "btnExtractCIA";
            this.btnExtractCIA.Size = new System.Drawing.Size(213, 64);
            this.btnExtractCIA.TabIndex = 7;
            this.btnExtractCIA.Text = "Extrair arquivo .CIA";
            this.btnExtractCIA.UseVisualStyleBackColor = true;
            this.btnExtractCIA.Click += new System.EventHandler(this.btnExtractCIA_Click);
            // 
            // btnMassExtract
            // 
            this.btnMassExtract.Location = new System.Drawing.Point(34, 218);
            this.btnMassExtract.Name = "btnMassExtract";
            this.btnMassExtract.Size = new System.Drawing.Size(213, 64);
            this.btnMassExtract.TabIndex = 9;
            this.btnMassExtract.Text = "Extrair Massivo";
            this.btnMassExtract.UseVisualStyleBackColor = true;
            this.btnMassExtract.Click += new System.EventHandler(this.btnMassExtract_Click);
            // 
            // btnMassRebuild
            // 
            this.btnMassRebuild.Location = new System.Drawing.Point(265, 218);
            this.btnMassRebuild.Name = "btnMassRebuild";
            this.btnMassRebuild.Size = new System.Drawing.Size(213, 64);
            this.btnMassRebuild.TabIndex = 10;
            this.btnMassRebuild.Text = "Compilar Massivo";
            this.btnMassRebuild.UseVisualStyleBackColor = true;
            this.btnMassRebuild.Click += new System.EventHandler(this.btnMassRebuild_Click);
            // 
            // btnExtractCXI
            // 
            this.btnExtractCXI.Location = new System.Drawing.Point(34, 463);
            this.btnExtractCXI.Name = "btnExtractCXI";
            this.btnExtractCXI.Size = new System.Drawing.Size(213, 64);
            this.btnExtractCXI.TabIndex = 11;
            this.btnExtractCXI.Text = "Extrair arquivo .CXI";
            this.btnExtractCXI.UseVisualStyleBackColor = true;
            this.btnExtractCXI.Click += new System.EventHandler(this.btnExtractCXI_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-136, -91);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(334, 317);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(-89, 427);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(334, 317);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // btnRebuildBanner
            // 
            this.btnRebuildBanner.Location = new System.Drawing.Point(265, 300);
            this.btnRebuildBanner.Name = "btnRebuildBanner";
            this.btnRebuildBanner.Size = new System.Drawing.Size(213, 64);
            this.btnRebuildBanner.TabIndex = 16;
            this.btnRebuildBanner.Text = "Compilar Banner Descriptografado";
            this.btnRebuildBanner.UseVisualStyleBackColor = true;
            this.btnRebuildBanner.Click += new System.EventHandler(this.btnRebuildBanner_Click);
            // 
            // btnExtractBanner
            // 
            this.btnExtractBanner.Location = new System.Drawing.Point(34, 300);
            this.btnExtractBanner.Name = "btnExtractBanner";
            this.btnExtractBanner.Size = new System.Drawing.Size(213, 64);
            this.btnExtractBanner.TabIndex = 15;
            this.btnExtractBanner.Text = "Extrair Banner Descriptografado";
            this.btnExtractBanner.UseVisualStyleBackColor = true;
            this.btnExtractBanner.Click += new System.EventHandler(this.btnExtractBanner_Click);
            // 
            // btnExtractFilePartition
            // 
            this.btnExtractFilePartition.Location = new System.Drawing.Point(265, 382);
            this.btnExtractFilePartition.Name = "btnExtractFilePartition";
            this.btnExtractFilePartition.Size = new System.Drawing.Size(213, 64);
            this.btnExtractFilePartition.TabIndex = 18;
            this.btnExtractFilePartition.Text = "Extrair Partição de Arquivo";
            this.btnExtractFilePartition.UseVisualStyleBackColor = true;
            this.btnExtractFilePartition.Click += new System.EventHandler(this.btnExtractFilePartition_Click);
            // 
            // btnExtractNCCH
            // 
            this.btnExtractNCCH.Location = new System.Drawing.Point(34, 382);
            this.btnExtractNCCH.Name = "btnExtractNCCH";
            this.btnExtractNCCH.Size = new System.Drawing.Size(213, 64);
            this.btnExtractNCCH.TabIndex = 17;
            this.btnExtractNCCH.Text = "Extrair Partição NCCH";
            this.btnExtractNCCH.UseVisualStyleBackColor = true;
            this.btnExtractNCCH.Click += new System.EventHandler(this.btnExtractNCCH_Click);
            // 
            // txtNomeArquivo
            // 
            this.txtNomeArquivo.Location = new System.Drawing.Point(15, 303);
            this.txtNomeArquivo.Name = "txtNomeArquivo";
            this.txtNomeArquivo.Size = new System.Drawing.Size(320, 20);
            this.txtNomeArquivo.TabIndex = 22;
            // 
            // txtLog
            // 
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.Location = new System.Drawing.Point(34, 170);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(229, 393);
            this.txtLog.TabIndex = 23;
            this.txtLog.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnLang);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtLog);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(922, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 624);
            this.panel1.TabIndex = 24;
            // 
            // btnLang
            // 
            this.btnLang.BackColor = System.Drawing.Color.Transparent;
            this.btnLang.Location = new System.Drawing.Point(34, 573);
            this.btnLang.Name = "btnLang";
            this.btnLang.Size = new System.Drawing.Size(229, 32);
            this.btnLang.TabIndex = 21;
            this.btnLang.Text = "Trocar Idioma";
            this.btnLang.UseVisualStyleBackColor = false;
            this.btnLang.Click += new System.EventHandler(this.btnLang_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(30, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Relatório";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(12, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Digite o nome do arquivo (sem extensão)";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnExtractFilePartition);
            this.panel2.Controls.Add(this.btnExtractNCCH);
            this.panel2.Controls.Add(this.btnRebuildBanner);
            this.panel2.Controls.Add(this.btnExtractBanner);
            this.panel2.Controls.Add(this.btnExtractCXI);
            this.panel2.Controls.Add(this.btnMassRebuild);
            this.panel2.Controls.Add(this.btnMassExtract);
            this.panel2.Controls.Add(this.btnRebuildCIA);
            this.panel2.Controls.Add(this.btnExtractCIA);
            this.panel2.Controls.Add(this.btnRebuild3DS);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(380, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 624);
            this.panel2.TabIndex = 26;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(3, 599);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 16);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(29, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Escolha uma Opção";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(720, 346);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(334, 317);
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(771, 24);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(334, 317);
            this.pictureBox5.TabIndex = 28;
            this.pictureBox5.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1208, 616);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeArquivo);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "3DS-EB";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRebuild3DS;
        private System.Windows.Forms.Button btnRebuildCIA;
        private System.Windows.Forms.Button btnExtractCIA;
        private System.Windows.Forms.Button btnMassExtract;
        private System.Windows.Forms.Button btnMassRebuild;
        private System.Windows.Forms.Button btnExtractCXI;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnRebuildBanner;
        private System.Windows.Forms.Button btnExtractBanner;
        private System.Windows.Forms.Button btnExtractFilePartition;
        private System.Windows.Forms.Button btnExtractNCCH;
        private System.Windows.Forms.TextBox txtNomeArquivo;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLang;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblStatus;
    }
}