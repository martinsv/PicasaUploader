﻿namespace PicasaUploader
{
	partial class DuplicateActionDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (DuplicateActionDialog));
			this.replaceButton = new System.Windows.Forms.Button ();
			this.replaceAllButton = new System.Windows.Forms.Button ();
			this.skipAllButton = new System.Windows.Forms.Button ();
			this.skipButton = new System.Windows.Forms.Button ();
			this.uploadAllButton = new System.Windows.Forms.Button ();
			this.uploadButton = new System.Windows.Forms.Button ();
			this.textLabel = new System.Windows.Forms.Label ();
			this.SuspendLayout ();
			// 
			// replaceButton
			// 
			this.replaceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.replaceButton.Location = new System.Drawing.Point (15, 94);
			this.replaceButton.Name = "replaceButton";
			this.replaceButton.Size = new System.Drawing.Size (75, 23);
			this.replaceButton.TabIndex = 0;
			this.replaceButton.Text = "Replace";
			this.replaceButton.UseVisualStyleBackColor = true;
			this.replaceButton.Click += new System.EventHandler (this.replaceButton_Click);
			// 
			// replaceAllButton
			// 
			this.replaceAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.replaceAllButton.Location = new System.Drawing.Point (96, 94);
			this.replaceAllButton.Name = "replaceAllButton";
			this.replaceAllButton.Size = new System.Drawing.Size (75, 23);
			this.replaceAllButton.TabIndex = 1;
			this.replaceAllButton.Text = "Replace All";
			this.replaceAllButton.UseVisualStyleBackColor = true;
			this.replaceAllButton.Click += new System.EventHandler (this.replaceAllButton_Click);
			// 
			// skipAllButton
			// 
			this.skipAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.skipAllButton.Location = new System.Drawing.Point (258, 94);
			this.skipAllButton.Name = "skipAllButton";
			this.skipAllButton.Size = new System.Drawing.Size (75, 23);
			this.skipAllButton.TabIndex = 3;
			this.skipAllButton.Text = "Skip All";
			this.skipAllButton.UseVisualStyleBackColor = true;
			this.skipAllButton.Click += new System.EventHandler (this.skipAllButton_Click);
			// 
			// skipButton
			// 
			this.skipButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.skipButton.Location = new System.Drawing.Point (177, 94);
			this.skipButton.Name = "skipButton";
			this.skipButton.Size = new System.Drawing.Size (75, 23);
			this.skipButton.TabIndex = 2;
			this.skipButton.Text = "Skip";
			this.skipButton.UseVisualStyleBackColor = true;
			this.skipButton.Click += new System.EventHandler (this.skipButton_Click);
			// 
			// uploadAllButton
			// 
			this.uploadAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.uploadAllButton.Location = new System.Drawing.Point (420, 94);
			this.uploadAllButton.Name = "uploadAllButton";
			this.uploadAllButton.Size = new System.Drawing.Size (75, 23);
			this.uploadAllButton.TabIndex = 5;
			this.uploadAllButton.Text = "Upload All";
			this.uploadAllButton.UseVisualStyleBackColor = true;
			this.uploadAllButton.Click += new System.EventHandler (this.uploadAllButton_Click);
			// 
			// uploadButton
			// 
			this.uploadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.uploadButton.Location = new System.Drawing.Point (339, 94);
			this.uploadButton.Name = "uploadButton";
			this.uploadButton.Size = new System.Drawing.Size (75, 23);
			this.uploadButton.TabIndex = 4;
			this.uploadButton.Text = "Upload";
			this.uploadButton.UseVisualStyleBackColor = true;
			this.uploadButton.Click += new System.EventHandler (this.uploadButton_Click);
			// 
			// textLabel
			// 
			this.textLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.textLabel.AutoSize = true;
			this.textLabel.Location = new System.Drawing.Point (12, 9);
			this.textLabel.Name = "textLabel";
			this.textLabel.Size = new System.Drawing.Size (416, 65);
			this.textLabel.TabIndex = 6;
			this.textLabel.Text = "A photo titled {0} is already present in album {1}.\r\n\r\nWhat would you like to do?" +
			    "\r\n\r\nNote: Photos in Picasa are not stored by title and the two photos might not " +
			    "be identical.";
			// 
			// DuplicateActionDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size (508, 124);
			this.ControlBox = false;
			this.Controls.Add (this.textLabel);
			this.Controls.Add (this.uploadAllButton);
			this.Controls.Add (this.uploadButton);
			this.Controls.Add (this.skipAllButton);
			this.Controls.Add (this.skipButton);
			this.Controls.Add (this.replaceAllButton);
			this.Controls.Add (this.replaceButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject ("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DuplicateActionDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Duplicate Photo?";
			this.ResumeLayout (false);
			this.PerformLayout ();

		}

		#endregion

		private System.Windows.Forms.Button replaceButton;
		private System.Windows.Forms.Button replaceAllButton;
		private System.Windows.Forms.Button skipAllButton;
		private System.Windows.Forms.Button skipButton;
		private System.Windows.Forms.Button uploadAllButton;
		private System.Windows.Forms.Button uploadButton;
		private System.Windows.Forms.Label textLabel;
	}
}