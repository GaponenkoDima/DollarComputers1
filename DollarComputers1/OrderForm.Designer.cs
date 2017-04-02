namespace DollarComputers1
{
    partial class OrderForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.componentsGroupBox = new System.Windows.Forms.GroupBox();
            this.osLabel = new System.Windows.Forms.Label();
            this.webCamLabel = new System.Windows.Forms.Label();
            this.gpuTypeLabel = new System.Windows.Forms.Label();
            this.hddLabel = new System.Windows.Forms.Label();
            this.cpuSpeedLabel = new System.Windows.Forms.Label();
            this.cpuNumberLabel = new System.Windows.Forms.Label();
            this.cpuTypeLabel = new System.Windows.Forms.Label();
            this.cpuBrandLabel = new System.Windows.Forms.Label();
            this.memoryLabel = new System.Windows.Forms.Label();
            this.lcdSizeLabel = new System.Windows.Forms.Label();
            this.summaryListBox = new System.Windows.Forms.ListBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.platformTextBox = new System.Windows.Forms.TextBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.platformLabel = new System.Windows.Forms.Label();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.conditionTextBox = new System.Windows.Forms.TextBox();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.computerPictureBox = new System.Windows.Forms.PictureBox();
            this.priceGroupBox = new System.Windows.Forms.GroupBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxTextBox = new System.Windows.Forms.TextBox();
            this.pricceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.salesTaxLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.componentsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).BeginInit();
            this.priceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(810, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // componentsGroupBox
            // 
            this.componentsGroupBox.Controls.Add(this.osLabel);
            this.componentsGroupBox.Controls.Add(this.webCamLabel);
            this.componentsGroupBox.Controls.Add(this.gpuTypeLabel);
            this.componentsGroupBox.Controls.Add(this.hddLabel);
            this.componentsGroupBox.Controls.Add(this.cpuSpeedLabel);
            this.componentsGroupBox.Controls.Add(this.cpuNumberLabel);
            this.componentsGroupBox.Controls.Add(this.cpuTypeLabel);
            this.componentsGroupBox.Controls.Add(this.cpuBrandLabel);
            this.componentsGroupBox.Controls.Add(this.memoryLabel);
            this.componentsGroupBox.Controls.Add(this.lcdSizeLabel);
            this.componentsGroupBox.Controls.Add(this.summaryListBox);
            this.componentsGroupBox.Controls.Add(this.modelTextBox);
            this.componentsGroupBox.Controls.Add(this.platformTextBox);
            this.componentsGroupBox.Controls.Add(this.modelLabel);
            this.componentsGroupBox.Controls.Add(this.platformLabel);
            this.componentsGroupBox.Controls.Add(this.manufacturerTextBox);
            this.componentsGroupBox.Controls.Add(this.conditionTextBox);
            this.componentsGroupBox.Controls.Add(this.manufacturerLabel);
            this.componentsGroupBox.Controls.Add(this.conditionLabel);
            this.componentsGroupBox.Location = new System.Drawing.Point(13, 28);
            this.componentsGroupBox.Name = "componentsGroupBox";
            this.componentsGroupBox.Size = new System.Drawing.Size(376, 401);
            this.componentsGroupBox.TabIndex = 1;
            this.componentsGroupBox.TabStop = false;
            this.componentsGroupBox.Text = "System Components";
            // 
            // osLabel
            // 
            this.osLabel.AutoSize = true;
            this.osLabel.Location = new System.Drawing.Point(53, 377);
            this.osLabel.Name = "osLabel";
            this.osLabel.Size = new System.Drawing.Size(22, 13);
            this.osLabel.TabIndex = 18;
            this.osLabel.Text = "OS";
            // 
            // webCamLabel
            // 
            this.webCamLabel.AutoSize = true;
            this.webCamLabel.Location = new System.Drawing.Point(27, 348);
            this.webCamLabel.Name = "webCamLabel";
            this.webCamLabel.Size = new System.Drawing.Size(51, 13);
            this.webCamLabel.TabIndex = 17;
            this.webCamLabel.Text = "WebCam";
            // 
            // gpuTypeLabel
            // 
            this.gpuTypeLabel.AutoSize = true;
            this.gpuTypeLabel.Location = new System.Drawing.Point(18, 316);
            this.gpuTypeLabel.Name = "gpuTypeLabel";
            this.gpuTypeLabel.Size = new System.Drawing.Size(57, 13);
            this.gpuTypeLabel.TabIndex = 16;
            this.gpuTypeLabel.Text = "GPU Type";
            // 
            // hddLabel
            // 
            this.hddLabel.AutoSize = true;
            this.hddLabel.Location = new System.Drawing.Point(44, 284);
            this.hddLabel.Name = "hddLabel";
            this.hddLabel.Size = new System.Drawing.Size(31, 13);
            this.hddLabel.TabIndex = 15;
            this.hddLabel.Text = "HDD";
            // 
            // cpuSpeedLabel
            // 
            this.cpuSpeedLabel.AutoSize = true;
            this.cpuSpeedLabel.Location = new System.Drawing.Point(12, 255);
            this.cpuSpeedLabel.Name = "cpuSpeedLabel";
            this.cpuSpeedLabel.Size = new System.Drawing.Size(63, 13);
            this.cpuSpeedLabel.TabIndex = 14;
            this.cpuSpeedLabel.Text = "CPU Speed";
            // 
            // cpuNumberLabel
            // 
            this.cpuNumberLabel.AutoSize = true;
            this.cpuNumberLabel.Location = new System.Drawing.Point(9, 226);
            this.cpuNumberLabel.Name = "cpuNumberLabel";
            this.cpuNumberLabel.Size = new System.Drawing.Size(69, 13);
            this.cpuNumberLabel.TabIndex = 13;
            this.cpuNumberLabel.Text = "CPU Number";
            // 
            // cpuTypeLabel
            // 
            this.cpuTypeLabel.AutoSize = true;
            this.cpuTypeLabel.Location = new System.Drawing.Point(21, 199);
            this.cpuTypeLabel.Name = "cpuTypeLabel";
            this.cpuTypeLabel.Size = new System.Drawing.Size(56, 13);
            this.cpuTypeLabel.TabIndex = 12;
            this.cpuTypeLabel.Text = "CPU Type";
            // 
            // cpuBrandLabel
            // 
            this.cpuBrandLabel.AutoSize = true;
            this.cpuBrandLabel.Location = new System.Drawing.Point(19, 173);
            this.cpuBrandLabel.Name = "cpuBrandLabel";
            this.cpuBrandLabel.Size = new System.Drawing.Size(60, 13);
            this.cpuBrandLabel.TabIndex = 11;
            this.cpuBrandLabel.Text = "CPU Brand";
            // 
            // memoryLabel
            // 
            this.memoryLabel.AutoSize = true;
            this.memoryLabel.Location = new System.Drawing.Point(33, 144);
            this.memoryLabel.Name = "memoryLabel";
            this.memoryLabel.Size = new System.Drawing.Size(44, 13);
            this.memoryLabel.TabIndex = 10;
            this.memoryLabel.Text = "Memory";
            // 
            // lcdSizeLabel
            // 
            this.lcdSizeLabel.AutoSize = true;
            this.lcdSizeLabel.Location = new System.Drawing.Point(27, 113);
            this.lcdSizeLabel.Name = "lcdSizeLabel";
            this.lcdSizeLabel.Size = new System.Drawing.Size(51, 13);
            this.lcdSizeLabel.TabIndex = 9;
            this.lcdSizeLabel.Text = "LCD Size";
            // 
            // summaryListBox
            // 
            this.summaryListBox.FormattingEnabled = true;
            this.summaryListBox.Location = new System.Drawing.Point(84, 113);
            this.summaryListBox.Name = "summaryListBox";
            this.summaryListBox.Size = new System.Drawing.Size(286, 277);
            this.summaryListBox.TabIndex = 8;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(251, 57);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(119, 20);
            this.modelTextBox.TabIndex = 7;
            // 
            // platformTextBox
            // 
            this.platformTextBox.Location = new System.Drawing.Point(251, 31);
            this.platformTextBox.Name = "platformTextBox";
            this.platformTextBox.Size = new System.Drawing.Size(119, 20);
            this.platformTextBox.TabIndex = 6;
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(209, 58);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(36, 13);
            this.modelLabel.TabIndex = 5;
            this.modelLabel.Text = "Model";
            // 
            // platformLabel
            // 
            this.platformLabel.AutoSize = true;
            this.platformLabel.Location = new System.Drawing.Point(200, 34);
            this.platformLabel.Name = "platformLabel";
            this.platformLabel.Size = new System.Drawing.Size(45, 13);
            this.platformLabel.TabIndex = 4;
            this.platformLabel.Text = "Platform";
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.Location = new System.Drawing.Point(84, 57);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.Size = new System.Drawing.Size(100, 20);
            this.manufacturerTextBox.TabIndex = 3;
            // 
            // conditionTextBox
            // 
            this.conditionTextBox.Location = new System.Drawing.Point(84, 31);
            this.conditionTextBox.Name = "conditionTextBox";
            this.conditionTextBox.Size = new System.Drawing.Size(100, 20);
            this.conditionTextBox.TabIndex = 2;
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Location = new System.Drawing.Point(7, 58);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(70, 13);
            this.manufacturerLabel.TabIndex = 1;
            this.manufacturerLabel.Text = "Manufacturer";
            // 
            // conditionLabel
            // 
            this.conditionLabel.AutoSize = true;
            this.conditionLabel.Location = new System.Drawing.Point(26, 31);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(51, 13);
            this.conditionLabel.TabIndex = 0;
            this.conditionLabel.Text = "Condition";
            // 
            // computerPictureBox
            // 
            this.computerPictureBox.Location = new System.Drawing.Point(396, 35);
            this.computerPictureBox.Name = "computerPictureBox";
            this.computerPictureBox.Size = new System.Drawing.Size(156, 159);
            this.computerPictureBox.TabIndex = 2;
            this.computerPictureBox.TabStop = false;
            // 
            // priceGroupBox
            // 
            this.priceGroupBox.Controls.Add(this.totalTextBox);
            this.priceGroupBox.Controls.Add(this.totalLabel);
            this.priceGroupBox.Controls.Add(this.taxTextBox);
            this.priceGroupBox.Controls.Add(this.pricceTextBox);
            this.priceGroupBox.Controls.Add(this.priceLabel);
            this.priceGroupBox.Controls.Add(this.salesTaxLabel);
            this.priceGroupBox.Location = new System.Drawing.Point(396, 227);
            this.priceGroupBox.Name = "priceGroupBox";
            this.priceGroupBox.Size = new System.Drawing.Size(402, 162);
            this.priceGroupBox.TabIndex = 3;
            this.priceGroupBox.TabStop = false;
            this.priceGroupBox.Text = "Your Price";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(254, 114);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(119, 20);
            this.totalTextBox.TabIndex = 24;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(58, 117);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 13);
            this.totalLabel.TabIndex = 23;
            this.totalLabel.Text = "Total";
            // 
            // taxTextBox
            // 
            this.taxTextBox.Location = new System.Drawing.Point(254, 51);
            this.taxTextBox.Name = "taxTextBox";
            this.taxTextBox.Size = new System.Drawing.Size(119, 20);
            this.taxTextBox.TabIndex = 22;
            // 
            // pricceTextBox
            // 
            this.pricceTextBox.Location = new System.Drawing.Point(254, 27);
            this.pricceTextBox.Name = "pricceTextBox";
            this.pricceTextBox.Size = new System.Drawing.Size(119, 20);
            this.pricceTextBox.TabIndex = 21;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(55, 27);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(34, 13);
            this.priceLabel.TabIndex = 19;
            this.priceLabel.Text = "Price ";
            // 
            // salesTaxLabel
            // 
            this.salesTaxLabel.AutoSize = true;
            this.salesTaxLabel.Location = new System.Drawing.Point(6, 54);
            this.salesTaxLabel.Name = "salesTaxLabel";
            this.salesTaxLabel.Size = new System.Drawing.Size(83, 13);
            this.salesTaxLabel.TabIndex = 20;
            this.salesTaxLabel.Text = "Sales Tax (13%)";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(561, 406);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(642, 406);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(723, 406);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(75, 23);
            this.finishButton.TabIndex = 6;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 441);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.priceGroupBox);
            this.Controls.Add(this.computerPictureBox);
            this.Controls.Add(this.componentsGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrderForm";
            this.Text = "Complete Your Order";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.componentsGroupBox.ResumeLayout(false);
            this.componentsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).EndInit();
            this.priceGroupBox.ResumeLayout(false);
            this.priceGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox componentsGroupBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox platformTextBox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label platformLabel;
        private System.Windows.Forms.TextBox manufacturerTextBox;
        private System.Windows.Forms.TextBox conditionTextBox;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.Label osLabel;
        private System.Windows.Forms.Label webCamLabel;
        private System.Windows.Forms.Label gpuTypeLabel;
        private System.Windows.Forms.Label hddLabel;
        private System.Windows.Forms.Label cpuSpeedLabel;
        private System.Windows.Forms.Label cpuNumberLabel;
        private System.Windows.Forms.Label cpuTypeLabel;
        private System.Windows.Forms.Label cpuBrandLabel;
        private System.Windows.Forms.Label memoryLabel;
        private System.Windows.Forms.Label lcdSizeLabel;
        private System.Windows.Forms.PictureBox computerPictureBox;
        private System.Windows.Forms.GroupBox priceGroupBox;
        private System.Windows.Forms.TextBox taxTextBox;
        private System.Windows.Forms.TextBox pricceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label salesTaxLabel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.ListBox summaryListBox;
    }
}