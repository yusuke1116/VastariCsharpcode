﻿#pragma checksum "C:\Users\yusuke kawano\Desktop\Team4\PhoneApp2\UploadPhoto.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8E516C5E1634C45E655871F7D1215727"
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
    
    
    public partial class Page3 : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal Microsoft.Phone.Controls.ListPicker Category;
        
        internal Microsoft.Phone.Controls.ListPicker Sub;
        
        internal System.Windows.Controls.TextBox Title;
        
        internal System.Windows.Controls.TextBox Title_Copy;
        
        internal Microsoft.Phone.Controls.ListPicker Artist;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/PhoneApp2;component/UploadPhoto.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.Category = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("Category")));
            this.Sub = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("Sub")));
            this.Title = ((System.Windows.Controls.TextBox)(this.FindName("Title")));
            this.Title_Copy = ((System.Windows.Controls.TextBox)(this.FindName("Title_Copy")));
            this.Artist = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("Artist")));
        }
    }
}
