namespace Math_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMark = new System.Windows.Forms.Label();
            this.lblNumberOfCloserTrue = new System.Windows.Forms.Label();
            this.lblNumberOfTrue = new System.Windows.Forms.Label();
            this.lblNumberOfFalse = new System.Windows.Forms.Label();
            this.btNext = new System.Windows.Forms.Button();
            this.btCheck = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEnterInput = new System.Windows.Forms.Label();
            this.lblOpType = new System.Windows.Forms.Label();
            this.lblNumberTow = new System.Windows.Forms.Label();
            this.lblNumberOne = new System.Windows.Forms.Label();
            this.lblNumberRound = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblMark);
            this.panel1.Controls.Add(this.lblNumberOfCloserTrue);
            this.panel1.Controls.Add(this.lblNumberOfTrue);
            this.panel1.Controls.Add(this.lblNumberOfFalse);
            this.panel1.Controls.Add(this.btNext);
            this.panel1.Controls.Add(this.btCheck);
            this.panel1.Controls.Add(this.txtAnswer);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblEnterInput);
            this.panel1.Controls.Add(this.lblOpType);
            this.panel1.Controls.Add(this.lblNumberTow);
            this.panel1.Controls.Add(this.lblNumberOne);
            this.panel1.Controls.Add(this.lblNumberRound);
            this.panel1.Location = new System.Drawing.Point(199, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 358);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMark.Location = new System.Drawing.Point(287, 12);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(197, 31);
            this.lblMark.TabIndex = 14;
            this.lblMark.Text = "احسنت اجابه صحيحه";
            this.lblMark.Visible = false;
            // 
            // lblNumberOfCloserTrue
            // 
            this.lblNumberOfCloserTrue.AutoSize = true;
            this.lblNumberOfCloserTrue.BackColor = System.Drawing.Color.Cyan;
            this.lblNumberOfCloserTrue.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfCloserTrue.Location = new System.Drawing.Point(431, 183);
            this.lblNumberOfCloserTrue.Name = "lblNumberOfCloserTrue";
            this.lblNumberOfCloserTrue.Size = new System.Drawing.Size(44, 45);
            this.lblNumberOfCloserTrue.TabIndex = 13;
            this.lblNumberOfCloserTrue.Text = "0";
            // 
            // lblNumberOfTrue
            // 
            this.lblNumberOfTrue.AutoSize = true;
            this.lblNumberOfTrue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblNumberOfTrue.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfTrue.Location = new System.Drawing.Point(344, 183);
            this.lblNumberOfTrue.Name = "lblNumberOfTrue";
            this.lblNumberOfTrue.Size = new System.Drawing.Size(44, 45);
            this.lblNumberOfTrue.TabIndex = 12;
            this.lblNumberOfTrue.Text = "0";
            // 
            // lblNumberOfFalse
            // 
            this.lblNumberOfFalse.AutoSize = true;
            this.lblNumberOfFalse.BackColor = System.Drawing.Color.Red;
            this.lblNumberOfFalse.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfFalse.Location = new System.Drawing.Point(255, 183);
            this.lblNumberOfFalse.Name = "lblNumberOfFalse";
            this.lblNumberOfFalse.Size = new System.Drawing.Size(44, 45);
            this.lblNumberOfFalse.TabIndex = 11;
            this.lblNumberOfFalse.Text = "0";
            // 
            // btNext
            // 
            this.btNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btNext.Enabled = false;
            this.btNext.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNext.Location = new System.Drawing.Point(331, 255);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(153, 52);
            this.btNext.TabIndex = 10;
            this.btNext.Text = "التالي";
            this.btNext.UseVisualStyleBackColor = false;
            this.btNext.Click += new System.EventHandler(this.button2_Click);
            // 
            // btCheck
            // 
            this.btCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btCheck.Enabled = false;
            this.btCheck.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheck.Location = new System.Drawing.Point(20, 255);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(153, 52);
            this.btCheck.TabIndex = 9;
            this.btCheck.Text = "فحص الاجابه";
            this.btCheck.UseVisualStyleBackColor = false;
            this.btCheck.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(20, 194);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(229, 33);
            this.txtAnswer.TabIndex = 8;
            this.txtAnswer.TextChanged += new System.EventHandler(this.txtAnswer_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Math_Game.Properties.Resources.FalseIcon;
            this.pictureBox3.Location = new System.Drawing.Point(429, 130);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Math_Game.Properties.Resources.TrueIcon;
            this.pictureBox2.Location = new System.Drawing.Point(343, 130);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Math_Game.Properties.Resources.FalseIcon;
            this.pictureBox1.Location = new System.Drawing.Point(254, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblEnterInput
            // 
            this.lblEnterInput.AutoSize = true;
            this.lblEnterInput.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterInput.Location = new System.Drawing.Point(14, 139);
            this.lblEnterInput.Name = "lblEnterInput";
            this.lblEnterInput.Size = new System.Drawing.Size(200, 31);
            this.lblEnterInput.TabIndex = 4;
            this.lblEnterInput.Text = "أدخل الجواب الصحيح";
            // 
            // lblOpType
            // 
            this.lblOpType.AutoSize = true;
            this.lblOpType.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpType.Location = new System.Drawing.Point(218, 66);
            this.lblOpType.Name = "lblOpType";
            this.lblOpType.Size = new System.Drawing.Size(50, 45);
            this.lblOpType.TabIndex = 3;
            this.lblOpType.Text = "+";
            // 
            // lblNumberTow
            // 
            this.lblNumberTow.AutoSize = true;
            this.lblNumberTow.BackColor = System.Drawing.Color.Gold;
            this.lblNumberTow.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberTow.Location = new System.Drawing.Point(354, 66);
            this.lblNumberTow.Name = "lblNumberTow";
            this.lblNumberTow.Size = new System.Drawing.Size(44, 45);
            this.lblNumberTow.TabIndex = 2;
            this.lblNumberTow.Text = "0";
            // 
            // lblNumberOne
            // 
            this.lblNumberOne.AutoSize = true;
            this.lblNumberOne.BackColor = System.Drawing.Color.Gold;
            this.lblNumberOne.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOne.Location = new System.Drawing.Point(111, 66);
            this.lblNumberOne.Name = "lblNumberOne";
            this.lblNumberOne.Size = new System.Drawing.Size(44, 45);
            this.lblNumberOne.TabIndex = 1;
            this.lblNumberOne.Text = "0";
            this.lblNumberOne.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblNumberRound
            // 
            this.lblNumberRound.AutoSize = true;
            this.lblNumberRound.BackColor = System.Drawing.Color.RosyBrown;
            this.lblNumberRound.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberRound.Location = new System.Drawing.Point(218, 18);
            this.lblNumberRound.Name = "lblNumberRound";
            this.lblNumberRound.Size = new System.Drawing.Size(50, 25);
            this.lblNumberRound.TabIndex = 0;
            this.lblNumberRound.Text = "0/5";
            // 
            // Form1
            // 
            this.AcceptButton = this.btCheck;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(836, 480);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEnterInput;
        private System.Windows.Forms.Label lblOpType;
        private System.Windows.Forms.Label lblNumberTow;
        private System.Windows.Forms.Label lblNumberOne;
        private System.Windows.Forms.Label lblNumberRound;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.Label lblNumberOfCloserTrue;
        private System.Windows.Forms.Label lblNumberOfTrue;
        private System.Windows.Forms.Label lblNumberOfFalse;
        private System.Windows.Forms.Label lblMark;
    }
}

