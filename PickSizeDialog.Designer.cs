
namespace PWSG_LAB5
{
    partial class PickSizeDialog
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
            this.components = new System.ComponentModel.Container();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.PickErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PickErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(130, 28);
            this.widthTextBox.MaxLength = 2;
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 23);
            this.widthTextBox.TabIndex = 0;
            this.widthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.widthTextBox_Validating);
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(130, 70);
            this.heightTextBox.MaxLength = 2;
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 23);
            this.heightTextBox.TabIndex = 1;
            this.heightTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.heightTextBox_Validating);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(26, 31);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(39, 15);
            this.widthLabel.TabIndex = 2;
            this.widthLabel.Text = "Width";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(26, 73);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(43, 15);
            this.heightLabel.TabIndex = 3;
            this.heightLabel.Text = "Height";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(26, 115);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(154, 115);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // PickErrorProvider
            // 
            this.PickErrorProvider.ContainerControl = this;
            // 
            // PickSizeDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(258, 163);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.widthTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PickSizeDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pick Size";
            ((System.ComponentModel.ISupportInitialize)(this.PickErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ErrorProvider PickErrorProvider;
    }
}