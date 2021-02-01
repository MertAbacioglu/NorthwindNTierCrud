
namespace Project.WinUI
{
    partial class AddShipper
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
            this.btnAddShipper = new System.Windows.Forms.Button();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.txtShipperPhone = new System.Windows.Forms.TextBox();
            this.txtShipperName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddShipper
            // 
            this.btnAddShipper.Location = new System.Drawing.Point(48, 140);
            this.btnAddShipper.Name = "btnAddShipper";
            this.btnAddShipper.Size = new System.Drawing.Size(128, 23);
            this.btnAddShipper.TabIndex = 11;
            this.btnAddShipper.Text = "Add Shipper";
            this.btnAddShipper.UseVisualStyleBackColor = true;
            this.btnAddShipper.Click += new System.EventHandler(this.btnAddShipper_Click);
            // 
            // label43
            // 
            this.label43.Location = new System.Drawing.Point(45, 89);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(100, 23);
            this.label43.TabIndex = 9;
            this.label43.Text = "Phone";
            // 
            // label42
            // 
            this.label42.Location = new System.Drawing.Point(45, 39);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(100, 23);
            this.label42.TabIndex = 10;
            this.label42.Text = "Company Name";
            // 
            // txtShipperPhone
            // 
            this.txtShipperPhone.Location = new System.Drawing.Point(171, 86);
            this.txtShipperPhone.Name = "txtShipperPhone";
            this.txtShipperPhone.Size = new System.Drawing.Size(100, 20);
            this.txtShipperPhone.TabIndex = 7;
            this.txtShipperPhone.Text = ",";
            // 
            // txtShipperName
            // 
            this.txtShipperName.Location = new System.Drawing.Point(171, 39);
            this.txtShipperName.Name = "txtShipperName";
            this.txtShipperName.Size = new System.Drawing.Size(100, 20);
            this.txtShipperName.TabIndex = 8;
            // 
            // AddShipper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 450);
            this.Controls.Add(this.btnAddShipper);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.txtShipperPhone);
            this.Controls.Add(this.txtShipperName);
            this.Name = "AddShipper";
            this.Text = "AddShipper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddShipper;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox txtShipperPhone;
        private System.Windows.Forms.TextBox txtShipperName;
    }
}