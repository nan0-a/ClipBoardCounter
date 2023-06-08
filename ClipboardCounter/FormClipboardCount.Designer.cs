
namespace ClipboardCounter
{
    partial class FormClipBoardCount
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
            this.components = new System.ComponentModel.Container();
            this.char_count_label = new System.Windows.Forms.Label();
            this.clipboard_check_fire = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // char_count_label
            // 
            this.char_count_label.AutoSize = true;
            this.char_count_label.Location = new System.Drawing.Point(12, 9);
            this.char_count_label.Name = "char_count_label";
            this.char_count_label.Size = new System.Drawing.Size(62, 15);
            this.char_count_label.TabIndex = 0;
            this.char_count_label.Text = "Not A Text";
            // 
            // clipboard_check_fire
            // 
            this.clipboard_check_fire.Enabled = true;
            this.clipboard_check_fire.Tick += new System.EventHandler(this.ClipboardCheckFireTick);
            // 
            // FormClipBoardCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(160, 32);
            this.Controls.Add(this.char_count_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormClipBoardCount";
            this.Text = "ClipBoardCount";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormClipboardCounterLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label char_count_label;
        private System.Windows.Forms.Timer clipboard_check_fire;
    }
}

