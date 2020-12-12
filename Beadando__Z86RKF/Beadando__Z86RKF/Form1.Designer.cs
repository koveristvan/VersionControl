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
            this.saveall = new System.Windows.Forms.Button();
            this.searchbutton = new System.Windows.Forms.Button();
            this.copymail = new System.Windows.Forms.Button();
            this.rebindingsource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.drawingpanel = new System.Windows.Forms.Panel();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.LocationTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SquareTextBox = new System.Windows.Forms.TextBox();
            this.LevelsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DirectionTextBox = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rebindingsource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // saveall
            // 
            this.saveall.Location = new System.Drawing.Point(611, 245);
            this.saveall.Name = "saveall";
            this.saveall.Size = new System.Drawing.Size(137, 56);
            this.saveall.TabIndex = 2;
            this.saveall.Text = "Export list in excel";
            this.saveall.UseVisualStyleBackColor = true;
            this.saveall.Click += new System.EventHandler(this.saveall_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(611, 307);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(137, 56);
            this.searchbutton.TabIndex = 3;
            this.searchbutton.Text = "Search location in chrome";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click_1);
            // 
            // copymail
            // 
            this.copymail.Location = new System.Drawing.Point(611, 369);
            this.copymail.Name = "copymail";
            this.copymail.Size = new System.Drawing.Size(137, 45);
            this.copymail.TabIndex = 4;
            this.copymail.Text = "Copy e-mail";
            this.copymail.UseVisualStyleBackColor = true;
            this.copymail.Click += new System.EventHandler(this.copymail_Click);
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
            this.drawingpanel.BackColor = System.Drawing.Color.Snow;
            this.drawingpanel.Location = new System.Drawing.Point(790, 46);
            this.drawingpanel.Name = "drawingpanel";
            this.drawingpanel.Size = new System.Drawing.Size(471, 368);
            this.drawingpanel.TabIndex = 6;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // LocationTextbox
            // 
            this.LocationTextbox.Location = new System.Drawing.Point(103, 430);
            this.LocationTextbox.Name = "LocationTextbox";
            this.LocationTextbox.Size = new System.Drawing.Size(465, 26);
            this.LocationTextbox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Location";
            // 
            // SquareTextBox
            // 
            this.SquareTextBox.Location = new System.Drawing.Point(103, 476);
            this.SquareTextBox.Name = "SquareTextBox";
            this.SquareTextBox.Size = new System.Drawing.Size(60, 26);
            this.SquareTextBox.TabIndex = 9;
            // 
            // LevelsTextBox
            // 
            this.LevelsTextBox.Location = new System.Drawing.Point(301, 476);
            this.LevelsTextBox.Name = "LevelsTextBox";
            this.LevelsTextBox.Size = new System.Drawing.Size(41, 26);
            this.LevelsTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 479);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "m^2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Number of levels";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 479);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Direction";
            // 
            // DirectionTextBox
            // 
            this.DirectionTextBox.Location = new System.Drawing.Point(426, 476);
            this.DirectionTextBox.Name = "DirectionTextBox";
            this.DirectionTextBox.Size = new System.Drawing.Size(142, 26);
            this.DirectionTextBox.TabIndex = 14;
            // 
            // search_textbox
            // 
            this.search_textbox.Location = new System.Drawing.Point(1120, 463);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(141, 26);
            this.search_textbox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(800, 463);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Number of google searches";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 545);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.search_textbox);
            this.Controls.Add(this.DirectionTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LevelsTextBox);
            this.Controls.Add(this.SquareTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LocationTextbox);
            this.Controls.Add(this.drawingpanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.copymail);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.saveall);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rebindingsource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveall;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Button copymail;
        private System.Windows.Forms.BindingSource rebindingsource;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        public System.Windows.Forms.Panel drawingpanel;
        private System.Windows.Forms.TextBox LocationTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SquareTextBox;
        private System.Windows.Forms.TextBox LevelsTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DirectionTextBox;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Label label6;
    }
}

