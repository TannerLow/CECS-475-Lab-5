<<<<<<< HEAD
﻿#pragma checksum "..\..\..\Views\App.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E2B5C70C87618A057A5C4169260510493D51DD50E3C5DEED543375D14DFE4CDE"
=======
﻿#pragma checksum "..\..\..\Views\App.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CB3DF9024834C7CD56D3264733C98D46289F47FB3819C8DC71311F67B71EE5AA"
>>>>>>> master
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
<<<<<<< HEAD
using lab5;
=======
>>>>>>> master
using lab5.ViewModel;


namespace lab5 {
    
    
    /// <summary>
    /// App
    /// </summary>
    public partial class App : System.Windows.Application {
        
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
            
            #line 3 "..\..\..\Views\App.xaml"
<<<<<<< HEAD
            this.StartupUri = new System.Uri("View/MainWindow.xaml", System.UriKind.Relative);
=======
            this.StartupUri = new System.Uri("MainWindow.xaml", System.UriKind.Relative);
>>>>>>> master
            
            #line default
            #line hidden
            System.Uri resourceLocater = new System.Uri("/lab5;component/views/app.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\App.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        /// <summary>
        /// Application Entry Point.
        /// </summary>
        [System.STAThreadAttribute()]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public static void Main() {
            lab5.App app = new lab5.App();
            app.InitializeComponent();
            app.Run();
        }
    }
}

