namespace MouseHookSample
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
            this.btnStartMouseHook = new System.Windows.Forms.Button();
            this.btnStopMouseHook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGUIProcess = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStartMouseHook
            // 
            this.btnStartMouseHook.Location = new System.Drawing.Point(12, 126);
            this.btnStartMouseHook.Name = "btnStartMouseHook";
            this.btnStartMouseHook.Size = new System.Drawing.Size(192, 36);
            this.btnStartMouseHook.TabIndex = 0;
            this.btnStartMouseHook.Text = "Start Mouse Hook";
            this.btnStartMouseHook.UseVisualStyleBackColor = true;
            this.btnStartMouseHook.Click += new System.EventHandler(this.btnStartMouseHook_Click);
            // 
            // btnStopMouseHook
            // 
            this.btnStopMouseHook.Location = new System.Drawing.Point(12, 168);
            this.btnStopMouseHook.Name = "btnStopMouseHook";
            this.btnStopMouseHook.Size = new System.Drawing.Size(192, 36);
            this.btnStopMouseHook.TabIndex = 1;
            this.btnStopMouseHook.Text = "Stop Mouse Hook";
            this.btnStopMouseHook.UseVisualStyleBackColor = true;
            this.btnStopMouseHook.Click += new System.EventHandler(this.btnStopMouseHook_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(857, 80);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btnGUIProcess
            // 
            this.btnGUIProcess.Location = new System.Drawing.Point(243, 380);
            this.btnGUIProcess.Name = "btnGUIProcess";
            this.btnGUIProcess.Size = new System.Drawing.Size(437, 36);
            this.btnGUIProcess.TabIndex = 3;
            this.btnGUIProcess.Text = "Start a long running process on the GUI thread";
            this.btnGUIProcess.UseVisualStyleBackColor = true;
            this.btnGUIProcess.Click += new System.EventHandler(this.btnGUIProcess_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(35, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(857, 80);
            this.label2.TabIndex = 4;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 517);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGUIProcess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStopMouseHook);
            this.Controls.Add(this.btnStartMouseHook);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartMouseHook;
        private System.Windows.Forms.Button btnStopMouseHook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGUIProcess;
        private System.Windows.Forms.Label label2;
    }
}

