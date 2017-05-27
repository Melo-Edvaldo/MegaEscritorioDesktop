namespace MegaEscritorioDesktop
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pineMaterial = new System.Windows.Forms.RadioButton();
            this.oakMaterial = new System.Windows.Forms.RadioButton();
            this.laminateMaterial = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dayFourteen = new System.Windows.Forms.RadioButton();
            this.daySeven = new System.Windows.Forms.RadioButton();
            this.dayFive = new System.Windows.Forms.RadioButton();
            this.dayThree = new System.Windows.Forms.RadioButton();
            this.price = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deskArea = new System.Windows.Forms.Label();
            this.deskDepth = new System.Windows.Forms.NumericUpDown();
            this.deskWidth = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.drawerNumber = new System.Windows.Forms.NumericUpDown();
            this.clickCalculate = new System.Windows.Forms.Button();
            this.priceQuote = new System.Windows.Forms.Label();
            this.quoteDate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deskDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskWidth)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawerNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "MEGA ESCRITORIO DESKTOP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desk Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Desk Depth";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pineMaterial);
            this.groupBox1.Controls.Add(this.oakMaterial);
            this.groupBox1.Controls.Add(this.laminateMaterial);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(276, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 122);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "3. Choose Desktop Material";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pineMaterial
            // 
            this.pineMaterial.AutoSize = true;
            this.pineMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pineMaterial.Location = new System.Drawing.Point(7, 69);
            this.pineMaterial.Name = "pineMaterial";
            this.pineMaterial.Size = new System.Drawing.Size(58, 21);
            this.pineMaterial.TabIndex = 2;
            this.pineMaterial.Text = "Pine ";
            this.pineMaterial.UseVisualStyleBackColor = true;
            this.pineMaterial.CheckedChanged += new System.EventHandler(this.pine);
            // 
            // oakMaterial
            // 
            this.oakMaterial.AutoSize = true;
            this.oakMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oakMaterial.Location = new System.Drawing.Point(7, 23);
            this.oakMaterial.Name = "oakMaterial";
            this.oakMaterial.Size = new System.Drawing.Size(52, 21);
            this.oakMaterial.TabIndex = 1;
            this.oakMaterial.TabStop = true;
            this.oakMaterial.Text = "Oak";
            this.oakMaterial.UseVisualStyleBackColor = true;
            this.oakMaterial.CheckedChanged += new System.EventHandler(this.oak);
            // 
            // laminateMaterial
            // 
            this.laminateMaterial.AutoSize = true;
            this.laminateMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laminateMaterial.Location = new System.Drawing.Point(7, 46);
            this.laminateMaterial.Name = "laminateMaterial";
            this.laminateMaterial.Size = new System.Drawing.Size(84, 21);
            this.laminateMaterial.TabIndex = 0;
            this.laminateMaterial.Text = "Laminate";
            this.laminateMaterial.UseVisualStyleBackColor = true;
            this.laminateMaterial.CheckedChanged += new System.EventHandler(this.laminate);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dayFourteen);
            this.groupBox2.Controls.Add(this.daySeven);
            this.groupBox2.Controls.Add(this.dayFive);
            this.groupBox2.Controls.Add(this.dayThree);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(276, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 122);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "4. Choose Rush Order (in Days)";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dayFourteen
            // 
            this.dayFourteen.AutoSize = true;
            this.dayFourteen.Checked = true;
            this.dayFourteen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayFourteen.Location = new System.Drawing.Point(7, 88);
            this.dayFourteen.Name = "dayFourteen";
            this.dayFourteen.Size = new System.Drawing.Size(202, 21);
            this.dayFourteen.TabIndex = 3;
            this.dayFourteen.TabStop = true;
            this.dayFourteen.Text = "14 (Normal production time)";
            this.dayFourteen.UseVisualStyleBackColor = true;
            this.dayFourteen.CheckedChanged += new System.EventHandler(this.day14);
            // 
            // daySeven
            // 
            this.daySeven.AutoSize = true;
            this.daySeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daySeven.Location = new System.Drawing.Point(7, 65);
            this.daySeven.Name = "daySeven";
            this.daySeven.Size = new System.Drawing.Size(34, 21);
            this.daySeven.TabIndex = 2;
            this.daySeven.TabStop = true;
            this.daySeven.Text = "7";
            this.daySeven.UseVisualStyleBackColor = true;
            this.daySeven.CheckedChanged += new System.EventHandler(this.day7);
            // 
            // dayFive
            // 
            this.dayFive.AutoSize = true;
            this.dayFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayFive.Location = new System.Drawing.Point(7, 42);
            this.dayFive.Name = "dayFive";
            this.dayFive.Size = new System.Drawing.Size(34, 21);
            this.dayFive.TabIndex = 1;
            this.dayFive.TabStop = true;
            this.dayFive.Text = "5";
            this.dayFive.UseVisualStyleBackColor = true;
            this.dayFive.CheckedChanged += new System.EventHandler(this.day5);
            // 
            // dayThree
            // 
            this.dayThree.AutoSize = true;
            this.dayThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayThree.Location = new System.Drawing.Point(7, 20);
            this.dayThree.Name = "dayThree";
            this.dayThree.Size = new System.Drawing.Size(34, 21);
            this.dayThree.TabIndex = 0;
            this.dayThree.TabStop = true;
            this.dayThree.Text = "3";
            this.dayThree.UseVisualStyleBackColor = true;
            this.dayThree.CheckedChanged += new System.EventHandler(this.day3);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(20, 365);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(94, 17);
            this.price.TabIndex = 8;
            this.price.Text = "Price Quote";
            this.price.Click += new System.EventHandler(this.label4_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(20, 405);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(91, 17);
            this.date.TabIndex = 9;
            this.date.Text = "Quote Date";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.deskArea);
            this.groupBox3.Controls.Add(this.deskDepth);
            this.groupBox3.Controls.Add(this.deskWidth);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 59);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 122);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "1. Specify the Size (in inches)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Max 100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(150, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Max 50";
            // 
            // deskArea
            // 
            this.deskArea.AutoSize = true;
            this.deskArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskArea.Location = new System.Drawing.Point(162, 105);
            this.deskArea.Name = "deskArea";
            this.deskArea.Size = new System.Drawing.Size(20, 17);
            this.deskArea.TabIndex = 16;
            this.deskArea.Text = "--";
            // 
            // deskDepth
            // 
            this.deskDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskDepth.Location = new System.Drawing.Point(94, 65);
            this.deskDepth.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.deskDepth.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.deskDepth.Name = "deskDepth";
            this.deskDepth.Size = new System.Drawing.Size(51, 23);
            this.deskDepth.TabIndex = 14;
            this.deskDepth.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // deskWidth
            // 
            this.deskWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskWidth.Location = new System.Drawing.Point(94, 28);
            this.deskWidth.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.deskWidth.Name = "deskWidth";
            this.deskWidth.Size = new System.Drawing.Size(51, 23);
            this.deskWidth.TabIndex = 13;
            this.deskWidth.TabStop = false;
            this.deskWidth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.deskWidth.ValueChanged += new System.EventHandler(this.deskWidth_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Desk Area (sq inches)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.drawerNumber);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 212);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(249, 122);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "2. Choose Numbers of Drawers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Max 7";
            // 
            // drawerNumber
            // 
            this.drawerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerNumber.Location = new System.Drawing.Point(10, 23);
            this.drawerNumber.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawerNumber.Name = "drawerNumber";
            this.drawerNumber.Size = new System.Drawing.Size(43, 23);
            this.drawerNumber.TabIndex = 14;
            this.drawerNumber.ValueChanged += new System.EventHandler(this.drawerNumber_ValueChanged);
            // 
            // clickCalculate
            // 
            this.clickCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickCalculate.Location = new System.Drawing.Point(276, 376);
            this.clickCalculate.Name = "clickCalculate";
            this.clickCalculate.Size = new System.Drawing.Size(168, 34);
            this.clickCalculate.TabIndex = 14;
            this.clickCalculate.Text = "Click to Calculate";
            this.clickCalculate.UseVisualStyleBackColor = true;
            this.clickCalculate.Click += new System.EventHandler(this.clickCalculate_Click);
            // 
            // priceQuote
            // 
            this.priceQuote.AutoSize = true;
            this.priceQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceQuote.Location = new System.Drawing.Point(120, 365);
            this.priceQuote.Name = "priceQuote";
            this.priceQuote.Size = new System.Drawing.Size(20, 17);
            this.priceQuote.TabIndex = 15;
            this.priceQuote.Text = "--";
            this.priceQuote.Click += new System.EventHandler(this.priceQuote_Click);
            // 
            // quoteDate
            // 
            this.quoteDate.AutoSize = true;
            this.quoteDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteDate.Location = new System.Drawing.Point(117, 405);
            this.quoteDate.Name = "quoteDate";
            this.quoteDate.Size = new System.Drawing.Size(20, 17);
            this.quoteDate.TabIndex = 16;
            this.quoteDate.Text = "--";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 476);
            this.Controls.Add(this.quoteDate);
            this.Controls.Add(this.priceQuote);
            this.Controls.Add(this.clickCalculate);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.date);
            this.Controls.Add(this.price);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Mega Escritorio Desktop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deskDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskWidth)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawerNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton pineMaterial;
        private System.Windows.Forms.RadioButton oakMaterial;
        private System.Windows.Forms.RadioButton laminateMaterial;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton dayFourteen;
        private System.Windows.Forms.RadioButton daySeven;
        private System.Windows.Forms.RadioButton dayFive;
        private System.Windows.Forms.RadioButton dayThree;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button clickCalculate;
        private System.Windows.Forms.NumericUpDown deskWidth;
        private System.Windows.Forms.NumericUpDown deskDepth;
        private System.Windows.Forms.NumericUpDown drawerNumber;
        private System.Windows.Forms.Label deskArea;
        private System.Windows.Forms.Label priceQuote;
        private System.Windows.Forms.Label quoteDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

