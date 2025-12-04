namespace p
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sbSelect = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnScaleM = new System.Windows.Forms.Button();
            this.btnScalePlus = new System.Windows.Forms.Button();
            this.btnText = new System.Windows.Forms.Button();
            this.btnPipetka = new System.Windows.Forms.Button();
            this.brush_color = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnPic = new System.Windows.Forms.Button();
            this.btnBrush = new System.Windows.Forms.Button();
            this.pic_color = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnRect = new System.Windows.Forms.Button();
            this.btnLastic = new System.Windows.Forms.Button();
            this.btnEll = new System.Windows.Forms.Button();
            this.btnPencil = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveJPGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.saveVectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openVectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1280, 521);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.sbSelect);
            this.panel1.Controls.Add(this.btnDown);
            this.panel1.Controls.Add(this.btnRight);
            this.panel1.Controls.Add(this.btnLeft);
            this.panel1.Controls.Add(this.btnTop);
            this.panel1.Controls.Add(this.btnScaleM);
            this.panel1.Controls.Add(this.btnScalePlus);
            this.panel1.Controls.Add(this.btnText);
            this.panel1.Controls.Add(this.btnPipetka);
            this.panel1.Controls.Add(this.brush_color);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.btnPic);
            this.panel1.Controls.Add(this.btnBrush);
            this.panel1.Controls.Add(this.pic_color);
            this.panel1.Controls.Add(this.btnColor);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnLine);
            this.panel1.Controls.Add(this.btnRect);
            this.panel1.Controls.Add(this.btnLastic);
            this.panel1.Controls.Add(this.btnEll);
            this.panel1.Controls.Add(this.btnPencil);
            this.panel1.Location = new System.Drawing.Point(3, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1258, 99);
            this.panel1.TabIndex = 1;
            // 
            // sbSelect
            // 
            this.sbSelect.Location = new System.Drawing.Point(497, 6);
            this.sbSelect.Name = "sbSelect";
            this.sbSelect.Size = new System.Drawing.Size(75, 38);
            this.sbSelect.TabIndex = 22;
            this.sbSelect.Text = "Select";
            this.sbSelect.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(907, 67);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(63, 23);
            this.btnDown.TabIndex = 21;
            this.btnDown.Text = "down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(939, 35);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(53, 26);
            this.btnRight.TabIndex = 20;
            this.btnRight.Text = "right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(865, 35);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(59, 26);
            this.btnLeft.TabIndex = 19;
            this.btnLeft.Text = "left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnTop
            // 
            this.btnTop.Location = new System.Drawing.Point(907, 6);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(46, 24);
            this.btnTop.TabIndex = 18;
            this.btnTop.Text = "top";
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // btnScaleM
            // 
            this.btnScaleM.Location = new System.Drawing.Point(998, 56);
            this.btnScaleM.Name = "btnScaleM";
            this.btnScaleM.Size = new System.Drawing.Size(81, 31);
            this.btnScaleM.TabIndex = 17;
            this.btnScaleM.Text = "Scale-";
            this.btnScaleM.UseVisualStyleBackColor = true;
            this.btnScaleM.Click += new System.EventHandler(this.btnScaleM_Click);
            // 
            // btnScalePlus
            // 
            this.btnScalePlus.Location = new System.Drawing.Point(998, 19);
            this.btnScalePlus.Name = "btnScalePlus";
            this.btnScalePlus.Size = new System.Drawing.Size(81, 31);
            this.btnScalePlus.TabIndex = 16;
            this.btnScalePlus.Text = "Scale+";
            this.btnScalePlus.UseVisualStyleBackColor = true;
            this.btnScalePlus.Click += new System.EventHandler(this.btnScalePlus_Click);
            // 
            // btnText
            // 
            this.btnText.Location = new System.Drawing.Point(413, 50);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(77, 38);
            this.btnText.TabIndex = 15;
            this.btnText.Text = "Text";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // btnPipetka
            // 
            this.btnPipetka.Location = new System.Drawing.Point(413, 9);
            this.btnPipetka.Name = "btnPipetka";
            this.btnPipetka.Size = new System.Drawing.Size(77, 38);
            this.btnPipetka.TabIndex = 14;
            this.btnPipetka.Text = "Pipetka";
            this.btnPipetka.UseVisualStyleBackColor = true;
            this.btnPipetka.Click += new System.EventHandler(this.button1_Click);
            // 
            // brush_color
            // 
            this.brush_color.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.brush_color.ForeColor = System.Drawing.Color.Black;
            this.brush_color.Location = new System.Drawing.Point(332, 51);
            this.brush_color.Name = "brush_color";
            this.brush_color.Size = new System.Drawing.Size(75, 40);
            this.brush_color.TabIndex = 13;
            this.brush_color.UseVisualStyleBackColor = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(690, 9);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(119, 56);
            this.trackBar1.TabIndex = 12;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btnPic
            // 
            this.btnPic.Location = new System.Drawing.Point(1113, 60);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(81, 31);
            this.btnPic.TabIndex = 10;
            this.btnPic.Text = "Picture";
            this.btnPic.UseVisualStyleBackColor = true;
            this.btnPic.Click += new System.EventHandler(this.btnPic_Click);
            // 
            // btnBrush
            // 
            this.btnBrush.Location = new System.Drawing.Point(332, 9);
            this.btnBrush.Name = "btnBrush";
            this.btnBrush.Size = new System.Drawing.Size(75, 41);
            this.btnBrush.TabIndex = 9;
            this.btnBrush.Text = "Brush";
            this.btnBrush.UseVisualStyleBackColor = true;
            this.btnBrush.Click += new System.EventHandler(this.btnBrush_Click);
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pic_color.ForeColor = System.Drawing.Color.Black;
            this.pic_color.Location = new System.Drawing.Point(263, 3);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(54, 88);
            this.pic_color.TabIndex = 8;
            this.pic_color.UseVisualStyleBackColor = false;
            this.pic_color.Click += new System.EventHandler(this.pic_color_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(182, 51);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 40);
            this.btnColor.TabIndex = 7;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1113, 14);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(81, 36);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(9, 50);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(75, 41);
            this.btnLine.TabIndex = 4;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnRect
            // 
            this.btnRect.Location = new System.Drawing.Point(90, 50);
            this.btnRect.Name = "btnRect";
            this.btnRect.Size = new System.Drawing.Size(85, 41);
            this.btnRect.TabIndex = 3;
            this.btnRect.Text = "Rectangle";
            this.btnRect.UseVisualStyleBackColor = true;
            this.btnRect.Click += new System.EventHandler(this.btnRect_Click);
            // 
            // btnLastic
            // 
            this.btnLastic.Location = new System.Drawing.Point(181, 3);
            this.btnLastic.Name = "btnLastic";
            this.btnLastic.Size = new System.Drawing.Size(75, 41);
            this.btnLastic.TabIndex = 2;
            this.btnLastic.Text = "Lastic";
            this.btnLastic.UseVisualStyleBackColor = true;
            this.btnLastic.Click += new System.EventHandler(this.btnLastic_Click);
            // 
            // btnEll
            // 
            this.btnEll.Location = new System.Drawing.Point(90, 3);
            this.btnEll.Name = "btnEll";
            this.btnEll.Size = new System.Drawing.Size(85, 41);
            this.btnEll.TabIndex = 1;
            this.btnEll.Text = "Ellipse";
            this.btnEll.UseVisualStyleBackColor = true;
            this.btnEll.Click += new System.EventHandler(this.btnEll_Click);
            // 
            // btnPencil
            // 
            this.btnPencil.Location = new System.Drawing.Point(9, 3);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(75, 41);
            this.btnPencil.TabIndex = 0;
            this.btnPencil.Text = "Pencil";
            this.btnPencil.UseVisualStyleBackColor = true;
            this.btnPencil.Click += new System.EventHandler(this.btnPencil_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1260, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveJPGToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveVectorToolStripMenuItem,
            this.openVectorToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveJPGToolStripMenuItem
            // 
            this.saveJPGToolStripMenuItem.Name = "saveJPGToolStripMenuItem";
            this.saveJPGToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveJPGToolStripMenuItem.Text = "Save";
            this.saveJPGToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.selectToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.selectToolStripMenuItem.Text = "Select";
            this.selectToolStripMenuItem.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(1017, 177);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(243, 356);
            this.listBox1.TabIndex = 3;
            // 
            // saveVectorToolStripMenuItem
            // 
            this.saveVectorToolStripMenuItem.Name = "saveVectorToolStripMenuItem";
            this.saveVectorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveVectorToolStripMenuItem.Text = "Save vector";
            this.saveVectorToolStripMenuItem.Click += new System.EventHandler(this.saveVectorToolStripMenuItem_Click);
            // 
            // openVectorToolStripMenuItem
            // 
            this.openVectorToolStripMenuItem.Name = "openVectorToolStripMenuItem";
            this.openVectorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openVectorToolStripMenuItem.Text = "Open vector";
            this.openVectorToolStripMenuItem.Click += new System.EventHandler(this.openVectorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 690);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPencil;
        private System.Windows.Forms.Button btnEll;
        private System.Windows.Forms.Button btnLastic;
        private System.Windows.Forms.Button btnRect;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.Button btnPic;
        private System.Windows.Forms.Button btnBrush;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveJPGToolStripMenuItem;
        private System.Windows.Forms.Button brush_color;
        private System.Windows.Forms.Button btnPipetka;
        private System.Windows.Forms.Button btnScaleM;
        private System.Windows.Forms.Button btnScalePlus;
        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Button sbSelect;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem saveVectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openVectorToolStripMenuItem;
    }
}

