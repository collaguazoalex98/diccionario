<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lvDiccionario = New System.Windows.Forms.ListView()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(159, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DICCIONARIO"
        '
        'lvDiccionario
        '
        Me.lvDiccionario.HideSelection = False
        Me.lvDiccionario.Location = New System.Drawing.Point(25, 102)
        Me.lvDiccionario.Name = "lvDiccionario"
        Me.lvDiccionario.Size = New System.Drawing.Size(374, 295)
        Me.lvDiccionario.TabIndex = 1
        Me.lvDiccionario.UseCompatibleStateImageBehavior = False
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRegresar.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnRegresar.Location = New System.Drawing.Point(456, 142)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(165, 106)
        Me.btnRegresar.TabIndex = 2
        Me.btnRegresar.Text = "Ingresar mas Palabras"
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Diccionario.My.Resources.Resources.image
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(291, 243)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Diccionario.My.Resources.Resources.image
        Me.PictureBox2.Location = New System.Drawing.Point(281, -3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(291, 243)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Diccionario.My.Resources.Resources.image
        Me.PictureBox3.Location = New System.Drawing.Point(570, -3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(232, 243)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.Diccionario.My.Resources.Resources.E68E2DEE2
        Me.PictureBox6.Location = New System.Drawing.Point(-1, 235)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(260, 203)
        Me.PictureBox6.TabIndex = 8
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Diccionario.My.Resources.Resources.E68E2DEE2
        Me.PictureBox5.Location = New System.Drawing.Point(281, 235)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(260, 203)
        Me.PictureBox5.TabIndex = 7
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Diccionario.My.Resources.Resources.E68E2DEE2
        Me.PictureBox4.Location = New System.Drawing.Point(542, 246)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(260, 203)
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.lvDiccionario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lvDiccionario As ListView
    Friend WithEvents btnRegresar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
End Class
