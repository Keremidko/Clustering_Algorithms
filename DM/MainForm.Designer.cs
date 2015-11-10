namespace DM
{
    partial class MainForm
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
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.drawLine = new System.Windows.Forms.Button();
            this.noiseFactor = new System.Windows.Forms.TextBox();
            this.drawCurve = new System.Windows.Forms.CheckBox();
            this.addNoiseCheckbox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.distanceInput = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.kernelsInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.countInput = new System.Windows.Forms.TextBox();
            this.generateRandom = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dbScanMinDist = new System.Windows.Forms.TextBox();
            this.dbScanMinPts = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cellCountInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cellThresholdInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kMeansInterationsInput = new System.Windows.Forms.TextBox();
            this.kMeansKernelInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.applyAlgorithm = new System.Windows.Forms.Button();
            this.netClusteringRadio = new System.Windows.Forms.RadioButton();
            this.dbScanRadio = new System.Windows.Forms.RadioButton();
            this.kMeansRadio = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.totalTimeLabel = new System.Windows.Forms.Label();
            this.clustersFoundLabel = new System.Windows.Forms.Label();
            this.algoNameLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawingPanel
            // 
            this.drawingPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.drawingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawingPanel.Location = new System.Drawing.Point(12, 12);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(425, 502);
            this.drawingPanel.TabIndex = 0;
            this.drawingPanel.Click += new System.EventHandler(this.drawingPanel_click);
            this.drawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingPanel_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.drawLine);
            this.groupBox1.Controls.Add(this.noiseFactor);
            this.groupBox1.Controls.Add(this.drawCurve);
            this.groupBox1.Controls.Add(this.addNoiseCheckbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.distanceInput);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.kernelsInput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.countInput);
            this.groupBox1.Controls.Add(this.generateRandom);
            this.groupBox1.Location = new System.Drawing.Point(443, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 208);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate Data";
            // 
            // drawLine
            // 
            this.drawLine.Location = new System.Drawing.Point(199, 124);
            this.drawLine.Name = "drawLine";
            this.drawLine.Size = new System.Drawing.Size(100, 23);
            this.drawLine.TabIndex = 7;
            this.drawLine.Text = "Draw";
            this.drawLine.UseVisualStyleBackColor = true;
            this.drawLine.Click += new System.EventHandler(this.drawLine_Click);
            // 
            // noiseFactor
            // 
            this.noiseFactor.Location = new System.Drawing.Point(199, 98);
            this.noiseFactor.Name = "noiseFactor";
            this.noiseFactor.Size = new System.Drawing.Size(100, 20);
            this.noiseFactor.TabIndex = 5;
            // 
            // drawCurve
            // 
            this.drawCurve.AutoSize = true;
            this.drawCurve.Location = new System.Drawing.Point(99, 128);
            this.drawCurve.Name = "drawCurve";
            this.drawCurve.Size = new System.Drawing.Size(82, 17);
            this.drawCurve.TabIndex = 6;
            this.drawCurve.Text = "Draw Curve";
            this.drawCurve.UseVisualStyleBackColor = true;
            // 
            // addNoiseCheckbox
            // 
            this.addNoiseCheckbox.AutoSize = true;
            this.addNoiseCheckbox.Location = new System.Drawing.Point(99, 101);
            this.addNoiseCheckbox.Name = "addNoiseCheckbox";
            this.addNoiseCheckbox.Size = new System.Drawing.Size(75, 17);
            this.addNoiseCheckbox.TabIndex = 4;
            this.addNoiseCheckbox.Text = "Add Noise";
            this.addNoiseCheckbox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Distance:";
            // 
            // distanceInput
            // 
            this.distanceInput.Location = new System.Drawing.Point(199, 72);
            this.distanceInput.Name = "distanceInput";
            this.distanceInput.Size = new System.Drawing.Size(100, 20);
            this.distanceInput.TabIndex = 3;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(9, 179);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(290, 23);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of Kernels:";
            // 
            // kernelsInput
            // 
            this.kernelsInput.Location = new System.Drawing.Point(199, 45);
            this.kernelsInput.Name = "kernelsInput";
            this.kernelsInput.Size = new System.Drawing.Size(100, 20);
            this.kernelsInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Count:";
            // 
            // countInput
            // 
            this.countInput.Location = new System.Drawing.Point(199, 19);
            this.countInput.Name = "countInput";
            this.countInput.Size = new System.Drawing.Size(100, 20);
            this.countInput.TabIndex = 1;
            // 
            // generateRandom
            // 
            this.generateRandom.Location = new System.Drawing.Point(9, 150);
            this.generateRandom.Name = "generateRandom";
            this.generateRandom.Size = new System.Drawing.Size(290, 23);
            this.generateRandom.TabIndex = 8;
            this.generateRandom.Text = "Generate";
            this.generateRandom.UseVisualStyleBackColor = true;
            this.generateRandom.Click += new System.EventHandler(this.generateRandom_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dbScanMinDist);
            this.groupBox2.Controls.Add(this.dbScanMinPts);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cellCountInput);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cellThresholdInput);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.kMeansInterationsInput);
            this.groupBox2.Controls.Add(this.kMeansKernelInput);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.applyAlgorithm);
            this.groupBox2.Controls.Add(this.netClusteringRadio);
            this.groupBox2.Controls.Add(this.dbScanRadio);
            this.groupBox2.Controls.Add(this.kMeansRadio);
            this.groupBox2.Location = new System.Drawing.Point(443, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 144);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clusterize";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(224, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Dist";
            // 
            // dbScanMinDist
            // 
            this.dbScanMinDist.Location = new System.Drawing.Point(255, 88);
            this.dbScanMinDist.Name = "dbScanMinDist";
            this.dbScanMinDist.Size = new System.Drawing.Size(44, 20);
            this.dbScanMinDist.TabIndex = 8;
            // 
            // dbScanMinPts
            // 
            this.dbScanMinPts.Location = new System.Drawing.Point(172, 88);
            this.dbScanMinPts.Name = "dbScanMinPts";
            this.dbScanMinPts.Size = new System.Drawing.Size(21, 20);
            this.dbScanMinPts.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(121, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "MinPTS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "N of Cells";
            // 
            // cellCountInput
            // 
            this.cellCountInput.Location = new System.Drawing.Point(172, 66);
            this.cellCountInput.Name = "cellCountInput";
            this.cellCountInput.Size = new System.Drawing.Size(21, 20);
            this.cellCountInput.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Threshold";
            // 
            // cellThresholdInput
            // 
            this.cellThresholdInput.Location = new System.Drawing.Point(255, 65);
            this.cellThresholdInput.Name = "cellThresholdInput";
            this.cellThresholdInput.Size = new System.Drawing.Size(44, 20);
            this.cellThresholdInput.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Iterations";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kernels";
            // 
            // kMeansInterationsInput
            // 
            this.kMeansInterationsInput.Location = new System.Drawing.Point(255, 42);
            this.kMeansInterationsInput.Name = "kMeansInterationsInput";
            this.kMeansInterationsInput.Size = new System.Drawing.Size(44, 20);
            this.kMeansInterationsInput.TabIndex = 2;
            // 
            // kMeansKernelInput
            // 
            this.kMeansKernelInput.Location = new System.Drawing.Point(172, 43);
            this.kMeansKernelInput.Name = "kMeansKernelInput";
            this.kMeansKernelInput.Size = new System.Drawing.Size(21, 20);
            this.kMeansKernelInput.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Method:";
            // 
            // applyAlgorithm
            // 
            this.applyAlgorithm.Location = new System.Drawing.Point(5, 115);
            this.applyAlgorithm.Name = "applyAlgorithm";
            this.applyAlgorithm.Size = new System.Drawing.Size(294, 23);
            this.applyAlgorithm.TabIndex = 9;
            this.applyAlgorithm.Text = "Apply";
            this.applyAlgorithm.UseVisualStyleBackColor = true;
            this.applyAlgorithm.Click += new System.EventHandler(this.applyAlgorithm_Click);
            // 
            // netClusteringRadio
            // 
            this.netClusteringRadio.AutoSize = true;
            this.netClusteringRadio.Location = new System.Drawing.Point(5, 67);
            this.netClusteringRadio.Name = "netClusteringRadio";
            this.netClusteringRadio.Size = new System.Drawing.Size(91, 17);
            this.netClusteringRadio.TabIndex = 3;
            this.netClusteringRadio.TabStop = true;
            this.netClusteringRadio.Text = "Net Clustering";
            this.netClusteringRadio.UseVisualStyleBackColor = true;
            // 
            // dbScanRadio
            // 
            this.dbScanRadio.AutoSize = true;
            this.dbScanRadio.Location = new System.Drawing.Point(6, 89);
            this.dbScanRadio.Name = "dbScanRadio";
            this.dbScanRadio.Size = new System.Drawing.Size(69, 17);
            this.dbScanRadio.TabIndex = 6;
            this.dbScanRadio.TabStop = true;
            this.dbScanRadio.Text = "DBSCAN";
            this.dbScanRadio.UseVisualStyleBackColor = true;
            // 
            // kMeansRadio
            // 
            this.kMeansRadio.AutoSize = true;
            this.kMeansRadio.Location = new System.Drawing.Point(5, 48);
            this.kMeansRadio.Name = "kMeansRadio";
            this.kMeansRadio.Size = new System.Drawing.Size(67, 17);
            this.kMeansRadio.TabIndex = 0;
            this.kMeansRadio.TabStop = true;
            this.kMeansRadio.Text = "K-Means";
            this.kMeansRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.totalTimeLabel);
            this.groupBox3.Controls.Add(this.clustersFoundLabel);
            this.groupBox3.Controls.Add(this.algoNameLabel);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(443, 376);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 138);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Performance Metrics";
            // 
            // totalTimeLabel
            // 
            this.totalTimeLabel.AutoSize = true;
            this.totalTimeLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.totalTimeLabel.Location = new System.Drawing.Point(90, 74);
            this.totalTimeLabel.Name = "totalTimeLabel";
            this.totalTimeLabel.Size = new System.Drawing.Size(24, 13);
            this.totalTimeLabel.TabIndex = 5;
            this.totalTimeLabel.Text = "n/a";
            // 
            // clustersFoundLabel
            // 
            this.clustersFoundLabel.AutoSize = true;
            this.clustersFoundLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.clustersFoundLabel.Location = new System.Drawing.Point(90, 49);
            this.clustersFoundLabel.Name = "clustersFoundLabel";
            this.clustersFoundLabel.Size = new System.Drawing.Size(24, 13);
            this.clustersFoundLabel.TabIndex = 4;
            this.clustersFoundLabel.Text = "n/a";
            // 
            // algoNameLabel
            // 
            this.algoNameLabel.AutoSize = true;
            this.algoNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.algoNameLabel.Location = new System.Drawing.Point(90, 27);
            this.algoNameLabel.Name = "algoNameLabel";
            this.algoNameLabel.Size = new System.Drawing.Size(24, 13);
            this.algoNameLabel.TabIndex = 3;
            this.algoNameLabel.Text = "n/a";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Algorithm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Total time";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Clusters found";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 526);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.drawingPanel);
            this.Name = "MainForm";
            this.Text = "Clustering Algorithms";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kernelsInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox countInput;
        private System.Windows.Forms.Button generateRandom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton dbScanRadio;
        private System.Windows.Forms.RadioButton kMeansRadio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button applyAlgorithm;
        private System.Windows.Forms.RadioButton netClusteringRadio;
        private System.Windows.Forms.Button drawLine;
        private System.Windows.Forms.CheckBox drawCurve;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox distanceInput;
        private System.Windows.Forms.CheckBox addNoiseCheckbox;
        private System.Windows.Forms.TextBox noiseFactor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kMeansInterationsInput;
        private System.Windows.Forms.TextBox kMeansKernelInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cellThresholdInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cellCountInput;
        private System.Windows.Forms.TextBox dbScanMinDist;
        private System.Windows.Forms.TextBox dbScanMinPts;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label totalTimeLabel;
        private System.Windows.Forms.Label clustersFoundLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label algoNameLabel;
    }
}

