﻿#pragma checksum "..\..\ProgWin.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6888B5AB1E05AD759FEE9D3C5842862A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4200
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


namespace Spinach {
    
    
    /// <summary>
    /// ProgWin
    /// </summary>
    public partial class ProgWin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\ProgWin.xaml"
        internal System.Windows.Controls.Grid DocumentRoot;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\ProgWin.xaml"
        internal System.Windows.Controls.Menu mnu;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ProgWin.xaml"
        internal System.Windows.Controls.MenuItem File;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\ProgWin.xaml"
        internal System.Windows.Controls.MenuItem mnuSave;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\ProgWin.xaml"
        internal System.Windows.Controls.MenuItem mnuExit;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\ProgWin.xaml"
        internal System.Windows.Controls.MenuItem mnuAccess;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\ProgWin.xaml"
        internal System.Windows.Controls.MenuItem mnuAdd;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\ProgWin.xaml"
        internal System.Windows.Controls.MenuItem mnuEdit;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\ProgWin.xaml"
        internal System.Windows.Controls.MenuItem mnuDelete;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\ProgWin.xaml"
        internal System.Windows.Controls.MenuItem Option;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\ProgWin.xaml"
        internal System.Windows.Controls.MenuItem mnuLine;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\ProgWin.xaml"
        internal System.Windows.Controls.MenuItem mnuWrap;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\ProgWin.xaml"
        internal System.Windows.Controls.MenuItem mnuHighlight;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\ProgWin.xaml"
        internal System.Windows.Controls.MenuItem mnuPlot;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\ProgWin.xaml"
        internal System.Windows.Controls.MenuItem mnuShowPlot;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\ProgWin.xaml"
        internal System.Windows.Controls.MenuItem mnuSavePlot;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\ProgWin.xaml"
        internal System.Windows.Controls.RichTextBox rtbInput;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\ProgWin.xaml"
        internal System.Windows.Controls.Label lblInput;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\ProgWin.xaml"
        internal System.Windows.Controls.Label lblResult;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\ProgWin.xaml"
        internal System.Windows.Controls.Button btnCompute;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\ProgWin.xaml"
        internal System.Windows.Controls.RichTextBox rtbResult;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\ProgWin.xaml"
        internal System.Windows.Controls.ListBox lstUsers;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\ProgWin.xaml"
        internal System.Windows.Controls.Label lblUsers;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\ProgWin.xaml"
        internal System.Windows.Controls.Label lblProgName;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\ProgWin.xaml"
        internal System.Windows.Controls.Label lblOwner;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\ProgWin.xaml"
        internal System.Windows.Controls.ListBox lstLine;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Spinach;component/progwin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ProgWin.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 4 "..\..\ProgWin.xaml"
            ((Spinach.ProgWin)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DocumentRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.mnu = ((System.Windows.Controls.Menu)(target));
            return;
            case 4:
            this.File = ((System.Windows.Controls.MenuItem)(target));
            
            #line 20 "..\..\ProgWin.xaml"
            this.File.Click += new System.Windows.RoutedEventHandler(this.mnuFile_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.mnuSave = ((System.Windows.Controls.MenuItem)(target));
            
            #line 21 "..\..\ProgWin.xaml"
            this.mnuSave.Click += new System.Windows.RoutedEventHandler(this.mnuSave_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.mnuExit = ((System.Windows.Controls.MenuItem)(target));
            
            #line 22 "..\..\ProgWin.xaml"
            this.mnuExit.Click += new System.Windows.RoutedEventHandler(this.mnuExit_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.mnuAccess = ((System.Windows.Controls.MenuItem)(target));
            
            #line 24 "..\..\ProgWin.xaml"
            this.mnuAccess.Click += new System.Windows.RoutedEventHandler(this.mnuAccess_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.mnuAdd = ((System.Windows.Controls.MenuItem)(target));
            
            #line 25 "..\..\ProgWin.xaml"
            this.mnuAdd.Click += new System.Windows.RoutedEventHandler(this.mnuAdd_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.mnuEdit = ((System.Windows.Controls.MenuItem)(target));
            
            #line 26 "..\..\ProgWin.xaml"
            this.mnuEdit.Click += new System.Windows.RoutedEventHandler(this.mnuEdit_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.mnuDelete = ((System.Windows.Controls.MenuItem)(target));
            
            #line 27 "..\..\ProgWin.xaml"
            this.mnuDelete.Click += new System.Windows.RoutedEventHandler(this.mnuDelete_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Option = ((System.Windows.Controls.MenuItem)(target));
            
            #line 29 "..\..\ProgWin.xaml"
            this.Option.Click += new System.Windows.RoutedEventHandler(this.mnuOption_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.mnuLine = ((System.Windows.Controls.MenuItem)(target));
            
            #line 30 "..\..\ProgWin.xaml"
            this.mnuLine.Click += new System.Windows.RoutedEventHandler(this.mnuLine_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.mnuWrap = ((System.Windows.Controls.MenuItem)(target));
            
            #line 31 "..\..\ProgWin.xaml"
            this.mnuWrap.Click += new System.Windows.RoutedEventHandler(this.mnuWrap_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.mnuHighlight = ((System.Windows.Controls.MenuItem)(target));
            
            #line 32 "..\..\ProgWin.xaml"
            this.mnuHighlight.Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.mnuPlot = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 16:
            this.mnuShowPlot = ((System.Windows.Controls.MenuItem)(target));
            
            #line 35 "..\..\ProgWin.xaml"
            this.mnuShowPlot.Click += new System.Windows.RoutedEventHandler(this.mnuShowPlot_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.mnuSavePlot = ((System.Windows.Controls.MenuItem)(target));
            
            #line 36 "..\..\ProgWin.xaml"
            this.mnuSavePlot.Click += new System.Windows.RoutedEventHandler(this.mnuSavePlot_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            this.rtbInput = ((System.Windows.Controls.RichTextBox)(target));
            
            #line 39 "..\..\ProgWin.xaml"
            this.rtbInput.KeyUp += new System.Windows.Input.KeyEventHandler(this.rtbInput_KeyUp);
            
            #line default
            #line hidden
            return;
            case 19:
            this.lblInput = ((System.Windows.Controls.Label)(target));
            return;
            case 20:
            this.lblResult = ((System.Windows.Controls.Label)(target));
            return;
            case 21:
            this.btnCompute = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\ProgWin.xaml"
            this.btnCompute.Click += new System.Windows.RoutedEventHandler(this.btnCompute_Click);
            
            #line default
            #line hidden
            return;
            case 22:
            this.rtbResult = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 23:
            this.lstUsers = ((System.Windows.Controls.ListBox)(target));
            return;
            case 24:
            this.lblUsers = ((System.Windows.Controls.Label)(target));
            return;
            case 25:
            this.lblProgName = ((System.Windows.Controls.Label)(target));
            return;
            case 26:
            this.lblOwner = ((System.Windows.Controls.Label)(target));
            return;
            case 27:
            this.lstLine = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
