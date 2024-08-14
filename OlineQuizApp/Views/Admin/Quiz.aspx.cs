using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace OlineQuizApp.Views.Admin
{
    public partial class Quiz : System.Web.UI.Page
    {
        Models.Functions con;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new Models.Functions();
            ShowQuix();
        }
        private void ShowQuix()
        {
            string query = "select QId as ID,Qname as QuizName, QQtNbr as Quantity, QMarksByAnswer as QuestionMarks from QuizTbl";
            Quizlist.DataSource = con.GetData(query);
            Quizlist.DataBind();
        }
        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
            string quiz = QuizTb.Value;
            int quet = int.Parse(QuestTb.Value);
            int answer = int.Parse(AnsByQuestTb.Value);
            if (quet > 0 && answer > 0){ 
            string query = string.Format("INSERT INTO QuizTbl (Qname, QQtNbr, QMarksByAnswer) VALUES ('{0}', '{1}', '{2}')", quiz, quet, answer);
            con.SetData(query);
            errmsg.InnerText = "Quiz Added!!!";
            QuizTb.Value = string.Empty;
            QuestTb.Value = string.Empty;
            AnsByQuestTb.Value = string.Empty;
            ShowQuix();
            }
            else
            {
                    errmsg.InnerText = "Enter Valid Value!!!";
             }

            }
            catch (Exception ex)
            {
                errmsg.InnerText = ex.Message;
            }
            
        }

        protected void Quizlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuizTb.Value = Quizlist.SelectedRow.Cells[2].Text;
            QuestTb.Value = Quizlist.SelectedRow.Cells[3].Text;
            AnsByQuestTb.Value = Quizlist.SelectedRow.Cells[4].Text;
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string quiz = QuizTb.Value;
                int quet = int.Parse(QuestTb.Value);
                int answer = int.Parse(AnsByQuestTb.Value);
                if (quet >0 && answer >0)
                {
                string query = string.Format("UPDATE QuizTbl set Qname= '{0}', QQtNbr = '{1}', QMarksByAnswer = '{2}' where QId = '{3}'", quiz, quet, answer, Quizlist.SelectedRow.Cells[1].Text);
                con.SetData(query);
                errmsg.InnerText = "Quiz Updated!!!";
                QuizTb.Value = string.Empty;
                QuestTb.Value = string.Empty;
                AnsByQuestTb.Value = string.Empty;
                ShowQuix();

                }
                else
                {
                    errmsg.InnerText = "Enter Valid Value!!!";
                }
            }
            catch (Exception ex)
            {
                errmsg.InnerText = ex.Message;
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string quiz = QuizTb.Value;
                int quet = int.Parse(QuestTb.Value);
                int answer = int.Parse(AnsByQuestTb.Value);
                    string query = string.Format(" Delete from QuizTbl where QId = '{0}'", Quizlist.SelectedRow.Cells[1].Text);
                    con.SetData(query);
                    errmsg.InnerText = "Quiz Deleted!!!";
                    QuizTb.Value = string.Empty;
                    QuestTb.Value = string.Empty;
                    AnsByQuestTb.Value = string.Empty;
                    ShowQuix();
            }
            catch (Exception ex)
            {
                errmsg.InnerText = ex.Message;
            }
        }
    }
}