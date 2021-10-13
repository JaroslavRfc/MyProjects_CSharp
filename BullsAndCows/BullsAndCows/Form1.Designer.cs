
namespace BullsAndCows
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
            this.inputtextBox = new System.Windows.Forms.TextBox();
            this.bullcountlabel = new System.Windows.Forms.Label();
            this.cowcountlabel = new System.Windows.Forms.Label();
            this.buttonroll = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StepColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BullColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CowColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // inputtextBox
            // 
            this.inputtextBox.Location = new System.Drawing.Point(1, 0);
            this.inputtextBox.Name = "inputtextBox";
            this.inputtextBox.Size = new System.Drawing.Size(181, 25);
            this.inputtextBox.TabIndex = 1;
            // 
            // bullcountlabel
            // 
            this.bullcountlabel.AutoSize = true;
            this.bullcountlabel.BackColor = System.Drawing.SystemColors.Window;
            this.bullcountlabel.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bullcountlabel.Location = new System.Drawing.Point(65, 358);
            this.bullcountlabel.Name = "bullcountlabel";
            this.bullcountlabel.Size = new System.Drawing.Size(99, 22);
            this.bullcountlabel.TabIndex = 2;
            this.bullcountlabel.Text = "Bulls = 0";
            // 
            // cowcountlabel
            // 
            this.cowcountlabel.AutoSize = true;
            this.cowcountlabel.BackColor = System.Drawing.SystemColors.Window;
            this.cowcountlabel.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cowcountlabel.Location = new System.Drawing.Point(702, 358);
            this.cowcountlabel.Name = "cowcountlabel";
            this.cowcountlabel.Size = new System.Drawing.Size(92, 22);
            this.cowcountlabel.TabIndex = 3;
            this.cowcountlabel.Text = "cows = 0";
            // 
            // buttonroll
            // 
            this.buttonroll.BackColor = System.Drawing.SystemColors.Window;
            this.buttonroll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonroll.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonroll.Location = new System.Drawing.Point(273, 0);
            this.buttonroll.Name = "buttonroll";
            this.buttonroll.Size = new System.Drawing.Size(115, 45);
            this.buttonroll.TabIndex = 4;
            this.buttonroll.Text = "ROLL";
            this.buttonroll.UseVisualStyleBackColor = false;
            this.buttonroll.Click += new System.EventHandler(this.buttonroll_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StepColumn,
            this.NumberColumn,
            this.BullColumn,
            this.CowColumn});
            this.dataGridView1.Location = new System.Drawing.Point(455, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(444, 115);
            this.dataGridView1.TabIndex = 5;
            // 
            // StepColumn
            // 
            this.StepColumn.HeaderText = "Step";
            this.StepColumn.Name = "StepColumn";
            this.StepColumn.ReadOnly = true;
            // 
            // NumberColumn
            // 
            this.NumberColumn.HeaderText = "Numbers";
            this.NumberColumn.Name = "NumberColumn";
            this.NumberColumn.ReadOnly = true;
            // 
            // BullColumn
            // 
            this.BullColumn.HeaderText = "Bulls";
            this.BullColumn.Name = "BullColumn";
            this.BullColumn.ReadOnly = true;
            // 
            // CowColumn
            // 
            this.CowColumn.HeaderText = "Cow";
            this.CowColumn.Name = "CowColumn";
            this.CowColumn.ReadOnly = true;
            // 
            // playbutton
            // 
            this.playbutton.BackColor = System.Drawing.SystemColors.Window;
            this.playbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playbutton.Location = new System.Drawing.Point(387, 336);
            this.playbutton.Name = "playbutton";
            this.playbutton.Size = new System.Drawing.Size(93, 44);
            this.playbutton.TabIndex = 6;
            this.playbutton.Text = "New Game";
            this.playbutton.UseVisualStyleBackColor = false;
            this.playbutton.Click += new System.EventHandler(this.playbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BullsAndCows.Properties.Resources.bulls_and_cows;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(899, 410);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonroll);
            this.Controls.Add(this.cowcountlabel);
            this.Controls.Add(this.bullcountlabel);
            this.Controls.Add(this.inputtextBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Stencil", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Bulls & Cows";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox inputtextBox;
        private System.Windows.Forms.Label bullcountlabel;
        private System.Windows.Forms.Label cowcountlabel;
        private System.Windows.Forms.Button buttonroll;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StepColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BullColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CowColumn;
        private System.Windows.Forms.Button playbutton;
        private System.Windows.Forms.Label label1;
    }
}

