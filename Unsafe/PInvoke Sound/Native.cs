﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PInvoke_Sound
{
    public static class Native
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool Beep(int dwFreq, int dwDuration);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MessageBeep(
            [MarshalAs(UnmanagedType.U4)]BeepTypes uType);
    }

    /// <summary>
    /// Enum type that enables intellisense on the private <see cref="Beep"/> method.
    /// </summary>
    /// <remarks>
    /// Used by the public Beep <see cref="Beep"/></remarks>
    public enum BeepTypes : uint
    {
        /// <summary>
        /// A simple windows beep
        /// </summary>            
        SimpleBeep = 0xFFFFFFFF,
        /// <summary>
        /// A standard windows OK beep
        /// </summary>
        OK = 0x00,
        /// <summary>
        /// A standard windows Question beep
        /// </summary>
        Question = 0x20,
        /// <summary>
        /// A standard windows Exclamation beep
        /// </summary>
        Exclamation = 0x30,
        /// <summary>
        /// A standard windows Asterisk beep
        /// </summary>
        Asterisk = 0x40,
    }
}
