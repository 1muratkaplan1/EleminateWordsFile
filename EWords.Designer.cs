namespace mkEng.SwiftWords
{
    partial class EleminateWordsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EleminateWordsFrm));
            this.label2 = new System.Windows.Forms.Label();
            this._btnTranslate = new System.Windows.Forms.Button();
            this.m_FileName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBoxEqCheck = new System.Windows.Forms.CheckBox();
            this.checkBoxIesCheck = new System.Windows.Forms.CheckBox();
            this.checkBoxLyCheck = new System.Windows.Forms.CheckBox();
            this.checkBoxIngCheck = new System.Windows.Forms.CheckBox();
            this.checkBoxSCheck = new System.Windows.Forms.CheckBox();
            this.checkBoxEdCheck = new System.Windows.Forms.CheckBox();
            this.checkBoxDCheck = new System.Windows.Forms.CheckBox();
            this.checkBoxEsCheck = new System.Windows.Forms.CheckBox();
            this.m_MinCharSizeInWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxVerb = new System.Windows.Forms.CheckBox();
            this.m_FileNameComp = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxSelectAll = new System.Windows.Forms.CheckBox();
            this.checkNumeric = new System.Windows.Forms.CheckBox();
            this.checkBoxNessCheck = new System.Windows.Forms.CheckBox();
            this.checkBoxEstCheck = new System.Windows.Forms.CheckBox();
            this.checkBoxIerCheck = new System.Windows.Forms.CheckBox();
            this.checkBoxErCheck = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBoxTranslate = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxBadWords = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Words text file";
            // 
            // _btnTranslate
            // 
            this._btnTranslate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnTranslate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnTranslate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnTranslate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnTranslate.Location = new System.Drawing.Point(14, 12);
            this._btnTranslate.Name = "_btnTranslate";
            this._btnTranslate.Size = new System.Drawing.Size(107, 28);
            this._btnTranslate.TabIndex = 13;
            this._btnTranslate.Text = "About Me";
            this._btnTranslate.UseVisualStyleBackColor = false;
            this._btnTranslate.Click += new System.EventHandler(this._btnTranslate_Click);
            // 
            // m_FileName
            // 
            this.m_FileName.Location = new System.Drawing.Point(13, 89);
            this.m_FileName.Name = "m_FileName";
            this.m_FileName.Size = new System.Drawing.Size(417, 21);
            this.m_FileName.TabIndex = 14;
            this.m_FileName.Text = "d://My Downloads//mWordDataBase//Words_Basic//words_Basic.txt";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(430, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "....";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(374, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 28);
            this.button2.TabIndex = 25;
            this.button2.Text = "Compute";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBoxEqCheck
            // 
            this.checkBoxEqCheck.AutoSize = true;
            this.checkBoxEqCheck.Checked = true;
            this.checkBoxEqCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEqCheck.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEqCheck.Location = new System.Drawing.Point(11, 75);
            this.checkBoxEqCheck.Name = "checkBoxEqCheck";
            this.checkBoxEqCheck.Size = new System.Drawing.Size(84, 17);
            this.checkBoxEqCheck.TabIndex = 17;
            this.checkBoxEqCheck.Text = "Equal Check";
            this.checkBoxEqCheck.UseVisualStyleBackColor = true;
            // 
            // checkBoxIesCheck
            // 
            this.checkBoxIesCheck.AutoSize = true;
            this.checkBoxIesCheck.Checked = true;
            this.checkBoxIesCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIesCheck.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIesCheck.Location = new System.Drawing.Point(99, 98);
            this.checkBoxIesCheck.Name = "checkBoxIesCheck";
            this.checkBoxIesCheck.Size = new System.Drawing.Size(71, 17);
            this.checkBoxIesCheck.TabIndex = 18;
            this.checkBoxIesCheck.Text = "ies Check";
            this.checkBoxIesCheck.UseVisualStyleBackColor = true;
            // 
            // checkBoxLyCheck
            // 
            this.checkBoxLyCheck.AutoSize = true;
            this.checkBoxLyCheck.Checked = true;
            this.checkBoxLyCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLyCheck.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLyCheck.Location = new System.Drawing.Point(185, 75);
            this.checkBoxLyCheck.Name = "checkBoxLyCheck";
            this.checkBoxLyCheck.Size = new System.Drawing.Size(109, 17);
            this.checkBoxLyCheck.TabIndex = 19;
            this.checkBoxLyCheck.Text = "Ly && Ment Check ";
            this.checkBoxLyCheck.UseVisualStyleBackColor = true;
            // 
            // checkBoxIngCheck
            // 
            this.checkBoxIngCheck.AutoSize = true;
            this.checkBoxIngCheck.Checked = true;
            this.checkBoxIngCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIngCheck.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIngCheck.Location = new System.Drawing.Point(100, 75);
            this.checkBoxIngCheck.Name = "checkBoxIngCheck";
            this.checkBoxIngCheck.Size = new System.Drawing.Size(72, 17);
            this.checkBoxIngCheck.TabIndex = 20;
            this.checkBoxIngCheck.Text = "ing Check";
            this.checkBoxIngCheck.UseVisualStyleBackColor = true;
            // 
            // checkBoxSCheck
            // 
            this.checkBoxSCheck.AutoSize = true;
            this.checkBoxSCheck.Checked = true;
            this.checkBoxSCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSCheck.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSCheck.Location = new System.Drawing.Point(11, 99);
            this.checkBoxSCheck.Name = "checkBoxSCheck";
            this.checkBoxSCheck.Size = new System.Drawing.Size(63, 17);
            this.checkBoxSCheck.TabIndex = 21;
            this.checkBoxSCheck.Text = "s Check";
            this.checkBoxSCheck.UseVisualStyleBackColor = true;
            // 
            // checkBoxEdCheck
            // 
            this.checkBoxEdCheck.AutoSize = true;
            this.checkBoxEdCheck.Checked = true;
            this.checkBoxEdCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEdCheck.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEdCheck.Location = new System.Drawing.Point(185, 99);
            this.checkBoxEdCheck.Name = "checkBoxEdCheck";
            this.checkBoxEdCheck.Size = new System.Drawing.Size(70, 17);
            this.checkBoxEdCheck.TabIndex = 22;
            this.checkBoxEdCheck.Text = "ed Check";
            this.checkBoxEdCheck.UseVisualStyleBackColor = true;
            // 
            // checkBoxDCheck
            // 
            this.checkBoxDCheck.AutoSize = true;
            this.checkBoxDCheck.Checked = true;
            this.checkBoxDCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDCheck.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDCheck.Location = new System.Drawing.Point(296, 75);
            this.checkBoxDCheck.Name = "checkBoxDCheck";
            this.checkBoxDCheck.Size = new System.Drawing.Size(64, 17);
            this.checkBoxDCheck.TabIndex = 23;
            this.checkBoxDCheck.Text = "d Check";
            this.checkBoxDCheck.UseVisualStyleBackColor = true;
            // 
            // checkBoxEsCheck
            // 
            this.checkBoxEsCheck.AutoSize = true;
            this.checkBoxEsCheck.Checked = true;
            this.checkBoxEsCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEsCheck.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEsCheck.Location = new System.Drawing.Point(296, 99);
            this.checkBoxEsCheck.Name = "checkBoxEsCheck";
            this.checkBoxEsCheck.Size = new System.Drawing.Size(69, 17);
            this.checkBoxEsCheck.TabIndex = 24;
            this.checkBoxEsCheck.Text = "es Check";
            this.checkBoxEsCheck.UseVisualStyleBackColor = true;
            // 
            // m_MinCharSizeInWord
            // 
            this.m_MinCharSizeInWord.Location = new System.Drawing.Point(375, 96);
            this.m_MinCharSizeInWord.Name = "m_MinCharSizeInWord";
            this.m_MinCharSizeInWord.Size = new System.Drawing.Size(81, 21);
            this.m_MinCharSizeInWord.TabIndex = 27;
            this.m_MinCharSizeInWord.Text = "2";
            this.m_MinCharSizeInWord.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.m_MinCharSizeInWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Min Char Cap.";
            // 
            // checkBoxVerb
            // 
            this.checkBoxVerb.AutoSize = true;
            this.checkBoxVerb.Checked = true;
            this.checkBoxVerb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxVerb.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxVerb.Location = new System.Drawing.Point(10, 128);
            this.checkBoxVerb.Name = "checkBoxVerb";
            this.checkBoxVerb.Size = new System.Drawing.Size(104, 18);
            this.checkBoxVerb.TabIndex = 29;
            this.checkBoxVerb.Text = "Compare Verb";
            this.checkBoxVerb.UseVisualStyleBackColor = true;
            this.checkBoxVerb.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // m_FileNameComp
            // 
            this.m_FileNameComp.Location = new System.Drawing.Point(131, 128);
            this.m_FileNameComp.Name = "m_FileNameComp";
            this.m_FileNameComp.Size = new System.Drawing.Size(299, 21);
            this.m_FileNameComp.TabIndex = 30;
            this.m_FileNameComp.Text = "d://My Downloads//mWordDataBase//Verb_Basic//english verb.txt";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(430, 126);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 23);
            this.button4.TabIndex = 31;
            this.button4.Text = "....";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxSelectAll);
            this.groupBox1.Controls.Add(this.checkNumeric);
            this.groupBox1.Controls.Add(this.checkBoxNessCheck);
            this.groupBox1.Controls.Add(this.checkBoxEstCheck);
            this.groupBox1.Controls.Add(this.checkBoxIerCheck);
            this.groupBox1.Controls.Add(this.checkBoxErCheck);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.m_MinCharSizeInWord);
            this.groupBox1.Controls.Add(this.checkBoxEsCheck);
            this.groupBox1.Controls.Add(this.checkBoxDCheck);
            this.groupBox1.Controls.Add(this.checkBoxEdCheck);
            this.groupBox1.Controls.Add(this.checkBoxSCheck);
            this.groupBox1.Controls.Add(this.checkBoxIngCheck);
            this.groupBox1.Controls.Add(this.checkBoxLyCheck);
            this.groupBox1.Controls.Add(this.checkBoxIesCheck);
            this.groupBox1.Controls.Add(this.checkBoxEqCheck);
            this.groupBox1.Location = new System.Drawing.Point(10, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 121);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Swift Properties";
            // 
            // checkBoxSelectAll
            // 
            this.checkBoxSelectAll.AutoSize = true;
            this.checkBoxSelectAll.Checked = true;
            this.checkBoxSelectAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSelectAll.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSelectAll.Location = new System.Drawing.Point(11, 20);
            this.checkBoxSelectAll.Name = "checkBoxSelectAll";
            this.checkBoxSelectAll.Size = new System.Drawing.Size(69, 17);
            this.checkBoxSelectAll.TabIndex = 36;
            this.checkBoxSelectAll.Text = "Select All";
            this.checkBoxSelectAll.UseVisualStyleBackColor = true;
            this.checkBoxSelectAll.CheckedChanged += new System.EventHandler(this.checkBoxSelectAll_CheckedChanged);
            // 
            // checkNumeric
            // 
            this.checkNumeric.AutoSize = true;
            this.checkNumeric.Checked = true;
            this.checkNumeric.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkNumeric.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNumeric.Location = new System.Drawing.Point(375, 52);
            this.checkNumeric.Name = "checkNumeric";
            this.checkNumeric.Size = new System.Drawing.Size(99, 17);
            this.checkNumeric.TabIndex = 35;
            this.checkNumeric.Text = "Numeric Check ";
            this.checkNumeric.UseVisualStyleBackColor = true;
            // 
            // checkBoxNessCheck
            // 
            this.checkBoxNessCheck.AutoSize = true;
            this.checkBoxNessCheck.Checked = true;
            this.checkBoxNessCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNessCheck.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNessCheck.Location = new System.Drawing.Point(296, 52);
            this.checkBoxNessCheck.Name = "checkBoxNessCheck";
            this.checkBoxNessCheck.Size = new System.Drawing.Size(83, 17);
            this.checkBoxNessCheck.TabIndex = 35;
            this.checkBoxNessCheck.Text = "ness Check ";
            this.checkBoxNessCheck.UseVisualStyleBackColor = true;
            // 
            // checkBoxEstCheck
            // 
            this.checkBoxEstCheck.AutoSize = true;
            this.checkBoxEstCheck.Checked = true;
            this.checkBoxEstCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEstCheck.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEstCheck.Location = new System.Drawing.Point(100, 52);
            this.checkBoxEstCheck.Name = "checkBoxEstCheck";
            this.checkBoxEstCheck.Size = new System.Drawing.Size(73, 17);
            this.checkBoxEstCheck.TabIndex = 34;
            this.checkBoxEstCheck.Text = "est Check";
            this.checkBoxEstCheck.UseVisualStyleBackColor = true;
            // 
            // checkBoxIerCheck
            // 
            this.checkBoxIerCheck.AutoSize = true;
            this.checkBoxIerCheck.Checked = true;
            this.checkBoxIerCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIerCheck.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIerCheck.Location = new System.Drawing.Point(185, 52);
            this.checkBoxIerCheck.Name = "checkBoxIerCheck";
            this.checkBoxIerCheck.Size = new System.Drawing.Size(73, 17);
            this.checkBoxIerCheck.TabIndex = 33;
            this.checkBoxIerCheck.Text = "ier Check ";
            this.checkBoxIerCheck.UseVisualStyleBackColor = true;
            // 
            // checkBoxErCheck
            // 
            this.checkBoxErCheck.AutoSize = true;
            this.checkBoxErCheck.Checked = true;
            this.checkBoxErCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxErCheck.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxErCheck.Location = new System.Drawing.Point(11, 52);
            this.checkBoxErCheck.Name = "checkBoxErCheck";
            this.checkBoxErCheck.Size = new System.Drawing.Size(68, 17);
            this.checkBoxErCheck.TabIndex = 32;
            this.checkBoxErCheck.Text = "er Check";
            this.checkBoxErCheck.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-7, 393);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(492, 18);
            this.progressBar1.TabIndex = 33;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // checkBoxTranslate
            // 
            this.checkBoxTranslate.AutoSize = true;
            this.checkBoxTranslate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTranslate.Location = new System.Drawing.Point(10, 200);
            this.checkBoxTranslate.Name = "checkBoxTranslate";
            this.checkBoxTranslate.Size = new System.Drawing.Size(174, 18);
            this.checkBoxTranslate.TabIndex = 29;
            this.checkBoxTranslate.Text = "Check words its translated ";
            this.checkBoxTranslate.UseVisualStyleBackColor = true;
            this.checkBoxTranslate.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.CausesValidation = false;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(184, 199);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(246, 21);
            this.comboBox1.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(427, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Turkish";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(-5, 371);
            this.label4.MinimumSize = new System.Drawing.Size(485, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(485, 19);
            this.label4.TabIndex = 35;
            this.label4.Text = "Turkish";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxBadWords
            // 
            this.checkBoxBadWords.AutoSize = true;
            this.checkBoxBadWords.Checked = true;
            this.checkBoxBadWords.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBadWords.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBadWords.Location = new System.Drawing.Point(10, 167);
            this.checkBoxBadWords.Name = "checkBoxBadWords";
            this.checkBoxBadWords.Size = new System.Drawing.Size(122, 18);
            this.checkBoxBadWords.TabIndex = 29;
            this.checkBoxBadWords.Text = "Check Bad Words";
            this.checkBoxBadWords.UseVisualStyleBackColor = true;
            this.checkBoxBadWords.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 21);
            this.textBox1.TabIndex = 30;
            this.textBox1.Text = "d://My Downloads//mWordDataBase//BadWords//badwords.txt";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(430, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "....";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(261, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 28);
            this.button5.TabIndex = 36;
            this.button5.Text = "Create DB";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // EleminateWordsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.m_FileNameComp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBoxVerb);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBoxBadWords);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.m_FileName);
            this.Controls.Add(this._btnTranslate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxTranslate);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 450);
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "EleminateWordsFrm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eleminate Words";
            this.Load += new System.EventHandler(this.GoogleTranslatorFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _btnTranslate;
        private System.Windows.Forms.TextBox m_FileName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBoxEqCheck;
        private System.Windows.Forms.CheckBox checkBoxIesCheck;
        private System.Windows.Forms.CheckBox checkBoxLyCheck;
        private System.Windows.Forms.CheckBox checkBoxIngCheck;
        private System.Windows.Forms.CheckBox checkBoxSCheck;
        private System.Windows.Forms.CheckBox checkBoxEdCheck;
        private System.Windows.Forms.CheckBox checkBoxDCheck;
        private System.Windows.Forms.CheckBox checkBoxEsCheck;
        private System.Windows.Forms.TextBox m_MinCharSizeInWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxVerb;
        private System.Windows.Forms.TextBox m_FileNameComp;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxEstCheck;
        private System.Windows.Forms.CheckBox checkBoxIerCheck;
        private System.Windows.Forms.CheckBox checkBoxErCheck;
        private System.Windows.Forms.CheckBox checkBoxNessCheck;
        private System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBoxTranslate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkNumeric;
        private System.Windows.Forms.CheckBox checkBoxBadWords;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBoxSelectAll;
        private System.Windows.Forms.Button button5;
    }
}