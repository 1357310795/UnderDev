﻿#ExternalChecksum("..\..\..\..\View\CameraView.xaml","{8829d00f-11b8-4213-878b-770e8597ac16}","6C30F8328D4941DD693C8DB058E94DA172EECF3DFC034F1E32F64FFDF39B2BDD")
'------------------------------------------------------------------------------
' <auto-generated>
'     此代码由工具生成。
'     运行时版本:4.0.30319.42000
'
'     对此文件的更改可能会导致不正确的行为，并且如果
'     重新生成代码，这些更改将会丢失。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports MaterialDesignThemes.Wpf
Imports MaterialDesignThemes.Wpf.Converters
Imports MaterialDesignThemes.Wpf.Transitions
Imports System
Imports System.Diagnostics
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Effects
Imports System.Windows.Media.Imaging
Imports System.Windows.Media.Media3D
Imports System.Windows.Media.TextFormatting
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Windows.Shell
Imports Telerik.Windows.Controls
Imports Telerik.Windows.Controls.Animation
Imports Telerik.Windows.Controls.Behaviors
Imports Telerik.Windows.Controls.Carousel
Imports Telerik.Windows.Controls.DragDrop
Imports Telerik.Windows.Controls.LayoutControl
Imports Telerik.Windows.Controls.Legend
Imports Telerik.Windows.Controls.Primitives
Imports Telerik.Windows.Controls.RadialMenu
Imports Telerik.Windows.Controls.TransitionEffects
Imports Telerik.Windows.Controls.TreeView
Imports Telerik.Windows.Controls.Wizard
Imports Telerik.Windows.Data
Imports Telerik.Windows.DragDrop
Imports Telerik.Windows.DragDrop.Behaviors
Imports Telerik.Windows.Input.Touch
Imports Telerik.Windows.Shapes
Imports TelerikWpfApp1


'''<summary>
'''CameraView
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class CameraView
    Inherits System.Windows.Controls.UserControl
    Implements System.Windows.Markup.IComponentConnector
    
    
    #ExternalSource("..\..\..\..\View\CameraView.xaml",10)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents Canvas1 As System.Windows.Controls.Canvas
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\View\CameraView.xaml",11)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents Grid1 As System.Windows.Controls.Grid
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\View\CameraView.xaml",21)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents webCam As Telerik.Windows.Controls.RadWebCam
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\View\CameraView.xaml",30)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents CameraSettingsControl As Telerik.Windows.Controls.CameraSettingsControl
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\View\CameraView.xaml",31)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents InkCanvas1 As System.Windows.Controls.InkCanvas
    
    #End ExternalSource
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")>  _
    Public Sub InitializeComponent() Implements System.Windows.Markup.IComponentConnector.InitializeComponent
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        Dim resourceLocater As System.Uri = New System.Uri("/TelerikWpfApp1;component/view/cameraview.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\..\..\View\CameraView.xaml",1)
        System.Windows.Application.LoadComponent(Me, resourceLocater)
        
        #End ExternalSource
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")>  _
    Sub System_Windows_Markup_IComponentConnector_Connect(ByVal connectionId As Integer, ByVal target As Object) Implements System.Windows.Markup.IComponentConnector.Connect
        If (connectionId = 1) Then
            Me.Canvas1 = CType(target,System.Windows.Controls.Canvas)
            Return
        End If
        If (connectionId = 2) Then
            Me.Grid1 = CType(target,System.Windows.Controls.Grid)
            Return
        End If
        If (connectionId = 3) Then
            Me.webCam = CType(target,Telerik.Windows.Controls.RadWebCam)
            Return
        End If
        If (connectionId = 4) Then
            Me.CameraSettingsControl = CType(target,Telerik.Windows.Controls.CameraSettingsControl)
            Return
        End If
        If (connectionId = 5) Then
            Me.InkCanvas1 = CType(target,System.Windows.Controls.InkCanvas)
            Return
        End If
        Me._contentLoaded = true
    End Sub
End Class
