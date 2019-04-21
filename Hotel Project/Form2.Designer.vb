<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SETUPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HallSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CUSTOMERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerPaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservationFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelModifyReservationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelReservatioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyReservationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservationDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuStrip1.BackgroundImage = CType(resources.GetObject("MenuStrip1.BackgroundImage"), System.Drawing.Image)
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SETUPToolStripMenuItem, Me.CUSTOMERToolStripMenuItem, Me.ToolStripMenuItem1, Me.REPORTSToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(585, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SETUPToolStripMenuItem
        '
        Me.SETUPToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SETUPToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RoomSetupToolStripMenuItem, Me.HallSetupToolStripMenuItem, Me.MenuSetupToolStripMenuItem})
        Me.SETUPToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SETUPToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SETUPToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SETUPToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SETUPToolStripMenuItem.Name = "SETUPToolStripMenuItem"
        Me.SETUPToolStripMenuItem.Size = New System.Drawing.Size(75, 29)
        Me.SETUPToolStripMenuItem.Tag = ""
        Me.SETUPToolStripMenuItem.Text = "SETUP"
        '
        'RoomSetupToolStripMenuItem
        '
        Me.RoomSetupToolStripMenuItem.BackgroundImage = CType(resources.GetObject("RoomSetupToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.RoomSetupToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RoomSetupToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomSetupToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window
        Me.RoomSetupToolStripMenuItem.Name = "RoomSetupToolStripMenuItem"
        Me.RoomSetupToolStripMenuItem.Size = New System.Drawing.Size(175, 26)
        Me.RoomSetupToolStripMenuItem.Text = "Room Setup"
        '
        'HallSetupToolStripMenuItem
        '
        Me.HallSetupToolStripMenuItem.BackgroundImage = CType(resources.GetObject("HallSetupToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.HallSetupToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HallSetupToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window
        Me.HallSetupToolStripMenuItem.Name = "HallSetupToolStripMenuItem"
        Me.HallSetupToolStripMenuItem.Size = New System.Drawing.Size(175, 26)
        Me.HallSetupToolStripMenuItem.Text = "Hall Setup"
        '
        'MenuSetupToolStripMenuItem
        '
        Me.MenuSetupToolStripMenuItem.BackgroundImage = CType(resources.GetObject("MenuSetupToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.MenuSetupToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuSetupToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuSetupToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window
        Me.MenuSetupToolStripMenuItem.Name = "MenuSetupToolStripMenuItem"
        Me.MenuSetupToolStripMenuItem.Size = New System.Drawing.Size(175, 26)
        Me.MenuSetupToolStripMenuItem.Text = "Menu Setup"
        '
        'CUSTOMERToolStripMenuItem
        '
        Me.CUSTOMERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerRegistrationToolStripMenuItem, Me.CustomerPaymentToolStripMenuItem})
        Me.CUSTOMERToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CUSTOMERToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CUSTOMERToolStripMenuItem.Name = "CUSTOMERToolStripMenuItem"
        Me.CUSTOMERToolStripMenuItem.Size = New System.Drawing.Size(117, 29)
        Me.CUSTOMERToolStripMenuItem.Text = "CUSTOMER"
        '
        'CustomerRegistrationToolStripMenuItem
        '
        Me.CustomerRegistrationToolStripMenuItem.BackgroundImage = CType(resources.GetObject("CustomerRegistrationToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.CustomerRegistrationToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CustomerRegistrationToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerRegistrationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window
        Me.CustomerRegistrationToolStripMenuItem.Name = "CustomerRegistrationToolStripMenuItem"
        Me.CustomerRegistrationToolStripMenuItem.Size = New System.Drawing.Size(252, 26)
        Me.CustomerRegistrationToolStripMenuItem.Text = "Customer Registration"
        '
        'CustomerPaymentToolStripMenuItem
        '
        Me.CustomerPaymentToolStripMenuItem.BackgroundImage = CType(resources.GetObject("CustomerPaymentToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.CustomerPaymentToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CustomerPaymentToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerPaymentToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window
        Me.CustomerPaymentToolStripMenuItem.Name = "CustomerPaymentToolStripMenuItem"
        Me.CustomerPaymentToolStripMenuItem.Size = New System.Drawing.Size(252, 26)
        Me.CustomerPaymentToolStripMenuItem.Text = "Customer Payment"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReservationFormToolStripMenuItem, Me.CancelModifyReservationToolStripMenuItem})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(135, 29)
        Me.ToolStripMenuItem1.Text = "RESERVATION"
        '
        'ReservationFormToolStripMenuItem
        '
        Me.ReservationFormToolStripMenuItem.BackgroundImage = CType(resources.GetObject("ReservationFormToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.ReservationFormToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ReservationFormToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReservationFormToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window
        Me.ReservationFormToolStripMenuItem.Name = "ReservationFormToolStripMenuItem"
        Me.ReservationFormToolStripMenuItem.Size = New System.Drawing.Size(290, 26)
        Me.ReservationFormToolStripMenuItem.Text = "Reservation Form"
        '
        'CancelModifyReservationToolStripMenuItem
        '
        Me.CancelModifyReservationToolStripMenuItem.BackgroundImage = CType(resources.GetObject("CancelModifyReservationToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.CancelModifyReservationToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelModifyReservationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CancelReservatioToolStripMenuItem, Me.ModifyReservationToolStripMenuItem})
        Me.CancelModifyReservationToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelModifyReservationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window
        Me.CancelModifyReservationToolStripMenuItem.Name = "CancelModifyReservationToolStripMenuItem"
        Me.CancelModifyReservationToolStripMenuItem.Size = New System.Drawing.Size(290, 26)
        Me.CancelModifyReservationToolStripMenuItem.Text = "Cancel/Modify Reservation"
        '
        'CancelReservatioToolStripMenuItem
        '
        Me.CancelReservatioToolStripMenuItem.BackgroundImage = CType(resources.GetObject("CancelReservatioToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.CancelReservatioToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelReservatioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window
        Me.CancelReservatioToolStripMenuItem.Name = "CancelReservatioToolStripMenuItem"
        Me.CancelReservatioToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.CancelReservatioToolStripMenuItem.Text = "Cancel Reservation"
        '
        'ModifyReservationToolStripMenuItem
        '
        Me.ModifyReservationToolStripMenuItem.BackgroundImage = CType(resources.GetObject("ModifyReservationToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.ModifyReservationToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ModifyReservationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window
        Me.ModifyReservationToolStripMenuItem.Name = "ModifyReservationToolStripMenuItem"
        Me.ModifyReservationToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.ModifyReservationToolStripMenuItem.Text = "Modify Reservation"
        '
        'REPORTSToolStripMenuItem
        '
        Me.REPORTSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerDetailsToolStripMenuItem, Me.ReservationDetailsToolStripMenuItem})
        Me.REPORTSToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REPORTSToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.REPORTSToolStripMenuItem.Name = "REPORTSToolStripMenuItem"
        Me.REPORTSToolStripMenuItem.Size = New System.Drawing.Size(100, 29)
        Me.REPORTSToolStripMenuItem.Text = "REPORTS"
        '
        'CustomerDetailsToolStripMenuItem
        '
        Me.CustomerDetailsToolStripMenuItem.BackgroundImage = CType(resources.GetObject("CustomerDetailsToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.CustomerDetailsToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CustomerDetailsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerDetailsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window
        Me.CustomerDetailsToolStripMenuItem.Name = "CustomerDetailsToolStripMenuItem"
        Me.CustomerDetailsToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.CustomerDetailsToolStripMenuItem.Text = "Customer Details"
        '
        'ReservationDetailsToolStripMenuItem
        '
        Me.ReservationDetailsToolStripMenuItem.BackgroundImage = CType(resources.GetObject("ReservationDetailsToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.ReservationDetailsToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ReservationDetailsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReservationDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ReservationDetailsToolStripMenuItem.Name = "ReservationDetailsToolStripMenuItem"
        Me.ReservationDetailsToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.ReservationDetailsToolStripMenuItem.Text = "Reservation Details"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.EXITToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.EXITToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXITToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.EXITToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(59, 29)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.BackgroundImage = CType(resources.GetObject("LogoutToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.LogoutToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.LogoutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window
        Me.LogoutToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(585, 484)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SETUPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HallSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CUSTOMERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerPaymentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REPORTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReservationDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReservationFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelModifyReservationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelReservatioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyReservationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
