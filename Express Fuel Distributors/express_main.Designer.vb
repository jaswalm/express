<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class express_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(express_main))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplicationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.strip_menu_main = New System.Windows.Forms.MenuStrip()
        Me.status_label = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.status_strip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.express_fuel_home = New System.Windows.Forms.TabControl()
        Me.express_tab_1 = New System.Windows.Forms.TabPage()
        Me.star_tab_2 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.strip_menu_main.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.express_fuel_home.SuspendLayout()
        Me.star_tab_2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.CloseToolStripMenuItem.Text = "Login"
        '
        'ApplicationsToolStripMenuItem
        '
        Me.ApplicationsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatorToolStripMenuItem})
        Me.ApplicationsToolStripMenuItem.Name = "ApplicationsToolStripMenuItem"
        Me.ApplicationsToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.ApplicationsToolStripMenuItem.Text = "Applications"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.CalculatorToolStripMenuItem.Text = "Calculator"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'strip_menu_main
        '
        Me.strip_menu_main.BackColor = System.Drawing.Color.Silver
        Me.strip_menu_main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ApplicationsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.strip_menu_main.Location = New System.Drawing.Point(0, 0)
        Me.strip_menu_main.Name = "strip_menu_main"
        Me.strip_menu_main.Size = New System.Drawing.Size(1187, 24)
        Me.strip_menu_main.TabIndex = 4
        '
        'status_label
        '
        Me.status_label.AutoSize = True
        Me.status_label.Location = New System.Drawing.Point(1078, 8)
        Me.status_label.Name = "status_label"
        Me.status_label.Size = New System.Drawing.Size(0, 13)
        Me.status_label.TabIndex = 5
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.status_strip})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 502)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1187, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'status_strip
        '
        Me.status_strip.Name = "status_strip"
        Me.status_strip.Size = New System.Drawing.Size(0, 17)
        '
        'express_fuel_home
        '
        Me.express_fuel_home.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.express_fuel_home.Controls.Add(Me.express_tab_1)
        Me.express_fuel_home.Controls.Add(Me.star_tab_2)
        Me.express_fuel_home.Dock = System.Windows.Forms.DockStyle.Top
        Me.express_fuel_home.Location = New System.Drawing.Point(0, 24)
        Me.express_fuel_home.Name = "express_fuel_home"
        Me.express_fuel_home.SelectedIndex = 0
        Me.express_fuel_home.Size = New System.Drawing.Size(1187, 87)
        Me.express_fuel_home.TabIndex = 8
        '
        'express_tab_1
        '
        Me.express_tab_1.BackColor = System.Drawing.Color.White
        Me.express_tab_1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.express_tab_1.Location = New System.Drawing.Point(4, 25)
        Me.express_tab_1.Name = "express_tab_1"
        Me.express_tab_1.Padding = New System.Windows.Forms.Padding(3)
        Me.express_tab_1.Size = New System.Drawing.Size(1179, 58)
        Me.express_tab_1.TabIndex = 0
        Me.express_tab_1.Text = "Express Fuel"
        Me.express_tab_1.ToolTipText = "Express Fuel Distributors Inc."
        '
        'star_tab_2
        '
        Me.star_tab_2.BackColor = System.Drawing.Color.White
        Me.star_tab_2.Controls.Add(Me.Button6)
        Me.star_tab_2.Controls.Add(Me.Button5)
        Me.star_tab_2.Controls.Add(Me.Button4)
        Me.star_tab_2.Controls.Add(Me.Button3)
        Me.star_tab_2.Controls.Add(Me.Button2)
        Me.star_tab_2.Controls.Add(Me.Button1)
        Me.star_tab_2.Location = New System.Drawing.Point(4, 25)
        Me.star_tab_2.Name = "star_tab_2"
        Me.star_tab_2.Padding = New System.Windows.Forms.Padding(3)
        Me.star_tab_2.Size = New System.Drawing.Size(1179, 58)
        Me.star_tab_2.TabIndex = 1
        Me.star_tab_2.Text = "Star Tank"
        Me.star_tab_2.ToolTipText = "Star Tank Lines Inc."
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 111)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel1.Size = New System.Drawing.Size(1187, 391)
        Me.Panel1.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.MediumBlue
        Me.Button1.FlatAppearance.BorderSize = 6
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(3, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 45)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.Color.MediumBlue
        Me.Button2.FlatAppearance.BorderSize = 6
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(533, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 45)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.BackColor = System.Drawing.Color.MediumBlue
        Me.Button3.FlatAppearance.BorderSize = 6
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Location = New System.Drawing.Point(427, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 45)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.AutoSize = True
        Me.Button4.BackColor = System.Drawing.Color.MediumBlue
        Me.Button4.FlatAppearance.BorderSize = 6
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Transparent
        Me.Button4.Location = New System.Drawing.Point(321, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 45)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.AutoSize = True
        Me.Button5.BackColor = System.Drawing.Color.MediumBlue
        Me.Button5.FlatAppearance.BorderSize = 6
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.Transparent
        Me.Button5.Location = New System.Drawing.Point(215, 6)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 45)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.AutoSize = True
        Me.Button6.BackColor = System.Drawing.Color.MediumBlue
        Me.Button6.FlatAppearance.BorderSize = 6
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.Transparent
        Me.Button6.Location = New System.Drawing.Point(109, 6)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 45)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'express_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1187, 524)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.express_fuel_home)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.status_label)
        Me.Controls.Add(Me.strip_menu_main)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.strip_menu_main
        Me.Name = "express_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Express Fuel Distributors Inc."
        Me.TopMost = True
        Me.strip_menu_main.ResumeLayout(False)
        Me.strip_menu_main.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.express_fuel_home.ResumeLayout(False)
        Me.star_tab_2.ResumeLayout(False)
        Me.star_tab_2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApplicationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents strip_menu_main As MenuStrip
    Friend WithEvents status_label As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents status_strip As ToolStripStatusLabel
    Friend WithEvents express_fuel_home As TabControl
    Friend WithEvents express_tab_1 As TabPage
    Friend WithEvents star_tab_2 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
