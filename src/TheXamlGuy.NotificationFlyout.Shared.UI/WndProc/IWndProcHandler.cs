﻿using System;

namespace TheXamlGuy.NotificationFlyout.Shared.UI.Helpers
{
    public interface IWndProcHandler
    {
        void Handle(uint message, IntPtr wParam, IntPtr lParam);
    }
}