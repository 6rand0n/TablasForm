namespace Tabla
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Principal = new Panel();
            Resultados = new RichTextBox();
            Ver = new Button();
            Num = new TextBox();
            labelNumero = new Label();
            Titulo = new Label();
            label1 = new Label();
            Principal.SuspendLayout();
            SuspendLayout();
            // 
            // Principal
            // 
            Principal.BackColor = SystemColors.ActiveCaption;
            Principal.Controls.Add(label1);
            Principal.Controls.Add(Resultados);
            Principal.Controls.Add(Ver);
            Principal.Controls.Add(Num);
            Principal.Controls.Add(labelNumero);
            Principal.Controls.Add(Titulo);
            Principal.Location = new Point(12, 12);
            Principal.Name = "Principal";
            Principal.Size = new Size(774, 426);
            Principal.TabIndex = 0;
            // 
            // Resultados
            // 
            Resultados.Font = new Font("Segoe UI Variable Display Semib", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Resultados.Location = new Point(412, 18);
            Resultados.Name = "Resultados";
            Resultados.Size = new Size(287, 384);
            Resultados.TabIndex = 4;
            Resultados.Text = "";
            // 
            // Ver
            // 
            Ver.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Ver.Location = new Point(155, 214);
            Ver.Name = "Ver";
            Ver.Size = new Size(94, 29);
            Ver.TabIndex = 3;
            Ver.Text = "Ver tabla";
            Ver.UseVisualStyleBackColor = true;
            Ver.Click += Ver_Click;
            // 
            // Num
            // 
            Num.Location = new Point(138, 155);
            Num.Name = "Num";
            Num.Size = new Size(125, 27);
            Num.TabIndex = 2;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNumero.Location = new Point(99, 102);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(208, 25);
            labelNumero.TabIndex = 1;
            labelNumero.Text = "¿Cual Numero Quieres?";
            labelNumero.Click += label1_Click;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Titulo.Location = new Point(99, 28);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(195, 26);
            Titulo.TabIndex = 0;
            Titulo.Tag = "Tabla de multiplicar";
            Titulo.Text = "Tabla de multiplicar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 378);
            label1.Name = "label1";
            label1.Size = new Size(402, 38);
            label1.TabIndex = 5;
            label1.Text = "Brandon Javier Becerra Davila";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Principal);
            Name = "Form1";
            Text = "Form1";
            Principal.ResumeLayout(false);
            Principal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Principal;
        private Label labelNumero;
        private Label Titulo;
        private TextBox Num;
        private RichTextBox Resultados;
        private Button Ver;
        private Label label1;
    }
}
