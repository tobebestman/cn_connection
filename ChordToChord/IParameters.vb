Imports Bentley.ProStructures.CadSystem
Imports Bentley.ProStructures.Connection.General

Public Interface IParameters
    Sub ReadFromConnection(eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer)
    Sub ReadFromTemplate(Template As PsTemplateManager, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer)
    Sub WriteToConnection(ByRef eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer)
    Sub WriteToTemplate(ByRef Template As PsTemplateManager)
End Interface
