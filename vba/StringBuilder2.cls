VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
END
Attribute VB_Name = "StringBuilder"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
'@Description("Represents a mutable string of characters.")
'based on the original work by @Blackhawk posted on Code Review Stack Exchange under CC-BY-SA.
'https://codereview.stackexchange.com/q/67596/23788
'adapted by Mathieu Guindon

Option Explicit

Private Declare PtrSafe Sub CopyMemory Lib "kernel32.dll" Alias "RtlMoveMemory" (ByVal dst As LongPtr, ByVal src As LongPtr, ByVal Length As LongPtr)

Public Enum StringBuilderError
    AppendFailed = vbObjectError Or 255
        InvalidMemberCall
End Enum

Private Const InitialCharCapacity As Long = 16
Private Const CharByteSize As Long = 2

Private currentByteLength As Long
Private buffer() As Byte

'@Description("Creates a new instance, optionally initialized with the specified content and/or character capacity.")
Public Function Create(Optional ByVal content As String, Optional ByVal initialCapacity As Long = InitialCharCapacity) As StringBuilder
        Dim result As StringBuilder
        Set result = New StringBuilder
        result.Capacity = IIf(initialCapacity < Len(content), Len(content), initialCapacity)
        result.Append content
        Set Create = result
End Function

Private Property Get IsDefaultInstance() As Boolean
        IsDefaultInstance = Me Is StringBuilder
End Property

Private Sub ThrowIfInvalidMemberCall()
        If IsDefaultInstance Then Err.Raise StringBuilderError.InvalidMemberCall, TypeName(Me), "Member call is invalid against default instance."
End Sub

'@Description("Appends a copy of the specified string to this instance.")
Public Function Append(ByVal value As String) As StringBuilder
        ThrowIfInvalidMemberCall
    On Error GoTo CleanFail
    
    Dim valueByteLength As Long
    valueByteLength = LenB(value)
    
    Dim newBufferSize As Long
    newBufferSize = currentByteLength + valueByteLength
    
    If newBufferSize < UBound(buffer) Then
        'got room, no need to resize
        CopyMemory VarPtr(buffer(currentByteLength)), StrPtr(value), valueByteLength
    Else
        If newBufferSize < UBound(buffer) * 2 Then
            'double buffer capacity
            ResizeBuffer
        Else
            ResizeBuffer newBufferSize
        End If
        CopyMemory VarPtr(buffer(currentByteLength)), StrPtr(value), valueByteLength
    End If
    
    currentByteLength = newBufferSize
    Set Append = Me
    
CleanExit:
    Exit Function

CleanFail:
    'Set Append = Nothing
    'Resume CleanExit
    With Err
        .Raise StringBuilderError.AppendFailed, TypeName(Me), .Description
    End With
End Function

'@Description("Gets the character length of the current instance.")
Public Property Get Length() As Long
        ThrowIfInvalidMemberCall
    Length = currentByteLength / CharByteSize
End Property

'@Description("Gets the current buffer capacity of the current instance.")
Public Property Get Capacity() As Long
        ThrowIfInvalidMemberCall
    Capacity = UBound(buffer)
End Property

Friend Property Let Capacity(ByVal value As Long)
        ThrowIfInvalidMemberCall
        ReDim buffer(0 To (value * CharByteSize) - 1)
End Property

Private Sub ResizeBuffer(Optional ByVal newSize As Long = 0)
    If newSize <> 0 Then
        ReDim Preserve buffer(0 To newSize - 1)
    Else
        ReDim Preserve buffer(0 To (UBound(buffer) * 2) + 1)
    End If
End Sub

'@Description("Returns the string content of the current instance.")
Public Function ToString() As String
        ThrowIfInvalidMemberCall
    ToString = Mid$(buffer, 1, currentByteLength / CharByteSize)
End Function
