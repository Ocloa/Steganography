﻿#pragma checksum "..\..\..\..\MVVM\View\ExtractTextView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "067804B0DF72145069C7EBEB395EF9278120EBAE71300DB510F90793E00C141B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Steganography.MVVM.View;
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


namespace Steganography.MVVM.View {
    
    
    /// <summary>
    /// ExtractTextView
    /// </summary>
    public partial class ExtractTextView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\MVVM\View\ExtractTextView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image pictureBoxStega;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\MVVM\View\ExtractTextView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox decodedText;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\MVVM\View\ExtractTextView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton lsb1;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\MVVM\View\ExtractTextView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton lsb2;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\MVVM\View\ExtractTextView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton lsb3;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\MVVM\View\ExtractTextView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton lsb4;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\MVVM\View\ExtractTextView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox stegabox;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\MVVM\View\ExtractTextView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button openButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Steganography;component/mvvm/view/extracttextview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MVVM\View\ExtractTextView.xaml"
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
            this.pictureBoxStega = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.decodedText = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\..\..\MVVM\View\ExtractTextView.xaml"
            this.decodedText.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textToEmbed_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lsb1 = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.lsb2 = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.lsb3 = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.lsb4 = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            
            #line 28 "..\..\..\..\MVVM\View\ExtractTextView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 8:
            this.stegabox = ((System.Windows.Controls.TextBox)(target));
            
            #line 43 "..\..\..\..\MVVM\View\ExtractTextView.xaml"
            this.stegabox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.stegabox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.openButton = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\..\MVVM\View\ExtractTextView.xaml"
            this.openButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

