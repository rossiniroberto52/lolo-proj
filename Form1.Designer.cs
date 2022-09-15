namespace project_lolo_v2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Temp = new System.Windows.Forms.TextBox();
            this.tb_vel = new System.Windows.Forms.TextBox();
            this.tb_s0 = new System.Windows.Forms.TextBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.rb_MT = new System.Windows.Forms.RadioButton();
            this.pb_Trajeto = new System.Windows.Forms.ProgressBar();
            this.lb_init = new System.Windows.Forms.Label();
            this.lb_final = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "calc: S = s0 + v * t";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resultado: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "s0 = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "V = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "T = ";
            // 
            // tb_Temp
            // 
            this.tb_Temp.Location = new System.Drawing.Point(52, 159);
            this.tb_Temp.Name = "tb_Temp";
            this.tb_Temp.Size = new System.Drawing.Size(100, 20);
            this.tb_Temp.TabIndex = 5;
            // 
            // tb_vel
            // 
            this.tb_vel.Location = new System.Drawing.Point(52, 132);
            this.tb_vel.Name = "tb_vel";
            this.tb_vel.Size = new System.Drawing.Size(100, 20);
            this.tb_vel.TabIndex = 6;
            // 
            // tb_s0
            // 
            this.tb_s0.Location = new System.Drawing.Point(52, 105);
            this.tb_s0.Name = "tb_s0";
            this.tb_s0.Size = new System.Drawing.Size(100, 20);
            this.tb_s0.TabIndex = 7;
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(30, 225);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(122, 43);
            this.btn_calc.TabIndex = 8;
            this.btn_calc.Text = "calcular";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // rb_MT
            // 
            this.rb_MT.AutoSize = true;
            this.rb_MT.Location = new System.Drawing.Point(187, 105);
            this.rb_MT.Name = "rb_MT";
            this.rb_MT.Size = new System.Drawing.Size(103, 17);
            this.rb_MT.TabIndex = 9;
            this.rb_MT.TabStop = true;
            this.rb_MT.Text = "Mostrar trajetoria";
            this.rb_MT.UseVisualStyleBackColor = true;
            // 
            // pb_Trajeto
            // 
            this.pb_Trajeto.Location = new System.Drawing.Point(367, 101);
            this.pb_Trajeto.Name = "pb_Trajeto";
            this.pb_Trajeto.Size = new System.Drawing.Size(355, 23);
            this.pb_Trajeto.TabIndex = 10;
            // 
            // lb_init
            // 
            this.lb_init.AutoSize = true;
            this.lb_init.Location = new System.Drawing.Point(367, 131);
            this.lb_init.Name = "lb_init";
            this.lb_init.Size = new System.Drawing.Size(0, 13);
            this.lb_init.TabIndex = 11;
            // 
            // lb_final
            // 
            this.lb_final.AutoSize = true;
            this.lb_final.Location = new System.Drawing.Point(691, 138);
            this.lb_final.Name = "lb_final";
            this.lb_final.Size = new System.Drawing.Size(0, 13);
            this.lb_final.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_final);
            this.Controls.Add(this.lb_init);
            this.Controls.Add(this.pb_Trajeto);
            this.Controls.Add(this.rb_MT);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.tb_s0);
            this.Controls.Add(this.tb_vel);
            this.Controls.Add(this.tb_Temp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "project lorena - by rossini135";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Temp;
        private System.Windows.Forms.TextBox tb_vel;
        private System.Windows.Forms.TextBox tb_s0;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.RadioButton rb_MT;
        private System.Windows.Forms.ProgressBar pb_Trajeto;
        private System.Windows.Forms.Label lb_init;
        private System.Windows.Forms.Label lb_final;
    }
}

