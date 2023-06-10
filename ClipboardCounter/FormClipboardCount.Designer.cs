
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
            components = new System.ComponentModel.Container();
            char_count_label = new System.Windows.Forms.Label();
            clipboard_check_fire = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // char_count_label
            // 
            char_count_label.AutoSize = true;
            char_count_label.Location = new System.Drawing.Point(12, 9);
            char_count_label.Name = "char_count_label";
            char_count_label.Size = new System.Drawing.Size(62, 15);
            char_count_label.TabIndex = 0;
            char_count_label.Text = "Not A Text";
            // 
            // clipboard_check_fire
            // 
            clipboard_check_fire.Enabled = true;
            clipboard_check_fire.Tick += ClipboardCheckFireTick;
            // 
            // FormClipBoardCount
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(160, 83);
            Controls.Add(char_count_label);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "FormClipBoardCount";
            Text = "ClipBoardCount";
            TopMost = true;
            Load += FormClipboardCounterLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label char_count_label;
        private System.Windows.Forms.Timer clipboard_check_fire;
    }
}

