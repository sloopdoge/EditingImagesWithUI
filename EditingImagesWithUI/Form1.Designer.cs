namespace EditingImagesWithUI
{
    partial class main
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
            imagesAmountInput = new TextBox();
            crewSizeInput = new TextBox();
            calculateTime = new Button();
            totalTimeOutput = new Label();
            SuspendLayout();
            // 
            // imagesAmountInput
            // 
            imagesAmountInput.Location = new Point(12, 12);
            imagesAmountInput.Name = "imagesAmountInput";
            imagesAmountInput.PlaceholderText = "Images Amount";
            imagesAmountInput.Size = new Size(100, 23);
            imagesAmountInput.TabIndex = 0;
            imagesAmountInput.TextChanged += imagesAmountInput_TextChanged;
            // 
            // crewSizeInput
            // 
            crewSizeInput.Location = new Point(12, 56);
            crewSizeInput.Name = "crewSizeInput";
            crewSizeInput.PlaceholderText = "Crew Size";
            crewSizeInput.Size = new Size(100, 23);
            crewSizeInput.TabIndex = 1;
            crewSizeInput.TextChanged += crewSizeInput_TextChanged;
            // 
            // calculateTime
            // 
            calculateTime.Location = new Point(12, 99);
            calculateTime.Name = "calculateTime";
            calculateTime.Size = new Size(100, 23);
            calculateTime.TabIndex = 2;
            calculateTime.Text = "Calculate time";
            calculateTime.UseVisualStyleBackColor = true;
            calculateTime.Click += calculateTime_Click;
            // 
            // totalTimeOutput
            // 
            totalTimeOutput.AutoSize = true;
            totalTimeOutput.Location = new Point(12, 140);
            totalTimeOutput.Name = "totalTimeOutput";
            totalTimeOutput.Size = new Size(59, 15);
            totalTimeOutput.TabIndex = 3;
            totalTimeOutput.Text = "Total time";
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 450);
            Controls.Add(totalTimeOutput);
            Controls.Add(calculateTime);
            Controls.Add(crewSizeInput);
            Controls.Add(imagesAmountInput);
            Name = "main";
            Text = "Editing Images";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox imagesAmountInput;
        private TextBox crewSizeInput;
        private Button calculateTime;
        private Label totalTimeOutput;
    }
}