
namespace Project.WinUI
{
    partial class AddEmployee
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
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbxEmployeeReportsTo = new System.Windows.Forms.ComboBox();
            this.txtEmployeeExtensions = new System.Windows.Forms.TextBox();
            this.txtEmployeePhone = new System.Windows.Forms.TextBox();
            this.txtEmployeeCountry = new System.Windows.Forms.TextBox();
            this.txtEmployeePostal = new System.Windows.Forms.TextBox();
            this.txtEmployeeRegion = new System.Windows.Forms.TextBox();
            this.txtEmployeeCity = new System.Windows.Forms.TextBox();
            this.txtEmployeeNotes = new System.Windows.Forms.RichTextBox();
            this.txtEmployeeAddress = new System.Windows.Forms.RichTextBox();
            this.dateTimeHired = new System.Windows.Forms.MaskedTextBox();
            this.dateTimeBirth = new System.Windows.Forms.MaskedTextBox();
            this.txtEmployeeCourTesy = new System.Windows.Forms.TextBox();
            this.txtEmployeeTitle = new System.Windows.Forms.TextBox();
            this.txtEmployeeFName = new System.Windows.Forms.TextBox();
            this.txtEmployeeLName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(588, 345);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnAddEmployee.TabIndex = 39;
            this.btnAddEmployee.Text = "Add";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(564, 57);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(99, 20);
            this.label22.TabIndex = 67;
            this.label22.Text = "Reports To ";
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(314, 207);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(99, 20);
            this.label21.TabIndex = 66;
            this.label21.Text = "Notes";
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(314, 59);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(99, 20);
            this.label20.TabIndex = 65;
            this.label20.Text = "Adress";
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(69, 319);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 20);
            this.label19.TabIndex = 64;
            this.label19.Text = "Country";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(69, 293);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 20);
            this.label18.TabIndex = 63;
            this.label18.Text = "Postal Code";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(69, 267);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 20);
            this.label17.TabIndex = 62;
            this.label17.Text = "Region";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(69, 241);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 20);
            this.label16.TabIndex = 61;
            this.label16.Text = "City";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(69, 213);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 20);
            this.label15.TabIndex = 60;
            this.label15.Text = "Title Of Courtesy";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(69, 188);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 17);
            this.label14.TabIndex = 59;
            this.label14.Text = "Title";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(69, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 17);
            this.label13.TabIndex = 58;
            this.label13.Text = "Hire Date";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(69, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 17);
            this.label12.TabIndex = 57;
            this.label12.Text = "Birth Date";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(69, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 17);
            this.label11.TabIndex = 56;
            this.label11.Text = "First Name";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(69, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 17);
            this.label10.TabIndex = 68;
            this.label10.Text = "Name";
            // 
            // cmbxEmployeeReportsTo
            // 
            this.cmbxEmployeeReportsTo.FormattingEnabled = true;
            this.cmbxEmployeeReportsTo.Location = new System.Drawing.Point(567, 80);
            this.cmbxEmployeeReportsTo.Name = "cmbxEmployeeReportsTo";
            this.cmbxEmployeeReportsTo.Size = new System.Drawing.Size(121, 21);
            this.cmbxEmployeeReportsTo.TabIndex = 55;
            // 
            // txtEmployeeExtensions
            // 
            this.txtEmployeeExtensions.Location = new System.Drawing.Point(184, 374);
            this.txtEmployeeExtensions.Name = "txtEmployeeExtensions";
            this.txtEmployeeExtensions.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeExtensions.TabIndex = 54;
            // 
            // txtEmployeePhone
            // 
            this.txtEmployeePhone.Location = new System.Drawing.Point(184, 345);
            this.txtEmployeePhone.Name = "txtEmployeePhone";
            this.txtEmployeePhone.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeePhone.TabIndex = 53;
            // 
            // txtEmployeeCountry
            // 
            this.txtEmployeeCountry.Location = new System.Drawing.Point(184, 316);
            this.txtEmployeeCountry.Name = "txtEmployeeCountry";
            this.txtEmployeeCountry.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeCountry.TabIndex = 52;
            // 
            // txtEmployeePostal
            // 
            this.txtEmployeePostal.Location = new System.Drawing.Point(184, 290);
            this.txtEmployeePostal.Name = "txtEmployeePostal";
            this.txtEmployeePostal.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeePostal.TabIndex = 51;
            // 
            // txtEmployeeRegion
            // 
            this.txtEmployeeRegion.Location = new System.Drawing.Point(184, 264);
            this.txtEmployeeRegion.Name = "txtEmployeeRegion";
            this.txtEmployeeRegion.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeRegion.TabIndex = 50;
            // 
            // txtEmployeeCity
            // 
            this.txtEmployeeCity.Location = new System.Drawing.Point(184, 238);
            this.txtEmployeeCity.Name = "txtEmployeeCity";
            this.txtEmployeeCity.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeCity.TabIndex = 49;
            // 
            // txtEmployeeNotes
            // 
            this.txtEmployeeNotes.Location = new System.Drawing.Point(317, 230);
            this.txtEmployeeNotes.Name = "txtEmployeeNotes";
            this.txtEmployeeNotes.Size = new System.Drawing.Size(188, 96);
            this.txtEmployeeNotes.TabIndex = 48;
            this.txtEmployeeNotes.Text = "";
            // 
            // txtEmployeeAddress
            // 
            this.txtEmployeeAddress.Location = new System.Drawing.Point(317, 82);
            this.txtEmployeeAddress.Name = "txtEmployeeAddress";
            this.txtEmployeeAddress.Size = new System.Drawing.Size(188, 96);
            this.txtEmployeeAddress.TabIndex = 47;
            this.txtEmployeeAddress.Text = "";
            // 
            // dateTimeHired
            // 
            this.dateTimeHired.Location = new System.Drawing.Point(184, 153);
            this.dateTimeHired.Mask = "00/00/0000";
            this.dateTimeHired.Name = "dateTimeHired";
            this.dateTimeHired.Size = new System.Drawing.Size(100, 20);
            this.dateTimeHired.TabIndex = 46;
            this.dateTimeHired.ValidatingType = typeof(System.DateTime);
            // 
            // dateTimeBirth
            // 
            this.dateTimeBirth.Location = new System.Drawing.Point(184, 118);
            this.dateTimeBirth.Mask = "00/00/0000";
            this.dateTimeBirth.Name = "dateTimeBirth";
            this.dateTimeBirth.Size = new System.Drawing.Size(100, 20);
            this.dateTimeBirth.TabIndex = 45;
            this.dateTimeBirth.ValidatingType = typeof(System.DateTime);
            // 
            // txtEmployeeCourTesy
            // 
            this.txtEmployeeCourTesy.Location = new System.Drawing.Point(184, 212);
            this.txtEmployeeCourTesy.Name = "txtEmployeeCourTesy";
            this.txtEmployeeCourTesy.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeCourTesy.TabIndex = 42;
            // 
            // txtEmployeeTitle
            // 
            this.txtEmployeeTitle.Location = new System.Drawing.Point(184, 186);
            this.txtEmployeeTitle.Name = "txtEmployeeTitle";
            this.txtEmployeeTitle.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeTitle.TabIndex = 41;
            // 
            // txtEmployeeFName
            // 
            this.txtEmployeeFName.Location = new System.Drawing.Point(184, 92);
            this.txtEmployeeFName.Name = "txtEmployeeFName";
            this.txtEmployeeFName.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeFName.TabIndex = 43;
            // 
            // txtEmployeeLName
            // 
            this.txtEmployeeLName.Location = new System.Drawing.Point(184, 66);
            this.txtEmployeeLName.Name = "txtEmployeeLName";
            this.txtEmployeeLName.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeLName.TabIndex = 40;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbxEmployeeReportsTo);
            this.Controls.Add(this.txtEmployeeExtensions);
            this.Controls.Add(this.txtEmployeePhone);
            this.Controls.Add(this.txtEmployeeCountry);
            this.Controls.Add(this.txtEmployeePostal);
            this.Controls.Add(this.txtEmployeeRegion);
            this.Controls.Add(this.txtEmployeeCity);
            this.Controls.Add(this.txtEmployeeNotes);
            this.Controls.Add(this.txtEmployeeAddress);
            this.Controls.Add(this.dateTimeHired);
            this.Controls.Add(this.dateTimeBirth);
            this.Controls.Add(this.txtEmployeeCourTesy);
            this.Controls.Add(this.txtEmployeeTitle);
            this.Controls.Add(this.txtEmployeeFName);
            this.Controls.Add(this.txtEmployeeLName);
            this.Controls.Add(this.btnAddEmployee);
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbxEmployeeReportsTo;
        private System.Windows.Forms.TextBox txtEmployeeExtensions;
        private System.Windows.Forms.TextBox txtEmployeePhone;
        private System.Windows.Forms.TextBox txtEmployeeCountry;
        private System.Windows.Forms.TextBox txtEmployeePostal;
        private System.Windows.Forms.TextBox txtEmployeeRegion;
        private System.Windows.Forms.TextBox txtEmployeeCity;
        private System.Windows.Forms.RichTextBox txtEmployeeNotes;
        private System.Windows.Forms.RichTextBox txtEmployeeAddress;
        private System.Windows.Forms.MaskedTextBox dateTimeHired;
        private System.Windows.Forms.MaskedTextBox dateTimeBirth;
        private System.Windows.Forms.TextBox txtEmployeeCourTesy;
        private System.Windows.Forms.TextBox txtEmployeeTitle;
        private System.Windows.Forms.TextBox txtEmployeeFName;
        private System.Windows.Forms.TextBox txtEmployeeLName;
    }
}