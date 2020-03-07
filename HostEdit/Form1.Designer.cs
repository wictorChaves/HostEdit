namespace HostEdit
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
            this.txt = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rm = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(13, 13);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(264, 20);
            this.txt.TabIndex = 0;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(283, 13);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 1;
            this.add.Text = "Adicionar";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(345, 342);
            this.listBox1.TabIndex = 2;
            // 
            // rm
            // 
            this.rm.Location = new System.Drawing.Point(12, 386);
            this.rm.Name = "rm";
            this.rm.Size = new System.Drawing.Size(345, 23);
            this.rm.TabIndex = 3;
            this.rm.Text = "Remover Selecionados";
            this.rm.UseVisualStyleBackColor = true;
            this.rm.Click += new System.EventHandler(this.rm_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(13, 415);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(345, 23);
            this.save.TabIndex = 4;
            this.save.Text = "Salvar";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 450);
            this.Controls.Add(this.save);
            this.Controls.Add(this.rm);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Edit Host File";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button rm;
        private System.Windows.Forms.Button save;
    }
}

