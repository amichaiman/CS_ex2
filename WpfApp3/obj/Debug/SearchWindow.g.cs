﻿#pragma checksum "..\..\SearchWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BE35FE16A57A3EE6AE8B04CF6EF281826A113FA6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfApp3;


namespace WpfApp3 {
    
    
    /// <summary>
    /// SearchWindow
    /// </summary>
    public partial class SearchWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton MovieTitleRadioButton;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MovieTitleTextBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton MovieYearRadioButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MovieStartYearTextBox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MovieEndYearTextBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton MovieDirectorRadioButton;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MovieDirectorTextBox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton MovieActorRadioButton;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MovieActorTextBox;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView SearchResultListView;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp3;component/searchwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SearchWindow.xaml"
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
            this.MovieTitleRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 21 "..\..\SearchWindow.xaml"
            this.MovieTitleRadioButton.Checked += new System.Windows.RoutedEventHandler(this.MovieTitleRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MovieTitleTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.MovieYearRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 25 "..\..\SearchWindow.xaml"
            this.MovieYearRadioButton.Checked += new System.Windows.RoutedEventHandler(this.MovieYearRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MovieStartYearTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.MovieEndYearTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.MovieDirectorRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 31 "..\..\SearchWindow.xaml"
            this.MovieDirectorRadioButton.Checked += new System.Windows.RoutedEventHandler(this.MovieDirectorRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.MovieDirectorTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.MovieActorRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 35 "..\..\SearchWindow.xaml"
            this.MovieActorRadioButton.Checked += new System.Windows.RoutedEventHandler(this.MovieActorRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.MovieActorTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            
            #line 39 "..\..\SearchWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.SearchResultListView = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

