﻿#pragma checksum "..\..\ProgConf.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "927BB43E88EE1703276EBE5A4A15D62C"
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
    /// ProgConf
    /// </summary>
    public partial class ProgConf : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 4 "..\..\ProgConf.xaml"
        internal Spinach.ProgConf frmProgConf;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\ProgConf.xaml"
        internal System.Windows.Controls.Menu mnuProg;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\ProgConf.xaml"
        internal System.Windows.Controls.MenuItem mnuFile;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\ProgConf.xaml"
        internal System.Windows.Controls.MenuItem submnuNew;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\ProgConf.xaml"
        internal System.Windows.Controls.MenuItem submnuLoad;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\ProgConf.xaml"
        internal System.Windows.Controls.MenuItem submnuDisconnect;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\ProgConf.xaml"
        internal System.Windows.Controls.MenuItem submnuExit;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\ProgConf.xaml"
        internal System.Windows.Controls.MenuItem mnuHelp;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ProgConf.xaml"
        internal System.Windows.Controls.ListBox lstUserList;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\ProgConf.xaml"
        internal System.Windows.Controls.Label lblSwarmList;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\ProgConf.xaml"
        internal System.Windows.Controls.RichTextBox rtbChat;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\ProgConf.xaml"
        internal System.Windows.Controls.TextBox txtMessage;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\ProgConf.xaml"
        internal System.Windows.Controls.Button cmdSend;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\ProgConf.xaml"
        internal System.Windows.Controls.Image image1;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\ProgConf.xaml"
        internal System.Windows.Controls.Label lblChat;
        
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
            System.Uri resourceLocater = new System.Uri("/Spinach;component/progconf.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ProgConf.xaml"
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
            this.frmProgConf = ((Spinach.ProgConf)(target));
            
            #line 4 "..\..\ProgConf.xaml"
            this.frmProgConf.Loaded += new System.Windows.RoutedEventHandler(this.frmProgConf_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.mnuProg = ((System.Windows.Controls.Menu)(target));
            return;
            case 3:
            this.mnuFile = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 4:
            this.submnuNew = ((System.Windows.Controls.MenuItem)(target));
            
            #line 12 "..\..\ProgConf.xaml"
            this.submnuNew.Click += new System.Windows.RoutedEventHandler(this.submnuNew_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.submnuLoad = ((System.Windows.Controls.MenuItem)(target));
            
            #line 13 "..\..\ProgConf.xaml"
            this.submnuLoad.Click += new System.Windows.RoutedEventHandler(this.submnuLoad_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.submnuDisconnect = ((System.Windows.Controls.MenuItem)(target));
            
            #line 15 "..\..\ProgConf.xaml"
            this.submnuDisconnect.Click += new System.Windows.RoutedEventHandler(this.submnuDisconnect_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.submnuExit = ((System.Windows.Controls.MenuItem)(target));
            
            #line 16 "..\..\ProgConf.xaml"
            this.submnuExit.Click += new System.Windows.RoutedEventHandler(this.submnuExit_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.mnuHelp = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 9:
            this.lstUserList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 10:
            this.lblSwarmList = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.rtbChat = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 12:
            this.txtMessage = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.cmdSend = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\ProgConf.xaml"
            this.cmdSend.Click += new System.Windows.RoutedEventHandler(this.cmdSend_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.image1 = ((System.Windows.Controls.Image)(target));
            return;
            case 15:
            this.lblChat = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
