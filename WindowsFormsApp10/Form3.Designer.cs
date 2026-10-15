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
            this.fairuMei = new System.Windows.Forms.TextBox();
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
            this.pictureBox1.Location = new System.Drawing.Point(103, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 156);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.button1.Location = new System.Drawing.Point(40, 75);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 84);
            this.button1.TabIndex = 5;
            this.button1.Text = ".3DSファイルを抽出";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRebuild3DS
            // 
            this.btnRebuild3DS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.btnRebuild3DS.FlatAppearance.BorderSize = 0;
            this.btnRebuild3DS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRebuild3DS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnRebuild3DS.Location = new System.Drawing.Point(309, 75);
            this.btnRebuild3DS.Margin = new System.Windows.Forms.Padding(4);
            this.btnRebuild3DS.Name = "btnRebuild3DS";
            this.btnRebuild3DS.Size = new System.Drawing.Size(248, 84);
            this.btnRebuild3DS.TabIndex = 6;
            this.btnRebuild3DS.Text = ".3DSファイルをコンパイルする";
            this.btnRebuild3DS.UseVisualStyleBackColor = false;
            this.btnRebuild3DS.Click += new System.EventHandler(this.btnRebuild3DS_Click);
            // 
            // btnRebuildCIA
            // 
            this.btnRebuildCIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.btnRebuildCIA.FlatAppearance.BorderSize = 0;
            this.btnRebuildCIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRebuildCIA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnRebuildCIA.Location = new System.Drawing.Point(309, 180);
            this.btnRebuildCIA.Margin = new System.Windows.Forms.Padding(4);
            this.btnRebuildCIA.Name = "btnRebuildCIA";
            this.btnRebuildCIA.Size = new System.Drawing.Size(248, 84);
            this.btnRebuildCIA.TabIndex = 8;
            this.btnRebuildCIA.Text = ".CIAファイルをコンパイルする";
            this.btnRebuildCIA.UseVisualStyleBackColor = false;
            this.btnRebuildCIA.Click += new System.EventHandler(this.btnRebuildCIA_Click);
            // 
            // btnExtractCIA
            // 
            this.btnExtractCIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.btnExtractCIA.FlatAppearance.BorderSize = 0;
            this.btnExtractCIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtractCIA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnExtractCIA.Location = new System.Drawing.Point(40, 180);
            this.btnExtractCIA.Margin = new System.Windows.Forms.Padding(4);
            this.btnExtractCIA.Name = "btnExtractCIA";
            this.btnExtractCIA.Size = new System.Drawing.Size(248, 84);
            this.btnExtractCIA.TabIndex = 7;
            this.btnExtractCIA.Text = ".CIAファイルを抽出";
            this.btnExtractCIA.UseVisualStyleBackColor = false;
            this.btnExtractCIA.Click += new System.EventHandler(this.btnExtractCIA_Click);
            // 
            // btnMassExtract
            // 
            this.btnMassExtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.btnMassExtract.FlatAppearance.BorderSize = 0;
            this.btnMassExtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMassExtract.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnMassExtract.Location = new System.Drawing.Point(40, 285);
            this.btnMassExtract.Margin = new System.Windows.Forms.Padding(4);
            this.btnMassExtract.Name = "btnMassExtract";
            this.btnMassExtract.Size = new System.Drawing.Size(248, 84);
            this.btnMassExtract.TabIndex = 9;
            this.btnMassExtract.Text = "大量ファイル抽出";
            this.btnMassExtract.UseVisualStyleBackColor = false;
            this.btnMassExtract.Click += new System.EventHandler(this.btnMassExtract_Click);
            // 
            // btnMassRebuild
            // 
            this.btnMassRebuild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.btnMassRebuild.FlatAppearance.BorderSize = 0;
            this.btnMassRebuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMassRebuild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnMassRebuild.Location = new System.Drawing.Point(309, 285);
            this.btnMassRebuild.Margin = new System.Windows.Forms.Padding(4);
            this.btnMassRebuild.Name = "btnMassRebuild";
            this.btnMassRebuild.Size = new System.Drawing.Size(248, 84);
            this.btnMassRebuild.TabIndex = 10;
            this.btnMassRebuild.Text = "大量のファイルのコンパイル";
            this.btnMassRebuild.UseVisualStyleBackColor = false;
            this.btnMassRebuild.Click += new System.EventHandler(this.btnMassRebuild_Click);
            // 
            // btnExtractCXI
            // 
            this.btnExtractCXI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.btnExtractCXI.FlatAppearance.BorderSize = 0;
            this.btnExtractCXI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtractCXI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnExtractCXI.Location = new System.Drawing.Point(40, 605);
            this.btnExtractCXI.Margin = new System.Windows.Forms.Padding(4);
            this.btnExtractCXI.Name = "btnExtractCXI";
            this.btnExtractCXI.Size = new System.Drawing.Size(248, 84);
            this.btnExtractCXI.TabIndex = 11;
            this.btnExtractCXI.Text = ".CXIファイルを抽出";
            this.btnExtractCXI.UseVisualStyleBackColor = false;
            this.btnExtractCXI.Click += new System.EventHandler(this.btnExtractCXI_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-159, -119);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(390, 415);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(-104, 558);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(390, 415);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // btnRebuildBanner
            // 
            this.btnRebuildBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.btnRebuildBanner.FlatAppearance.BorderSize = 0;
            this.btnRebuildBanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRebuildBanner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnRebuildBanner.Location = new System.Drawing.Point(309, 392);
            this.btnRebuildBanner.Margin = new System.Windows.Forms.Padding(4);
            this.btnRebuildBanner.Name = "btnRebuildBanner";
            this.btnRebuildBanner.Size = new System.Drawing.Size(248, 84);
            this.btnRebuildBanner.TabIndex = 16;
            this.btnRebuildBanner.Text = "復号化されたバナーをコンパイルする";
            this.btnRebuildBanner.UseVisualStyleBackColor = false;
            this.btnRebuildBanner.Click += new System.EventHandler(this.btnRebuildBanner_Click);
            // 
            // btnExtractBanner
            // 
            this.btnExtractBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.btnExtractBanner.FlatAppearance.BorderSize = 0;
            this.btnExtractBanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtractBanner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnExtractBanner.Location = new System.Drawing.Point(40, 392);
            this.btnExtractBanner.Margin = new System.Windows.Forms.Padding(4);
            this.btnExtractBanner.Name = "btnExtractBanner";
            this.btnExtractBanner.Size = new System.Drawing.Size(248, 84);
            this.btnExtractBanner.TabIndex = 15;
            this.btnExtractBanner.Text = "復号化されたバナーを抽出";
            this.btnExtractBanner.UseVisualStyleBackColor = false;
            this.btnExtractBanner.Click += new System.EventHandler(this.btnExtractBanner_Click);
            // 
            // btnExtractFilePartition
            // 
            this.btnExtractFilePartition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.btnExtractFilePartition.FlatAppearance.BorderSize = 0;
            this.btnExtractFilePartition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtractFilePartition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnExtractFilePartition.Location = new System.Drawing.Point(309, 500);
            this.btnExtractFilePartition.Margin = new System.Windows.Forms.Padding(4);
            this.btnExtractFilePartition.Name = "btnExtractFilePartition";
            this.btnExtractFilePartition.Size = new System.Drawing.Size(248, 84);
            this.btnExtractFilePartition.TabIndex = 18;
            this.btnExtractFilePartition.Text = "ファイルパーティションの抽出";
            this.btnExtractFilePartition.UseVisualStyleBackColor = false;
            this.btnExtractFilePartition.Click += new System.EventHandler(this.btnExtractFilePartition_Click);
            // 
            // btnExtractNCCH
            // 
            this.btnExtractNCCH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.btnExtractNCCH.FlatAppearance.BorderSize = 0;
            this.btnExtractNCCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtractNCCH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnExtractNCCH.Location = new System.Drawing.Point(40, 500);
            this.btnExtractNCCH.Margin = new System.Windows.Forms.Padding(4);
            this.btnExtractNCCH.Name = "btnExtractNCCH";
            this.btnExtractNCCH.Size = new System.Drawing.Size(248, 84);
            this.btnExtractNCCH.TabIndex = 17;
            this.btnExtractNCCH.Text = "NCCHファイルパーティションを抽出します";
            this.btnExtractNCCH.UseVisualStyleBackColor = false;
            this.btnExtractNCCH.Click += new System.EventHandler(this.btnExtractNCCH_Click);
            // 
            // fairuMei
            // 
            this.fairuMei.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fairuMei.Location = new System.Drawing.Point(16, 389);
            this.fairuMei.Margin = new System.Windows.Forms.Padding(4);
            this.fairuMei.Name = "fairuMei";
            this.fairuMei.Size = new System.Drawing.Size(373, 25);
            this.fairuMei.TabIndex = 22;
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtLog.Location = new System.Drawing.Point(40, 222);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(267, 514);
            this.txtLog.TabIndex = 23;
            this.txtLog.Text = "";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.btnLang);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtLog);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1076, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 816);
            this.panel1.TabIndex = 24;
            // 
            // btnLang
            // 
            this.btnLang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.btnLang.FlatAppearance.BorderSize = 0;
            this.btnLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLang.Location = new System.Drawing.Point(40, 749);
            this.btnLang.Margin = new System.Windows.Forms.Padding(4);
            this.btnLang.Name = "btnLang";
            this.btnLang.Size = new System.Drawing.Size(267, 42);
            this.btnLang.TabIndex = 21;
            this.btnLang.Text = "言語を変更する";
            this.btnLang.UseVisualStyleBackColor = false;
            this.btnLang.Click += new System.EventHandler(this.btnLang_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(35, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 30);
            this.label2.TabIndex = 25;
            this.label2.Text = "報告";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(14, 365);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "ファイル名（拡張子なし）を入力してください";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
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
            this.panel2.Location = new System.Drawing.Point(443, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(589, 816);
            this.panel2.TabIndex = 26;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(4, 783);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(243, 30);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "プログラムステータス";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(34, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 30);
            this.label3.TabIndex = 20;
            this.label3.Text = "以下の選択肢からお選びください。";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(840, 452);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(390, 415);
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(899, 31);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(390, 415);
            this.pictureBox5.TabIndex = 28;
            this.pictureBox5.TabStop = false;
            // 
            // Form3
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1409, 815);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fairuMei);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox fairuMei;
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