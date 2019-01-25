namespace GameOfLife_PAI
{
    partial class GameOfLife
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
            this.tablePanel_background = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_startParallelThreads = new System.Windows.Forms.Button();
            this.button_startSingleThread = new System.Windows.Forms.Button();
            this.groupBox_settings = new System.Windows.Forms.GroupBox();
            this.numeric_numOfThreads = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numeric_probability = new System.Windows.Forms.NumericUpDown();
            this.label_numOfThreads = new System.Windows.Forms.Label();
            this.numeric_numOfCols = new System.Windows.Forms.NumericUpDown();
            this.label_numOfRows = new System.Windows.Forms.Label();
            this.label_numOfCols = new System.Windows.Forms.Label();
            this.numeric_numOfRows = new System.Windows.Forms.NumericUpDown();
            this.picture_playground = new System.Windows.Forms.PictureBox();
            this.tablePanel_background.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_numOfThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_probability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_numOfCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_numOfRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_playground)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel_background
            // 
            this.tablePanel_background.ColumnCount = 2;
            this.tablePanel_background.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.71957F));
            this.tablePanel_background.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.28042F));
            this.tablePanel_background.Controls.Add(this.panel1, 1, 0);
            this.tablePanel_background.Controls.Add(this.picture_playground, 0, 0);
            this.tablePanel_background.Location = new System.Drawing.Point(12, 12);
            this.tablePanel_background.Name = "tablePanel_background";
            this.tablePanel_background.RowCount = 1;
            this.tablePanel_background.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanel_background.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanel_background.Size = new System.Drawing.Size(756, 459);
            this.tablePanel_background.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_startParallelThreads);
            this.panel1.Controls.Add(this.button_startSingleThread);
            this.panel1.Controls.Add(this.groupBox_settings);
            this.panel1.Location = new System.Drawing.Point(583, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 453);
            this.panel1.TabIndex = 1;
            // 
            // button_startParallelThreads
            // 
            this.button_startParallelThreads.Location = new System.Drawing.Point(3, 370);
            this.button_startParallelThreads.Name = "button_startParallelThreads";
            this.button_startParallelThreads.Size = new System.Drawing.Size(164, 37);
            this.button_startParallelThreads.TabIndex = 2;
            this.button_startParallelThreads.Text = "Start Parallel Threads";
            this.button_startParallelThreads.UseVisualStyleBackColor = true;
            this.button_startParallelThreads.Click += new System.EventHandler(this.button_startParallelThreads_Click);
            // 
            // button_startSingleThread
            // 
            this.button_startSingleThread.Location = new System.Drawing.Point(3, 413);
            this.button_startSingleThread.Name = "button_startSingleThread";
            this.button_startSingleThread.Size = new System.Drawing.Size(164, 37);
            this.button_startSingleThread.TabIndex = 1;
            this.button_startSingleThread.Text = "Start Single Thread";
            this.button_startSingleThread.UseVisualStyleBackColor = true;
            this.button_startSingleThread.Click += new System.EventHandler(this.button_startSingleThread_Click);
            // 
            // groupBox_settings
            // 
            this.groupBox_settings.Controls.Add(this.numeric_numOfThreads);
            this.groupBox_settings.Controls.Add(this.label1);
            this.groupBox_settings.Controls.Add(this.numeric_probability);
            this.groupBox_settings.Controls.Add(this.label_numOfThreads);
            this.groupBox_settings.Controls.Add(this.numeric_numOfCols);
            this.groupBox_settings.Controls.Add(this.label_numOfRows);
            this.groupBox_settings.Controls.Add(this.label_numOfCols);
            this.groupBox_settings.Controls.Add(this.numeric_numOfRows);
            this.groupBox_settings.Location = new System.Drawing.Point(3, 3);
            this.groupBox_settings.Name = "groupBox_settings";
            this.groupBox_settings.Size = new System.Drawing.Size(164, 361);
            this.groupBox_settings.TabIndex = 3;
            this.groupBox_settings.TabStop = false;
            this.groupBox_settings.Text = "Settings";
            // 
            // numeric_numOfThreads
            // 
            this.numeric_numOfThreads.Location = new System.Drawing.Point(3, 331);
            this.numeric_numOfThreads.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numeric_numOfThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_numOfThreads.Name = "numeric_numOfThreads";
            this.numeric_numOfThreads.Size = new System.Drawing.Size(161, 20);
            this.numeric_numOfThreads.TabIndex = 8;
            this.numeric_numOfThreads.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Probability:";
            // 
            // numeric_probability
            // 
            this.numeric_probability.DecimalPlaces = 3;
            this.numeric_probability.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numeric_probability.Location = new System.Drawing.Point(3, 147);
            this.numeric_probability.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_probability.Name = "numeric_probability";
            this.numeric_probability.Size = new System.Drawing.Size(161, 20);
            this.numeric_probability.TabIndex = 7;
            this.numeric_probability.Value = new decimal(new int[] {
            10,
            0,
            0,
            196608});
            this.numeric_probability.ValueChanged += new System.EventHandler(this.numeric_probability_ValueChanged);
            // 
            // label_numOfThreads
            // 
            this.label_numOfThreads.AutoSize = true;
            this.label_numOfThreads.Location = new System.Drawing.Point(0, 315);
            this.label_numOfThreads.Name = "label_numOfThreads";
            this.label_numOfThreads.Size = new System.Drawing.Size(97, 13);
            this.label_numOfThreads.TabIndex = 7;
            this.label_numOfThreads.Text = "Number of threads:";
            // 
            // numeric_numOfCols
            // 
            this.numeric_numOfCols.Location = new System.Drawing.Point(3, 77);
            this.numeric_numOfCols.Maximum = new decimal(new int[] {
            450,
            0,
            0,
            0});
            this.numeric_numOfCols.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeric_numOfCols.Name = "numeric_numOfCols";
            this.numeric_numOfCols.Size = new System.Drawing.Size(161, 20);
            this.numeric_numOfCols.TabIndex = 5;
            this.numeric_numOfCols.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numeric_numOfCols.ValueChanged += new System.EventHandler(this.numeric_numOfCols_ValueChanged);
            // 
            // label_numOfRows
            // 
            this.label_numOfRows.AutoSize = true;
            this.label_numOfRows.Location = new System.Drawing.Point(0, 16);
            this.label_numOfRows.Name = "label_numOfRows";
            this.label_numOfRows.Size = new System.Drawing.Size(84, 13);
            this.label_numOfRows.TabIndex = 4;
            this.label_numOfRows.Text = "Number of rows:";
            // 
            // label_numOfCols
            // 
            this.label_numOfCols.AutoSize = true;
            this.label_numOfCols.Location = new System.Drawing.Point(0, 61);
            this.label_numOfCols.Name = "label_numOfCols";
            this.label_numOfCols.Size = new System.Drawing.Size(101, 13);
            this.label_numOfCols.TabIndex = 3;
            this.label_numOfCols.Text = "Number of columns:";
            // 
            // numeric_numOfRows
            // 
            this.numeric_numOfRows.Location = new System.Drawing.Point(3, 32);
            this.numeric_numOfRows.Maximum = new decimal(new int[] {
            450,
            0,
            0,
            0});
            this.numeric_numOfRows.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeric_numOfRows.Name = "numeric_numOfRows";
            this.numeric_numOfRows.Size = new System.Drawing.Size(161, 20);
            this.numeric_numOfRows.TabIndex = 6;
            this.numeric_numOfRows.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numeric_numOfRows.ValueChanged += new System.EventHandler(this.numeric_numOfRows_ValueChanged);
            // 
            // picture_playground
            // 
            this.picture_playground.Location = new System.Drawing.Point(3, 3);
            this.picture_playground.Name = "picture_playground";
            this.picture_playground.Size = new System.Drawing.Size(574, 453);
            this.picture_playground.TabIndex = 2;
            this.picture_playground.TabStop = false;
            // 
            // GameOfLife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 483);
            this.Controls.Add(this.tablePanel_background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GameOfLife";
            this.Text = "GameOfLife";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameOfLife_FormClosed);
            this.tablePanel_background.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox_settings.ResumeLayout(false);
            this.groupBox_settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_numOfThreads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_probability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_numOfCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_numOfRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_playground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tablePanel_background;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numeric_numOfThreads;
        private System.Windows.Forms.Button button_startParallelThreads;
        private System.Windows.Forms.Label label_numOfThreads;
        private System.Windows.Forms.Button button_startSingleThread;
        private System.Windows.Forms.GroupBox groupBox_settings;
        private System.Windows.Forms.NumericUpDown numeric_numOfCols;
        private System.Windows.Forms.Label label_numOfRows;
        private System.Windows.Forms.Label label_numOfCols;
        private System.Windows.Forms.NumericUpDown numeric_numOfRows;
        private System.Windows.Forms.PictureBox picture_playground;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numeric_probability;
    }
}

