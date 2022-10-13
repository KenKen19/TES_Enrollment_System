
namespace TES_Enrollment_System
{
    partial class Login_Form
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
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.txt_user_input = new System.Windows.Forms.TextBox();
            this.txt_pass_input = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(134, 442);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(227, 50);
            this.btn_Confirm.TabIndex = 2;
            this.btn_Confirm.Text = "Login ";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(134, 498);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(227, 50);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // txt_user_input
            // 
            this.txt_user_input.Location = new System.Drawing.Point(134, 320);
            this.txt_user_input.Multiline = true;
            this.txt_user_input.Name = "txt_user_input";
            this.txt_user_input.Size = new System.Drawing.Size(227, 42);
            this.txt_user_input.TabIndex = 4;
            // 
            // txt_pass_input
            // 
            this.txt_pass_input.Location = new System.Drawing.Point(134, 368);
            this.txt_pass_input.Multiline = true;
            this.txt_pass_input.Name = "txt_pass_input";
            this.txt_pass_input.Size = new System.Drawing.Size(227, 42);
            this.txt_pass_input.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TES_Enrollment_System.Properties.Resources.TESLogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(195, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 103);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 611);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_pass_input);
            this.Controls.Add(this.txt_user_input);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Confirm);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tucdao Elementary School Enrollment System";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Login_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox txt_user_input;
        private System.Windows.Forms.TextBox txt_pass_input;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

