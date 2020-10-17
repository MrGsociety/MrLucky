namespace Mr.Lucky
{
    partial class Mr_Lucky_main_menu
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
            this.exit_btn = new System.Windows.Forms.Button();
            this.register_panel = new System.Windows.Forms.Panel();
            this.reg_password_again = new System.Windows.Forms.Label();
            this.reg_password_lbl = new System.Windows.Forms.Label();
            this.reg_username_lbl = new System.Windows.Forms.Label();
            this.register_lbl = new System.Windows.Forms.Label();
            this.login_panel = new System.Windows.Forms.Panel();
            this.computer_name_lbl = new System.Windows.Forms.Label();
            this.register_username = new System.Windows.Forms.TextBox();
            this.register_password = new System.Windows.Forms.TextBox();
            this.register_password_again = new System.Windows.Forms.TextBox();
            this.login_pasword = new System.Windows.Forms.TextBox();
            this.login_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.register_btn = new System.Windows.Forms.Button();
            this.reg_rechapta_chbox = new System.Windows.Forms.CheckBox();
            this.log_rechapta_chbox = new System.Windows.Forms.CheckBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.register_panel.SuspendLayout();
            this.login_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit_btn
            // 
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.Location = new System.Drawing.Point(532, 613);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(130, 58);
            this.exit_btn.TabIndex = 0;
            this.exit_btn.Text = "Kilépés";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // register_panel
            // 
            this.register_panel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.register_panel.Controls.Add(this.reg_rechapta_chbox);
            this.register_panel.Controls.Add(this.register_btn);
            this.register_panel.Controls.Add(this.register_password_again);
            this.register_panel.Controls.Add(this.register_password);
            this.register_panel.Controls.Add(this.register_username);
            this.register_panel.Controls.Add(this.reg_password_again);
            this.register_panel.Controls.Add(this.reg_password_lbl);
            this.register_panel.Controls.Add(this.reg_username_lbl);
            this.register_panel.Controls.Add(this.register_lbl);
            this.register_panel.Location = new System.Drawing.Point(12, 71);
            this.register_panel.Name = "register_panel";
            this.register_panel.Size = new System.Drawing.Size(472, 600);
            this.register_panel.TabIndex = 1;
            // 
            // reg_password_again
            // 
            this.reg_password_again.AutoSize = true;
            this.reg_password_again.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 14.25F);
            this.reg_password_again.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reg_password_again.Location = new System.Drawing.Point(76, 259);
            this.reg_password_again.Name = "reg_password_again";
            this.reg_password_again.Size = new System.Drawing.Size(108, 26);
            this.reg_password_again.TabIndex = 3;
            this.reg_password_again.Text = "Jelszó ismét";
            // 
            // reg_password_lbl
            // 
            this.reg_password_lbl.AutoSize = true;
            this.reg_password_lbl.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 14.25F);
            this.reg_password_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reg_password_lbl.Location = new System.Drawing.Point(126, 207);
            this.reg_password_lbl.Name = "reg_password_lbl";
            this.reg_password_lbl.Size = new System.Drawing.Size(58, 26);
            this.reg_password_lbl.TabIndex = 2;
            this.reg_password_lbl.Text = "Jelszó";
            // 
            // reg_username_lbl
            // 
            this.reg_username_lbl.AutoSize = true;
            this.reg_username_lbl.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reg_username_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reg_username_lbl.Location = new System.Drawing.Point(53, 154);
            this.reg_username_lbl.Name = "reg_username_lbl";
            this.reg_username_lbl.Size = new System.Drawing.Size(131, 26);
            this.reg_username_lbl.TabIndex = 1;
            this.reg_username_lbl.Text = "Felhasználónév";
            // 
            // register_lbl
            // 
            this.register_lbl.AutoSize = true;
            this.register_lbl.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.register_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.register_lbl.Location = new System.Drawing.Point(86, 15);
            this.register_lbl.Name = "register_lbl";
            this.register_lbl.Size = new System.Drawing.Size(273, 60);
            this.register_lbl.TabIndex = 0;
            this.register_lbl.Text = "Regisztráció";
            // 
            // login_panel
            // 
            this.login_panel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.login_panel.Controls.Add(this.log_rechapta_chbox);
            this.login_panel.Controls.Add(this.label4);
            this.login_panel.Controls.Add(this.login_btn);
            this.login_panel.Controls.Add(this.login_pasword);
            this.login_panel.Controls.Add(this.label3);
            this.login_panel.Controls.Add(this.login_username);
            this.login_panel.Controls.Add(this.label2);
            this.login_panel.Location = new System.Drawing.Point(710, 71);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(472, 600);
            this.login_panel.TabIndex = 2;
            // 
            // computer_name_lbl
            // 
            this.computer_name_lbl.AutoSize = true;
            this.computer_name_lbl.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computer_name_lbl.Location = new System.Drawing.Point(12, 24);
            this.computer_name_lbl.Name = "computer_name_lbl";
            this.computer_name_lbl.Size = new System.Drawing.Size(125, 22);
            this.computer_name_lbl.TabIndex = 3;
            this.computer_name_lbl.Text = "Gépnév";
            // 
            // register_username
            // 
            this.register_username.Location = new System.Drawing.Point(190, 159);
            this.register_username.Name = "register_username";
            this.register_username.Size = new System.Drawing.Size(169, 20);
            this.register_username.TabIndex = 4;
            // 
            // register_password
            // 
            this.register_password.Location = new System.Drawing.Point(190, 213);
            this.register_password.Name = "register_password";
            this.register_password.Size = new System.Drawing.Size(169, 20);
            this.register_password.TabIndex = 5;
            // 
            // register_password_again
            // 
            this.register_password_again.Location = new System.Drawing.Point(190, 265);
            this.register_password_again.Name = "register_password_again";
            this.register_password_again.Size = new System.Drawing.Size(169, 20);
            this.register_password_again.TabIndex = 6;
            // 
            // login_pasword
            // 
            this.login_pasword.Location = new System.Drawing.Point(216, 269);
            this.login_pasword.Name = "login_pasword";
            this.login_pasword.Size = new System.Drawing.Size(169, 20);
            this.login_pasword.TabIndex = 12;
            // 
            // login_username
            // 
            this.login_username.Location = new System.Drawing.Point(216, 215);
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(169, 20);
            this.login_username.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(152, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Jelszó";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(79, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Felhasználónév";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(90, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 60);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bejelentkezés";
            // 
            // register_btn
            // 
            this.register_btn.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn.Location = new System.Drawing.Point(122, 391);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(169, 44);
            this.register_btn.TabIndex = 7;
            this.register_btn.Text = "Regisztrálok";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // reg_rechapta_chbox
            // 
            this.reg_rechapta_chbox.AutoSize = true;
            this.reg_rechapta_chbox.Location = new System.Drawing.Point(131, 340);
            this.reg_rechapta_chbox.Name = "reg_rechapta_chbox";
            this.reg_rechapta_chbox.Size = new System.Drawing.Size(113, 17);
            this.reg_rechapta_chbox.TabIndex = 8;
            this.reg_rechapta_chbox.Text = "Nem vagyok robot";
            this.reg_rechapta_chbox.UseVisualStyleBackColor = true;
            this.reg_rechapta_chbox.CheckedChanged += new System.EventHandler(this.reg_rechapta_chbox_CheckedChanged);
            // 
            // log_rechapta_chbox
            // 
            this.log_rechapta_chbox.AutoSize = true;
            this.log_rechapta_chbox.Location = new System.Drawing.Point(166, 318);
            this.log_rechapta_chbox.Name = "log_rechapta_chbox";
            this.log_rechapta_chbox.Size = new System.Drawing.Size(113, 17);
            this.log_rechapta_chbox.TabIndex = 10;
            this.log_rechapta_chbox.Text = "Nem vagyok robot";
            this.log_rechapta_chbox.UseVisualStyleBackColor = true;
            this.log_rechapta_chbox.CheckedChanged += new System.EventHandler(this.log_rechapta_chbox_CheckedChanged);
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Location = new System.Drawing.Point(157, 369);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(182, 44);
            this.login_btn.TabIndex = 9;
            this.login_btn.Text = "Bejelentkezek";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // Mr_Lucky_main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 683);
            this.ControlBox = false;
            this.Controls.Add(this.computer_name_lbl);
            this.Controls.Add(this.login_panel);
            this.Controls.Add(this.register_panel);
            this.Controls.Add(this.exit_btn);
            this.Name = "Mr_Lucky_main_menu";
            this.Text = "Mr.Lucky Menü";
            this.Load += new System.EventHandler(this.Mr_Lucky_main_menu_Load);
            this.register_panel.ResumeLayout(false);
            this.register_panel.PerformLayout();
            this.login_panel.ResumeLayout(false);
            this.login_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Panel register_panel;
        private System.Windows.Forms.Panel login_panel;
        private System.Windows.Forms.Label reg_password_again;
        private System.Windows.Forms.Label reg_password_lbl;
        private System.Windows.Forms.Label reg_username_lbl;
        private System.Windows.Forms.Label register_lbl;
        private System.Windows.Forms.Label computer_name_lbl;
        private System.Windows.Forms.TextBox register_password_again;
        private System.Windows.Forms.TextBox register_password;
        private System.Windows.Forms.TextBox register_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox login_pasword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.CheckBox reg_rechapta_chbox;
        private System.Windows.Forms.CheckBox log_rechapta_chbox;
        private System.Windows.Forms.Button login_btn;
    }
}

