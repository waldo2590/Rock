﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PlacementGroup.ascx.cs" Inherits="RockWeb.Blocks.Event.RegistrationInstance.PlacementGroup" %>

<style>
    .registrant-gender-boy {
        background-color: lightblue;
        border-color: blue;
        color: blue;
    }

    .registrant-gender-girl {
        background-color: lightpink;
        border-color: deeppink;
        color: deeppink;
    }
</style>

<asp:UpdatePanel ID="upnlContent" runat="server">
    <ContentTemplate>

        <Rock:RockDropDownList ID="ddlDebugGroupType" runat="server" Label="DEBUG: Set GroupTypeId parameter" AutoPostBack="true" OnSelectedIndexChanged="ddlDebugGroupType_SelectedIndexChanged" CssClass="input-width-xl" />
        <Rock:NotificationBox ID="nbConfigurationError" runat="server" />

        <asp:Panel ID="pnlView" runat="server" CssClass="panel panel-block panel-placementgroup">

            <%-- Panel Header --%>
            <div class="panel-heading">
                <h1 class="panel-title">
                    <asp:Literal ID="lGroupPlacementGroupTypeIconHtml" runat="server">
                        <i class="fa fa-star"></i>
                    </asp:Literal>
                    <asp:Literal ID="lGroupPlacementGroupTypeName" Text="###GroupType.Term###.Pluralized()" runat="server" />
                </h1>

                <div class="panel-labels">
                    <asp:LinkButton ID="btnAddPlacementGroup" runat="server" CssClass="js-autoschedule btn btn-default btn-xs" OnClick="btnAddPlacementGroup_Click">
                        <asp:Literal ID="lAddPlacementGroupButtonIconHtml" runat="server">
                            <i class="fa fa-star"></i>
                        </asp:Literal>
                        <asp:Literal ID="lAddPlacementGroupButtonText" Text="Add (###GroupType.Term Name###)" runat="server" />
                    </asp:LinkButton>
                    <asp:LinkButton ID="btnConfiguration" runat="server" CssClass="btn btn-default btn-xs" OnClick="btnConfiguration_Click"><i class="fa fa-gear"></i></asp:LinkButton>
                </div>
            </div>


            <%-- Panel Body --%>
            <div class="panel-body">
                <asp:Panel ID="pnlGroupPlacementContainer" runat="server">
                    <asp:Panel ID="pnlGroupPlacement" runat="server">

                        <Rock:HiddenFieldWithClass ID="hfRegistrationTemplateId" runat="server" CssClass="js-registration-template-id" />
                        <Rock:HiddenFieldWithClass ID="hfRegistrationInstanceId" runat="server" CssClass="js-registration-instance-id" />
                        <Rock:HiddenFieldWithClass ID="hfPlacementGroupTypeId" runat="server" CssClass="js-placement-grouptype-id" />

                        <div class="row row-eq-height">
                            <div class="col-md-4 hidden-xs">

                                <div class="group-placement-registrantlist">

                                    <div class="panel panel-block registrant-list">

                                        <div class="panel-heading">
                                            <h1 class="panel-title">
                                                <i class="fa fa-user"></i>
                                                Registrants
                                            </h1>

                                            <div class="panel-labels">
                                                <div class="js-toggle-registrant-details btn btn-xs btn-default">
                                                    <i class="fa fa-angle-double-down"></i>
                                                </div>
                                            </div>
                                        </div>

                                        <div class="panel-body padding-all-none">
                                            <Rock:RockTextBox ID="sfRegistrant" runat="server" CssClass="registrant-search padding-all-sm js-registrant-search" PrependText="<i class='fa fa-search'></i>" Placeholder="Search" spellcheck="false" />

                                            <div class="scroll-list">
                                                <%-- loading indicator --%>
                                                <i class="fa fa-refresh fa-spin margin-l-md js-loading-notification" style="display: none; opacity: .4;"></i>

                                                <%-- container for list of registrants --%>
                                                <asp:Panel ID="pnlRegistrantListContainer" CssClass="js-group-placement-registrant-container registrant-container dropzone" runat="server">
                                                </asp:Panel>
                                            </div>
                                        </div>

                                    </div>
                                </div>

                            </div>

                            <div class="col-md-8">
                                <%-- containers for each placement group (for example:bus) that registrants can be dragged into --%>
                                <div class="placement-groups js-placement-groups">
                                    <asp:Repeater ID="rptPlacementGroups" runat="server" OnItemDataBound="rptPlacementGroups_ItemDataBound">
                                        <ItemTemplate>

                                            <asp:Panel ID="pnlPlacementGroup" runat="server" CssClass="placement-group js-placement-group">
                                                <Rock:HiddenFieldWithClass ID="hfPlacementGroupId" runat="server" CssClass="js-placement-group-id" />
                                                <Rock:HiddenFieldWithClass ID="hfPlacementGroupCapacity" runat="server" CssClass="js-placement-group-capacity" />

                                                <div class="panel panel-block panel-group">
                                                    <div class="panel-heading">
                                                        <h1 class="panel-title">
                                                            <asp:Literal ID="lGroupName" runat="server" />
                                                        </h1>

                                                        <asp:Panel ID="pnlGroupStatusLabels" runat="server" CssClass="panel-labels">
                                                            ##TODO Group Status ##
                                                        </asp:Panel>
                                                    </div>

                                                    <div class="panel-body">

                                                        <asp:Repeater ID="rptPlacementGroupRole" runat="server" OnItemDataBound="rptPlacementGroupRole_ItemDataBound" Visible="true">
                                                            <ItemTemplate>
                                                                <div class="panel-group-role">
                                                                    <div class="panel panel-block panel-grouprole">
                                                                        <div class="panel-heading">
                                                                            <Rock:HiddenFieldWithClass ID="hfGroupTypeRoleId" runat="server" CssClass="js-grouptyperole-id" />
                                                                            <h1 class="panel-title">
                                                                                <asp:Literal ID="lGroupRoleName" runat="server" />
                                                                            </h1>

                                                                            <asp:Panel ID="pnlGroupRoleStatusLabels" runat="server" CssClass="panel-labels">
                                                                                ##TODO Role Status##
                                                                                <div class="js-grouptyperole-statuslabels-container grouptyperole-statuslabels-container"></div>
                                                                            </asp:Panel>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </ItemTemplate>
                                                        </asp:Repeater>

                                                    </div>

                                                </div>

                                            </asp:Panel>

                                        </ItemTemplate>
                                    </asp:Repeater>
                                </div>
                            </div>
                        </div>
                    </asp:Panel>
                </asp:Panel>
            </div>

        </asp:Panel>


        <%-- Placement Configuration (User preferences) --%>
        <asp:Panel ID="pnlConfiguration" runat="server">
            <Rock:ModalDialog ID="mdPlacementConfiguration" runat="server" Title="Placement Configuration" OnSaveClick="mdPlacementConfiguration_SaveClick">
                <Content>
                    <Rock:CampusPicker ID="cpConfigurationCampusPicker" runat="server" Label="Campus Filter" />

                    <%-- This will only be shown when in Registration Template mode --%>
                    <Rock:PanelWidget ID="pwRegistrationInstanceConfiguration" runat="server" Title="Registration Instance Configuration">
                        <div class="row">
                            <div class="col-md-12">
                                <Rock:RockCheckBox ID="cbShowRegistrationInstanceName" runat="server" Label="Show Registration Instance Name" Help="When enabled, the registration instance name will be included in the details of each registrant in the Registrants list" Checked="true" />

                                <Rock:RockCheckBoxList ID="cblRegistrationInstances" runat="server" Label="Registration Instances" Help="Set the registration instances to include. If none are selected, then all will be included." />
                            </div>
                        </div>
                    </Rock:PanelWidget>

                    <Rock:PanelWidget ID="pnlRegistrationConfiguration" runat="server" Title="Registrant Configuration">
                        <div class="row">
                            <div class="col-md-6">
                                <Rock:RockCheckBox ID="cbHighlightGenders" runat="server" Label="Highlight Genders" Help="Enable this to highlight each registrant to indicate their gender (pink, blue)." />
                            </div>
                            <div class="col-md-6">
                                <Rock:RockCheckBox ID="cbShowFees" runat="server" Label="Show Fees" Help="Enable this to show any fees associated with each registrant." />
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-12">
                                <Rock:RockDropDownList ID="ddlDisplayedRegistrantAttributes" EnhanceForLongLists="true" runat="server" Label="Displayed Registration (did you mean Registrant or both??) Attributes" />

                                <Rock:RockControlWrapper ID="rcwRegistrantFilters" runat="server" Label="Registrant Filters">
                                    ##TODO##
                                </Rock:RockControlWrapper>
                            </div>
                        </div>
                    </Rock:PanelWidget>

                    <Rock:PanelWidget ID="pwGroupConfiguration" runat="server" Title="Group Configuration">
                        ##TODO##
                    </Rock:PanelWidget>

                </Content>
            </Rock:ModalDialog>
        </asp:Panel>

    </ContentTemplate>
</asp:UpdatePanel>
