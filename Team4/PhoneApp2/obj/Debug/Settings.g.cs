﻿#pragma checksum "C:\Users\yusuke kawano\Desktop\Team4\PhoneApp2\Settings.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7B6452F440F24DFAC1C5CD4A82B2C5A5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace PhoneApp2 {
    
    
    public partial class Settings_ : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBox OldPin;
        
        internal System.Windows.Controls.TextBox NewPin;
        
        internal System.Windows.Controls.TextBox CNewPin;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/PhoneApp2;component/Settings.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.OldPin = ((System.Windows.Controls.TextBox)(this.FindName("OldPin")));
            this.NewPin = ((System.Windows.Controls.TextBox)(this.FindName("NewPin")));
            this.CNewPin = ((System.Windows.Controls.TextBox)(this.FindName("CNewPin")));
        }
    }
}

