// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_EDGEDETECTION_MODE")]
    public enum EdgedetectionMode : int
    {
        [NativeName("Name", "D2D1_EDGEDETECTION_MODE_SOBEL")]
        Sobel = 0x0,
        [NativeName("Name", "D2D1_EDGEDETECTION_MODE_PREWITT")]
        Prewitt = 0x1,
        [NativeName("Name", "D2D1_EDGEDETECTION_MODE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
