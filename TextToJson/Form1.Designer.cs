namespace TextToJson
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
            this.tb_output = new System.Windows.Forms.TextBox();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_to_array = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_output
            // 
            this.tb_output.Location = new System.Drawing.Point(637, 31);
            this.tb_output.MaxLength = 3276700;
            this.tb_output.Multiline = true;
            this.tb_output.Name = "tb_output";
            this.tb_output.ReadOnly = true;
            this.tb_output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_output.Size = new System.Drawing.Size(484, 430);
            this.tb_output.TabIndex = 2;
            // 
            // tb_input
            // 
            this.tb_input.Location = new System.Drawing.Point(12, 31);
            this.tb_input.MaxLength = 3276700;
            this.tb_input.Multiline = true;
            this.tb_input.Name = "tb_input";
            this.tb_input.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_input.Size = new System.Drawing.Size(484, 430);
            this.tb_input.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(635, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output:";
            // 
            // btn_to_array
            // 
            this.btn_to_array.Location = new System.Drawing.Point(530, 236);
            this.btn_to_array.Name = "btn_to_array";
            this.btn_to_array.Size = new System.Drawing.Size(75, 23);
            this.btn_to_array.TabIndex = 6;
            this.btn_to_array.Text = "To Array >";
            this.btn_to_array.UseVisualStyleBackColor = true;
            this.btn_to_array.Click += new System.EventHandler(this.btn_to_array_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "json";
            this.saveFileDialog1.FileName = "output";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(1003, 471);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(118, 27);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 510);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_to_array);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_input);
            this.Controls.Add(this.tb_output);
            this.Name = "Form1";
            this.Text = "TextToJson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_to_array;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_save;
    }
}

