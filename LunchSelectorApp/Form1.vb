Public Class Form1
    Private Sub calculateBTN_Click(sender As Object, e As EventArgs) Handles calculateBTN.Click

        Dim frenchFries As Integer = Val(frenchFriesTB.Text)
        Dim salad As Integer = Val(saladTB.Text)
        Dim cheeseBurger As Integer = Val(cheeseBurgerTB.Text)
        Dim chickenBurger As Integer = Val(chickenBurgerTB.Text)
        Dim rootBeer As Integer = Val(rootBeerTB.Text)
        Dim cokeZero As Integer = Val(cokeZeroTB.Text)
        Dim totalItems As Integer
        totalItems = frenchFries + salad + cheeseBurger + chickenBurger + rootBeer + cokeZero

        outputLBL.Text = totalItems.ToString

    End Sub

    Private Sub clearBTN_Click(sender As Object, e As EventArgs) Handles clearBTN.Click

        frenchFriesTB.Text = " "
        saladTB.Text = " "
        cheeseBurgerTB.Text = " "
        chickenBurgerTB.Text = " "
        rootBeerTB.Text = " "
        cokeZeroTB.Text = " "
        outputLBL.Text = " "

    End Sub

    Private Sub input_TextChanged(sender As Object, e As EventArgs) _
            Handles frenchFriesTB.TextChanged, saladTB.TextChanged, cheeseBurgerTB.TextChanged,
                    chickenBurgerTB.TextChanged, rootBeerTB.TextChanged, cokeZeroTB.TextChanged

        outputLBL.Text = ""

    End Sub
End Class
