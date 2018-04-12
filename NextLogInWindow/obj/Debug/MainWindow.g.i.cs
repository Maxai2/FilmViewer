﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C606D67F3B606E1A9623AA2C3A292E351574971D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using NextLogInWindow;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace NextLogInWindow {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 60 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon piList;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon piGrid;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbMoreWatched;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbMoreLook;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/NextLogInWindow;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.piList = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            
            #line 60 "..\..\MainWindow.xaml"
            this.piList.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PackIcon_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.piGrid = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            
            #line 62 "..\..\MainWindow.xaml"
            this.piGrid.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PackIcon_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tbMoreWatched = ((System.Windows.Controls.TextBlock)(target));
            
            #line 66 "..\..\MainWindow.xaml"
            this.tbMoreWatched.MouseEnter += new System.Windows.Input.MouseEventHandler(this.tbMoreWatched_MouseEnter);
            
            #line default
            #line hidden
            
            #line 66 "..\..\MainWindow.xaml"
            this.tbMoreWatched.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.tbMoreWatched_MouseDown);
            
            #line default
            #line hidden
            
            #line 66 "..\..\MainWindow.xaml"
            this.tbMoreWatched.MouseLeave += new System.Windows.Input.MouseEventHandler(this.tbMoreWatched_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbMoreLook = ((System.Windows.Controls.TextBlock)(target));
            
            #line 82 "..\..\MainWindow.xaml"
            this.tbMoreLook.MouseEnter += new System.Windows.Input.MouseEventHandler(this.tbMoreLook_MouseEnter);
            
            #line default
            #line hidden
            
            #line 82 "..\..\MainWindow.xaml"
            this.tbMoreLook.MouseLeave += new System.Windows.Input.MouseEventHandler(this.tbMoreLook_MouseLeave);
            
            #line default
            #line hidden
            
            #line 82 "..\..\MainWindow.xaml"
            this.tbMoreLook.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.tbMoreLook_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

