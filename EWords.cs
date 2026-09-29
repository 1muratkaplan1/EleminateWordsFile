// Copyright (c) 2010 mk-Engineering
// License: Code Project Open License


using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using AForge.Imaging;

namespace mkEng.SwiftWords
{

    //static SpeechRecognitionEngine _recognizer = null;
    //static ManualResetEvent manualResetEvent = null;


    /// <summary>
    /// A sample application to demonstrate the <see cref="TranslatorOld"/> class.
    /// </summary>
    public partial class EleminateWordsFrm : Form
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleSRTFrm"/> class.
        /// </summary>
        public EleminateWordsFrm()
        {
            InitializeComponent();
        }

        #endregion

        #region Form event handlers

        /// <summary>
        /// Handles the Load event of the GoogleTranslatorFrm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void GoogleTranslatorFrm_Load
            (object sender,
             EventArgs e)
        {
            this.comboBox1.Items.AddRange(Translator.Languages.ToArray());
            this.comboBox1.SelectedItem = "Turkish";
            label3.Text = "Turkish";
        }

        #endregion

        #region Button handlers

        /// <summary>
        /// Handles the LinkClicked event of the _lnkSourceEnglish control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void _lnkSourceEnglish_LinkClicked
            (object sender,
             LinkLabelLinkClickedEventArgs e)
        {

        }

        /// <summary>
        /// Handles the LinkClicked event of the _lnkTargetEnglish control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void _lnkTargetEnglish_LinkClicked
            (object sender,
             LinkLabelLinkClickedEventArgs e)
        {
        }

        /// <summary>
        /// Handles the Click event of the _btnTranslate control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void _btnTranslate_Click
            (object sender,
             EventArgs e)
        {
            System.Drawing.Bitmap sourceImage = (Bitmap)Bitmap.FromFile(@"d:\My Downloads\search.jpg");
            System.Drawing.Bitmap template = (Bitmap)Bitmap.FromFile(@"d:\My Downloads\search_image.jpg");
            // create template matching algorithm's instance
            // (set similarity threshold to 92.5%)
            
            ExhaustiveTemplateMatching tm = new ExhaustiveTemplateMatching(0.921f);
            // find all matchings with specified above similarity

            TemplateMatch[] matchings = tm.ProcessImage(sourceImage, template);
            // highlight found matchings

            BitmapData data = sourceImage.LockBits(
                 new Rectangle(0, 0, sourceImage.Width, sourceImage.Height),
                 ImageLockMode.ReadWrite, sourceImage.PixelFormat);
            foreach (TemplateMatch m in matchings)
            {

                Drawing.Rectangle(data, m.Rectangle, Color.Red);

                MessageBox.Show(m.Rectangle.Location.ToString());
                // do something else with matching
            }
            sourceImage.UnlockBits(data);

            //AboutBox1 settingsForm = new AboutBox1();
            //settingsForm.Show();
            ////AboutBox1 about; 

        }

        /// <summary>
        /// Handles the Click event of the _btnSpeak control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void _btnSpeak_Click
            (object sender,
             EventArgs e)
        {
        }

        /// <summary>
        /// Handles the LinkClicked event of the _lnkReverse control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void _lnkReverse_LinkClicked
            (object sender,
             LinkLabelLinkClickedEventArgs e)
        {
            // Swap translation mode

            // Reset text
            //this._editSourceText.Text = this._editTarget.Text;
            //this._editTarget.Text = string.Empty;
            this.Update();
            this._translationSpeakUrl = string.Empty;
        }

        #endregion

        #region Fields

        /// <summary>
        /// The URL used to speak the translation.
        /// </summary>
        private string _translationSpeakUrl;
        public static int percent = 0;
        OpenFileDialog openDialog = new OpenFileDialog();

        private bool GetOpenDialog(TextBox mtext)
        {
            openDialog.Title = "Select A File";
            openDialog.Filter = "Text Files (*.TXT)|*.txt";
            if (openDialog.ShowDialog() == DialogResult.OK) {
                mtext.Text = openDialog.FileName;
                mtext.Refresh();
                return true;
            }
            else {
                MessageBox.Show("PLease choose SRT Files!!!!.....");
                return false;
            }
        }

