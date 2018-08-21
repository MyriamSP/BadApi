using System.Windows.Forms;

namespace RestBadApi
{
    partial class restForm
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
            this.getData = new System.Windows.Forms.Button();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.datePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.datePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxResponse = new System.Windows.Forms.TextBox();
            this.dataGridViewTweets = new System.Windows.Forms.DataGridView();
            this.groupBoxDates = new System.Windows.Forms.GroupBox();
            this.groupBoxTweets = new System.Windows.Forms.GroupBox();
            this.groupBoxJSON = new System.Windows.Forms.GroupBox();
            this.labelTotalTweets = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxTotalTweets = new System.Windows.Forms.TextBox();
            this.labelDupTweets = new System.Windows.Forms.Label();
            this.textBoxDupTweets = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTweets)).BeginInit();
            this.groupBoxDates.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // getData
            // 
            this.getData.Location = new System.Drawing.Point(746, 45);
            this.getData.Name = "getData";
            this.getData.Size = new System.Drawing.Size(122, 31);
            this.getData.TabIndex = 0;
            this.getData.Text = "GET THEM!";
            this.getData.UseVisualStyleBackColor = true;
            this.getData.Click += new System.EventHandler(this.getData_Click);
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(95, 25);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(52, 13);
            this.startDateLabel.TabIndex = 5;
            this.startDateLabel.Text = "StartDate";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(438, 25);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(49, 13);
            this.endDateLabel.TabIndex = 6;
            this.endDateLabel.Text = "EndDate";
            // 
            // datePickerStartDate
            // 
            this.datePickerStartDate.Location = new System.Drawing.Point(98, 56);
            this.datePickerStartDate.MaxDate = new System.DateTime(2017, 12, 30, 0, 0, 0, 0);
            this.datePickerStartDate.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.datePickerStartDate.Name = "datePickerStartDate";
            this.datePickerStartDate.Size = new System.Drawing.Size(200, 20);
            this.datePickerStartDate.TabIndex = 3;
            this.datePickerStartDate.Value = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            // 
            // datePickerEndDate
            // 
            this.datePickerEndDate.Location = new System.Drawing.Point(441, 56);
            this.datePickerEndDate.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.datePickerEndDate.MinDate = new System.DateTime(2016, 1, 2, 0, 0, 0, 0);
            this.datePickerEndDate.Name = "datePickerEndDate";
            this.datePickerEndDate.Size = new System.Drawing.Size(200, 20);
            this.datePickerEndDate.TabIndex = 7;
            this.datePickerEndDate.Value = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            // 
            // textBoxResponse
            // 
            this.textBoxResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxResponse.Location = new System.Drawing.Point(29, 492);
            this.textBoxResponse.Multiline = true;
            this.textBoxResponse.Name = "textBoxResponse";
            this.textBoxResponse.ReadOnly = true;
            this.textBoxResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResponse.Size = new System.Drawing.Size(1002, 116);
            this.textBoxResponse.TabIndex = 10;
            // 
            // dataGridViewTweets
            // 
            this.dataGridViewTweets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewTweets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTweets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTweets.Location = new System.Drawing.Point(29, 150);
            this.dataGridViewTweets.Name = "dataGridViewTweets";
            this.dataGridViewTweets.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTweets.Size = new System.Drawing.Size(1002, 304);
            this.dataGridViewTweets.TabIndex = 11;
            // 
            // groupBoxDates
            // 
            this.groupBoxDates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDates.Controls.Add(this.datePickerStartDate);
            this.groupBoxDates.Controls.Add(this.startDateLabel);
            this.groupBoxDates.Controls.Add(this.getData);
            this.groupBoxDates.Controls.Add(this.endDateLabel);
            this.groupBoxDates.Controls.Add(this.datePickerEndDate);
            this.groupBoxDates.Location = new System.Drawing.Point(12, 13);
            this.groupBoxDates.Name = "groupBoxDates";
            this.groupBoxDates.Size = new System.Drawing.Size(1240, 111);
            this.groupBoxDates.TabIndex = 12;
            this.groupBoxDates.TabStop = false;
            this.groupBoxDates.Text = "Date Selection";
            // 
            // groupBoxTweets
            // 
            this.groupBoxTweets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxTweets.Location = new System.Drawing.Point(12, 131);
            this.groupBoxTweets.Name = "groupBoxTweets";
            this.groupBoxTweets.Size = new System.Drawing.Size(1036, 336);
            this.groupBoxTweets.TabIndex = 13;
            this.groupBoxTweets.TabStop = false;
            this.groupBoxTweets.Text = "Total Unique Tweets";
            // 
            // groupBoxJSON
            // 
            this.groupBoxJSON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxJSON.Location = new System.Drawing.Point(12, 473);
            this.groupBoxJSON.Name = "groupBoxJSON";
            this.groupBoxJSON.Size = new System.Drawing.Size(1036, 145);
            this.groupBoxJSON.TabIndex = 14;
            this.groupBoxJSON.TabStop = false;
            this.groupBoxJSON.Text = "Messages";
            // 
            // labelTotalTweets
            // 
            this.labelTotalTweets.AutoSize = true;
            this.labelTotalTweets.Location = new System.Drawing.Point(6, 33);
            this.labelTotalTweets.Name = "labelTotalTweets";
            this.labelTotalTweets.Size = new System.Drawing.Size(106, 13);
            this.labelTotalTweets.TabIndex = 15;
            this.labelTotalTweets.Text = "Total Unique Tweets";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDupTweets);
            this.groupBox1.Controls.Add(this.labelDupTweets);
            this.groupBox1.Controls.Add(this.textBoxTotalTweets);
            this.groupBox1.Controls.Add(this.labelTotalTweets);
            this.groupBox1.Location = new System.Drawing.Point(1055, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 336);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tweet Summary";
            // 
            // textBoxTotalTweets
            // 
            this.textBoxTotalTweets.Location = new System.Drawing.Point(9, 61);
            this.textBoxTotalTweets.Name = "textBoxTotalTweets";
            this.textBoxTotalTweets.ReadOnly = true;
            this.textBoxTotalTweets.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalTweets.TabIndex = 16;
            // 
            // labelDupTweets
            // 
            this.labelDupTweets.AutoSize = true;
            this.labelDupTweets.Location = new System.Drawing.Point(6, 94);
            this.labelDupTweets.Name = "labelDupTweets";
            this.labelDupTweets.Size = new System.Drawing.Size(96, 13);
            this.labelDupTweets.TabIndex = 17;
            this.labelDupTweets.Text = "Duplicated Tweets";
            // 
            // textBoxDupTweets
            // 
            this.textBoxDupTweets.Location = new System.Drawing.Point(9, 120);
            this.textBoxDupTweets.Name = "textBoxDupTweets";
            this.textBoxDupTweets.ReadOnly = true;
            this.textBoxDupTweets.Size = new System.Drawing.Size(100, 20);
            this.textBoxDupTweets.TabIndex = 18;
            // 
            // restForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 620);
            this.Controls.Add(this.dataGridViewTweets);
            this.Controls.Add(this.textBoxResponse);
            this.Controls.Add(this.groupBoxDates);
            this.Controls.Add(this.groupBoxTweets);
            this.Controls.Add(this.groupBoxJSON);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(1076, 659);
            this.Name = "restForm";
            this.Text = "Get Tweets!";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTweets)).EndInit();
            this.groupBoxDates.ResumeLayout(false);
            this.groupBoxDates.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getData;
        private System.Windows.Forms.DateTimePicker datePickerStartDate;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.DateTimePicker datePickerEndDate;
        private TextBox textBoxResponse;
        private DataGridView dataGridViewTweets;
        private GroupBox groupBoxDates;
        private GroupBox groupBoxTweets;
        private GroupBox groupBoxJSON;
        private Label labelTotalTweets;
        private GroupBox groupBox1;
        private TextBox textBoxDupTweets;
        private Label labelDupTweets;
        private TextBox textBoxTotalTweets;
    }
}

