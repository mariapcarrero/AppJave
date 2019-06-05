﻿using Xamarin.Forms;

namespace JaverianaCali.Helpers
{
    public class StatusBarHelper
    {
        static readonly StatusBarHelper instance = new StatusBarHelper();
        public const string TranslucentStatusChangeMessage = "TranslucentStatusChange";

        public static StatusBarHelper Instance => instance;

        protected StatusBarHelper()
        {
        }

        public void MakeTranslucentStatusBar(bool translucent) => MessagingCenter.Send(this, TranslucentStatusChangeMessage, translucent);
    }
}
