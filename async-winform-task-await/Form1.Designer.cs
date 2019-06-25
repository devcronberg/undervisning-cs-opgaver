namespace async_winform_task_await
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
            this.btnTask = new System.Windows.Forms.Button();
            this.btnAwait = new System.Windows.Forms.Button();
            this.txtTal = new System.Windows.Forms.TextBox();
            this.btnAwaitAfbryd = new System.Windows.Forms.Button();
            this.chkSimulerFejl = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaskAfbryd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTask
            // 
            this.btnTask.Location = new System.Drawing.Point(30, 37);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(75, 23);
            this.btnTask.TabIndex = 0;
            this.btnTask.Text = "Med Task";
            this.btnTask.UseVisualStyleBackColor = true;
            // 
            // btnAwait
            // 
            this.btnAwait.Location = new System.Drawing.Point(121, 37);
            this.btnAwait.Name = "btnAwait";
            this.btnAwait.Size = new System.Drawing.Size(75, 23);
            this.btnAwait.TabIndex = 1;
            this.btnAwait.Text = "Med await";
            this.btnAwait.UseVisualStyleBackColor = true;
            this.btnAwait.Click += new System.EventHandler(this.BtnAwait_Click);
            // 
            // txtTal
            // 
            this.txtTal.Location = new System.Drawing.Point(58, 12);
            this.txtTal.Name = "txtTal";
            this.txtTal.ReadOnly = true;
            this.txtTal.Size = new System.Drawing.Size(47, 20);
            this.txtTal.TabIndex = 2;
            // 
            // btnAwaitAfbryd
            // 
            this.btnAwaitAfbryd.Enabled = false;
            this.btnAwaitAfbryd.Location = new System.Drawing.Point(121, 67);
            this.btnAwaitAfbryd.Name = "btnAwaitAfbryd";
            this.btnAwaitAfbryd.Size = new System.Drawing.Size(75, 23);
            this.btnAwaitAfbryd.TabIndex = 3;
            this.btnAwaitAfbryd.Text = "Afbryd";
            this.btnAwaitAfbryd.UseVisualStyleBackColor = true;
            this.btnAwaitAfbryd.Click += new System.EventHandler(this.BtnAwaitAfbryd_Click);
            // 
            // chkSimulerFejl
            // 
            this.chkSimulerFejl.AutoSize = true;
            this.chkSimulerFejl.Location = new System.Drawing.Point(120, 14);
            this.chkSimulerFejl.Name = "chkSimulerFejl";
            this.chkSimulerFejl.Size = new System.Drawing.Size(76, 17);
            this.chkSimulerFejl.TabIndex = 4;
            this.chkSimulerFejl.Text = "Simuler fejl";
            this.chkSimulerFejl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkSimulerFejl.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tal";
            // 
            // btnTaskAfbryd
            // 
            this.btnTaskAfbryd.Enabled = false;
            this.btnTaskAfbryd.Location = new System.Drawing.Point(30, 67);
            this.btnTaskAfbryd.Name = "btnTaskAfbryd";
            this.btnTaskAfbryd.Size = new System.Drawing.Size(75, 23);
            this.btnTaskAfbryd.TabIndex = 6;
            this.btnTaskAfbryd.Text = "Afbryd";
            this.btnTaskAfbryd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 112);
            this.Controls.Add(this.btnTaskAfbryd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkSimulerFejl);
            this.Controls.Add(this.btnAwaitAfbryd);
            this.Controls.Add(this.txtTal);
            this.Controls.Add(this.btnAwait);
            this.Controls.Add(this.btnTask);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Async Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.Button btnAwait;
        private System.Windows.Forms.TextBox txtTal;
        private System.Windows.Forms.Button btnAwaitAfbryd;
        private System.Windows.Forms.CheckBox chkSimulerFejl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTaskAfbryd;
    }
}

