﻿Imports System.Windows.Forms

Public Class frmInicioF



    Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long


    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        '     Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

  

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        

        If lbrol.Text = "INVITADO" Then
            ADMINISTRADOR.Enabled = False
            USUARIO.Enabled = False


        Else
            If lbrol.Text = "USUARIO" Then
                ADMINISTRADOR.Enabled = False



            Else
                If lbrol.Text = "ADMINISTRADOR" Then

                    '        Else
                    '            If lbrol.Text = "UsuarioREDRUBI" Then
                    '                fexpobeni.Enabled = False
                    '                redrubi.Enabled = True
                    '                emfopesbe.Enabled = False
                    '                postgrado.Enabled = False
                    '                registroR.Enabled = False
                    '                SUPERADMIN.Enabled = False
                    '            Else
                    '                If lbrol.Text = "AdministradorREDRUBI" Then
                    '                    fexpobeni.Enabled = False
                    '                    redrubi.Enabled = True
                    '                    emfopesbe.Enabled = False
                    '                    postgrado.Enabled = False
                    '                    SUPERADMIN.Enabled = False
                    '                Else
                    '                    If lbrol.Text = "UsuarioPOSTGRADO" Then
                    '                        fexpobeni.Enabled = False
                    '                        redrubi.Enabled = False
                    '                        emfopesbe.Enabled = False
                    '                        postgrado.Enabled = True
                    '                        registroP.Enabled = False
                    '                        SUPERADMIN.Enabled = False
                    '                    Else
                    '                        If lbrol.Text = "AdministradorPOSTGRADO" Then
                    '                            fexpobeni.Enabled = False
                    '                            redrubi.Enabled = False
                    '                            emfopesbe.Enabled = False
                    '                            postgrado.Enabled = True
                    '                            SUPERADMIN.Enabled = False
                    '                        Else
                    '                            If lbrol.Text = "UsuarioCAMPOFERIAL" Then
                    '                                fexpobeni.Enabled = True
                    '                                redrubi.Enabled = False
                    '                                emfopesbe.Enabled = False
                    '                                postgrado.Enabled = False
                    '                                registroF.Enabled = False
                    '                                SUPERADMIN.Enabled = False
                    '                            Else
                    '                                If lbrol.Text = "AdministradorCAMPOFERIAL" Then
                    '                                    fexpobeni.Enabled = True
                    '                                    redrubi.Enabled = False
                    '                                    emfopesbe.Enabled = False
                    '                                    postgrado.Enabled = False
                    '                                    SUPERADMIN.Enabled = False
                    '                                Else
                    '                                    MessageBox.Show("USAURIO INCORRECTO")
                    '                                    Me.Close()
                    '                                    frmLogin.Show()
                    '                                End If
                    '                            End If
                    '                        End If
                    '                    End If
                    '                End If
                    '            End If
                End If
            End If
        End If

        Label1.Focus()

    End Sub

   

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

   

   


    Private Sub REGISTRODEUSUARIOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REGISTRODEUSUARIOSToolStripMenuItem.Click
        frmUsuario.MdiParent = Me
        frmUsuario.Show()
    End Sub

  
 
    Private Sub REGISTROToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REGISTROToolStripMenuItem.Click
        frmRegistro.MdiParent = Me
        frmRegistro.Show()
    End Sub

    Private Sub EDITARREGISTRODEARCHIVOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EDITARREGISTRODEARCHIVOSToolStripMenuItem.Click
        frmEditarRegistro.MdiParent = Me
        frmEditarRegistro.Show()
    End Sub

  
    Private Sub ReportePorNumeroDeChequeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportePorNumeroDeChequeToolStripMenuItem.Click
        frmReportePorNroCheque.MdiParent = Me
        frmReportePorNroCheque.Show()

    End Sub

    Private Sub ReportePorNombreBeneficiarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportePorNombreBeneficiarioToolStripMenuItem.Click
        frmReportePorNombreBeneficiario.MdiParent = Me
        frmReportePorNombreBeneficiario.Show()
    End Sub

    Private Sub REPORTESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REPORTESToolStripMenuItem.Click
        frmReporte.MdiParent = Me
        frmReporte.Show()
    End Sub

 

    
    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        End

    End Sub

    Private Sub ReportePorTomoYMomentoContableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportePorTomoYMomentoContableToolStripMenuItem.Click
        frmReportePorTomoMomento.MdiParent = Me
        frmReportePorTomoMomento.Show()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        End
    End Sub

    Private Sub HelpMenu_Click(sender As Object, e As EventArgs) Handles HelpMenu.Click
        'Dim rutaEjecutable As String = System.IO.Directory.GetCurrentDirectory().ToString
        ''Los archivos de la documentación HTML están en una carpeta llamada HTML
        'System.Diagnostics.Process.Start(rutaEjecutable & "\HTML\Ejemplo de prueba.html")
        'Dim rutaEjecutable As String = System.IO.Directory.GetCurrentDirectory().ToString
        'System.Diagnostics.Process.Start(rutaEjecutable & "\prueba para archivos.chm")
    End Sub

    Private Sub ContentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContentsToolStripMenuItem.Click
        'Dim rutaEjecutable As String = System.IO.Directory.GetCurrentDirectory().ToString
        'System.Diagnostics.Process.Start(rutaEjecutable & "\Ayuda Sistema De Archivos.chm")
        Shell("explorer.exe root = C:\Program Files\SAOWL\Ayuda Sistema De Archivos.chm", vbNormalFocus)
 

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        frmAcercaDe.ShowDialog()
    End Sub

    Private Sub WindowsMenu_Click(sender As Object, e As EventArgs) Handles WindowsMenu.Click

    End Sub

    Private Sub MenuStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip.ItemClicked

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class
