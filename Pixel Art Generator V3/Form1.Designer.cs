namespace Pixel_Art_Generator_V3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.xInput = new System.Windows.Forms.TextBox();
            this.labX = new System.Windows.Forms.Label();
            this.labY = new System.Windows.Forms.Label();
            this.yInput = new System.Windows.Forms.TextBox();
            this.bGen = new System.Windows.Forms.Button();
            this.colInput = new System.Windows.Forms.TextBox();
            this.labCol = new System.Windows.Forms.Label();
            this.testing = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bSave = new System.Windows.Forms.Button();
            this.bLoad = new System.Windows.Forms.Button();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // xInput
            // 
            this.xInput.Location = new System.Drawing.Point(59, 12);
            this.xInput.Name = "xInput";
            this.xInput.Size = new System.Drawing.Size(100, 23);
            this.xInput.TabIndex = 0;
            this.xInput.Text = "10";
            // 
            // labX
            // 
            this.labX.AutoSize = true;
            this.labX.Location = new System.Drawing.Point(12, 15);
            this.labX.Name = "labX";
            this.labX.Size = new System.Drawing.Size(41, 15);
            this.labX.TabIndex = 1;
            this.labX.Text = "X-Axis";
            // 
            // labY
            // 
            this.labY.AutoSize = true;
            this.labY.Location = new System.Drawing.Point(165, 15);
            this.labY.Name = "labY";
            this.labY.Size = new System.Drawing.Size(41, 15);
            this.labY.TabIndex = 2;
            this.labY.Text = "Y-Axis";
            // 
            // yInput
            // 
            this.yInput.Location = new System.Drawing.Point(212, 12);
            this.yInput.Name = "yInput";
            this.yInput.Size = new System.Drawing.Size(100, 23);
            this.yInput.TabIndex = 3;
            this.yInput.Text = "10";
            // 
            // bGen
            // 
            this.bGen.Location = new System.Drawing.Point(318, 12);
            this.bGen.Name = "bGen";
            this.bGen.Size = new System.Drawing.Size(75, 23);
            this.bGen.TabIndex = 4;
            this.bGen.Text = "Generate";
            this.bGen.UseVisualStyleBackColor = true;
            this.bGen.Click += new System.EventHandler(this.bGen_Click);
            // 
            // colInput
            // 
            this.colInput.Location = new System.Drawing.Point(857, 12);
            this.colInput.MaxLength = 6;
            this.colInput.Name = "colInput";
            this.colInput.Size = new System.Drawing.Size(100, 23);
            this.colInput.TabIndex = 5;
            // 
            // labCol
            // 
            this.labCol.AutoSize = true;
            this.labCol.Location = new System.Drawing.Point(815, 15);
            this.labCol.Name = "labCol";
            this.labCol.Size = new System.Drawing.Size(36, 15);
            this.labCol.TabIndex = 6;
            this.labCol.Text = "Color";
            // 
            // testing
            // 
            this.testing.AutoSize = true;
            this.testing.Location = new System.Drawing.Point(857, 37);
            this.testing.Name = "testing";
            this.testing.Size = new System.Drawing.Size(38, 15);
            this.testing.TabIndex = 8;
            this.testing.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Tick);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(653, 11);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 9;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bLoad
            // 
            this.bLoad.Location = new System.Drawing.Point(734, 11);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(75, 23);
            this.bLoad.TabIndex = 10;
            this.bLoad.Text = "Load";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(399, 12);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(248, 23);
            this.nameInput.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 450);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.bLoad);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.testing);
            this.Controls.Add(this.labCol);
            this.Controls.Add(this.colInput);
            this.Controls.Add(this.bGen);
            this.Controls.Add(this.yInput);
            this.Controls.Add(this.labY);
            this.Controls.Add(this.labX);
            this.Controls.Add(this.xInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xInput;
        private System.Windows.Forms.Label labX;
        private System.Windows.Forms.Label labY;
        private System.Windows.Forms.TextBox yInput;
        private System.Windows.Forms.Button bGen;
        private System.Windows.Forms.TextBox colInput;
        private System.Windows.Forms.Label labCol;
        private System.Windows.Forms.Label testing;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.TextBox nameInput;
    }
}
