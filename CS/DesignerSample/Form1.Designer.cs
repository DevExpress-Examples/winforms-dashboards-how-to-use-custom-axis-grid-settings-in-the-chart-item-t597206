﻿namespace DesignerSample
{
    partial class Form1
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
            this.dashboardDesigner1 = new DevExpress.DashboardWin.DashboardDesigner();
            this.SuspendLayout();
            // 
            // dashboardDesigner1
            // 
            this.dashboardDesigner1.DataSourceWizardSettings.AvailableDataSourceTypes = ((DevExpress.DashboardWin.DashboardDesignerDataSourceType)((((((DevExpress.DashboardWin.DashboardDesignerDataSourceType.Sql | DevExpress.DashboardWin.DashboardDesignerDataSourceType.Olap) 
            | DevExpress.DashboardWin.DashboardDesignerDataSourceType.Object) 
            | DevExpress.DashboardWin.DashboardDesignerDataSourceType.EF) 
            | DevExpress.DashboardWin.DashboardDesignerDataSourceType.Excel) 
            | DevExpress.DashboardWin.DashboardDesignerDataSourceType.Extract)));
            this.dashboardDesigner1.DataSourceWizardSettings.EnableCustomSql = true;
            this.dashboardDesigner1.DataSourceWizardSettings.QueryBuilderDiagramView = false;
            this.dashboardDesigner1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardDesigner1.Location = new System.Drawing.Point(0, 0);
            this.dashboardDesigner1.Name = "dashboardDesigner1";
            this.dashboardDesigner1.Size = new System.Drawing.Size(1299, 744);
            this.dashboardDesigner1.TabIndex = 0;
            this.dashboardDesigner1.DashboardItemControlCreated += new DevExpress.DashboardWin.DashboardItemControlCreatedEventHandler(this.dashboardDesigner1_DashboardItemControlCreated);
            this.dashboardDesigner1.DashboardItemBeforeControlDisposed += new DevExpress.DashboardWin.DashboardItemBeforeControlDisposedEventHandler(this.dashboardDesigner1_DashboardItemBeforeControlDisposed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 744);
            this.Controls.Add(this.dashboardDesigner1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.DashboardWin.DashboardDesigner dashboardDesigner1;
    }
}