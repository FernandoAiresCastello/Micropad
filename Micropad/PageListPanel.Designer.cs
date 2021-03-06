﻿namespace Micropad
{
    partial class PageListPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LstPages = new System.Windows.Forms.ListBox();
            this.BtnAddNewPage = new System.Windows.Forms.ToolStripButton();
            this.BtnDeletePage = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LstPages, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 355);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAddNewPage,
            this.BtnDeletePage});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(260, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 333);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(260, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LstPages
            // 
            this.LstPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstPages.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstPages.FormattingEnabled = true;
            this.LstPages.ItemHeight = 15;
            this.LstPages.Location = new System.Drawing.Point(3, 28);
            this.LstPages.Name = "LstPages";
            this.LstPages.ScrollAlwaysVisible = true;
            this.LstPages.Size = new System.Drawing.Size(254, 302);
            this.LstPages.TabIndex = 2;
            // 
            // BtnAddNewPage
            // 
            this.BtnAddNewPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnAddNewPage.Image = global::Micropad.Properties.Resources.add;
            this.BtnAddNewPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAddNewPage.Name = "BtnAddNewPage";
            this.BtnAddNewPage.Size = new System.Drawing.Size(23, 22);
            this.BtnAddNewPage.Text = "Add new page";
            this.BtnAddNewPage.Click += new System.EventHandler(this.BtnAddNewPage_Click);
            // 
            // BtnDeletePage
            // 
            this.BtnDeletePage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDeletePage.Image = global::Micropad.Properties.Resources.delete;
            this.BtnDeletePage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDeletePage.Name = "BtnDeletePage";
            this.BtnDeletePage.Size = new System.Drawing.Size(23, 22);
            this.BtnDeletePage.Text = "Delete selected page";
            this.BtnDeletePage.Click += new System.EventHandler(this.BtnDeletePage_Click);
            // 
            // PageListPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PageListPanel";
            this.Size = new System.Drawing.Size(260, 355);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton BtnAddNewPage;
        private System.Windows.Forms.ListBox LstPages;
        private System.Windows.Forms.ToolStripButton BtnDeletePage;
    }
}
