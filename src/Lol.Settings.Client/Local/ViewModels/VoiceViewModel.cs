﻿using System.Collections.Generic;
using System.Windows.Forms;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Mvvm;
using Lol.Data.Codes;
using Lol.Data.Config;
using Lol.Data.Setting.Clients;
using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using Lol.Devices.Audio;
using Lol.Foundation.Riotbase;

namespace Lol.Settings.Client.Local.ViewModels
{
    public partial class VoiceViewModel : ObservableBase
    {
        [ObservableProperty]
        private List<AudioDevice> _deviceList;
        [ObservableProperty]
        private List<UsualCodes> _inputMode;
        [ObservableProperty]
        private string _selectInputMode;
        public VoiceModel Model { get; set; }

        public VoiceViewModel()
        {
            DeviceList = new AudioDeviceInfo().GetDevices();
            InputMode = new CodesApi().GetCodes("000001");

            ConfigModel config = RiotConfig.LoadConfig();
            Model = config.Settings.Voice;
        }

        [RelayCommand]
        private void ChangeVoiceMode(UsualCodes codes)
        {
            SelectInputMode = Model.InputMode = codes.ItemName;
        }
    }
}
