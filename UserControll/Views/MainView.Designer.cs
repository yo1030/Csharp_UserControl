namespace UserControll.Views
{
    partial class MainView
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
            AAATextBox = new TextBox();
            CallButton = new Button();
            searchControl = new SearchControl();
            SuspendLayout();
            // 
            // AAATextBox
            // 
            AAATextBox.Location = new Point(35, 49);
            AAATextBox.Name = "AAATextBox";
            AAATextBox.Size = new Size(100, 23);
            AAATextBox.TabIndex = 0;
            // 
            // CallButton
            // 
            CallButton.Location = new Point(174, 49);
            CallButton.Name = "CallButton";
            CallButton.Size = new Size(75, 23);
            CallButton.TabIndex = 1;
            CallButton.Text = "Call";
            CallButton.UseVisualStyleBackColor = true;
            // 
            // searchControl
            // 
            searchControl.BorderStyle = BorderStyle.FixedSingle;
            searchControl.Location = new Point(35, 105);
            searchControl.Name = "searchControl";
            searchControl.Size = new Size(275, 114);
            searchControl.TabIndex = 2;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 442);
            Controls.Add(searchControl);
            Controls.Add(CallButton);
            Controls.Add(AAATextBox);
            Name = "MainView";
            Text = "MainView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AAATextBox;
        private Button CallButton;
        private SearchControl searchControl;
    }
}