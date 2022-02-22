namespace Tarea_8
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
            this.datosLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.saldoLabel = new System.Windows.Forms.Label();
            this.nDepositosLabel = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.saldoTextBox = new System.Windows.Forms.TextBox();
            this.consultarButton = new System.Windows.Forms.Button();
            this.nRetirosLabel = new System.Windows.Forms.Label();
            this.nDepositosLabel1 = new System.Windows.Forms.Label();
            this.nRetirosLabel1 = new System.Windows.Forms.Label();
            this.operacionesLabel = new System.Windows.Forms.Label();
            this.vDepositoLabel = new System.Windows.Forms.Label();
            this.vRetiroLabel = new System.Windows.Forms.Label();
            this.depositoTextBox = new System.Windows.Forms.TextBox();
            this.retiroTextBox = new System.Windows.Forms.TextBox();
            this.salirButton = new System.Windows.Forms.Button();
            this.depositarButton = new System.Windows.Forms.Button();
            this.retirarButton = new System.Windows.Forms.Button();
            this.crearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // datosLabel
            // 
            this.datosLabel.AutoSize = true;
            this.datosLabel.Location = new System.Drawing.Point(175, 22);
            this.datosLabel.Name = "datosLabel";
            this.datosLabel.Size = new System.Drawing.Size(125, 13);
            this.datosLabel.TabIndex = 0;
            this.datosLabel.Text = "DATOS DE LA CUENTA";
            this.datosLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(33, 97);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(44, 13);
            this.nombreLabel.TabIndex = 1;
            this.nombreLabel.Text = "Nombre";
            this.nombreLabel.Click += new System.EventHandler(this.nombreLabel_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(33, 129);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(73, 13);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "Identificación:";
            this.idLabel.Click += new System.EventHandler(this.idLabel_Click);
            // 
            // saldoLabel
            // 
            this.saldoLabel.AutoSize = true;
            this.saldoLabel.Location = new System.Drawing.Point(33, 163);
            this.saldoLabel.Name = "saldoLabel";
            this.saldoLabel.Size = new System.Drawing.Size(37, 13);
            this.saldoLabel.TabIndex = 3;
            this.saldoLabel.Text = "Saldo:";
            this.saldoLabel.Click += new System.EventHandler(this.saldoLabel_Click);
            // 
            // nDepositosLabel
            // 
            this.nDepositosLabel.AutoSize = true;
            this.nDepositosLabel.Location = new System.Drawing.Point(334, 97);
            this.nDepositosLabel.Name = "nDepositosLabel";
            this.nDepositosLabel.Size = new System.Drawing.Size(57, 13);
            this.nDepositosLabel.TabIndex = 4;
            this.nDepositosLabel.Text = "Depositos:";
            this.nDepositosLabel.Click += new System.EventHandler(this.nDepositosLabel_Click);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(122, 94);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 5;
            this.nombreTextBox.TextChanged += new System.EventHandler(this.nombreTextBox_TextChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(122, 126);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 6;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // saldoTextBox
            // 
            this.saldoTextBox.Location = new System.Drawing.Point(122, 160);
            this.saldoTextBox.Name = "saldoTextBox";
            this.saldoTextBox.Size = new System.Drawing.Size(100, 20);
            this.saldoTextBox.TabIndex = 7;
            this.saldoTextBox.TextChanged += new System.EventHandler(this.saldoTextBox_TextChanged);
            // 
            // consultarButton
            // 
            this.consultarButton.Location = new System.Drawing.Point(228, 158);
            this.consultarButton.Name = "consultarButton";
            this.consultarButton.Size = new System.Drawing.Size(75, 23);
            this.consultarButton.TabIndex = 8;
            this.consultarButton.Text = "Consultar";
            this.consultarButton.UseVisualStyleBackColor = true;
            this.consultarButton.Click += new System.EventHandler(this.consultarButton_Click);
            // 
            // nRetirosLabel
            // 
            this.nRetirosLabel.AutoSize = true;
            this.nRetirosLabel.Location = new System.Drawing.Point(334, 129);
            this.nRetirosLabel.Name = "nRetirosLabel";
            this.nRetirosLabel.Size = new System.Drawing.Size(43, 13);
            this.nRetirosLabel.TabIndex = 9;
            this.nRetirosLabel.Text = "Retiros:";
            this.nRetirosLabel.Click += new System.EventHandler(this.nRetirosLabel_Click);
            // 
            // nDepositosLabel1
            // 
            this.nDepositosLabel1.AutoSize = true;
            this.nDepositosLabel1.Location = new System.Drawing.Point(397, 97);
            this.nDepositosLabel1.Name = "nDepositosLabel1";
            this.nDepositosLabel1.Size = new System.Drawing.Size(13, 13);
            this.nDepositosLabel1.TabIndex = 10;
            this.nDepositosLabel1.Text = "0";
            this.nDepositosLabel1.Click += new System.EventHandler(this.nDepositosLabel1_Click);
            // 
            // nRetirosLabel1
            // 
            this.nRetirosLabel1.AutoSize = true;
            this.nRetirosLabel1.Location = new System.Drawing.Point(397, 129);
            this.nRetirosLabel1.Name = "nRetirosLabel1";
            this.nRetirosLabel1.Size = new System.Drawing.Size(13, 13);
            this.nRetirosLabel1.TabIndex = 11;
            this.nRetirosLabel1.Text = "0";
            this.nRetirosLabel1.Click += new System.EventHandler(this.nRetirosLabel1_Click);
            // 
            // operacionesLabel
            // 
            this.operacionesLabel.AutoSize = true;
            this.operacionesLabel.Location = new System.Drawing.Point(175, 216);
            this.operacionesLabel.Name = "operacionesLabel";
            this.operacionesLabel.Size = new System.Drawing.Size(84, 13);
            this.operacionesLabel.TabIndex = 12;
            this.operacionesLabel.Text = "OPERACIONES";
            this.operacionesLabel.Click += new System.EventHandler(this.operacionesLabel_Click);
            // 
            // vDepositoLabel
            // 
            this.vDepositoLabel.AutoSize = true;
            this.vDepositoLabel.Location = new System.Drawing.Point(119, 254);
            this.vDepositoLabel.Name = "vDepositoLabel";
            this.vDepositoLabel.Size = new System.Drawing.Size(77, 13);
            this.vDepositoLabel.TabIndex = 13;
            this.vDepositoLabel.Text = "Valor deposito:";
            this.vDepositoLabel.Click += new System.EventHandler(this.vDepositoLabel_Click);
            // 
            // vRetiroLabel
            // 
            this.vRetiroLabel.AutoSize = true;
            this.vRetiroLabel.Location = new System.Drawing.Point(243, 254);
            this.vRetiroLabel.Name = "vRetiroLabel";
            this.vRetiroLabel.Size = new System.Drawing.Size(60, 13);
            this.vRetiroLabel.TabIndex = 14;
            this.vRetiroLabel.Text = "Valor retiro:";
            this.vRetiroLabel.Click += new System.EventHandler(this.vRetiroLabel_Click);
            // 
            // depositoTextBox
            // 
            this.depositoTextBox.Location = new System.Drawing.Point(122, 283);
            this.depositoTextBox.Name = "depositoTextBox";
            this.depositoTextBox.Size = new System.Drawing.Size(100, 20);
            this.depositoTextBox.TabIndex = 15;
            this.depositoTextBox.TextChanged += new System.EventHandler(this.depositoTextBox_TextChanged);
            // 
            // retiroTextBox
            // 
            this.retiroTextBox.Location = new System.Drawing.Point(246, 283);
            this.retiroTextBox.Name = "retiroTextBox";
            this.retiroTextBox.Size = new System.Drawing.Size(100, 20);
            this.retiroTextBox.TabIndex = 16;
            this.retiroTextBox.TextChanged += new System.EventHandler(this.retiroTextBox_TextChanged);
            // 
            // salirButton
            // 
            this.salirButton.Location = new System.Drawing.Point(389, 346);
            this.salirButton.Name = "salirButton";
            this.salirButton.Size = new System.Drawing.Size(75, 38);
            this.salirButton.TabIndex = 17;
            this.salirButton.Text = "Salir";
            this.salirButton.UseVisualStyleBackColor = true;
            this.salirButton.Click += new System.EventHandler(this.salirButton_Click);
            // 
            // depositarButton
            // 
            this.depositarButton.Location = new System.Drawing.Point(134, 325);
            this.depositarButton.Name = "depositarButton";
            this.depositarButton.Size = new System.Drawing.Size(75, 23);
            this.depositarButton.TabIndex = 18;
            this.depositarButton.Text = "Depositar";
            this.depositarButton.UseVisualStyleBackColor = true;
            this.depositarButton.Click += new System.EventHandler(this.depositarButton_Click);
            // 
            // retirarButton
            // 
            this.retirarButton.Location = new System.Drawing.Point(256, 325);
            this.retirarButton.Name = "retirarButton";
            this.retirarButton.Size = new System.Drawing.Size(75, 23);
            this.retirarButton.TabIndex = 19;
            this.retirarButton.Text = "Retirar";
            this.retirarButton.UseVisualStyleBackColor = true;
            this.retirarButton.Click += new System.EventHandler(this.retirarButton_Click);
            // 
            // crearButton
            // 
            this.crearButton.Location = new System.Drawing.Point(36, 53);
            this.crearButton.Name = "crearButton";
            this.crearButton.Size = new System.Drawing.Size(75, 23);
            this.crearButton.TabIndex = 20;
            this.crearButton.Text = "Crear ";
            this.crearButton.UseVisualStyleBackColor = true;
            this.crearButton.Click += new System.EventHandler(this.crearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 405);
            this.Controls.Add(this.crearButton);
            this.Controls.Add(this.retirarButton);
            this.Controls.Add(this.depositarButton);
            this.Controls.Add(this.salirButton);
            this.Controls.Add(this.retiroTextBox);
            this.Controls.Add(this.depositoTextBox);
            this.Controls.Add(this.vRetiroLabel);
            this.Controls.Add(this.vDepositoLabel);
            this.Controls.Add(this.operacionesLabel);
            this.Controls.Add(this.nRetirosLabel1);
            this.Controls.Add(this.nDepositosLabel1);
            this.Controls.Add(this.nRetirosLabel);
            this.Controls.Add(this.consultarButton);
            this.Controls.Add(this.saldoTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.nDepositosLabel);
            this.Controls.Add(this.saldoLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.datosLabel);
            this.Name = "Form1";
            this.Text = " Tarea 8";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label datosLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label saldoLabel;
        private System.Windows.Forms.Label nDepositosLabel;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox saldoTextBox;
        private System.Windows.Forms.Button consultarButton;
        private System.Windows.Forms.Label nRetirosLabel;
        private System.Windows.Forms.Label nDepositosLabel1;
        private System.Windows.Forms.Label nRetirosLabel1;
        private System.Windows.Forms.Label operacionesLabel;
        private System.Windows.Forms.Label vDepositoLabel;
        private System.Windows.Forms.Label vRetiroLabel;
        private System.Windows.Forms.TextBox depositoTextBox;
        private System.Windows.Forms.TextBox retiroTextBox;
        private System.Windows.Forms.Button salirButton;
        private System.Windows.Forms.Button depositarButton;
        private System.Windows.Forms.Button retirarButton;
        private System.Windows.Forms.Button crearButton;
    }
}

