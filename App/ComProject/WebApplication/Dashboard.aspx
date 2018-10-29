<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="WebApplication.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>WebApi Online Component Repository</title>

    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.98.0/css/materialize.min.css" />
    <link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons" />

    <link rel="stylesheet" type="text/css" href="css/main.css" />

</head>

<body>
    <form id="mainForm" runat="server">
        <asp:ScriptManager runat="server" EnablePartialRendering="true"></asp:ScriptManager>
        <div class="row">
            <!-- BEGINING // SIDE SECTION -->
            <div class="col s12 m4 l2 sidebar zero-padding fixed">

                <div class="affix">
                    <div class="logo">
                        <img src="images/logo-bold.png" class="logo-img" alt="" title="Volvo Eco Driving - Highscores" />
                    </div>

                    <div class="sidebar-inner">

                        <ul class="collapsible" data-collapsible="accordion" style="margin-top: 40px; border: 0px">
                            <li>
                                <div class="collapsible-header active" style="color: black">
                                    <img src="images/component.png" alt="component icon" />Components
                                </div>
                                <div class="collapsible-body collapsible-body-settings ">
                                    <!-- Search bar -->
                                    <form class=" hide-on-med-and-down" id="form1">
                                        <div class="input-field">
                                            <asp:TextBox ID="search" type="search" ClientIDMode="Static" autocomplete="off" runat="server" />
                                            <asp:Button ID="confirmSearch" class="searchButton" OnClick="confirmSearch_Click" runat="server" />
                                            <label class="label-icon" for="search"><i class="material-icons">search</i></label>
                                            <i class="material-icons">close</i>
                                            <div id="searchResults"></div>
                                        </div>
                                    </form>
                                    <!--Radio buttons for component name selection-->

                                    <asp:RadioButtonList ID="radioContainer" OnSelectedIndexChanged="radioContainer_SelectedIndexChanged" AutoPostBack="true" runat="server">
                                    </asp:RadioButtonList>

                                </div>
                            </li>
                        </ul>

                    </div>
                </div>
            </div>




            <!-- END // SIDEBAR SECTION -->

            <!-- BEGINING // MAIN SECTION -->
            <div class="col s12 m8 l10 content offset-m4 offset-l2">

                <div class="content-inner">

                    <ul id="results-table" class="collapsible" data-collapsible="accordion">
                        <li>
                            <!--Header of the item-->

                            <asp:UpdatePanel runat="server">
                                <ContentTemplate>
                                    <div class="mainContainerHeader" id="1">
                                        <span>#Comp <span id="componentHeaderTitle" runat="server"></span></span>
                                        <span class="right downloadSection">
                                            <asp:ImageButton ID="componentDownloadLink" Enabled="false" OnClick="componentDownloadLink_Click" ImageUrl="~/images/download.png" runat="server" /></span>
                                    </div>

                                </ContentTemplate>
                                <Triggers>
                                    <asp:PostBackTrigger ControlID="componentDownloadLink" />
                                </Triggers>
                            </asp:UpdatePanel>
                            <!-- Body of first collapsable item -->
                            <div class="mainContainerBody" style="height: 555px !important">

                                <div class="row">

                                    <!--LEFT SIDE-->
                                    <div class="col s6">
                                        <br />
                                        <div class="radar-chart-container">
                                            <ul class="collection">
                                                <li class="collection-item" runat="server"><b>Classes: </b>
                                                    <p id="classesReflection" runat="server"></p>
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                    <!-- END LEFT SIDE-->

                                    <!-- BEGINING TABLES-->
                                    <div class="col s6">
                                        <br />
                                        <ul class="collection">
                                            <li class="collection-item" runat="server"><b>Interfaces: </b>
                                                <p id="interfacesReflection" runat="server"></p>
                                            </li>
                                        </ul>

                                        <!-- START // TABLE-->
                                        <ul class="collection" style="margin-top: 9px;">
                                            <li class="collection-item" style="font-weight: 500">COMPONENT INFORMATION</li>
                                            <li class="collection-item" runat="server"><b>Title:</b> <span id="componentName" runat="server"></span></li>
                                            <li class="collection-item" runat="server"><b>Author:</b> <span id="componentAuthor" runat="server"></span></li>
                                            <li class="collection-item" runat="server"><b>Type:</b> <span id="componentType" runat="server"></span></li>
                                            <li class="collection-item" runat="server"><b>Description:</b> <span id="componentDescription" runat="server"></span></li>
                                        </ul>
                                        <!-- END // TABLE-->
                                    </div>
                                    <!-- END // CHART, BUTTONS, TABLE-->
                                </div>
                            </div>
                        </li>
                    </ul>
                </div>
                <!--INNER CONTENT DIV-->
            </div>
            <!-- END // MAIN SECTION-->
        </div>
    </form>

    <script src="https://code.jquery.com/jquery-2.1.1.min.js" type="text/javascript"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.98.0/js/materialize.min.js" type="text/javascript"></script>


    <script>
        function button_click(objTextBox, objBtnID) {
            if (window.event.keyCode == 13) {
                document.getElementById(objBtnID).focus();
                document.getElementById(objBtnID).click();
            }
        }
    </script>
</body>
</html>
