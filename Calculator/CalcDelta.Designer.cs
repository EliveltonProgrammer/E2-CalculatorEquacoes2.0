
namespace CalcDelta
{
    partial class FrmCalcDelta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalcDelta));
            this.TbxVlrA = new System.Windows.Forms.TextBox();
            this.TbxVlrB = new System.Windows.Forms.TextBox();
            this.TbxVlrC = new System.Windows.Forms.TextBox();
            this.TbxResultado = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnZerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbxVlrA
            // 
            this.TbxVlrA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TbxVlrA.Location = new System.Drawing.Point(59, 28);
            this.TbxVlrA.Name = "TbxVlrA";
            this.TbxVlrA.Size = new System.Drawing.Size(36, 20);
            this.TbxVlrA.TabIndex = 0;
            this.TbxVlrA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbxVlrB
            // 
            this.TbxVlrB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TbxVlrB.Location = new System.Drawing.Point(59, 54);
            this.TbxVlrB.Name = "TbxVlrB";
            this.TbxVlrB.Size = new System.Drawing.Size(36, 20);
            this.TbxVlrB.TabIndex = 1;
            this.TbxVlrB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbxVlrC
            // 
            this.TbxVlrC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TbxVlrC.Location = new System.Drawing.Point(59, 80);
            this.TbxVlrC.Name = "TbxVlrC";
            this.TbxVlrC.Size = new System.Drawing.Size(36, 20);
            this.TbxVlrC.TabIndex = 2;
            this.TbxVlrC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbxResultado
            // 
            this.TbxResultado.BackColor = System.Drawing.SystemColors.Window;
            this.TbxResultado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TbxResultado.Location = new System.Drawing.Point(215, 54);
            this.TbxResultado.Name = "TbxResultado";
            this.TbxResultado.ReadOnly = true;
            this.TbxResultado.Size = new System.Drawing.Size(40, 20);
            this.TbxResultado.TabIndex = 3;
            this.TbxResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(84, 141);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnZerar
            // 
            this.btnZerar.Location = new System.Drawing.Point(165, 141);
            this.btnZerar.Name = "btnZerar";
            this.btnZerar.Size = new System.Drawing.Size(75, 23);
            this.btnZerar.TabIndex = 5;
            this.btnZerar.Text = "Zerar";
            this.btnZerar.UseVisualStyleBackColor = true;
            this.btnZerar.Click += new System.EventHandler(this.btnZerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Valor A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Valor C:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor B:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor Delta:";
            // 
            // FrmCalcDelta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(329, 200);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZerar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.TbxResultado);
            this.Controls.Add(this.TbxVlrC);
            this.Controls.Add(this.TbxVlrB);
            this.Controls.Add(this.TbxVlrA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCalcDelta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator 1.0";
            this.Load += new System.EventHandler(this.FrmCalc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbxVlrA;
        private System.Windows.Forms.TextBox TbxVlrB;
        private System.Windows.Forms.TextBox TbxVlrC;
        private System.Windows.Forms.TextBox TbxResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnZerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

