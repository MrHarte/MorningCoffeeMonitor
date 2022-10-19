namespace MorningCoffeeMonitor
{
    partial class MonitorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitorForm));
            this.CarafePictureBox = new System.Windows.Forms.PictureBox();
            this.MakerPictureBox = new System.Windows.Forms.PictureBox();
            this.MakerStatusLabel = new System.Windows.Forms.Label();
            this.CarafeLevelLabel = new System.Windows.Forms.Label();
            this.AliceLevelLabel = new System.Windows.Forms.Label();
            this.BobLevelLabel = new System.Windows.Forms.Label();
            this.BobMugPictureBox = new System.Windows.Forms.PictureBox();
            this.AliceMugPictureBox = new System.Windows.Forms.PictureBox();
            this.FillAliceMugButton = new System.Windows.Forms.Button();
            this.FillBobMugButton = new System.Windows.Forms.Button();
            this.AliceLabel = new System.Windows.Forms.Label();
            this.AliceDrinkButton = new System.Windows.Forms.Button();
            this.AlicePrepareButton = new System.Windows.Forms.Button();
            this.BobPrepareButton = new System.Windows.Forms.Button();
            this.BobDrinkButton = new System.Windows.Forms.Button();
            this.BobLabel = new System.Windows.Forms.Label();
            this.MakeCoffeeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CarafePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MakerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BobMugPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AliceMugPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CarafePictureBox
            // 
            this.CarafePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("CarafePictureBox.Image")));
            this.CarafePictureBox.Location = new System.Drawing.Point(166, 12);
            this.CarafePictureBox.Name = "CarafePictureBox";
            this.CarafePictureBox.Size = new System.Drawing.Size(160, 182);
            this.CarafePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CarafePictureBox.TabIndex = 0;
            this.CarafePictureBox.TabStop = false;
            // 
            // MakerPictureBox
            // 
            this.MakerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MakerPictureBox.Image")));
            this.MakerPictureBox.Location = new System.Drawing.Point(12, 12);
            this.MakerPictureBox.Name = "MakerPictureBox";
            this.MakerPictureBox.Size = new System.Drawing.Size(148, 182);
            this.MakerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MakerPictureBox.TabIndex = 1;
            this.MakerPictureBox.TabStop = false;
            // 
            // MakerStatusLabel
            // 
            this.MakerStatusLabel.AutoSize = true;
            this.MakerStatusLabel.ForeColor = System.Drawing.Color.Green;
            this.MakerStatusLabel.Location = new System.Drawing.Point(24, 197);
            this.MakerStatusLabel.Name = "MakerStatusLabel";
            this.MakerStatusLabel.Size = new System.Drawing.Size(124, 15);
            this.MakerStatusLabel.TabIndex = 2;
            this.MakerStatusLabel.Text = "Ready To Make Coffee";
            // 
            // CarafeLevelLabel
            // 
            this.CarafeLevelLabel.AutoSize = true;
            this.CarafeLevelLabel.Location = new System.Drawing.Point(209, 197);
            this.CarafeLevelLabel.Name = "CarafeLevelLabel";
            this.CarafeLevelLabel.Size = new System.Drawing.Size(62, 15);
            this.CarafeLevelLabel.TabIndex = 3;
            this.CarafeLevelLabel.Text = "Level: 50%";
            // 
            // AliceLevelLabel
            // 
            this.AliceLevelLabel.AutoSize = true;
            this.AliceLevelLabel.Location = new System.Drawing.Point(164, 307);
            this.AliceLevelLabel.Name = "AliceLevelLabel";
            this.AliceLevelLabel.Size = new System.Drawing.Size(62, 15);
            this.AliceLevelLabel.TabIndex = 4;
            this.AliceLevelLabel.Text = "Level: 30%";
            // 
            // BobLevelLabel
            // 
            this.BobLevelLabel.AutoSize = true;
            this.BobLevelLabel.Location = new System.Drawing.Point(164, 410);
            this.BobLevelLabel.Name = "BobLevelLabel";
            this.BobLevelLabel.Size = new System.Drawing.Size(62, 15);
            this.BobLevelLabel.TabIndex = 5;
            this.BobLevelLabel.Text = "Level: 70%";
            // 
            // BobMugPictureBox
            // 
            this.BobMugPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("BobMugPictureBox.Image")));
            this.BobMugPictureBox.Location = new System.Drawing.Point(145, 357);
            this.BobMugPictureBox.Name = "BobMugPictureBox";
            this.BobMugPictureBox.Size = new System.Drawing.Size(100, 50);
            this.BobMugPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BobMugPictureBox.TabIndex = 7;
            this.BobMugPictureBox.TabStop = false;
            // 
            // AliceMugPictureBox
            // 
            this.AliceMugPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("AliceMugPictureBox.Image")));
            this.AliceMugPictureBox.Location = new System.Drawing.Point(145, 254);
            this.AliceMugPictureBox.Name = "AliceMugPictureBox";
            this.AliceMugPictureBox.Size = new System.Drawing.Size(100, 50);
            this.AliceMugPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AliceMugPictureBox.TabIndex = 8;
            this.AliceMugPictureBox.TabStop = false;
            // 
            // FillAliceMugButton
            // 
            this.FillAliceMugButton.Location = new System.Drawing.Point(251, 275);
            this.FillAliceMugButton.Name = "FillAliceMugButton";
            this.FillAliceMugButton.Size = new System.Drawing.Size(75, 23);
            this.FillAliceMugButton.TabIndex = 9;
            this.FillAliceMugButton.Text = "Fill";
            this.FillAliceMugButton.UseVisualStyleBackColor = true;
            // 
            // FillBobMugButton
            // 
            this.FillBobMugButton.Location = new System.Drawing.Point(251, 368);
            this.FillBobMugButton.Name = "FillBobMugButton";
            this.FillBobMugButton.Size = new System.Drawing.Size(75, 23);
            this.FillBobMugButton.TabIndex = 10;
            this.FillBobMugButton.Text = "Fill";
            this.FillBobMugButton.UseVisualStyleBackColor = true;
            // 
            // AliceLabel
            // 
            this.AliceLabel.AutoSize = true;
            this.AliceLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AliceLabel.Location = new System.Drawing.Point(12, 248);
            this.AliceLabel.Name = "AliceLabel";
            this.AliceLabel.Size = new System.Drawing.Size(59, 30);
            this.AliceLabel.TabIndex = 11;
            this.AliceLabel.Text = "Alice";
            // 
            // AliceDrinkButton
            // 
            this.AliceDrinkButton.Location = new System.Drawing.Point(12, 281);
            this.AliceDrinkButton.Name = "AliceDrinkButton";
            this.AliceDrinkButton.Size = new System.Drawing.Size(127, 23);
            this.AliceDrinkButton.TabIndex = 12;
            this.AliceDrinkButton.Text = "Drink a sip";
            this.AliceDrinkButton.UseVisualStyleBackColor = true;
            // 
            // AlicePrepareButton
            // 
            this.AlicePrepareButton.Location = new System.Drawing.Point(12, 308);
            this.AlicePrepareButton.Name = "AlicePrepareButton";
            this.AlicePrepareButton.Size = new System.Drawing.Size(127, 23);
            this.AlicePrepareButton.TabIndex = 13;
            this.AlicePrepareButton.Text = "Pepare Coffee Maker";
            this.AlicePrepareButton.UseVisualStyleBackColor = true;
            // 
            // BobPrepareButton
            // 
            this.BobPrepareButton.Location = new System.Drawing.Point(12, 408);
            this.BobPrepareButton.Name = "BobPrepareButton";
            this.BobPrepareButton.Size = new System.Drawing.Size(127, 23);
            this.BobPrepareButton.TabIndex = 16;
            this.BobPrepareButton.Text = "Pepare Coffee Maker";
            this.BobPrepareButton.UseVisualStyleBackColor = true;
            // 
            // BobDrinkButton
            // 
            this.BobDrinkButton.Location = new System.Drawing.Point(12, 381);
            this.BobDrinkButton.Name = "BobDrinkButton";
            this.BobDrinkButton.Size = new System.Drawing.Size(127, 23);
            this.BobDrinkButton.TabIndex = 15;
            this.BobDrinkButton.Text = "Drink a sip";
            this.BobDrinkButton.UseVisualStyleBackColor = true;
            // 
            // BobLabel
            // 
            this.BobLabel.AutoSize = true;
            this.BobLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BobLabel.Location = new System.Drawing.Point(12, 348);
            this.BobLabel.Name = "BobLabel";
            this.BobLabel.Size = new System.Drawing.Size(52, 30);
            this.BobLabel.TabIndex = 14;
            this.BobLabel.Text = "Bob";
            // 
            // MakeCoffeeButton
            // 
            this.MakeCoffeeButton.Location = new System.Drawing.Point(12, 215);
            this.MakeCoffeeButton.Name = "MakeCoffeeButton";
            this.MakeCoffeeButton.Size = new System.Drawing.Size(148, 23);
            this.MakeCoffeeButton.TabIndex = 17;
            this.MakeCoffeeButton.Text = "Make Coffee";
            this.MakeCoffeeButton.UseVisualStyleBackColor = true;
            // 
            // MonitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 450);
            this.Controls.Add(this.MakeCoffeeButton);
            this.Controls.Add(this.BobPrepareButton);
            this.Controls.Add(this.BobDrinkButton);
            this.Controls.Add(this.BobLabel);
            this.Controls.Add(this.AlicePrepareButton);
            this.Controls.Add(this.AliceDrinkButton);
            this.Controls.Add(this.AliceLabel);
            this.Controls.Add(this.FillBobMugButton);
            this.Controls.Add(this.FillAliceMugButton);
            this.Controls.Add(this.AliceMugPictureBox);
            this.Controls.Add(this.BobMugPictureBox);
            this.Controls.Add(this.BobLevelLabel);
            this.Controls.Add(this.AliceLevelLabel);
            this.Controls.Add(this.CarafeLevelLabel);
            this.Controls.Add(this.MakerStatusLabel);
            this.Controls.Add(this.MakerPictureBox);
            this.Controls.Add(this.CarafePictureBox);
            this.Name = "MonitorForm";
            this.Text = "Morning Coffee Monitor";
            ((System.ComponentModel.ISupportInitialize)(this.CarafePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MakerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BobMugPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AliceMugPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox CarafePictureBox;
        private PictureBox MakerPictureBox;
        private Label MakerStatusLabel;
        private Label CarafeLevelLabel;
        private Label AliceLevelLabel;
        private Label BobLevelLabel;
        private PictureBox BobMugPictureBox;
        private PictureBox AliceMugPictureBox;
        private Button FillAliceMugButton;
        private Button FillBobMugButton;
        private Label AliceLabel;
        private Button AliceDrinkButton;
        private Button AlicePrepareButton;
        private Button BobPrepareButton;
        private Button BobDrinkButton;
        private Label BobLabel;
        private Button MakeCoffeeButton;
    }
}