        private void setUtilsInit() {
            Utils.CHECK_EQ                  = checkBoxEqCheck.Checked;
            Utils.CHECK_IES                 = checkBoxIesCheck.Checked;
            Utils.CHECK_LY                  = checkBoxLyCheck.Checked;
            Utils.CHECK_ING                 = checkBoxIngCheck.Checked;
            Utils.CHECK_S                   = checkBoxSCheck.Checked;
            Utils.CHECK_ED                  = checkBoxEdCheck.Checked;
            Utils.CHECK_ES                  = checkBoxEsCheck.Checked;
            Utils.CHECK_D                   = checkBoxDCheck.Checked;
            Utils.CHECK_ER                  = checkBoxErCheck.Checked;
            Utils.CHECK_EST                 = checkBoxEstCheck.Checked;
            Utils.CHECK_IER                 = checkBoxIerCheck.Checked;
            Utils.CHECK_NESS                = checkBoxNessCheck.Checked;
            Utils.CHECK_NUMERIC             = checkNumeric.Checked;

            Utils.CHECK_COMPARE             = checkBoxVerb.Checked;
            Utils.Min_Char_Size_In_Word     = Int32.Parse(m_MinCharSizeInWord.Text) + 1;
            Utils.szSourceWordsFileName     = m_FileName.Text;
            Utils.szCompWordsFileName       = m_FileNameComp.Text;
            Utils.szCompBadWordsFileName    = textBox1.Text;

        }
        private bool Calculate()
        {
            if (m_FileName.Text.Length == 0) {
                return false;
            }
            setUtilsInit();

            Utils.TASKNAME = "FILLING WORDS VECTOR";
            ProgressStep(0);
            if (!Utils.FillVector(m_FileName.Text, Utils.m_vtSource)) {
                Utils.TASKNAME = "MAIN WORDS CREATE VECTOR PROBLEM";
                Thread.Sleep(1000);
                return false;
            }

            if (checkBoxBadWords.Checked)
            {
                Utils.TASKNAME = "FILLING BAD WORDS VECTOR";
                ProgressStep(0);
                if (!Utils.FillVector(textBox1.Text, Utils.m_vtCompBadWords))
                {
                    Utils.TASKNAME = "BAD WORDS CREATE VECTOR PROBLEM";
                    Thread.Sleep(1000);
                    return false;
                }

                ProgressStep(0);
                Utils.TASKNAME = "REMOVING BAD WORDS FROM VECTOR";
                if (!Utils.CompareWords(Utils.m_vtSource, Utils.m_vtCompBadWords, Utils.m_vtWrite))
                {
                    Utils.TASKNAME = "REMOVING BAD WORDS PROBLEM";
                    Thread.Sleep(1000);
                }
                CopyWriteToSourceVectorAndClear();
            }

            if (checkBoxVerb.Checked)
            {
                Utils.TASKNAME = "FILLING VERB VECTOR";
                ProgressStep(0);
                if (!Utils.FillVector(m_FileNameComp.Text, Utils.m_vtCompWords))
                {
                    Utils.TASKNAME = "VERB CREATE VECTOR PROBLEM";
                    Thread.Sleep(1000);
                    return false;
                }

                ProgressStep(0);
                Utils.TASKNAME = "COMPARE VERB VECTOR";
                if (!Utils.CompareWords(Utils.m_vtSource, Utils.m_vtCompWords, Utils.m_vtWrite))
                {
                    Utils.TASKNAME = "VERB FILL VECTOR PROBLEM";
                    Thread.Sleep(1000);
                }
                CopyWriteToSourceVectorAndClear();
            }

            Utils.TASKNAME = "ELEMINATION";
            ProgressStep(0);
            if (!Utils.EleminateVector(Utils.m_vtSource, Utils.m_vtWrite))
            {
                Utils.TASKNAME = "ELEMINATION PROBLEM";
                Thread.Sleep(1000);
            }

            if (checkBoxTranslate.Checked)
            {
                Utils.TASKNAME = "TRANSLATION";
                ProgressStep(0);
                if (!Utils.CreateTranslateVector(Utils.m_vtWrite, comboBox1.GetItemText(comboBox1.SelectedItem))){
                    Utils.TASKNAME = "NO TRANSLATION VECTOR";
                    Thread.Sleep(1000);
                }
                else
                {
                    CopyWriteToSourceVectorAndClear();

                    Utils.TASKNAME = "WRITE TO FILE TRANSLATION VECTOR";
                    ProgressStep(0);
                    if (!Utils.WriteVectorToFile((Path.GetFullPath(m_FileName.Text)) + "/" + "TRANSLATIONVECTOR.txt", Utils.m_vtTranslate))
                    {
                        Utils.TASKNAME = "TRANSLATION VECTOR WRTITE TO FILE ERROR";
                        Thread.Sleep(1000);
                    }
                    if (!Utils.WriteVectorToFile((Path.GetFullPath(m_FileName.Text)) + "/" + "NOTRANSLATIONVECTOR.txt", Utils.m_vtNoTranslate))
                    {
                        Utils.TASKNAME = "NO TRANSLATION VECTOR WRTITE TO FILE ERROR";
                        Thread.Sleep(1000);
                    }
                    if (!Utils.WriteVectorToFile((Path.GetFullPath(m_FileName.Text))+"/" + "NOSWIFTTRANSLATIONVECTOR.txt", Utils.m_vtNoSwiftTranslate))
                    {
                        Utils.TASKNAME = "NO SWIFT TRANSLATION VECTOR WRTITE TO FILE ERROR";
                        Thread.Sleep(1000);
                    }

                    ProgressStep(0);
                    Utils.TASKNAME = "COMPARE VERB VECTOR";
                    if (!Utils.CompareWords(Utils.m_vtSource, Utils.m_vtNoTranslate, Utils.m_vtWrite))
                    {
                        Utils.TASKNAME = "VERB FILL VECTOR PROBLEM";
                        Thread.Sleep(1000);
                    }
                }
            }
             
            Utils.TASKNAME = "WRITE TO FILE";
            ProgressStep(0);
            if (!Utils.WriteVectorToFile(m_FileName.Text, Utils.m_vtWrite))
            {
                return false;
            }
            ProgressStep(0);

            return true;
        }
        private void CopyWriteToSourceVectorAndClear() {
            Utils.m_vtSource.Clear();
            Utils.CopyVector(Utils.m_vtWrite, Utils.m_vtSource);
            Utils.m_vtWrite.Clear();
        }
        private void button1_Click(object sender, EventArgs e){
            if (!GetOpenDialog(m_FileName)){
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e){
            //start "work"
            percent = 0;
            //timer1.Enabled = true;
            button2.Enabled = false;
            Calculate();
            MessageBox.Show("Complete!!!!.....");
            button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!GetOpenDialog(textBox1))
            {
                return;
            }
            if (textBox1.Text.Length == 0)
            {
                return;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVerb.Checked)
            {
                m_FileNameComp.Enabled = true;
                button4.Enabled = true;
            }
            else
            {
                m_FileNameComp.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!GetOpenDialog(m_FileNameComp)){
                return;
            }

            if (m_FileNameComp.Text.Length == 0){
                return;
            }
        }


