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
            this.inputX = new System.Windows.Forms.TextBox();
            this.labX = new System.Windows.Forms.Label();
            this.labY = new System.Windows.Forms.Label();
            this.inputY = new System.Windows.Forms.TextBox();
            this.bGen = new System.Windows.Forms.Button();
            this.inputCol = new System.Windows.Forms.TextBox();
            this.labCol = new System.Windows.Forms.Label();
            this.testing = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bSave = new System.Windows.Forms.Button();
            this.bLoad = new System.Windows.Forms.Button();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputScale = new System.Windows.Forms.TextBox();
            this.labScale = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputX
            // 
            this.inputX.Location = new System.Drawing.Point(59, 12);
            this.inputX.Name = "inputX";
            this.inputX.Size = new System.Drawing.Size(35, 23);
            this.inputX.TabIndex = 0;
            this.inputX.Text = "10";
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
            this.labY.Location = new System.Drawing.Point(100, 15);
            this.labY.Name = "labY";
            this.labY.Size = new System.Drawing.Size(41, 15);
            this.labY.TabIndex = 2;
            this.labY.Text = "Y-Axis";
            // 
            // inputY
            // 
            this.inputY.Location = new System.Drawing.Point(147, 12);
            this.inputY.Name = "inputY";
            this.inputY.Size = new System.Drawing.Size(35, 23);
            this.inputY.TabIndex = 3;
            this.inputY.Text = "10";
            // 
            // bGen
            // 
            this.bGen.Location = new System.Drawing.Point(188, 11);
            this.bGen.Name = "bGen";
            this.bGen.Size = new System.Drawing.Size(75, 23);
            this.bGen.TabIndex = 4;
            this.bGen.Text = "Generate";
            this.bGen.UseVisualStyleBackColor = true;
            this.bGen.Click += new System.EventHandler(this.bGen_Click);
            // 
            // inputCol
            // 
            this.inputCol.Location = new System.Drawing.Point(727, 11);
            this.inputCol.MaxLength = 6;
            this.inputCol.Name = "inputCol";
            this.inputCol.Size = new System.Drawing.Size(51, 23);
            this.inputCol.TabIndex = 5;
            this.inputCol.Text = "FF0000";
            // 
            // labCol
            // 
            this.labCol.AutoSize = true;
            this.labCol.Location = new System.Drawing.Point(685, 16);
            this.labCol.Name = "labCol";
            this.labCol.Size = new System.Drawing.Size(36, 15);
            this.labCol.TabIndex = 6;
            this.labCol.Text = "Color";
            // 
            // testing
            // 
            this.testing.AutoSize = true;
            this.testing.Location = new System.Drawing.Point(784, 16);
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
            this.bSave.Location = new System.Drawing.Point(523, 12);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 9;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bLoad
            // 
            this.bLoad.Location = new System.Drawing.Point(604, 12);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(75, 23);
            this.bLoad.TabIndex = 10;
            this.bLoad.Text = "Load";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(314, 12);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(111, 23);
            this.inputName.TabIndex = 11;
            // 
            // inputScale
            // 
            this.inputScale.Location = new System.Drawing.Point(471, 12);
            this.inputScale.Name = "inputScale";
            this.inputScale.Size = new System.Drawing.Size(46, 23);
            this.inputScale.TabIndex = 12;
            this.inputScale.Text = "1";
            // 
            // labScale
            // 
            this.labScale.AutoSize = true;
            this.labScale.Location = new System.Drawing.Point(431, 15);
            this.labScale.Name = "labScale";
            this.labScale.Size = new System.Drawing.Size(34, 15);
            this.labScale.TabIndex = 13;
            this.labScale.Text = "Scale";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(269, 15);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(39, 15);
            this.labName.TabIndex = 14;
            this.labName.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labScale);
            this.Controls.Add(this.inputScale);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.bLoad);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.testing);
            this.Controls.Add(this.labCol);
            this.Controls.Add(this.inputCol);
            this.Controls.Add(this.bGen);
            this.Controls.Add(this.inputY);
            this.Controls.Add(this.labY);
            this.Controls.Add(this.labX);
            this.Controls.Add(this.inputX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputX;
        private System.Windows.Forms.Label labX;
        private System.Windows.Forms.Label labY;
        private System.Windows.Forms.TextBox inputY;
        private System.Windows.Forms.Button bGen;
        private System.Windows.Forms.TextBox inputCol;
        private System.Windows.Forms.Label labCol;
        private System.Windows.Forms.Label testing;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputScale;
        private System.Windows.Forms.Label labScale;
        private System.Windows.Forms.Label labName;
    }
}
