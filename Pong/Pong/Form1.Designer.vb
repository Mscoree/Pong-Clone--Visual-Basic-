<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Tiles = New System.Windows.Forms.PictureBox()
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Tiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tiles
        '
        Me.Tiles.Image = CType(resources.GetObject("Tiles.Image"), System.Drawing.Image)
        Me.Tiles.Location = New System.Drawing.Point(533, 294)
        Me.Tiles.Name = "Tiles"
        Me.Tiles.Size = New System.Drawing.Size(200, 200)
        Me.Tiles.TabIndex = 1
        Me.Tiles.TabStop = False
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 506)
        Me.Controls.Add(Me.Tiles)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Tiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tiles As System.Windows.Forms.PictureBox
    Friend WithEvents DirectoryEntry1 As System.DirectoryServices.DirectoryEntry
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
