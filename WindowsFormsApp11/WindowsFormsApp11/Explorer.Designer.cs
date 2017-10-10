namespace WindowsFormsApp11
{
    partial class Explorer
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.explorerTreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // explorerTreeView
            // 
            this.explorerTreeView.Location = new System.Drawing.Point(12, 12);
            this.explorerTreeView.Name = "explorerTreeView";
            this.explorerTreeView.Size = new System.Drawing.Size(392, 421);
            this.explorerTreeView.TabIndex = 0;
            // 
            // Explorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 445);
            this.Controls.Add(this.explorerTreeView);
            this.Name = "Explorer";
            this.Text = "Explorer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView explorerTreeView;
    }
}

