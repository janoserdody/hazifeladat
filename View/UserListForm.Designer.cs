namespace View
{
    partial class UserListForm
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.buttonModify = new System.Windows.Forms.Button();
            this.saveXMLButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(Common.User);
            this.gridControl1.Location = new System.Drawing.Point(39, 29);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1500, 500);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(571, 619);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(175, 51);
            this.buttonModify.TabIndex = 1;
            this.buttonModify.Text = "Módosít";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveXMLButton
            // 
            this.saveXMLButton.Location = new System.Drawing.Point(927, 619);
            this.saveXMLButton.Name = "saveXMLButton";
            this.saveXMLButton.Size = new System.Drawing.Size(177, 51);
            this.saveXMLButton.TabIndex = 2;
            this.saveXMLButton.Text = "XML-be mentés";
            this.saveXMLButton.UseVisualStyleBackColor = true;
            this.saveXMLButton.Click += new System.EventHandler(this.saveXMLButton_Click);
            // 
            // UserListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2134, 1230);
            this.Controls.Add(this.saveXMLButton);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.gridControl1);
            this.Name = "UserListForm";
            this.Text = "UserListForm";
            this.Activated += new System.EventHandler(this.UserListForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button saveXMLButton;
    }
}