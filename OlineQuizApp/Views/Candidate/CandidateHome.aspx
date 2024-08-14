<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Candidate/CandidateMaster.Master" AutoEventWireup="true" CodeBehind="CandidateHome.aspx.cs" Inherits="OlineQuizApp.Views.Candidate.CandidateHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   <style>
        body{
            background-image: url("../../Assests/Images/1.jpg");
            background-size: cover;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="row" style="height:100px;">

    </div>
    <div class="row">
        <div class="col bg-light border-top-2 border-bottom-2">
            <div class="row pt-3 pb-3">
                <div class="col-2"></div>
                <div class="col-2"><label class="form-label text-center text-success h4">Select Your Quiz</label></div>
                <div class="col-4"><asp:DropDownList ID="QuiznameTb" class="form-control" runat="server"></asp:DropDownList></div>
                <div class="col-4">
                    <asp:Button ID="SubmitBtn" runat="server" Text="Submit" class="btn btn-success" OnClick="SubmitBtn_Click" /></div>
            </div>
            <div>                
            </div>

        </div>
    </div>
</asp:Content>
