﻿#ExternalChecksum("..\..\..\..\ToolsMenu\CameraConfigurator.xaml","{8829d00f-11b8-4213-878b-770e8597ac16}","7B5604E6F6E4FA3D806C348B530EB0ECC067CA126F6DC6DAE07F99051245D6A4")
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

Namespace TelerikWpfApp1.Camset
    
    '''<summary>
    '''SettingMenu
    '''</summary>
    <Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
    Partial Public Class SettingMenu
        Inherits System.Windows.Controls.UserControl
        Implements System.Windows.Markup.IComponentConnector
        
        
        #ExternalSource("..\..\..\..\ToolsMenu\CameraConfigurator.xaml",15)
        <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
        Friend WithEvents startCameraButton As System.Windows.Controls.Button
        
        #End ExternalSource
        
        
        #ExternalSource("..\..\..\..\ToolsMenu\CameraConfigurator.xaml",22)
        <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
        Friend WithEvents stopCameraButton As System.Windows.Controls.Button
        
        #End ExternalSource
        
        
        #ExternalSource("..\..\..\..\ToolsMenu\CameraConfigurator.xaml",31)
        <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
        Friend WithEvents cameraDevicesComboBox As System.Windows.Controls.ComboBox
        
        #End ExternalSource
        
        
        #ExternalSource("..\..\..\..\ToolsMenu\CameraConfigurator.xaml",40)
        <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
        Friend WithEvents videoFormatsComboBox As System.Windows.Controls.ComboBox
        
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
            Dim resourceLocater As System.Uri = New System.Uri("/TelerikWpfApp1;component/toolsmenu/cameraconfigurator.xaml", System.UriKind.Relative)
            
            #ExternalSource("..\..\..\..\ToolsMenu\CameraConfigurator.xaml",1)
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
                Me.startCameraButton = CType(target,System.Windows.Controls.Button)
                
                #ExternalSource("..\..\..\..\ToolsMenu\CameraConfigurator.xaml",20)
                AddHandler Me.startCameraButton.Click, New System.Windows.RoutedEventHandler(AddressOf Me.OnStartCameraClick)
                
                #End ExternalSource
                Return
            End If
            If (connectionId = 2) Then
                Me.stopCameraButton = CType(target,System.Windows.Controls.Button)
                
                #ExternalSource("..\..\..\..\ToolsMenu\CameraConfigurator.xaml",26)
                AddHandler Me.stopCameraButton.Click, New System.Windows.RoutedEventHandler(AddressOf Me.OnStopCameraClick)
                
                #End ExternalSource
                Return
            End If
            If (connectionId = 3) Then
                Me.cameraDevicesComboBox = CType(target,System.Windows.Controls.ComboBox)
                
                #ExternalSource("..\..\..\..\ToolsMenu\CameraConfigurator.xaml",34)
                AddHandler Me.cameraDevicesComboBox.SelectionChanged, New System.Windows.Controls.SelectionChangedEventHandler(AddressOf Me.OnCameraDevicesComboBoxSelectionChanged)
                
                #End ExternalSource
                Return
            End If
            If (connectionId = 4) Then
                Me.videoFormatsComboBox = CType(target,System.Windows.Controls.ComboBox)
                
                #ExternalSource("..\..\..\..\ToolsMenu\CameraConfigurator.xaml",42)
                AddHandler Me.videoFormatsComboBox.SelectionChanged, New System.Windows.Controls.SelectionChangedEventHandler(AddressOf Me.OnVideoFormatComboBoxSelectionChanged)
                
                #End ExternalSource
                Return
            End If
            Me._contentLoaded = true
        End Sub
    End Class
End Namespace
