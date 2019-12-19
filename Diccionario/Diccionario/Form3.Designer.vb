<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.lblPalabra = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.txtDefinicion = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPalabra
        '
        Me.lblPalabra.AutoSize = True
        Me.lblPalabra.Location = New System.Drawing.Point(380, 77)
        Me.lblPalabra.Name = "lblPalabra"
        Me.lblPalabra.Size = New System.Drawing.Size(62, 20)
        Me.lblPalabra.TabIndex = 0
        Me.lblPalabra.Text = "palabra"
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(329, 222)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(160, 57)
        Me.btnRegresar.TabIndex = 2
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'txtDefinicion
        '
        Me.txtDefinicion.Location = New System.Drawing.Point(182, 147)
        Me.txtDefinicion.Name = "txtDefinicion"
        Me.txtDefinicion.Size = New System.Drawing.Size(477, 26)
        Me.txtDefinicion.TabIndex = 3
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Diccionario.My.Resources.Resources.images
        Me.PictureBox3.Location = New System.Drawing.Point(13, 241)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(286, 182)
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Diccionario.My.Resources.Resources.diccionario_box
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(304, 206)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Diccionario.My.Resources.Resources.diccionario_box
        Me.PictureBox2.Location = New System.Drawing.Point(495, 241)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(304, 206)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Diccionario.My.Resources.Resources.images
        Me.PictureBox4.Location = New System.Drawing.Point(495, 12)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(286, 182)
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.txtDefinicion)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.lblPalabra)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPalabra As Label
    Friend WithEvents btnRegresar As Button
    Friend WithEvents txtDefinicion As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
