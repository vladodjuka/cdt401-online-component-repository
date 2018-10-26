<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="ComProject.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>WebApi Online Component Repository</title>

    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.98.0/css/materialize.min.css" />
    <link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons" />

    <link rel="stylesheet" type="text/css" href="css/main.css" />

</head>

<body>

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
                                        <input id="search" type="search" required="required" onkeyup="getBlogs(this.value,0);" />
                                        <label class="label-icon" for="search"><i class="material-icons">search</i></label>
                                        <i class="material-icons">close</i>
                                        <div id="searchResults"></div>
                                    </div>
                                </form>
                                <!--Radio buttons for component name selection-->
                                <form id="machine" runat="server">
                                    <asp:RadioButtonList ID="radioContainer" OnSelectedIndexChanged="radioContainer_SelectedIndexChanged" AutoPostBack="true" runat="server">
                                        <%--<input name="componentName" type="radio" id="fruitShop_radio" checked="checked" value="FruitShopCom" />
                                        <label for="fruitShop_radio">FruitShopCom</label>
                                        <br />
                                        <br />--%>
                                        <%--<asp:RadioButton ID="RadioButton1" runat="server"  Text="FruitShop"/>--%>

                                        <%--<input name="componentName" type="radio" id="ejb_radio" value="EJBComponent" />
                                        <label for="ejb_radio">EJBComponent</label>
                                        <br />
                                        <br />

                                        <input name="componentName" type="radio" id="com_radio" value="COMComponent" />
                                        <label for="com_radio">COMComponent</label>
                                        <br />
                                        <br />

                                        <input name="componentName" type="radio" id="net_radio" value="NETComponent" />
                                        <label for="net_radio">NETComponent</label>--%>
                                    </asp:RadioButtonList>
                                </form>
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
                        <div class="mainContainerHeader" id="1">
                            <span>#Comp <span id="componentHeaderTitle" runat="server"></span></span>
                            <span class="right downloadSection"><a id="componentDownloadLink" href="" runat="server"><img src="images/download.png" alt="Download icon"/></a></span>
                        </div>
                        <!-- Body of first collapsable item -->
                        <div class="mainContainerBody" style="height:555px !important">

                            <div class="row">

                                <!--LEFT SIDE-->
                                <div class="col s6">
                                    <br />
                                    <div class="radar-chart-container">
                                        <ul class="collection">
                                        <li class="collection-item" runat="server">Classes: <p id="classesReflection" runat="server"></p></li>
                                            </ul>
                                    </div>
                                </div>
                                <!-- END LEFT SIDE-->

                                <!-- BEGINING // CHART, BUTTONS, TABLE-->
                                <div class="col s6">
                                    <br />
                                    <ul class="collection">
                                        <li class="collection-item" runat="server">Interfaces: <p id="interfacesReflection" runat="server"></p></li>
                                            </ul>
                                    <!--LINE CHART-->
                                    <!--<canvas id="line-chart-{{index}}" width="200" height="150" style="margin-top: 9px;"></canvas>-->
                                    <!--END LINE CHART-->
                                    <!--BUTTONS -->

                                    <%--<a class="waves-effect waves-light btn" data-label="Fuel" data-type="FUEL" data-id="{{index}}">Fuel</a>
                                    <a class="waves-effect waves-light btn" data-label="Distance" data-type="DISTANCE" data-id="{{index}}">Distance</a>
                                    <a class="waves-effect waves-light btn" data-label="Load" data-type="LOADED" data-id="{{index}}">Load</a>--%>

                                    <!--END BUTTONS -->

                                    <!-- START // TABLE-->
                                    <ul class="collection" style="margin-top: 9px;">

                                        <li class="collection-item" runat="server">Component name: <span id="componentName" runat="server"></span></li>
                                        <li class="collection-item" runat="server">Component author: <span id="componentAuthor" runat="server"></span></li>
                                        <li class="collection-item" runat="server">Component type: <span id="componentType" runat="server"></span></li>
                                        <li class="collection-item" runat="server">Component description: <span id="componentDescription" runat="server"></span></li>
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

    <script src="https://code.jquery.com/jquery-2.1.1.min.js" type="text/javascript"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.98.0/js/materialize.min.js" type="text/javascript"></script>
</body>
</html>
