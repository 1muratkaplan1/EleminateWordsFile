
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace mkEng.SwiftWords
{
 
    public class Utils
    {
        public static String valueS = "|&&";
        public static String valueE = "&&|";
        //public static String valueSearch = "\u0026\u0026";

        public static String endLine = "\n";
        public static String SELECTSRTFILEFROMFOLDER = "SELECT TO SRT FILE FROM FOLDER..........";
        public static String FILLINGTOVECTOR = "FILLING TO VECTOR..........";
        public static String STARTINGTRANSLATE = "STARTING TRANSLATE..........";
        public static String ERRORWHILETRANSLATE = "ERROR WHILE TRANSLATE..........";
        public static String FINISHEDTRANSLATE = "FINISHED TRANSLATE..........";
        public static String ADDFILENAMEENDTEXT = "___UPDATE";
        public static String TASKNAME = "FILLING WORDS VECTOR";

        public static String[] BADWORDS = { };


        public static int TRANSLATEDSENTENCESSIZE = 0;
        public static int TRANSLATEDSENTENCESSIZECOUNTER = 0;

        public static Boolean CHECK_EQ      = false;
        public static Boolean CHECK_IES     = false;
        public static Boolean CHECK_LY      = false;
        public static Boolean CHECK_ING     = false;
        public static Boolean CHECK_S       = false;
        public static Boolean CHECK_ED      = false;
        public static Boolean CHECK_ES      = false;
        public static Boolean CHECK_D       = false;
        public static Boolean CHECK_ER      = false;
        public static Boolean CHECK_EST     = false;
        public static Boolean CHECK_IER     = false;
        public static Boolean CHECK_NESS    = false;
        public static Boolean CHECK_NUMERIC = false;

        public static String[] NATIVE_LANGUAGES = {
            "Afrikaans af"  ,"Albanian sq",     "Arabic ar",    "Belarusian be",
            "Bengali bn"    ,"Bulgarian bg",    "Catalan ca",   "Chinese zh-CN",
            "Czech cs"      ,"Danish da",       "Esperanto eo", "Filipino tl",  "Finnish fi",
            "French fr"     ,"German de",       "Georgian ka",  "Hebrew iw",    "Hindi hi",
            "Hungarian hu"  ,"Indonesian id",   "Irish ga",     "Italian it",   "Japanese ja",
            "Korean ko"     ,"Lao lo",          "Latin la",     "Malay ms",
            "Norwegian no"  ,"Persian fa",      "Polish pl",    "Portuguese pt","Romanian ro",
            "Russian ru"    ,"Serbian sr",      "Spanish es",   "Swedish sv",   "Turkish tr",
            "Ukrainian uk"  ,"Urdu ur",         "Vietnamese vi", "Yiddish yi"   };

        public struct db_row {
            String engWord;
            List<String> nativeWords;
        }

        public static Boolean CHECK_COMPARE = false;

        public static int Min_Char_Size_In_Word = 3;


        public static List<String> m_vtSource = new List<String>();
        public static List<String> m_vtCompWords = new List<String>();
        public static List<String> m_vtCompBadWords = new List<String>();

        public static List<String> m_vtTranslate = new List<String>();
        public static List<String> m_vtNoTranslate = new List<String>();
        public static List<String> m_vtNoSwiftTranslate = new List<String>();

        public static List<String> m_vtWrite = new List<String>();
        public static List<String> lFiles = new List<String>();
        public static List<String> lString = new List<String>();
 
        public static String szSourceWordsFileName  = "";
        public static String szCompWordsFileName    = "";
        public static String szCompBadWordsFileName = "";


        public static string addTextToFileName(String szFileNameOld, String stAddText)
        {
            // Create the file.
            String sFileName = szFileNameOld;
            String fileNameWithoutExtension = Path.GetFileNameWithoutExtension(sFileName);
            String fileExtension = Path.GetExtension(sFileName);
            String filePath = Path.GetDirectoryName(sFileName);
            String newFile = filePath + "\\" + fileNameWithoutExtension + stAddText + fileExtension;
            return newFile;
        }
        public static void ChangeCharFromString(String from, String to, String szString) {
            if (szString.Length!=0 && szString.IndexOf(from) != -1)
            { // Check Foreging Character.....
                szString = szString.Replace(from,to);
            }
        }

        public static bool EleminateVector(List<String> vtSource, List<String> vtWrite) {
            if (vtSource.Capacity != 0)
            {
                try
                {
                    float fStep = 100.0f / vtSource.Count;
                    float percent = 0;

                        // Do not initialize this variable here.
                    CopyVector(vtSource, vtWrite);
                    for (int n = 0; n < vtSource.Count; n++)
                    {
                        bool bAddToVector = false;
                        List<String> deleteList = new List<String>();
                        for (int k = 0; k < vtWrite.Count; k++) {

                            if (vtWrite[k].Length < Min_Char_Size_In_Word) {
                                deleteList.Add(vtWrite[k]); continue;
                            }

                            if (CHECK_NUMERIC)
                            {
                                if (vtWrite[k].Any(char.IsDigit))
                                {
                                    deleteList.Add(vtWrite[k]); continue;
                                }
                            }

                            ChangeCharFromString("é", "e", vtWrite[k]);
                            ChangeCharFromString("é", "e", vtSource[n]);

                            ChangeCharFromString("ó", "o", vtWrite[k]);
                            ChangeCharFromString("ó", "o", vtSource[n]);

                            if (!(vtSource[n][0].Equals(vtWrite[k][0])) ||
                                    !(vtSource[n][1].Equals(vtWrite[k][1]))) {
                                continue;
                            }


                            if (CHECK_EQ) {
                                if (vtSource[n].Trim().Equals(vtWrite[k].Trim())) {
                                    if (!bAddToVector) {
                                        bAddToVector = true; continue;
                                    }
                                    else {
                                        deleteList.Add(vtWrite[k]); continue;
                                    }
                                }
                            }

                            if (CHECK_S) {
                                if ((vtSource[n] + "s").Trim().Equals(vtWrite[k].Trim())) {
                                    deleteList.Add(vtWrite[k]); continue;
                                }
                            }

                            if (CHECK_ES) {
                                if ((vtSource[n] + "es").Trim().Equals(vtWrite[k].Trim())) {
                                    deleteList.Add(vtWrite[k]); continue;
                                }
                            }

                            if (CHECK_LY) {
                                if ((vtSource[n] + "ment").Trim().Equals(vtWrite[k].Trim())) {
                                    deleteList.Add(vtWrite[k]); continue;
                                }
                                if ((vtSource[n] + "ly").Trim().Equals(vtWrite[k].Trim())) {
                                    deleteList.Add(vtWrite[k]); continue;
                                }
                                if (vtSource[n][vtSource[n].Length - 1] == 'e') {
                                    String szTemp = vtSource[n].Remove(vtSource[n].Length - 1);
                                    if ((szTemp + "ly").Trim().Equals(vtWrite[k].Trim())) { // package packging 
                                        deleteList.Add(vtWrite[k]); continue;
                                    }
                                }
                            }
                            if (CHECK_ER)
                            {
                                if ((vtSource[n] + "er").Trim().Equals(vtWrite[k].Trim()))
                                {
                                    deleteList.Add(vtWrite[k]); continue;
                                }
                                if (vtSource[n][vtSource[n].Length - 1] == 'e')
                                {
                                    String szTemp = vtSource[n].Remove(vtSource[n].Length - 1);
                                    if ((szTemp + "er").Trim().Equals(vtWrite[k].Trim())) //unstable unstabler
                                    {  
                                        deleteList.Add(vtWrite[k]); continue;
                                    }
                                }
                            }
                            if (CHECK_EST)
                            {
                                if ((vtSource[n] + "est").Trim().Equals(vtWrite[k].Trim()))
                                {
                                    deleteList.Add(vtWrite[k]); continue;
                                }
                                if (vtSource[n][vtSource[n].Length - 1] == 'e')
                                {
                                    String szTemp = vtSource[n].Remove(vtSource[n].Length - 1);
                                    if ((szTemp + "est").Trim().Equals(vtWrite[k].Trim())) //unstable unstabler
                                    {
                                        deleteList.Add(vtWrite[k]); continue;
                                    }
                                }
                            }
                            if (CHECK_IER)
                            {
                                if ((vtSource[n] + "ier").Trim().Equals(vtWrite[k].Trim()))
                                {
                                    deleteList.Add(vtWrite[k]); continue;
                                }
                                if (vtSource[n][vtSource[n].Length - 1] == 'i' || vtSource[n][vtSource[n].Length - 1] == 'e')
                                {
                                    String szTemp = vtSource[n].Remove(vtSource[n].Length - 1);
                                    if ((szTemp + "ier").Trim().Equals(vtWrite[k].Trim())) //unstable unstabler
                                    {
                                        deleteList.Add(vtWrite[k]); continue;
                                    }
                                }
                                if (vtSource[n][vtSource[n].Length - 1] == 'r' || vtSource[n][vtSource[n].Length - 1] == 't'
                                    || vtSource[n][vtSource[n].Length - 1] == 'p' || vtSource[n][vtSource[n].Length - 1] == 'd')
                                {
                                    if ((vtSource[n] + vtSource[n][vtSource[n].Length - 1] + "ier").Trim().Equals(vtWrite[k].Trim()))
                                    { // zippier zip
                                        deleteList.Add(vtWrite[k]); continue;
                                    }
                                }
                            }
                            if (CHECK_NESS)
                            {
                                if ((vtSource[n] + "ness").Trim().Equals(vtWrite[k].Trim()))
                                {
                                    deleteList.Add(vtWrite[k]); continue;
                                }
                                if (vtSource[n][vtSource[n].Length - 1] == 'n')
                                {
                                    String szTemp = vtSource[n].Remove(vtSource[n].Length - 1);
                                    if ((szTemp + "ness").Trim().Equals(vtWrite[k].Trim())) //unstable unstabler
                                    {
                                        deleteList.Add(vtWrite[k]); continue;
                                    }
                                }
                            }
                            if (CHECK_ED) {
                                if ((vtSource[n] + "ed").Trim().Equals(vtWrite[k].Trim())) {
                                    deleteList.Add(vtWrite[k]); continue;
                                }
                                if (vtSource[n][vtSource[n].Length - 1] == 'e') {
                                    String szTemp = vtSource[n].Remove(vtSource[n].Length - 1);
                                    if ((szTemp + "ed").Trim().Equals(vtWrite[k].Trim())){ //unstable unstabled 
                                        deleteList.Add(vtWrite[k]); continue;
                                    }
                                }
                                if (vtSource[n][vtSource[n].Length - 1] == 'r' || vtSource[n][vtSource[n].Length - 1] == 't'
                                    || vtSource[n][vtSource[n].Length - 1] == 'p' || vtSource[n][vtSource[n].Length - 1] == 'd')
                                {// abhorred zipped
                                    if ((vtSource[n] + vtSource[n][vtSource[n].Length - 1] + "ed").Trim().Equals(vtWrite[k].Trim()))
                                    { // package packging 
                                        deleteList.Add(vtWrite[k]); continue;
                                    }
                                }
                                if (vtSource[n][vtSource[n].Length - 1] == 'y') { //try --->tried
                                    String szTemp = vtSource[n].Remove(vtSource[n].Length - 1);
                                    if ((szTemp + "ied").Trim().Equals(vtWrite[k].Trim()))
                                    { // package packging 
                                        deleteList.Add(vtWrite[k]); continue;
                                    }
                                }
                            }

                            if (CHECK_IES) {
                                if (vtSource[n][vtSource[n].Length - 1] == 'y') {
                                    String szTemp = vtSource[n].Remove(vtSource[n].Length - 1);
                                    if ((szTemp + "ies").Trim().Equals(vtWrite[k].Trim()))
                                    { // package packging 
                                        deleteList.Add(vtWrite[k]); continue;
                                    }
                                }
                            }

                            if (CHECK_ING) {
                                if ((vtSource[n] + "ing").Trim().Equals(vtWrite[k].Trim()) ||  // painting
                                        (vtSource[n] + vtSource[n][vtSource[n].Length - 1] + "ing").Equals(vtWrite[k])) { // 
                                    deleteList.Add(vtWrite[k]); continue;
                                }
                                if (vtSource[n][vtSource[n].Length - 1] == 'e') {
                                    String szTemp = vtSource[n].Remove(vtSource[n].Length - 1);
                                    if ((szTemp + "ing").Trim().Equals(vtWrite[k].Trim())) { // package packging 
                                        deleteList.Add(vtWrite[k]); continue;
                                    }
                                }
                            }
                        }

                        for (int tt = 0; tt < deleteList.Count; tt++) {
                            vtWrite.Remove(deleteList[tt]);
                        }
                        percent += fStep;
                        Program.DOUBLESRT_CLASS_FORM.ProgressStep((int)percent);
                    }
                }
                catch
                {
                    return false;
                }

            }

            return true;
        }


        public static bool CompareWords(List<String> vtSourceWords,
                                        List<String> vtCompWords,
                                        List<String> vtResultWords)
        {
            if (!CHECK_COMPARE || vtSourceWords.Capacity == 0 || 
                szCompWordsFileName.Length==0) {
                return false;
            }

            if (vtCompWords.Capacity == 0) {
                return false;
            }

            CopyVector(vtSourceWords, vtResultWords);

            float fStep = 100.0f / vtCompWords.Count;
            float percent = 0;

            for (int n = 0; n < vtCompWords.Count; n++)
            {
                List<String> deleteList = new List<String>();
                for (int k = 0; k < vtResultWords.Count; k++)
                {
                    String stSource = vtResultWords[k].ToLower();
                    String stComp = vtCompWords[n].ToLower();

                    if (stSource.Trim().Equals(stComp.Trim()))
                    {
                        vtResultWords.RemoveAt(k);
                    }
                }
                percent += fStep;
                Program.DOUBLESRT_CLASS_FORM.ProgressStep((int)percent);
            }
            return true;
        }

        public static bool CopyVector(List<String> vtsource, List<String> vtDest) {
            if (vtsource.Count != 0)
            {
                for (int n = 0; n < vtsource.Count; n++)
                {
                    vtDest.Add(vtsource[n].ToLower());
                }
            }else { return false; }
            return true;
        }

        public static float CalculateLineFromFile(String szFileName) {
            Stream stream = File.Open(szFileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader reader = new StreamReader(stream);
            float step = 100.0f / reader.ReadToEnd().Split(new char[] { '\n' }).Length ;
            stream.Close();
            reader.Close();
            return step;
        }
        public static bool FillVector(string szFileName, List<String> vtWords)
        {
            if (szFileName.Length == 0 && !File.Exists(szFileName)) {
                return false;
            }

            if (vtWords.Count != 0) { 
                vtWords.Clear();
            }

            String line = "";
            try
            {
                Stream stream = File.Open(szFileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                StreamReader reader = new StreamReader(stream);
                float fStep = CalculateLineFromFile(szFileName);
                float percent = 0;
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    if (line.Length != 0 && line[0] != ';') {
                        if (line.Length > 3) {
                            if (line[0] == '\xEF' && line[1] == '\xBB' && line[2] == '\xBF') {
                                line.Remove('\xEF'); line.Remove('\xBB'); line.Remove('\xBF');
                            }
                        }
                        if (line.Contains("\t"))
                        {
                            string[] split = line.Split('\t');
                            if (split.Length != 0)
                            {
                                for (int n = 0; n < split.Length; n++)
                                {
                                    vtWords.Add(split[n].ToLower());
                                }
                            }
                        }else
                        {
                            vtWords.Add(line);                   
                        }
                    }
                    percent += fStep;
                    Program.DOUBLESRT_CLASS_FORM.ProgressStep((int)percent);

                }
                stream.Close();
                reader.Close();
                return true;
            }
            catch (Exception c)
            {
                MessageBox.Show(line);
                Console.WriteLine("The process failed: {0}______{1}", c.ToString(),line);
                return false;
            }
        }


        public static bool WriteVectorToFile(String szFileName, List<String> vtWrite)
        {
            if (szFileName.Length == 0 || vtWrite.Count == 0) {
                return false;
            }

            float fStep = 100.0f / vtWrite.Count;
            float percent = 0;

            String newFile = addTextToFileName(szFileName, ADDFILENAMEENDTEXT);
            if (File.Exists(newFile)){
                File.Delete(newFile);
            }

            using (Stream stream = File.OpenWrite(newFile))
            using (var fs = new StreamWriter(stream, new UTF8Encoding(true)))
            {
                foreach (String line in vtWrite)
                {
                    fs.Write(line);
                    fs.Write(Utils.endLine);
                    percent += fStep;
                    Program.DOUBLESRT_CLASS_FORM.ProgressStep((int)percent);
                }
                fs.Close();
                
            }
            return true;
        }
        public static bool CreateTranslateVector(List<String> vtSource,String szNativeLang,Boolean bDontWorkProgress=false,Boolean bCompare=true)
        {
            Translator t = new Translator();
            int nCharSize = 0, nItem = 1, nMaxCharSize = 4300;
            String sFile = "";
            float fStep = 100.0f / vtSource.Count;
            float percent = 0;

            foreach (String pSub in vtSource)
            {
                nCharSize += pSub.Length + 2;
                sFile += valueS + pSub + valueE + endLine;

                if (nCharSize > nMaxCharSize || nItem == vtSource.Count)
                {
                    nCharSize = 0;
                    String szTranslate = "";
                    szTranslate += t.Translate(sFile, "English", szNativeLang);
                    Thread.Sleep(100);
                    if (szTranslate.Length == 0){
                        return false;
                    }else{
                        if (!SplitTranslateSentences(szTranslate, sFile, bCompare)){
                            return false;
                        }
                    }
                    sFile = "";
                    if (!bDontWorkProgress){
                        percent += fStep;
                        Program.DOUBLESRT_CLASS_FORM.ProgressStep((int)percent);
                    }
                }
                nItem++;
            }

            return true;
        }
        public static String SiftWord(String szText)
        {
            if (szText.Length != 0)
            {
                szText = szText.Replace(valueS, "")
                                 .Replace(valueE, "")
                                 .Replace(endLine, "");
                return szText;
            }
            return "";

        }
        public static bool SplitTranslateSentences(String szTransAfter,String szTransBefore,Boolean bCompare=true)
        {
            var json = szTransAfter;
            if (szTransAfter.Length != 0)
            {
                var root = (JContainer)JToken.Parse(json);
                if (root.HasValues)
                {
                    var parent = (JContainer)root[0];
                    if (parent.HasValues)
                    {
                        string szTur = "", szEng = "";
                        bool bAddList = false;

                        foreach (var child in parent)
                        {
                            string szTurTmp = child[0].ToString();
                            string szEngTmp = child[1].ToString();

                            if (szTurTmp.Length > 0)
                            {
                                if (!szEngTmp.Contains(valueS) && !szEngTmp.Contains(valueE))
                                {
                                    szTur += szTurTmp;
                                    szEng += szEngTmp;
                                }
                                else if ((!szEngTmp.Contains(valueS) && szEngTmp.Contains(valueE)) ||
                                            (szEngTmp.Contains(valueS) && !szEngTmp.Contains(valueE)))
                                {
                                    szTur += szTurTmp;
                                    szEng += szEngTmp;
                                    if (szEngTmp.Contains(valueE))
                                    {
                                        bAddList = true;
                                    }
                                }
                                else if (szEngTmp.Contains(valueS) && szEngTmp.Contains(valueE))
                                {
                                    szTur = szTurTmp;
                                    szEng = szEngTmp;
                                    bAddList = true;
                                }
                            }
                            if (bAddList)
                            {
                                bAddList = false;

                                szTur = SiftWord(szTur);
                                szEng = SiftWord(szEng);

                                if (!szEng.Contains("|") && szTur.Contains("|"))
                                {
                                    szTur = szTur.Replace("|", "");
                                }
                                if (!szEng.Contains("&&") && szTur.Contains("&&"))
                                {
                                    szTur = szTur.Replace("&&", "");
                                }
                                if (!szEng.Contains("&") && szTur.Contains("&"))
                                {
                                    szTur = szTur.Replace("&", "");
                                }

                                for (int n = 0; n < szTur.Length; n++)
                                {
                                    if (szTur[0] == (' '))
                                    {
                                        szTur = szTur.Substring(1, szTur.Length - 1);
                                    }
                                    if (szTur[szTur.Length - 1] == (' '))
                                    {
                                        szTur = szTur.Substring(0, szTur.Length - 1);
                                    }
                                }

                                szTur = szTur.ToLower();
                                szEng = szEng.ToLower();

                                if (bCompare)
                                {
                                    if (szEng.Contains(szTur) || szTur.Contains(szEng) || szTur.Trim().Equals(szEng.Trim()))
                                    {
                                        m_vtNoTranslate.Add(szEng);

                                    }
                                    else
                                    {
                                        m_vtTranslate.Add(szTur);
                                    }
                                }
                                else {
                                    m_vtTranslate.Add(szTur);
                                }

                                m_vtNoSwiftTranslate.Add(szTur);


                                szTur = "";
                                szEng = "";
                            }
                        }
                    }
                }
            }

            return true;
        }
        public static String getDBFileName(String szFileName) {
            return Utils.addTextToFileName(szFileName, "DB");
        }
        public static Boolean AddRowToDBFile(String szFileName,String szRow) {
            if (!File.Exists(getDBFileName(szFileName))) {

                using (Stream stream = File.OpenWrite(getDBFileName(szFileName)))
                using (var fs = new StreamWriter(stream, new UTF8Encoding(true)))
                {
                    fs.Write(szRow);
                    fs.Write(Utils.endLine);
                    fs.Close();
                }
            }else
            {
                using (var fs = new StreamWriter(getDBFileName(szFileName), append:true))
                {
                    fs.Write(szRow);
                    fs.Write(Utils.endLine);
                    fs.Close();
                }
            }
            return true;
        }
        public static int FindStartNumber(String szFileName, List<String> vtWords) {

            if (File.Exists(szFileName))
            {
                var data = File.ReadAllLines(szFileName);

                for (int k = 1; k < data.Length; k++)
                {
                    String line = data[data.Length - k];
                    if (line.Length != 0 && line[0] != ';')
                    {
                        if (line.Length > 3)
                        {
                            if (line[0] == '\xEF' && line[1] == '\xBB' && line[2] == '\xBF')
                            {
                                line.Remove('\xEF'); line.Remove('\xBB'); line.Remove('\xBF');
                            }
                        }
                        if (line.Contains("\t"))
                        {
                            string[] split = line.Split('\t');
                            if (split.Length != 0)
                            {
                                for (int n = 0; n < vtWords.Count; n++)
                                {
                                    if (split[0].Trim().Equals(vtWords[n]))
                                    {
                                        if ((n + 1) < vtWords.Count)
                                        {
                                            return n + 1;
                                        }
                                        else
                                        {
                                            return -1;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return 0;
        }
    }
}
