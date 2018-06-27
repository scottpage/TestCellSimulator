﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System.Runtime.Serialization

Namespace UnifiedEventLogService
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="Severity", [Namespace]:="http://schemas.datacontract.org/2004/07/ScottPage.RollsRoyce.TestCellSimulator.Di"& _ 
        "splays.Services")>  _
    Public Enum Severity As Integer
        
        <System.Runtime.Serialization.EnumMemberAttribute()>  _
        Information = 0
        
        <System.Runtime.Serialization.EnumMemberAttribute()>  _
        Warning = 1
        
        <System.Runtime.Serialization.EnumMemberAttribute()>  _
        Critical = 2
    End Enum
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="UnifiedEventLogService.IUnifiedEventLogService")>  _
    Public Interface IUnifiedEventLogService
        
        <System.ServiceModel.OperationContractAttribute(IsOneWay:=true, Action:="http://tempuri.org/IUnifiedEventLogService/LogEntry")>  _
        Sub LogEntry(ByVal severity As UnifiedEventLogService.Severity, ByVal source As String, ByVal message As String)
        
        <System.ServiceModel.OperationContractAttribute(IsOneWay:=true, AsyncPattern:=true, Action:="http://tempuri.org/IUnifiedEventLogService/LogEntry")>  _
        Function BeginLogEntry(ByVal severity As UnifiedEventLogService.Severity, ByVal source As String, ByVal message As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
        
        Sub EndLogEntry(ByVal result As System.IAsyncResult)
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface IUnifiedEventLogServiceChannel
        Inherits UnifiedEventLogService.IUnifiedEventLogService, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class UnifiedEventLogServiceClient
        Inherits System.ServiceModel.ClientBase(Of UnifiedEventLogService.IUnifiedEventLogService)
        Implements UnifiedEventLogService.IUnifiedEventLogService
        
        Private onBeginLogEntryDelegate As BeginOperationDelegate
        
        Private onEndLogEntryDelegate As EndOperationDelegate
        
        Private onLogEntryCompletedDelegate As System.Threading.SendOrPostCallback
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Event LogEntryCompleted As System.EventHandler(Of System.ComponentModel.AsyncCompletedEventArgs)
        
        Public Sub LogEntry(ByVal severity As UnifiedEventLogService.Severity, ByVal source As String, ByVal message As String) Implements UnifiedEventLogService.IUnifiedEventLogService.LogEntry
            MyBase.Channel.LogEntry(severity, source, message)
        End Sub
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public Function BeginLogEntry(ByVal severity As UnifiedEventLogService.Severity, ByVal source As String, ByVal message As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult Implements UnifiedEventLogService.IUnifiedEventLogService.BeginLogEntry
            Return MyBase.Channel.BeginLogEntry(severity, source, message, callback, asyncState)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public Sub EndLogEntry(ByVal result As System.IAsyncResult) Implements UnifiedEventLogService.IUnifiedEventLogService.EndLogEntry
            MyBase.Channel.EndLogEntry(result)
        End Sub
        
        Private Function OnBeginLogEntry(ByVal inValues() As Object, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Dim severity As UnifiedEventLogService.Severity = CType(inValues(0),UnifiedEventLogService.Severity)
            Dim source As String = CType(inValues(1),String)
            Dim message As String = CType(inValues(2),String)
            Return Me.BeginLogEntry(severity, source, message, callback, asyncState)
        End Function
        
        Private Function OnEndLogEntry(ByVal result As System.IAsyncResult) As Object()
            Me.EndLogEntry(result)
            Return Nothing
        End Function
        
        Private Sub OnLogEntryCompleted(ByVal state As Object)
            If (Not (Me.LogEntryCompletedEvent) Is Nothing) Then
                Dim e As InvokeAsyncCompletedEventArgs = CType(state,InvokeAsyncCompletedEventArgs)
                RaiseEvent LogEntryCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState))
            End If
        End Sub
        
        Public Overloads Sub LogEntryAsync(ByVal severity As UnifiedEventLogService.Severity, ByVal source As String, ByVal message As String)
            Me.LogEntryAsync(severity, source, message, Nothing)
        End Sub
        
        Public Overloads Sub LogEntryAsync(ByVal severity As UnifiedEventLogService.Severity, ByVal source As String, ByVal message As String, ByVal userState As Object)
            If (Me.onBeginLogEntryDelegate Is Nothing) Then
                Me.onBeginLogEntryDelegate = AddressOf Me.OnBeginLogEntry
            End If
            If (Me.onEndLogEntryDelegate Is Nothing) Then
                Me.onEndLogEntryDelegate = AddressOf Me.OnEndLogEntry
            End If
            If (Me.onLogEntryCompletedDelegate Is Nothing) Then
                Me.onLogEntryCompletedDelegate = AddressOf Me.OnLogEntryCompleted
            End If
            MyBase.InvokeAsync(Me.onBeginLogEntryDelegate, New Object() {severity, source, message}, Me.onEndLogEntryDelegate, Me.onLogEntryCompletedDelegate, userState)
        End Sub
    End Class
End Namespace
