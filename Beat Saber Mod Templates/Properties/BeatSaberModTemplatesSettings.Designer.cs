﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BeatSaberModTemplates.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.3.0.0")]
    internal sealed partial class BeatSaberModTemplatesSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static BeatSaberModTemplatesSettings defaultInstance = ((BeatSaberModTemplatesSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new BeatSaberModTemplatesSettings())));
        
        public static BeatSaberModTemplatesSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ChosenInstallPath {
            get {
                return ((string)(this["ChosenInstallPath"]));
            }
            set {
                this["ChosenInstallPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool GenerateUserFileWithTemplate {
            get {
                return ((bool)(this["GenerateUserFileWithTemplate"]));
            }
            set {
                this["GenerateUserFileWithTemplate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool GenerateUserFileOnExisting {
            get {
                return ((bool)(this["GenerateUserFileOnExisting"]));
            }
            set {
                this["GenerateUserFileOnExisting"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SetManifestJsonDefaults {
            get {
                return ((bool)(this["SetManifestJsonDefaults"]));
            }
            set {
                this["SetManifestJsonDefaults"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CopyToIPAPendingOnBuild {
            get {
                return ((bool)(this["CopyToIPAPendingOnBuild"]));
            }
            set {
                this["CopyToIPAPendingOnBuild"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public byte BuildReferenceType {
            get {
                return ((byte)(this["BuildReferenceType"]));
            }
            set {
                this["BuildReferenceType"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Manifest_Author {
            get {
                return ((string)(this["Manifest_Author"]));
            }
            set {
                this["Manifest_Author"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Manifest_Donation {
            get {
                return ((string)(this["Manifest_Donation"]));
            }
            set {
                this["Manifest_Donation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Manifest_AuthorEnabled {
            get {
                return ((bool)(this["Manifest_AuthorEnabled"]));
            }
            set {
                this["Manifest_AuthorEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Manifest_DonationEnabled {
            get {
                return ((bool)(this["Manifest_DonationEnabled"]));
            }
            set {
                this["Manifest_DonationEnabled"] = value;
            }
        }
    }
}
