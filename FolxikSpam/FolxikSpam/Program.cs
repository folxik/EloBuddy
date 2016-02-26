using System;
using EloBuddy;
using EloBuddy.SDK.Events;
using EloBuddy.SDK.Rendering;
using SharpDX;

namespace FolxikSpam
{
    public static class Program
    {

        static void Main(string[] args)
        {
            Loading.OnLoadingComplete += OnLoadingComplete;
        }
        private static void OnLoadingComplete(EventArgs args)
        {
            Config.Initialize(); 
            
            Chat.Print("<font color='#660033'>FolxikSpam Loaded!</font><font color='#33FF00'>Have fun!");
            Chat.Print("<font color='##FF9900'>Addon working on patch</font><font color='#EBC79E'>6.4.0.250!");
            Drawing.OnDraw += OnDraw;
        }
        private static void OnDraw(EventArgs args)
        {
        }
    }
}
