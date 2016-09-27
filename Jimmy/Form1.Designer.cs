namespace Jimmy
{
    partial class Jimmy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jimmy));
            this.Hello_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Rules = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Hello_button
            // 
            this.Hello_button.BackColor = System.Drawing.Color.Yellow;
            this.Hello_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hello_button.Location = new System.Drawing.Point(469, 234);
            this.Hello_button.Name = "Hello_button";
            this.Hello_button.Size = new System.Drawing.Size(235, 132);
            this.Hello_button.TabIndex = 0;
            this.Hello_button.Tag = "Hello";
            this.Hello_button.Text = "Hello";
            this.Hello_button.UseVisualStyleBackColor = false;
            this.Hello_button.Click += new System.EventHandler(this.Hello_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Goldenrod;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(284, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(645, 119);
            this.label1.TabIndex = 1;
            this.label1.Text = "HI I\'M JIMMY";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(336, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(483, 95);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dungeon Instance 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(336, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(483, 89);
            this.button2.TabIndex = 3;
            this.button2.Text = "Dungeon Instance 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Rules
            // 
            this.Rules.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rules.Location = new System.Drawing.Point(12, 164);
            this.Rules.Name = "Rules";
            this.Rules.Size = new System.Drawing.Size(294, 292);
            this.Rules.TabIndex = 4;
            this.Rules.Text = "Rules\r\n- When you start the dugeon go \r\nin order of instances";
            this.Rules.UseVisualStyleBackColor = true;
            // 
            // Jimmy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1185, 627);
            this.Controls.Add(this.Rules);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hello_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Jimmy";
            this.Tag = "jimmy_lbl";
            this.Text = "Jimmy";
            this.Load += new System.EventHandler(this.Jimmy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Hello_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Rules;
    }
}

