
namespace RunningCompetitors
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbxRunnerList = new System.Windows.Forms.ListBox();
            this.btnLoadRunners = new System.Windows.Forms.Button();
            this.btnAddRunner = new System.Windows.Forms.Button();
            this.txtInputRunner = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Running Competitors";
            // 
            // lbxRunnerList
            // 
            this.lbxRunnerList.FormattingEnabled = true;
            this.lbxRunnerList.ItemHeight = 16;
            this.lbxRunnerList.Location = new System.Drawing.Point(34, 106);
            this.lbxRunnerList.Name = "lbxRunnerList";
            this.lbxRunnerList.Size = new System.Drawing.Size(199, 292);
            this.lbxRunnerList.TabIndex = 1;
            // 
            // btnLoadRunners
            // 
            this.btnLoadRunners.Location = new System.Drawing.Point(524, 131);
            this.btnLoadRunners.Name = "btnLoadRunners";
            this.btnLoadRunners.Size = new System.Drawing.Size(186, 57);
            this.btnLoadRunners.TabIndex = 2;
            this.btnLoadRunners.Text = "Load Runners";
            this.btnLoadRunners.UseVisualStyleBackColor = true;
            this.btnLoadRunners.Click += new System.EventHandler(this.btnLoadRunners_Click);
            // 
            // btnAddRunner
            // 
            this.btnAddRunner.Location = new System.Drawing.Point(525, 234);
            this.btnAddRunner.Name = "btnAddRunner";
            this.btnAddRunner.Size = new System.Drawing.Size(185, 63);
            this.btnAddRunner.TabIndex = 3;
            this.btnAddRunner.Text = "Add New Runner";
            this.btnAddRunner.UseVisualStyleBackColor = true;
            this.btnAddRunner.Click += new System.EventHandler(this.btnAddRunner_Click);
            // 
            // txtInputRunner
            // 
            this.txtInputRunner.Location = new System.Drawing.Point(524, 194);
            this.txtInputRunner.Name = "txtInputRunner";
            this.txtInputRunner.Size = new System.Drawing.Size(186, 22);
            this.txtInputRunner.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtInputRunner);
            this.Controls.Add(this.btnAddRunner);
            this.Controls.Add(this.btnLoadRunners);
            this.Controls.Add(this.lbxRunnerList);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxRunnerList;
        private System.Windows.Forms.Button btnLoadRunners;
        private System.Windows.Forms.Button btnAddRunner;
        private System.Windows.Forms.TextBox txtInputRunner;
    }
}

