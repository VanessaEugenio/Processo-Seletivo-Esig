<%@ Page Language="C#" MasterPageFile="~/CRUD2.master" AutoEventWireup="true" CodeBehind="ListarPessoas.aspx.cs" Inherits="PS_Esig.ListarPessoas" EnableEventValidation="false" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="font-size: medium; font-style: normal" align="center">Processo Seletivo</h1>
    <image src="images/esigS.png" />

    <table id="tblForm" cellspacing="0" cellpadding="0" width="100%" border="0">


        <tr>
            <td height="100%" align="center">
                <div style="margin-top: 10px">
                    <asp:Label ID="Label3" runat="server" Text="LISTAR" BorderColor="#666666" Width="100%" BorderStyle="None" Font-Bold="True" Font-Size="18px" ForeColor="White" BackColor="#666666" Visible="True"></asp:Label>
                </div>
            </td>
        </tr>

    </table>


</asp:Content>
<asp:Content ID="content1" ContentPlaceHolderID="cphGrid" runat="server">

    <form runat="server">
        <div style="margin-left: 200px; margin-top: 190px">
            <asp:GridView AutoGenerateColumns="False"
                AllowPaging="True"
                OnPageIndexChanging="grvLista_PageIndexChanging"
                EnableModelValidation="True"
                runat="server" ID="grvLista" CssClass="table table-bordered table-striped" GridLines="Both" ShowHeaderWhenEmpty="True" EmptyDataText="Não foram encontrados resultados" Width="100%" OnRowCommand="grvLista_RowCommand" DataKeyNames="Pessoa_ID">
                <Columns>

                    <asp:BoundField HeaderText="ID" DataField="Pessoa_ID" />
                    <asp:BoundField HeaderText="Nome" DataField="Nome" />
                    <asp:BoundField HeaderText="Vencimento" DataField="Salario_Bruto" />
                    <asp:BoundField HeaderText="Descontos" DataField="Descontos" />
                    <asp:BoundField HeaderText="Líquido" DataField="Salario_Liquido" />

                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="BtnAlterar" runat="server" Text="✏️" CommandName="Alterar" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Pessoa_ID").ToString() %>' />
                        </ItemTemplate>
                        <HeaderTemplate>
                            Editar
                        </HeaderTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="BtnExcluir" runat="server" Text="X" CommandName="Excluir" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Pessoa_ID").ToString() %>' />
                        </ItemTemplate>
                        <HeaderTemplate>
                            Excluir
                        </HeaderTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="BtnRecalcular" runat="server" Text="Recalcular" CommandName="Recalcular" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Pessoa_ID").ToString() %>' />
                        </ItemTemplate>
                        <HeaderTemplate>
                            Recalcular
                        </HeaderTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="BtnCCheque" runat="server" Text="Contra-Cheque" CommandName="C_Cheque" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Pessoa_ID").ToString() %>' />
                        </ItemTemplate>
                        <HeaderTemplate>
                            Contra-Cheque
                        </HeaderTemplate>
                    </asp:TemplateField>

                </Columns>
                <HeaderStyle Font-Size="Large" HorizontalAlign="Center" />
                <PagerStyle Font-Size="Smaller" />
                <RowStyle Font-Size="Medium" HorizontalAlign="Center" />
                <PagerSettings Position="Top" Mode="NextPreviousFirstLast"
                    PreviousPageText="<img src='images/setEsquerda.png' border='0' title='Página Anterior'/>"
                    NextPageText="<img src='images/setDireita.png' border='0' title='Próxima Página'/>"
                    FirstPageText="<img src='images/setEsquerda.png' border='0' title='Primeira Página'/>"
                    LastPageText="<img src='images/setDireita.png' border='0' title='Última Página'/>" PageButtonCount="15" />


            </asp:GridView>
            <div style="margin-left: 0px; margin-top: 15px">
                <asp:Button ID="BtnRecalcular" runat="server" Text="Recalcular geral" OnClick="BtnRecalcular_Click" Visible="false" />
            </div>
        </div>

        <div style="margin-top: -550px; margin-left: 1400px;">
            <asp:ImageButton ID="BtnVoltar" runat="server" AlternateText="CADASTRAR" ImageUrl="images/returnLaranja.png" OnClick="BtnVoltar_Click"></asp:ImageButton>

        </div>
    </form>
</asp:Content>





