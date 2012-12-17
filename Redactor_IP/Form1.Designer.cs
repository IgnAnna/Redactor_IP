namespace Redactor_IP
{
    partial class MainScreen
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
            this.Cross = new System.Windows.Forms.RadioButton();
            this.Line = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Cross
            // 
            this.Cross.AutoSize = true;
            this.Cross.Location = new System.Drawing.Point(211, 170);
            this.Cross.Name = "Cross";
            this.Cross.Size = new System.Drawing.Size(67, 17);
            this.Cross.TabIndex = 0;
            this.Cross.TabStop = true;
            this.Cross.Text = "Крестик";
            this.Cross.UseVisualStyleBackColor = true;
            this.Cross.CheckedChanged += new System.EventHandler(this.Cross_Line_Changed);
            // 
            // Line
            // 
            this.Line.AutoSize = true;
            this.Line.Location = new System.Drawing.Point(211, 194);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(57, 17);
            this.Line.TabIndex = 1;
            this.Line.TabStop = true;
            this.Line.Text = "Линия";
            this.Line.UseVisualStyleBackColor = true;
            this.Line.CheckedChanged += new System.EventHandler(this.Cross_Line_Changed);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.Cross);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainScreen_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainScreen_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainScreen_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Cross;
        private System.Windows.Forms.RadioButton Line;
    }
}

