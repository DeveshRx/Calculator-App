Public Class Form1
    Public m1, m2, m3, m4, m5, m6, m7, p, ans As Decimal
    Private Sub SpaceToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SpaceToolStripMenuItem.Click
        ProgressBar1.Increment(-100%)
        PictureBox1.Visible = True
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox7.Visible = False
    End Sub

    Private Sub NebulaToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NebulaToolStripMenuItem.Click
        PictureBox1.Visible = False
        PictureBox3.Visible = True
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox7.Visible = False
        ProgressBar1.Increment(-100%)
    End Sub
    Private Sub EvergreenToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles EvergreenToolStripMenuItem.Click
        PictureBox1.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = True
        PictureBox6.Visible = False
        PictureBox7.Visible = False
        ProgressBar1.Increment(-100%)
    End Sub

    Private Sub SkyHiToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SkyHiToolStripMenuItem.Click
        PictureBox1.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox7.Visible = True
        ProgressBar1.Increment(-100%)
    End Sub

    Private Sub CatToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CatToolStripMenuItem.Click
        ProgressBar1.Increment(-100%)
        PictureBox1.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = True
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox7.Visible = False
    End Sub

    Private Sub NeedForSpeedworldToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NeedForSpeedworldToolStripMenuItem.Click
        PictureBox1.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = True
        ProgressBar1.Increment(-100%)
        PictureBox7.Visible = False
    End Sub
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        m1 = TextBox1.Text
        m2 = TextBox2.Text
        ProgressBar1.Increment(10%)
        ProgressBar1.Increment(15%)
        ProgressBar1.Increment(20%)
        ProgressBar1.Increment(25%)
        ProgressBar1.Increment(30%)
        ProgressBar1.Increment(35%)
        ProgressBar1.Increment(40%)
        ProgressBar1.Increment(45%)
        ProgressBar1.Increment(50%)
        ProgressBar1.Increment(55%)
        ProgressBar1.Increment(60%)
        ProgressBar1.Increment(65%)
        ProgressBar1.Increment(70%)
        ProgressBar1.Increment(75%)
        ProgressBar1.Increment(80%)
        ProgressBar1.Increment(85%)
        ProgressBar1.Increment(90%)
        ProgressBar1.Increment(95%)
        ProgressBar1.Increment(100%)
        If TextBox5.Visible = False Then ans = m1 * m2
        If TextBox5.Visible = True Then m3 = TextBox5.Text
        If TextBox5.Visible = True Then ans = m1 * m2 * m3
        If TextBox6.Visible = True Then m4 = TextBox6.Text
        If TextBox6.Visible = True Then ans = m1 * m2 * m3 * m4
        If TextBox7.Visible = True Then m5 = TextBox7.Text
        If TextBox7.Visible = True Then ans = m1 * m2 * m3 * m4 * m5
        If TextBox8.Visible = True Then m6 = TextBox7.Text
        If TextBox8.Visible = True Then ans = m1 * m2 * m3 * m4 * m5 * m6
        If TextBox9.Visible = True Then m7 = TextBox9.Text
        If TextBox9.Visible = True Then ans = m1 * m2 * m3 * m4 * m5 * m6 * m7
        TextBox3.Text = ans

    End Sub
    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        m1 = TextBox1.Text
        m2 = TextBox2.Text
        ProgressBar1.Increment(10%)
        ProgressBar1.Increment(15%)
        ProgressBar1.Increment(20%)
        ProgressBar1.Increment(25%)
        ProgressBar1.Increment(30%)
        ProgressBar1.Increment(35%)
        ProgressBar1.Increment(40%)
        ProgressBar1.Increment(45%)
        ProgressBar1.Increment(50%)
        ProgressBar1.Increment(55%)
        ProgressBar1.Increment(60%)
        ProgressBar1.Increment(65%)
        ProgressBar1.Increment(70%)
        ProgressBar1.Increment(75%)
        ProgressBar1.Increment(80%)
        ProgressBar1.Increment(85%)
        ProgressBar1.Increment(90%)
        ProgressBar1.Increment(95%)
        ProgressBar1.Increment(100%)
        If TextBox5.Visible = False Then ans = m1 + m2
        If TextBox5.Visible = True Then m3 = TextBox5.Text
        If TextBox5.Visible = True Then ans = m1 + m2 + m3
        If TextBox6.Visible = True Then m4 = TextBox6.Text
        If TextBox6.Visible = True Then ans = m1 + m2 + m3 + m4
        If TextBox7.Visible = True Then m5 = TextBox7.Text
        If TextBox7.Visible = True Then ans = m1 + m2 + m3 + m4 + m5
        If TextBox8.Visible = True Then m6 = TextBox7.Text
        If TextBox8.Visible = True Then ans = m1 + m2 + m3 + m4 + m5 + m6
        If TextBox9.Visible = True Then m7 = TextBox9.Text
        If TextBox9.Visible = True Then ans = m1 + m2 + m3 + m4 + m5 + m6 + m7
        TextBox3.Text = ans

    End Sub
    Private Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        m1 = TextBox1.Text
        m2 = TextBox2.Text
        ProgressBar1.Increment(10%)
        ProgressBar1.Increment(15%)
        ProgressBar1.Increment(20%)
        ProgressBar1.Increment(25%)
        ProgressBar1.Increment(30%)
        ProgressBar1.Increment(35%)
        ProgressBar1.Increment(40%)
        ProgressBar1.Increment(45%)
        ProgressBar1.Increment(50%)
        ProgressBar1.Increment(55%)
        ProgressBar1.Increment(60%)
        ProgressBar1.Increment(65%)
        ProgressBar1.Increment(70%)
        ProgressBar1.Increment(75%)
        ProgressBar1.Increment(80%)
        ProgressBar1.Increment(85%)
        ProgressBar1.Increment(90%)
        ProgressBar1.Increment(95%)
        ProgressBar1.Increment(100%)
        If TextBox5.Visible = False Then ans = m1 / m2
        If TextBox5.Visible = True Then m3 = TextBox5.Text
        If TextBox5.Visible = True Then ans = m1 / m2 / m3
        If TextBox6.Visible = True Then m4 = TextBox6.Text
        If TextBox6.Visible = True Then ans = m1 / m2 / m3 / m4
        If TextBox7.Visible = True Then m5 = TextBox7.Text
        If TextBox7.Visible = True Then ans = m1 / m2 / m3 / m4 / m5
        If TextBox8.Visible = True Then m6 = TextBox7.Text
        If TextBox8.Visible = True Then ans = m1 / m2 / m3 / m4 / m5 / m6
        If TextBox9.Visible = True Then m7 = TextBox9.Text
        If TextBox9.Visible = True Then ans = m1 / m2 / m3 / m4 / m5 / m6 / m7
        TextBox3.Text = ans

    End Sub
    Private Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        m1 = TextBox1.Text
        m2 = TextBox2.Text
        ProgressBar1.Increment(10%)
        ProgressBar1.Increment(15%)
        ProgressBar1.Increment(20%)
        ProgressBar1.Increment(25%)
        ProgressBar1.Increment(30%)
        ProgressBar1.Increment(35%)
        ProgressBar1.Increment(40%)
        ProgressBar1.Increment(45%)
        ProgressBar1.Increment(50%)
        ProgressBar1.Increment(55%)
        ProgressBar1.Increment(60%)
        ProgressBar1.Increment(65%)
        ProgressBar1.Increment(70%)
        ProgressBar1.Increment(75%)
        ProgressBar1.Increment(80%)
        ProgressBar1.Increment(85%)
        ProgressBar1.Increment(90%)
        ProgressBar1.Increment(95%)
        ProgressBar1.Increment(100%)
        If TextBox5.Visible = False Then ans = m1 - m2
        If TextBox5.Visible = True Then m3 = TextBox5.Text
        If TextBox5.Visible = True Then ans = m1 - m2 - m3
        If TextBox6.Visible = True Then m4 = TextBox6.Text
        If TextBox6.Visible = True Then ans = m1 - m2 - m3 - m4
        If TextBox7.Visible = True Then m5 = TextBox7.Text
        If TextBox7.Visible = True Then ans = m1 - m2 - m3 - m4 - m5
        If TextBox8.Visible = True Then m6 = TextBox7.Text
        If TextBox8.Visible = True Then ans = m1 - m2 - m3 - m4 - m5 - m6
        If TextBox9.Visible = True Then m7 = TextBox9.Text
        If TextBox9.Visible = True Then ans = m1 - m2 - m3 - m4 - m5 - m6 - m7
        TextBox3.Text = ans

    End Sub
    Private Sub Button8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button8.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        ProgressBar1.Increment(-100%)
    End Sub
    Private Sub Button9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button9.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox3.Text = ""
        ProgressBar1.Increment(-100%)
    End Sub
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
        ProgressBar1.Increment(-100%)
    End Sub
    Public Sub Button12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button12.Click
        TextBox5.Visible = True
        Button12.Visible = False
        Button10.Visible = True
        Button15.Visible = True
        ProgressBar1.Increment(-100%)
    End Sub
    Private Sub Button10_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button10.Click
        TextBox6.Visible = True
        Button10.Visible = False
        Button11.Visible = True
        Button16.Visible = True
        Button15.Visible = False
        ProgressBar1.Increment(-100%)
    End Sub
    Private Sub Button11_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button11.Click
        TextBox7.Visible = True
        Button11.Visible = False
        Button13.Visible = True
        Button17.Visible = True
        Button16.Visible = False
        ProgressBar1.Increment(-100%)
    End Sub

    Private Sub Button13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button13.Click
        TextBox8.Visible = True
        Button13.Visible = False
        Button14.Visible = True
        Button18.Visible = True
        Button17.Visible = False
        ProgressBar1.Increment(-100%)
    End Sub
    Private Sub Button14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button14.Click
        TextBox9.Visible = True
        Button14.Visible = False
        Button19.Visible = True
        Button18.Visible = False
        ProgressBar1.Increment(-100%)
    End Sub
    Private Sub Button15_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button15.Click
        TextBox5.Visible = False
        Button15.Visible = False
        Button10.Visible = False
        Button12.Visible = True
        ProgressBar1.Increment(-100%)
    End Sub
    Private Sub Button16_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button16.Click
        Button16.Visible = False
        TextBox6.Visible = False
        Button15.Visible = True
        Button11.Visible = False
        Button10.Visible = True
        ProgressBar1.Increment(-100%)
    End Sub
    Private Sub Button17_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button17.Click
        Button17.Visible = False
        TextBox7.Visible = False
        Button13.Visible = False
        Button11.Visible = True
        Button16.Visible = True
        ProgressBar1.Increment(-100%)
    End Sub
    Private Sub Button18_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button18.Click
        Button18.Visible = False
        TextBox8.Visible = False
        Button14.Visible = False
        Button17.Visible = True
        Button13.Visible = True
        ProgressBar1.Increment(-100%)
    End Sub
    Private Sub Button19_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button19.Click
        Button19.Visible = False
        TextBox9.Visible = False
        Button14.Visible = True
        Button18.Visible = True
        ProgressBar1.Increment(-100%)
    End Sub


    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        ProgressBar1.Increment(-100%)
        p = 2
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        ProgressBar1.Increment(-100%)
        p = 3
    End Sub
    Private Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
        If TextBox1.Text = "" Then MsgBox("Enter the value in textbox")
        If TextBox1.Text = "" Then TextBox1.Text = 0
        m1 = TextBox1.Text
        ProgressBar1.Increment(10%)
        ProgressBar1.Increment(15%)
        ProgressBar1.Increment(20%)
        ProgressBar1.Increment(25%)
        ProgressBar1.Increment(30%)
        ProgressBar1.Increment(35%)
        ProgressBar1.Increment(40%)
        ProgressBar1.Increment(45%)
        ProgressBar1.Increment(50%)
        ProgressBar1.Increment(55%)
        ProgressBar1.Increment(60%)
        ProgressBar1.Increment(65%)
        ProgressBar1.Increment(70%)
        ProgressBar1.Increment(75%)
        ProgressBar1.Increment(80%)
        ProgressBar1.Increment(85%)
        ProgressBar1.Increment(90%)
        ProgressBar1.Increment(95%)
        ProgressBar1.Increment(100%)
        If p = 2 Then ans = 4 / 3 * 22 / 7 * m1 * m1 * m1
        If p = 3 Then ans = 4 / 3 * 3.14 * m1 * m1 * m1
        TextBox3.Text = ans

    End Sub
    Private Sub sphereSurfaceAreaToolStripMenuItem_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles sphereSurfaceAreaToolStripMenuItem.Click
        Button24.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button12.Visible = False
        Button13.Visible = False
        Button14.Visible = False
        Button15.Visible = False
        Button16.Visible = False
        Button17.Visible = False
        Button18.Visible = False
        Button25.Visible = False
        Button26.Visible = False
        Button27.Visible = False
        Button19.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button7.Visible = False
        Button20.Visible = False
        Button21.Visible = False
        Button22.Visible = False
        Button6.Visible = True
        Button6.Width = "229"
        Button6.Text = "Find the Total surface area of sphere"
        TextBox2.Visible = False
        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label2.Text = "Total surface area of sphere"
        Label4.Visible = True
        Label4.Text = "Radius="
        Label3.Visible = True
        Label3.Text = "4 X pie X Radius X Radius"
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        PictureBox2.Visible = True
        PictureBox8.Visible = False
        PictureBox9.Visible = False
        PictureBox10.Visible = False
        PictureBox11.Visible = False
        PictureBox12.Visible = False
        Button28.Visible = False
        Button29.Visible = False
        Button30.Visible = False
        Button31.Visible = False
        Label10.Visible = False
        Button32.Visible = False
        Button33.Visible = False
        Button34.Visible = False
    End Sub
    Private Sub Button6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.Click
        If TextBox1.Text = "" Then MsgBox("Enter the value in textbox")
        If TextBox1.Text = "" Then TextBox1.Text = 0
        m1 = TextBox1.Text
        ProgressBar1.Increment(10%)
        ProgressBar1.Increment(15%)
        ProgressBar1.Increment(20%)
        ProgressBar1.Increment(25%)
        ProgressBar1.Increment(30%)
        ProgressBar1.Increment(35%)
        ProgressBar1.Increment(40%)
        ProgressBar1.Increment(45%)
        ProgressBar1.Increment(50%)
        ProgressBar1.Increment(55%)
        ProgressBar1.Increment(60%)
        ProgressBar1.Increment(65%)
        ProgressBar1.Increment(70%)
        ProgressBar1.Increment(75%)
        ProgressBar1.Increment(80%)
        ProgressBar1.Increment(85%)
        ProgressBar1.Increment(90%)
        ProgressBar1.Increment(95%)
        ProgressBar1.Increment(100%)
        If p = 2 Then ans = 4 * 22 / 7 * m1 * m1
        If p = 3 Then ans = 4 * 3.14 * m1 * m1
        TextBox3.Text = ans

    End Sub
    Private Sub cubeVolumeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cubeVolumeToolStripMenuItem.Click
        ProgressBar1.Increment(-100%)
        Button24.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button12.Visible = False
        Button13.Visible = False
        Button14.Visible = False
        Button15.Visible = False
        Button16.Visible = False
        Button17.Visible = False
        Button18.Visible = False
        Button19.Visible = False
        Button1.Visible = False
        Button25.Visible = False
        Button26.Visible = False
        Button27.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = True
        Button20.Visible = False
        Button21.Visible = False
        Button22.Visible = False
        Button7.Width = "229"
        Button7.Text = "Find the volume of cube"
        TextBox2.Visible = False
        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label2.Text = "volume of cube"
        Label4.Visible = True
        Label4.Text = "Side="
        Label3.Visible = True
        Label3.Text = "side X side X side"
        RadioButton1.Visible = False
        RadioButton2.Visible = False
        PictureBox2.Visible = False
        PictureBox8.Visible = False
        PictureBox9.Visible = True
        PictureBox10.Visible = False
        PictureBox11.Visible = False
        PictureBox12.Visible = False
        Button28.Visible = False
        Button29.Visible = False
        Button30.Visible = False
        Label10.Visible = False
        Button31.Visible = False
        Button32.Visible = False
        Button33.Visible = False
        Button34.Visible = False
    End Sub
    Private Sub Button7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.Click
        If TextBox1.Text = "" Then MsgBox("Enter the value in textbox")
        If TextBox1.Text = "" Then TextBox1.Text = 0
        m1 = TextBox1.Text
        ProgressBar1.Increment(10%)
        ProgressBar1.Increment(15%)
        ProgressBar1.Increment(20%)
        ProgressBar1.Increment(25%)
        ProgressBar1.Increment(30%)
        ProgressBar1.Increment(35%)
        ProgressBar1.Increment(40%)
        ProgressBar1.Increment(45%)
        ProgressBar1.Increment(50%)
        ProgressBar1.Increment(55%)
        ProgressBar1.Increment(60%)
        ProgressBar1.Increment(65%)
        ProgressBar1.Increment(70%)
        ProgressBar1.Increment(75%)
        ProgressBar1.Increment(80%)
        ProgressBar1.Increment(85%)
        ProgressBar1.Increment(90%)
        ProgressBar1.Increment(95%)
        ProgressBar1.Increment(100%)
        ans = m1 * m1 * m1
        TextBox3.Text = ans

    End Sub
    Private Sub Button20_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button20.Click
        If TextBox1.Text = "" Then MsgBox("Enter the value in textbox")
        If TextBox1.Text = "" Then TextBox1.Text = 0
        m1 = TextBox1.Text
        ProgressBar1.Increment(10%)
        ProgressBar1.Increment(15%)
        ProgressBar1.Increment(20%)
        ProgressBar1.Increment(25%)
        ProgressBar1.Increment(30%)
        ProgressBar1.Increment(35%)
        ProgressBar1.Increment(40%)
        ProgressBar1.Increment(45%)
        ProgressBar1.Increment(50%)
        ProgressBar1.Increment(55%)
        ProgressBar1.Increment(60%)
        ProgressBar1.Increment(65%)
        ProgressBar1.Increment(70%)
        ProgressBar1.Increment(75%)
        ProgressBar1.Increment(80%)
        ProgressBar1.Increment(85%)
        ProgressBar1.Increment(90%)
        ProgressBar1.Increment(95%)
        ProgressBar1.Increment(100%)
        ans = 6 * m1 * m1
        TextBox3.Text = ans

    End Sub
    Private Sub cubeTotalSurfaceAreaToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cubeTotalSurfaceAreaToolStripMenuItem.Click
        ProgressBar1.Increment(-100%)
        Button24.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button12.Visible = False
        Button13.Visible = False
        Button14.Visible = False
        Button15.Visible = False
        Button16.Visible = False
        Button17.Visible = False
        Button18.Visible = False
        Button19.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Button25.Visible = False
        Button26.Visible = False
        Button27.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button22.Visible = False
        Button20.Visible = True
        Button20.Width = "229"
        Button20.Text = "Find the Total surface area of cube"
        TextBox2.Visible = False
        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label2.Text = "Total surface of cube"
        Label4.Visible = True
        Label4.Text = "Side="
        Label3.Visible = True
        Label3.Text = "6 X side X side"
        RadioButton1.Visible = False
        RadioButton2.Visible = False
        PictureBox2.Visible = False
        PictureBox8.Visible = False
        PictureBox9.Visible = True
        PictureBox10.Visible = False
        PictureBox11.Visible = False
        PictureBox12.Visible = False
        Button28.Visible = False
        Button29.Visible = False
        Button31.Visible = False
        Button30.Visible = False
        Label10.Visible = False
        Button32.Visible = False
        Button33.Visible = False
        Button34.Visible = False
    End Sub
    Private Sub cuboidTotalSurfaceAreaToolStripMenuItem_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cuboidTotalSurfaceAreaToolStripMenuItem.Click
        ProgressBar1.Increment(-100%)
        Button24.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button12.Visible = False
        Button13.Visible = False
        Button14.Visible = False
        Button15.Visible = False
        Button16.Visible = False
        Button17.Visible = False
        Button25.Visible = False
        Button26.Visible = False
        Button27.Visible = False
        Button18.Visible = False
        Button19.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button20.Visible = False
        Button22.Visible = False
        Button21.Visible = True
        Button21.Width = "200"
        Button21.Text = "Find the Total surface area of cuboid"
        TextBox2.Visible = True
        TextBox5.Visible = True
        TextBox6.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        Label2.Text = "Total surface of cuboid"
        Label4.Visible = True
        Label4.Text = "Length ="
        Label3.Visible = True
        Label3.Text = "2(lengthXBreath + BreathXHight + HightXLength)"
        Label5.Visible = True
        Label5.Text = "Breath ="
        Label6.Visible = True
        Label6.Text = "Hight ="
        RadioButton1.Visible = False
        RadioButton2.Visible = False
        PictureBox2.Visible = False
        PictureBox8.Visible = False
        PictureBox9.Visible = False
        PictureBox10.Visible = False
        PictureBox11.Visible = False
        PictureBox12.Visible = True
        Button28.Visible = False
        Button29.Visible = False
        Label10.Visible = False
        Button31.Visible = False
        Button30.Visible = False
        Button32.Visible = False
        Button33.Visible = False
        Button34.Visible = False
    End Sub

    Private Sub Button21_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button21.Click
        If TextBox1.Text = "" Then MsgBox("Enter the value in textbox")
        If TextBox1.Text = "" Then TextBox1.Text = 0
        m1 = TextBox1.Text
        m2 = TextBox2.Text
        m3 = TextBox5.Text
        ProgressBar1.Increment(10%)
        ProgressBar1.Increment(15%)
        ProgressBar1.Increment(20%)
        ProgressBar1.Increment(25%)
        ProgressBar1.Increment(30%)
        ProgressBar1.Increment(35%)
        ProgressBar1.Increment(40%)
        ProgressBar1.Increment(45%)
        ProgressBar1.Increment(50%)
        ProgressBar1.Increment(55%)
        ProgressBar1.Increment(60%)
        ProgressBar1.Increment(65%)
        ProgressBar1.Increment(70%)
        ProgressBar1.Increment(75%)
        ProgressBar1.Increment(80%)
        ProgressBar1.Increment(85%)
        ProgressBar1.Increment(90%)
        ProgressBar1.Increment(95%)
        ProgressBar1.Increment(100%)
        ans = 2 * m1 * m2 + m2 * m3 + m3 * m1
        TextBox3.Text = ans

    End Sub
    Private Sub cuboidVolumeToolStripMenuItem_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cuboidVolumeToolStripMenuItem.Click
        ProgressBar1.Increment(-100%)
        Button24.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button12.Visible = False
        Button13.Visible = False
        Button14.Visible = False
        Button15.Visible = False
        Button16.Visible = False
        Button17.Visible = False
        Button18.Visible = False
        Button19.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Button25.Visible = False
        Button26.Visible = False
        Button27.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button20.Visible = False
        Button22.Visible = True
        Button21.Visible = False
        Button22.Width = "200"
        Button22.Text = "Find the volume of cuboid"
        TextBox2.Visible = True
        TextBox5.Visible = True
        TextBox6.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        Label2.Text = "Volume of cuboid"
        Label4.Visible = True
        Label4.Text = "Length ="
        Label3.Visible = True
        Label3.Text = "length X Breath X Hight"
        Label5.Visible = True
        Label5.Text = "Breath ="
        Label6.Visible = True
        Label6.Text = "Hight ="
        RadioButton1.Visible = False
        RadioButton2.Visible = False
        PictureBox2.Visible = False
        PictureBox8.Visible = False
        PictureBox9.Visible = False
        PictureBox10.Visible = False
        PictureBox11.Visible = False
        PictureBox12.Visible = True
        Button28.Visible = False
        Label10.Visible = False
        Button29.Visible = False
        Button30.Visible = False
        Button31.Visible = False
        Button32.Visible = False
        Button33.Visible = False
        Button34.Visible = False
    End Sub
    Private Sub Button22_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button22.Click
        If TextBox1.Text = "" Then MsgBox("Enter the value in textbox")
        If TextBox1.Text = "" Then TextBox1.Text = 0
        m1 = TextBox1.Text
        m2 = TextBox2.Text
        m3 = TextBox5.Text
        ProgressBar1.Increment(10%)
        ProgressBar1.Increment(15%)
        ProgressBar1.Increment(20%)
        ProgressBar1.Increment(25%)
        ProgressBar1.Increment(30%)
        ProgressBar1.Increment(35%)
        ProgressBar1.Increment(40%)
        ProgressBar1.Increment(45%)
        ProgressBar1.Increment(50%)
        ProgressBar1.Increment(55%)
        ProgressBar1.Increment(60%)
        ProgressBar1.Increment(65%)
        ProgressBar1.Increment(70%)
        ProgressBar1.Increment(75%)
        ProgressBar1.Increment(80%)
        ProgressBar1.Increment(85%)
        ProgressBar1.Increment(90%)
        ProgressBar1.Increment(95%)
        ProgressBar1.Increment(100%)
        ans = m1 * m2 * m3
        TextBox3.Text = ans

    End Sub
    Private Sub Button23_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button23.Click
        ProgressBar1.Increment(-100%)
        Button24.Visible = False
        TextBox2.Visible = True
        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button13.Visible = False
        Button14.Visible = False
        Button15.Visible = False
        Button16.Visible = False
        Button7.Visible = False
        Button20.Visible = False
        Button21.Visible = False
        Button22.Visible = False
        Label3.Visible = False
        Button25.Visible = False
        Button26.Visible = False
        Button27.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button12.Visible = True
        Label2.Text = "Simple Calculator"
        PictureBox2.Visible = False
        PictureBox8.Visible = False
        PictureBox9.Visible = False
        PictureBox10.Visible = False
        PictureBox11.Visible = False
        PictureBox12.Visible = False
        RadioButton1.Visible = False
        RadioButton2.Visible = False
        Button28.Visible = False
        Button29.Visible = False
        Label10.Visible = False
        Button30.Visible = False
        Button31.Visible = False
        Button32.Visible = False
        Button33.Visible = False
        Button34.Visible = False
    End Sub

    Private Sub Button24_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button24.Click
        If TextBox1.Text = "" Then MsgBox("Enter the value in textbox")
        If TextBox1.Text = "" Then TextBox1.Text = 0
        m1 = TextBox1.Text
        m2 = TextBox2.Text
        m3 = TextBox5.Text
        ProgressBar1.Increment(10%)
        ProgressBar1.Increment(15%)
        ProgressBar1.Increment(20%)
        ProgressBar1.Increment(25%)
        ProgressBar1.Increment(30%)
        ProgressBar1.Increment(35%)
        ProgressBar1.Increment(40%)
        ProgressBar1.Increment(45%)
        ProgressBar1.Increment(50%)
        ProgressBar1.Increment(55%)
        ProgressBar1.Increment(60%)
        ProgressBar1.Increment(65%)
        ProgressBar1.Increment(70%)
        ProgressBar1.Increment(75%)
        ProgressBar1.Increment(80%)
        ProgressBar1.Increment(85%)
        ProgressBar1.Increment(90%)
        ProgressBar1.Increment(95%)
        ProgressBar1.Increment(100%)
        ans = 2 * m1 + m2 * m3
        TextBox3.Text = ans

    End Sub

    Private Sub Areaof4verticalfacesToolStripMenuItem_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Areaof4verticalfacesToolStripMenuItem.Click
        ProgressBar1.Increment(-100%)
        Button24.Visible = True
        Button10.Visible = False
        Button11.Visible = False
        Button12.Visible = False
        Button13.Visible = False
        Button25.Visible = False
        Button26.Visible = False
        Button27.Visible = False
        Button14.Visible = False
        Button15.Visible = False
        Button16.Visible = False
        Button17.Visible = False
        Button18.Visible = False
        Button19.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button20.Visible = False
        Button22.Visible = False
        Button21.Visible = False
        Button24.Width = "220"
        Button24.Text = "Find the area of 4 vertical faces of cuboid"
        TextBox2.Visible = True
        TextBox5.Visible = True
        TextBox6.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        Label2.Text = "Area of 4 vertical faces of cuboid"
        Label4.Visible = True
        Label4.Text = "Length ="
        Label3.Visible = True
        Label3.Text = "2(length + Breath) X Hight"
        Label5.Visible = True
        Label5.Text = "Breath ="
        Label6.Visible = True
        Label6.Text = "Hight ="
        RadioButton1.Visible = False
        RadioButton2.Visible = False
        PictureBox2.Visible = False
        PictureBox8.Visible = False
        PictureBox9.Visible = False
        PictureBox10.Visible = False
        PictureBox11.Visible = False
        PictureBox12.Visible = True
        Button28.Visible = False
        Button29.Visible = False
        Label10.Visible = False
        Button30.Visible = False
        Button31.Visible = False
        Button32.Visible = False
        Button33.Visible = False
        Button34.Visible = False
    End Sub


    Private Sub cylinderCurvedSurfaceAreaToolStripMenuItem_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cylinderCurvedSurfaceAreaToolStripMenuItem.Click
        ProgressBar1.Increment(-100%)
        Button24.Visible = False
        TextBox2.Visible = True
        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button13.Visible = False
        Button14.Visible = False
        Button15.Visible = False
        Button16.Visible = False
        Button7.Visible = False
        Button20.Visible = False
        Button21.Visible = False
        Button22.Visible = False
        Label3.Visible = True
        Label3.Text = "2 X PIE X R X H"
        Label4.Visible = True
        Label5.Visible = True
        Label4.Text = "Radius="
        Label5.Text = "Hight="
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button12.Visible = False
        Label2.Text = "Curved surface area of cylinder"
        PictureBox2.Visible = False
        PictureBox8.Visible = False
        PictureBox9.Visible = False
        PictureBox10.Visible = True
        PictureBox11.Visible = False
        PictureBox12.Visible = False
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        Button25.Visible = True
        Button25.Width = "210"
        Button25.Text = "Find Curved surface area"
        Button26.Visible = False
        Button27.Visible = False
        Button28.Visible = False
        Button29.Visible = False
        Label10.Visible = False
        Button30.Visible = False
        Button31.Visible = False
        Button32.Visible = False
        Button33.Visible = False
        Button34.Visible = False
    End Sub


    Private Sub Button25_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button25.Click
        If TextBox1.Text = "" Then MsgBox("Enter the value in textbox")
        If TextBox2.Text = "" Then MsgBox("Enter the value in textbox")
        If TextBox1.Text = "" Then TextBox1.Text = "0"
        If TextBox2.Text = "" Then TextBox2.Text = "0"
        m1 = TextBox1.Text
        m2 = TextBox2.Text
        ProgressBar1.Increment(10%)
        ProgressBar1.Increment(15%)
        ProgressBar1.Increment(20%)
        ProgressBar1.Increment(25%)
        ProgressBar1.Increment(30%)
        ProgressBar1.Increment(35%)
        ProgressBar1.Increment(40%)
        ProgressBar1.Increment(45%)
        ProgressBar1.Increment(50%)
        ProgressBar1.Increment(55%)
        ProgressBar1.Increment(60%)
        ProgressBar1.Increment(65%)
        ProgressBar1.Increment(70%)
        ProgressBar1.Increment(75%)
        ProgressBar1.Increment(80%)
        ProgressBar1.Increment(85%)
        ProgressBar1.Increment(90%)
        ProgressBar1.Increment(95%)
        ProgressBar1.Increment(100%)
        If p = 2 Then ans = 2 * 22 / 7 * m1 * m2
        If p = 3 Then ans = 2 * 3.14 * m1 * m2
        TextBox3.Text = ans

    End Sub

    Private Sub cylinderTotalSurfaceAreaToolStripMenuItem_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cylinderTotalSurfaceAreaToolStripMenuItem.Click
        ProgressBar1.Increment(-100%)
        Button24.Visible = False
        TextBox2.Visible = True
        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button13.Visible = False
        Button14.Visible = False
        Button15.Visible = False
        Button16.Visible = False
        Button7.Visible = False
        Button20.Visible = False
        Button21.Visible = False
        Button22.Visible = False
        Label3.Visible = True
        Label3.Text = "2 X pie X R(R + H)"
        Label4.Visible = True
        Label5.Visible = True
        Label4.Text = "Radius="
        Label5.Text = "Hight="
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button12.Visible = False
        Label2.Text = "Total surface area of cylinder"
        PictureBox2.Visible = False
        PictureBox8.Visible = False
        PictureBox9.Visible = False
        PictureBox10.Visible = True
        PictureBox11.Visible = False
        PictureBox12.Visible = False
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        Button25.Visible = False
        Label10.Visible = False
        Button26.Visible = True
        Button26.Width = "220"
        Button26.Text = "Find Total surface area"
        Button27.Visible = False
        Button28.Visible = False
        Button29.Visible = False
        Button30.Visible = False
        Button31.Visible = False
        Button32.Visible = False
        Button33.Visible = False
        Button34.Visible = False
    End Sub

    Private Sub Button26_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button26.Click
        If TextBox1.Text = "" Then MsgBox("Enter the value in textbox")
        If TextBox2.Text = "" Then MsgBox("Enter the value in textbox")
        If TextBox1.Text = "" Then TextBox1.Text = "0"
        If TextBox2.Text = "" Then TextBox2.Text = "0"
        m1 = TextBox1.Text
        ProgressBar1.Increment(10%)
        ProgressBar1.Increment(15%)
        ProgressBar1.Increment(20%)
        ProgressBar1.Increment(25%)
        ProgressBar1.Increment(30%)
        ProgressBar1.Increment(35%)
        ProgressBar1.Increment(40%)
        ProgressBar1.Increment(45%)
        ProgressBar1.Increment(50%)
        ProgressBar1.Increment(55%)
        ProgressBar1.Increment(60%)
        ProgressBar1.Increment(65%)
        ProgressBar1.Increment(70%)
        ProgressBar1.Increment(75%)
        ProgressBar1.Increment(80%)
        ProgressBar1.Increment(85%)
        ProgressBar1.Increment(90%)
        ProgressBar1.Increment(95%)
        ProgressBar1.Increment(100%)
        m2 = TextBox2.Text
        If p = 2 Then ans = 2 * 22 / 7 * m1 * m1 + m2
        If p = 3 Then ans = 2 * 3.14 * m1 * m1 + m2
        TextBox3.Text = ans

    End Sub

    Private Sub cylinderVolumeToolStripMenuItem_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cylinderVolumeToolStripMenuItem.Click
        ProgressBar1.Increment(-100%)
        Button24.Visible = False
        TextBox2.Visible = True
        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button13.Visible = False
        Button14.Visible = False
        Button15.Visible = False
        Button16.Visible = False
        Button7.Visible = False
        Button20.Visible = False
        Button21.Visible = False
        Button22.Visible = False
        Label3.Visible = True
        Label3.Text = "pie X R X R X H"
        Label4.Visible = True
        Label5.Visible = True
        Label4.Text = "Radius="
        Label5.Text = "Hight="
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button12.Visible = False
        Label2.Text = "Volume of cylinder"
        PictureBox2.Visible = False
        PictureBox8.Visible = False
        PictureBox9.Visible = False
        PictureBox10.Visible = True
        PictureBox11.Visible = False
        PictureBox12.Visible = False
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        Button25.Visible = False
        Button26.Visible = False
        Button27.Width = "220"
        Button27.Text = "Find Volume"
        Button27.Visible = True
        Button28.Visible = False
        Label10.Visible = False
        Button29.Visible = False
        Button30.Visible = False
        Button31.Visible = False
        Button32.Visible = False
        Button33.Visible = False
        Button34.Visible = False
    End Sub

    Private Sub Button27_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button27.Click
        If TextBox1.Text = "" Then MsgBox("Enter the value in textbox")
        If TextBox2.Text = "" Then MsgBox("Enter the value in textbox")
        If TextBox1.Text = "" Then TextBox1.Text = "0"
        If TextBox2.Text = "" Then TextBox2.Text = "0"
        m1 = TextBox1.Text
        m2 = TextBox2.Text
        ProgressBar1.Increment(10%)
        ProgressBar1.Increment(15%)
        ProgressBar1.Increment(20%)
        ProgressBar1.Increment(25%)
        ProgressBar1.Increment(30%)
        ProgressBar1.Increment(35%)
        ProgressBar1.Increment(40%)
        ProgressBar1.Increment(45%)
        ProgressBar1.Increment(50%)
        ProgressBar1.Increment(55%)
        ProgressBar1.Increment(60%)
        ProgressBar1.Increment(65%)
        ProgressBar1.Increment(70%)
        ProgressBar1.Increment(75%)
        ProgressBar1.Increment(80%)
        ProgressBar1.Increment(85%)
        ProgressBar1.Increment(90%)
        ProgressBar1.Increment(95%)
        ProgressBar1.Increment(100%)
        If p = 2 Then ans = 2 * 22 / 7 * m1 * m1 * m2
        If p = 3 Then ans = 2 * 3.14 * m1 * m1 * m2
        TextBox3.Text = ans

    End Sub

    Private Sub sphereVolume_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sphereVolume.Click
        Button24.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button12.Visible = False
        Button13.Visible = False
        Button14.Visible = False
        Button15.Visible = False
        Button16.Visible = False
        Button17.Visible = False
        Button18.Visible = False
        Button19.Visible = False
        Button20.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button22.Visible = False
        Button6.Visible = False
        Button21.Visible = False
        Button7.Visible = False
        Button20.Visible = False
        Button5.Visible = True
        Button5.Width = "154"
        Button5.Text = "Find the Volume of sphere"
        TextBox2.Visible = False
        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label2.Text = "Volume of sphere"
        Label4.Visible = True
        Label4.Text = "Radius="
        Label3.Visible = True
        Label3.Text = "4/3 X pie X Radius X Radius X Radius"
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        PictureBox2.Visible = True
        PictureBox8.Visible = False
        PictureBox9.Visible = False
        PictureBox10.Visible = False
        PictureBox11.Visible = False
        PictureBox12.Visible = False
        Button25.Visible = False
        Button26.Visible = False
        Button27.Visible = False
        Button28.Visible = False
        Label10.Visible = False
        Button29.Visible = False
        Button30.Visible = False
        Button31.Visible = False
        Button32.Visible = False
        Button33.Visible = False
        Button34.Visible = False
    End Sub

    Private Sub coneCurvedSurfaceAreaToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles coneCurvedSurfaceAreaToolStripMenuItem.Click
        ProgressBar1.Increment(-100%)
        Button24.Visible = False
        TextBox2.Visible = True
        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button13.Visible = False
        Button14.Visible = False
        Button15.Visible = False
        Button16.Visible = False
        Button7.Visible = False
        Button20.Visible = False
        Button21.Visible = False
        Button22.Visible = False
        Label3.Visible = True
        Label3.Text = "pie x R X slant hight of cone"
        Button25.Visible = False
        Button26.Visible = False
        Button27.Visible = False
        Label4.Visible = True
        Label5.Visible = True
        Label5.Text = "Slant hight="
        Label4.Text = "Radius="
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button12.Visible = False
        Label2.Text = "CSA of cone"
        PictureBox2.Visible = False
        PictureBox8.Visible = True
        PictureBox9.Visible = False
        PictureBox10.Visible = False
        PictureBox11.Visible = False
        PictureBox12.Visible = False
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        Button28.Visible = True
        Label10.Visible = False
        Button29.Visible = False
        Button30.Visible = False
        Button31.Visible = False
        Button32.Visible = False
        Button33.Visible = False
        Button34.Visible = False
    End Sub

    Private Sub coneTotalSurfaceAreaToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles coneTotalSurfaceAreaToolStripMenuItem.Click
        ProgressBar1.Increment(-100%)
        Button24.Visible = False
        TextBox2.Visible = True
        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button13.Visible = False
        Button14.Visible = False
        Button15.Visible = False
        Button16.Visible = False
        Button7.Visible = False
        Button20.Visible = False
        Button21.Visible = False
        Button22.Visible = False
        Label3.Visible = True
        Label3.Text = "pie x R ( R + slant hight of cone)"
        Button25.Visible = False
        Button26.Visible = False
        Button27.Visible = False
        Label4.Visible = True
        Label5.Visible = True
        Label5.Text = "Slant hight="
        Label4.Text = "Radius="
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Label10.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button12.Visible = False
        Label2.Text = "TSA of cone"
        PictureBox2.Visible = False
        PictureBox8.Visible = True
        PictureBox9.Visible = False
        PictureBox10.Visible = False
        PictureBox11.Visible = False
        PictureBox12.Visible = False
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        Button28.Visible = False
        Button29.Visible = True
        Button30.Visible = False
        Button31.Visible = False
        Button32.Visible = False
        Button33.Visible = False
        Button34.Visible = False
    End Sub

    Private Sub coneVolumeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles coneVolumeToolStripMenuItem.Click
        ProgressBar1.Increment(-100%)
        Button24.Visible = False
        TextBox2.Visible = True
        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button13.Visible = False
        Button14.Visible = False
        Button15.Visible = False
        Button16.Visible = False
        Button7.Visible = False
        Button20.Visible = False
        Button21.Visible = False
        Button22.Visible = False
        Label3.Visible = True
        Label3.Text = "1/3 X pie x R X R X H"
        Button25.Visible = False
        Button26.Visible = False
        Button27.Visible = False
        Label4.Visible = True
        Label5.Visible = True
        Label5.Text = "hight="
        Label4.Text = "Radius="
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button12.Visible = False
        Label2.Text = "Volume of cone"
        PictureBox2.Visible = False
        PictureBox8.Visible = True
        PictureBox9.Visible = False
        PictureBox10.Visible = False
        PictureBox11.Visible = False
        PictureBox12.Visible = False
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        Button28.Visible = False
        Button29.Visible = False
        Button30.Visible = True
        Label10.Visible = False
        Button31.Visible = False
        Button32.Visible = False
        Button33.Visible = False
        Button34.Visible = False
    End Sub

    Private Sub Button28_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button28.Click
        If TextBox1.Text = "" Then MsgBox("Enter the value in textbox")
        If TextBox2.Text = "" Then MsgBox("Enter the value in textbox")
        If TextBox1.Text = "" Then TextBox1.Text = "0"
        If TextBox2.Text = "" Then TextBox2.Text = "0"
        m1 = TextBox1.Text
        m2 = TextBox2.Text
        ProgressBar1.Increment(10%)
        ProgressBar1.Increment(15%)
        ProgressBar1.Increment(20%)
        ProgressBar1.Increment(25%)
        ProgressBar1.Increment(30%)
        ProgressBar1.Increment(35%)
        ProgressBar1.Increment(40%)
        ProgressBar1.Increment(45%)
        ProgressBar1.Increment(50%)
        ProgressBar1.Increment(55%)
        ProgressBar1.Increment(60%)
        ProgressBar1.Increment(65%)
        ProgressBar1.Increment(70%)
        ProgressBar1.Increment(75%)
        ProgressBar1.Increment(80%)
        ProgressBar1.Increment(85%)
        ProgressBar1.Increment(90%)
        ProgressBar1.Increment(95%)
        ProgressBar1.Increment(100%)
        If p = 2 Then ans = 22 / 7 * m1 * m2
        If p = 3 Then ans = 3.14 * m1 * m2
        TextBox3.Text = ans

    End Sub

    Private Sub Button29_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button29.Click
        If TextBox1.Text = "" Then MsgBox("Enter the value in textbox")
        If TextBox2.Text = "" Then MsgBox("Enter the value in textbox")
        If TextBox1.Text = "" Then TextBox1.Text = "0"
        If TextBox2.Text = "" Then TextBox2.Text = "0"
        m1 = TextBox1.Text
        m2 = TextBox2.Text
        ProgressBar1.Increment(10%)
        ProgressBar1.Increment(15%)
        ProgressBar1.Increment(20%)
        ProgressBar1.Increment(25%)
        ProgressBar1.Increment(30%)
        ProgressBar1.Increment(35%)
        ProgressBar1.Increment(40%)
        ProgressBar1.Increment(45%)
        ProgressBar1.Increment(50%)
        ProgressBar1.Increment(55%)
        ProgressBar1.Increment(60%)
        ProgressBar1.Increment(65%)
        ProgressBar1.Increment(70%)
        ProgressBar1.Increment(75%)
        ProgressBar1.Increment(80%)
        ProgressBar1.Increment(85%)
        ProgressBar1.Increment(90%)
        ProgressBar1.Increment(95%)
        ProgressBar1.Increment(100%)
        If p = 2 Then ans = 22 / 7 * m1 * m1 + m2
        If p = 3 Then ans = 3.14 * m1 * m1 + m2
        TextBox3.Text = ans

    End Sub

    Private Sub Button30_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button30.Click
        If TextBox1.Text = "" Then MsgBox("Enter the value in textbox")
        If TextBox2.Text = "" Then MsgBox("Enter the value in textbox")
        If TextBox1.Text = "" Then TextBox1.Text = "0"
        If TextBox2.Text = "" Then TextBox2.Text = "0"
        m1 = TextBox1.Text
        m2 = TextBox2.Text
        ProgressBar1.Increment(10%)
        ProgressBar1.Increment(15%)
        ProgressBar1.Increment(20%)
        ProgressBar1.Increment(25%)
        ProgressBar1.Increment(30%)
        ProgressBar1.Increment(35%)
        ProgressBar1.Increment(40%)
        ProgressBar1.Increment(45%)
        ProgressBar1.Increment(50%)
        ProgressBar1.Increment(55%)
        ProgressBar1.Increment(60%)
        ProgressBar1.Increment(65%)
        ProgressBar1.Increment(70%)
        ProgressBar1.Increment(75%)
        ProgressBar1.Increment(80%)
        ProgressBar1.Increment(85%)
        ProgressBar1.Increment(90%)
        ProgressBar1.Increment(95%)
        ProgressBar1.Increment(100%)
        If p = 2 Then ans = 1 / 3 * 22 / 7 * m1 * m1 * m2
        If p = 3 Then ans = 1 / 3 * 3.14 * m1 * m1 * m2
        TextBox3.Text = ans

    End Sub


    Private Sub PercentageToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PercentageToolStripMenuItem.Click
        Button31.Visible = True
        Button24.Visible = False
        TextBox2.Visible = True
        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button13.Visible = False
        Button14.Visible = False
        Button15.Visible = False
        Button16.Visible = False
        Button7.Visible = False
        Button20.Visible = False
        Button21.Visible = False
        Button22.Visible = False
        Label3.Visible = False
        Label3.Text = "1/3 X pie x R X R X H"
        Button25.Visible = False
        Button26.Visible = False
        Button27.Visible = False
        Label4.Visible = True
        Label5.Visible = True
        Label5.Text = "Total number"
        Label4.Text = "Number"
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button12.Visible = False
        Label2.Text = "Percentage"
        PictureBox2.Visible = False
        PictureBox8.Visible = False
        PictureBox9.Visible = False
        PictureBox10.Visible = False
        PictureBox11.Visible = False
        PictureBox12.Visible = False
        RadioButton1.Visible = False
        RadioButton2.Visible = False
        Button28.Visible = False
        Button29.Visible = False
        Button30.Visible = False
        Label10.Visible = True
        Button32.Visible = False
        Button33.Visible = False
        Button34.Visible = False
    End Sub

    Private Sub Button31_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button31.Click
        ProgressBar1.Increment(10%)
        ProgressBar1.Increment(15%)
        ProgressBar1.Increment(20%)
        ProgressBar1.Increment(25%)
        ProgressBar1.Increment(30%)
        ProgressBar1.Increment(35%)
        ProgressBar1.Increment(40%)
        ProgressBar1.Increment(45%)
        ProgressBar1.Increment(50%)
        If TextBox1.Text = "" Then MsgBox("Enter the value in textbox")
        If TextBox1.Text = "" Then TextBox1.Text = 0
        If TextBox2.Text = "" Then MsgBox("Enter the value in textbox")
        If TextBox2.Text = "" Then TextBox1.Text = 0
        ProgressBar1.Increment(55%)
        ProgressBar1.Increment(60%)
        ProgressBar1.Increment(65%)
        ProgressBar1.Increment(70%)
        ProgressBar1.Increment(75%)
        ProgressBar1.Increment(80%)
        ProgressBar1.Increment(85%)
        ProgressBar1.Increment(90%)
        ProgressBar1.Increment(95%)
        ProgressBar1.Increment(100%)

        m1 = TextBox1.Text
        m2 = TextBox2.Text
        ans = m1 / m2 * 100
        TextBox3.Text = ans

    End Sub



    Private Sub HemisphereCurvedSurfaceAreaToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HemisphereCurvedSurfaceAreaToolStripMenuItem.Click
        ProgressBar1.Increment(-100%)
        Button24.Visible = False
        TextBox2.Visible = False
        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button13.Visible = False
        Button14.Visible = False
        Button15.Visible = False
        Button16.Visible = False
        Button7.Visible = False
        Button20.Visible = False
        Button21.Visible = False
        Button22.Visible = False
        Label3.Visible = True
        Label3.Text = "2 X pie x R X R"
        Button25.Visible = False
        Button26.Visible = False
        Button27.Visible = False
        Label4.Visible = True
        Label5.Visible = False
        Label5.Text = "hight="
        Label4.Text = "Radius="
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button12.Visible = False
        Label2.Text = "CSA of hemisphere"
        PictureBox2.Visible = False
        PictureBox8.Visible = False
        PictureBox9.Visible = False
        PictureBox10.Visible = False
        PictureBox11.Visible = True
        PictureBox12.Visible = False
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        Button28.Visible = False
        Button29.Visible = False
        Button30.Visible = False
        Label10.Visible = False
        Button31.Visible = False
        Button32.Visible = True
        Button32.Text = "find CSA"
        Button33.Visible = False
        Button34.Visible = False
    End Sub

    Private Sub HemisphereTotalSurfaceAreaToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HemisphereTotalSurfaceAreaToolStripMenuItem.Click
        ProgressBar1.Increment(-100%)
        Button24.Visible = False
        TextBox2.Visible = False
        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button13.Visible = False
        Button14.Visible = False
        Button15.Visible = False
        Button16.Visible = False
        Button7.Visible = False
        Button20.Visible = False
        Button21.Visible = False
        Button22.Visible = False
        Label3.Visible = True
        Label3.Text = "3 X pie x R X R"
        Button25.Visible = False
        Button26.Visible = False
        Button27.Visible = False
        Label4.Visible = True
        Label5.Visible = False
        Label5.Text = "hight="
        Label4.Text = "Radius="
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button12.Visible = False
        Label2.Text = "TSA of hemisphere"
        PictureBox2.Visible = False
        PictureBox8.Visible = False
        PictureBox9.Visible = False
        PictureBox10.Visible = False
        PictureBox11.Visible = True
        PictureBox12.Visible = False
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        Button28.Visible = False
        Button29.Visible = False
        Button30.Visible = False
        Label10.Visible = False
        Button31.Visible = False
        Button32.Visible = False
        Button33.Text = "find TSA"
        Button33.Visible = True
        Button34.Visible = False
    End Sub

    Private Sub HemisphereVolumeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HemisphereVolumeToolStripMenuItem.Click
        ProgressBar1.Increment(-100%)
        Button24.Visible = False
        TextBox2.Visible = False
        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button13.Visible = False
        Button14.Visible = False
        Button15.Visible = False
        Button16.Visible = False
        Button7.Visible = False
        Button20.Visible = False
        Button21.Visible = False
        Button22.Visible = False
        Label3.Visible = True
        Label3.Text = "2/3 X pie x R X R X R"
        Button25.Visible = False
        Button26.Visible = False
        Button27.Visible = False
        Label4.Visible = True
        Label5.Visible = False
        Label5.Text = "hight="
        Label4.Text = "Radius="
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button12.Visible = False
        Label2.Text = "Volume of hemisphere"
        PictureBox2.Visible = False
        PictureBox8.Visible = False
        PictureBox9.Visible = False
        PictureBox10.Visible = False
        PictureBox11.Visible = True
        PictureBox12.Visible = False
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        Button28.Visible = False
        Button29.Visible = False
        Button30.Visible = False
        Label10.Visible = False
        Button31.Visible = False
        Button32.Visible = False
        Button34.Text = "find Volume"
        Button33.Visible = False
        Button34.Visible = True
    End Sub
    Private Sub Button32_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button32.Click
        If TextBox1.Text = "" Then MsgBox("Enter the value in textbox")
        If TextBox1.Text = "" Then TextBox1.Text = "0"
        m1 = TextBox1.Text
        ProgressBar1.Increment(10%)
        ProgressBar1.Increment(15%)
        ProgressBar1.Increment(20%)
        ProgressBar1.Increment(25%)
        ProgressBar1.Increment(30%)
        ProgressBar1.Increment(35%)
        ProgressBar1.Increment(40%)
        ProgressBar1.Increment(45%)
        ProgressBar1.Increment(50%)
        ProgressBar1.Increment(55%)
        ProgressBar1.Increment(60%)
        ProgressBar1.Increment(65%)
        ProgressBar1.Increment(70%)
        ProgressBar1.Increment(75%)
        ProgressBar1.Increment(80%)
        ProgressBar1.Increment(85%)
        ProgressBar1.Increment(90%)
        ProgressBar1.Increment(95%)
        ProgressBar1.Increment(100%)
        If p = 2 Then ans = 2 * 22 / 7 * m1 * m1
        If p = 3 Then ans = 2 * 3.14 * m1 * m1
        TextBox3.Text = ans

    End Sub

    Private Sub Button33_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button33.Click
        If TextBox1.Text = "" Then MsgBox("Enter the value in textbox")
        If TextBox1.Text = "" Then TextBox1.Text = "0"
        m1 = TextBox1.Text
        ProgressBar1.Increment(10%)
        ProgressBar1.Increment(15%)
        ProgressBar1.Increment(20%)
        ProgressBar1.Increment(25%)
        ProgressBar1.Increment(30%)
        ProgressBar1.Increment(35%)
        ProgressBar1.Increment(40%)
        ProgressBar1.Increment(45%)
        ProgressBar1.Increment(50%)
        ProgressBar1.Increment(55%)
        ProgressBar1.Increment(60%)
        ProgressBar1.Increment(65%)
        ProgressBar1.Increment(70%)
        ProgressBar1.Increment(75%)
        ProgressBar1.Increment(80%)
        ProgressBar1.Increment(85%)
        ProgressBar1.Increment(90%)
        ProgressBar1.Increment(95%)
        ProgressBar1.Increment(100%)
        If p = 2 Then ans = 3 * 22 / 7 * m1 * m1
        If p = 3 Then ans = 3 * 3.14 * m1 * m1
        TextBox3.Text = ans

    End Sub

    Private Sub Button34_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button34.Click
        If TextBox1.Text = "" Then MsgBox("Enter the value in textbox")
        If TextBox1.Text = "" Then TextBox1.Text = "0"
        m1 = TextBox1.Text
        ProgressBar1.Increment(10%)
        ProgressBar1.Increment(15%)
        ProgressBar1.Increment(20%)
        ProgressBar1.Increment(25%)
        ProgressBar1.Increment(30%)
        ProgressBar1.Increment(35%)
        ProgressBar1.Increment(40%)
        ProgressBar1.Increment(45%)
        ProgressBar1.Increment(50%)
        ProgressBar1.Increment(55%)
        ProgressBar1.Increment(60%)
        ProgressBar1.Increment(65%)
        ProgressBar1.Increment(70%)
        ProgressBar1.Increment(75%)
        ProgressBar1.Increment(80%)
        ProgressBar1.Increment(85%)
        ProgressBar1.Increment(90%)
        ProgressBar1.Increment(95%)
        ProgressBar1.Increment(100%)
        If p = 2 Then ans = 2 / 3 * 22 / 7 * m1 * m1 * m1
        If p = 3 Then ans = 2 / 3 * 3.14 * m1 * m1 * m1
        TextBox3.Text = ans

    End Sub

    
    Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        NotifyIcon1.Text = "Devesh"




        


    End Sub

    Private Sub CircleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CircleToolStripMenuItem.Click
        ProgressBar1.Increment(-100%)
    End Sub

    Private Sub ConeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ConeToolStripMenuItem.Click
        ProgressBar1.Increment(-100%)
    End Sub

    Private Sub CToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CToolStripMenuItem.Click
        ProgressBar1.Increment(-100%)
    End Sub

    Private Sub CubeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CubeToolStripMenuItem.Click
        ProgressBar1.Increment(-100%)
    End Sub

    Private Sub CuboidToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CuboidToolStripMenuItem.Click
        ProgressBar1.Increment(-100%)
    End Sub

    Private Sub HemisphereToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HemisphereToolStripMenuItem.Click
        ProgressBar1.Increment(-100%)
    End Sub

    Private Sub MenuStrip1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuStrip1.Click
        ProgressBar1.Increment(-100%)
    End Sub

    Private Sub NotifyIcon1_BalloonTipShown(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.BalloonTipShown

        NotifyIcon1.BalloonTipText = "Welcome"
    End Sub


    Private Sub NotifyIcon1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.Click
        AboutBox1.Show()
    End Sub

    
    Private Sub WebBrowser1_FileDownload(ByVal sender As Object, ByVal e As System.EventArgs) Handles WebBrowser1.FileDownload

    End Sub
End Class