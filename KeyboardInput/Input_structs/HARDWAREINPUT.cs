﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KeyboardInput
{
#pragma warning disable 649
    /// <summary>
    /// Contains information about a simulated message generated by an input device other than a keyboard or mouse. 
    /// </summary>
    struct HARDWAREINPUT
    {
        /// <summary>
        /// The message generated by the input hardware.
        /// </summary>
        public UInt32 uMsg;
        /// <summary>
        /// The low-order word of the lParam parameter for uMsg. 
        /// </summary>
        public UInt16 wParamL;
        /// <summary>
        /// The high-order word of the lParam parameter for uMsg. 
        /// </summary>
        public UInt16 wParamH;
    }
#pragma warning restore 649
}
