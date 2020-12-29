﻿using System;
using System.Windows.Forms;

namespace EspionSpotify.Extensions
{
    public static class ControlExtensions
    {
        public static TResult GetPropertyThreadSafe<TControl, TResult>(this TControl control, Func<TControl, TResult> getter)
            where TControl : Control
        {
            if (control.IsInvokeRequired())
            {
                return (TResult)control.Invoke(getter, control);
            }
            else
            {
                return getter(control);
            }
        }

        public static void SetPropertyThreadSafe<TControl>(this TControl control, MethodInvoker setter)
           where TControl : Control
        {
            lock (control)
            {
                if (control.IsInvokeRequired())
                {
                    control.Invoke(setter);
                }
                else
                {
                    setter();
                }
            }
        }

        public static bool IsInvokeRequired<TControl>(this TControl control)
            where TControl : Control
        {
            return !control.IsDisposed && control.InvokeRequired;
        }
    }
}