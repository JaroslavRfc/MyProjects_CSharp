
namespace Clicker_2._0
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
            this.numberlabel = new System.Windows.Forms.Label();
            this.clickbutton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timelabel = new System.Windows.Forms.Label();
            this.restartbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Round = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resetbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // numberlabel
            // 
            this.numberlabel.AutoSize = true;
            this.numberlabel.Font = new System.Drawing.Font("Ink Free", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberlabel.Image = global::Clicker_2._0.Properties.Resources.depositphotos_29581221_stock_illustration_seamless_pattern_exercise_book_in;
            this.numberlabel.Location = new System.Drawing.Point(245, 33);
            this.numberlabel.Name = "numberlabel";
            this.numberlabel.Size = new System.Drawing.Size(173, 198);
            this.numberlabel.TabIndex = 0;
            this.numberlabel.Text = "0";
            // 
            // clickbutton
            // 
            this.clickbutton.BackgroundImage = global::Clicker_2._0.Properties.Resources.depositphotos_29581221_stock_illustration_seamless_pattern_exercise_book_in;
            this.clickbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clickbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clickbutton.Font = new System.Drawing.Font("Ink Free", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clickbutton.Location = new System.Drawing.Point(215, 267);
            this.clickbutton.Name = "clickbutton";
            this.clickbutton.Size = new System.Drawing.Size(276, 157);
            this.clickbutton.TabIndex = 1;
            this.clickbutton.Text = "Click";
            this.clickbutton.UseVisualStyleBackColor = true;
            this.clickbutton.Click += new System.EventHandler(this.clickbutton_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.Font = new System.Drawing.Font("Ink Free", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timelabel.Image = global::Clicker_2._0.Properties.Resources.depositphotos_29581221_stock_illustration_seamless_pattern_exercise_book_in;
            this.timelabel.Location = new System.Drawing.Point(143, 182);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(45, 49);
            this.timelabel.TabIndex = 2;
            this.timelabel.Text = "0";
            // 
            // restartbutton
            // 
            this.restartbutton.BackgroundImage = global::Clicker_2._0.Properties.Resources.depositphotos_29581221_stock_illustration_seamless_pattern_exercise_book_in;
            this.restartbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restartbutton.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.restartbutton.Location = new System.Drawing.Point(23, 24);
            this.restartbutton.Name = "restartbutton";
            this.restartbutton.Size = new System.Drawing.Size(122, 54);
            this.restartbutton.TabIndex = 3;
            this.restartbutton.Text = "Restart";
            this.restartbutton.UseVisualStyleBackColor = true;
            this.restartbutton.Click += new System.EventHandler(this.restartbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Round,
            this.Score});
            this.dataGridView1.Location = new System.Drawing.Point(530, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(240, 391);
            this.dataGridView1.TabIndex = 4;
            // 
            // Round
            // 
            this.Round.HeaderText = "Round";
            this.Round.Name = "Round";
            // 
            // Score
            // 
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            // 
            // resetbutton
            // 
            this.resetbutton.BackgroundImage = global::Clicker_2._0.Properties.Resources.depositphotos_29581221_stock_illustration_seamless_pattern_exercise_book_in;
            this.resetbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetbutton.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetbutton.Location = new System.Drawing.Point(23, 359);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(122, 56);
            this.resetbutton.TabIndex = 5;
            this.resetbutton.Text = "Reset";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Image = global::Clicker_2._0.Properties.Resources.depositphotos_29581221_stock_illustration_seamless_pattern_exercise_book_in;
            this.label1.Location = new System.Drawing.Point(12, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 49);
            this.label1.TabIndex = 6;
            this.label1.Text = "Timer:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Clicker_2._0.Properties.Resources.depositphotos_29581221_stock_illustration_seamless_pattern_exercise_book_in;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.restartbutton);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.clickbutton);
            this.Controls.Add(this.numberlabel);
            this.Name = "Form1";
            this.Text = "Clicker";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numberlabel;
        private System.Windows.Forms.Button clickbutton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Button restartbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Round;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.Label label1;
    }
}

