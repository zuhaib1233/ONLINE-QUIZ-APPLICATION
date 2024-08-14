using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace OlineQuizApp.Views.Candidate
{
    public partial class Test : System.Web.UI.Page
    {
        Models.Functions con;
        static int i =0 ;
        int quiz = CandidateHome.QId;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new Models.Functions();
            if (!IsPostBack)
            {
               
                Get_question();
                i = 1;
            }

        }
        int c;
        static int score = 0;
        private void correct()
        {
            if (Ans1Rb.Checked)
            {
                c = 1;
            }
            else if (Ans2Rb.Checked)
            {
                c = 2;
            }
            else if (Ans3Rb.Checked)
            {
                c = 3;
            }
            else if (Ans4Rb.Checked)
            {
                c = 4;
            }

        }

        private void inserttest()
        {
            try
            {
                int candidate = Login.CandId;
                int quiz = CandidateHome.QId; 
                string query = "INSERT INTO TestTbl VALUES ({0}, {1}, '{2}',{3})";
                query = string.Format(query, candidate,quiz,System.DateTime.Now.Date,score);
                con.SetData(query);
                //errmsg.InnerText = candidate + ""+ quiz;
            }
            catch (Exception ex)
            {
                errmsg.InnerText = ex.Message;
            }
        }

       
        private void Next_question()
        {
            string query = string.Format("select * from QuestionTbl where Quiz={0}",quiz);
            DataTable Questions = con.GetData(query);
            int questnumber = Questions.Rows.Count;
            if (i < questnumber)
            {
                if (Ans1Rb.Checked || Ans2Rb.Checked || Ans3Rb.Checked || Ans4Rb.Checked)
                {
                    QuesTb.InnerText = Questions.Rows[i][2].ToString();
                    Ans1Lb1.InnerText = Questions.Rows[i][3].ToString();
                    Ans2Lb1.InnerText = Questions.Rows[i][4].ToString();
                    Ans3Lb1.InnerText = Questions.Rows[i][5].ToString();
                    Ans4Lb1.InnerText = Questions.Rows[i][6].ToString();
                    correct();
                    if (c == int.Parse(Questions.Rows[i][7].ToString()))
                    {
                        score+=1;
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                    
                    if (questnumber == i)
                    {
                        SubmitButton1.Text = "Submit";
                    }
                    Ans1Rb.Checked = false;
                    Ans2Rb.Checked = false;
                    Ans3Rb.Checked = false;
                    Ans4Rb.Checked = false;
                    
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('No Answer Selected')", true);
                }
            }
            else
            {
                Label1.InnerText = " you got "+score + " Marks out of " + questnumber;
                inserttest();
                questnumber = 0;
            }
        }
        private void Get_question()
        {
            string query = "select * from QuestionTbl";
            DataTable Questions = con.GetData(query);
            int questnumber = Questions.Rows.Count;
            if (i < questnumber)
            {
                QuesTb.InnerText = Questions.Rows[i][2].ToString();
                Ans1Lb1.InnerText = Questions.Rows[i][3].ToString();
                Ans2Lb1.InnerText = Questions.Rows[i][4].ToString();
                Ans3Lb1.InnerText = Questions.Rows[i][5].ToString();
                Ans4Lb1.InnerText = Questions.Rows[i][6].ToString();
                i++;
            }
        }
       
        protected void Button1_Click(object sender, EventArgs e)
        {
            Next_question();
        }
        private void Previous_question()
        {
            // pending
        }
        protected void backButton_Click(object sender, EventArgs e)
        {
            Previous_question();
        }
    }
}