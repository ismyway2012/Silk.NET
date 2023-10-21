// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs;

public unsafe static class WICProgressiveLevelControlVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICProgressiveLevelControl> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICProgressiveLevelControl*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICProgressiveLevelControl> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICProgressiveLevelControl*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICProgressiveLevelControl> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICProgressiveLevelControl*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICProgressiveLevelControl> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICProgressiveLevelControl*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IWICProgressiveLevelControl> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICProgressiveLevelControl*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IWICProgressiveLevelControl> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICProgressiveLevelControl*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLevelCount(this ComPtr<IWICProgressiveLevelControl> thisVtbl, uint* pcLevels)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICProgressiveLevelControl*, uint*, int>)@this->LpVtbl[3])(@this, pcLevels);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetLevelCount(this ComPtr<IWICProgressiveLevelControl> thisVtbl, ref uint pcLevels)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcLevelsPtr = &pcLevels)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICProgressiveLevelControl*, uint*, int>)@this->LpVtbl[3])(@this, pcLevelsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentLevel(this ComPtr<IWICProgressiveLevelControl> thisVtbl, uint* pnLevel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICProgressiveLevelControl*, uint*, int>)@this->LpVtbl[4])(@this, pnLevel);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCurrentLevel(this ComPtr<IWICProgressiveLevelControl> thisVtbl, ref uint pnLevel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pnLevelPtr = &pnLevel)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICProgressiveLevelControl*, uint*, int>)@this->LpVtbl[4])(@this, pnLevelPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetCurrentLevel(this ComPtr<IWICProgressiveLevelControl> thisVtbl, uint nLevel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICProgressiveLevelControl*, uint, int>)@this->LpVtbl[5])(@this, nLevel);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IWICProgressiveLevelControl> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICProgressiveLevelControl> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICProgressiveLevelControl> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetLevelCount(this ComPtr<IWICProgressiveLevelControl> thisVtbl, Span<uint> pcLevels)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLevelCount(ref pcLevels.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetCurrentLevel(this ComPtr<IWICProgressiveLevelControl> thisVtbl, Span<uint> pnLevel)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCurrentLevel(ref pnLevel.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IWICProgressiveLevelControl> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}