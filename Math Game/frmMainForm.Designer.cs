namespace Math_Game
{
    partial class frmMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblOpType = new System.Windows.Forms.Label();
            this.cbOperation = new System.Windows.Forms.ComboBox();
            this.lblNumberOfQuestions = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.txtNumberQuestions = new System.Windows.Forms.TextBox();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.lblChoseLanguage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(239, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Math Game";
            // 
            // cbLevel
            // 
            this.cbLevel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Items.AddRange(new object[] {
            "سهل",
            "متوسط",
            "صعب",
            "مشكل يالوز"});
            this.cbLevel.Location = new System.Drawing.Point(293, 144);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(187, 27);
            this.cbLevel.TabIndex = 2;
            this.cbLevel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblLevel.Location = new System.Drawing.Point(290, 118);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(157, 23);
            this.lblLevel.TabIndex = 3;
            this.lblLevel.Text = "مستوى الصعوبه";
            // 
            // lblOpType
            // 
            this.lblOpType.AutoSize = true;
            this.lblOpType.BackColor = System.Drawing.Color.Transparent;
            this.lblOpType.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOpType.Location = new System.Drawing.Point(290, 202);
            this.lblOpType.Name = "lblOpType";
            this.lblOpType.Size = new System.Drawing.Size(109, 23);
            this.lblOpType.TabIndex = 5;
            this.lblOpType.Text = "نوع العمليه";
            // 
            // cbOperation
            // 
            this.cbOperation.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOperation.FormattingEnabled = true;
            this.cbOperation.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "Mix"});
            this.cbOperation.Location = new System.Drawing.Point(293, 228);
            this.cbOperation.Name = "cbOperation";
            this.cbOperation.Size = new System.Drawing.Size(187, 27);
            this.cbOperation.TabIndex = 4;
            this.cbOperation.SelectedIndexChanged += new System.EventHandler(this.cbOperation_SelectedIndexChanged);
            // 
            // lblNumberOfQuestions
            // 
            this.lblNumberOfQuestions.AutoSize = true;
            this.lblNumberOfQuestions.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfQuestions.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNumberOfQuestions.Location = new System.Drawing.Point(290, 286);
            this.lblNumberOfQuestions.Name = "lblNumberOfQuestions";
            this.lblNumberOfQuestions.Size = new System.Drawing.Size(117, 23);
            this.lblNumberOfQuestions.TabIndex = 7;
            this.lblNumberOfQuestions.Text = "عدد الاسئله";
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.Silver;
            this.btStart.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.Location = new System.Drawing.Point(327, 363);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(120, 46);
            this.btStart.TabIndex = 8;
            this.btStart.Text = "البدأ";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNumberQuestions
            // 
            this.txtNumberQuestions.Font = new System.Drawing.Font("Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtNumberQuestions.Location = new System.Drawing.Point(293, 312);
            this.txtNumberQuestions.Name = "txtNumberQuestions";
            this.txtNumberQuestions.Size = new System.Drawing.Size(187, 27);
            this.txtNumberQuestions.TabIndex = 9;
            this.txtNumberQuestions.TextChanged += new System.EventHandler(this.txtNumberQuestions_TextChanged);
            // 
            // cbLanguage
            // 
            this.cbLanguage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Items.AddRange(new object[] {
            "عربي",
            "English"});
            this.cbLanguage.Location = new System.Drawing.Point(583, 382);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(187, 27);
            this.cbLanguage.TabIndex = 11;
            this.cbLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // lblChoseLanguage
            // 
            this.lblChoseLanguage.AutoSize = true;
            this.lblChoseLanguage.BackColor = System.Drawing.Color.Transparent;
            this.lblChoseLanguage.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoseLanguage.ForeColor = System.Drawing.Color.Black;
            this.lblChoseLanguage.Location = new System.Drawing.Point(579, 344);
            this.lblChoseLanguage.Name = "lblChoseLanguage";
            this.lblChoseLanguage.Size = new System.Drawing.Size(108, 23);
            this.lblChoseLanguage.TabIndex = 12;
            this.lblChoseLanguage.Text = "أختيار اللغه";
            // 
            // frmMainForm
            // 
            this.AcceptButton = this.btStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblChoseLanguage);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.txtNumberQuestions);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.lblNumberOfQuestions);
            this.Controls.Add(this.lblOpType);
            this.Controls.Add(this.cbOperation);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.cbLevel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMainForm";
            this.Text = "frmMainForm";
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.ComboBox cbOperation;
        private System.Windows.Forms.Label lblNumberOfQuestions;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.TextBox txtNumberQuestions;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.Label lblChoseLanguage;
        private System.Windows.Forms.Label lblOpType;
    }
}