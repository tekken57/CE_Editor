Imports System.IO    'Files
Imports System.Text ' Text Encoding
'Original File information gathered by Perfectplex: http://smacktalks.org/forums/topic/63726-masking-tool-help-required/
'Object 1 : Torso	
'Object 2 : Left Arm	
'Object 3 : Right Arm	
'Object 4 : Left Hand	
'Object 5 : Right Hand	
'Object 6 : Hips
'Object 7 : Left Leg
'Object 8 : Right Leg
'Object 9 : Feet
Public Class Form1
    Dim active_file As String = ""
    Dim mask_array As Byte()
    Dim head_count As Integer
    Dim body_count As Integer
    'actively used when making a save
    Dim current_row As Integer = 0
    Dim current_container As String = ""
    Dim container_array As Byte() = New Byte() {}
    Dim container_count As Integer = 0
    Dim current_part As Integer = -1
    Dim part_array As Byte() = New Byte() {}
    Dim body_part_count As Integer = 0
    Dim current_mask As Integer = -1
    Dim single_mask_array As Byte() = New Byte() {}
    Dim array_count As Integer = 0
    Dim number_array As Byte() = New Byte() {}
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            active_file = OpenFileDialog1.FileName
            If File.Exists(active_file) Then
                ExportScriptToolStripMenuItem.Visible = True
                open_mask(active_file)
            End If
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim Saved_File = ""
        If active_file.ToLower.Contains(".txt") Then
            SaveCEFile.InitialDirectory = Path.GetDirectoryName(active_file)
            If SaveCEFile.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Saved_File = SaveCEFile.FileName
            End If
        Else
            Saved_File = active_file
        End If

        If Not Saved_File = "" Then
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells(1).Value.ToString = "nil" OrElse row.Cells(2).Value.ToString = "nil" Then
                    MessageBox.Show("Please delete any nil rows before saving")
                End If
            Next
            If Saved_File = active_file Then
                File.Copy(active_file, active_file & ".bak", True)
            End If

            Dim total_file As Byte() = New Byte() {}
            current_row = 1
            ' row 0 must be manually processed as the starting point
            current_container = DataGridView1(0, 0).Value.ToString().Substring(0, 6)
            container_array = New Byte(0) {}
            container_count = 0
            current_part = CInt(DataGridView1(0, 0).Value.ToString().Substring(7, 1))
            part_array = New Byte(0) {}
            body_part_count = 0
            current_mask = CInt(DataGridView1(0, 0).Value.ToString().Substring(9, 1))
            single_mask_array = New Byte(0) {}
            array_count = 0
            number_array = New Byte(7) {}
            Buffer.BlockCopy(BitConverter.GetBytes(CInt(DataGridView1(1, 0).Value)), 0, number_array, 0, 4)
            Buffer.BlockCopy(BitConverter.GetBytes(CInt(DataGridView1(2, 0).Value)), 0, number_array, 4, 4)
            Do While current_row < DataGridView1.RowCount
                If DataGridView1(0, current_row).Value.ToString.Length = 0 Then
                    'MessageBox.Show("Adding")
                    add_number_to_array()
                Else
                    If Not current_container = DataGridView1(0, current_row).Value.ToString().Substring(0, 6) Then
                        'putting the number arrays into a mask container
                        make_mask()
                        'Make a new part together and adding it to any other parts
                        make_body_part()
                        'Now putting the container together
                        make_container()
                    Else
                        If Not current_part = CInt(DataGridView1(0, current_row).Value.ToString().Substring(7, 1)) Then
                            'putting the number arrays into a mask container
                            make_mask()
                            'Make a new part together and adding it to any other parts
                            make_body_part()
                        Else
                            If Not current_mask = CInt(DataGridView1(0, current_row).Value.ToString().Substring(9, 1)) Then
                                'putting the number arrays into a mask container
                                make_mask()
                            Else
                                'This shouldn't happen, but this means it's the same part and it should just add the numbers
                                add_number_to_array()
                            End If
                        End If
                    End If
                End If
                current_row += 1
            Loop
            'finish last package at this point
            'putting the number arrays into a mask container
            make_mask()
            'Make a new part together and adding it to any other parts
            make_body_part()
            'Now putting the container together
            make_container()
            'Add the final header and then add containers to file
            total_file = New Byte(container_array.Length + &HC - 2) {}
            'adding ceader length
            total_file(&H4) = &HC
            'adding container count
            total_file(&H8) = container_count
            'copying final containers to array before writing to file
            Buffer.BlockCopy(container_array, 0, total_file, &HC, container_array.Length - 1)
            File.WriteAllBytes(Saved_File, total_file)
            MessageBox.Show("File Saved")
        Else
            MessageBox.Show("No Active File")
        End If
    End Sub
    Sub add_number_to_array()
        Dim old_length As Integer = number_array.Length
        ReDim Preserve number_array(old_length + 7)
        Buffer.BlockCopy(BitConverter.GetBytes(CInt(DataGridView1(1, current_row).Value)), 0, number_array, old_length, 4)
        Buffer.BlockCopy(BitConverter.GetBytes(CInt(DataGridView1(2, current_row).Value)), 0, number_array, old_length + 4, 4)
    End Sub
    Sub make_new_number_array()
        ReDim number_array(7)
        Buffer.BlockCopy(BitConverter.GetBytes(CInt(DataGridView1(1, current_row).Value)), 0, number_array, 0, 4)
        Buffer.BlockCopy(BitConverter.GetBytes(CInt(DataGridView1(2, current_row).Value)), 0, number_array, 4, 4)
    End Sub
    Private Sub make_mask()
        Dim old_length As Integer = single_mask_array.Length - 1
        ReDim Preserve single_mask_array((single_mask_array.Length) + (number_array.Length) + &H10 - 1)
        'length of header
        single_mask_array(old_length) = &H10
        'length of total plus header
        Buffer.BlockCopy(BitConverter.GetBytes(CInt((number_array.Length) + &H10)), 0, single_mask_array, old_length + &H4, 4)
        'putting the mask number which should be 0
        Buffer.BlockCopy(BitConverter.GetBytes(CInt(current_mask)), 0, single_mask_array, old_length + &H8, 4)
        'getting the count of numbers
        Buffer.BlockCopy(BitConverter.GetBytes(CInt((number_array.Length - 1) / 8)), 0, single_mask_array, old_length + &HC, 4)
        'copying the number array into the mask
        Buffer.BlockCopy(number_array, 0, single_mask_array, old_length + &H10, number_array.Length)
        array_count += 1
        ' MessageBox.Show(DataGridView1(0, current_row).Value.ToString() & vbNewLine &
        'DataGridView1(0, current_row).Value.ToString().Length)
        If current_row < DataGridView1.RowCount Then
            current_mask = CInt(DataGridView1(0, current_row).Value.ToString().Substring(9, 1))
            make_new_number_array()
        End If
        'Make New Number Array for new mask
    End Sub
    Sub make_new_mask()
        single_mask_array = New Byte(0) {}
    End Sub
    Sub make_body_part()
        Dim old_length As Integer = part_array.Length - 1
        ReDim Preserve part_array(part_array.Length + single_mask_array.Length + &H10 - 2)
        'length of header
        part_array(old_length) = &H10
        'length of total plus header
        Buffer.BlockCopy(BitConverter.GetBytes(CInt(single_mask_array.Length + &H10 - 1)), 0, part_array, old_length + &H4, 4)
        'putting the body part number
        Buffer.BlockCopy(BitConverter.GetBytes(CInt(current_part)), 0, part_array, old_length + &H8, 4)
        'getting the count of masks
        Buffer.BlockCopy(BitConverter.GetBytes(CInt(array_count)), 0, part_array, old_length + &HC, 4)
        'copying the number array into the mask
        Buffer.BlockCopy(single_mask_array, 0, part_array, old_length + &H10, single_mask_array.Length)
        '
        body_part_count += 1
        If current_row < DataGridView1.RowCount Then
            current_part = CInt(DataGridView1(0, current_row).Value.ToString().Substring(7, 1))
        End If
        make_new_mask()
        array_count = 0
    End Sub
    Sub make_new_body_part()
        part_array = New Byte(0) {}
    End Sub
    Sub make_container()
        Dim old_length As Integer = container_array.Length - 1
        ReDim Preserve container_array(container_array.Length + part_array.Length + &H4C - 2)
        'length of header
        container_array(old_length) = &H4C
        'length of total plus header
        Buffer.BlockCopy(BitConverter.GetBytes(CInt(part_array.Length + &H4C - 1)), 0, container_array, old_length + &H4, 4)
        'putting in the container name
        Buffer.BlockCopy(System.Text.Encoding.ASCII.GetBytes(current_container), 0, container_array, old_length + &H8, System.Text.Encoding.ASCII.GetBytes(current_container).Length)
        'adding the count of body parts
        Buffer.BlockCopy(BitConverter.GetBytes(CInt(body_part_count)), 0, container_array, old_length + &H48, 4)
        'copying the number array into the mask
        Buffer.BlockCopy(part_array, 0, container_array, old_length + &H4C, part_array.Length)
        '
        container_count += 1
        If current_row < DataGridView1.RowCount Then
            current_container = DataGridView1(0, current_row).Value.ToString().Substring(0, 6)
        End If
        make_new_body_part()
        body_part_count = 0
    End Sub
    Private Sub open_mask(ByVal Source As String)
        DataGridView1.Rows.Clear()
        Dim fileLength As Long
        Using reader As New BinaryReader(File.Open(Source, FileMode.Open, FileAccess.Read))
            fileLength = reader.BaseStream.Length
            mask_array = reader.ReadBytes(fileLength)
        End Using
        'MessageBox.Show(fileLength)

        Dim CE_header As Integer = BitConverter.ToInt32(mask_array, &H4) ' should be C
        If Not CE_header = &HC Then
            MessageBox.Show("Unkown error with CE header")
            Exit Sub
        End If
        Dim active_offset As Long = CE_header
        Dim containter_count As Integer = BitConverter.ToInt32(mask_array, &H8) ' Should be 2
        If containter_count = 0 Then
            MessageBox.Show("CE contains no masks")
            Exit Sub
        End If
        Dim current_mask As String
        '-
        'First we have to process each container, these are the M_Head and M_Body containers
        '-
        For i As Integer = 0 To containter_count - 1 'process each mask individuallt head then body
            Dim mask_header_length As Integer = BitConverter.ToInt32(mask_array, active_offset) ' should start as offset &hC, should also be &H4c
            current_mask = System.Text.Encoding.ASCII.GetString(mask_array, active_offset + &H8, 6)
            'BitConverter.ToString(mask_array, active_offset + &H8)
            Dim mask_length As Integer = BitConverter.ToInt32(mask_array, active_offset + &H4) ' should be &h4c if mask masks no objects
            Dim masked_parts As Integer = BitConverter.ToInt32(mask_array, active_offset + &H48)
            If Not masked_parts = 0 Then
                '-
                'Now if the container contains masked parts we have to start processing those masked parts
                '-
                active_offset += mask_header_length
                For j As Integer = 0 To masked_parts - 1
                    Dim masked_part_header_legnth As Integer = BitConverter.ToInt32(mask_array, active_offset)
                    If Not masked_part_header_legnth = &H10 Then
                        MessageBox.Show("Error with Mask Header")
                        Exit Sub
                    End If
                    Dim total_part_mask_length As Integer = BitConverter.ToInt32(mask_array, active_offset + 4)
                    Dim part_number As Integer = BitConverter.ToInt32(mask_array, active_offset + 8)
                    Dim masks_on_part As Integer = BitConverter.ToInt32(mask_array, active_offset + &HC) 'should be 1 always from what I've seen
                    If masks_on_part = 0 Then
                        DataGridView1.Rows.Add(current_mask & "_" & part_number & "_1", "nil", "nil")
                        active_offset += total_part_mask_length
                    Else
                        '-
                        'For some reason they seem to have the capability of containing more than 1 set of mask arrays so this is just an extra layer of precaution
                        'This next for should only run once for every CE I've looked at
                        '-
                        active_offset += masked_part_header_legnth
                        For k As Integer = 0 To masks_on_part - 1
                            Dim true_mask_header_length As Integer = BitConverter.ToInt32(mask_array, active_offset)
                            If Not true_mask_header_length = &H10 Then
                                MessageBox.Show("Error with Mask Header")
                                Exit Sub
                            End If
                            Dim true_mask_total_length As Integer = BitConverter.ToInt32(mask_array, active_offset + 4)
                            Dim true_mask_number As Integer = BitConverter.ToInt32(mask_array, active_offset + 8)
                            Dim true_mask_count As Integer = BitConverter.ToInt32(mask_array, active_offset + &HC)
                            If masks_on_part = 0 Then
                                DataGridView1.Rows.Add(current_mask & "_" & part_number & "_" & true_mask_number, "nil", "nil")
                                active_offset += true_mask_total_length
                            Else
                                '-
                                'Now to handle the true sets of masks each set is 8 bytes
                                '-
                                active_offset += true_mask_header_length
                                For L As Integer = 0 To true_mask_count - 1
                                    'I only want the first line to have the part name
                                    If L = 0 Then
                                        DataGridView1.Rows.Add(current_mask & "_" & part_number & "_" & true_mask_number,
                                                               BitConverter.ToInt32(mask_array, active_offset),
                                                               BitConverter.ToInt32(mask_array, active_offset + 4))
                                        active_offset += 8
                                    Else
                                        DataGridView1.Rows.Add("",
                                                                BitConverter.ToInt32(mask_array, active_offset),
                                                                BitConverter.ToInt32(mask_array, active_offset + 4))
                                        active_offset += 8
                                    End If
                                Next
                            End If
                        Next
                    End If
                Next
            Else
                DataGridView1.Rows.Add(current_mask & "_0_0", "nil", "nil")
                active_offset += mask_length
            End If
        Next
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
       e.RowIndex >= 0 Then
            If e.ColumnIndex = 3 Then
                'add row of mask
                Dim temprow As DataGridViewRow = DataGridView1.Rows(e.RowIndex).Clone()
                temprow.Cells(0).Value = ""
                temprow.Cells(1).Value = DataGridView1.Rows(e.RowIndex).Cells(1).Value
                temprow.Cells(2).Value = DataGridView1.Rows(e.RowIndex).Cells(2).Value
                DataGridView1.Rows.Insert(e.RowIndex + 1, temprow)
            ElseIf e.ColumnIndex = 4 Then
                'delete row of mask
                DataGridView1.Rows.Remove(DataGridView1.Rows(e.RowIndex))
            Else
                'do nothing because a not button column at this time.
            End If
            'MessageBox.Show(e.ColumnIndex & vbNewLine &  e.RowIndex)
            'TODO - Button Clicked - Execute Code Here
        End If
    End Sub
    Private Sub ExportScriptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportScriptToolStripMenuItem.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                Dim CurrentBody As String = "New"
                Dim FaceArray As List(Of Integer) = New List(Of Integer)
                Using sw As New IO.StreamWriter(SaveFileDialog1.FileName)
                    For i As Integer = 0 To DataGridView1.RowCount - 1
                        If DataGridView1.Rows(i).Cells(0).Value = "" Then 'Just some mask numbers
                            For j As Integer = CInt(DataGridView1.Rows(i).Cells(1).Value) To CInt(DataGridView1.Rows(i).Cells(2).Value)
                                FaceArray.Add(j + 1)
                            Next
                        Else 'New Body Part
                            If CurrentBody <> "New" Then
                                'We Have to Write the existing Mask to the File
                                sw.WriteLine(CurrentBody)
                                FaceArray.Sort()
                                sw.WriteLine(String.Join(",", FaceArray))
                            End If
                            If Not DataGridView1.Rows(i).Cells(1).Value.ToString = "nil" Then
                                FaceArray = New List(Of Integer)
                                For j As Integer = CInt(DataGridView1.Rows(i).Cells(1).Value) To CInt(DataGridView1.Rows(i).Cells(2).Value)
                                    FaceArray.Add(j + 1)
                                Next
                                If DataGridView1.Rows(i).Cells(0).Value.contains("Body") Then
                                    CurrentBody = "Object" & (CInt(DataGridView1.Rows(i).Cells(0).Value.ToString().Substring(7, 1)) + 1).ToString
                                Else
                                    CurrentBody = "Object" & (CInt(DataGridView1.Rows(i).Cells(0).Value.ToString().Substring(7, 1))).ToString
                                End If
                            End If
                        End If
                    Next
                End Using
                MessageBox.Show("File Saved")
            End If
        Else
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                Dim FaceArray As List(Of Integer) = New List(Of Integer)
                For Each temprow As DataGridViewRow In DataGridView1.SelectedRows
                    For i As Integer = CInt(temprow.Cells(1).Value) To CInt(temprow.Cells(2).Value)
                        FaceArray.Add(i + 1)
                    Next
                Next
                'sorts all the faces before putting it in the array
                FaceArray.Sort()
                '3ds max script provided by tekken
                Using sw As New IO.StreamWriter(SaveFileDialog1.FileName)
                    sw.WriteLine(String.Join(",", FaceArray))
                End Using
                MessageBox.Show("File Saved")
            End If
        End If
    End Sub
    Private Sub OldExport(sender As Object, e As EventArgs)
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Select row header to select rows.")
        Else
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                Dim FaceArray As List(Of Integer) = New List(Of Integer)
                For Each temprow As DataGridViewRow In DataGridView1.SelectedRows
                    For i As Integer = CInt(temprow.Cells(1).Value) To CInt(temprow.Cells(2).Value)
                        FaceArray.Add(i)
                    Next
                Next
                'sorts all the faces before putting it in the array
                FaceArray.Sort()
                '3ds max script provided by tekken
                Using sw As New IO.StreamWriter(SaveFileDialog1.FileName)
                    sw.WriteLine("for c in selection do")
                    sw.WriteLine("(")
                    sw.WriteLine("--c = convertToPoly($)")
                    sw.WriteLine("--polyop.setFaceSelection c #(" & FaceArray.Count & ")")
                    sw.WriteLine("setFaceSelection c #(" & String.Join(",", FaceArray) & ")")
                    sw.WriteLine(")")
                End Using
                MessageBox.Show("File Saved")
            End If
        End If
    End Sub

    Private Sub ImportFacesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportFacesToolStripMenuItem.Click
        If OpenTxtFile.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            active_file = OpenTxtFile.FileName
            If File.Exists(active_file) Then
                ExportScriptToolStripMenuItem.Visible = True
                open_faces(active_file)
            End If
        End If
    End Sub
    Private Sub open_faces(ByVal Source As String)
        DataGridView1.Rows.Clear()
        Dim New_Faces As String() = File.ReadAllLines(Source)
        For i As Integer = 0 To New_Faces.Count - 1 Step 2
            'MessageBox.Show(New_Faces(i))
            Dim Temp_Name As String
            Dim Temp_Object_Number As Integer = New_Faces(i).Substring(6, 1)
            If Temp_Object_Number = 0 Then
                Temp_Name = "M_Head_0_0"
            Else
                Temp_Name = "M_Body_" & Temp_Object_Number - 1 & "_0"
            End If
            Dim Face_Numbers As String() = New_Faces(i + 1).Split(",")
            Dim Individual_Faces As List(Of Integer) = New List(Of Integer)
            For Each temp_face_num As String In Face_Numbers
                Individual_Faces.Add(Integer.Parse(temp_face_num))
            Next
            Individual_Faces.Sort()
            Dim Name_Added As Boolean = False
            Dim Base_Number As Integer = Individual_Faces(0) - 1
            For J As Integer = 1 To Individual_Faces.Count - 1
                If Not Individual_Faces(J) = Individual_Faces(J - 1) + 1 Then
                    If Name_Added = False Then
                        DataGridView1.Rows.Add(Temp_Name, Base_Number, Individual_Faces(J - 1) - 1)
                        Base_Number = Individual_Faces(J) - 1
                        Name_Added = True
                    Else
                        DataGridView1.Rows.Add("", Base_Number, Individual_Faces(J - 1) - 1)
                        Base_Number = Individual_Faces(J) - 1
                    End If
                End If
            Next
            If Name_Added = False Then
                DataGridView1.Rows.Add(Temp_Name, Base_Number, Individual_Faces(Individual_Faces.Count - 1) - 1)
                Name_Added = True
            Else
                DataGridView1.Rows.Add("", Base_Number, Individual_Faces(Individual_Faces.Count - 1) - 1)
            End If
        Next
    End Sub
    Private Sub TutorialVideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TutorialVideoToolStripMenuItem.Click
        Try
            Process.Start("https://www.youtube.com/watch?v=e7WNIh-WYB4")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DSImportScriptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DSImportScriptToolStripMenuItem.Click
        Try
            Process.Start("http://velociterium.com/3FYJ")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DSSelectionScriptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DSSelectionScriptToolStripMenuItem.Click
        Try
            Process.Start("http://velociterium.com/3FZt")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DSExportScriptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DSExportScriptToolStripMenuItem.Click
        Try
            Process.Start("http://velociterium.com/3Fd2")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AznTutorialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AznTutorialToolStripMenuItem.Click
        Try
            Process.Start("http://velociterium.com/4t4q")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class


