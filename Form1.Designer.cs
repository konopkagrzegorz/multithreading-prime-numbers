namespace Multithreading
{
    partial class PrimeNumberFinder
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOneThread = new System.Windows.Forms.Button();
            this.btnMultithreading = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.LabelTotalTime = new System.Windows.Forms.Label();
            this.TextBoxTotalTime = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.CelingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOneThread
            // 
            this.btnOneThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOneThread.Location = new System.Drawing.Point(12, 80);
            this.btnOneThread.Name = "btnOneThread";
            this.btnOneThread.Size = new System.Drawing.Size(161, 75);
            this.btnOneThread.TabIndex = 0;
            this.btnOneThread.Text = "Znajdz jednowątkowo";
            this.btnOneThread.UseVisualStyleBackColor = true;
            this.btnOneThread.Click += new System.EventHandler(this.btnOneThread_Click);
            // 
            // btnMultithreading
            // 
            this.btnMultithreading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMultithreading.Location = new System.Drawing.Point(192, 80);
            this.btnMultithreading.Name = "btnMultithreading";
            this.btnMultithreading.Size = new System.Drawing.Size(161, 75);
            this.btnMultithreading.TabIndex = 1;
            this.btnMultithreading.Text = "Znajdz wielowątkowo";
            this.btnMultithreading.UseVisualStyleBackColor = true;
            this.btnMultithreading.Click += new System.EventHandler(this.btnMultithreading_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(12, 170);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(341, 281);
            this.outputTextBox.TabIndex = 2;
            this.outputTextBox.Text = "";
            // 
            // LabelTotalTime
            // 
            this.LabelTotalTime.AutoSize = true;
            this.LabelTotalTime.Location = new System.Drawing.Point(12, 473);
            this.LabelTotalTime.Name = "LabelTotalTime";
            this.LabelTotalTime.Size = new System.Drawing.Size(82, 13);
            this.LabelTotalTime.TabIndex = 3;
            this.LabelTotalTime.Text = "Całkowity czas:";
            // 
            // TextBoxTotalTime
            // 
            this.TextBoxTotalTime.Location = new System.Drawing.Point(100, 470);
            this.TextBoxTotalTime.Name = "TextBoxTotalTime";
            this.TextBoxTotalTime.Size = new System.Drawing.Size(80, 20);
            this.TextBoxTotalTime.TabIndex = 4;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(278, 467);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Czyść";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(233, 42);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // CelingLabel
            // 
            this.CelingLabel.AutoSize = true;
            this.CelingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CelingLabel.Location = new System.Drawing.Point(115, 9);
            this.CelingLabel.Name = "CelingLabel";
            this.CelingLabel.Size = new System.Drawing.Size(238, 16);
            this.CelingLabel.TabIndex = 7;
            this.CelingLabel.Text = "Ile liczb naturalnych chcesz sprawdzic?";
            // 
            // PrimeNumberFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 495);
            this.Controls.Add(this.CelingLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.TextBoxTotalTime);
            this.Controls.Add(this.LabelTotalTime);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.btnMultithreading);
            this.Controls.Add(this.btnOneThread);
            this.Name = "PrimeNumberFinder";
            this.Text = "Find Prime Numbers";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOneThread;
        private System.Windows.Forms.Button btnMultithreading;
        private System.Windows.Forms.RichTextBox outputTextBox;
        private System.Windows.Forms.Label LabelTotalTime;
        private System.Windows.Forms.TextBox TextBoxTotalTime;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label CelingLabel;
    }
}

