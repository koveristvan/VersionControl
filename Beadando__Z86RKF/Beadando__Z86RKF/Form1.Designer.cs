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
            this.saveall = new System.Windows.Forms.Button();
            this.save1 = new System.Windows.Forms.Button();
            this.copymail = new System.Windows.Forms.Button();
            this.rebindingsource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.drawingpanel = new System.Windows.Forms.Panel();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
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
            this.drawbutton.Click += new System.EventHandler(this.drawbutton_Click);
            // 
            // saveall
            // 
            this.saveall.Location = new System.Drawing.Point(611, 191);
            this.saveall.Name = "saveall";
            this.saveall.Size = new System.Drawing.Size(137, 45);
            this.saveall.TabIndex = 2;
            this.saveall.Text = "Save all from list";
            this.saveall.UseVisualStyleBackColor = true;
            this.saveall.Click += new System.EventHandler(this.saveall_Click);
            // 
            // save1
            // 
            this.save1.Location = new System.Drawing.Point(611, 242);
            this.save1.Name = "save1";
            this.save1.Size = new System.Drawing.Size(137, 56);
            this.save1.TabIndex = 3;
            this.save1.Text = "Save selected item";
            this.save1.UseVisualStyleBackColor = true;
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
            // drawingpanel
            // 
            this.drawingpanel.Location = new System.Drawing.Point(790, 46);
            this.drawingpanel.Name = "drawingpanel";
            this.drawingpanel.Size = new System.Drawing.Size(471, 368);
            this.drawingpanel.TabIndex = 6;
            //this.drawingpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.paint);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 472);
            this.Controls.Add(this.drawingpanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.copymail);
            this.Controls.Add(this.save1);
            this.Controls.Add(this.saveall);
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
        private System.Windows.Forms.Button drawbutton;
        private System.Windows.Forms.Button saveall;
        private System.Windows.Forms.Button save1;
        private System.Windows.Forms.Button copymail;
        private System.Windows.Forms.BindingSource rebindingsource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel drawingpanel;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    }
}

