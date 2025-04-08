namespace JuegoQuiz
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
            this.components = new System.ComponentModel.Container();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbDificultad = new System.Windows.Forms.ComboBox();
            this.timerPregunta = new System.Windows.Forms.Timer(this.components);
            this.lblPregunta = new System.Windows.Forms.Label();
            this.rdbRespuesta1 = new System.Windows.Forms.RadioButton();
            this.rdbRespuesta2 = new System.Windows.Forms.RadioButton();
            this.rdbRespuesta3 = new System.Windows.Forms.RadioButton();
            this.rdbRespuesta4 = new System.Windows.Forms.RadioButton();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.lblPreguntasRestantes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Location = new System.Drawing.Point(512, 36);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(75, 23);
            this.BtnIniciar.TabIndex = 0;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(89, 36);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 1;
            // 
            // cmbDificultad
            // 
            this.cmbDificultad.FormattingEnabled = true;
            this.cmbDificultad.Location = new System.Drawing.Point(269, 36);
            this.cmbDificultad.Name = "cmbDificultad";
            this.cmbDificultad.Size = new System.Drawing.Size(121, 21);
            this.cmbDificultad.TabIndex = 2;
            // 
            // timerPregunta
            // 
            this.timerPregunta.Tick += new System.EventHandler(this.timerPregunta_Tick);
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(60, 101);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(53, 13);
            this.lblPregunta.TabIndex = 3;
            this.lblPregunta.Text = "Pregunta:";
            // 
            // rdbRespuesta1
            // 
            this.rdbRespuesta1.AutoSize = true;
            this.rdbRespuesta1.Location = new System.Drawing.Point(63, 148);
            this.rdbRespuesta1.Name = "rdbRespuesta1";
            this.rdbRespuesta1.Size = new System.Drawing.Size(14, 13);
            this.rdbRespuesta1.TabIndex = 4;
            this.rdbRespuesta1.TabStop = true;
            this.rdbRespuesta1.UseVisualStyleBackColor = true;
            this.rdbRespuesta1.Click += new System.EventHandler(this.rdbRespuesta1_Click);
            // 
            // rdbRespuesta2
            // 
            this.rdbRespuesta2.AutoSize = true;
            this.rdbRespuesta2.Location = new System.Drawing.Point(368, 148);
            this.rdbRespuesta2.Name = "rdbRespuesta2";
            this.rdbRespuesta2.Size = new System.Drawing.Size(14, 13);
            this.rdbRespuesta2.TabIndex = 5;
            this.rdbRespuesta2.TabStop = true;
            this.rdbRespuesta2.UseVisualStyleBackColor = true;
            this.rdbRespuesta2.Click += new System.EventHandler(this.rdbRespuesta1_Click);
            // 
            // rdbRespuesta3
            // 
            this.rdbRespuesta3.AutoSize = true;
            this.rdbRespuesta3.Location = new System.Drawing.Point(63, 195);
            this.rdbRespuesta3.Name = "rdbRespuesta3";
            this.rdbRespuesta3.Size = new System.Drawing.Size(14, 13);
            this.rdbRespuesta3.TabIndex = 6;
            this.rdbRespuesta3.TabStop = true;
            this.rdbRespuesta3.UseVisualStyleBackColor = true;
            this.rdbRespuesta3.Click += new System.EventHandler(this.rdbRespuesta1_Click);
            // 
            // rdbRespuesta4
            // 
            this.rdbRespuesta4.AutoSize = true;
            this.rdbRespuesta4.Location = new System.Drawing.Point(368, 195);
            this.rdbRespuesta4.Name = "rdbRespuesta4";
            this.rdbRespuesta4.Size = new System.Drawing.Size(14, 13);
            this.rdbRespuesta4.TabIndex = 7;
            this.rdbRespuesta4.TabStop = true;
            this.rdbRespuesta4.UseVisualStyleBackColor = true;
            this.rdbRespuesta4.Click += new System.EventHandler(this.rdbRespuesta1_Click);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblTiempo.Location = new System.Drawing.Point(60, 338);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(83, 25);
            this.lblTiempo.TabIndex = 9;
            this.lblTiempo.Text = "Tiempo";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(456, 287);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 10;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntaje.Location = new System.Drawing.Point(58, 267);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(0, 25);
            this.lblPuntaje.TabIndex = 11;
            // 
            // lblPreguntasRestantes
            // 
            this.lblPreguntasRestantes.AutoSize = true;
            this.lblPreguntasRestantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblPreguntasRestantes.Location = new System.Drawing.Point(60, 381);
            this.lblPreguntasRestantes.Name = "lblPreguntasRestantes";
            this.lblPreguntasRestantes.Size = new System.Drawing.Size(213, 25);
            this.lblPreguntasRestantes.TabIndex = 12;
            this.lblPreguntasRestantes.Text = "Preguntas Restantes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 450);
            this.Controls.Add(this.lblPreguntasRestantes);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.rdbRespuesta4);
            this.Controls.Add(this.rdbRespuesta3);
            this.Controls.Add(this.rdbRespuesta2);
            this.Controls.Add(this.rdbRespuesta1);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.cmbDificultad);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.BtnIniciar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbDificultad;
        private System.Windows.Forms.Timer timerPregunta;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.RadioButton rdbRespuesta1;
        private System.Windows.Forms.RadioButton rdbRespuesta2;
        private System.Windows.Forms.RadioButton rdbRespuesta3;
        private System.Windows.Forms.RadioButton rdbRespuesta4;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Label lblPreguntasRestantes;
    }
}

