namespace RemoteServerManager.Ui {
  partial class Form2 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if(disposing && (components != null)) {
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.containerPanel = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.button1);
      this.panel1.Controls.Add(this.textBox1);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 375);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(677, 37);
      this.panel1.TabIndex = 0;
      // 
      // containerPanel
      // 
      this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.containerPanel.Location = new System.Drawing.Point(0, 0);
      this.containerPanel.Name = "containerPanel";
      this.containerPanel.Size = new System.Drawing.Size(677, 375);
      this.containerPanel.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(39, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "input : ";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(58, 9);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(467, 20);
      this.textBox1.TabIndex = 1;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(531, 7);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(113, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "Shout";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(677, 412);
      this.Controls.Add(this.containerPanel);
      this.Controls.Add(this.panel1);
      this.Name = "Form2";
      this.Text = "Form2";
      this.Load += new System.EventHandler(this.Form2_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel containerPanel;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button1;
  }
}