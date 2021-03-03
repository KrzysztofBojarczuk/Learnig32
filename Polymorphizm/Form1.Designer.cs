
namespace Polymorphizm
{
    partial class Form1
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
            this.createAnimalButton = new System.Windows.Forms.Button();
            this.createDogButton = new System.Windows.Forms.Button();
            this.createCatButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createAnimalButton
            // 
            this.createAnimalButton.Location = new System.Drawing.Point(268, 228);
            this.createAnimalButton.Name = "createAnimalButton";
            this.createAnimalButton.Size = new System.Drawing.Size(93, 23);
            this.createAnimalButton.TabIndex = 0;
            this.createAnimalButton.Text = "Utwórz zwierze";
            this.createAnimalButton.UseVisualStyleBackColor = true;
            this.createAnimalButton.Click += new System.EventHandler(this.createAnimalButton_Click);
            // 
            // createDogButton
            // 
            this.createDogButton.Location = new System.Drawing.Point(396, 228);
            this.createDogButton.Name = "createDogButton";
            this.createDogButton.Size = new System.Drawing.Size(75, 23);
            this.createDogButton.TabIndex = 1;
            this.createDogButton.Text = "Utwórz psa";
            this.createDogButton.UseVisualStyleBackColor = true;
            this.createDogButton.Click += new System.EventHandler(this.createDogButton_Click);
            // 
            // createCatButton
            // 
            this.createCatButton.Location = new System.Drawing.Point(501, 228);
            this.createCatButton.Name = "createCatButton";
            this.createCatButton.Size = new System.Drawing.Size(75, 23);
            this.createCatButton.TabIndex = 2;
            this.createCatButton.Text = "Utwórz kota";
            this.createCatButton.UseVisualStyleBackColor = true;
            this.createCatButton.Click += new System.EventHandler(this.createCatButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(396, 270);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Zakończ";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.createCatButton);
            this.Controls.Add(this.createDogButton);
            this.Controls.Add(this.createAnimalButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createAnimalButton;
        private System.Windows.Forms.Button createDogButton;
        private System.Windows.Forms.Button createCatButton;
        private System.Windows.Forms.Button exitButton;
    }
}

