﻿#pragma checksum "C:\Users\yusuke kawano\Desktop\VastariCsharpcode-master\Team4\PhoneApp2\Registration.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "48E370582CA9079018548C21A12A9894"
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
    
    
    public partial class Registration : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox UsrName;
        
        internal System.Windows.Controls.TextBox Email;
        
        internal System.Windows.Controls.TextBox ConEmail;
        
        internal System.Windows.Controls.TextBox Pswd;
        
        internal System.Windows.Controls.TextBox ConPswd;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/PhoneApp2;component/Registration.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.UsrName = ((System.Windows.Controls.TextBox)(this.FindName("UsrName")));
            this.Email = ((System.Windows.Controls.TextBox)(this.FindName("Email")));
            this.ConEmail = ((System.Windows.Controls.TextBox)(this.FindName("ConEmail")));
            this.Pswd = ((System.Windows.Controls.TextBox)(this.FindName("Pswd")));
            this.ConPswd = ((System.Windows.Controls.TextBox)(this.FindName("ConPswd")));
        }
    }
}

