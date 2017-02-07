﻿using GalaSoft.MvvmLight;
using LightBulb.Services.Interfaces;

namespace LightBulb.ViewModels
{
    public sealed class AdvancedSettingsViewModel : ViewModelBase
    {
        public ISettingsService SettingsService { get; }

        public AdvancedSettingsViewModel(ISettingsService settingsService)
        {
            SettingsService = settingsService;
        }
    }
}