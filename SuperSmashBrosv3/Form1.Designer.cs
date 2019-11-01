namespace SuperSmashBrosv3
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
            this.stageBox = new System.Windows.Forms.PictureBox();
            this.stageBoxup = new System.Windows.Forms.PictureBox();
            this.stageBoxLeft = new System.Windows.Forms.PictureBox();
            this.stageBoxRight = new System.Windows.Forms.PictureBox();
            this.stageBoxDown = new System.Windows.Forms.PictureBox();
            this.p1Box = new System.Windows.Forms.PictureBox();
            this.p2Box = new System.Windows.Forms.PictureBox();
            this.gravityTimer = new System.Windows.Forms.Timer(this.components);
            this.jumpTimer1 = new System.Windows.Forms.Timer(this.components);
            this.jumpTimer2 = new System.Windows.Forms.Timer(this.components);
            this.stageCollisionTimer = new System.Windows.Forms.Timer(this.components);
            this.LocationTimer = new System.Windows.Forms.Timer(this.components);
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.testLabel = new System.Windows.Forms.Label();
            this.gravityTimer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.stageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stageBoxup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stageBoxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stageBoxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stageBoxDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Box)).BeginInit();
            this.SuspendLayout();
            // 
            // stageBox
            // 
            this.stageBox.BackColor = System.Drawing.Color.Black;
            this.stageBox.Location = new System.Drawing.Point(500, 400);
            this.stageBox.Name = "stageBox";
            this.stageBox.Size = new System.Drawing.Size(600, 200);
            this.stageBox.TabIndex = 0;
            this.stageBox.TabStop = false;
            // 
            // stageBoxup
            // 
            this.stageBoxup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.stageBoxup.Location = new System.Drawing.Point(500, 400);
            this.stageBoxup.Name = "stageBoxup";
            this.stageBoxup.Size = new System.Drawing.Size(600, 36);
            this.stageBoxup.TabIndex = 1;
            this.stageBoxup.TabStop = false;
            // 
            // stageBoxLeft
            // 
            this.stageBoxLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.stageBoxLeft.Location = new System.Drawing.Point(500, 432);
            this.stageBoxLeft.Name = "stageBoxLeft";
            this.stageBoxLeft.Size = new System.Drawing.Size(44, 168);
            this.stageBoxLeft.TabIndex = 2;
            this.stageBoxLeft.TabStop = false;
            // 
            // stageBoxRight
            // 
            this.stageBoxRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.stageBoxRight.Location = new System.Drawing.Point(1056, 432);
            this.stageBoxRight.Name = "stageBoxRight";
            this.stageBoxRight.Size = new System.Drawing.Size(44, 168);
            this.stageBoxRight.TabIndex = 3;
            this.stageBoxRight.TabStop = false;
            // 
            // stageBoxDown
            // 
            this.stageBoxDown.BackColor = System.Drawing.Color.Green;
            this.stageBoxDown.Location = new System.Drawing.Point(500, 564);
            this.stageBoxDown.Name = "stageBoxDown";
            this.stageBoxDown.Size = new System.Drawing.Size(600, 36);
            this.stageBoxDown.TabIndex = 4;
            this.stageBoxDown.TabStop = false;
            // 
            // p1Box
            // 
            this.p1Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.p1Box.Location = new System.Drawing.Point(500, 294);
            this.p1Box.Name = "p1Box";
            this.p1Box.Size = new System.Drawing.Size(80, 100);
            this.p1Box.TabIndex = 5;
            this.p1Box.TabStop = false;
            // 
            // p2Box
            // 
            this.p2Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.p2Box.Location = new System.Drawing.Point(1020, 294);
            this.p2Box.Name = "p2Box";
            this.p2Box.Size = new System.Drawing.Size(80, 100);
            this.p2Box.TabIndex = 6;
            this.p2Box.TabStop = false;
            // 
            // gravityTimer
            // 
            this.gravityTimer.Enabled = true;
            this.gravityTimer.Interval = 18;
            this.gravityTimer.Tick += new System.EventHandler(this.gravityTimer_Tick);
            // 
            // jumpTimer1
            // 
            this.jumpTimer1.Interval = 10;
            this.jumpTimer1.Tick += new System.EventHandler(this.jumpTimer1_Tick);
            // 
            // jumpTimer2
            // 
            this.jumpTimer2.Interval = 10;
            this.jumpTimer2.Tick += new System.EventHandler(this.jumpTimer2_Tick);
            // 
            // stageCollisionTimer
            // 
            this.stageCollisionTimer.Enabled = true;
            this.stageCollisionTimer.Interval = 10;
            this.stageCollisionTimer.Tick += new System.EventHandler(this.stageCollisionTimer_Tick);
            // 
            // LocationTimer
            // 
            this.LocationTimer.Enabled = true;
            this.LocationTimer.Interval = 10;
            this.LocationTimer.Tick += new System.EventHandler(this.p1LocationTimer_Tick);
            // 
            // moveTimer
            // 
            this.moveTimer.Enabled = true;
            this.moveTimer.Interval = 10;
            this.moveTimer.Tick += new System.EventHandler(this.moveTimer_Tick);
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(78, 69);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(35, 13);
            this.testLabel.TabIndex = 7;
            this.testLabel.Text = "label1";
            // 
            // gravityTimer2
            // 
            this.gravityTimer2.Enabled = true;
            this.gravityTimer2.Interval = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1584, 761);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.p2Box);
            this.Controls.Add(this.p1Box);
            this.Controls.Add(this.stageBoxDown);
            this.Controls.Add(this.stageBoxRight);
            this.Controls.Add(this.stageBoxLeft);
            this.Controls.Add(this.stageBoxup);
            this.Controls.Add(this.stageBox);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.stageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stageBoxup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stageBoxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stageBoxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stageBoxDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox stageBox;
        private System.Windows.Forms.PictureBox stageBoxup;
        private System.Windows.Forms.PictureBox stageBoxLeft;
        private System.Windows.Forms.PictureBox stageBoxRight;
        private System.Windows.Forms.PictureBox stageBoxDown;
        private System.Windows.Forms.PictureBox p1Box;
        private System.Windows.Forms.PictureBox p2Box;
        private System.Windows.Forms.Timer gravityTimer;
        private System.Windows.Forms.Timer jumpTimer1;
        private System.Windows.Forms.Timer jumpTimer2;
        private System.Windows.Forms.Timer stageCollisionTimer;
        private System.Windows.Forms.Timer LocationTimer;
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Timer gravityTimer2;
    }
}

