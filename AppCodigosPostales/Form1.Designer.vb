<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
    Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
    DataGridView1 = New DataGridView()
    cboEstado = New ComboBox()
    cboMunicipio = New ComboBox()
    CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
    SuspendLayout()
    ' 
    ' DataGridView1
    ' 
    DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
    DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = SystemColors.Control
    DataGridViewCellStyle1.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
    DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
    DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    DataGridView1.ColumnHeadersHeight = 50
    DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = SystemColors.Window
    DataGridViewCellStyle2.Font = New Font("Segoe UI", 20F)
    DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
    DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
    DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
    DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
    DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
    DataGridView1.Location = New Point(12, 100)
    DataGridView1.Name = "DataGridView1"
    DataGridView1.Size = New Size(776, 338)
    DataGridView1.TabIndex = 0
    ' 
    ' cboEstado
    ' 
    cboEstado.Font = New Font("Segoe UI", 16F)
    cboEstado.FormattingEnabled = True
    cboEstado.Location = New Point(12, 26)
    cboEstado.Name = "cboEstado"
    cboEstado.Size = New Size(255, 38)
    cboEstado.TabIndex = 1
    ' 
    ' cboMunicipio
    ' 
    cboMunicipio.Font = New Font("Segoe UI", 16F)
    cboMunicipio.FormattingEnabled = True
    cboMunicipio.Location = New Point(288, 26)
    cboMunicipio.Name = "cboMunicipio"
    cboMunicipio.Size = New Size(255, 38)
    cboMunicipio.TabIndex = 2
    ' 
    ' Form1
    ' 
    AutoScaleDimensions = New SizeF(7F, 15F)
    AutoScaleMode = AutoScaleMode.Font
    ClientSize = New Size(800, 450)
    Controls.Add(cboMunicipio)
    Controls.Add(cboEstado)
    Controls.Add(DataGridView1)
    Name = "Form1"
    Text = "Form1"
    CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
    ResumeLayout(False)
  End Sub

  Friend WithEvents DataGridView1 As DataGridView
  Friend WithEvents cboEstado As ComboBox
  Friend WithEvents cboMunicipio As ComboBox

End Class
