﻿using BeatSaberModTemplates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeatSaberModTemplates.ViewModels
{
    public class SettingsViewModel : ViewModelBase
    {
        public SettingsViewModel()
        {
            CurrentSettings = new SettingsModel(PreviousSettings);
        }

        private ReadOnlySettingsModel PreviousSettings => BSMTSettingsManager.CurrentSettings;
        private SettingsModel _currentSettings;

        public SettingsModel CurrentSettings
        {
            get { return _currentSettings; }
            set
            {
                if (_currentSettings?.Equals(value) ?? value == null)
                    return;
                _currentSettings = value;
                NotifyPropertyChanged();
            }
        }

        #region Settings Properties
        public bool ChosenInstallPathChanged { get; private set; }
        public string ChosenInstallPath
        {
            get { return CurrentSettings?.ChosenInstallPath ?? PreviousSettings.ChosenInstallPath; }
            set
            {
                if (CurrentSettings?.ChosenInstallPath == value)
                    return;
                CurrentSettings.ChosenInstallPath = value;
                NotifyPropertyChanged();
                if ((CurrentSettings.ChosenInstallPath == PreviousSettings.ChosenInstallPath) != ChosenInstallPathChanged)
                {
                    ChosenInstallPathChanged = !ChosenInstallPathChanged;
                    NotifyPropertyChanged(nameof(ChosenInstallPathChanged));
                }
            }
        }

        public bool GenerateUserFileWithTemplateChanged { get; private set; }
        public bool GenerateUserFileWithTemplate
        {
            get { return CurrentSettings?.GenerateUserFileWithTemplate ?? PreviousSettings.GenerateUserFileWithTemplate; }
            set
            {
                if (CurrentSettings?.GenerateUserFileWithTemplate == value)
                    return;
                CurrentSettings.GenerateUserFileWithTemplate = value;
                NotifyPropertyChanged();
                if ((CurrentSettings.GenerateUserFileWithTemplate == PreviousSettings.GenerateUserFileWithTemplate) != GenerateUserFileWithTemplateChanged)
                {
                    GenerateUserFileWithTemplateChanged = !GenerateUserFileWithTemplateChanged;
                    NotifyPropertyChanged(nameof(GenerateUserFileWithTemplateChanged));
                }
            }
        }

        public bool GenerateUserFileOnExistingChanged { get; private set; }
        public bool GenerateUserFileOnExisting
        {
            get { return CurrentSettings?.GenerateUserFileOnExisting ?? PreviousSettings.GenerateUserFileOnExisting; }
            set
            {
                if (CurrentSettings?.GenerateUserFileOnExisting == value)
                    return;
                CurrentSettings.GenerateUserFileOnExisting = value;
                NotifyPropertyChanged();
                if ((CurrentSettings.GenerateUserFileOnExisting == PreviousSettings.GenerateUserFileOnExisting) != GenerateUserFileOnExistingChanged)
                {
                    GenerateUserFileOnExistingChanged = !GenerateUserFileOnExistingChanged;
                    NotifyPropertyChanged(nameof(GenerateUserFileOnExistingChanged));
                }
            }
        }

        public bool SetManifestJsonDefaultsChanged { get; private set; }
        public bool SetManifestJsonDefaults
        {
            get { return CurrentSettings?.SetManifestJsonDefaults ?? PreviousSettings.SetManifestJsonDefaults; }
            set
            {
                if (CurrentSettings?.SetManifestJsonDefaults == value)
                    return;
                CurrentSettings.SetManifestJsonDefaults = value;
                NotifyPropertyChanged();
                if ((CurrentSettings.SetManifestJsonDefaults == PreviousSettings.SetManifestJsonDefaults) != SetManifestJsonDefaultsChanged)
                {
                    SetManifestJsonDefaultsChanged = !SetManifestJsonDefaultsChanged;
                    NotifyPropertyChanged(nameof(SetManifestJsonDefaultsChanged));
                }
            }
        }

        public bool CopyToIPAPendingOnBuildChanged { get; private set; }
        public bool CopyToIPAPendingOnBuild
        {
            get { return CurrentSettings?.CopyToIPAPendingOnBuild ?? PreviousSettings.CopyToIPAPendingOnBuild; }
            set
            {
                if (CurrentSettings?.CopyToIPAPendingOnBuild == value)
                    return;
                CurrentSettings.CopyToIPAPendingOnBuild = value;
                NotifyPropertyChanged();
                if ((CurrentSettings.CopyToIPAPendingOnBuild == PreviousSettings.CopyToIPAPendingOnBuild) != CopyToIPAPendingOnBuildChanged)
                {
                    CopyToIPAPendingOnBuildChanged = !CopyToIPAPendingOnBuildChanged;
                    NotifyPropertyChanged(nameof(CopyToIPAPendingOnBuildChanged));
                }
            }
        }

        public bool BuildReferenceTypeChanged { get; private set; }
        public BuildReferenceType BuildReferenceType
        {
            get { return CurrentSettings?.BuildReferenceType ?? PreviousSettings.BuildReferenceType; }
            set
            {
                if (CurrentSettings?.BuildReferenceType == value)
                    return;
                CurrentSettings.BuildReferenceType = value;
                NotifyPropertyChanged();
                if ((CurrentSettings.BuildReferenceType == PreviousSettings.BuildReferenceType) != BuildReferenceTypeChanged)
                {
                    BuildReferenceTypeChanged = !BuildReferenceTypeChanged;
                    NotifyPropertyChanged(nameof(BuildReferenceTypeChanged));
                }
            }
        }

        public bool Manifest_AuthorChanged { get; private set; }
        public string Manifest_Author
        {
            get { return CurrentSettings?.Manifest_Author ?? PreviousSettings.Manifest_Author; }
            set
            {
                if (CurrentSettings?.Manifest_Author == value)
                    return;
                CurrentSettings.Manifest_Author = value;
                NotifyPropertyChanged();
                if ((CurrentSettings.Manifest_Author == PreviousSettings.Manifest_Author) != Manifest_AuthorChanged)
                {
                    Manifest_AuthorChanged = !Manifest_AuthorChanged;
                    NotifyPropertyChanged(nameof(Manifest_AuthorChanged));
                }
            }
        }

        public bool Manifest_DonationChanged { get; private set; }
        public string Manifest_Donation
        {
            get { return CurrentSettings?.Manifest_Donation ?? PreviousSettings.Manifest_Donation; }
            set
            {
                if (CurrentSettings?.Manifest_Donation == value)
                    return;
                CurrentSettings.Manifest_Donation = value;
                NotifyPropertyChanged();
                if ((CurrentSettings.Manifest_Donation == PreviousSettings.Manifest_Donation) != Manifest_DonationChanged)
                {
                    Manifest_DonationChanged = !Manifest_DonationChanged;
                    NotifyPropertyChanged(nameof(Manifest_DonationChanged));
                }
            }
        }

        public bool Manifest_AuthorEnabledChanged { get; private set; }
        public bool Manifest_AuthorEnabled
        {
            get { return CurrentSettings?.Manifest_AuthorEnabled ?? PreviousSettings.Manifest_AuthorEnabled; }
            set
            {
                if (CurrentSettings?.Manifest_AuthorEnabled == value)
                    return;
                CurrentSettings.Manifest_AuthorEnabled = value;
                NotifyPropertyChanged();
                if ((CurrentSettings.Manifest_AuthorEnabled == PreviousSettings.Manifest_AuthorEnabled) != Manifest_AuthorEnabledChanged)
                {
                    Manifest_AuthorEnabledChanged = !Manifest_AuthorEnabledChanged;
                    NotifyPropertyChanged(nameof(Manifest_AuthorEnabledChanged));
                }
            }
        }

        public bool Manifest_DonationEnabledChanged { get; private set; }
        public bool Manifest_DonationEnabled
        {
            get { return CurrentSettings?.Manifest_DonationEnabled ?? PreviousSettings.Manifest_DonationEnabled; }
            set
            {
                if (CurrentSettings?.Manifest_DonationEnabled == value)
                    return;
                CurrentSettings.Manifest_DonationEnabled = value;
                NotifyPropertyChanged();
                if ((CurrentSettings.Manifest_DonationEnabled == PreviousSettings.Manifest_DonationEnabled) != Manifest_DonationEnabledChanged)
                {
                    Manifest_DonationEnabledChanged = !Manifest_DonationEnabledChanged;
                    NotifyPropertyChanged(nameof(Manifest_DonationEnabledChanged));
                }
            }
        }
        #endregion

    }
}
