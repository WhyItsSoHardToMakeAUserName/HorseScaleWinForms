namespace HorseScale
{
    partial class Form1
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
            menuStrip2 = new MenuStrip();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            setCmPerPxToolStripMenuItem = new ToolStripMenuItem();
            measureDistanceToolStripMenuItem = new ToolStripMenuItem();
            StratTakingMeasurementsStripMenuItem = new ToolStripMenuItem();
            uploadToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            PasternGirthLabel = new Label();
            HorseBreedLabel = new Label();
            HorseMassLabel = new Label();
            ChestCircumferenceLabel = new Label();
            ObliqueBodyLengthLabel = new Label();
            HeightAtTheWithersLabel = new Label();
            DistanceLabel = new Label();
            Point2Label = new Label();
            Point1Label = new Label();
            CmPerPxLabel = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolsToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(712, 24);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { setCmPerPxToolStripMenuItem, measureDistanceToolStripMenuItem, StratTakingMeasurementsStripMenuItem, uploadToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(46, 20);
            toolsToolStripMenuItem.Text = "Tools";
            toolsToolStripMenuItem.Click += toolsToolStripMenuItem_Click;
            // 
            // setCmPerPxToolStripMenuItem
            // 
            setCmPerPxToolStripMenuItem.Name = "setCmPerPxToolStripMenuItem";
            setCmPerPxToolStripMenuItem.Size = new Size(281, 22);
            setCmPerPxToolStripMenuItem.Text = "Установить См на Пиксель";
            setCmPerPxToolStripMenuItem.Click += setCmPerPxToolStripMenuItem_Click;
            // 
            // measureDistanceToolStripMenuItem
            // 
            measureDistanceToolStripMenuItem.Name = "measureDistanceToolStripMenuItem";
            measureDistanceToolStripMenuItem.Size = new Size(281, 22);
            measureDistanceToolStripMenuItem.Text = "Измерить дистанцию между точками";
            measureDistanceToolStripMenuItem.Click += measureDistanceToolStripMenuItem_Click;
            // 
            // StratTakingMeasurementsStripMenuItem
            // 
            StratTakingMeasurementsStripMenuItem.Name = "StratTakingMeasurementsStripMenuItem";
            StratTakingMeasurementsStripMenuItem.Size = new Size(281, 22);
            StratTakingMeasurementsStripMenuItem.Text = "Начать измерение промеров";
            StratTakingMeasurementsStripMenuItem.Click += начатьИзмерениеПромеровToolStripMenuItem_Click;
            // 
            // uploadToolStripMenuItem
            // 
            uploadToolStripMenuItem.Name = "uploadToolStripMenuItem";
            uploadToolStripMenuItem.Size = new Size(281, 22);
            uploadToolStripMenuItem.Text = "Загрузить Изображение";
            uploadToolStripMenuItem.Click += загрузитьИзображениеToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 23);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(PasternGirthLabel);
            panel1.Controls.Add(HorseBreedLabel);
            panel1.Controls.Add(HorseMassLabel);
            panel1.Controls.Add(ChestCircumferenceLabel);
            panel1.Controls.Add(ObliqueBodyLengthLabel);
            panel1.Controls.Add(HeightAtTheWithersLabel);
            panel1.Controls.Add(DistanceLabel);
            panel1.Controls.Add(Point2Label);
            panel1.Controls.Add(Point1Label);
            panel1.Controls.Add(CmPerPxLabel);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(712, 524);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint_2;
            // 
            // PasternGirthLabel
            // 
            PasternGirthLabel.AutoSize = true;
            PasternGirthLabel.Font = new Font("Segoe UI", 16F);
            PasternGirthLabel.Location = new Point(12, 291);
            PasternGirthLabel.Name = "PasternGirthLabel";
            PasternGirthLabel.Size = new Size(168, 30);
            PasternGirthLabel.TabIndex = 13;
            PasternGirthLabel.Text = "Обхват пясти - ";
            // 
            // HorseBreedLabel
            // 
            HorseBreedLabel.AutoSize = true;
            HorseBreedLabel.Font = new Font("Segoe UI", 16F);
            HorseBreedLabel.Location = new Point(12, 158);
            HorseBreedLabel.Name = "HorseBreedLabel";
            HorseBreedLabel.Size = new Size(299, 30);
            HorseBreedLabel.TabIndex = 12;
            HorseBreedLabel.Text = "Порода выбранной лошади";
            HorseBreedLabel.Click += HorseBreedLabel_Click;
            // 
            // HorseMassLabel
            // 
            HorseMassLabel.AutoSize = true;
            HorseMassLabel.Font = new Font("Segoe UI", 16F);
            HorseMassLabel.Location = new Point(12, 128);
            HorseMassLabel.Name = "HorseMassLabel";
            HorseMassLabel.Size = new Size(298, 30);
            HorseMassLabel.TabIndex = 11;
            HorseMassLabel.Text = "Масса выбранной лошади -";
            // 
            // ChestCircumferenceLabel
            // 
            ChestCircumferenceLabel.AutoSize = true;
            ChestCircumferenceLabel.Font = new Font("Segoe UI", 16F);
            ChestCircumferenceLabel.Location = new Point(11, 261);
            ChestCircumferenceLabel.Name = "ChestCircumferenceLabel";
            ChestCircumferenceLabel.Size = new Size(163, 30);
            ChestCircumferenceLabel.TabIndex = 10;
            ChestCircumferenceLabel.Text = "Обхват груди -";
            // 
            // ObliqueBodyLengthLabel
            // 
            ObliqueBodyLengthLabel.AutoSize = true;
            ObliqueBodyLengthLabel.Font = new Font("Segoe UI", 16F);
            ObliqueBodyLengthLabel.Location = new Point(11, 231);
            ObliqueBodyLengthLabel.Name = "ObliqueBodyLengthLabel";
            ObliqueBodyLengthLabel.Size = new Size(203, 30);
            ObliqueBodyLengthLabel.TabIndex = 9;
            ObliqueBodyLengthLabel.Text = "Косая длина тела -";
            ObliqueBodyLengthLabel.Click += label1_Click_1;
            // 
            // HeightAtTheWithersLabel
            // 
            HeightAtTheWithersLabel.AutoSize = true;
            HeightAtTheWithersLabel.Font = new Font("Segoe UI", 16F);
            HeightAtTheWithersLabel.Location = new Point(11, 201);
            HeightAtTheWithersLabel.Name = "HeightAtTheWithersLabel";
            HeightAtTheWithersLabel.Size = new Size(182, 30);
            HeightAtTheWithersLabel.TabIndex = 8;
            HeightAtTheWithersLabel.Text = "Высота в холке -";
            HeightAtTheWithersLabel.Click += HeightAtTheWithers_Click;
            // 
            // DistanceLabel
            // 
            DistanceLabel.AutoSize = true;
            DistanceLabel.Font = new Font("Segoe UI", 16F);
            DistanceLabel.Location = new Point(11, 98);
            DistanceLabel.Name = "DistanceLabel";
            DistanceLabel.Size = new Size(399, 30);
            DistanceLabel.TabIndex = 6;
            DistanceLabel.Text = "Дистанция между двумя точками в см";
            // 
            // Point2Label
            // 
            Point2Label.AutoSize = true;
            Point2Label.Font = new Font("Segoe UI", 16F);
            Point2Label.Location = new Point(11, 38);
            Point2Label.Name = "Point2Label";
            Point2Label.Size = new Size(293, 30);
            Point2Label.TabIndex = 5;
            Point2Label.Text = "Координаты второй точки |";
            // 
            // Point1Label
            // 
            Point1Label.AutoSize = true;
            Point1Label.Font = new Font("Segoe UI", 16F);
            Point1Label.Location = new Point(12, 6);
            Point1Label.Name = "Point1Label";
            Point1Label.Size = new Size(296, 30);
            Point1Label.TabIndex = 4;
            Point1Label.Text = "Координаты первой точки |";
            // 
            // CmPerPxLabel
            // 
            CmPerPxLabel.AutoSize = true;
            CmPerPxLabel.Font = new Font("Segoe UI", 16F);
            CmPerPxLabel.Location = new Point(11, 68);
            CmPerPxLabel.Name = "CmPerPxLabel";
            CmPerPxLabel.Size = new Size(160, 30);
            CmPerPxLabel.TabIndex = 3;
            CmPerPxLabel.Text = "См на пиксель";
            CmPerPxLabel.Click += label1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 548);
            Controls.Add(panel1);
            Controls.Add(menuStrip2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem setCmPerPxToolStripMenuItem;
        private ToolStripMenuItem measureDistanceToolStripMenuItem;
        private ToolStripMenuItem StratTakingMeasurementsStripMenuItem;
        private ToolStripMenuItem uploadToolStripMenuItem;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label CmPerPxLabel;
        private Label Point2Label;
        private Label Point1Label;
        private Label DistanceLabel;
        private Label HeightAtTheWithersLabel;
        private Label ObliqueBodyLengthLabel;
        private Label ChestCircumferenceLabel;
        private ContextMenuStrip contextMenuStrip1;
        private Label HorseBreedLabel;
        private Label HorseMassLabel;
        private Label PasternGirthLabel;
    }
}
