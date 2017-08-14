namespace COMP123_Sumer2017_Assignment5._4
{
    partial class BMICalculatorForm
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
            this.Calculate = new System.Windows.Forms.Label();
            this.MaleButton = new System.Windows.Forms.Button();
            this.FemaleButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.AutoSize = true;
            this.Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate.Location = new System.Drawing.Point(135, 103);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(356, 39);
            this.Calculate.TabIndex = 0;
            this.Calculate.Text = "Calculate Body Mass";
            // 
            // MaleButton
            // 
            this.MaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleButton.Location = new System.Drawing.Point(98, 302);
            this.MaleButton.Name = "MaleButton";
            this.MaleButton.Size = new System.Drawing.Size(173, 45);
            this.MaleButton.TabIndex = 1;
            this.MaleButton.Text = "Male";
            this.MaleButton.UseVisualStyleBackColor = true;
            // 
            // FemaleButon
            // 
            this.FemaleButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemaleButon.Location = new System.Drawing.Point(346, 302);
            this.FemaleButon.Name = "FemaleButon";
            this.FemaleButon.Size = new System.Drawing.Size(168, 45);
            this.FemaleButon.TabIndex = 2;
            this.FemaleButon.Text = "Female";
            this.FemaleButon.UseVisualStyleBackColor = true;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 510);
            this.Controls.Add(this.FemaleButon);
            this.Controls.Add(this.MaleButton);
            this.Controls.Add(this.Calculate);
            this.Name = "BMICalculatorForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Calculate;
        private System.Windows.Forms.Button MaleButton;
        private System.Windows.Forms.Button FemaleButon;
    }
}

