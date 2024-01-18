<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        BurgerPB = New PictureBox()
        dinerLB = New Label()
        drinksLBL = New Label()
        saladLBL = New Label()
        rootBeerLBL = New Label()
        cokeZeroLBL = New Label()
        totalItemsLBL = New Label()
        appetizersLBL = New Label()
        frenchFriesLBL = New Label()
        appetizerGB = New GroupBox()
        saladTB = New TextBox()
        frenchFriesTB = New TextBox()
        drinksGB = New GroupBox()
        cokeZeroTB = New TextBox()
        rootBeerTB = New TextBox()
        entreesLBL = New Label()
        cheeseBurgerLBL = New Label()
        chickenBurgerLBL = New Label()
        cheeseBurgerTB = New TextBox()
        chickenBurgerTB = New TextBox()
        entreesGB = New GroupBox()
        clearBTN = New Button()
        calculateBTN = New Button()
        outputLBL = New Label()
        CType(BurgerPB, ComponentModel.ISupportInitialize).BeginInit()
        appetizerGB.SuspendLayout()
        drinksGB.SuspendLayout()
        entreesGB.SuspendLayout()
        SuspendLayout()
        ' 
        ' BurgerPB
        ' 
        BurgerPB.BackColor = Color.OliveDrab
        BurgerPB.BorderStyle = BorderStyle.Fixed3D
        BurgerPB.Image = CType(resources.GetObject("BurgerPB.Image"), Image)
        BurgerPB.Location = New Point(445, 154)
        BurgerPB.Name = "BurgerPB"
        BurgerPB.Size = New Size(381, 297)
        BurgerPB.SizeMode = PictureBoxSizeMode.CenterImage
        BurgerPB.TabIndex = 0
        BurgerPB.TabStop = False
        ' 
        ' dinerLB
        ' 
        dinerLB.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dinerLB.AutoSize = True
        dinerLB.Font = New Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point)
        dinerLB.Location = New Point(253, 21)
        dinerLB.Name = "dinerLB"
        dinerLB.Size = New Size(409, 70)
        dinerLB.TabIndex = 1
        dinerLB.Text = "Brayden's Diner"
        ' 
        ' drinksLBL
        ' 
        drinksLBL.AutoSize = True
        drinksLBL.Font = New Font("Stencil", 14F, FontStyle.Bold, GraphicsUnit.Point)
        drinksLBL.Location = New Point(12, -3)
        drinksLBL.Name = "drinksLBL"
        drinksLBL.Size = New Size(126, 33)
        drinksLBL.TabIndex = 4
        drinksLBL.Text = "Drinks"
        ' 
        ' saladLBL
        ' 
        saladLBL.AutoSize = True
        saladLBL.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point)
        saladLBL.Location = New Point(24, 86)
        saladLBL.Name = "saladLBL"
        saladLBL.Size = New Size(71, 30)
        saladLBL.TabIndex = 6
        saladLBL.Text = "Salad:"
        ' 
        ' rootBeerLBL
        ' 
        rootBeerLBL.AutoSize = True
        rootBeerLBL.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point)
        rootBeerLBL.Location = New Point(26, 47)
        rootBeerLBL.Name = "rootBeerLBL"
        rootBeerLBL.Size = New Size(117, 30)
        rootBeerLBL.TabIndex = 9
        rootBeerLBL.Text = "Root Beer:"
        ' 
        ' cokeZeroLBL
        ' 
        cokeZeroLBL.AutoSize = True
        cokeZeroLBL.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point)
        cokeZeroLBL.Location = New Point(26, 87)
        cokeZeroLBL.Name = "cokeZeroLBL"
        cokeZeroLBL.Size = New Size(121, 30)
        cokeZeroLBL.TabIndex = 10
        cokeZeroLBL.Text = "Coke Zero:"
        ' 
        ' totalItemsLBL
        ' 
        totalItemsLBL.AutoSize = True
        totalItemsLBL.Font = New Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point)
        totalItemsLBL.Location = New Point(462, 477)
        totalItemsLBL.Name = "totalItemsLBL"
        totalItemsLBL.Size = New Size(180, 29)
        totalItemsLBL.TabIndex = 11
        totalItemsLBL.Text = "Total Items:"
        ' 
        ' appetizersLBL
        ' 
        appetizersLBL.AutoSize = True
        appetizersLBL.Font = New Font("Stencil", 14F, FontStyle.Bold, GraphicsUnit.Point)
        appetizersLBL.Location = New Point(12, 0)
        appetizersLBL.Name = "appetizersLBL"
        appetizersLBL.Size = New Size(189, 33)
        appetizersLBL.TabIndex = 2
        appetizersLBL.Text = "Appetizers"
        ' 
        ' frenchFriesLBL
        ' 
        frenchFriesLBL.AutoSize = True
        frenchFriesLBL.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point)
        frenchFriesLBL.Location = New Point(26, 47)
        frenchFriesLBL.Name = "frenchFriesLBL"
        frenchFriesLBL.Size = New Size(137, 30)
        frenchFriesLBL.TabIndex = 5
        frenchFriesLBL.Text = "French Fries:"
        ' 
        ' appetizerGB
        ' 
        appetizerGB.BackColor = Color.BurlyWood
        appetizerGB.BackgroundImageLayout = ImageLayout.None
        appetizerGB.Controls.Add(saladTB)
        appetizerGB.Controls.Add(frenchFriesTB)
        appetizerGB.Controls.Add(saladLBL)
        appetizerGB.Controls.Add(frenchFriesLBL)
        appetizerGB.Controls.Add(appetizersLBL)
        appetizerGB.Location = New Point(53, 154)
        appetizerGB.Name = "appetizerGB"
        appetizerGB.Size = New Size(339, 133)
        appetizerGB.TabIndex = 12
        appetizerGB.TabStop = False
        ' 
        ' saladTB
        ' 
        saladTB.Font = New Font("Stencil", 11F, FontStyle.Regular, GraphicsUnit.Point)
        saladTB.Location = New Point(212, 87)
        saladTB.Name = "saladTB"
        saladTB.Size = New Size(109, 34)
        saladTB.TabIndex = 12
        saladTB.TextAlign = HorizontalAlignment.Right
        ' 
        ' frenchFriesTB
        ' 
        frenchFriesTB.Font = New Font("Stencil", 11F, FontStyle.Regular, GraphicsUnit.Point)
        frenchFriesTB.Location = New Point(212, 48)
        frenchFriesTB.Name = "frenchFriesTB"
        frenchFriesTB.Size = New Size(109, 34)
        frenchFriesTB.TabIndex = 11
        frenchFriesTB.TextAlign = HorizontalAlignment.Right
        ' 
        ' drinksGB
        ' 
        drinksGB.BackColor = Color.BurlyWood
        drinksGB.Controls.Add(cokeZeroTB)
        drinksGB.Controls.Add(rootBeerTB)
        drinksGB.Controls.Add(cokeZeroLBL)
        drinksGB.Controls.Add(rootBeerLBL)
        drinksGB.Controls.Add(drinksLBL)
        drinksGB.Location = New Point(53, 456)
        drinksGB.Name = "drinksGB"
        drinksGB.Size = New Size(339, 133)
        drinksGB.TabIndex = 14
        drinksGB.TabStop = False
        ' 
        ' cokeZeroTB
        ' 
        cokeZeroTB.Font = New Font("Stencil", 11F, FontStyle.Regular, GraphicsUnit.Point)
        cokeZeroTB.Location = New Point(212, 87)
        cokeZeroTB.Name = "cokeZeroTB"
        cokeZeroTB.Size = New Size(109, 34)
        cokeZeroTB.TabIndex = 12
        cokeZeroTB.TextAlign = HorizontalAlignment.Right
        ' 
        ' rootBeerTB
        ' 
        rootBeerTB.Font = New Font("Stencil", 11F, FontStyle.Regular, GraphicsUnit.Point)
        rootBeerTB.Location = New Point(212, 48)
        rootBeerTB.Name = "rootBeerTB"
        rootBeerTB.Size = New Size(109, 34)
        rootBeerTB.TabIndex = 11
        rootBeerTB.TextAlign = HorizontalAlignment.Right
        ' 
        ' entreesLBL
        ' 
        entreesLBL.AutoSize = True
        entreesLBL.Font = New Font("Stencil", 14F, FontStyle.Bold, GraphicsUnit.Point)
        entreesLBL.Location = New Point(12, 0)
        entreesLBL.Name = "entreesLBL"
        entreesLBL.Size = New Size(142, 33)
        entreesLBL.TabIndex = 3
        entreesLBL.Text = "Entrees"
        ' 
        ' cheeseBurgerLBL
        ' 
        cheeseBurgerLBL.AutoSize = True
        cheeseBurgerLBL.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point)
        cheeseBurgerLBL.Location = New Point(24, 46)
        cheeseBurgerLBL.Name = "cheeseBurgerLBL"
        cheeseBurgerLBL.Size = New Size(164, 30)
        cheeseBurgerLBL.TabIndex = 7
        cheeseBurgerLBL.Text = "Cheese Burger:"
        ' 
        ' chickenBurgerLBL
        ' 
        chickenBurgerLBL.AutoSize = True
        chickenBurgerLBL.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point)
        chickenBurgerLBL.Location = New Point(26, 85)
        chickenBurgerLBL.Name = "chickenBurgerLBL"
        chickenBurgerLBL.Size = New Size(172, 30)
        chickenBurgerLBL.TabIndex = 8
        chickenBurgerLBL.Text = "Chicken Burger:"
        ' 
        ' cheeseBurgerTB
        ' 
        cheeseBurgerTB.Font = New Font("Stencil", 11F, FontStyle.Regular, GraphicsUnit.Point)
        cheeseBurgerTB.Location = New Point(212, 47)
        cheeseBurgerTB.Name = "cheeseBurgerTB"
        cheeseBurgerTB.Size = New Size(109, 34)
        cheeseBurgerTB.TabIndex = 9
        cheeseBurgerTB.TextAlign = HorizontalAlignment.Right
        ' 
        ' chickenBurgerTB
        ' 
        chickenBurgerTB.Font = New Font("Stencil", 11F, FontStyle.Regular, GraphicsUnit.Point)
        chickenBurgerTB.Location = New Point(212, 86)
        chickenBurgerTB.Name = "chickenBurgerTB"
        chickenBurgerTB.Size = New Size(109, 34)
        chickenBurgerTB.TabIndex = 10
        chickenBurgerTB.TextAlign = HorizontalAlignment.Right
        ' 
        ' entreesGB
        ' 
        entreesGB.BackColor = Color.BurlyWood
        entreesGB.Controls.Add(chickenBurgerTB)
        entreesGB.Controls.Add(cheeseBurgerTB)
        entreesGB.Controls.Add(chickenBurgerLBL)
        entreesGB.Controls.Add(cheeseBurgerLBL)
        entreesGB.Controls.Add(entreesLBL)
        entreesGB.Location = New Point(53, 306)
        entreesGB.Name = "entreesGB"
        entreesGB.Size = New Size(339, 133)
        entreesGB.TabIndex = 13
        entreesGB.TabStop = False
        ' 
        ' clearBTN
        ' 
        clearBTN.Cursor = Cursors.Hand
        clearBTN.Font = New Font("Stencil", 14F, FontStyle.Bold, GraphicsUnit.Point)
        clearBTN.Location = New Point(445, 543)
        clearBTN.Name = "clearBTN"
        clearBTN.Size = New Size(184, 46)
        clearBTN.TabIndex = 15
        clearBTN.Text = "Clear"
        clearBTN.UseVisualStyleBackColor = True
        ' 
        ' calculateBTN
        ' 
        calculateBTN.Cursor = Cursors.Hand
        calculateBTN.Font = New Font("Stencil", 14F, FontStyle.Bold, GraphicsUnit.Point)
        calculateBTN.Location = New Point(642, 543)
        calculateBTN.Name = "calculateBTN"
        calculateBTN.Size = New Size(184, 46)
        calculateBTN.TabIndex = 16
        calculateBTN.Text = "Calculate"
        calculateBTN.UseVisualStyleBackColor = True
        ' 
        ' outputLBL
        ' 
        outputLBL.BackColor = Color.BurlyWood
        outputLBL.BorderStyle = BorderStyle.Fixed3D
        outputLBL.Font = New Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point)
        outputLBL.Location = New Point(665, 471)
        outputLBL.Name = "outputLBL"
        outputLBL.Size = New Size(134, 44)
        outputLBL.TabIndex = 17
        outputLBL.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.OliveDrab
        ClientSize = New Size(878, 611)
        Controls.Add(outputLBL)
        Controls.Add(calculateBTN)
        Controls.Add(clearBTN)
        Controls.Add(drinksGB)
        Controls.Add(entreesGB)
        Controls.Add(appetizerGB)
        Controls.Add(totalItemsLBL)
        Controls.Add(dinerLB)
        Controls.Add(BurgerPB)
        Name = "Form1"
        Text = "Form1"
        CType(BurgerPB, ComponentModel.ISupportInitialize).EndInit()
        appetizerGB.ResumeLayout(False)
        appetizerGB.PerformLayout()
        drinksGB.ResumeLayout(False)
        drinksGB.PerformLayout()
        entreesGB.ResumeLayout(False)
        entreesGB.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BurgerPB As PictureBox
    Friend WithEvents dinerLB As Label
    Friend WithEvents drinksLBL As Label
    Friend WithEvents saladLBL As Label
    Friend WithEvents rootBeerLBL As Label
    Friend WithEvents cokeZeroLBL As Label
    Friend WithEvents totalItemsLBL As Label
    Friend WithEvents appetizersLBL As Label
    Friend WithEvents frenchFriesLBL As Label
    Friend WithEvents appetizerGB As GroupBox
    Friend WithEvents drinksGB As GroupBox
    Friend WithEvents entreesLBL As Label
    Friend WithEvents cheeseBurgerLBL As Label
    Friend WithEvents chickenBurgerLBL As Label
    Friend WithEvents cheeseBurgerTB As TextBox
    Friend WithEvents chickenBurgerTB As TextBox
    Friend WithEvents entreesGB As GroupBox
    Friend WithEvents clearBTN As Button
    Friend WithEvents calculateBTN As Button
    Friend WithEvents cokeZeroTB As TextBox
    Friend WithEvents rootBeerTB As TextBox
    Friend WithEvents saladTB As TextBox
    Friend WithEvents frenchFriesTB As TextBox
    Friend WithEvents outputLBL As Label

End Class
