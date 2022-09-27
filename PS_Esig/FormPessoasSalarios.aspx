<%@ Page Language="C#" MasterPageFile="~/CRUD2.master" AutoEventWireup="true" CodeBehind="FormPessoasSalarios.aspx.cs" Inherits="PS_Esig.FormPessoasSalarios" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="font-size: medium; font-style: normal" align="center">Processo Seletivo</h1>
    <image src="images/esigS.png" />

    <table id="tblForm" cellspacing="0" cellpadding="0" width="100%" border="0">
        <tr>
            <td height="100%" align="center">
                <div style="margin-top: 10px">
                    <asp:Label ID="Label2" runat="server" Text="CADASTRAR" BorderColor="#666666" Width="100%" BorderStyle="None" Font-Bold="True" Font-Size="18px" ForeColor="White" BackColor="#666666"></asp:Label>
                </div>
            </td>
        </tr>

      

    </table>


</asp:Content>


<asp:Content ID="Content1" ContentPlaceHolderID="cphFiltros" runat="server" Visible="true">
    <form runat="server">
        <table id="tblForm1" cellspacing="0" cellpadding="0" width="100%" border="0">
            <%--  Nome e email--%>
            <tr>
                <td height="100%">
                    <div style="margin-top: -500px; margin-left: 190px;">
                        <asp:Label ID="LblNome" runat="server" Text="Nome" Font-Bold="True"></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td height="100%">
                    <div style="margin-top: -480px; margin-left: 190px;">
                        <asp:TextBox ID="TextNome" runat="server" Width="30%"></asp:TextBox>
                    </div>
                </td>
            </tr>

            <tr>
                <td height="100%">
                    <div style="margin-top: -500px; margin-left: 600px;">
                        <asp:Label ID="LblEmail" runat="server" Text="Email" Font-Bold="True"></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td height="100%">
                    <div style="margin-top: -480px; margin-left: 600px;">
                        <asp:TextBox ID="TextEmail" runat="server" Width="30%"></asp:TextBox>
                    </div>
                </td>
            </tr>

            <%--  Telefone e Data de nascimento--%>
            <tr>
                <td height="100%">
                    <div style="margin-top: -500px; margin-left: 900px;">
                        <asp:Label ID="LblFone" runat="server" Text="Telefone" Font-Bold="True"></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td height="100%">
                    <div style="margin-top: -480px; margin-left: 900px;">
                        <asp:TextBox ID="TextFone" runat="server" Width="30%"></asp:TextBox>
                        
                    </div>
                </td>
            </tr>

            <tr>
                <td height="100%">
                    <div style="margin-top: -500px; margin-left: 1100px;">
                        <asp:Label ID="LblDataNasc" runat="server" Text="Data de Nascimento" Font-Bold="True"></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td height="100%">
                    <div style="margin-top: -480px; margin-left: 1100px;">
                        <asp:TextBox ID="TextDataNasci" runat="server" Width="40%"></asp:TextBox>
                    </div>
                </td>
            </tr>

            <%--  Endereço e Cep--%>
            <tr>
                <td height="100%">
                    <div style="margin-top: -450px; margin-left: 190px;">
                        <asp:Label ID="LblEndereco" runat="server" Text="Endereço, Nº" Font-Bold="True"></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td height="100%">
                    <div style="margin-top: -430px; margin-left: 190px;">
                        <asp:TextBox ID="TextEndereco" runat="server" Width="20%"></asp:TextBox>
                    </div>
                </td>
            </tr>

            <tr>
                <td height="100%">
                    <div style="margin-top: -450px; margin-left: 480px;">
                        <asp:Label ID="LblCep" runat="server" Text="CEP" Font-Bold="True"></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td height="100%">
                    <div style="margin-top: -430px; margin-left: 480px;">
                        <asp:TextBox ID="TextCep" runat="server" Width="20%"></asp:TextBox>
                    </div>
                </td>
            </tr>

            <%--  País e Cidade--%>
            <tr>
                <td height="100%">
                    <div style="margin-top: -450px; margin-left: 700px;">
                        <asp:Label ID="LblPais" runat="server" Text="País" Font-Bold="True"></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td height="100%">
                    <div style="margin-top: -430px; margin-left: 700px;">
                        <asp:TextBox ID="TextPais" runat="server" Width="20%"></asp:TextBox>
                    </div>
                </td>
            </tr>

            <tr>
                <td height="100%">
                    <div style="margin-top: -450px; margin-left: 880px;">
                        <asp:Label ID="LblCidade" runat="server" Text="Cidade" Font-Bold="True"></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td height="100%">
                    <div style="margin-top: -430px; margin-left: 880px;">
                        <asp:TextBox ID="TextCidade" runat="server" Width="20%"></asp:TextBox>
                    </div>
                </td>
            </tr>

            <%--  Cargo e Usuário--%>
            <tr>
                <td height="100%">
                    <div style="margin-top: -500px; margin-left: 1270px;">
                        <asp:Label ID="LblCargo" runat="server" Text="Cargo" Font-Bold="True"></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td height="100%">
                    <div style="margin-top: -480px; margin-left: 1270px;">
                        <asp:DropDownList ID="DListCargo" runat="Server" Width="60%" Height="100%">
                            <asp:ListItem Text="Estagiario" Value="1" />
                            <asp:ListItem Text="Tecnico" Value="2" />
                            <asp:ListItem Text="Analista" Value="3" />
                            <asp:ListItem Text="Coordenador" Value="4" />
                            <asp:ListItem Text="Gerente" Value="5" />
                        </asp:DropDownList>
                    </div>
                </td>
            </tr>

            <tr>
                <td height="100%">
                    <div style="margin-top: -400px; margin-left: 190px;">
                        <asp:Label ID="LblUsuario" runat="server" Text="Usuario" Font-Bold="True"></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td height="100%">
                    <div style="margin-top: -370px; margin-left: 190px;">
                        <asp:TextBox ID="TextUsuario" runat="server" Width="20%"></asp:TextBox>
                    </div>
                </td>
            </tr>

            <%--  Botão cadstrar--%>

            <tr>
                <td height="100%">
                    <div style="margin-top: -370px; margin-left: 1150px;">
                        <asp:Button ID="BtnCalcular" runat="server" Text="CALCULAR" OnClick="BtnCalcular_Click" Width="30%" Height="30px" BorderStyle="Groove" BorderColor="White" Font-Italic="True" Font-Bold="True"></asp:Button>
                    </div>
                </td>
            </tr>


            <tr>
                <td height="100%">
                    <div style="margin-top: -370px; margin-left: 1270px;">
                        <asp:Button ID="BtnCadastrar" runat="server" Text="CADASTRAR" OnClick="BtnCadastrar_Click" Width="50%" Height="30px" BorderStyle="Groove" BorderColor="White" Font-Italic="True" Font-Bold="True"></asp:Button>
                    </div>
                </td>
            </tr>

            <tr>
                <td height="100%">
                    <div style="margin-left: 190px; margin-top: -190px">
                        <asp:GridView AutoGenerateColumns="False"
                            AllowPaging="True"
                            runat="server" ID="grvCalculo" CssClass="table table-bordered table-striped" GridLines="Both" ShowHeaderWhenEmpty="True" EmptyDataText="Não foram encontrados resultados" Width="90%" DataKeyNames="Pessoa_ID">
                            <Columns>

                                <asp:BoundField HeaderText="ID" DataField="Pessoa_ID" />
                                <asp:BoundField HeaderText="Nome" DataField="Nome" />
                                <asp:BoundField HeaderText="Vencimento" DataField="Salario_Bruto" />
                                <asp:BoundField HeaderText="Descontos" DataField="Descontos" />
                                <asp:BoundField HeaderText="Líquido" DataField="Salario_Liquido" />



                            </Columns>
                            <HeaderStyle Font-Size="Large" HorizontalAlign="Center" />
                            <PagerStyle Font-Size="Smaller" />
                            <RowStyle Font-Size="Medium" HorizontalAlign="Center" />
                        </asp:GridView>
                    </div>

                </td>
            </tr>
        </table>
        <%--  Botão Voltar--%>
        <div style="margin-top: -755px; margin-left: 1400px;">
            <asp:ImageButton ID="BtnVoltar" runat="server" AlternateText="CADASTRAR" ImageUrl="images/returnLaranja.png" OnClick="BtnVoltar_Click"></asp:ImageButton>

        </div>

    </form>
</asp:Content>

