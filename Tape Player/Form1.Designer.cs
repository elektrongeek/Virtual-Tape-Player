namespace Tape_PLayer
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Load_File = new System.Windows.Forms.Button();
            this.File_Dialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.Play_Button = new System.Windows.Forms.Button();
            this.Pause_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // Load_File
            // 
            this.Load_File.Location = new System.Drawing.Point(27, 311);
            this.Load_File.Name = "Load_File";
            this.Load_File.Size = new System.Drawing.Size(113, 73);
            this.Load_File.TabIndex = 0;
            this.Load_File.Text = "LOAD";
            this.Load_File.UseVisualStyleBackColor = true;
            this.Load_File.Click += new System.EventHandler(this.Load_File_Click);
            // 
            // File_Dialog
            // 
            this.File_Dialog.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(120, 12);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(226, 122);
            this.Player.TabIndex = 2;
            this.Player.Visible = false;
            // 
            // Play_Button
            // 
            this.Play_Button.BackgroundImage = global::Tape_Player.Properties.Resources.PlayButton;
            this.Play_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Play_Button.Location = new System.Drawing.Point(173, 311);
            this.Play_Button.Name = "Play_Button";
            this.Play_Button.Size = new System.Drawing.Size(100, 73);
            this.Play_Button.TabIndex = 3;
            this.Play_Button.Text = "PLAY";
            this.Play_Button.UseVisualStyleBackColor = true;
            this.Play_Button.Click += new System.EventHandler(this.Play_Button_Click);
            // 
            // Pause_Button
            // 
            this.Pause_Button.BackgroundImage = global::Tape_Player.Properties.Resources.PauseButton;
            this.Pause_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pause_Button.Location = new System.Drawing.Point(325, 311);
            this.Pause_Button.Name = "Pause_Button";
            this.Pause_Button.Size = new System.Drawing.Size(107, 73);
            this.Pause_Button.TabIndex = 4;
            this.Pause_Button.UseVisualStyleBackColor = true;
            this.Pause_Button.Click += new System.EventHandler(this.Pause_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tape_Player.Properties.Resources.brushedframe4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(542, 410);
            this.Controls.Add(this.Pause_Button);
            this.Controls.Add(this.Play_Button);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Load_File);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Load_File;
        private System.Windows.Forms.OpenFileDialog File_Dialog;
        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.Button Play_Button;
        private System.Windows.Forms.Button Pause_Button;
    }
}

