namespace Buttons___Labels_TextBox
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
            this.btn_First = new System.Windows.Forms.Button();
            this.tbx_First = new System.Windows.Forms.TextBox();
            this.tbx_Second = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.lbl_First = new System.Windows.Forms.Label();
            this.lbl_Second = new System.Windows.Forms.Label();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_First
            // 
            this.btn_First.Location = new System.Drawing.Point(247, 163);
            this.btn_First.Name = "btn_First";
            this.btn_First.Size = new System.Drawing.Size(157, 72);
            this.btn_First.TabIndex = 0;
            this.btn_First.Text = "Add össze a két számot!";
            this.btn_First.UseVisualStyleBackColor = true;
            this.btn_First.Click += new System.EventHandler(this.btn_First_Click);
            // 
            // tbx_First
            // 
            this.tbx_First.Location = new System.Drawing.Point(106, 40);
            this.tbx_First.Name = "tbx_First";
            this.tbx_First.Size = new System.Drawing.Size(100, 20);
            this.tbx_First.TabIndex = 1;
            // 
            // tbx_Second
            // 
            this.tbx_Second.Location = new System.Drawing.Point(304, 40);
            this.tbx_Second.Name = "tbx_Second";
            this.tbx_Second.Size = new System.Drawing.Size(100, 20);
            this.tbx_Second.TabIndex = 2;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(560, 67);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(100, 20);
            this.Result.TabIndex = 3;
            // 
            // lbl_First
            // 
            this.lbl_First.AutoSize = true;
            this.lbl_First.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_First.Location = new System.Drawing.Point(101, 79);
            this.lbl_First.Name = "lbl_First";
            this.lbl_First.Size = new System.Drawing.Size(111, 25);
            this.lbl_First.TabIndex = 4;
            this.lbl_First.Text = "Első szám";
            // 
            // lbl_Second
            // 
            this.lbl_Second.AutoSize = true;
            this.lbl_Second.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Second.Location = new System.Drawing.Point(276, 79);
            this.lbl_Second.Name = "lbl_Second";
            this.lbl_Second.Size = new System.Drawing.Size(150, 25);
            this.lbl_Second.TabIndex = 5;
            this.lbl_Second.Text = "Második szám";
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Result.Location = new System.Drawing.Point(432, 61);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(115, 25);
            this.lbl_Result.TabIndex = 6;
            this.lbl_Result.Text = "Eredmény:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(672, 272);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.lbl_Second);
            this.Controls.Add(this.lbl_First);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.tbx_Second);
            this.Controls.Add(this.tbx_First);
            this.Controls.Add(this.btn_First);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_First;
        private System.Windows.Forms.TextBox tbx_First;
        private System.Windows.Forms.TextBox tbx_Second;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label lbl_First;
        private System.Windows.Forms.Label lbl_Second;
        private System.Windows.Forms.Label lbl_Result;
    }
}

