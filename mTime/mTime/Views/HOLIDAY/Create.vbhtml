﻿@ModelType model.HOLIDAY
@Code
    ViewData("Title") = "Create"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center">
    @Html.Partial("_SubMenuLeft")

    <div class="bd_ctr_rightpart">
        <div id="addbox-01" class="ctr_rtpt_box">
            <div class="ctr_rtpt_b_ht">
                <span>Holiday :: Create</span>
            </div>

            @Using (Html.BeginForm())
                @Html.AntiForgeryToken()
                @<div class="ctr_holiday_addbox">
                    <div class="hlday_addbox_part">
                        <div class="hlday_addbox_pt_tt">Holiday Name :</div>
                        <div class="">
                            @Html.EditorFor(Function(model) model.HOLIDAYNAME, New With {.htmlAttributes = New With {.class = "input_field_fill_available"}})
                            @Html.ValidationMessageFor(Function(model) model.HOLIDAYNAME, "", New With {.class = "text-danger"})
                        </div>
                    </div>

                    <div class="hlday_addbox_part">
                        <div class="hlday_addbox_pt_tt">Date From :</div>
                        <div class="">
                            @Html.EditorFor(Function(model) model.FROM, New With {.htmlAttributes = New With {.class = "input_field_fill_available"}})
                            @Html.ValidationMessageFor(Function(model) model.FROM, "", New With {.class = "text-danger"})
                        </div>
                    </div>

                    <div class="hlday_addbox_part">
                        <div class="hlday_addbox_pt_tt">Date To :</div>
                        <div class="">
                            @Html.EditorFor(Function(model) model.UNTIL, New With {.htmlAttributes = New With {.class = "input_field_fill_available"}})
                            @Html.ValidationMessageFor(Function(model) model.UNTIL, "", New With {.class = "text-danger"})
                        </div>
                    </div>

                    <div class="hlday_addbox_partbtn">
                        <a href="@Url.Action("Holiday", "Maintenance")">
                            <div id="closebtn" Class="rtpt_closebtn filter1">
                                Cancel
                            </div>
                        </a>

                        <a href="@Url.Action("Create", "Holiday")" id="save">
                            <div id="savebtn" Class="rtpt_savebtn filter1">
                                Save
                            </div>
                        </a>
                    </div>
                </div>
            End Using

            @Code
                If ViewBag.Result = "OK" Then
                    @<script>
                        window.onload = function() {
                            $(".save_ok_popup").addClass("display_block").fadeOut(3000);
                            window.location.href = "@Url.Action("Holiday", "Maintenance")";
                        };
                    </script>
                End If
            End Code


            <div id="" Class="ctr_rtpt_popupbox display_none save_ok_popup">
                <div Class="rtpt_popupbox_inb">
                    <div Class="fa fa-check-circle-o popupbox_inb_icon_blue"></div>
                    <div Class="popupbox_inb_tt">Save successfully</div>
                </div>
            </div>

            <div id="" Class="ctr_rtpt_popupbox display_none exclamation_ok_popup">
                <div Class="rtpt_popupbox_inb">
                    <div Class="fa fa-exclamation-circle popupbox_inb_icon_red"></div>
                    <div Class="popupbox_inb_tt">Save failed</div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class="bg_color_w"></div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section


<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>

<script type="text/javascript">
    $(function () {
        $("#save").click(function () {
            document.forms[0].submit();
            return false;
        });
    });
</script>