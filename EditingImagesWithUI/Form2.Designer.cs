namespace EditingImagesWithUI
{
    partial class Error
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
            errorText = new Label();
            closeButton = new Button();
            SuspendLayout();
            // 
            // errorText
            // 
            errorText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            errorText.AutoSize = true;
            errorText.Location = new Point(39, 9);
            errorText.Name = "errorText";
            errorText.Size = new Size(173, 15);
            errorText.TabIndex = 0;
            errorText.Text = "Input the correct numeric value";
            errorText.TextAlign = ContentAlignment.TopCenter;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            closeButton.Location = new Point(93, 40);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(62, 23);
            closeButton.TabIndex = 1;
            closeButton.Text = "OK";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // Error
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(237, 75);
            Controls.Add(closeButton);
            Controls.Add(errorText);
            Name = "Error";
            Text = "Error: Invalid Input";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label errorText;
        private Button closeButton;
    }
}