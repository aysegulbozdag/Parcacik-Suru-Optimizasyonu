namespace Parcacik_Suru_Optimizasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtIteration = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtC2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtC1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSırala = new System.Windows.Forms.Button();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLow = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(603, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(328, 295);
            this.dataGridView1.TabIndex = 34;
            // 
            // txtIteration
            // 
            this.txtIteration.Location = new System.Drawing.Point(815, 376);
            this.txtIteration.Name = "txtIteration";
            this.txtIteration.Size = new System.Drawing.Size(116, 20);
            this.txtIteration.TabIndex = 33;
            this.txtIteration.Text = "50";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(741, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Jenerasyon:";
            // 
            // txtC2
            // 
            this.txtC2.Location = new System.Drawing.Point(619, 409);
            this.txtC2.Name = "txtC2";
            this.txtC2.Size = new System.Drawing.Size(116, 20);
            this.txtC2.TabIndex = 31;
            this.txtC2.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(451, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "pbest için Öğr. Fakt. (c2) : ";
            // 
            // txtC1
            // 
            this.txtC1.Location = new System.Drawing.Point(619, 378);
            this.txtC1.Name = "txtC1";
            this.txtC1.Size = new System.Drawing.Size(116, 20);
            this.txtC1.TabIndex = 29;
            this.txtC1.Text = "2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(451, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "gbest için Öğr. Fakt. (c1) :";
            // 
            // btnSırala
            // 
            this.btnSırala.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSırala.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSırala.Location = new System.Drawing.Point(12, 440);
            this.btnSırala.Name = "btnSırala";
            this.btnSırala.Size = new System.Drawing.Size(919, 32);
            this.btnSırala.TabIndex = 27;
            this.btnSırala.Text = "Sırala";
            this.btnSırala.UseVisualStyleBackColor = false;
            this.btnSırala.Click += new System.EventHandler(this.btnSırala_Click);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(329, 413);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(116, 20);
            this.txtSize.TabIndex = 26;
            this.txtSize.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(200, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Sürünün Büyüklüğü :";
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(329, 377);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(116, 20);
            this.txtD.TabIndex = 24;
            this.txtD.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(223, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Sürünün Boyutu :";
            // 
            // txtTop
            // 
            this.txtTop.Location = new System.Drawing.Point(81, 408);
            this.txtTop.Name = "txtTop";
            this.txtTop.Size = new System.Drawing.Size(116, 20);
            this.txtTop.TabIndex = 22;
            this.txtTop.Text = "5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Üst Sınır :";
            // 
            // txtLow
            // 
            this.txtLow.Location = new System.Drawing.Point(81, 378);
            this.txtLow.Name = "txtLow";
            this.txtLow.Size = new System.Drawing.Size(116, 20);
            this.txtLow.TabIndex = 20;
            this.txtLow.Text = "-5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Alt Sınır :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Six-Hump Camel Text Fonksiyonu ile PSO ";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 50);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "gbest değerleri";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(583, 295);
            this.chart1.TabIndex = 35;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 483);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtIteration);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtC2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtC1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSırala);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtIteration;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtC2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtC1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSırala;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

