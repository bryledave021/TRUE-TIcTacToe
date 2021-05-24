
namespace TicTacToeGame
{
    partial class IntroForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_Instructions = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Play
            // 
            this.btn_Play.Location = new System.Drawing.Point(30, 97);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(145, 51);
            this.btn_Play.TabIndex = 0;
            this.btn_Play.Text = "Play";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_Instructions
            // 
            this.btn_Instructions.Location = new System.Drawing.Point(30, 154);
            this.btn_Instructions.Name = "btn_Instructions";
            this.btn_Instructions.Size = new System.Drawing.Size(145, 51);
            this.btn_Instructions.TabIndex = 1;
            this.btn_Instructions.Text = "How To Play";
            this.btn_Instructions.UseVisualStyleBackColor = true;
            this.btn_Instructions.Click += new System.EventHandler(this.btn_Instructions_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(30, 211);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(145, 45);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Title.Location = new System.Drawing.Point(12, 24);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(183, 53);
            this.lbl_Title.TabIndex = 4;
            this.lbl_Title.Text = "TIC  TAC TOE GAME";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IntroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 288);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Instructions);
            this.Controls.Add(this.btn_Play);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IntroForm";
            this.Text = "Tic Tac Toe Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_Instructions;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_Title;
    }
}

