namespace DSPBL
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ExitBut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Infobut = new System.Windows.Forms.Button();
            this.HealthBut = new System.Windows.Forms.Button();
            this.HcareBut = new System.Windows.Forms.Button();
            this.GraphBut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitBut
            // 
            this.ExitBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitBut.BackgroundImage")));
            this.ExitBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitBut.FlatAppearance.BorderSize = 0;
            this.ExitBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBut.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ExitBut.Location = new System.Drawing.Point(3, 385);
            this.ExitBut.Name = "ExitBut";
            this.ExitBut.Size = new System.Drawing.Size(111, 53);
            this.ExitBut.TabIndex = 0;
            this.ExitBut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ExitBut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ExitBut.UseVisualStyleBackColor = true;
            this.ExitBut.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GraphBut);
            this.panel1.Controls.Add(this.HcareBut);
            this.panel1.Controls.Add(this.ExitBut);
            this.panel1.Controls.Add(this.HealthBut);
            this.panel1.Controls.Add(this.Infobut);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(686, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 450);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(114, 77);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "CC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(686, 77);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 77);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(686, 373);
            this.panel4.TabIndex = 3;
            // 
            // Infobut
            // 
            this.Infobut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Infobut.BackgroundImage")));
            this.Infobut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Infobut.FlatAppearance.BorderSize = 0;
            this.Infobut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Infobut.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Infobut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Infobut.Location = new System.Drawing.Point(3, 98);
            this.Infobut.Name = "Infobut";
            this.Infobut.Size = new System.Drawing.Size(111, 53);
            this.Infobut.TabIndex = 4;
            this.Infobut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Infobut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Infobut.UseVisualStyleBackColor = true;
            // 
            // HealthBut
            // 
            this.HealthBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HealthBut.BackgroundImage")));
            this.HealthBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HealthBut.FlatAppearance.BorderSize = 0;
            this.HealthBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HealthBut.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.HealthBut.Location = new System.Drawing.Point(3, 170);
            this.HealthBut.Name = "HealthBut";
            this.HealthBut.Size = new System.Drawing.Size(111, 53);
            this.HealthBut.TabIndex = 5;
            this.HealthBut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HealthBut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.HealthBut.UseVisualStyleBackColor = true;
            // 
            // HcareBut
            // 
            this.HcareBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HcareBut.BackgroundImage")));
            this.HcareBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HcareBut.FlatAppearance.BorderSize = 0;
            this.HcareBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HcareBut.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HcareBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.HcareBut.Location = new System.Drawing.Point(3, 244);
            this.HcareBut.Name = "HcareBut";
            this.HcareBut.Size = new System.Drawing.Size(111, 53);
            this.HcareBut.TabIndex = 6;
            this.HcareBut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HcareBut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.HcareBut.UseVisualStyleBackColor = true;
            // 
            // GraphBut
            // 
            this.GraphBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GraphBut.BackgroundImage")));
            this.GraphBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GraphBut.FlatAppearance.BorderSize = 0;
            this.GraphBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GraphBut.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GraphBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GraphBut.Location = new System.Drawing.Point(3, 314);
            this.GraphBut.Name = "GraphBut";
            this.GraphBut.Size = new System.Drawing.Size(111, 53);
            this.GraphBut.TabIndex = 7;
            this.GraphBut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GraphBut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GraphBut.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitBut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button GraphBut;
        private System.Windows.Forms.Button HcareBut;
        private System.Windows.Forms.Button HealthBut;
        private System.Windows.Forms.Button Infobut;
    }
}

