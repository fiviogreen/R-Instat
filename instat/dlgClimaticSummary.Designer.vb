﻿' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgClimaticSummary
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.rdoAnnual = New System.Windows.Forms.RadioButton()
        Me.rdoAnnualVariable = New System.Windows.Forms.RadioButton()
        Me.rdoWithinYear = New System.Windows.Forms.RadioButton()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblReceiverTo = New System.Windows.Forms.Label()
        Me.lblReceiverFrom = New System.Windows.Forms.Label()
        Me.cmdSummary = New System.Windows.Forms.Button()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblNewColName = New System.Windows.Forms.Label()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.ucrInputSave = New instat.ucrInputTextBox()
        Me.ucrReceiverFrom = New instat.ucrReceiverSingle()
        Me.ucrReceiverTo = New instat.ucrReceiverSingle()
        Me.ucrNudTo = New instat.ucrNud()
        Me.ucrNudFrom = New instat.ucrNud()
        Me.ucrReceiverElement = New instat.ucrReceiverSingle()
        Me.ucrReceiverDOY = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlAnnual = New instat.UcrPanel()
        Me.ucrSelectorVariable = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'rdoAnnual
        '
        Me.rdoAnnual.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoAnnual.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoAnnual.FlatAppearance.BorderSize = 2
        Me.rdoAnnual.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoAnnual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoAnnual.Location = New System.Drawing.Point(46, 14)
        Me.rdoAnnual.Name = "rdoAnnual"
        Me.rdoAnnual.Size = New System.Drawing.Size(118, 27)
        Me.rdoAnnual.TabIndex = 15
        Me.rdoAnnual.TabStop = True
        Me.rdoAnnual.Text = "Annual"
        Me.rdoAnnual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoAnnual.UseVisualStyleBackColor = True
        '
        'rdoAnnualVariable
        '
        Me.rdoAnnualVariable.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoAnnualVariable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoAnnualVariable.FlatAppearance.BorderSize = 2
        Me.rdoAnnualVariable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoAnnualVariable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoAnnualVariable.Location = New System.Drawing.Point(278, 14)
        Me.rdoAnnualVariable.Name = "rdoAnnualVariable"
        Me.rdoAnnualVariable.Size = New System.Drawing.Size(118, 27)
        Me.rdoAnnualVariable.TabIndex = 16
        Me.rdoAnnualVariable.TabStop = True
        Me.rdoAnnualVariable.Text = "Annual Variable"
        Me.rdoAnnualVariable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoAnnualVariable.UseVisualStyleBackColor = True
        '
        'rdoWithinYear
        '
        Me.rdoWithinYear.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoWithinYear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoWithinYear.FlatAppearance.BorderSize = 2
        Me.rdoWithinYear.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoWithinYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoWithinYear.Location = New System.Drawing.Point(162, 14)
        Me.rdoWithinYear.Name = "rdoWithinYear"
        Me.rdoWithinYear.Size = New System.Drawing.Size(118, 27)
        Me.rdoWithinYear.TabIndex = 17
        Me.rdoWithinYear.TabStop = True
        Me.rdoWithinYear.Text = "Within Year"
        Me.rdoWithinYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoWithinYear.UseVisualStyleBackColor = True
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(259, 69)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 26
        Me.lblStation.Text = "Station:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(259, 110)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 27
        Me.lblDate.Text = "Date:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(259, 151)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 28
        Me.lblYear.Text = "Year:"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(259, 192)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(66, 13)
        Me.lblDay.TabIndex = 29
        Me.lblDay.Text = "Day of Year:"
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.Location = New System.Drawing.Point(259, 233)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(48, 13)
        Me.lblElement.TabIndex = 30
        Me.lblElement.Text = "Element:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(169, 323)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 33
        Me.lblTo.Text = "To:"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(10, 322)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblFrom.TabIndex = 34
        Me.lblFrom.Text = "From:"
        '
        'lblReceiverTo
        '
        Me.lblReceiverTo.AutoSize = True
        Me.lblReceiverTo.Location = New System.Drawing.Point(169, 322)
        Me.lblReceiverTo.Name = "lblReceiverTo"
        Me.lblReceiverTo.Size = New System.Drawing.Size(23, 13)
        Me.lblReceiverTo.TabIndex = 37
        Me.lblReceiverTo.Text = "To:"
        '
        'lblReceiverFrom
        '
        Me.lblReceiverFrom.AutoSize = True
        Me.lblReceiverFrom.Location = New System.Drawing.Point(10, 322)
        Me.lblReceiverFrom.Name = "lblReceiverFrom"
        Me.lblReceiverFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblReceiverFrom.TabIndex = 38
        Me.lblReceiverFrom.Text = "From:"
        '
        'cmdSummary
        '
        Me.cmdSummary.Location = New System.Drawing.Point(303, 348)
        Me.cmdSummary.Name = "cmdSummary"
        Me.cmdSummary.Size = New System.Drawing.Size(105, 21)
        Me.cmdSummary.TabIndex = 39
        Me.cmdSummary.Tag = "Summary"
        Me.cmdSummary.Text = "Summary Options"
        Me.cmdSummary.UseVisualStyleBackColor = True
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(259, 274)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(40, 13)
        Me.lblMonth.TabIndex = 41
        Me.lblMonth.Text = "Month:"
        '
        'lblNewColName
        '
        Me.lblNewColName.AutoSize = True
        Me.lblNewColName.Location = New System.Drawing.Point(14, 352)
        Me.lblNewColName.Name = "lblNewColName"
        Me.lblNewColName.Size = New System.Drawing.Size(101, 13)
        Me.lblNewColName.TabIndex = 42
        Me.lblNewColName.Text = "New Column Name:"
        '
        'ucrReceiverMonth
        '
        Me.ucrReceiverMonth.frmParent = Me
        Me.ucrReceiverMonth.Location = New System.Drawing.Point(259, 289)
        Me.ucrReceiverMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMonth.strNcFilePath = ""
        Me.ucrReceiverMonth.TabIndex = 44
        Me.ucrReceiverMonth.ucrSelector = Nothing
        '
        'ucrInputSave
        '
        Me.ucrInputSave.AddQuotesIfUnrecognised = True
        Me.ucrInputSave.IsMultiline = False
        Me.ucrInputSave.IsReadOnly = False
        Me.ucrInputSave.Location = New System.Drawing.Point(117, 349)
        Me.ucrInputSave.Name = "ucrInputSave"
        Me.ucrInputSave.Size = New System.Drawing.Size(175, 21)
        Me.ucrInputSave.TabIndex = 43
        '
        'ucrReceiverFrom
        '
        Me.ucrReceiverFrom.frmParent = Me
        Me.ucrReceiverFrom.Location = New System.Drawing.Point(46, 319)
        Me.ucrReceiverFrom.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFrom.Name = "ucrReceiverFrom"
        Me.ucrReceiverFrom.Selector = Nothing
        Me.ucrReceiverFrom.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFrom.strNcFilePath = ""
        Me.ucrReceiverFrom.TabIndex = 36
        Me.ucrReceiverFrom.ucrSelector = Nothing
        '
        'ucrReceiverTo
        '
        Me.ucrReceiverTo.frmParent = Me
        Me.ucrReceiverTo.Location = New System.Drawing.Point(195, 319)
        Me.ucrReceiverTo.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTo.Name = "ucrReceiverTo"
        Me.ucrReceiverTo.Selector = Nothing
        Me.ucrReceiverTo.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverTo.strNcFilePath = ""
        Me.ucrReceiverTo.TabIndex = 35
        Me.ucrReceiverTo.ucrSelector = Nothing
        '
        'ucrNudTo
        '
        Me.ucrNudTo.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTo.Location = New System.Drawing.Point(195, 319)
        Me.ucrNudTo.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Name = "ucrNudTo"
        Me.ucrNudTo.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTo.TabIndex = 32
        Me.ucrNudTo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudFrom
        '
        Me.ucrNudFrom.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFrom.Location = New System.Drawing.Point(46, 319)
        Me.ucrNudFrom.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFrom.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Name = "ucrNudFrom"
        Me.ucrNudFrom.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudFrom.TabIndex = 31
        Me.ucrNudFrom.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrReceiverElement
        '
        Me.ucrReceiverElement.frmParent = Me
        Me.ucrReceiverElement.Location = New System.Drawing.Point(259, 248)
        Me.ucrReceiverElement.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElement.Name = "ucrReceiverElement"
        Me.ucrReceiverElement.Selector = Nothing
        Me.ucrReceiverElement.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverElement.strNcFilePath = ""
        Me.ucrReceiverElement.TabIndex = 24
        Me.ucrReceiverElement.ucrSelector = Nothing
        '
        'ucrReceiverDOY
        '
        Me.ucrReceiverDOY.frmParent = Me
        Me.ucrReceiverDOY.Location = New System.Drawing.Point(259, 207)
        Me.ucrReceiverDOY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDOY.Name = "ucrReceiverDOY"
        Me.ucrReceiverDOY.Selector = Nothing
        Me.ucrReceiverDOY.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDOY.strNcFilePath = ""
        Me.ucrReceiverDOY.TabIndex = 23
        Me.ucrReceiverDOY.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(259, 166)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 22
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(259, 125)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 21
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(259, 84)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 20
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 380)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(399, 52)
        Me.ucrBase.TabIndex = 12
        '
        'ucrPnlAnnual
        '
        Me.ucrPnlAnnual.Location = New System.Drawing.Point(28, 10)
        Me.ucrPnlAnnual.Name = "ucrPnlAnnual"
        Me.ucrPnlAnnual.Size = New System.Drawing.Size(381, 35)
        Me.ucrPnlAnnual.TabIndex = 18
        '
        'ucrSelectorVariable
        '
        Me.ucrSelectorVariable.bShowHiddenColumns = False
        Me.ucrSelectorVariable.bUseCurrentFilter = True
        Me.ucrSelectorVariable.Location = New System.Drawing.Point(9, 59)
        Me.ucrSelectorVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorVariable.Name = "ucrSelectorVariable"
        Me.ucrSelectorVariable.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorVariable.TabIndex = 45
        '
        'dlgClimaticSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 443)
        Me.Controls.Add(Me.ucrSelectorVariable)
        Me.Controls.Add(Me.ucrReceiverMonth)
        Me.Controls.Add(Me.lblNewColName)
        Me.Controls.Add(Me.ucrInputSave)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.cmdSummary)
        Me.Controls.Add(Me.lblReceiverFrom)
        Me.Controls.Add(Me.lblReceiverTo)
        Me.Controls.Add(Me.ucrReceiverFrom)
        Me.Controls.Add(Me.ucrReceiverTo)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.ucrNudTo)
        Me.Controls.Add(Me.ucrNudFrom)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverElement)
        Me.Controls.Add(Me.ucrReceiverDOY)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.rdoWithinYear)
        Me.Controls.Add(Me.rdoAnnualVariable)
        Me.Controls.Add(Me.rdoAnnual)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlAnnual)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimaticSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Climatic Summary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents rdoAnnual As RadioButton
    Friend WithEvents rdoAnnualVariable As RadioButton
    Friend WithEvents rdoWithinYear As RadioButton
    Friend WithEvents ucrPnlAnnual As UcrPanel
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrReceiverElement As ucrReceiverSingle
    Friend WithEvents ucrReceiverDOY As ucrReceiverSingle
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents lblStation As Label
    Friend WithEvents lblElement As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents ucrNudTo As ucrNud
    Friend WithEvents ucrNudFrom As ucrNud
    Friend WithEvents lblReceiverFrom As Label
    Friend WithEvents lblReceiverTo As Label
    Friend WithEvents ucrReceiverFrom As ucrReceiverSingle
    Friend WithEvents ucrReceiverTo As ucrReceiverSingle
    Friend WithEvents cmdSummary As Button
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblNewColName As Label
    Friend WithEvents ucrInputSave As ucrInputTextBox
    Friend WithEvents ucrReceiverMonth As ucrReceiverSingle
    Friend WithEvents ucrSelectorVariable As ucrSelectorByDataFrameAddRemove
End Class
