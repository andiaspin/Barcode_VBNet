Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Masukkan Kode Barcode", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            On Error Resume Next
            Dim barcode As KeepAutomation.Barcode.Bean.BarCode = New KeepAutomation.Barcode.Bean.BarCode
            barcode.Symbology = KeepAutomation.Barcode.Symbology.Code128A
            barcode.CodeToEncode = TextBox1.Text
            barcode.X = 1
            barcode.Y = 60
            barcode.BottomMargin = 10
            barcode.TopMargin = 10
            barcode.LeftMargin = 10
            barcode.RightMargin = 10
            barcode.DisplayText = True
            barcode.Orientation = KeepAutomation.Barcode.Orientation.Degree0
            barcode.BarcodeUnit = KeepAutomation.Barcode.BarcodeUnit.Pixel
            barcode.DPI = 72
            barcode.TextFont = New Font("Arial", 10.0F, FontStyle.Bold)
            barcode.ImageFormat = System.Drawing.Imaging.ImageFormat.Jpeg
            barcode.generateBarcodeToImageFile(Application.StartupPath & "\Barcode\" & TextBox1.Text & ".jpeg")
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\Barcode\" & TextBox1.Text & ".jpeg")

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Masukkan Kode Barcode", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            On Error Resume Next
            Dim barcode As KeepAutomation.Barcode.Bean.BarCode = New KeepAutomation.Barcode.Bean.BarCode
            barcode.Symbology = KeepAutomation.Barcode.Symbology.QRCode
            barcode.CodeToEncode = TextBox1.Text
            barcode.X = PictureBox2.Width
            barcode.Y = PictureBox2.Height
            barcode.BottomMargin = 10
            barcode.TopMargin = 10
            barcode.LeftMargin = 10
            barcode.RightMargin = 10
            barcode.DisplayText = True
            barcode.Orientation = KeepAutomation.Barcode.Orientation.Degree0
            barcode.BarcodeUnit = KeepAutomation.Barcode.BarcodeUnit.Pixel
            barcode.DPI = 72
            barcode.ImageFormat = System.Drawing.Imaging.ImageFormat.Png
            barcode.generateBarcodeToImageFile(Application.StartupPath & "\Barcode\" & TextBox1.Text & ".png")
            PictureBox2.Image = Image.FromFile(Application.StartupPath & "\Barcode\" & TextBox1.Text & ".png")

        End If
    End Sub
End Class
