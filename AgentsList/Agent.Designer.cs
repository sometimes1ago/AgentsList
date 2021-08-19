
namespace AgentsList
{
    partial class Agent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AgentImage = new System.Windows.Forms.PictureBox();
            this.AgentType = new System.Windows.Forms.Label();
            this.AgentName = new System.Windows.Forms.Label();
            this.SellsPerYear = new System.Windows.Forms.Label();
            this.AgentPhone = new System.Windows.Forms.Label();
            this.AgentPriority = new System.Windows.Forms.Label();
            this.AgentSale = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AgentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // AgentImage
            // 
            this.AgentImage.Location = new System.Drawing.Point(18, 17);
            this.AgentImage.Name = "AgentImage";
            this.AgentImage.Size = new System.Drawing.Size(100, 111);
            this.AgentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AgentImage.TabIndex = 0;
            this.AgentImage.TabStop = false;
            // 
            // AgentType
            // 
            this.AgentType.AutoSize = true;
            this.AgentType.Location = new System.Drawing.Point(124, 17);
            this.AgentType.Name = "AgentType";
            this.AgentType.Size = new System.Drawing.Size(26, 13);
            this.AgentType.TabIndex = 1;
            this.AgentType.Text = "Тип";
            // 
            // AgentName
            // 
            this.AgentName.AutoSize = true;
            this.AgentName.Location = new System.Drawing.Point(124, 41);
            this.AgentName.Name = "AgentName";
            this.AgentName.Size = new System.Drawing.Size(131, 13);
            this.AgentName.TabIndex = 2;
            this.AgentName.Text = "Фамилия Имя Отчество";
            // 
            // SellsPerYear
            // 
            this.SellsPerYear.AutoSize = true;
            this.SellsPerYear.Location = new System.Drawing.Point(124, 65);
            this.SellsPerYear.Name = "SellsPerYear";
            this.SellsPerYear.Size = new System.Drawing.Size(88, 13);
            this.SellsPerYear.TabIndex = 3;
            this.SellsPerYear.Text = "Продаж за год: ";
            // 
            // AgentPhone
            // 
            this.AgentPhone.AutoSize = true;
            this.AgentPhone.Location = new System.Drawing.Point(124, 89);
            this.AgentPhone.Name = "AgentPhone";
            this.AgentPhone.Size = new System.Drawing.Size(52, 13);
            this.AgentPhone.TabIndex = 4;
            this.AgentPhone.Text = "Телефон";
            // 
            // AgentPriority
            // 
            this.AgentPriority.AutoSize = true;
            this.AgentPriority.Location = new System.Drawing.Point(124, 113);
            this.AgentPriority.Name = "AgentPriority";
            this.AgentPriority.Size = new System.Drawing.Size(96, 13);
            this.AgentPriority.TabIndex = 5;
            this.AgentPriority.Text = "Приортитеность: ";
            // 
            // AgentSale
            // 
            this.AgentSale.AutoSize = true;
            this.AgentSale.Location = new System.Drawing.Point(418, 17);
            this.AgentSale.Name = "AgentSale";
            this.AgentSale.Size = new System.Drawing.Size(44, 13);
            this.AgentSale.TabIndex = 6;
            this.AgentSale.Text = "Скидка";
            // 
            // AgentListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AgentSale);
            this.Controls.Add(this.AgentPriority);
            this.Controls.Add(this.AgentPhone);
            this.Controls.Add(this.SellsPerYear);
            this.Controls.Add(this.AgentName);
            this.Controls.Add(this.AgentType);
            this.Controls.Add(this.AgentImage);
            this.Name = "AgentListItem";
            this.Size = new System.Drawing.Size(500, 150);
            ((System.ComponentModel.ISupportInitialize)(this.AgentImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AgentImage;
        private System.Windows.Forms.Label AgentType;
        private System.Windows.Forms.Label AgentName;
        private System.Windows.Forms.Label SellsPerYear;
        private System.Windows.Forms.Label AgentPhone;
        private System.Windows.Forms.Label AgentPriority;
        private System.Windows.Forms.Label AgentSale;
    }
}
