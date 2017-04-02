namespace DollarComputers1
{
    partial class SelectForm
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.hardwareDataGridView = new System.Windows.Forms.DataGridView();
            this.yourSelectionLabed = new System.Windows.Forms.Label();
            this.yourSelectionTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Location = new System.Drawing.Point(13, 13);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(147, 13);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "DollarComputer Hardware List";
            // 
            // hardwareDataGridView
            // 
            this.hardwareDataGridView.AllowUserToAddRows = false;
            this.hardwareDataGridView.AllowUserToDeleteRows = false;
            this.hardwareDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hardwareDataGridView.Location = new System.Drawing.Point(13, 30);
            this.hardwareDataGridView.Name = "hardwareDataGridView";
            this.hardwareDataGridView.ReadOnly = true;
            this.hardwareDataGridView.Size = new System.Drawing.Size(746, 345);
            this.hardwareDataGridView.TabIndex = 1;
            // 
            // yourSelectionLabed
            // 
            this.yourSelectionLabed.AutoSize = true;
            this.yourSelectionLabed.Location = new System.Drawing.Point(10, 403);
            this.yourSelectionLabed.Name = "yourSelectionLabed";
            this.yourSelectionLabed.Size = new System.Drawing.Size(76, 13);
            this.yourSelectionLabed.TabIndex = 2;
            this.yourSelectionLabed.Text = "Your Selection";
            // 
            // yourSelectionTextBox
            // 
            this.yourSelectionTextBox.Location = new System.Drawing.Point(204, 400);
            this.yourSelectionTextBox.Name = "yourSelectionTextBox";
            this.yourSelectionTextBox.Size = new System.Drawing.Size(354, 20);
            this.yourSelectionTextBox.TabIndex = 3;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(596, 400);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(677, 400);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 439);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.yourSelectionTextBox);
            this.Controls.Add(this.yourSelectionLabed);
            this.Controls.Add(this.hardwareDataGridView);
            this.Controls.Add(this.HeaderLabel);
            this.Name = "SelectForm";
            this.Text = "Select Your Computer";
            this.Load += new System.EventHandler(this.SelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hardwareDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.DataGridView hardwareDataGridView;
        private System.Windows.Forms.Label yourSelectionLabed;
        private System.Windows.Forms.TextBox yourSelectionTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button nextButton;
    }
}