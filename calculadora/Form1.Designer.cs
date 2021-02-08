namespace calculadora
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
            this.btCero = new System.Windows.Forms.Button();
            this.btPunto = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            this.btSuma = new System.Windows.Forms.Button();
            this.btResta = new System.Windows.Forms.Button();
            this.btTres = new System.Windows.Forms.Button();
            this.btDos = new System.Windows.Forms.Button();
            this.btUno = new System.Windows.Forms.Button();
            this.btMultiplicacion = new System.Windows.Forms.Button();
            this.btSeis = new System.Windows.Forms.Button();
            this.btCinco = new System.Windows.Forms.Button();
            this.btCuatro = new System.Windows.Forms.Button();
            this.btDivicion = new System.Windows.Forms.Button();
            this.btNueve = new System.Windows.Forms.Button();
            this.btOcho = new System.Windows.Forms.Button();
            this.btSiete = new System.Windows.Forms.Button();
            this.txPrincipal = new System.Windows.Forms.TextBox();
            this.txSecundario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCero
            // 
            this.btCero.Location = new System.Drawing.Point(57, 263);
            this.btCero.Name = "btCero";
            this.btCero.Size = new System.Drawing.Size(40, 40);
            this.btCero.TabIndex = 0;
            this.btCero.Text = "0";
            this.btCero.UseVisualStyleBackColor = true;
            this.btCero.Click += new System.EventHandler(this.btCero_Click);
            // 
            // btPunto
            // 
            this.btPunto.Location = new System.Drawing.Point(11, 263);
            this.btPunto.Name = "btPunto";
            this.btPunto.Size = new System.Drawing.Size(40, 40);
            this.btPunto.TabIndex = 1;
            this.btPunto.Text = ".";
            this.btPunto.UseVisualStyleBackColor = true;
            this.btPunto.Click += new System.EventHandler(this.btPunto_Click);
            // 
            // btIgual
            // 
            this.btIgual.Location = new System.Drawing.Point(103, 263);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(40, 40);
            this.btIgual.TabIndex = 2;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = true;
            this.btIgual.Click += new System.EventHandler(this.btIgual_Click);
            // 
            // btSuma
            // 
            this.btSuma.Location = new System.Drawing.Point(149, 263);
            this.btSuma.Name = "btSuma";
            this.btSuma.Size = new System.Drawing.Size(40, 40);
            this.btSuma.TabIndex = 3;
            this.btSuma.Text = "+";
            this.btSuma.UseVisualStyleBackColor = true;
            this.btSuma.Click += new System.EventHandler(this.btSuma_Click);
            // 
            // btResta
            // 
            this.btResta.Location = new System.Drawing.Point(149, 217);
            this.btResta.Name = "btResta";
            this.btResta.Size = new System.Drawing.Size(40, 40);
            this.btResta.TabIndex = 7;
            this.btResta.Text = "-";
            this.btResta.UseVisualStyleBackColor = true;
            this.btResta.Click += new System.EventHandler(this.btResta_Click);
            // 
            // btTres
            // 
            this.btTres.Location = new System.Drawing.Point(103, 217);
            this.btTres.Name = "btTres";
            this.btTres.Size = new System.Drawing.Size(40, 40);
            this.btTres.TabIndex = 6;
            this.btTres.Text = "3";
            this.btTres.UseVisualStyleBackColor = true;
            this.btTres.Click += new System.EventHandler(this.btTres_Click);
            // 
            // btDos
            // 
            this.btDos.Location = new System.Drawing.Point(57, 217);
            this.btDos.Name = "btDos";
            this.btDos.Size = new System.Drawing.Size(40, 40);
            this.btDos.TabIndex = 5;
            this.btDos.Text = "2";
            this.btDos.UseVisualStyleBackColor = true;
            this.btDos.Click += new System.EventHandler(this.btDos_Click);
            // 
            // btUno
            // 
            this.btUno.Location = new System.Drawing.Point(11, 217);
            this.btUno.Name = "btUno";
            this.btUno.Size = new System.Drawing.Size(40, 40);
            this.btUno.TabIndex = 4;
            this.btUno.Text = "1";
            this.btUno.UseVisualStyleBackColor = true;
            this.btUno.Click += new System.EventHandler(this.btUno_Click);
            // 
            // btMultiplicacion
            // 
            this.btMultiplicacion.Location = new System.Drawing.Point(149, 171);
            this.btMultiplicacion.Name = "btMultiplicacion";
            this.btMultiplicacion.Size = new System.Drawing.Size(40, 40);
            this.btMultiplicacion.TabIndex = 11;
            this.btMultiplicacion.Text = "x";
            this.btMultiplicacion.UseVisualStyleBackColor = true;
            this.btMultiplicacion.Click += new System.EventHandler(this.btMultiplicacion_Click);
            // 
            // btSeis
            // 
            this.btSeis.Location = new System.Drawing.Point(103, 171);
            this.btSeis.Name = "btSeis";
            this.btSeis.Size = new System.Drawing.Size(40, 40);
            this.btSeis.TabIndex = 10;
            this.btSeis.Text = "6";
            this.btSeis.UseVisualStyleBackColor = true;
            this.btSeis.Click += new System.EventHandler(this.btSeis_Click);
            // 
            // btCinco
            // 
            this.btCinco.Location = new System.Drawing.Point(57, 171);
            this.btCinco.Name = "btCinco";
            this.btCinco.Size = new System.Drawing.Size(40, 40);
            this.btCinco.TabIndex = 9;
            this.btCinco.Text = "5";
            this.btCinco.UseVisualStyleBackColor = true;
            this.btCinco.Click += new System.EventHandler(this.btCinco_Click);
            // 
            // btCuatro
            // 
            this.btCuatro.Location = new System.Drawing.Point(11, 171);
            this.btCuatro.Name = "btCuatro";
            this.btCuatro.Size = new System.Drawing.Size(40, 40);
            this.btCuatro.TabIndex = 8;
            this.btCuatro.Text = "4";
            this.btCuatro.UseVisualStyleBackColor = true;
            this.btCuatro.Click += new System.EventHandler(this.btCuatro_Click);
            // 
            // btDivicion
            // 
            this.btDivicion.Location = new System.Drawing.Point(149, 125);
            this.btDivicion.Name = "btDivicion";
            this.btDivicion.Size = new System.Drawing.Size(40, 40);
            this.btDivicion.TabIndex = 15;
            this.btDivicion.Text = "/";
            this.btDivicion.UseVisualStyleBackColor = true;
            this.btDivicion.Click += new System.EventHandler(this.btDivicion_Click);
            // 
            // btNueve
            // 
            this.btNueve.Location = new System.Drawing.Point(103, 125);
            this.btNueve.Name = "btNueve";
            this.btNueve.Size = new System.Drawing.Size(40, 40);
            this.btNueve.TabIndex = 14;
            this.btNueve.Text = "9";
            this.btNueve.UseVisualStyleBackColor = true;
            this.btNueve.Click += new System.EventHandler(this.btNueve_Click);
            // 
            // btOcho
            // 
            this.btOcho.Location = new System.Drawing.Point(57, 125);
            this.btOcho.Name = "btOcho";
            this.btOcho.Size = new System.Drawing.Size(40, 40);
            this.btOcho.TabIndex = 13;
            this.btOcho.Text = "8";
            this.btOcho.UseVisualStyleBackColor = true;
            this.btOcho.Click += new System.EventHandler(this.btOcho_Click);
            // 
            // btSiete
            // 
            this.btSiete.Location = new System.Drawing.Point(11, 125);
            this.btSiete.Name = "btSiete";
            this.btSiete.Size = new System.Drawing.Size(40, 40);
            this.btSiete.TabIndex = 12;
            this.btSiete.Text = "7";
            this.btSiete.UseVisualStyleBackColor = true;
            this.btSiete.Click += new System.EventHandler(this.btSiete_Click);
            // 
            // txPrincipal
            // 
            this.txPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPrincipal.Location = new System.Drawing.Point(12, 31);
            this.txPrincipal.Multiline = true;
            this.txPrincipal.Name = "txPrincipal";
            this.txPrincipal.Size = new System.Drawing.Size(177, 37);
            this.txPrincipal.TabIndex = 16;
            this.txPrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txPrincipal.TextChanged += new System.EventHandler(this.txPrincipal_TextChanged);
            // 
            // txSecundario
            // 
            this.txSecundario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txSecundario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSecundario.Location = new System.Drawing.Point(12, 18);
            this.txSecundario.Name = "txSecundario";
            this.txSecundario.Size = new System.Drawing.Size(176, 14);
            this.txSecundario.TabIndex = 17;
            this.txSecundario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 18;
            this.button1.Text = "MS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 20;
            this.button2.Text = "C";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(57, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 19;
            this.button3.Text = "CE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(149, 79);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 40);
            this.button4.TabIndex = 21;
            this.button4.Text = "MR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(201, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.pegarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pegarToolStripMenuItem.Text = "Pegar";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 312);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txSecundario);
            this.Controls.Add(this.txPrincipal);
            this.Controls.Add(this.btDivicion);
            this.Controls.Add(this.btNueve);
            this.Controls.Add(this.btOcho);
            this.Controls.Add(this.btSiete);
            this.Controls.Add(this.btMultiplicacion);
            this.Controls.Add(this.btSeis);
            this.Controls.Add(this.btCinco);
            this.Controls.Add(this.btCuatro);
            this.Controls.Add(this.btResta);
            this.Controls.Add(this.btTres);
            this.Controls.Add(this.btDos);
            this.Controls.Add(this.btUno);
            this.Controls.Add(this.btSuma);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.btPunto);
            this.Controls.Add(this.btCero);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCero;
        private System.Windows.Forms.Button btPunto;
        private System.Windows.Forms.Button btIgual;
        private System.Windows.Forms.Button btSuma;
        private System.Windows.Forms.Button btResta;
        private System.Windows.Forms.Button btTres;
        private System.Windows.Forms.Button btDos;
        private System.Windows.Forms.Button btUno;
        private System.Windows.Forms.Button btMultiplicacion;
        private System.Windows.Forms.Button btSeis;
        private System.Windows.Forms.Button btCinco;
        private System.Windows.Forms.Button btCuatro;
        private System.Windows.Forms.Button btDivicion;
        private System.Windows.Forms.Button btNueve;
        private System.Windows.Forms.Button btOcho;
        private System.Windows.Forms.Button btSiete;
        private System.Windows.Forms.TextBox txPrincipal;
        private System.Windows.Forms.TextBox txSecundario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}

