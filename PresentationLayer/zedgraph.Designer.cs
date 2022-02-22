
namespace PresentationLayer
{
    partial class zedgraph
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
            this.zedGraph1 = new ZedGraph.ZedGraphControl();
            this.SuspendLayout();
            // 
            // zedGraph1
            // 
            this.zedGraph1.Location = new System.Drawing.Point(-1, 0);
            this.zedGraph1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraph1.Name = "zedGraph1";
            this.zedGraph1.ScrollGrace = 0D;
            this.zedGraph1.ScrollMaxX = 0D;
            this.zedGraph1.ScrollMaxY = 0D;
            this.zedGraph1.ScrollMaxY2 = 0D;
            this.zedGraph1.ScrollMinX = 0D;
            this.zedGraph1.ScrollMinY = 0D;
            this.zedGraph1.ScrollMinY2 = 0D;
            this.zedGraph1.Size = new System.Drawing.Size(1228, 492);
            this.zedGraph1.TabIndex = 0;
            // 
            // zedgraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 495);
            this.ControlBox = false;
            this.Controls.Add(this.zedGraph1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "zedgraph";
            this.Text = "zedgraph";
            this.Load += new System.EventHandler(this.zedgraph_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private ZedGraph.ZedGraphControl zedGraph1;
    }
}