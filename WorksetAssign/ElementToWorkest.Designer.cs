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
            this.label1 = new System.Windows.Forms.Label();
            this.containerBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.containerBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // elementsComboBox
            // 
            this.elementsComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.elementsComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.elementsComboBox.FormattingEnabled = true;
            this.elementsComboBox.Location = new System.Drawing.Point(12, 77);
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
            this.assignButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.assignButton.Location = new System.Drawing.Point(12, 233);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(100, 30);
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
            this.worksetsComboBox.Location = new System.Drawing.Point(12, 155);
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
            this.doneButton.Location = new System.Drawing.Point(159, 232);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(100, 32);
            this.doneButton.TabIndex = 3;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type";
            // 
            // containerBox
            // 
            this.containerBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.containerBox.Controls.Add(this.label2);
            this.containerBox.Controls.Add(this.elementsComboBox);
            this.containerBox.Controls.Add(this.label1);
            this.containerBox.Controls.Add(this.assignButton);
            this.containerBox.Controls.Add(this.doneButton);
            this.containerBox.Controls.Add(this.worksetsComboBox);
            this.containerBox.Location = new System.Drawing.Point(12, 9);
            this.containerBox.Name = "containerBox";
            this.containerBox.Size = new System.Drawing.Size(274, 285);
            this.containerBox.TabIndex = 5;
            this.containerBox.TabStop = false;
            this.containerBox.Text = "Elements to Workest";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Workset";
            // 
            // ElementToWorkest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 304);
            this.Controls.Add(this.containerBox);
            this.MaximumSize = new System.Drawing.Size(320, 600);
            this.MinimumSize = new System.Drawing.Size(320, 360);
            this.Name = "ElementToWorkest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.containerBox.ResumeLayout(false);
            this.containerBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox elementsComboBox;
        private System.Windows.Forms.Button assignButton;
        private System.Windows.Forms.ComboBox worksetsComboBox;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox containerBox;
        private System.Windows.Forms.Label label2;
    }
}