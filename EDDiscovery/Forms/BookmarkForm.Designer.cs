﻿/*
 * Copyright © 2016 EDDiscovery development team
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not use this
 * file except in compliance with the License. You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software distributed under
 * the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF
 * ANY KIND, either express or implied. See the License for the specific language
 * governing permissions and limitations under the License.
 * 
 * EDDiscovery is not affiliated with Frontier Developments plc.
 */
namespace EDDiscovery.Forms
{
    partial class BookmarkForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelBookmarkNotes = new System.Windows.Forms.Label();
            this.labelTimeMade = new System.Windows.Forms.Label();
            this.textBoxNotes = new ExtendedControls.RichTextBoxScroll();
            this.textBoxX = new ExtendedControls.TextBoxBorder();
            this.textBoxY = new ExtendedControls.TextBoxBorder();
            this.textBoxZ = new ExtendedControls.TextBoxBorder();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTime = new ExtendedControls.TextBoxBorder();
            this.buttonOK = new ExtendedControls.ButtonExt();
            this.buttonCancel = new ExtendedControls.ButtonExt();
            this.buttonDelete = new ExtendedControls.ButtonExt();
            this.labelTravelNote = new System.Windows.Forms.Label();
            this.labelTravelNoteEdit = new System.Windows.Forms.Label();
            this.textBoxTravelNote = new ExtendedControls.TextBoxBorder();
            this.checkBoxTarget = new ExtendedControls.CheckBoxCustom();
            this.buttonEDSM = new ExtendedControls.ButtonExt();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxName = new ExtendedControls.AutoCompleteTextBox();
            this.userControlSurfaceBookmarks1 = new EDDiscovery.UserControls.UserControlSurfaceBookmarks();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Co-ordinates";
            // 
            // labelBookmarkNotes
            // 
            this.labelBookmarkNotes.Location = new System.Drawing.Point(9, 147);
            this.labelBookmarkNotes.Name = "labelBookmarkNotes";
            this.labelBookmarkNotes.Size = new System.Drawing.Size(121, 69);
            this.labelBookmarkNotes.TabIndex = 0;
            this.labelBookmarkNotes.Text = "Bookmark Notes";
            // 
            // labelTimeMade
            // 
            this.labelTimeMade.AutoSize = true;
            this.labelTimeMade.Location = new System.Drawing.Point(9, 76);
            this.labelTimeMade.Name = "labelTimeMade";
            this.labelTimeMade.Size = new System.Drawing.Size(60, 13);
            this.labelTimeMade.TabIndex = 0;
            this.labelTimeMade.Text = "Time Made";
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxNotes.BorderColorScaling = 0.5F;
            this.textBoxNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNotes.HideScrollBar = true;
            this.textBoxNotes.Location = new System.Drawing.Point(139, 147);
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.ReadOnly = false;
            this.textBoxNotes.ScrollBarArrowBorderColor = System.Drawing.Color.LightBlue;
            this.textBoxNotes.ScrollBarArrowButtonColor = System.Drawing.Color.LightGray;
            this.textBoxNotes.ScrollBarBackColor = System.Drawing.SystemColors.Control;
            this.textBoxNotes.ScrollBarBorderColor = System.Drawing.Color.White;
            this.textBoxNotes.ScrollBarFlatStyle = System.Windows.Forms.FlatStyle.System;
            this.textBoxNotes.ScrollBarForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxNotes.ScrollBarMouseOverButtonColor = System.Drawing.Color.Green;
            this.textBoxNotes.ScrollBarMousePressedButtonColor = System.Drawing.Color.Red;
            this.textBoxNotes.ScrollBarSliderColor = System.Drawing.Color.DarkGray;
            this.textBoxNotes.ScrollBarThumbBorderColor = System.Drawing.Color.Yellow;
            this.textBoxNotes.ScrollBarThumbButtonColor = System.Drawing.Color.DarkBlue;
            this.textBoxNotes.ScrollBarWidth = 20;
            this.textBoxNotes.ShowLineCount = false;
            this.textBoxNotes.Size = new System.Drawing.Size(336, 103);
            this.textBoxNotes.TabIndex = 0;
            this.textBoxNotes.TextBoxBackColor = System.Drawing.SystemColors.Control;
            this.textBoxNotes.TextBoxForeColor = System.Drawing.SystemColors.ControlText;
            // 
            // textBoxX
            // 
            this.textBoxX.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxX.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxX.BackErrorColor = System.Drawing.Color.Red;
            this.textBoxX.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxX.BorderColorScaling = 0.5F;
            this.textBoxX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxX.ControlBackground = System.Drawing.SystemColors.Control;
            this.textBoxX.InErrorCondition = false;
            this.textBoxX.Location = new System.Drawing.Point(139, 43);
            this.textBoxX.Multiline = false;
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.ReadOnly = true;
            this.textBoxX.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxX.SelectionLength = 0;
            this.textBoxX.SelectionStart = 0;
            this.textBoxX.Size = new System.Drawing.Size(80, 20);
            this.textBoxX.TabIndex = 4;
            this.textBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxX.WordWrap = true;
            this.textBoxX.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxY
            // 
            this.textBoxY.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxY.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxY.BackErrorColor = System.Drawing.Color.Red;
            this.textBoxY.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxY.BorderColorScaling = 0.5F;
            this.textBoxY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxY.ControlBackground = System.Drawing.SystemColors.Control;
            this.textBoxY.InErrorCondition = false;
            this.textBoxY.Location = new System.Drawing.Point(273, 43);
            this.textBoxY.Multiline = false;
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.ReadOnly = true;
            this.textBoxY.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxY.SelectionLength = 0;
            this.textBoxY.SelectionStart = 0;
            this.textBoxY.Size = new System.Drawing.Size(80, 20);
            this.textBoxY.TabIndex = 5;
            this.textBoxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxY.WordWrap = true;
            this.textBoxY.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxZ
            // 
            this.textBoxZ.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxZ.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxZ.BackErrorColor = System.Drawing.Color.Red;
            this.textBoxZ.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxZ.BorderColorScaling = 0.5F;
            this.textBoxZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxZ.ControlBackground = System.Drawing.SystemColors.Control;
            this.textBoxZ.InErrorCondition = false;
            this.textBoxZ.Location = new System.Drawing.Point(395, 43);
            this.textBoxZ.Multiline = false;
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.ReadOnly = true;
            this.textBoxZ.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxZ.SelectionLength = 0;
            this.textBoxZ.SelectionStart = 0;
            this.textBoxZ.Size = new System.Drawing.Size(80, 20);
            this.textBoxZ.TabIndex = 6;
            this.textBoxZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxZ.WordWrap = true;
            this.textBoxZ.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "x:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "y:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "z:";
            // 
            // textBoxTime
            // 
            this.textBoxTime.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxTime.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxTime.BackErrorColor = System.Drawing.Color.Red;
            this.textBoxTime.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxTime.BorderColorScaling = 0.5F;
            this.textBoxTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTime.ControlBackground = System.Drawing.SystemColors.Control;
            this.textBoxTime.InErrorCondition = false;
            this.textBoxTime.Location = new System.Drawing.Point(139, 73);
            this.textBoxTime.Multiline = false;
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.ReadOnly = true;
            this.textBoxTime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxTime.SelectionLength = 0;
            this.textBoxTime.SelectionStart = 0;
            this.textBoxTime.Size = new System.Drawing.Size(246, 20);
            this.textBoxTime.TabIndex = 7;
            this.textBoxTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxTime.WordWrap = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(548, 542);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(467, 542);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(3, 542);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelTravelNote
            // 
            this.labelTravelNote.Location = new System.Drawing.Point(6, 254);
            this.labelTravelNote.Name = "labelTravelNote";
            this.labelTravelNote.Size = new System.Drawing.Size(124, 49);
            this.labelTravelNote.TabIndex = 0;
            this.labelTravelNote.Text = "Travel History Note";
            // 
            // labelTravelNoteEdit
            // 
            this.labelTravelNoteEdit.Location = new System.Drawing.Point(9, 312);
            this.labelTravelNoteEdit.Name = "labelTravelNoteEdit";
            this.labelTravelNoteEdit.Size = new System.Drawing.Size(121, 46);
            this.labelTravelNoteEdit.TabIndex = 0;
            this.labelTravelNoteEdit.Text = "(Edit on Travel Screen)";
            // 
            // textBoxTravelNote
            // 
            this.textBoxTravelNote.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxTravelNote.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxTravelNote.BackErrorColor = System.Drawing.Color.Red;
            this.textBoxTravelNote.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxTravelNote.BorderColorScaling = 0.5F;
            this.textBoxTravelNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTravelNote.ControlBackground = System.Drawing.SystemColors.Control;
            this.textBoxTravelNote.InErrorCondition = false;
            this.textBoxTravelNote.Location = new System.Drawing.Point(139, 256);
            this.textBoxTravelNote.Multiline = true;
            this.textBoxTravelNote.Name = "textBoxTravelNote";
            this.textBoxTravelNote.ReadOnly = true;
            this.textBoxTravelNote.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxTravelNote.SelectionLength = 0;
            this.textBoxTravelNote.SelectionStart = 0;
            this.textBoxTravelNote.Size = new System.Drawing.Size(336, 87);
            this.textBoxTravelNote.TabIndex = 8;
            this.textBoxTravelNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxTravelNote.WordWrap = true;
            // 
            // checkBoxTarget
            // 
            this.checkBoxTarget.AutoSize = true;
            this.checkBoxTarget.CheckBoxColor = System.Drawing.Color.Gray;
            this.checkBoxTarget.CheckBoxInnerColor = System.Drawing.Color.White;
            this.checkBoxTarget.CheckColor = System.Drawing.Color.DarkBlue;
            this.checkBoxTarget.FontNerfReduction = 0.5F;
            this.checkBoxTarget.ImageButtonDisabledScaling = 0.5F;
            this.checkBoxTarget.Location = new System.Drawing.Point(298, 112);
            this.checkBoxTarget.MouseOverColor = System.Drawing.Color.CornflowerBlue;
            this.checkBoxTarget.Name = "checkBoxTarget";
            this.checkBoxTarget.Size = new System.Drawing.Size(87, 17);
            this.checkBoxTarget.TabIndex = 10;
            this.checkBoxTarget.Text = "Make Target";
            this.checkBoxTarget.TickBoxReductionSize = 10;
            this.checkBoxTarget.UseVisualStyleBackColor = true;
            // 
            // buttonEDSM
            // 
            this.buttonEDSM.Location = new System.Drawing.Point(139, 106);
            this.buttonEDSM.Name = "buttonEDSM";
            this.buttonEDSM.Size = new System.Drawing.Size(75, 23);
            this.buttonEDSM.TabIndex = 11;
            this.buttonEDSM.Text = "EDSM";
            this.buttonEDSM.UseVisualStyleBackColor = true;
            this.buttonEDSM.Click += new System.EventHandler(this.buttonEDSM_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.userControlSurfaceBookmarks1);
            this.panel1.Controls.Add(this.buttonEDSM);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBoxTarget);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.buttonOK);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxZ);
            this.panel1.Controls.Add(this.labelBookmarkNotes);
            this.panel1.Controls.Add(this.textBoxY);
            this.panel1.Controls.Add(this.labelTravelNote);
            this.panel1.Controls.Add(this.textBoxX);
            this.panel1.Controls.Add(this.labelTravelNoteEdit);
            this.panel1.Controls.Add(this.textBoxTime);
            this.panel1.Controls.Add(this.labelTimeMade);
            this.panel1.Controls.Add(this.textBoxNotes);
            this.panel1.Controls.Add(this.textBoxTravelNote);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 570);
            this.panel1.TabIndex = 12;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // textBoxName
            // 
            this.textBoxName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxName.BackErrorColor = System.Drawing.Color.Red;
            this.textBoxName.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxName.BorderColorScaling = 0.5F;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.ControlBackground = System.Drawing.SystemColors.Control;
            this.textBoxName.DropDownBackgroundColor = System.Drawing.Color.Gray;
            this.textBoxName.DropDownBorderColor = System.Drawing.Color.Green;
            this.textBoxName.DropDownHeight = 200;
            this.textBoxName.DropDownItemHeight = 20;
            this.textBoxName.DropDownMouseOverBackgroundColor = System.Drawing.Color.Red;
            this.textBoxName.DropDownScrollBarButtonColor = System.Drawing.Color.LightGray;
            this.textBoxName.DropDownScrollBarColor = System.Drawing.Color.LightGray;
            this.textBoxName.DropDownWidth = 0;
            this.textBoxName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.textBoxName.InErrorCondition = false;
            this.textBoxName.Location = new System.Drawing.Point(139, 16);
            this.textBoxName.Multiline = false;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = false;
            this.textBoxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxName.SelectionLength = 0;
            this.textBoxName.SelectionStart = 0;
            this.textBoxName.Size = new System.Drawing.Size(336, 20);
            this.textBoxName.TabIndex = 13;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxName.WordWrap = true;
            this.textBoxName.Validated += new System.EventHandler(this.textBoxName_Validated);
            // 
            // userControlSurfaceBookmarks1
            // 
            this.userControlSurfaceBookmarks1.Location = new System.Drawing.Point(13, 362);
            this.userControlSurfaceBookmarks1.Name = "userControlSurfaceBookmarks1";
            this.userControlSurfaceBookmarks1.Size = new System.Drawing.Size(602, 160);
            this.userControlSurfaceBookmarks1.TabIndex = 12;
            // 
            // BookmarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 570);
            this.Controls.Add(this.panel1);
            this.Icon = global::EDDiscovery.Properties.Resources.edlogo_3mo_icon;
            this.Name = "BookmarkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Bookmark";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelBookmarkNotes;
        private System.Windows.Forms.Label labelTimeMade;
        private ExtendedControls.RichTextBoxScroll textBoxNotes;
        private ExtendedControls.TextBoxBorder textBoxX;
        private ExtendedControls.TextBoxBorder textBoxY;
        private ExtendedControls.TextBoxBorder textBoxZ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private ExtendedControls.TextBoxBorder textBoxTime;
        private ExtendedControls.ButtonExt buttonOK;
        private ExtendedControls.ButtonExt buttonCancel;
        private ExtendedControls.ButtonExt buttonDelete;
        private System.Windows.Forms.Label labelTravelNote;
        private System.Windows.Forms.Label labelTravelNoteEdit;
        private ExtendedControls.TextBoxBorder textBoxTravelNote;
        private ExtendedControls.CheckBoxCustom checkBoxTarget;
        private ExtendedControls.ButtonExt buttonEDSM;
        private System.Windows.Forms.Panel panel1;
        private UserControls.UserControlSurfaceBookmarks userControlSurfaceBookmarks1;
        private ExtendedControls.AutoCompleteTextBox textBoxName;
    }
}