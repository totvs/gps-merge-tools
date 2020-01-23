namespace MergeTools
{
    partial class ConfigurationForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.batPath = new System.Windows.Forms.TextBox();
            this.logBatPath = new System.Windows.Forms.TextBox();
            this.tfsPath = new System.Windows.Forms.TextBox();
            this.winmergePath = new System.Windows.Forms.TextBox();
            this.confirmeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diretório para criação dos .bat gerados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Diretório para criação do LOG da execução do .bat gerado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Diretório da instalação do TFS:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Diretório do WinMerge:";
            // 
            // batPath
            // 
            this.batPath.Location = new System.Drawing.Point(11, 25);
            this.batPath.Name = "batPath";
            this.batPath.Size = new System.Drawing.Size(305, 20);
            this.batPath.TabIndex = 4;
            // 
            // logBatPath
            // 
            this.logBatPath.Location = new System.Drawing.Point(11, 73);
            this.logBatPath.Name = "logBatPath";
            this.logBatPath.Size = new System.Drawing.Size(305, 20);
            this.logBatPath.TabIndex = 5;
            // 
            // tfsPath
            // 
            this.tfsPath.Location = new System.Drawing.Point(11, 121);
            this.tfsPath.Name = "tfsPath";
            this.tfsPath.Size = new System.Drawing.Size(305, 20);
            this.tfsPath.TabIndex = 6;
            // 
            // winmergePath
            // 
            this.winmergePath.Location = new System.Drawing.Point(12, 169);
            this.winmergePath.Name = "winmergePath";
            this.winmergePath.Size = new System.Drawing.Size(304, 20);
            this.winmergePath.TabIndex = 7;
            // 
            // confirmeButton
            // 
            this.confirmeButton.Location = new System.Drawing.Point(241, 201);
            this.confirmeButton.Name = "confirmeButton";
            this.confirmeButton.Size = new System.Drawing.Size(75, 23);
            this.confirmeButton.TabIndex = 8;
            this.confirmeButton.Text = "Confirmar";
            this.confirmeButton.UseVisualStyleBackColor = true;
            this.confirmeButton.Click += new System.EventHandler(this.ConfirmeButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(160, 201);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CloseForm);
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 232);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmeButton);
            this.Controls.Add(this.winmergePath);
            this.Controls.Add(this.tfsPath);
            this.Controls.Add(this.logBatPath);
            this.Controls.Add(this.batPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigurationForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.ConfigurationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox batPath;
        private System.Windows.Forms.TextBox logBatPath;
        private System.Windows.Forms.TextBox tfsPath;
        private System.Windows.Forms.TextBox winmergePath;
        private System.Windows.Forms.Button confirmeButton;
        private System.Windows.Forms.Button cancelButton;
    }
}