namespace MergeTools
{
    partial class MainForm
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
            this.startMergeButton = new System.Windows.Forms.Button();
            this.version = new System.Windows.Forms.MaskedTextBox();
            this.csvPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.runBat = new System.Windows.Forms.CheckBox();
            this.addVersionButton = new System.Windows.Forms.Button();
            this.VersionsList = new System.Windows.Forms.CheckedListBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.configButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Versão para Merge:";
            // 
            // startMergeButton
            // 
            this.startMergeButton.Location = new System.Drawing.Point(162, 157);
            this.startMergeButton.Name = "startMergeButton";
            this.startMergeButton.Size = new System.Drawing.Size(111, 25);
            this.startMergeButton.TabIndex = 4;
            this.startMergeButton.Text = "Realizar Merge";
            this.startMergeButton.UseVisualStyleBackColor = true;
            this.startMergeButton.Click += new System.EventHandler(this.StartMergeButton_Click);
            // 
            // version
            // 
            this.version.Location = new System.Drawing.Point(12, 22);
            this.version.Mask = "##.#.##";
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(137, 20);
            this.version.TabIndex = 1;
            // 
            // csvPath
            // 
            this.csvPath.Location = new System.Drawing.Point(12, 131);
            this.csvPath.Name = "csvPath";
            this.csvPath.Size = new System.Drawing.Size(261, 20);
            this.csvPath.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Caminho CSV:";
            // 
            // runBat
            // 
            this.runBat.AutoSize = true;
            this.runBat.Location = new System.Drawing.Point(12, 162);
            this.runBat.Name = "runBat";
            this.runBat.Size = new System.Drawing.Size(144, 17);
            this.runBat.TabIndex = 2;
            this.runBat.Text = "Rodar .bat após geração";
            this.runBat.UseVisualStyleBackColor = false;
            // 
            // addVersionButton
            // 
            this.addVersionButton.Location = new System.Drawing.Point(164, 22);
            this.addVersionButton.Name = "addVersionButton";
            this.addVersionButton.Size = new System.Drawing.Size(111, 24);
            this.addVersionButton.TabIndex = 8;
            this.addVersionButton.Text = "Adicionar Versão";
            this.addVersionButton.UseVisualStyleBackColor = true;
            this.addVersionButton.Click += new System.EventHandler(this.AddVersionButton_Click);
            // 
            // VersionsList
            // 
            this.VersionsList.FormattingEnabled = true;
            this.VersionsList.Location = new System.Drawing.Point(12, 48);
            this.VersionsList.Name = "VersionsList";
            this.VersionsList.Size = new System.Drawing.Size(137, 64);
            this.VersionsList.TabIndex = 9;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(164, 48);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(111, 23);
            this.removeButton.TabIndex = 10;
            this.removeButton.Text = "Remover Versão";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // configButton
            // 
            this.configButton.Location = new System.Drawing.Point(164, 74);
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(111, 25);
            this.configButton.TabIndex = 11;
            this.configButton.Text = "Configurações";
            this.configButton.UseVisualStyleBackColor = true;
            this.configButton.Click += new System.EventHandler(this.ConfigButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 188);
            this.Controls.Add(this.configButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.VersionsList);
            this.Controls.Add(this.addVersionButton);
            this.Controls.Add(this.runBat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.csvPath);
            this.Controls.Add(this.version);
            this.Controls.Add(this.startMergeButton);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Merge da V11 para Outras Versões";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_Closed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startMergeButton;
        private System.Windows.Forms.MaskedTextBox version;
        private System.Windows.Forms.TextBox csvPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox runBat;
        private System.Windows.Forms.Button addVersionButton;
        private System.Windows.Forms.CheckedListBox VersionsList;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button configButton;
    }
}

