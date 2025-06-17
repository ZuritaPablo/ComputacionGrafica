namespace Cohen_Sutherland
{
    partial class btnDraw
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
            this.gbxPicCanvas = new System.Windows.Forms.GroupBox();
            this.gbxImputs = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstPointY = new System.Windows.Forms.TextBox();
            this.txtEndPointX = new System.Windows.Forms.TextBox();
            this.txtEndPointY = new System.Windows.Forms.TextBox();
            this.txtFirstPointX = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbxPicCanvas.SuspendLayout();
            this.gbxImputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxPicCanvas
            // 
            this.gbxPicCanvas.BackColor = System.Drawing.SystemColors.Control;
            this.gbxPicCanvas.Controls.Add(this.picCanvas);
            this.gbxPicCanvas.Location = new System.Drawing.Point(367, 12);
            this.gbxPicCanvas.Name = "gbxPicCanvas";
            this.gbxPicCanvas.Size = new System.Drawing.Size(421, 426);
            this.gbxPicCanvas.TabIndex = 0;
            this.gbxPicCanvas.TabStop = false;
            this.gbxPicCanvas.Text = "Grafico";
            // 
            // gbxImputs
            // 
            this.gbxImputs.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxImputs.Controls.Add(this.button1);
            this.gbxImputs.Controls.Add(this.txtFirstPointX);
            this.gbxImputs.Controls.Add(this.txtEndPointY);
            this.gbxImputs.Controls.Add(this.txtEndPointX);
            this.gbxImputs.Controls.Add(this.txtFirstPointY);
            this.gbxImputs.Controls.Add(this.label2);
            this.gbxImputs.Controls.Add(this.label1);
            this.gbxImputs.Location = new System.Drawing.Point(12, 12);
            this.gbxImputs.Name = "gbxImputs";
            this.gbxImputs.Size = new System.Drawing.Size(342, 175);
            this.gbxImputs.TabIndex = 1;
            this.gbxImputs.TabStop = false;
            this.gbxImputs.Text = "Entrada";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(17, 25);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(390, 388);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Punto Inicial: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Punto Final: ";
            // 
            // txtFirstPointY
            // 
            this.txtFirstPointY.Location = new System.Drawing.Point(152, 34);
            this.txtFirstPointY.Name = "txtFirstPointY";
            this.txtFirstPointY.Size = new System.Drawing.Size(34, 20);
            this.txtFirstPointY.TabIndex = 3;
            this.txtFirstPointY.Text = "5";
            // 
            // txtEndPointX
            // 
            this.txtEndPointX.Location = new System.Drawing.Point(112, 62);
            this.txtEndPointX.Name = "txtEndPointX";
            this.txtEndPointX.Size = new System.Drawing.Size(34, 20);
            this.txtEndPointX.TabIndex = 4;
            this.txtEndPointX.Text = "4";
            // 
            // txtEndPointY
            // 
            this.txtEndPointY.Location = new System.Drawing.Point(152, 62);
            this.txtEndPointY.Name = "txtEndPointY";
            this.txtEndPointY.Size = new System.Drawing.Size(34, 20);
            this.txtEndPointY.TabIndex = 5;
            this.txtEndPointY.Text = "7";
            // 
            // txtFirstPointX
            // 
            this.txtFirstPointX.Location = new System.Drawing.Point(112, 34);
            this.txtFirstPointX.Name = "txtFirstPointX";
            this.txtFirstPointX.Size = new System.Drawing.Size(34, 20);
            this.txtFirstPointX.TabIndex = 4;
            this.txtFirstPointX.Text = "1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Dibujar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxImputs);
            this.Controls.Add(this.gbxPicCanvas);
            this.Name = "btnDraw";
            this.Text = "Form1";
            this.gbxPicCanvas.ResumeLayout(false);
            this.gbxImputs.ResumeLayout(false);
            this.gbxImputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPicCanvas;
        private System.Windows.Forms.GroupBox gbxImputs;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstPointX;
        private System.Windows.Forms.TextBox txtEndPointY;
        private System.Windows.Forms.TextBox txtEndPointX;
        private System.Windows.Forms.TextBox txtFirstPointY;
        private System.Windows.Forms.Button button1;
    }
}

