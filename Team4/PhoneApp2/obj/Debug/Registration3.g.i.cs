﻿#pragma checksum "C:\Users\yusuke kawano\Desktop\Team3\PhoneApp2\Registration3.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A779E02CC2FF02BF2128DC2B1B678EBE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
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
    
    
    public partial class Registration3 : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.CheckBox Fine_Art;
        
        internal System.Windows.Controls.CheckBox Antiques;
        
        internal System.Windows.Controls.CheckBox Artefacts;
        
        internal System.Windows.Controls.CheckBox Memorabilia;
        
        internal System.Windows.Controls.CheckBox Other;
        
        internal System.Windows.Controls.CheckBox Agree;
        
        internal System.Windows.Controls.HyperlinkButton Term;
        
        internal System.Windows.Controls.HyperlinkButton Privacy;
        
        internal Microsoft.Phone.Controls.ListPicker listPicker;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/PhoneApp2;component/Registration3.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.Fine_Art = ((System.Windows.Controls.CheckBox)(this.FindName("Fine_Art")));
            this.Antiques = ((System.Windows.Controls.CheckBox)(this.FindName("Antiques")));
            this.Artefacts = ((System.Windows.Controls.CheckBox)(this.FindName("Artefacts")));
            this.Memorabilia = ((System.Windows.Controls.CheckBox)(this.FindName("Memorabilia")));
            this.Other = ((System.Windows.Controls.CheckBox)(this.FindName("Other")));
            this.Agree = ((System.Windows.Controls.CheckBox)(this.FindName("Agree")));
            this.Term = ((System.Windows.Controls.HyperlinkButton)(this.FindName("Term")));
            this.Privacy = ((System.Windows.Controls.HyperlinkButton)(this.FindName("Privacy")));
            this.listPicker = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("listPicker")));
        }
    }
}
