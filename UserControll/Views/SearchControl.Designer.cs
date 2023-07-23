namespace UserControll.Views
{
    partial class SearchControl
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            SearchTextBox = new TextBox();
            BackButton = new Button();
            SuspendLayout();
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(20, 26);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(100, 23);
            SearchTextBox.TabIndex = 0;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(151, 26);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 1;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            // 
            // SeaarchControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(BackButton);
            Controls.Add(SearchTextBox);
            Name = "SeaarchControl";
            Size = new Size(275, 114);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SearchTextBox;
        private Button BackButton;
    }
}
