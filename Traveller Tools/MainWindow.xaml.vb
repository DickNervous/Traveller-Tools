Class MainWindow
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs) Handles MyBase.Loaded

        Dim Traveller_System_DataDataSet As Traveller_Tools.Traveller_System_DataDataSet = CType(Me.FindResource("Traveller_System_DataDataSet"), Traveller_Tools.Traveller_System_DataDataSet)

        'Load data into the table System_Master. You can modify this code as needed.
        Dim Traveller_System_DataDataSetSystem_MasterTableAdapter As Traveller_Tools.Traveller_System_DataDataSetTableAdapters.System_MasterTableAdapter = New Traveller_Tools.Traveller_System_DataDataSetTableAdapters.System_MasterTableAdapter()
        Traveller_System_DataDataSetSystem_MasterTableAdapter.Fill(Traveller_System_DataDataSet.System_Master)

        Dim System_MasterViewSource As System.Windows.Data.CollectionViewSource = CType(Me.FindResource("System_MasterViewSource"), System.Windows.Data.CollectionViewSource)
        System_MasterViewSource.View.MoveCurrentToFirst()

    End Sub
End Class