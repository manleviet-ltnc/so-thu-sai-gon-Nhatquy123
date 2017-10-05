namespace Sở_Thú_Xì_Gòn
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstThumoi = new System.Windows.Forms.TextBox();
            this.lstDanhsachthu = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thú mới";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách thú ";
            // 
            // lstThumoi
            // 
            this.lstThumoi.AllowDrop = true;
            this.lstThumoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstThumoi.Location = new System.Drawing.Point(3, 104);
            this.lstThumoi.Name = "lstThumoi";
            this.lstThumoi.Size = new System.Drawing.Size(110, 20);
            this.lstThumoi.TabIndex = 2;
            this.lstThumoi.Text = "lst ThuMoi";
            this.toolTip1.SetToolTip(this.lstThumoi, "Ấn chuột và kéo sang Danh sách thú để tạo sở thú ");
            this.lstThumoi.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstDanhSach_DragDrop);
            this.lstThumoi.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            // 
            // lstDanhsachthu
            // 
            this.lstDanhsachthu.AllowDrop = true;
            this.lstDanhsachthu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDanhsachthu.Location = new System.Drawing.Point(119, 104);
            this.lstDanhsachthu.Name = "lstDanhsachthu";
            this.lstDanhsachthu.Size = new System.Drawing.Size(111, 20);
            this.lstDanhsachthu.TabIndex = 3;
            this.lstDanhsachthu.Text = "lst Danh sách ";
            this.lstDanhsachthu.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstDanhSach_DragDrop);
            this.lstDanhsachthu.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstDanhSach_DragDrop);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lstThumoi, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lstDanhsachthu, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(76, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(233, 230);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 367);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lstThumoi;
        private System.Windows.Forms.TextBox lstDanhsachthu;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

