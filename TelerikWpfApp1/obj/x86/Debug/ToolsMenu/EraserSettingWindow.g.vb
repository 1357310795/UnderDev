﻿#ExternalChecksum("..\..\..\..\ToolsMenu\EraserSettingWindow.xaml","{8829d00f-11b8-4213-878b-770e8597ac16}","CFF1F43CBF97832482EECA457771118D0C2051E7EE61BEE832C2608890B4E3EA")
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
Imports TelerikWpfApp1


'''<summary>
'''EraserSettingWindow
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class EraserSettingWindow
    Inherits System.Windows.Window
    Implements System.Windows.Markup.IComponentConnector
    
    
    #ExternalSource("..\..\..\..\ToolsMenu\EraserSettingWindow.xaml",26)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents MyScaleTransform1 As System.Windows.Media.ScaleTransform
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\ToolsMenu\EraserSettingWindow.xaml",42)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents MyScaleTransform2 As System.Windows.Media.ScaleTransform
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\ToolsMenu\EraserSettingWindow.xaml",65)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents MyScaleTransform3 As System.Windows.Media.ScaleTransform
    
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
        Dim resourceLocater As System.Uri = New System.Uri("/TelerikWpfApp1;component/toolsmenu/erasersettingwindow.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\..\..\ToolsMenu\EraserSettingWindow.xaml",1)
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
            
            #ExternalSource("..\..\..\..\ToolsMenu\EraserSettingWindow.xaml",8)
            AddHandler CType(target,EraserSettingWindow).Deactivated, New System.EventHandler(AddressOf Me.Window_LostFocus)
            
            #End ExternalSource
            
            #ExternalSource("..\..\..\..\ToolsMenu\EraserSettingWindow.xaml",9)
            AddHandler CType(target,EraserSettingWindow).Loaded, New System.Windows.RoutedEventHandler(AddressOf Me.Window_Loaded)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 2) Then
            Me.MyScaleTransform1 = CType(target,System.Windows.Media.ScaleTransform)
            Return
        End If
        If (connectionId = 3) Then
            Me.MyScaleTransform2 = CType(target,System.Windows.Media.ScaleTransform)
            Return
        End If
        If (connectionId = 4) Then
            
            #ExternalSource("..\..\..\..\ToolsMenu\EraserSettingWindow.xaml",53)
            AddHandler CType(target,System.Windows.Controls.Button).Click, New System.Windows.RoutedEventHandler(AddressOf Me.Button_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 5) Then
            
            #ExternalSource("..\..\..\..\ToolsMenu\EraserSettingWindow.xaml",58)
            AddHandler CType(target,System.Windows.Controls.Button).Click, New System.Windows.RoutedEventHandler(AddressOf Me.Button_Click_1)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 6) Then
            Me.MyScaleTransform3 = CType(target,System.Windows.Media.ScaleTransform)
            Return
        End If
        If (connectionId = 7) Then
            
            #ExternalSource("..\..\..\..\ToolsMenu\EraserSettingWindow.xaml",70)
            AddHandler CType(target,System.Windows.Controls.Button).Click, New System.Windows.RoutedEventHandler(AddressOf Me.Button_Click_2)
            
            #End ExternalSource
            Return
        End If
        Me._contentLoaded = true
    End Sub
End Class

