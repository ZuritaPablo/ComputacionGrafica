namespace Algoritmos
{
    partial class Form1
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
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.txtStarPointX = new System.Windows.Forms.TextBox();
            this.txtFinishPointX = new System.Windows.Forms.TextBox();
            this.lblStarPoint = new System.Windows.Forms.Label();
            this.lblFinishPoint = new System.Windows.Forms.Label();
            this.txtStarPointY = new System.Windows.Forms.TextBox();
            this.txtFinishPointY = new System.Windows.Forms.TextBox();
            this.cbxAlgotithms = new System.Windows.Forms.ComboBox();
            this.gbxImputs = new System.Windows.Forms.GroupBox();
            this.gbxbutton = new System.Windows.Forms.GroupBox();
            this.gbxPicCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.gbxImputs.SuspendLayout();
            this.gbxbutton.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxPicCanvas
            // 
            this.gbxPicCanvas.Controls.Add(this.picCanvas);
            this.gbxPicCanvas.Location = new System.Drawing.Point(306, 9);
            this.gbxPicCanvas.Name = "gbxPicCanvas";
            this.gbxPicCanvas.Size = new System.Drawing.Size(475, 428);
            this.gbxPicCanvas.TabIndex = 0;
            this.gbxPicCanvas.TabStop = false;
            this.gbxPicCanvas.Text = "Gráfico";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(12, 18);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(451, 397);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(15, 28);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(93, 24);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Dibujar";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // txtStarPointX
            // 
            this.txtStarPointX.Location = new System.Drawing.Point(90, 31);
            this.txtStarPointX.Name = "txtStarPointX";
            this.txtStarPointX.Size = new System.Drawing.Size(35, 20);
            this.txtStarPointX.TabIndex = 2;
            // 
            // txtFinishPointX
            // 
            this.txtFinishPointX.Location = new System.Drawing.Point(90, 62);
            this.txtFinishPointX.Name = "txtFinishPointX";
            this.txtFinishPointX.Size = new System.Drawing.Size(35, 20);
            this.txtFinishPointX.TabIndex = 3;
            // 
            // lblStarPoint
            // 
            this.lblStarPoint.AutoSize = true;
            this.lblStarPoint.Location = new System.Drawing.Point(13, 31);
            this.lblStarPoint.Name = "lblStarPoint";
            this.lblStarPoint.Size = new System.Drawing.Size(71, 13);
            this.lblStarPoint.TabIndex = 4;
            this.lblStarPoint.Text = "Punto Inicial: ";
            // 
            // lblFinishPoint
            // 
            this.lblFinishPoint.AutoSize = true;
            this.lblFinishPoint.Location = new System.Drawing.Point(18, 65);
            this.lblFinishPoint.Name = "lblFinishPoint";
            this.lblFinishPoint.Size = new System.Drawing.Size(66, 13);
            this.lblFinishPoint.TabIndex = 5;
            this.lblFinishPoint.Text = "Punto Final: ";
            // 
            // txtStarPointY
            // 
            this.txtStarPointY.Location = new System.Drawing.Point(131, 31);
            this.txtStarPointY.Name = "txtStarPointY";
            this.txtStarPointY.Size = new System.Drawing.Size(35, 20);
            this.txtStarPointY.TabIndex = 6;
            // 
            // txtFinishPointY
            // 
            this.txtFinishPointY.Location = new System.Drawing.Point(131, 62);
            this.txtFinishPointY.Name = "txtFinishPointY";
            this.txtFinishPointY.Size = new System.Drawing.Size(35, 20);
            this.txtFinishPointY.TabIndex = 7;
            // 
            // cbxAlgotithms
            // 
            this.cbxAlgotithms.FormattingEnabled = true;
            this.cbxAlgotithms.Items.AddRange(new object[] {
            "DDA",
            "Bresenham Linea",
            "Bresenham circunferencias"});
            this.cbxAlgotithms.Location = new System.Drawing.Point(16, 100);
            this.cbxAlgotithms.Name = "cbxAlgotithms";
            this.cbxAlgotithms.Size = new System.Drawing.Size(198, 21);
            this.cbxAlgotithms.TabIndex = 8;
            // 
            // gbxImputs
            // 
            this.gbxImputs.Controls.Add(this.txtFinishPointY);
            this.gbxImputs.Controls.Add(this.cbxAlgotithms);
            this.gbxImputs.Controls.Add(this.txtStarPointY);
            this.gbxImputs.Controls.Add(this.lblFinishPoint);
            this.gbxImputs.Controls.Add(this.lblStarPoint);
            this.gbxImputs.Controls.Add(this.txtFinishPointX);
            this.gbxImputs.Controls.Add(this.txtStarPointX);
            this.gbxImputs.Location = new System.Drawing.Point(12, 12);
            this.gbxImputs.Name = "gbxImputs";
            this.gbxImputs.Size = new System.Drawing.Size(288, 144);
            this.gbxImputs.TabIndex = 9;
            this.gbxImputs.TabStop = false;
            this.gbxImputs.Text = "Entrada";
            this.gbxImputs.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gbxbutton
            // 
            this.gbxbutton.Controls.Add(this.btnDraw);
            this.gbxbutton.Location = new System.Drawing.Point(13, 164);
            this.gbxbutton.Name = "gbxbutton";
            this.gbxbutton.Size = new System.Drawing.Size(286, 68);
            this.gbxbutton.TabIndex = 10;
            this.gbxbutton.TabStop = false;
            this.gbxbutton.Text = "Botones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxbutton);
            this.Controls.Add(this.gbxImputs);
            this.Controls.Add(this.gbxPicCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxPicCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.gbxImputs.ResumeLayout(false);
            this.gbxImputs.PerformLayout();
            this.gbxbutton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPicCanvas;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.TextBox txtStarPointX;
        private System.Windows.Forms.TextBox txtFinishPointX;
        private System.Windows.Forms.Label lblStarPoint;
        private System.Windows.Forms.Label lblFinishPoint;
        private System.Windows.Forms.TextBox txtStarPointY;
        private System.Windows.Forms.TextBox txtFinishPointY;
        private System.Windows.Forms.ComboBox cbxAlgotithms;
        private System.Windows.Forms.GroupBox gbxImputs;
        private System.Windows.Forms.GroupBox gbxbutton;
    }
}

