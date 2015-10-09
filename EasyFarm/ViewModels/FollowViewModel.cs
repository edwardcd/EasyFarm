﻿using EasyFarm.Classes;
using EasyFarm.Mvvm;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyFarm.ViewModels
{
    [ViewModel("Follow")]
    public class FollowViewModel : BindableBase, IViewModel
    {
        public string ViewName { get; set; }

        public string Name
        {
            get { return Config.Instance.FollowedPlayer; }
            set
            {
                Config.Instance.FollowedPlayer = value;
                AppInformer.InformUser("Now following {0}.", value);
            }
        }

        public double Distance
        {
            get { return Config.Instance.FollowDistance; }
            set
            {
                SetProperty(ref Config.Instance.FollowDistance, value);
                AppInformer.InformUser(string.Format("Follow Distance: {0}.", value));
            }
        }
    }
}
