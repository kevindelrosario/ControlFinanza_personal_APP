
namespace finanzasApp
{
    partial class Resumen
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gridMovimientos = new System.Windows.Forms.DataGridView();
            this.lbBalanceTotal = new System.Windows.Forms.Label();
            this.lbTotalIngreso = new System.Windows.Forms.Label();
            this.lbTotalGasto = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btReiniciar = new System.Windows.Forms.Button();
            this.lbId = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbAhorro = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btAhorro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMovimientos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Grafico
            // 
            this.Grafico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.Grafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Grafico.Legends.Add(legend1);
            this.Grafico.Location = new System.Drawing.Point(788, 58);
            this.Grafico.Name = "Grafico";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Movimientos";
            this.Grafico.Series.Add(series1);
            this.Grafico.Size = new System.Drawing.Size(423, 260);
            this.Grafico.TabIndex = 0;
            this.Grafico.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(272, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(520, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gastos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(316, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingresos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(262, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Movimientos";
            // 
            // gridMovimientos
            // 
            this.gridMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMovimientos.Location = new System.Drawing.Point(265, 417);
            this.gridMovimientos.Name = "gridMovimientos";
            this.gridMovimientos.ReadOnly = true;
            this.gridMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMovimientos.Size = new System.Drawing.Size(728, 325);
            this.gridMovimientos.TabIndex = 5;
            this.gridMovimientos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMovimientos_CellClick);
            // 
            // lbBalanceTotal
            // 
            this.lbBalanceTotal.AutoSize = true;
            this.lbBalanceTotal.Font = new System.Drawing.Font("Segoe UI Emoji", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalanceTotal.Location = new System.Drawing.Point(371, 108);
            this.lbBalanceTotal.Name = "lbBalanceTotal";
            this.lbBalanceTotal.Size = new System.Drawing.Size(157, 85);
            this.lbBalanceTotal.TabIndex = 6;
            this.lbBalanceTotal.Text = "0.00";
            // 
            // lbTotalIngreso
            // 
            this.lbTotalIngreso.AutoSize = true;
            this.lbTotalIngreso.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalIngreso.Location = new System.Drawing.Point(314, 245);
            this.lbTotalIngreso.Name = "lbTotalIngreso";
            this.lbTotalIngreso.Size = new System.Drawing.Size(50, 26);
            this.lbTotalIngreso.TabIndex = 8;
            this.lbTotalIngreso.Text = "0.00";
            // 
            // lbTotalGasto
            // 
            this.lbTotalGasto.AutoSize = true;
            this.lbTotalGasto.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalGasto.Location = new System.Drawing.Point(518, 245);
            this.lbTotalGasto.Name = "lbTotalGasto";
            this.lbTotalGasto.Size = new System.Drawing.Size(50, 26);
            this.lbTotalGasto.TabIndex = 9;
            this.lbTotalGasto.Text = "0.00";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lbAhorro);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btReiniciar);
            this.panel2.Controls.Add(this.lbId);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.Grafico);
            this.panel2.Controls.Add(this.lbTotalGasto);
            this.panel2.Controls.Add(this.lbBalanceTotal);
            this.panel2.Controls.Add(this.lbTotalIngreso);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.gridMovimientos);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1321, 805);
            this.panel2.TabIndex = 14;
            // 
            // btReiniciar
            // 
            this.btReiniciar.BackColor = System.Drawing.Color.Crimson;
            this.btReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReiniciar.ForeColor = System.Drawing.Color.White;
            this.btReiniciar.Location = new System.Drawing.Point(999, 417);
            this.btReiniciar.Name = "btReiniciar";
            this.btReiniciar.Size = new System.Drawing.Size(73, 42);
            this.btReiniciar.TabIndex = 19;
            this.btReiniciar.Text = "Reiniciar \r\nValores";
            this.btReiniciar.UseVisualStyleBackColor = false;
            this.btReiniciar.Click += new System.EventHandler(this.btReiniciar_Click);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(262, 398);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(15, 16);
            this.lbId.TabIndex = 18;
            this.lbId.Text = "0";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(761, 748);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 27);
            this.button3.TabIndex = 17;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(654, 748);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 27);
            this.button2.TabIndex = 16;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btAhorro);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(86, 805);
            this.panel1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar Movimiento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prueba.Properties.Resources.icons8_billetera_96;
            this.pictureBox1.Location = new System.Drawing.Point(265, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 85);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::prueba.Properties.Resources.icons8_ingresos_48;
            this.pictureBox3.Location = new System.Drawing.Point(265, 223);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 51);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::prueba.Properties.Resources.icons8_gastos_48;
            this.pictureBox2.Location = new System.Drawing.Point(465, 223);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 51);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // lbAhorro
            // 
            this.lbAhorro.AutoSize = true;
            this.lbAhorro.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAhorro.Location = new System.Drawing.Point(674, 245);
            this.lbAhorro.Name = "lbAhorro";
            this.lbAhorro.Size = new System.Drawing.Size(50, 26);
            this.lbAhorro.TabIndex = 21;
            this.lbAhorro.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(676, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ahorros";
            // 
            // btAhorro
            // 
            this.btAhorro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btAhorro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btAhorro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btAhorro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAhorro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAhorro.ForeColor = System.Drawing.Color.Transparent;
            this.btAhorro.Location = new System.Drawing.Point(0, 45);
            this.btAhorro.Margin = new System.Windows.Forms.Padding(0);
            this.btAhorro.Name = "btAhorro";
            this.btAhorro.Size = new System.Drawing.Size(86, 45);
            this.btAhorro.TabIndex = 1;
            this.btAhorro.Text = "Agregar\r\nAhorro";
            this.btAhorro.UseVisualStyleBackColor = true;
            this.btAhorro.Click += new System.EventHandler(this.btAhorro_Click);
            // 
            // Resumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 799);
            this.Controls.Add(this.panel2);
            this.Name = "Resumen";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Grafico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMovimientos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Grafico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gridMovimientos;
        private System.Windows.Forms.Label lbBalanceTotal;
        private System.Windows.Forms.Label lbTotalIngreso;
        private System.Windows.Forms.Label lbTotalGasto;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Button btReiniciar;
        private System.Windows.Forms.Label lbAhorro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btAhorro;
    }
}

