namespace ImageSegmentation
{
    partial class MainForm
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
            this.inputPictureBox = new System.Windows.Forms.PictureBox();
            this.outputPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.meansNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.runButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.noticeLabel = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxLoopsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.minErrorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.inputPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meansNumericUpDown)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxLoopsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minErrorNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputPictureBox
            // 
            this.inputPictureBox.BackColor = System.Drawing.Color.White;
            this.inputPictureBox.Location = new System.Drawing.Point(17, 139);
            this.inputPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputPictureBox.Name = "inputPictureBox";
            this.inputPictureBox.Size = new System.Drawing.Size(557, 480);
            this.inputPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inputPictureBox.TabIndex = 0;
            this.inputPictureBox.TabStop = false;
            // 
            // outputPictureBox
            // 
            this.outputPictureBox.BackColor = System.Drawing.Color.White;
            this.outputPictureBox.Location = new System.Drawing.Point(582, 139);
            this.outputPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.outputPictureBox.Name = "outputPictureBox";
            this.outputPictureBox.Size = new System.Drawing.Size(557, 480);
            this.outputPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.outputPictureBox.TabIndex = 1;
            this.outputPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input image";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(779, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output image";
            // 
            // pathLabel
            // 
            this.pathLabel.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathLabel.Location = new System.Drawing.Point(24, 624);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(682, 50);
            this.pathLabel.TabIndex = 4;
            this.pathLabel.Text = "File path:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "K =";
            // 
            // meansNumericUpDown
            // 
            this.meansNumericUpDown.Location = new System.Drawing.Point(78, 54);
            this.meansNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.meansNumericUpDown.Name = "meansNumericUpDown";
            this.meansNumericUpDown.Size = new System.Drawing.Size(92, 35);
            this.meansNumericUpDown.TabIndex = 8;
            this.meansNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // runButton
            // 
            this.runButton.BackColor = System.Drawing.Color.LimeGreen;
            this.runButton.FlatAppearance.BorderSize = 0;
            this.runButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runButton.ForeColor = System.Drawing.Color.White;
            this.runButton.Location = new System.Drawing.Point(722, 50);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(90, 36);
            this.runButton.TabIndex = 9;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = false;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Image files(*.PNG;*.BMP;*.JPG;*.GIF)|*.PNG;*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            // 
            // noticeLabel
            // 
            this.noticeLabel.AutoSize = true;
            this.noticeLabel.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeLabel.Location = new System.Drawing.Point(780, 359);
            this.noticeLabel.Name = "noticeLabel";
            this.noticeLabel.Size = new System.Drawing.Size(177, 24);
            this.noticeLabel.TabIndex = 10;
            this.noticeLabel.Text = "image sedang di proses ..";
            this.noticeLabel.Visible = false;
            this.noticeLabel.Click += new System.EventHandler(this.noticeLabel_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Image files(*.PNG;*.BMP;*.JPG;*.GIF)|*.PNG;*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1153, 33);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem,
            this.saveOutputToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.openImageToolStripMenuItem.Text = "Open image";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // saveOutputToolStripMenuItem
            // 
            this.saveOutputToolStripMenuItem.Name = "saveOutputToolStripMenuItem";
            this.saveOutputToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.saveOutputToolStripMenuItem.Text = "Save output";
            this.saveOutputToolStripMenuItem.Click += new System.EventHandler(this.saveOutputToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // maxLoopsNumericUpDown
            // 
            this.maxLoopsNumericUpDown.Location = new System.Drawing.Point(126, 16);
            this.maxLoopsNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.maxLoopsNumericUpDown.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.maxLoopsNumericUpDown.Name = "maxLoopsNumericUpDown";
            this.maxLoopsNumericUpDown.Size = new System.Drawing.Size(95, 35);
            this.maxLoopsNumericUpDown.TabIndex = 11;
            this.maxLoopsNumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(260, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 27);
            this.label6.TabIndex = 15;
            this.label6.Text = "Min error:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "Max loops:";
            // 
            // minErrorNumericUpDown
            // 
            this.minErrorNumericUpDown.Location = new System.Drawing.Point(372, 16);
            this.minErrorNumericUpDown.Name = "minErrorNumericUpDown";
            this.minErrorNumericUpDown.Size = new System.Drawing.Size(95, 35);
            this.minErrorNumericUpDown.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.minErrorNumericUpDown);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.maxLoopsNumericUpDown);
            this.groupBox1.Location = new System.Drawing.Point(223, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 52);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 683);
            this.Controls.Add(this.noticeLabel);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.meansNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputPictureBox);
            this.Controls.Add(this.inputPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Segmentation by Annisa Johan M Afdal";
            ((System.ComponentModel.ISupportInitialize)(this.inputPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meansNumericUpDown)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxLoopsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minErrorNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox inputPictureBox;
        private System.Windows.Forms.PictureBox outputPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown meansNumericUpDown;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label noticeLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveOutputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown maxLoopsNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown minErrorNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

