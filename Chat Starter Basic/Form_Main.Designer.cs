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
            this.button_connect = new System.Windows.Forms.Button();
            this.listBox_conversation = new System.Windows.Forms.ListBox();
            this.pictureBox_user = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).BeginInit();
            this.SuspendLayout();
            // 
            // button_send
            // 
            this.button_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_send.BackColor = System.Drawing.Color.Navy;
            this.button_send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_send.Location = new System.Drawing.Point(313, 182);
            this.button_send.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(83, 35);
            this.button_send.TabIndex = 1;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = false;
            this.button_send.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // textBox_message
            // 
            this.textBox_message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_message.BackColor = System.Drawing.Color.Black;
            this.textBox_message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_message.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_message.ForeColor = System.Drawing.Color.White;
            this.textBox_message.Location = new System.Drawing.Point(12, 182);
            this.textBox_message.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_message.Multiline = true;
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.Size = new System.Drawing.Size(295, 35);
            this.textBox_message.TabIndex = 2;
            // 
            // button_connect
            // 
            this.button_connect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_connect.BackColor = System.Drawing.Color.Green;
            this.button_connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_connect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_connect.Location = new System.Drawing.Point(313, 101);
            this.button_connect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(83, 30);
            this.button_connect.TabIndex = 1;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = false;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
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
            this.listBox_conversation.ItemHeight = 16;
            this.listBox_conversation.Location = new System.Drawing.Point(12, 12);
            this.listBox_conversation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox_conversation.Name = "listBox_conversation";
            this.listBox_conversation.Size = new System.Drawing.Size(295, 162);
            this.listBox_conversation.TabIndex = 3;
            // 
            // pictureBox_user
            // 
            this.pictureBox_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_user.Image = global::ChatStarterBasic.Properties.Resources.yeni_insan_ava;
            this.pictureBox_user.Location = new System.Drawing.Point(313, 12);
            this.pictureBox_user.Name = "pictureBox_user";
            this.pictureBox_user.Size = new System.Drawing.Size(83, 82);
            this.pictureBox_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_user.TabIndex = 4;
            this.pictureBox_user.TabStop = false;
            // 
            // Form_Main
            // 
            this.AcceptButton = this.button_send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.button_connect;
            this.ClientSize = new System.Drawing.Size(408, 230);
            this.Controls.Add(this.pictureBox_user);
            this.Controls.Add(this.listBox_conversation);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.textBox_message);
            this.Controls.Add(this.button_send);
            this.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat Starter Basic";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.TextBox textBox_message;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.ListBox listBox_conversation;
        private System.Windows.Forms.PictureBox pictureBox_user;
    }
}

