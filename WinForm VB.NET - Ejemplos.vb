Public Class Ejemplos
    
	'Procedimiento para solo recibir numeros en un TextBox, mediante el evento KeyPress
	Private Sub MyKeyPress(ByRef e As System.Windows.Forms.KeyPressEventArgs)
		e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
	
	'Procedimiento para mostrar datos de un DataGridView en Label/TextBox
	Private Sub CellE()
        [Label/TextBox] = [DataGridView].CurrentRow.Cells([Columna]).Value
    End Sub
	
	'Procedimiento para mostrar texto de un Label/TextBox con formato moneda
	'Configurar a un evento del tipo Click para evitar errores en ejecución
	Sub Moneda()
	    [Label/TextBox] = FormatCurrency(([Label/TextBox]), "$ 0")
		[Label/TextBox] = Format([Label/TextBox], "$ 0")
	End Sub
	
	'Procedimiento para no permitir modificación de datos en un ComboBox
	Sub PropCB()
        [ComboBox].DropDownStyle = ComboBoxStyle.DropDownList
        [ComboBox].FlatStyle = FlatStyle.Popup
    End Sub
End Class