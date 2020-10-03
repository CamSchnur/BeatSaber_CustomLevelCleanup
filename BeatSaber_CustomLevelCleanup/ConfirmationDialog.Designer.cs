namespace BeatSaber_CustomLevelCleanup
{
    partial class ConfirmationDialog
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBoxFavLevels = new System.Windows.Forms.ListBox();
            this.listBoxLevelsToDelete = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Here\'s what we found in those BeatSaber data folders:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 623);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Given all that information, would you like to go ahead with the deletion?";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(111, 672);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Yes, delete them";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(254, 672);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "No, cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listBoxFavLevels
            // 
            this.listBoxFavLevels.FormattingEnabled = true;
            this.listBoxFavLevels.Location = new System.Drawing.Point(84, 92);
            this.listBoxFavLevels.Name = "listBoxFavLevels";
            this.listBoxFavLevels.Size = new System.Drawing.Size(923, 212);
            this.listBoxFavLevels.TabIndex = 3;
            // 
            // listBoxLevelsToDelete
            // 
            this.listBoxLevelsToDelete.FormattingEnabled = true;
            this.listBoxLevelsToDelete.Location = new System.Drawing.Point(84, 341);
            this.listBoxLevelsToDelete.Name = "listBoxLevelsToDelete";
            this.listBoxLevelsToDelete.Size = new System.Drawing.Size(923, 225);
            this.listBoxLevelsToDelete.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Custom levels that you have starred:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(414, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Custom levels that you have NOT starred:  (These will all be deleted if you proce" +
    "ed!!!!!)\r\n";
            // 
            // ConfirmationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 778);
            this.Controls.Add(this.listBoxLevelsToDelete);
            this.Controls.Add(this.listBoxFavLevels);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ConfirmationDialog";
            this.Text = "Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBoxFavLevels;
        private System.Windows.Forms.ListBox listBoxLevelsToDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}