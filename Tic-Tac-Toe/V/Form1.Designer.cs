namespace Tic_Tac_Toe {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing&&(components!=null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSE = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.buttonSW = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonW = new System.Windows.Forms.Button();
            this.buttonNE = new System.Windows.Forms.Button();
            this.buttonN = new System.Windows.Forms.Button();
            this.buttonNW = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.buttonSE, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonS, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonSW, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonE, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonC, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonW, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonNE, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonN, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonNW, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(533, 448);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonSE
            // 
            this.buttonSE.BackColor = System.Drawing.Color.Black;
            this.buttonSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSE.Location = new System.Drawing.Point(357, 301);
            this.buttonSE.Name = "buttonSE";
            this.buttonSE.Size = new System.Drawing.Size(173, 144);
            this.buttonSE.TabIndex = 8;
            this.buttonSE.UseVisualStyleBackColor = false;
            this.buttonSE.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonS
            // 
            this.buttonS.BackColor = System.Drawing.Color.Black;
            this.buttonS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonS.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonS.Location = new System.Drawing.Point(180, 301);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(171, 144);
            this.buttonS.TabIndex = 7;
            this.buttonS.UseVisualStyleBackColor = false;
            this.buttonS.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonSW
            // 
            this.buttonSW.BackColor = System.Drawing.Color.Black;
            this.buttonSW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSW.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSW.Location = new System.Drawing.Point(3, 301);
            this.buttonSW.Name = "buttonSW";
            this.buttonSW.Size = new System.Drawing.Size(171, 144);
            this.buttonSW.TabIndex = 6;
            this.buttonSW.UseVisualStyleBackColor = false;
            this.buttonSW.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonE
            // 
            this.buttonE.BackColor = System.Drawing.Color.Black;
            this.buttonE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonE.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonE.Location = new System.Drawing.Point(357, 152);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(173, 143);
            this.buttonE.TabIndex = 5;
            this.buttonE.UseVisualStyleBackColor = false;
            this.buttonE.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.Black;
            this.buttonC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.Location = new System.Drawing.Point(180, 152);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(171, 143);
            this.buttonC.TabIndex = 4;
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonW
            // 
            this.buttonW.BackColor = System.Drawing.Color.Black;
            this.buttonW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonW.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonW.Location = new System.Drawing.Point(3, 152);
            this.buttonW.Name = "buttonW";
            this.buttonW.Size = new System.Drawing.Size(171, 143);
            this.buttonW.TabIndex = 3;
            this.buttonW.UseVisualStyleBackColor = false;
            this.buttonW.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonNE
            // 
            this.buttonNE.BackColor = System.Drawing.Color.Black;
            this.buttonNE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNE.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNE.Location = new System.Drawing.Point(357, 3);
            this.buttonNE.Name = "buttonNE";
            this.buttonNE.Size = new System.Drawing.Size(173, 143);
            this.buttonNE.TabIndex = 2;
            this.buttonNE.UseVisualStyleBackColor = false;
            this.buttonNE.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonN
            // 
            this.buttonN.BackColor = System.Drawing.Color.Black;
            this.buttonN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonN.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonN.Location = new System.Drawing.Point(180, 3);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(171, 143);
            this.buttonN.TabIndex = 1;
            this.buttonN.UseVisualStyleBackColor = false;
            this.buttonN.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonNW
            // 
            this.buttonNW.BackColor = System.Drawing.Color.Black;
            this.buttonNW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNW.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNW.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonNW.Location = new System.Drawing.Point(3, 3);
            this.buttonNW.Name = "buttonNW";
            this.buttonNW.Size = new System.Drawing.Size(171, 143);
            this.buttonNW.TabIndex = 0;
            this.buttonNW.UseVisualStyleBackColor = false;
            this.buttonNW.Click += new System.EventHandler(this.Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 448);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "TIC - TAC - TOE";
            this.TransparencyKey = System.Drawing.Color.Green;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonSE;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button buttonSW;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonW;
        private System.Windows.Forms.Button buttonNE;
        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.Button buttonNW;
    }
}

