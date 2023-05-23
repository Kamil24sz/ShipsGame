namespace ShipsGame.Okna
{
    partial class UstawienieStatkow
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
            this.planszaGracza = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDalej = new System.Windows.Forms.Button();
            this.txtNazwaGracza = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.planszaGracza)).BeginInit();
            this.SuspendLayout();
            // 
            // planszaGracza
            // 
            this.planszaGracza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.planszaGracza.Image = global::ShipsGame.Properties.Resources.board;
            this.planszaGracza.Location = new System.Drawing.Point(22, 23);
            this.planszaGracza.Name = "planszaGracza";
            this.planszaGracza.Size = new System.Drawing.Size(400, 400);
            this.planszaGracza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.planszaGracza.TabIndex = 0;
            this.planszaGracza.TabStop = false;
            this.planszaGracza.MouseMove += new System.Windows.Forms.MouseEventHandler(this.planszaGracza_MouseMove);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(540, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Obróć";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDalej
            // 
            this.btnDalej.Location = new System.Drawing.Point(540, 284);
            this.btnDalej.Name = "btnDalej";
            this.btnDalej.Size = new System.Drawing.Size(75, 23);
            this.btnDalej.TabIndex = 2;
            this.btnDalej.Text = "Dalej";
            this.btnDalej.UseVisualStyleBackColor = true;
            // 
            // txtNazwaGracza
            // 
            this.txtNazwaGracza.Location = new System.Drawing.Point(525, 153);
            this.txtNazwaGracza.Name = "txtNazwaGracza";
            this.txtNazwaGracza.Size = new System.Drawing.Size(100, 20);
            this.txtNazwaGracza.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(546, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gracz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(522, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Podaj nazwę gracza";
            // 
            // UstawienieStatkow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 441);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNazwaGracza);
            this.Controls.Add(this.btnDalej);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.planszaGracza);
            this.Name = "UstawienieStatkow";
            this.Text = "UstawienieStatkow";
            ((System.ComponentModel.ISupportInitialize)(this.planszaGracza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox planszaGracza;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDalej;
        private System.Windows.Forms.TextBox txtNazwaGracza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}