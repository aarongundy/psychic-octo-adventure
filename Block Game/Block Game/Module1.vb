Module Module1

    Public Structure LevelFinder
        Dim userlevel As Integer
    End Structure

    Public Const moveChar As String = "F:\programming\Block Game\Block Game\bin\Debug\button-14.wav"
    Public Const background As String = "F:\programming\Block Game\Block Game\bin\Debug\background.mp3"
    Public low As Integer = 25
    Public medium As Integer = 50
    Public high As Integer = 75
    Public off As Integer = 0
    'Public soundLevel(4) As Array
    'soundLevel(0) As Integer = 0
    Public backgroundImage As Image
    Public backgroundColor As Color = Color.Black
    Public textColor As Color = Color.White
    Public userName As String
    Public userlevel As Integer
    Public editOption As String
    Public timeArray(64) As Double
    Public winningSquare As Integer
    Public startingSquare As Integer
End Module
