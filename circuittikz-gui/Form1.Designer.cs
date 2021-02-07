
namespace circuittikz_gui
{
    partial class CircuitTikzGUI
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
            this.TeXCode = new System.Windows.Forms.TextBox();
            this.Display = new System.Windows.Forms.PictureBox();
            this.DebugButton = new System.Windows.Forms.Button();
            this.precisionMode = new System.Windows.Forms.CheckBox();
            this.CopyToClip = new System.Windows.Forms.Button();
            this.ValueBox = new System.Windows.Forms.TextBox();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.UnitBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Display)).BeginInit();
            this.SuspendLayout();
            // 
            // TeXCode
            // 
            this.TeXCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeXCode.Location = new System.Drawing.Point(1518, 12);
            this.TeXCode.Multiline = true;
            this.TeXCode.Name = "TeXCode";
            this.TeXCode.ReadOnly = true;
            this.TeXCode.Size = new System.Drawing.Size(374, 800);
            this.TeXCode.TabIndex = 0;
            this.TeXCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeXCode_KeyPress);
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(12, 12);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(1500, 800);
            this.Display.TabIndex = 1;
            this.Display.TabStop = false;
            this.Display.Click += new System.EventHandler(this.circuitClick);
            this.Display.MouseHover += new System.EventHandler(this.circuitHover);
            // 
            // DebugButton
            // 
            this.DebugButton.Location = new System.Drawing.Point(1678, 987);
            this.DebugButton.Name = "DebugButton";
            this.DebugButton.Size = new System.Drawing.Size(199, 45);
            this.DebugButton.TabIndex = 2;
            this.DebugButton.Text = "DEBUG";
            this.DebugButton.UseVisualStyleBackColor = true;
            this.DebugButton.Click += new System.EventHandler(this.printDebug);
            // 
            // precisionMode
            // 
            this.precisionMode.AutoSize = true;
            this.precisionMode.Location = new System.Drawing.Point(1678, 914);
            this.precisionMode.Margin = new System.Windows.Forms.Padding(2);
            this.precisionMode.Name = "precisionMode";
            this.precisionMode.Size = new System.Drawing.Size(106, 21);
            this.precisionMode.TabIndex = 4;
            this.precisionMode.Text = "Precision Mode";
            this.precisionMode.UseVisualStyleBackColor = true;
            // 
            // CopyToClip
            // 
            this.CopyToClip.Location = new System.Drawing.Point(1678, 818);
            this.CopyToClip.Name = "CopyToClip";
            this.CopyToClip.Size = new System.Drawing.Size(199, 49);
            this.CopyToClip.TabIndex = 5;
            this.CopyToClip.Text = "Copy To Clipboard";
            this.CopyToClip.UseVisualStyleBackColor = true;
            this.CopyToClip.Click += new System.EventHandler(this.copyToClipboard);
            // 
            // ValueBox
            // 
            this.ValueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueBox.Location = new System.Drawing.Point(1142, 858);
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(180, 44);
            this.ValueBox.TabIndex = 6;
            // 
            // TypeBox
            // 
            this.TypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeBox.Location = new System.Drawing.Point(1019, 858);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(100, 44);
            this.TypeBox.TabIndex = 7;
            // 
            // UnitBox
            // 
            this.UnitBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitBox.Location = new System.Drawing.Point(1328, 858);
            this.UnitBox.Name = "UnitBox";
            this.UnitBox.Size = new System.Drawing.Size(174, 44);
            this.UnitBox.TabIndex = 8;
            // 
            // CircuitTikzGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.UnitBox);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.ValueBox);
            this.Controls.Add(this.CopyToClip);
            this.Controls.Add(this.precisionMode);
            this.Controls.Add(this.DebugButton);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.TeXCode);
            this.Name = "CircuitTikzGUI";
            this.Text = "CircuitTikz-GUI";
            ((System.ComponentModel.ISupportInitialize)(this.Display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TeXCode;
        private System.Windows.Forms.PictureBox Display;
        private System.Windows.Forms.Button DebugButton;
        private System.Windows.Forms.CheckBox precisionMode;
        private System.Windows.Forms.Button CopyToClip;
        private System.Windows.Forms.TextBox ValueBox;
        private System.Windows.Forms.TextBox TypeBox;
        private System.Windows.Forms.TextBox UnitBox;
    }
}

