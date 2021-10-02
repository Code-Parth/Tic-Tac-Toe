
namespace TicTacToe__Tut
{
    partial class StartNewGameMessage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartNewGameMessage));
            this.PanelTitlebar = new System.Windows.Forms.Panel();
            this.AppName = new System.Windows.Forms.Label();
            this.AppIcon = new System.Windows.Forms.PictureBox();
            this.RoundCorner = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragControl4 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.BtnYes = new Guna.UI2.WinForms.Guna2Button();
            this.BtnNo = new Guna.UI2.WinForms.Guna2Button();
            this.PanelTitlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTitlebar
            // 
            this.PanelTitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PanelTitlebar.Controls.Add(this.AppName);
            this.PanelTitlebar.Controls.Add(this.AppIcon);
            this.PanelTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitlebar.Location = new System.Drawing.Point(0, 0);
            this.PanelTitlebar.Name = "PanelTitlebar";
            this.PanelTitlebar.Size = new System.Drawing.Size(400, 30);
            this.PanelTitlebar.TabIndex = 1;
            // 
            // AppName
            // 
            this.AppName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppName.Font = new System.Drawing.Font("Iniya Display", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.AppName.ForeColor = System.Drawing.Color.White;
            this.AppName.Location = new System.Drawing.Point(30, 0);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(370, 30);
            this.AppName.TabIndex = 3;
            this.AppName.Text = "Start New Game";
            this.AppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AppIcon
            // 
            this.AppIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.AppIcon.ErrorImage = null;
            this.AppIcon.Image = global::TicTacToe__Tut.Properties.Resources.TicTacToe;
            this.AppIcon.InitialImage = null;
            this.AppIcon.Location = new System.Drawing.Point(0, 0);
            this.AppIcon.Name = "AppIcon";
            this.AppIcon.Size = new System.Drawing.Size(30, 30);
            this.AppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AppIcon.TabIndex = 0;
            this.AppIcon.TabStop = false;
            // 
            // RoundCorner
            // 
            this.RoundCorner.BorderRadius = 16;
            this.RoundCorner.TargetControl = this;
            // 
            // DragControl1
            // 
            this.DragControl1.TargetControl = this.AppIcon;
            // 
            // DragControl2
            // 
            this.DragControl2.TargetControl = this.AppName;
            // 
            // DragControl3
            // 
            this.DragControl3.TargetControl = this;
            // 
            // DragControl4
            // 
            this.DragControl4.TargetControl = this.label1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Do you want to Start New Game ?";
            // 
            // BtnYes
            // 
            this.BtnYes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.BtnYes.BorderRadius = 20;
            this.BtnYes.BorderThickness = 3;
            this.BtnYes.CheckedState.Parent = this.BtnYes;
            this.BtnYes.CustomImages.Parent = this.BtnYes;
            this.BtnYes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(250)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.BtnYes.Font = new System.Drawing.Font("Iniya Display", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.BtnYes.ForeColor = System.Drawing.Color.White;
            this.BtnYes.HoverState.Parent = this.BtnYes;
            this.BtnYes.Location = new System.Drawing.Point(12, 99);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.PressedColor = System.Drawing.Color.Transparent;
            this.BtnYes.ShadowDecoration.Parent = this.BtnYes;
            this.BtnYes.Size = new System.Drawing.Size(160, 50);
            this.BtnYes.TabIndex = 6;
            this.BtnYes.Text = "YES";
            this.BtnYes.Click += new System.EventHandler(this.BtnYes_Click);
            // 
            // BtnNo
            // 
            this.BtnNo.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnNo.BorderRadius = 20;
            this.BtnNo.BorderThickness = 3;
            this.BtnNo.CheckedState.Parent = this.BtnNo;
            this.BtnNo.CustomImages.Parent = this.BtnNo;
            this.BtnNo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.BtnNo.Font = new System.Drawing.Font("Iniya Display", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.BtnNo.ForeColor = System.Drawing.Color.White;
            this.BtnNo.HoverState.Parent = this.BtnNo;
            this.BtnNo.Location = new System.Drawing.Point(228, 99);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.PressedColor = System.Drawing.Color.Transparent;
            this.BtnNo.ShadowDecoration.Parent = this.BtnNo;
            this.BtnNo.Size = new System.Drawing.Size(160, 50);
            this.BtnNo.TabIndex = 7;
            this.BtnNo.Text = "NO";
            this.BtnNo.Click += new System.EventHandler(this.BtnNo_Click);
            // 
            // StartNewGameMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(400, 168);
            this.Controls.Add(this.BtnNo);
            this.Controls.Add(this.BtnYes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelTitlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartNewGameMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start New Game";
            this.PanelTitlebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AppIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitlebar;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.PictureBox AppIcon;
        private Guna.UI2.WinForms.Guna2Elipse RoundCorner;
        private Guna.UI2.WinForms.Guna2DragControl DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl DragControl3;
        private Guna.UI2.WinForms.Guna2DragControl DragControl4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button BtnYes;
        private Guna.UI2.WinForms.Guna2Button BtnNo;
    }
}