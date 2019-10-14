namespace Grafica_pe_calculator
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.borderColorButton = new System.Windows.Forms.Button();
            this.borderColorPB = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fillColorButton = new System.Windows.Forms.Button();
            this.fillColorPB = new System.Windows.Forms.PictureBox();
            this.rotationTrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderColorPB)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fillColorPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Location = new System.Drawing.Point(12, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "shape";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.borderColorButton);
            this.groupBox1.Controls.Add(this.borderColorPB);
            this.groupBox1.Location = new System.Drawing.Point(618, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 98);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Border";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 19);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(136, 45);
            this.trackBar1.TabIndex = 4;
            // 
            // borderColorButton
            // 
            this.borderColorButton.Location = new System.Drawing.Point(106, 64);
            this.borderColorButton.Name = "borderColorButton";
            this.borderColorButton.Size = new System.Drawing.Size(36, 28);
            this.borderColorButton.TabIndex = 3;
            this.borderColorButton.Text = "pick";
            this.borderColorButton.UseVisualStyleBackColor = true;
            this.borderColorButton.Click += new System.EventHandler(this.borderColorButton_Click);
            // 
            // borderColorPB
            // 
            this.borderColorPB.Location = new System.Drawing.Point(6, 64);
            this.borderColorPB.Name = "borderColorPB";
            this.borderColorPB.Size = new System.Drawing.Size(93, 28);
            this.borderColorPB.TabIndex = 2;
            this.borderColorPB.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fillColorButton);
            this.groupBox2.Controls.Add(this.fillColorPB);
            this.groupBox2.Location = new System.Drawing.Point(618, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 47);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fill";
            // 
            // fillColorButton
            // 
            this.fillColorButton.Location = new System.Drawing.Point(106, 13);
            this.fillColorButton.Name = "fillColorButton";
            this.fillColorButton.Size = new System.Drawing.Size(36, 28);
            this.fillColorButton.TabIndex = 1;
            this.fillColorButton.Text = "pick";
            this.fillColorButton.UseVisualStyleBackColor = true;
            // 
            // fillColorPB
            // 
            this.fillColorPB.Location = new System.Drawing.Point(6, 13);
            this.fillColorPB.Name = "fillColorPB";
            this.fillColorPB.Size = new System.Drawing.Size(93, 28);
            this.fillColorPB.TabIndex = 0;
            this.fillColorPB.TabStop = false;
            // 
            // rotationTrackBar
            // 
            this.rotationTrackBar.Location = new System.Drawing.Point(618, 356);
            this.rotationTrackBar.Maximum = 72;
            this.rotationTrackBar.Name = "rotationTrackBar";
            this.rotationTrackBar.Size = new System.Drawing.Size(148, 45);
            this.rotationTrackBar.TabIndex = 5;
            this.rotationTrackBar.ValueChanged += new System.EventHandler(this.rotationTrackBar_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rotation";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(618, 438);
            this.trackBar2.Maximum = 39;
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(148, 45);
            this.trackBar2.TabIndex = 7;
            this.trackBar2.Value = 20;
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Scale";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 720);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rotationTrackBar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderColorPB)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fillColorPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button borderColorButton;
        private System.Windows.Forms.PictureBox borderColorPB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button fillColorButton;
        private System.Windows.Forms.PictureBox fillColorPB;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar rotationTrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label3;
    }
}

