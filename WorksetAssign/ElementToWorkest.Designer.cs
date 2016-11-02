namespace WorksetAssign
{
    partial class ElementToWorkest
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
            this.elementsComboBox = new System.Windows.Forms.ComboBox();
            this.assignButton = new System.Windows.Forms.Button();
            this.worksetsComboBox = new System.Windows.Forms.ComboBox();
            this.doneButton = new System.Windows.Forms.Button();
            this.elementLabel = new System.Windows.Forms.Label();
            this.worksetLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.progressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // elementsComboBox
            // 
            this.elementsComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.elementsComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.elementsComboBox.FormattingEnabled = true;
            this.elementsComboBox.Location = new System.Drawing.Point(32, 64);
            this.elementsComboBox.MaxDropDownItems = 5;
            this.elementsComboBox.Name = "elementsComboBox";
            this.elementsComboBox.Size = new System.Drawing.Size(247, 28);
            this.elementsComboBox.Sorted = true;
            this.elementsComboBox.TabIndex = 0;
            this.elementsComboBox.DropDown += new System.EventHandler(this.elementsComboBox_DropDown);
            this.elementsComboBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.elementsComboBox_PreviewKeyDown);
            // 
            // assignButton
            // 
            this.assignButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.assignButton.Location = new System.Drawing.Point(374, 24);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(106, 32);
            this.assignButton.TabIndex = 1;
            this.assignButton.Text = "Assign";
            this.assignButton.UseVisualStyleBackColor = true;
            this.assignButton.Click += new System.EventHandler(this.assignButton_Click);
            // 
            // worksetsComboBox
            // 
            this.worksetsComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.worksetsComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.worksetsComboBox.FormattingEnabled = true;
            this.worksetsComboBox.Location = new System.Drawing.Point(32, 129);
            this.worksetsComboBox.MaxDropDownItems = 5;
            this.worksetsComboBox.Name = "worksetsComboBox";
            this.worksetsComboBox.Size = new System.Drawing.Size(247, 28);
            this.worksetsComboBox.Sorted = true;
            this.worksetsComboBox.TabIndex = 2;
            this.worksetsComboBox.DropDown += new System.EventHandler(this.worksetsComboBox_DropDown);
            this.worksetsComboBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.worksetsComboBox_PreviewKeyDown);
            // 
            // doneButton
            // 
            this.doneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.doneButton.Location = new System.Drawing.Point(486, 24);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(106, 32);
            this.doneButton.TabIndex = 3;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // elementLabel
            // 
            this.elementLabel.AutoSize = true;
            this.elementLabel.Location = new System.Drawing.Point(32, 35);
            this.elementLabel.Name = "elementLabel";
            this.elementLabel.Size = new System.Drawing.Size(43, 20);
            this.elementLabel.TabIndex = 4;
            this.elementLabel.Text = "Type";
            // 
            // worksetLabel
            // 
            this.worksetLabel.AutoSize = true;
            this.worksetLabel.Location = new System.Drawing.Point(32, 100);
            this.worksetLabel.Name = "worksetLabel";
            this.worksetLabel.Size = new System.Drawing.Size(68, 20);
            this.worksetLabel.TabIndex = 5;
            this.worksetLabel.Text = "Workset";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(32, 212);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(560, 10);
            this.progressBar.TabIndex = 6;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.Panel1.Controls.Add(this.progressLabel);
            this.splitContainer1.Panel1.Controls.Add(this.progressBar);
            this.splitContainer1.Panel1.Controls.Add(this.elementLabel);
            this.splitContainer1.Panel1.Controls.Add(this.worksetLabel);
            this.splitContainer1.Panel1.Controls.Add(this.worksetsComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.elementsComboBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.assignButton);
            this.splitContainer1.Panel2.Controls.Add(this.doneButton);
            this.splitContainer1.Size = new System.Drawing.Size(628, 344);
            this.splitContainer1.SplitterDistance = 262;
            this.splitContainer1.TabIndex = 7;
            // 
            // progressLabel
            // 
            this.progressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressLabel.AutoEllipsis = true;
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(32, 179);
            this.progressLabel.MaximumSize = new System.Drawing.Size(560, 18);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(13, 18);
            this.progressLabel.TabIndex = 8;
            this.progressLabel.Text = " ";
            // 
            // ElementToWorkest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 344);
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(650, 400);
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "ElementToWorkest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox elementsComboBox;
        private System.Windows.Forms.Button assignButton;
        private System.Windows.Forms.ComboBox worksetsComboBox;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Label elementLabel;
        private System.Windows.Forms.Label worksetLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label progressLabel;
    }
}