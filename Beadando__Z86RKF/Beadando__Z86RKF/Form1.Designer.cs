namespace Beadando__Z86RKF
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.drawbutton = new System.Windows.Forms.Button();
            this.copyall = new System.Windows.Forms.Button();
            this.copy1 = new System.Windows.Forms.Button();
            this.copymail = new System.Windows.Forms.Button();
            this.rebindingsource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rebindingsource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(556, 368);
            this.dataGridView1.TabIndex = 0;
            // 
            // drawbutton
            // 
            this.drawbutton.Location = new System.Drawing.Point(611, 46);
            this.drawbutton.Name = "drawbutton";
            this.drawbutton.Size = new System.Drawing.Size(137, 45);
            this.drawbutton.TabIndex = 1;
            this.drawbutton.Text = "How it looks";
            this.drawbutton.UseVisualStyleBackColor = true;
            // 
            // copyall
            // 
            this.copyall.Location = new System.Drawing.Point(611, 191);
            this.copyall.Name = "copyall";
            this.copyall.Size = new System.Drawing.Size(137, 45);
            this.copyall.TabIndex = 2;
            this.copyall.Text = "Copy all from list";
            this.copyall.UseVisualStyleBackColor = true;
            // 
            // copy1
            // 
            this.copy1.Location = new System.Drawing.Point(611, 242);
            this.copy1.Name = "copy1";
            this.copy1.Size = new System.Drawing.Size(137, 56);
            this.copy1.TabIndex = 3;
            this.copy1.Text = "Copy selected item";
            this.copy1.UseVisualStyleBackColor = true;
            // 
            // copymail
            // 
            this.copymail.Location = new System.Drawing.Point(611, 369);
            this.copymail.Name = "copymail";
            this.copymail.Size = new System.Drawing.Size(137, 45);
            this.copymail.TabIndex = 4;
            this.copymail.Text = "Copy e-mail";
            this.copymail.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Real Estate List Pest county";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.copymail);
            this.Controls.Add(this.copy1);
            this.Controls.Add(this.copyall);
            this.Controls.Add(this.drawbutton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rebindingsource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button drawbutton;
        private System.Windows.Forms.Button copyall;
        private System.Windows.Forms.Button copy1;
        private System.Windows.Forms.Button copymail;
        private System.Windows.Forms.BindingSource rebindingsource;
        private System.Windows.Forms.Label label1;
    }
}

