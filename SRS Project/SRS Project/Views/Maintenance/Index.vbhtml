﻿@Code
    ViewData("Title") = "Home Page"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center">
    @Html.Partial("_SubMenuLeft")

    <div class="bd_ctr_rightpart">
        <div id="rtpt_box-01" class="ctr_rtpt_box">
            <div class="ctr_rtpt_b_ht">
                <span>Hyperlink</span>

                <div class="fa fa-refresh rtpt_b_ht_refresh"></div>
                <div id="addnewbtn" class="rtpt_ftr_addbtn filter1">Add Item</div>
            </div>

            <table>
                <thead>
                    <tr>
                        <th style="width: 65px;"></th>
                        <th style="width: 250px;">Title</th>
                        <th>UPL</th>
                    </tr>
                </thead>

                <tbody>
                    <tr>
                        <td>
                            <div id="editbtn" class="fa fa-pencil-square-o btn_edit"></div>
                            <div id="deletebtn" class="fa fa-trash-o btn_trash"></div>
                        </td>
                        <td>eModuler Support</td>
                        <td style="padding: 0 5px;">http://Support.emoduler.com</td>
                    </tr>

                    <tr>
                        <td>
                            <div id="editbtn" class="fa fa-pencil-square-o btn_edit"></div>
                            <div id="deletebtn" class="fa fa-trash-o btn_trash"></div>
                        </td>
                        <td>eModuler Support 01</td>
                        <td>http://Support.emoduler.com</td>
                    </tr>
                </tbody>
            </table>

            <div class="ctr_rtpt_b_ftr">
                <span>Total 2 iten(s)</span>
            </div>
        </div>

        <div id="addbox-01" class="ctr_rtpt_box display_none">
            <div class="ctr_rtpt_b_ht">
                <span>Hyperlink - Add Item</span>
            </div>

            <div class="ctr_rtpt_addbox">
                <div class="rtpt_addbox_part">
                    <div class="rtpt_addbox_pt_tt">Title :</div>
                    <input type="text" id="title" name="title">

                    <div class="rtpt_addbox_pt_error">Text Error</div>
                </div>

                <div class="rtpt_addbox_part">
                    <div class="rtpt_addbox_pt_tt">URL :</div>
                    <input type="text" id="URL" name="URL">

                    <div class="rtpt_addbox_pt_error">Text Error</div>
                </div>

                <div class="rtpt_addbox_partbtn">
                    <div id="closebtn" class="rtpt_closebtn filter1">Close</div>

                    <div id="savebtn" class="rtpt_savebtn filter1">Save</div>
                </div>
            </div>
        </div>

        <div id="editbox-01" class="ctr_rtpt_box display_none">
            <div class="ctr_rtpt_b_ht">
                <span>Hyperlink - Edit</span>
            </div>

            <div class="ctr_rtpt_addbox">
                <div class="rtpt_addbox_part">
                    <div class="rtpt_addbox_pt_tt">Title :</div>
                    <input type="text" id="title" name="title" value="eModuler Support">

                    <div class="rtpt_addbox_pt_error">Text Error</div>
                </div>

                <div class="rtpt_addbox_part">
                    <div class="rtpt_addbox_pt_tt">URL :</div>
                    <input type="text" id="URL" name="URL" value="http://Support.emoduler.com">

                    <div class="rtpt_addbox_pt_error">Text Error</div>
                </div>

                <div class="rtpt_addbox_partbtn">
                    <div id="closebtn" class="rtpt_closebtn filter1">Close</div>

                    <div id="savebtn" class="rtpt_savebtn filter1">Save</div>
                </div>
            </div>
        </div>

        <div id="deletebox-01" class="ctr_rtpt_popupbox display_none">
            <div class="rtpt_popupbox_inb">
                <div class="fa fa-trash-o popupbox_inb_icon_red"></div>
                <div class="popupbox_inb_tt">Confirm Delete</div>

                <div class="popupbox_inb_btnpart">
                    <div id="closebtn" class="rtpt_closebtn filter1">Close</div>
                    <div id="yesbtn" class="rtpt_yesbtn filter1">Yes</div>
                </div>
            </div>
        </div>

        @*<div class="ctr_rtpt_footer">
                <div class="rtpt_ftr_addbtn filter1">Add Item</div>
            </div>*@
    </div>
</div>