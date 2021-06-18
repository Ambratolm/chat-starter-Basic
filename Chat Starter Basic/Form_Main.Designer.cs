namespace ChatStarterBasic
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.button_send = new System.Windows.Forms.Button();
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.button_online = new System.Windows.Forms.Button();
            this.listBox_conversation = new System.Windows.Forms.ListBox();
            this.pictureBox_user = new System.Windows.Forms.PictureBox();
            this.button_config = new System.Windows.Forms.Button();
            this.button_off = new System.Windows.Forms.Button();
            this.button_on = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).BeginInit();
            this.SuspendLayout();
            // 
            // button_send
            // 
            this.button_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_send.BackColor = System.Drawing.Color.Navy;
            this.button_send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_send.Location = new System.Drawing.Point(626, 404);
            this.button_send.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(166, 66);
            this.button_send.TabIndex = 1;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = false;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // textBox_message
            // 
            this.textBox_message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_message.BackColor = System.Drawing.Color.Black;
            this.textBox_message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_message.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_message.ForeColor = System.Drawing.Color.White;
            this.textBox_message.Location = new System.Drawing.Point(24, 404);
            this.textBox_message.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBox_message.Multiline = true;
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.Size = new System.Drawing.Size(588, 64);
            this.textBox_message.TabIndex = 0;
            this.textBox_message.TextChanged += new System.EventHandler(this.textBox_message_TextChanged);
            // 
            // button_online
            // 
            this.button_online.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_online.BackColor = System.Drawing.Color.Green;
            this.button_online.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_online.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_online.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_online.Location = new System.Drawing.Point(626, 188);
            this.button_online.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.button_online.Name = "button_online";
            this.button_online.Size = new System.Drawing.Size(166, 42);
            this.button_online.TabIndex = 3;
            this.button_online.Tag = "";
            this.button_online.Text = "Online";
            this.button_online.UseVisualStyleBackColor = false;
            this.button_online.Click += new System.EventHandler(this.button_online_Click);
            // 
            // listBox_conversation
            // 
            this.listBox_conversation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_conversation.BackColor = System.Drawing.Color.Black;
            this.listBox_conversation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_conversation.ForeColor = System.Drawing.Color.White;
            this.listBox_conversation.FormattingEnabled = true;
            this.listBox_conversation.ItemHeight = 30;
            this.listBox_conversation.Location = new System.Drawing.Point(24, 22);
            this.listBox_conversation.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.listBox_conversation.Name = "listBox_conversation";
            this.listBox_conversation.Size = new System.Drawing.Size(588, 362);
            this.listBox_conversation.TabIndex = 2;
            // 
            // pictureBox_user
            // 
            this.pictureBox_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_user.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBox_user.Image = global::ChatStarterBasic.Properties.Resources.yeni_insan;
            this.pictureBox_user.Location = new System.Drawing.Point(626, 22);
            this.pictureBox_user.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox_user.Name = "pictureBox_user";
            this.pictureBox_user.Size = new System.Drawing.Size(164, 152);
            this.pictureBox_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_user.TabIndex = 4;
            this.pictureBox_user.TabStop = false;
            // 
            // button_config
            // 
            this.button_config.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_config.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_config.Location = new System.Drawing.Point(626, 322);
            this.button_config.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.button_config.Name = "button_config";
            this.button_config.Size = new System.Drawing.Size(166, 66);
            this.button_config.TabIndex = 1;
            this.button_config.Text = "Config";
            this.button_config.UseVisualStyleBackColor = false;
            this.button_config.Click += new System.EventHandler(this.button_config_Click);
            // 
            // button_off
            // 
            this.button_off.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_off.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_off.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_off.Location = new System.Drawing.Point(717, 261);
            this.button_off.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.button_off.Name = "button_off";
            this.button_off.Size = new System.Drawing.Size(75, 45);
            this.button_off.TabIndex = 1;
            this.button_off.Text = "OFF";
            this.button_off.UseVisualStyleBackColor = false;
            this.button_off.Click += new System.EventHandler(this.button_off_Click);
            // 
            // button_on
            // 
            this.button_on.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_on.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_on.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_on.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_on.Location = new System.Drawing.Point(626, 261);
            this.button_on.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.button_on.Name = "button_on";
            this.button_on.Size = new System.Drawing.Size(75, 45);
            this.button_on.TabIndex = 1;
            this.button_on.Text = "ON";
            this.button_on.UseVisualStyleBackColor = false;
            this.button_on.Click += new System.EventHandler(this.button_on_Click);
            // 
            // Form_Main
            // 
            this.AcceptButton = this.button_send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.button_online;
            this.ClientSize = new System.Drawing.Size(816, 494);
            this.Controls.Add(this.pictureBox_user);
            this.Controls.Add(this.listBox_conversation);
            this.Controls.Add(this.button_online);
            this.Controls.Add(this.textBox_message);
            this.Controls.Add(this.button_on);
            this.Controls.Add(this.button_off);
            this.Controls.Add(this.button_config);
            this.Controls.Add(this.button_send);
            this.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat Starter Basic";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.TextBox textBox_message;
        private System.Windows.Forms.Button button_online;
        private System.Windows.Forms.ListBox listBox_conversation;
        private System.Windows.Forms.PictureBox pictureBox_user;
        private System.Windows.Forms.Button button_config;
        private System.Windows.Forms.Button button_off;
        private System.Windows.Forms.Button button_on;
    }
}

