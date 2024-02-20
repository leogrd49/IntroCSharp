namespace IntroCSharp.WF
{
    partial class FormListChips
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
            ListBoxChips = new ListBox();
            SuspendLayout();
            // 
            // ListBoxChips
            // 
            ListBoxChips.FormattingEnabled = true;
            ListBoxChips.Location = new Point(84, 22);
            ListBoxChips.Name = "ListBoxChips";
            ListBoxChips.Size = new Size(151, 344);
            ListBoxChips.TabIndex = 0;
            ListBoxChips.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // FormListChips
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListBoxChips);
            Name = "FormListChips";
            Text = "FormListChips";
            ResumeLayout(false);
        }

        #endregion

        private ListBox ListBoxChips;
    }
}