﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.3603
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("MyCompany.Customers.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to This will simulate a critical error occurring. {0}An event will be raised to notify VB6 that the application should shut down..
        '''</summary>
        Friend ReadOnly Property CriticalErrMsg() As String
            Get
                Return ResourceManager.GetString("CriticalErrMsg", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Critical Error Event.
        '''</summary>
        Friend ReadOnly Property CriticalErrMsgTitle() As String
            Get
                Return ResourceManager.GetString("CriticalErrMsgTitle", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Customer #{0} Detail (.NET).
        '''</summary>
        Friend ReadOnly Property CustomerDetailsFormText() As String
            Get
                Return ResourceManager.GetString("CustomerDetailsFormText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Not Implemented in Sample Application..
        '''</summary>
        Friend ReadOnly Property NYIMessageText() As String
            Get
                Return ResourceManager.GetString("NYIMessageText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Sample error code..
        '''</summary>
        Friend ReadOnly Property SampleErrorCode() As String
            Get
                Return ResourceManager.GetString("SampleErrorCode", resourceCulture)
            End Get
        End Property
        
        Friend ReadOnly Property users() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("users", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
    End Module
End Namespace
