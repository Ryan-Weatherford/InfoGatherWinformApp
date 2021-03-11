
namespace PersonInfoWinformUI
{
    partial class HomeForm
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
            this.labelAppHeading = new System.Windows.Forms.Label();
            this.labelNewPerson = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.listBoxOurPeople = new System.Windows.Forms.ListBox();
            this.labelOurPeople = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAppHeading
            // 
            this.labelAppHeading.AutoSize = true;
            this.labelAppHeading.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppHeading.Location = new System.Drawing.Point(226, 9);
            this.labelAppHeading.Name = "labelAppHeading";
            this.labelAppHeading.Size = new System.Drawing.Size(217, 37);
            this.labelAppHeading.TabIndex = 0;
            this.labelAppHeading.Text = "Person Info App";
            // 
            // labelNewPerson
            // 
            this.labelNewPerson.AutoSize = true;
            this.labelNewPerson.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPerson.Location = new System.Drawing.Point(9, 67);
            this.labelNewPerson.Name = "labelNewPerson";
            this.labelNewPerson.Size = new System.Drawing.Size(134, 29);
            this.labelNewPerson.TabIndex = 1;
            this.labelNewPerson.Text = "New Person";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(10, 114);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(125, 29);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "First Name:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(10, 163);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(122, 29);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last Name:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(147, 111);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(250, 36);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(147, 160);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(250, 36);
            this.textBoxLastName.TabIndex = 2;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(147, 213);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(94, 38);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // listBoxOurPeople
            // 
            this.listBoxOurPeople.FormattingEnabled = true;
            this.listBoxOurPeople.ItemHeight = 28;
            this.listBoxOurPeople.Location = new System.Drawing.Point(12, 315);
            this.listBoxOurPeople.Name = "listBoxOurPeople";
            this.listBoxOurPeople.Size = new System.Drawing.Size(634, 340);
            this.listBoxOurPeople.TabIndex = 5;
            // 
            // labelOurPeople
            // 
            this.labelOurPeople.AutoSize = true;
            this.labelOurPeople.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOurPeople.Location = new System.Drawing.Point(10, 276);
            this.labelOurPeople.Name = "labelOurPeople";
            this.labelOurPeople.Size = new System.Drawing.Size(130, 29);
            this.labelOurPeople.TabIndex = 6;
            this.labelOurPeople.Text = "Our People ";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 672);
            this.Controls.Add(this.labelOurPeople);
            this.Controls.Add(this.listBoxOurPeople);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelNewPerson);
            this.Controls.Add(this.labelAppHeading);
            this.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HomeForm";
            this.Text = "Home Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAppHeading;
        private System.Windows.Forms.Label labelNewPerson;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ListBox listBoxOurPeople;
        private System.Windows.Forms.Label labelOurPeople;
    }
}

