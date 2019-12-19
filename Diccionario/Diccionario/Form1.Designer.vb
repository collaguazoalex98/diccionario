<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPalabra = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDefinicion = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 299)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 71)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(348, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Palabra"
        '
        'txtPalabra
        '
        Me.txtPalabra.Location = New System.Drawing.Point(280, 82)
        Me.txtPalabra.Name = "txtPalabra"
        Me.txtPalabra.Size = New System.Drawing.Size(236, 26)
        Me.txtPalabra.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(348, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Definicion "
        '
        'txtDefinicion
        '
        Me.txtDefinicion.Location = New System.Drawing.Point(280, 202)
        Me.txtDefinicion.Name = "txtDefinicion"
        Me.txtDefinicion.Size = New System.Drawing.Size(236, 26)
        Me.txtDefinicion.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(199, 299)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(156, 71)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Diccionario.My.Resources.Resources.tenor
        Me.PictureBox2.Location = New System.Drawing.Point(12, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(520, 381)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(372, 299)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 71)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Guardar Datos"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(-69, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(407, 252)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(656, 299)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(149, 38)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "examinar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(600, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 257)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "imagen"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 423)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtDefinicion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPalabra)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPalabra As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDefinicion As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button4 As Button
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents GroupBox1 As GroupBox
End Class
