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

Imports System
Imports System.Runtime.Serialization

Namespace ThrottleService
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="Range", [Namespace]:="http://schemas.datacontract.org/2004/07/ScottPage.RollsRoyce.TestCellSimulator.Si"& _ 
        "mulation.Models"),  _
     System.SerializableAttribute()>  _
    Partial Public Class Range
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private MaximumField As Double
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private MinimumField As Double
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Maximum() As Double
            Get
                Return Me.MaximumField
            End Get
            Set
                If (Me.MaximumField.Equals(value) <> true) Then
                    Me.MaximumField = value
                    Me.RaisePropertyChanged("Maximum")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Minimum() As Double
            Get
                Return Me.MinimumField
            End Get
            Set
                If (Me.MinimumField.Equals(value) <> true) Then
                    Me.MinimumField = value
                    Me.RaisePropertyChanged("Minimum")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="ThrottleService.IThrottleService", SessionMode:=System.ServiceModel.SessionMode.NotAllowed)>  _
    Public Interface IThrottleService
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IThrottleService/GetLeverAngle", ReplyAction:="http://tempuri.org/IThrottleService/GetLeverAngleResponse")>  _
        Function GetLeverAngle() As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IThrottleService/GetLeverAngle", ReplyAction:="http://tempuri.org/IThrottleService/GetLeverAngleResponse")>  _
        Function GetLeverAngleAsync() As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(IsOneWay:=true, Action:="http://tempuri.org/IThrottleService/UpdateLeverAngle")>  _
        Sub UpdateLeverAngle(ByVal value As Double)
        
        <System.ServiceModel.OperationContractAttribute(IsOneWay:=true, Action:="http://tempuri.org/IThrottleService/UpdateLeverAngle")>  _
        Function UpdateLeverAngleAsync(ByVal value As Double) As System.Threading.Tasks.Task
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IThrottleService/GetRange", ReplyAction:="http://tempuri.org/IThrottleService/GetRangeResponse")>  _
        Function GetRange() As ThrottleService.Range
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IThrottleService/GetRange", ReplyAction:="http://tempuri.org/IThrottleService/GetRangeResponse")>  _
        Function GetRangeAsync() As System.Threading.Tasks.Task(Of ThrottleService.Range)
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface IThrottleServiceChannel
        Inherits ThrottleService.IThrottleService, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class ThrottleServiceClient
        Inherits System.ServiceModel.ClientBase(Of ThrottleService.IThrottleService)
        Implements ThrottleService.IThrottleService
        
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
        
        Public Function GetLeverAngle() As Double Implements ThrottleService.IThrottleService.GetLeverAngle
            Return MyBase.Channel.GetLeverAngle
        End Function
        
        Public Function GetLeverAngleAsync() As System.Threading.Tasks.Task(Of Double) Implements ThrottleService.IThrottleService.GetLeverAngleAsync
            Return MyBase.Channel.GetLeverAngleAsync
        End Function
        
        Public Sub UpdateLeverAngle(ByVal value As Double) Implements ThrottleService.IThrottleService.UpdateLeverAngle
            MyBase.Channel.UpdateLeverAngle(value)
        End Sub
        
        Public Function UpdateLeverAngleAsync(ByVal value As Double) As System.Threading.Tasks.Task Implements ThrottleService.IThrottleService.UpdateLeverAngleAsync
            Return MyBase.Channel.UpdateLeverAngleAsync(value)
        End Function
        
        Public Function GetRange() As ThrottleService.Range Implements ThrottleService.IThrottleService.GetRange
            Return MyBase.Channel.GetRange
        End Function
        
        Public Function GetRangeAsync() As System.Threading.Tasks.Task(Of ThrottleService.Range) Implements ThrottleService.IThrottleService.GetRangeAsync
            Return MyBase.Channel.GetRangeAsync
        End Function
    End Class
End Namespace
