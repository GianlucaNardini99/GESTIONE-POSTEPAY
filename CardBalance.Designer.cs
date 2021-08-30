
namespace GESTIONE_POSTEPAY
{
    partial class CardBalance
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(34, 56);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(189, 23);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "SALDO IN DATA ";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(99, 96);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(345, 24);
            this.dtpDate.TabIndex = 1;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
            this.lbl2.Location = new System.Drawing.Point(34, 191);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(252, 23);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "SALDO DELLA CARTA";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(262, 232);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(29, 26);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "€";
            // 
            // tbAmount
            // 
            this.tbAmount.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F);
            this.tbAmount.Location = new System.Drawing.Point(99, 232);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(148, 24);
            this.tbAmount.TabIndex = 4;
            this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleInput);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.Info;
            this.btnOk.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F);
            this.btnOk.Location = new System.Drawing.Point(383, 324);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(113, 54);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Info;
            this.btnCancel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F);
            this.btnCancel.Location = new System.Drawing.Point(540, 324);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 54);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "ANNULLA";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CardBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(707, 418);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lbl1);
            this.Name = "CardBalance";
            this.Text = "SALDO CARTA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}