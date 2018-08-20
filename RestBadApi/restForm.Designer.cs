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
            this.listViewTweets = new System.Windows.Forms.ListView();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.datePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.datePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.timePickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.timePickerEndTime = new System.Windows.Forms.DateTimePicker();
            this.textBoxResponse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // getData
            // 
            this.getData.Location = new System.Drawing.Point(606, 44);
            this.getData.Name = "getData";
            this.getData.Size = new System.Drawing.Size(122, 45);
            this.getData.TabIndex = 0;
            this.getData.Text = "GET THEM!";
            this.getData.UseVisualStyleBackColor = true;
            this.getData.Click += new System.EventHandler(this.getData_Click);
            // 
            // listViewTweets
            // 
            this.listViewTweets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTweets.Location = new System.Drawing.Point(33, 358);
            this.listViewTweets.Name = "listViewTweets";
            this.listViewTweets.Size = new System.Drawing.Size(729, 157);
            this.listViewTweets.TabIndex = 2;
            this.listViewTweets.UseCompatibleStateImageBehavior = false;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(30, 25);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(52, 13);
            this.startDateLabel.TabIndex = 5;
            this.startDateLabel.Text = "StartDate";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(316, 25);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(49, 13);
            this.endDateLabel.TabIndex = 6;
            this.endDateLabel.Text = "EndDate";
            // 
            // datePickerStartDate
            // 
            this.datePickerStartDate.Location = new System.Drawing.Point(33, 54);
            this.datePickerStartDate.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.datePickerStartDate.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.datePickerStartDate.Name = "datePickerStartDate";
            this.datePickerStartDate.Size = new System.Drawing.Size(200, 20);
            this.datePickerStartDate.TabIndex = 3;
            this.datePickerStartDate.Value = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            // 
            // datePickerEndDate
            // 
            this.datePickerEndDate.Location = new System.Drawing.Point(319, 54);
            this.datePickerEndDate.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.datePickerEndDate.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.datePickerEndDate.Name = "datePickerEndDate";
            this.datePickerEndDate.Size = new System.Drawing.Size(200, 20);
            this.datePickerEndDate.TabIndex = 7;
            this.datePickerEndDate.Value = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            // 
            // timePickerStartTime
            // 
            this.timePickerStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerStartTime.Location = new System.Drawing.Point(33, 80);
            this.timePickerStartTime.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.timePickerStartTime.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.timePickerStartTime.Name = "timePickerStartTime";
            this.timePickerStartTime.Size = new System.Drawing.Size(98, 20);
            this.timePickerStartTime.TabIndex = 8;
            this.timePickerStartTime.Value = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            // 
            // timePickerEndTime
            // 
            this.timePickerEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerEndTime.Location = new System.Drawing.Point(319, 80);
            this.timePickerEndTime.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.timePickerEndTime.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.timePickerEndTime.Name = "timePickerEndTime";
            this.timePickerEndTime.Size = new System.Drawing.Size(98, 20);
            this.timePickerEndTime.TabIndex = 9;
            this.timePickerEndTime.Value = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            // 
            // textBoxResponse
            // 
            this.textBoxResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResponse.Location = new System.Drawing.Point(33, 130);
            this.textBoxResponse.Multiline = true;
            this.textBoxResponse.Name = "textBoxResponse";
            this.textBoxResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResponse.Size = new System.Drawing.Size(729, 222);
            this.textBoxResponse.TabIndex = 10;
            // 
            // restForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.textBoxResponse);
            this.Controls.Add(this.timePickerEndTime);
            this.Controls.Add(this.timePickerStartTime);
            this.Controls.Add(this.datePickerEndDate);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.datePickerStartDate);
            this.Controls.Add(this.listViewTweets);
            this.Controls.Add(this.getData);
            this.MinimumSize = new System.Drawing.Size(816, 575);
            this.Name = "restForm";
            this.Text = "GetForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getData;
        private System.Windows.Forms.ListView listViewTweets;
        private System.Windows.Forms.DateTimePicker datePickerStartDate;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.DateTimePicker datePickerEndDate;
        private System.Windows.Forms.DateTimePicker timePickerStartTime;
        private System.Windows.Forms.DateTimePicker timePickerEndTime;
        private TextBox textBoxResponse;
    }
}

