Imports System.IO
Imports System.Diagnostics
Imports System.Threading

Public Class Form1
    Dim WithEvents watcher As FileSystemWatcher
    Dim monitorThread As Thread

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Filtro in checkbox altrimenti senza è illegibile troppe modifiche nel changed
        clbEvents.Items.Add("Changed")
        clbEvents.Items.Add("Created")
        clbEvents.Items.Add("Deleted")
        clbEvents.Items.Add("Renamed")

        clbEvents.SetItemChecked(0, True)
        clbEvents.SetItemChecked(1, True)
        clbEvents.SetItemChecked(2, True)
        clbEvents.SetItemChecked(3, True)
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Using folderDialog As New FolderBrowserDialog
            If folderDialog.ShowDialog() = DialogResult.OK Then
                txtPath.Text = folderDialog.SelectedPath
            End If
        End Using
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If String.IsNullOrWhiteSpace(txtPath.Text) OrElse Not Directory.Exists(txtPath.Text) Then
            MessageBox.Show("Inserisci una cartella valida.")
            Return
        End If

        If String.IsNullOrWhiteSpace(txtProcessName.Text) Then
            MessageBox.Show("Inserisci il nome del processo.")
            Return
        End If

        lstEvents.Items.Add($"In attesa dell'avvio del processo {txtProcessName.Text}.exe...")
        monitorThread = New Thread(Sub() MonitorProcessAndStartWatcher(txtProcessName.Text))
        monitorThread.IsBackground = True
        monitorThread.Start()
    End Sub

    Private Sub MonitorProcessAndStartWatcher(processName As String)
        ' Attesa del processo
        Do While Process.GetProcessesByName(processName).Length = 0
            Thread.Sleep(1000)
        Loop

        ' Processo trovato, parte il monitoraggio
        Invoke(Sub()
                   lstEvents.Items.Add($"{processName}.exe avviato. Inizio monitoraggio...")
                   StartWatcher()
               End Sub)
    End Sub

    Private Sub StartWatcher()
        watcher = New FileSystemWatcher(txtPath.Text)
        watcher.IncludeSubdirectories = True
        watcher.Filter = txtFilter.Text
        watcher.SynchronizingObject = Me ' per non mandare in errore il cross thread altrimenti dice che non è valida

        ' notifica base grazie a chatgpt
        watcher.NotifyFilter = NotifyFilters.FileName Or NotifyFilters.DirectoryName Or NotifyFilters.LastWrite

        ' filtro di abilitazione degli eventi selezionati nel checkbox
        If clbEvents.GetItemChecked(0) Then AddHandler watcher.Changed, AddressOf OnChanged
        If clbEvents.GetItemChecked(1) Then AddHandler watcher.Created, AddressOf OnCreated
        If clbEvents.GetItemChecked(2) Then AddHandler watcher.Deleted, AddressOf OnDeleted
        If clbEvents.GetItemChecked(3) Then AddHandler watcher.Renamed, AddressOf OnRenamed

        AddHandler watcher.Error, AddressOf OnError

        watcher.EnableRaisingEvents = True
    End Sub

    ' stringa degli eventi
    Private Sub OnChanged(sender As Object, e As FileSystemEventArgs)
        lstEvents.Items.Add($"Modificato: {e.FullPath}")
    End Sub

    Private Sub OnCreated(sender As Object, e As FileSystemEventArgs)
        lstEvents.Items.Add($"Creato: {e.FullPath}")
    End Sub

    Private Sub OnDeleted(sender As Object, e As FileSystemEventArgs)
        lstEvents.Items.Add($"Eliminato: {e.FullPath}")
    End Sub

    Private Sub OnRenamed(sender As Object, e As RenamedEventArgs)
        lstEvents.Items.Add($"Rinominato: {e.OldFullPath} → {e.FullPath}")
    End Sub

    Private Sub OnError(sender As Object, e As ErrorEventArgs)
        lstEvents.Items.Add($"Errore: {e.GetException().Message}")
    End Sub
End Class
