namespace MyApp.Ejercicios
{
    partial class MDIPrincipal
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
            this.btnArrays = new System.Windows.Forms.Button();
            this.btnToDo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArrays
            // 
            this.btnArrays.Location = new System.Drawing.Point(49, 56);
            this.btnArrays.Name = "btnArrays";
            this.btnArrays.Size = new System.Drawing.Size(75, 23);
            this.btnArrays.TabIndex = 0;
            this.btnArrays.Text = "Arrays";
            this.btnArrays.UseVisualStyleBackColor = true;
            this.btnArrays.Click += new System.EventHandler(this.btnArrays_Click);
            // 
            // btnToDo
            // 
            this.btnToDo.Location = new System.Drawing.Point(49, 85);
            this.btnToDo.Name = "btnToDo";
            this.btnToDo.Size = new System.Drawing.Size(75, 23);
            this.btnToDo.TabIndex = 1;
            this.btnToDo.Text = "ToDo";
            this.btnToDo.UseVisualStyleBackColor = true;
            this.btnToDo.Click += new System.EventHandler(this.btnToDo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Personas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MDIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnToDo);
            this.Controls.Add(this.btnArrays);
            this.Name = "MDIPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnArrays;
        private Button btnToDo;
        private Button button1;
    }
}