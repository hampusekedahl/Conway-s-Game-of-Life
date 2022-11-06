module Gui
    open System.Windows.Forms
    open System.Drawing

    let defaultSize = new Size(30,30)
    let buttonPos color x y = new Button(Top=x, Left=y, Size=defaultSize, BackColor=color, ForeColor=Color.FromArgb(0xFFFFFFFF))

    let gameButtons = seq{ for y in 1..16 do for x in 1..16 -> (buttonPos (Color.FromArgb(0xFF262626)) (x*30+70) (y*30+325)) } 
   
    let gameButtons1 = Seq.toArray(gameButtons)

    let windowForm = new Form(Text = "Conway's Game of Life", BackColor = Color.FromArgb(0xFF191919),  Height=800, Width=1200)
    let titleLabel=new Label(Top=25,Left=535, Width = 130, Text="Conway's Game of Life", ForeColor=Color.FromArgb(0xFFFFFFFF))

    let clearBtn =new Button(Text="CLEAR",Top=666,Left=325, Height=30, Width = 100, BackColor=Color.FromArgb(0xFF193441), ForeColor=Color.FromArgb(0xFFFFFFFF))
    let pauseBtn =new Button(Text="STOP",Top=666,Left=475, Height=30, Width = 100, BackColor=Color.FromArgb(0xFFe74c3c), ForeColor=Color.FromArgb(0xFFFFFFFF))
    let startBtn =new Button(Text="START",Top=666,Left=625, Height=30, Width = 100, BackColor=Color.FromArgb(0xFF58B455),ForeColor=Color.FromArgb(0xFFFFFFFF))
    let nextBtn =new Button(Text="NEXT",Top=666,Left=775, Height=30,Width = 100, BackColor=Color.FromArgb(0xFFffe11a),ForeColor=Color.FromArgb(0xFF262626))

    let fileLabel = new Label(Top=250,Left=90, Width = 130, Text="Input Filename", ForeColor=Color.FromArgb(0xFFFFFFFF))
    let saveBtn = new Button(Text="SAVE", Top=360, Left=140, Height=30, Width = 70,  BackColor=Color.FromArgb(0xFF58B455), ForeColor=Color.FromArgb(0xFFFFFFFF))
    let loadBtn = new Button(Text="LOAD", Top=360, Left=50, Height=30, Width = 70, BackColor=Color.FromArgb(0xFFe74c3c), ForeColor=Color.FromArgb(0xFFFFFFFF))
    let fileInput = new TextBox(Top=290, Left=50, Width = 160,  BackColor=Color.FromArgb(0xFF262626), ForeColor=Color.FromArgb(0xFFFFFFFF))

    let subtractBtn =new Button(Text="-",Top=400,Left=1050, Height=30, Width=50, BackColor=Color.FromArgb(0xFFe74c3c), ForeColor=Color.FromArgb(0xFFFFFFFF))
    let generationLabel=new Label(Top=360,Left=1065,Width=20, Height=20, Text="0", ForeColor=Color.FromArgb(0xFFFFFFFF))
    let addBtn =new Button(Text="+",Top=300,Left=1050, Height=30, Width=50, BackColor=Color.FromArgb(0xFF58B455), ForeColor=Color.FromArgb(0xFFFFFFFF))
    let infinityBtn =new Button(Text="∞",Top=240,Left=1050, Height=30, Width=50, BackColor=Color.FromArgb(0xFF3498db), ForeColor=Color.FromArgb(0xFFFFFFFF))
    

        
    
    windowForm.Controls.AddRange (gameButtons1|> Seq.cast |> Seq.toArray)
 
    windowForm.Controls.Add(fileLabel)
    windowForm.Controls.Add(titleLabel)
    windowForm.Controls.Add(nextBtn)
    windowForm.Controls.Add(startBtn)
    windowForm.Controls.Add(clearBtn)
    windowForm.Controls.Add(pauseBtn)
    windowForm.Controls.Add(subtractBtn)
    windowForm.Controls.Add(generationLabel)
    windowForm.Controls.Add(addBtn)
    windowForm.Controls.Add(infinityBtn)
    windowForm.Controls.Add(saveBtn)
    windowForm.Controls.Add(loadBtn)
    windowForm.Controls.Add(fileInput)
        
    





