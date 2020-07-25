<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Evaluacion3.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/EstiloLog.css" rel="stylesheet" />
    <div class="modal-dialog justify-center">
        <div class="main-section">
            <div class="modal-content" style="background-color: #196dc880">
                
                    <div class="form-group text-center mb-4">
                        <img src="Content/img/logoRS.png" width="200"/>
                    </div>
                <form action="About.aspx" method="get" class="form">
                <asp:Login ID="Log" runat="server" OnAuthenticate="Log_Authenticate"
                    LoginButtonText="Acceder"
                    PasswordLabelText="Contraseña"
                    UserNameLabelText="Usuario"
                    RememberMeText="Recordarme la próxima vez." TitleText="" Width="239px"
                    >
                </asp:Login>
               </form>
            </div>
        </div>

    </div>

    <footer class="page-footer font-small white position-absolute mb-0 w-100 h-auto">
        <div class="footer-copyright" style="font-size:14px;">
            ©Copyright 2020 by Paulina Bordones. All rights reserved.
        </div>
    </footer>

</asp:Content>
