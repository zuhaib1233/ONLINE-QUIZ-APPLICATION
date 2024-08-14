<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Questions.aspx.cs" Inherits="OlineQuizApp.Views.Admin.Questions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-3">
                <h5 class="text-center text-danger">Manage Questions</h5>
                <div class="mb-1">
                    <label for="QuiznameTb" class="form-label">Quiz</label>
                    <asp:DropDownList ID="QuiznameTb" class="form-control" runat="server"></asp:DropDownList>
                </div>
                <div class="mb-1">
                    <label for="QuestTb" class="form-label">Question</label>
                    <input type="text" class="form-control" id="QuestTb" runat="server" required="required"/>
                </div>
                <div class="mb-1">
                    <label for="Ans1Tb" class="form-label">Option 1</label>
                    <input type="text" class="form-control" id="Ans1Tb" runat="server" autocomplete="off" required="required"/>
                </div>
                <div class="mb-1">
                    <label for="Ans2Tb" class="form-label">Option 2</label>
                    <input type="text" class="form-control" id="Ans2Tb" runat="server" autocomplete="off" required="required" />
                </div>
                <div class="mb-1">
                    <label for="Ans3Tb" class="form-label">Option 3</label>
                    <input type="text" class="form-control" id="Ans3Tb" runat="server" autocomplete="off" required="required" />
                </div>
                <div class="mb-1">
                    <label for="Ans4Tb" class="form-label">Option 4</label>
                    <input type="text" class="form-control" id="Ans4Tb" runat="server" autocomplete="off" required="required" />
                </div>
                <div class="mb-1">
                    <label for="CorrectTb" class="form-label">Correct Option</label>
                    <input type="text" class="form-control" id="CorrectTb" runat="server" autocomplete="off" required="required" />
                </div>
                <div class="row">
                    <label id="errmsg" runat="server" class="text-danger"></label>
                    <div class="col d-grid mb-3">
                        <asp:Button ID="EditBtn" runat="server" Text="Edit" CssClass="btn btn-warning btn-block" OnClick="EditBtn_Click" />
                    </div>
                    <div class="col d-grid mb-3">
                        <asp:Button ID="SaveBtn" runat="server" Text="Save" CssClass="btn btn-primary btn-block" OnClick="SaveBtn_Click" />
                    </div>
                    <div class="col d-grid mb-3">
                        <asp:Button ID="DeleteBtn" runat="server" Text="Delete" CssClass="btn btn-danger btn-block" OnClick="DeleteBtn_Click" />
                    </div>
                </div>
            </div>
            <div class="col-md-9">
                <h3 class="text-danger text-center">Questions List</h3>
                <asp:GridView ID="Questionslist" runat="server" CssClass="table row-cols-4" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" AutoGenerateSelectButton="True" OnSelectedIndexChanged="Questionslist_SelectedIndexChanged">
                    <AlternatingRowStyle BackColor="White"></AlternatingRowStyle>
                    <EditRowStyle BackColor="#2461BF"/>
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White"></FooterStyle>
                    <HeaderStyle BackColor="#ff4444" Font-Bold="True" ForeColor="White"></HeaderStyle>
                    <PagerStyle HorizontalAlign="Center" BackColor="#2461BF" ForeColor="White"></PagerStyle>
                    <RowStyle BackColor="#EFF3FB"/>
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="333333"></SelectedRowStyle>
                    <SortedAscendingCellStyle BackColor="#F1F1F1"></SortedAscendingCellStyle>
                    <SortedAscendingHeaderStyle BackColor="#808080"></SortedAscendingHeaderStyle>
                    <SortedDescendingCellStyle BackColor="#F5F7FB"></SortedDescendingCellStyle>
                    <SortedDescendingHeaderStyle BackColor="#6D95E1"></SortedDescendingHeaderStyle>
                </asp:GridView>
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
