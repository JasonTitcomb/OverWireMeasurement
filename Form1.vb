Imports System.Drawing.Printing

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtStarts.Text = "1"
        txtAngle.Text = "60"

        ' Wire/numeric fields: wire, highpd, lowpd, thdpi
        AddHandler txtTpi.KeyPress, AddressOf NumericKeyPress
        AddHandler txtStarts.KeyPress, AddressOf NumericKeyPress
        AddHandler txtAngle.KeyPress, AddressOf NumericKeyPress
        AddHandler txtHighPD.KeyPress, AddressOf NumericKeyPress
        AddHandler txtLowPD.KeyPress, AddressOf NumericKeyPress
        AddHandler txtWire.KeyPress, AddressOf NumericKeyPress

        ' Buttons
        AddHandler btnCalculate.Click, AddressOf btnCalculate_Click
        AddHandler btnPrint.Click, AddressOf btnPrint_Click

        ' Printing
        AddHandler PrintDocument1.PrintPage, AddressOf PrintDocument1_PrintPage

    End Sub

    Private Sub NumericKeyPress(sender As Object, e As KeyPressEventArgs)
        ' Allow digits, control chars, one decimal point
        If Char.IsControl(e.KeyChar) Then Return
        Dim tb = TryCast(sender, TextBox)
        If tb Is Nothing Then Return

        If e.KeyChar = "."c Then
            If tb.Text.Contains(".") Then
                e.Handled = True
                Return
            End If
            Return
        End If

        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs)
        ' Validate required fields
        If String.IsNullOrWhiteSpace(txtDesc.Text) OrElse
           String.IsNullOrWhiteSpace(txtTpi.Text) OrElse
           String.IsNullOrWhiteSpace(txtStarts.Text) OrElse
           String.IsNullOrWhiteSpace(txtAngle.Text) OrElse
           String.IsNullOrWhiteSpace(txtLowPD.Text) OrElse
           String.IsNullOrWhiteSpace(txtHighPD.Text) Then

            MessageBox.Show("All the fields are not filled in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDesc.Focus()
            Return
        End If

        ' Parse inputs
        Dim Pi As Double = Math.PI
        Dim thdpi As Double = Val(txtTpi.Text)
        Dim pitch As Double = If(thdpi <> 0, 1.0 / thdpi, 0.0)
        Dim a As Double = Val(txtAngle.Text) / 2.0
        Dim cosa As Double = Math.Cos(a * (Pi / 180.0))
        Dim sina As Double = Math.Sin(a * (Pi / 180.0))
        Dim tna As Double = Math.Tan(a * (Pi / 180.0))

        Dim l As Double = pitch * Val(txtStarts.Text)
        Dim mpd As Double = (Val(txtHighPD.Text) + Val(txtLowPD.Text)) / 2.0
        Dim B As Double = 0.0
        If mpd <> 0 Then
            B = l / (Pi * mpd)
        End If
        Dim tanb As Double = (B / (Pi / 180.0))
        Dim t As Double = pitch * 0.5
        Dim cota As Double = If(tna <> 0, 1.0 / tna, 0.0)
        Dim coseca As Double = If(sina <> 0, 1.0 / sina, 0.0)

        ' Best wire if wire not provided
        Dim besw As Double = 0
        If Val(txtWire.Text) = 0 Then
            besw = t / cosa
            txtBest.Text = Format(besw, "##.######")
            txtWire.Text = txtBest.Text
        Else
            besw = t / cosa
            txtBest.Text = Format(besw, "##.######")
        End If

        ' Formula
        Dim step1 As Double = 1 + coseca + ((B ^ 2) * 0.5 * cosa * cota)
        Dim step2 As Double = step1 * Val(txtWire.Text)
        Dim step3 As Double = mpd - (t * cota)
        Dim owm As Double = step2 + step3

        Dim tolerance As Double = (Val(txtHighPD.Text) - Val(txtLowPD.Text)) / 2.0
        lblMaxResult.Text = Format((owm + tolerance), "##.######")
        lblMinResult.Text = Format((owm - tolerance), "##.######")

        txtDesc.Focus()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs)
        ' Validate before printing
        If String.IsNullOrWhiteSpace(txtDesc.Text) OrElse
           String.IsNullOrWhiteSpace(txtTpi.Text) OrElse
           String.IsNullOrWhiteSpace(txtStarts.Text) OrElse
           String.IsNullOrWhiteSpace(txtAngle.Text) OrElse
           String.IsNullOrWhiteSpace(txtLowPD.Text) OrElse
           String.IsNullOrWhiteSpace(txtHighPD.Text) Then

            MessageBox.Show("All the fields are not filled in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDesc.Focus()
            Return
        End If

        Try
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("The form could not be printed. " & ex.Message, "Printer error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private printLines As String()
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs)
        ' Build lines to print (similar to original)
        Dim lines As New System.Collections.Generic.List(Of String)
        lines.Add("Over wire measurement using the")
        lines.Add("Bureau of Standards General Formula")
        lines.Add("which compensates largely for the effect of lead angle.")
        lines.Add("======================================================")
        lines.Add(String.Empty)
        lines.Add("Thread: " & txtDesc.Text)
        lines.Add("TPI: " & txtTpi.Text)
        lines.Add("Starts: " & txtStarts.Text)
        lines.Add("Included Angle: " & txtAngle.Text)
        lines.Add("High Pitch Dia.: " & txtHighPD.Text)
        lines.Add("Low Pitch Dia.: " & txtLowPD.Text)
        lines.Add("Wire Used: " & txtWire.Text)
        lines.Add("Best Wire: " & txtBest.Text)
        lines.Add(String.Empty)
        lines.Add("******************************************************")
        lines.Add("Max over wire measurement: " & lblMaxResult.Text)
        lines.Add("Min over wire measurement: " & lblMinResult.Text)
        lines.Add("******************************************************")

        Dim y As Single = e.MarginBounds.Top
        Dim font As New Font("Courier New", 10)
        For Each line In lines
            e.Graphics.DrawString(line, font, Brushes.Black, e.MarginBounds.Left, y)
            y += font.GetHeight(e.Graphics) + 2
        Next
    End Sub


End Class
