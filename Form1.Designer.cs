namespace PerceptronPredictionSystem
{
	partial class Form
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.startButton = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.nrPerceptronTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.label6 = new System.Windows.Forms.Label();
			this.notTakenTotalLabel = new System.Windows.Forms.Label();
			this.notTakenPredictedLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.filenameLabel = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label4 = new System.Windows.Forms.Label();
			this.takenTotalLabel = new System.Windows.Forms.Label();
			this.takenPredictedLabel = new System.Windows.Forms.Label();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.accuracyLabel = new System.Windows.Forms.Label();
			this.accuracyTakenLabel = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1082, 553);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.textBox2, 1, 3);
			this.tableLayoutPanel2.Controls.Add(this.startButton, 0, 4);
			this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.textBox1, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.nrPerceptronTextBox, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.tableLayoutPanel2.RowCount = 6;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(318, 547);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBox2.ForeColor = System.Drawing.Color.White;
			this.textBox2.Location = new System.Drawing.Point(154, 205);
			this.textBox2.Margin = new System.Windows.Forms.Padding(0, 15, 0, 6);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(144, 30);
			this.textBox2.TabIndex = 3;
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// startButton
			// 
			this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.tableLayoutPanel2.SetColumnSpan(this.startButton, 2);
			this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.startButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.startButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.startButton.ForeColor = System.Drawing.Color.White;
			this.startButton.Location = new System.Drawing.Point(13, 276);
			this.startButton.Margin = new System.Windows.Forms.Padding(3, 26, 3, 3);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(282, 41);
			this.startButton.TabIndex = 4;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.tableLayoutPanel2.SetColumnSpan(this.label7, 2);
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label7.ForeColor = System.Drawing.Color.Silver;
			this.label7.Location = new System.Drawing.Point(13, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(282, 70);
			this.label7.TabIndex = 6;
			this.label7.Text = "Perceptron";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBox1.ForeColor = System.Drawing.Color.White;
			this.textBox1.Location = new System.Drawing.Point(154, 145);
			this.textBox1.Margin = new System.Windows.Forms.Padding(0, 15, 0, 6);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(144, 30);
			this.textBox1.TabIndex = 2;
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(13, 190);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(138, 60);
			this.label5.TabIndex = 4;
			this.label5.Text = "Benchmark";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// nrPerceptronTextBox
			// 
			this.nrPerceptronTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.nrPerceptronTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.nrPerceptronTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nrPerceptronTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.nrPerceptronTextBox.ForeColor = System.Drawing.Color.White;
			this.nrPerceptronTextBox.Location = new System.Drawing.Point(154, 85);
			this.nrPerceptronTextBox.Margin = new System.Windows.Forms.Padding(0, 15, 0, 6);
			this.nrPerceptronTextBox.Name = "nrPerceptronTextBox";
			this.nrPerceptronTextBox.Size = new System.Drawing.Size(144, 30);
			this.nrPerceptronTextBox.TabIndex = 1;
			this.nrPerceptronTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(13, 130);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(138, 60);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nr Bits HR";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(13, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 60);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nr Perceptrons";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel2, 1, 2);
			this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.filenameLabel, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel3, 0, 3);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(327, 3);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.tableLayoutPanel3.RowCount = 4;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(752, 547);
			this.tableLayoutPanel3.TabIndex = 1;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(this.label6);
			this.flowLayoutPanel2.Controls.Add(this.notTakenTotalLabel);
			this.flowLayoutPanel2.Controls.Add(this.notTakenPredictedLabel);
			this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(238, 83);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
			this.flowLayoutPanel2.Size = new System.Drawing.Size(511, 194);
			this.flowLayoutPanel2.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label6.ForeColor = System.Drawing.Color.Silver;
			this.label6.Location = new System.Drawing.Point(3, 15);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(195, 28);
			this.label6.TabIndex = 2;
			this.label6.Text = "Not Taken";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// notTakenTotalLabel
			// 
			this.notTakenTotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.notTakenTotalLabel.AutoSize = true;
			this.notTakenTotalLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.notTakenTotalLabel.ForeColor = System.Drawing.Color.White;
			this.notTakenTotalLabel.Location = new System.Drawing.Point(3, 58);
			this.notTakenTotalLabel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
			this.notTakenTotalLabel.Name = "notTakenTotalLabel";
			this.notTakenTotalLabel.Size = new System.Drawing.Size(195, 23);
			this.notTakenTotalLabel.TabIndex = 3;
			this.notTakenTotalLabel.Text = "Not-Taken total: x";
			this.notTakenTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// notTakenPredictedLabel
			// 
			this.notTakenPredictedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.notTakenPredictedLabel.AutoSize = true;
			this.notTakenPredictedLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.notTakenPredictedLabel.ForeColor = System.Drawing.Color.White;
			this.notTakenPredictedLabel.Location = new System.Drawing.Point(3, 96);
			this.notTakenPredictedLabel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
			this.notTakenPredictedLabel.Name = "notTakenPredictedLabel";
			this.notTakenPredictedLabel.Size = new System.Drawing.Size(195, 23);
			this.notTakenPredictedLabel.TabIndex = 4;
			this.notTakenPredictedLabel.Text = "Not-Taken predicted: x";
			this.notTakenPredictedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.tableLayoutPanel3.SetColumnSpan(this.label2, 2);
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(13, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(736, 40);
			this.label2.TabIndex = 2;
			this.label2.Text = "Total jumps: x";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// filenameLabel
			// 
			this.filenameLabel.AutoSize = true;
			this.tableLayoutPanel3.SetColumnSpan(this.filenameLabel, 2);
			this.filenameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.filenameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.filenameLabel.ForeColor = System.Drawing.Color.Silver;
			this.filenameLabel.Location = new System.Drawing.Point(13, 0);
			this.filenameLabel.Name = "filenameLabel";
			this.filenameLabel.Size = new System.Drawing.Size(736, 40);
			this.filenameLabel.TabIndex = 1;
			this.filenameLabel.Text = "Filename";
			this.filenameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.label4);
			this.flowLayoutPanel1.Controls.Add(this.takenTotalLabel);
			this.flowLayoutPanel1.Controls.Add(this.takenPredictedLabel);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 83);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
			this.flowLayoutPanel1.Size = new System.Drawing.Size(219, 194);
			this.flowLayoutPanel1.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label4.ForeColor = System.Drawing.Color.Silver;
			this.label4.Location = new System.Drawing.Point(3, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(159, 28);
			this.label4.TabIndex = 2;
			this.label4.Text = "Taken";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// takenTotalLabel
			// 
			this.takenTotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.takenTotalLabel.AutoSize = true;
			this.takenTotalLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.takenTotalLabel.ForeColor = System.Drawing.Color.White;
			this.takenTotalLabel.Location = new System.Drawing.Point(3, 58);
			this.takenTotalLabel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
			this.takenTotalLabel.Name = "takenTotalLabel";
			this.takenTotalLabel.Size = new System.Drawing.Size(159, 23);
			this.takenTotalLabel.TabIndex = 3;
			this.takenTotalLabel.Text = "Taken total: x";
			this.takenTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// takenPredictedLabel
			// 
			this.takenPredictedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.takenPredictedLabel.AutoSize = true;
			this.takenPredictedLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.takenPredictedLabel.ForeColor = System.Drawing.Color.White;
			this.takenPredictedLabel.Location = new System.Drawing.Point(3, 96);
			this.takenPredictedLabel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
			this.takenPredictedLabel.Name = "takenPredictedLabel";
			this.takenPredictedLabel.Size = new System.Drawing.Size(159, 23);
			this.takenPredictedLabel.TabIndex = 4;
			this.takenPredictedLabel.Text = "Taken predicted: x";
			this.takenPredictedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// flowLayoutPanel3
			// 
			this.tableLayoutPanel3.SetColumnSpan(this.flowLayoutPanel3, 2);
			this.flowLayoutPanel3.Controls.Add(this.accuracyLabel);
			this.flowLayoutPanel3.Controls.Add(this.accuracyTakenLabel);
			this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel3.Location = new System.Drawing.Point(13, 283);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(736, 261);
			this.flowLayoutPanel3.TabIndex = 5;
			// 
			// accuracyLabel
			// 
			this.accuracyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.accuracyLabel.AutoSize = true;
			this.accuracyLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.accuracyLabel.ForeColor = System.Drawing.Color.White;
			this.accuracyLabel.Location = new System.Drawing.Point(3, 15);
			this.accuracyLabel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
			this.accuracyLabel.Name = "accuracyLabel";
			this.accuracyLabel.Size = new System.Drawing.Size(165, 23);
			this.accuracyLabel.TabIndex = 4;
			this.accuracyLabel.Text = "Accuracy: x%";
			this.accuracyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// accuracyTakenLabel
			// 
			this.accuracyTakenLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.accuracyTakenLabel.AutoSize = true;
			this.accuracyTakenLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.accuracyTakenLabel.ForeColor = System.Drawing.Color.White;
			this.accuracyTakenLabel.Location = new System.Drawing.Point(3, 53);
			this.accuracyTakenLabel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
			this.accuracyTakenLabel.Name = "accuracyTakenLabel";
			this.accuracyTakenLabel.Size = new System.Drawing.Size(165, 23);
			this.accuracyTakenLabel.TabIndex = 5;
			this.accuracyTakenLabel.Text = "Accuracy taken: x%";
			this.accuracyTakenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1082, 553);
			this.Controls.Add(this.tableLayoutPanel1);
			this.MinimumSize = new System.Drawing.Size(1100, 600);
			this.Name = "Form";
			this.Text = "Perceptron Prediction System";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.flowLayoutPanel3.ResumeLayout(false);
			this.flowLayoutPanel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel tableLayoutPanel2;
		private Label label1;
		private Label label5;
		private TextBox nrPerceptronTextBox;
		private Label label3;
		private TextBox textBox2;
		private TextBox textBox1;
		private Button startButton;
		private TableLayoutPanel tableLayoutPanel3;
		private Label filenameLabel;
		private Label label2;
		private FlowLayoutPanel flowLayoutPanel2;
		private Label label6;
		private Label notTakenTotalLabel;
		private Label notTakenPredictedLabel;
		private FlowLayoutPanel flowLayoutPanel1;
		private Label label4;
		private Label takenTotalLabel;
		private Label takenPredictedLabel;
		private FlowLayoutPanel flowLayoutPanel3;
		private Label accuracyLabel;
		private Label accuracyTakenLabel;
		private Label label7;
	}
}