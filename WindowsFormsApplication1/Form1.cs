using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class frmMain : Form
    {

        private object path = "C:\\data\\temp.docx";
        private object saveAs = "C:\\data\\test.docx";

        public frmMain()
        {
            InitializeComponent();
        }

        private void buttongenerate_Click(object sender, EventArgs e)
        {
            string jobName = textbox.Text.Trim();//trimming spaces off front and rear
            if (InputGood(jobName))
            {
                lblStatus.Text = "Generating";
                if (Generate(jobName, path))
                    lblStatus.Text = "Generateion Complete";
                else
                    lblStatus.Text = "Generation Failed";                
            }
            else
            {
                lblStatus.Text = "Check input.";
                return; // bail out
            }

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

      
        private bool InputGood(string s)
        {
            return s.Trim().Length > 0;    //we are returning whether the number of characters is greater than 0
        }


        public bool Generate(string text, object path)
        {
            bool success = false;// default to failed
            object missing = System.Reflection.Missing.Value;
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document aDoc = null;
            if(File.Exists((string)path))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;
                aDoc = wordApp.Documents.Open(ref path, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref isVisible, ref missing, ref missing, ref missing, ref missing);
                aDoc.Activate();

                //replace text
                ReplaceText(wordApp, "<jobname>", text);


            }
            else
            {
                MessageBox.Show("File Does Not Exist");
                return success; 
            }

            aDoc.SaveAs(ref saveAs, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
            success = true;

            aDoc.Close(ref missing, ref missing, ref missing);    


            return success;
        }


        public static void ReplaceText(Microsoft.Office.Interop.Word.Application app, Object findMe, Object replaceMe)
        {

            try
            {
                object replaceAll = true;
                object missing = System.Reflection.Missing.Value;
                app.Application.Selection.Find.ClearFormatting();
                app.Application.Selection.Find.Text = (string)findMe;
                app.Application.Selection.Find.Replacement.ClearFormatting();


                if (replaceMe.ToString().Length < 250) // Normal execution
                {
                    app.Application.Selection.Find.Replacement.Text = (string)replaceMe;
                    app.Application.Selection.Find.Execute(
                    ref missing, ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing, ref missing,
                    ref replaceAll, ref missing, ref missing, ref missing, ref missing);
                }

                else  // Some real simple logic!!
                {
                    app.Application.Selection.Find.Execute(
                    ref findMe, ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing, ref missing);

                    // the area where the findMe is located in the Document is selected.
                    // Hence when you execute the statement below the replaceMe string is
                    // placed in the area selected, which is what we wanted!
                    app.Application.Selection.Text = (string)replaceMe;
                }
            }

            catch (Exception ex)
            {

            }
        }

        private void textbox_Enter(object sender, EventArgs e)
        {
            textbox.Text = string.Empty;
        }

    }

}
