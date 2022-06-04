
namespace CalcEquacao
{
    partial class FrmCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalc));
            this.TbxVlrA = new System.Windows.Forms.TextBox();
            this.TbxVlrB = new System.Windows.Forms.TextBox();
            this.TbxVlrC = new System.Windows.Forms.TextBox();
            this.TbxVlrDelta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbinfRaiz = new System.Windows.Forms.Label();
            this.lbinfEquac = new System.Windows.Forms.Label();
            this.cbxTpEquac = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TbxVlrX2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbxVlrX1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TbxPtoMaxY = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TbxPtoMaxX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TbxPtoMinY = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TbxPtoMinX = new System.Windows.Forms.TextBox();
            this.groupInfRaiz = new System.Windows.Forms.GroupBox();
            this.lbStatusInf = new System.Windows.Forms.Label();
            this.lbinfCoordVertice = new System.Windows.Forms.Label();
            this.lbInfPtoVertice = new System.Windows.Forms.Label();
            this.lbinfParab = new System.Windows.Forms.Label();
            this.groupInfEquac = new System.Windows.Forms.GroupBox();
            this.lbStatusEquac = new System.Windows.Forms.Label();
            this.toolTipInicio = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnImprFormula = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnZerar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panelAutExport = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.LbData = new System.Windows.Forms.Label();
            this.LbHorario = new System.Windows.Forms.Label();
            this.timerInicio = new System.Windows.Forms.Timer(this.components);
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.PrintDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupInfRaiz.SuspendLayout();
            this.groupInfEquac.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panelAutExport.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbxVlrA
            // 
            this.TbxVlrA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxVlrA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TbxVlrA.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.TbxVlrA.ForeColor = System.Drawing.Color.Blue;
            this.TbxVlrA.Location = new System.Drawing.Point(21, 37);
            this.TbxVlrA.Name = "TbxVlrA";
            this.TbxVlrA.Size = new System.Drawing.Size(36, 23);
            this.TbxVlrA.TabIndex = 1;
            this.TbxVlrA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbxVlrA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxVlrA_KeyPress);
            // 
            // TbxVlrB
            // 
            this.TbxVlrB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxVlrB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TbxVlrB.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.TbxVlrB.ForeColor = System.Drawing.Color.Blue;
            this.TbxVlrB.Location = new System.Drawing.Point(63, 37);
            this.TbxVlrB.Name = "TbxVlrB";
            this.TbxVlrB.Size = new System.Drawing.Size(36, 23);
            this.TbxVlrB.TabIndex = 2;
            this.TbxVlrB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbxVlrB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxVlrB_KeyPress);
            // 
            // TbxVlrC
            // 
            this.TbxVlrC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxVlrC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TbxVlrC.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.TbxVlrC.ForeColor = System.Drawing.Color.Blue;
            this.TbxVlrC.Location = new System.Drawing.Point(105, 37);
            this.TbxVlrC.Name = "TbxVlrC";
            this.TbxVlrC.Size = new System.Drawing.Size(36, 23);
            this.TbxVlrC.TabIndex = 3;
            this.TbxVlrC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbxVlrC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxVlrC_KeyPress);
            // 
            // TbxVlrDelta
            // 
            this.TbxVlrDelta.BackColor = System.Drawing.SystemColors.Window;
            this.TbxVlrDelta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxVlrDelta.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.TbxVlrDelta.ForeColor = System.Drawing.Color.Blue;
            this.TbxVlrDelta.Location = new System.Drawing.Point(7, 65);
            this.TbxVlrDelta.Name = "TbxVlrDelta";
            this.TbxVlrDelta.ReadOnly = true;
            this.TbxVlrDelta.Size = new System.Drawing.Size(64, 23);
            this.TbxVlrDelta.TabIndex = 3;
            this.TbxVlrDelta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(114, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "C:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(72, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "B:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(16, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Delta:";
            // 
            // lbinfRaiz
            // 
            this.lbinfRaiz.AutoSize = true;
            this.lbinfRaiz.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbinfRaiz.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbinfRaiz.Location = new System.Drawing.Point(2, 25);
            this.lbinfRaiz.Name = "lbinfRaiz";
            this.lbinfRaiz.Size = new System.Drawing.Size(52, 16);
            this.lbinfRaiz.TabIndex = 10;
            this.lbinfRaiz.Text = "&&infRaiz";
            // 
            // lbinfEquac
            // 
            this.lbinfEquac.AutoSize = true;
            this.lbinfEquac.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbinfEquac.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbinfEquac.Location = new System.Drawing.Point(43, 22);
            this.lbinfEquac.Name = "lbinfEquac";
            this.lbinfEquac.Size = new System.Drawing.Size(81, 22);
            this.lbinfEquac.TabIndex = 11;
            this.lbinfEquac.Text = "&&infEquac";
            // 
            // cbxTpEquac
            // 
            this.cbxTpEquac.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTpEquac.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbxTpEquac.FormattingEnabled = true;
            this.cbxTpEquac.Items.AddRange(new object[] {
            "Equação do 1º Grau",
            "Equação do 2º Grau"});
            this.cbxTpEquac.Location = new System.Drawing.Point(26, 26);
            this.cbxTpEquac.MaxDropDownItems = 2;
            this.cbxTpEquac.Name = "cbxTpEquac";
            this.cbxTpEquac.Size = new System.Drawing.Size(126, 22);
            this.cbxTpEquac.TabIndex = 1;
            this.toolTipInicio.SetToolTip(this.cbxTpEquac, "Determine o Tipo de sua Equação");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TbxVlrA);
            this.groupBox1.Controls.Add(this.TbxVlrB);
            this.groupBox1.Controls.Add(this.TbxVlrC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 66);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coeficientes da Equação";
            this.toolTipInicio.SetToolTip(this.groupBox1, "Determine os Valores de sua Equação do 2º Grau");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TbxVlrX2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TbxVlrX1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TbxVlrDelta);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(12, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 127);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valores das Raízes";
            this.toolTipInicio.SetToolTip(this.groupBox2, "Resultados calculados de sua Equação");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(120, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "x ||:";
            // 
            // TbxVlrX2
            // 
            this.TbxVlrX2.BackColor = System.Drawing.SystemColors.Window;
            this.TbxVlrX2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxVlrX2.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.TbxVlrX2.ForeColor = System.Drawing.Color.Blue;
            this.TbxVlrX2.Location = new System.Drawing.Point(99, 88);
            this.TbxVlrX2.Name = "TbxVlrX2";
            this.TbxVlrX2.ReadOnly = true;
            this.TbxVlrX2.Size = new System.Drawing.Size(64, 23);
            this.TbxVlrX2.TabIndex = 12;
            this.TbxVlrX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(120, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "x |:";
            // 
            // TbxVlrX1
            // 
            this.TbxVlrX1.BackColor = System.Drawing.SystemColors.Window;
            this.TbxVlrX1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxVlrX1.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.TbxVlrX1.ForeColor = System.Drawing.Color.Blue;
            this.TbxVlrX1.Location = new System.Drawing.Point(100, 40);
            this.TbxVlrX1.Name = "TbxVlrX1";
            this.TbxVlrX1.ReadOnly = true;
            this.TbxVlrX1.Size = new System.Drawing.Size(64, 23);
            this.TbxVlrX1.TabIndex = 10;
            this.TbxVlrX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label10.Location = new System.Drawing.Point(52, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Vértice Máxímo";
            // 
            // TbxPtoMaxY
            // 
            this.TbxPtoMaxY.BackColor = System.Drawing.SystemColors.Window;
            this.TbxPtoMaxY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxPtoMaxY.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.TbxPtoMaxY.ForeColor = System.Drawing.Color.Blue;
            this.TbxPtoMaxY.Location = new System.Drawing.Point(65, 196);
            this.TbxPtoMaxY.Name = "TbxPtoMaxY";
            this.TbxPtoMaxY.ReadOnly = true;
            this.TbxPtoMaxY.Size = new System.Drawing.Size(64, 23);
            this.TbxPtoMaxY.TabIndex = 20;
            this.TbxPtoMaxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label11.Location = new System.Drawing.Point(52, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Vértice Máxímo";
            // 
            // TbxPtoMaxX
            // 
            this.TbxPtoMaxX.BackColor = System.Drawing.SystemColors.Window;
            this.TbxPtoMaxX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxPtoMaxX.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.TbxPtoMaxX.ForeColor = System.Drawing.Color.Blue;
            this.TbxPtoMaxX.Location = new System.Drawing.Point(65, 149);
            this.TbxPtoMaxX.Name = "TbxPtoMaxX";
            this.TbxPtoMaxX.ReadOnly = true;
            this.TbxPtoMaxX.Size = new System.Drawing.Size(64, 23);
            this.TbxPtoMaxX.TabIndex = 18;
            this.TbxPtoMaxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(52, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Vértice Minímo";
            // 
            // TbxPtoMinY
            // 
            this.TbxPtoMinY.BackColor = System.Drawing.SystemColors.Window;
            this.TbxPtoMinY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxPtoMinY.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.TbxPtoMinY.ForeColor = System.Drawing.Color.Blue;
            this.TbxPtoMinY.Location = new System.Drawing.Point(65, 92);
            this.TbxPtoMinY.Name = "TbxPtoMinY";
            this.TbxPtoMinY.ReadOnly = true;
            this.TbxPtoMinY.Size = new System.Drawing.Size(64, 23);
            this.TbxPtoMinY.TabIndex = 16;
            this.TbxPtoMinY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Location = new System.Drawing.Point(52, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Vértice Minímo";
            // 
            // TbxPtoMinX
            // 
            this.TbxPtoMinX.BackColor = System.Drawing.SystemColors.Window;
            this.TbxPtoMinX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxPtoMinX.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.TbxPtoMinX.ForeColor = System.Drawing.Color.Blue;
            this.TbxPtoMinX.Location = new System.Drawing.Point(65, 44);
            this.TbxPtoMinX.Name = "TbxPtoMinX";
            this.TbxPtoMinX.ReadOnly = true;
            this.TbxPtoMinX.Size = new System.Drawing.Size(64, 23);
            this.TbxPtoMinX.TabIndex = 14;
            this.TbxPtoMinX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupInfRaiz
            // 
            this.groupInfRaiz.Controls.Add(this.lbStatusInf);
            this.groupInfRaiz.Controls.Add(this.lbinfCoordVertice);
            this.groupInfRaiz.Controls.Add(this.lbInfPtoVertice);
            this.groupInfRaiz.Controls.Add(this.lbinfParab);
            this.groupInfRaiz.Controls.Add(this.lbinfRaiz);
            this.groupInfRaiz.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.groupInfRaiz.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupInfRaiz.Location = new System.Drawing.Point(214, 133);
            this.groupInfRaiz.Name = "groupInfRaiz";
            this.groupInfRaiz.Size = new System.Drawing.Size(268, 127);
            this.groupInfRaiz.TabIndex = 15;
            this.groupInfRaiz.TabStop = false;
            this.groupInfRaiz.Text = "Informações Equacionárias";
            this.toolTipInicio.SetToolTip(this.groupInfRaiz, "Informativo de suas Raízes");
            // 
            // lbStatusInf
            // 
            this.lbStatusInf.AutoSize = true;
            this.lbStatusInf.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatusInf.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbStatusInf.Location = new System.Drawing.Point(47, 57);
            this.lbStatusInf.Name = "lbStatusInf";
            this.lbStatusInf.Size = new System.Drawing.Size(54, 16);
            this.lbStatusInf.TabIndex = 13;
            this.lbStatusInf.Text = "&&StatusInf";
            // 
            // lbinfCoordVertice
            // 
            this.lbinfCoordVertice.AutoSize = true;
            this.lbinfCoordVertice.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbinfCoordVertice.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbinfCoordVertice.Location = new System.Drawing.Point(2, 85);
            this.lbinfCoordVertice.Name = "lbinfCoordVertice";
            this.lbinfCoordVertice.Size = new System.Drawing.Size(99, 16);
            this.lbinfCoordVertice.TabIndex = 13;
            this.lbinfCoordVertice.Text = "&&infCoordVertice";
            // 
            // lbInfPtoVertice
            // 
            this.lbInfPtoVertice.AutoSize = true;
            this.lbInfPtoVertice.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfPtoVertice.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbInfPtoVertice.Location = new System.Drawing.Point(2, 65);
            this.lbInfPtoVertice.Name = "lbInfPtoVertice";
            this.lbInfPtoVertice.Size = new System.Drawing.Size(84, 16);
            this.lbInfPtoVertice.TabIndex = 12;
            this.lbInfPtoVertice.Text = "&&infPtoVertice";
            // 
            // lbinfParab
            // 
            this.lbinfParab.AutoSize = true;
            this.lbinfParab.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbinfParab.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbinfParab.Location = new System.Drawing.Point(2, 45);
            this.lbinfParab.Name = "lbinfParab";
            this.lbinfParab.Size = new System.Drawing.Size(60, 16);
            this.lbinfParab.TabIndex = 11;
            this.lbinfParab.Text = "&&infParab";
            // 
            // groupInfEquac
            // 
            this.groupInfEquac.Controls.Add(this.lbStatusEquac);
            this.groupInfEquac.Controls.Add(this.lbinfEquac);
            this.groupInfEquac.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.groupInfEquac.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupInfEquac.Location = new System.Drawing.Point(255, 281);
            this.groupInfEquac.Name = "groupInfEquac";
            this.groupInfEquac.Size = new System.Drawing.Size(196, 53);
            this.groupInfEquac.TabIndex = 16;
            this.groupInfEquac.TabStop = false;
            this.groupInfEquac.Text = "Equação";
            this.toolTipInicio.SetToolTip(this.groupInfEquac, "Informativo de sua Equação");
            // 
            // lbStatusEquac
            // 
            this.lbStatusEquac.AutoSize = true;
            this.lbStatusEquac.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatusEquac.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbStatusEquac.Location = new System.Drawing.Point(8, 25);
            this.lbStatusEquac.Name = "lbStatusEquac";
            this.lbStatusEquac.Size = new System.Drawing.Size(73, 16);
            this.lbStatusEquac.TabIndex = 12;
            this.lbStatusEquac.Text = "&&StatusEquac";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.TbxPtoMaxY);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.TbxPtoMinX);
            this.groupBox3.Controls.Add(this.TbxPtoMaxX);
            this.groupBox3.Controls.Add(this.TbxPtoMinY);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(12, 268);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(209, 229);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pontos de Coordenadas Vértice";
            this.toolTipInicio.SetToolTip(this.groupBox3, "Resultados calculados de sua Equação");
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label15.Location = new System.Drawing.Point(33, 197);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 15);
            this.label15.TabIndex = 25;
            this.label15.Text = "(y):";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label14.Location = new System.Drawing.Point(33, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 15);
            this.label14.TabIndex = 24;
            this.label14.Text = "(y):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label13.Location = new System.Drawing.Point(33, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 15);
            this.label13.TabIndex = 23;
            this.label13.Text = "(x):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label12.Location = new System.Drawing.Point(33, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "(x):";
            // 
            // btnImprFormula
            // 
            this.btnImprFormula.BackgroundImage = global::Calculator.Properties.Resources.Formula;
            this.btnImprFormula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImprFormula.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprFormula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprFormula.Location = new System.Drawing.Point(301, 423);
            this.btnImprFormula.Name = "btnImprFormula";
            this.btnImprFormula.Size = new System.Drawing.Size(48, 48);
            this.btnImprFormula.TabIndex = 3;
            this.btnImprFormula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipInicio.SetToolTip(this.btnImprFormula, "Imprimir a Formula Explicativa");
            this.btnImprFormula.UseVisualStyleBackColor = true;
            this.btnImprFormula.Click += new System.EventHandler(this.btnImprFormula_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(441, 8);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(16, 16);
            this.btnMinimizar.TabIndex = 85;
            this.toolTipInicio.SetToolTip(this.btnMinimizar, "Minimizar");
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(468, 10);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(12, 12);
            this.btnFechar.TabIndex = 86;
            this.toolTipInicio.SetToolTip(this.btnFechar, "Sair");
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::Calculator.Properties.Resources.Sair;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(409, 423);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(48, 48);
            this.btnSair.TabIndex = 5;
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipInicio.SetToolTip(this.btnSair, "Sair");
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnZerar
            // 
            this.btnZerar.BackgroundImage = global::Calculator.Properties.Resources.Zerar;
            this.btnZerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnZerar.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnZerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZerar.Location = new System.Drawing.Point(355, 423);
            this.btnZerar.Name = "btnZerar";
            this.btnZerar.Size = new System.Drawing.Size(48, 48);
            this.btnZerar.TabIndex = 4;
            this.btnZerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipInicio.SetToolTip(this.btnZerar, "Zerar valores");
            this.btnZerar.UseVisualStyleBackColor = true;
            this.btnZerar.Click += new System.EventHandler(this.btnZerar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackgroundImage = global::Calculator.Properties.Resources.Calcular;
            this.btnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(247, 423);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(48, 48);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipInicio.SetToolTip(this.btnCalcular, "Calcular Equação");
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbxTpEquac);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox5.Location = new System.Drawing.Point(289, 50);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(168, 60);
            this.groupBox5.TabIndex = 99;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Formato da Equação";
            // 
            // panelAutExport
            // 
            this.panelAutExport.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelAutExport.Controls.Add(this.btnMinimizar);
            this.panelAutExport.Controls.Add(this.label9);
            this.panelAutExport.Controls.Add(this.btnFechar);
            this.panelAutExport.Controls.Add(this.Data);
            this.panelAutExport.Controls.Add(this.LbData);
            this.panelAutExport.Controls.Add(this.LbHorario);
            this.panelAutExport.Location = new System.Drawing.Point(-1, 0);
            this.panelAutExport.Name = "panelAutExport";
            this.panelAutExport.Size = new System.Drawing.Size(490, 34);
            this.panelAutExport.TabIndex = 85;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 6.75F);
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(9, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 12);
            this.label9.TabIndex = 42;
            this.label9.Text = "Horário:";
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Font = new System.Drawing.Font("Arial", 6.75F);
            this.Data.ForeColor = System.Drawing.SystemColors.Window;
            this.Data.Location = new System.Drawing.Point(9, 5);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(28, 12);
            this.Data.TabIndex = 40;
            this.Data.Text = "Data:";
            // 
            // LbData
            // 
            this.LbData.AutoSize = true;
            this.LbData.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbData.ForeColor = System.Drawing.SystemColors.Window;
            this.LbData.Location = new System.Drawing.Point(34, 4);
            this.LbData.Name = "LbData";
            this.LbData.Size = new System.Drawing.Size(38, 14);
            this.LbData.TabIndex = 41;
            this.LbData.Text = "&&Data";
            // 
            // LbHorario
            // 
            this.LbHorario.AutoSize = true;
            this.LbHorario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHorario.ForeColor = System.Drawing.SystemColors.Window;
            this.LbHorario.Location = new System.Drawing.Point(44, 17);
            this.LbHorario.Name = "LbHorario";
            this.LbHorario.Size = new System.Drawing.Size(55, 14);
            this.LbHorario.TabIndex = 39;
            this.LbHorario.Text = "&&Horario";
            // 
            // timerInicio
            // 
            this.timerInicio.Enabled = true;
            this.timerInicio.Interval = 1000;
            this.timerInicio.Tick += new System.EventHandler(this.timerInicio_Tick);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.PrintDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // FrmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(488, 509);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnImprFormula);
            this.Controls.Add(this.panelAutExport);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupInfEquac);
            this.Controls.Add(this.groupInfRaiz);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnZerar);
            this.Controls.Add(this.btnCalcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E2 Calculator Equação";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupInfRaiz.ResumeLayout(false);
            this.groupInfRaiz.PerformLayout();
            this.groupInfEquac.ResumeLayout(false);
            this.groupInfEquac.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.panelAutExport.ResumeLayout(false);
            this.panelAutExport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TbxVlrA;
        private System.Windows.Forms.TextBox TbxVlrB;
        private System.Windows.Forms.TextBox TbxVlrC;
        private System.Windows.Forms.TextBox TbxVlrDelta;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnZerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbinfRaiz;
        private System.Windows.Forms.Label lbinfEquac;
        private System.Windows.Forms.ComboBox cbxTpEquac;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupInfRaiz;
        private System.Windows.Forms.GroupBox groupInfEquac;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbxVlrX2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbxVlrX1;
        private System.Windows.Forms.ToolTip toolTipInicio;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbxPtoMinY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TbxPtoMinX;
        private System.Windows.Forms.Label lbinfParab;
        private System.Windows.Forms.Label lbInfPtoVertice;
        private System.Windows.Forms.Panel panelAutExport;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.Label LbData;
        private System.Windows.Forms.Label LbHorario;
        private System.Windows.Forms.Timer timerInicio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TbxPtoMaxY;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TbxPtoMaxX;
        private System.Windows.Forms.Label lbinfCoordVertice;
        private System.Windows.Forms.Button btnImprFormula;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbStatusInf;
        private System.Windows.Forms.Label lbStatusEquac;
        public System.Drawing.Printing.PrintDocument PrintDocument;
        public System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        public System.Windows.Forms.PrintDialog printDialog;
    }
}

