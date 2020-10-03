namespace BeatSaber_CustomLevelCleanup
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChangePlayerData = new System.Windows.Forms.Button();
            this.buttonChangeSongHashData = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonChangeCustomLevels = new System.Windows.Forms.Button();
            this.textBoxCustomLevels = new System.Windows.Forms.TextBox();
            this.textBoxSongHashData = new System.Windows.Forms.TextBox();
            this.textBoxPlayerData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // buttonChangePlayerData
            // 
            this.buttonChangePlayerData.Location = new System.Drawing.Point(713, 143);
            this.buttonChangePlayerData.Name = "buttonChangePlayerData";
            this.buttonChangePlayerData.Size = new System.Drawing.Size(75, 23);
            this.buttonChangePlayerData.TabIndex = 1;
            this.buttonChangePlayerData.Text = "Change";
            this.buttonChangePlayerData.UseVisualStyleBackColor = true;
            this.buttonChangePlayerData.Click += new System.EventHandler(this.buttonChangePlayerData_Click);
            // 
            // buttonChangeSongHashData
            // 
            this.buttonChangeSongHashData.Location = new System.Drawing.Point(713, 187);
            this.buttonChangeSongHashData.Name = "buttonChangeSongHashData";
            this.buttonChangeSongHashData.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeSongHashData.TabIndex = 2;
            this.buttonChangeSongHashData.Text = "Change";
            this.buttonChangeSongHashData.UseVisualStyleBackColor = true;
            this.buttonChangeSongHashData.Click += new System.EventHandler(this.buttonChangeSongHashData_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(351, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonChangeCustomLevels
            // 
            this.buttonChangeCustomLevels.Location = new System.Drawing.Point(713, 232);
            this.buttonChangeCustomLevels.Name = "buttonChangeCustomLevels";
            this.buttonChangeCustomLevels.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeCustomLevels.TabIndex = 2;
            this.buttonChangeCustomLevels.Text = "Change";
            this.buttonChangeCustomLevels.UseVisualStyleBackColor = true;
            this.buttonChangeCustomLevels.Click += new System.EventHandler(this.buttonChangeCustomLevels_Click);
            // 
            // textBoxCustomLevels
            // 
            this.textBoxCustomLevels.Location = new System.Drawing.Point(91, 234);
            this.textBoxCustomLevels.Name = "textBoxCustomLevels";
            this.textBoxCustomLevels.Size = new System.Drawing.Size(598, 20);
            this.textBoxCustomLevels.TabIndex = 4;
            // 
            // textBoxSongHashData
            // 
            this.textBoxSongHashData.Location = new System.Drawing.Point(91, 190);
            this.textBoxSongHashData.Name = "textBoxSongHashData";
            this.textBoxSongHashData.Size = new System.Drawing.Size(598, 20);
            this.textBoxSongHashData.TabIndex = 4;
            // 
            // textBoxPlayerData
            // 
            this.textBoxPlayerData.Location = new System.Drawing.Point(91, 145);
            this.textBoxPlayerData.Name = "textBoxPlayerData";
            this.textBoxPlayerData.Size = new System.Drawing.Size(598, 20);
            this.textBoxPlayerData.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "PlayerData:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "SongHashData:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Custom Levels:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPlayerData);
            this.Controls.Add(this.textBoxSongHashData);
            this.Controls.Add(this.textBoxCustomLevels);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonChangeCustomLevels);
            this.Controls.Add(this.buttonChangeSongHashData);
            this.Controls.Add(this.buttonChangePlayerData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "BeatSaber Custom Level Cleanup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonChangePlayerData;
        private System.Windows.Forms.Button buttonChangeSongHashData;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonChangeCustomLevels;
        private System.Windows.Forms.TextBox textBoxCustomLevels;
        private System.Windows.Forms.TextBox textBoxSongHashData;
        private System.Windows.Forms.TextBox textBoxPlayerData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

