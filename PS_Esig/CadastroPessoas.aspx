<%@ Page Language="C#" MasterPageFile="~/CRUD2.master" AutoEventWireup="true" CodeBehind="CadastroPessoas.aspx.cs" Inherits="PS_Esig.CadastroPessoas" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="font-size: medium; font-style: normal" align="center">Processo Seletivo</h1>
    <image src="images/esigS.png" />

    <form runat="server">
        <table id="tblForm" cellspacing="0" cellpadding="0" width="100%" border="0">
            <tr>
                <td height="100%">
                    <div style="margin-top: 10px">
                        <asp:Button ID="BtnCadastrar" runat="server" Text="CADASTRAR" OnClick="BtnCadastrar_Click" Width="100%"  Font-Bold="True" Font-Italic="True" Font-Size="14px" Height="50px" />
                    </div>
                </td>
            </tr>

            <tr>
                <td height="100%">
                    <div style="margin-top: 10px">
                        <asp:Button ID="BtnListar" runat="server" Text="LISTAR" OnClick="BtnListar_Click" Width="100%" Font-Bold="True" Font-Italic="True" Font-Size="14px" Height="50px"/>
                    </div>
                </td>
            </tr>

           <%-- <tr>
                <td height="100%">
                    <div style="margin-top: 10px">
                        <asp:Button ID="Button3" runat="server" Text="Button" Width="100%" Font-Bold="True" Font-Italic="True" Font-Size="14px" Height="50px"/>
                    </div>
                </td>
            </tr>--%>
        </table>
    </form>
</asp:Content>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <h1 style="font-size: medium; font-style: normal" align="center"> Sel_Es</h1>
</asp:Content>--%>