        public void ProgressStep(int percent)
        {
//            percent++;
            String szText = Utils.TASKNAME + "   " + percent;
            ShowScreen(szText);
            if (progressBar1.InvokeRequired)
            {
                progressBar1.BeginInvoke(new Action(() => progressBar1.Value = percent));
            }
            else
            {
                progressBar1.Value = percent;
            }
        }
        public void ShowScreen(string szText)
        {
            label4.Text = szText;
            label4.Refresh();
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
 
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.comboBox1.SelectedItem = "Turkish";

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTranslate.Checked)
            {
                label3.Enabled = true;
                comboBox1.Enabled = true;
            }
            else
            {
                label3.Enabled = false;
                comboBox1.Enabled = false;
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBadWords.Checked)
            {
                textBox1.Enabled = true;
                button3.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
                button3.Enabled = false;
            }

        }

        private void checkBoxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSelectAll.Checked)
            {
                checkBoxEqCheck.Checked = true;
                checkBoxIesCheck.Checked = true;
                checkBoxLyCheck.Checked = true;
                checkBoxIngCheck.Checked = true;
                checkBoxSCheck.Checked = true;
                checkBoxEdCheck.Checked = true;
                checkBoxEsCheck.Checked = true;
                checkBoxDCheck.Checked = true;
                checkBoxErCheck.Checked = true;
                checkBoxEstCheck.Checked = true;
                checkBoxIerCheck.Checked = true;
                checkBoxNessCheck.Checked = true;
                checkNumeric.Checked = true;
            }
            else
            {
                checkBoxEqCheck.Checked = false;
                checkBoxIesCheck.Checked = false;
                checkBoxLyCheck.Checked = false;
                checkBoxIngCheck.Checked = false;
                checkBoxSCheck.Checked = false;
                checkBoxEdCheck.Checked = false;
                checkBoxEsCheck.Checked = false;
                checkBoxDCheck.Checked = false;
                checkBoxErCheck.Checked = false;
                checkBoxEstCheck.Checked = false;
                checkBoxIerCheck.Checked = false;
                checkBoxNessCheck.Checked = false;
                checkNumeric.Checked = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Utils.TASKNAME = "FILLING WORDS VECTOR";
            ProgressStep(0);
            String newFile = Utils.addTextToFileName(m_FileName.Text, Utils.ADDFILENAMEENDTEXT);

            if (!File.Exists(newFile)){
                MessageBox.Show("Database file not found");
                return;
            }

            if (!Utils.FillVector(newFile, Utils.m_vtSource))
            {
                Utils.TASKNAME = "MAIN WORDS CREATE VECTOR PROBLEM";
                Thread.Sleep(1000);
                return ;
            }

            float fStep = 100.0f / (Utils.m_vtSource.Count);
            float percent = 0;
            ProgressStep(0);

            Utils.TASKNAME = "PREPARE FOR TRANSLATION";
            int nStartNumber = Utils.FindStartNumber(Utils.getDBFileName(m_FileName.Text),Utils.m_vtSource);
            if (nStartNumber > 0) {
                Utils.AddRowToDBFile(m_FileName.Text, "\t");
            }else if (nStartNumber == -1){
                MessageBox.Show("DB File is Ready");
            }

            Utils.TASKNAME = "STARING TRANSLATION";
            int nNumber = 1;
            for (int k = nStartNumber; k < Utils.m_vtSource.Count; k++)
            {
                String szRow = Utils.m_vtSource[k]+'\t';
                Utils.m_vtWrite.Add(Utils.m_vtSource[k]);
                for (int n = 0; n < Utils.NATIVE_LANGUAGES.Length; n++)
                {
                    string[] split = Utils.NATIVE_LANGUAGES[n].Split(' ');
                    if (split[0].Length == 0){
                        continue;
                    }

                    Utils.TASKNAME = Utils.m_vtSource[k] + " " + (k + 1) +
                                        " number translation eng to " + Utils.NATIVE_LANGUAGES[n] +
                                        " " + ((int)percent);
                    percent = fStep * k;
                    ProgressStep((int)percent);

                    if (!Utils.CreateTranslateVector(Utils.m_vtWrite, split[0], true,false))
                    {
                        Utils.TASKNAME = "NO TRANSLATION VECTOR";
                        //continue;
                        if (nNumber > 2)
                        {
                            continue;
                        }
                        Thread.Sleep(1000 * 3600);
                        nNumber++;
                    }

                    if (Utils.m_vtTranslate.Count > 0)
                    {
                        szRow += Utils.m_vtTranslate[0] + '\t';
                        Utils.m_vtTranslate.Clear();
                    }
                    else
                    {
                        //Thread.Sleep(1000 * 3600 * 1); // Rest 1 hours....
                        //k--;
                        continue;
                    } 
                }

                Utils.m_vtWrite.Clear();
                Utils.AddRowToDBFile(m_FileName.Text,szRow);
            }
        }
    }
    #endregion

}
