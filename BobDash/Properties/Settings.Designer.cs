﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BobDash.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.5.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://frcvision.local:1181/?action=stream")]
        public string Camera1Uri {
            get {
                return ((string)(this["Camera1Uri"]));
            }
            set {
                this["Camera1Uri"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://frcvision.local:1182/?action=stream")]
        public string Camera2Uri {
            get {
                return ((string)(this["Camera2Uri"]));
            }
            set {
                this["Camera2Uri"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10.0.85.2")]
        public string NetworkTablesServer {
            get {
                return ((string)(this["NetworkTablesServer"]));
            }
            set {
                this["NetworkTablesServer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://frcvision.local:1183/?action=stream")]
        public string DriverAssistCameraUri {
            get {
                return ((string)(this["DriverAssistCameraUri"]));
            }
            set {
                this["DriverAssistCameraUri"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UpgradeRequired {
            get {
                return ((bool)(this["UpgradeRequired"]));
            }
            set {
                this["UpgradeRequired"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DesiredPivotPosition")]
        public string DesiredPivotPositionVariableName {
            get {
                return ((string)(this["DesiredPivotPositionVariableName"]));
            }
            set {
                this["DesiredPivotPositionVariableName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DesiredExtendPosition")]
        public string DesiredExtendPositionVariableName {
            get {
                return ((string)(this["DesiredExtendPositionVariableName"]));
            }
            set {
                this["DesiredExtendPositionVariableName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DesiredWristPosition")]
        public string DesiredWristPositionVariableName {
            get {
                return ((string)(this["DesiredWristPositionVariableName"]));
            }
            set {
                this["DesiredWristPositionVariableName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Extendo pivot position")]
        public string CurrentPivotPositionVariableName {
            get {
                return ((string)(this["CurrentPivotPositionVariableName"]));
            }
            set {
                this["CurrentPivotPositionVariableName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Extendo extend position")]
        public string CurrentExtendPositionVariableName {
            get {
                return ((string)(this["CurrentExtendPositionVariableName"]));
            }
            set {
                this["CurrentExtendPositionVariableName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Intake wrist position")]
        public string CurrentWristPositionVariableName {
            get {
                return ((string)(this["CurrentWristPositionVariableName"]));
            }
            set {
                this["CurrentWristPositionVariableName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <string>None</string>
  <string>Manual OnePlace</string>
  <string>Balance</string>
  <string>Score and Engage</string>
  <string>Manual Mobility</string>
  <string>CS</string>
  <string>Normal Follow</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection AutoModes {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["AutoModes"]));
            }
            set {
                this["AutoModes"] = value;
            }
        }
    }
}
