namespace Merchant_RPG {
    partial class PartyBuilder {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GoodToGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(102, 95);
            this.listBox1.TabIndex = 0;
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Position 1";
            this.label1.DragDrop += new System.Windows.Forms.DragEventHandler(this.label1_DragDrop);
            this.label1.DragEnter += new System.Windows.Forms.DragEventHandler(this.labels_DragEnter);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labels_MouseDown);
            
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Position 2";
            this.label2.DragDrop += new System.Windows.Forms.DragEventHandler(this.label2_DragDrop);
            this.label2.DragEnter += new System.Windows.Forms.DragEventHandler(this.labels_DragEnter);
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labels_MouseDown);

            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Position 3";
            this.label3.DragDrop += new System.Windows.Forms.DragEventHandler(this.label3_DragDrop);
            this.label3.DragEnter += new System.Windows.Forms.DragEventHandler(this.labels_DragEnter);
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labels_MouseDown);

            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Position 4";
            this.label4.DragDrop += new System.Windows.Forms.DragEventHandler(this.label4_DragDrop);
            this.label4.DragEnter += new System.Windows.Forms.DragEventHandler(this.labels_DragEnter);
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labels_MouseDown);

            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Position 5";
            this.label5.DragDrop += new System.Windows.Forms.DragEventHandler(this.label5_DragDrop);
            this.label5.DragEnter += new System.Windows.Forms.DragEventHandler(this.labels_DragEnter);
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labels_MouseDown);

            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Position 6";
            this.label6.DragDrop += new System.Windows.Forms.DragEventHandler(this.label6_DragDrop);
            this.label6.DragEnter += new System.Windows.Forms.DragEventHandler(this.labels_DragEnter);
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labels_MouseDown);

            // 
            // GoodToGo
            // 
            this.GoodToGo.Location = new System.Drawing.Point(140, 284);
            this.GoodToGo.Name = "GoodToGo";
            this.GoodToGo.Size = new System.Drawing.Size(75, 23);
            this.GoodToGo.TabIndex = 7;
            this.GoodToGo.Text = "Cancel";
            this.GoodToGo.UseVisualStyleBackColor = true;
            this.GoodToGo.Click += new System.EventHandler(this.button1_Click);
            // 
            // PartyBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 422);
            this.Controls.Add(this.GoodToGo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "PartyBuilder";
            this.Text = "PartyBuilder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button GoodToGo;
    }
}