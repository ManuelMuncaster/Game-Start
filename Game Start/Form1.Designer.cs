namespace Game_Start
{
    partial class gamescreenState
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
            this.buttonstartState = new System.Windows.Forms.Button();
            this.gamestartsState = new System.Windows.Forms.Label();
            this.numberState = new System.Windows.Forms.Label();
            this.gotextState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonstartState
            // 
            this.buttonstartState.Location = new System.Drawing.Point(86, 100);
            this.buttonstartState.Name = "buttonstartState";
            this.buttonstartState.Size = new System.Drawing.Size(111, 51);
            this.buttonstartState.TabIndex = 0;
            this.buttonstartState.Text = "Press  to Start";
            this.buttonstartState.UseVisualStyleBackColor = true;
            this.buttonstartState.Click += new System.EventHandler(this.button1_Click);
            // 
            // gamestartsState
            // 
            this.gamestartsState.AutoSize = true;
            this.gamestartsState.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamestartsState.ForeColor = System.Drawing.Color.White;
            this.gamestartsState.Location = new System.Drawing.Point(41, 110);
            this.gamestartsState.Name = "gamestartsState";
            this.gamestartsState.Size = new System.Drawing.Size(156, 25);
            this.gamestartsState.TabIndex = 1;
            this.gamestartsState.Text = "Game Starts in...";
            this.gamestartsState.Click += new System.EventHandler(this.label1_Click);
            // 
            // numberState
            // 
            this.numberState.AutoSize = true;
            this.numberState.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberState.ForeColor = System.Drawing.Color.White;
            this.numberState.Location = new System.Drawing.Point(194, 110);
            this.numberState.Name = "numberState";
            this.numberState.Size = new System.Drawing.Size(23, 25);
            this.numberState.TabIndex = 2;
            this.numberState.Text = "3";
            // 
            // gotextState
            // 
            this.gotextState.AutoSize = true;
            this.gotextState.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gotextState.ForeColor = System.Drawing.Color.White;
            this.gotextState.Location = new System.Drawing.Point(102, 110);
            this.gotextState.Name = "gotextState";
            this.gotextState.Size = new System.Drawing.Size(0, 25);
            this.gotextState.TabIndex = 3;
            // 
            // gamescreenState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.gotextState);
            this.Controls.Add(this.numberState);
            this.Controls.Add(this.gamestartsState);
            this.Controls.Add(this.buttonstartState);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "gamescreenState";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonstartState;
        private System.Windows.Forms.Label gamestartsState;
        private System.Windows.Forms.Label numberState;
        private System.Windows.Forms.Label gotextState;
    }
}

