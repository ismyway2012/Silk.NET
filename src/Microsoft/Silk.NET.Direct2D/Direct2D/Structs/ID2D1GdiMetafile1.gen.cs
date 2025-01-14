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

namespace Silk.NET.Direct2D
{
    [Guid("2e69f9e8-dd3f-4bf9-95ba-c04f49d788df")]
    [NativeName("Name", "ID2D1GdiMetafile1")]
    public unsafe partial struct ID2D1GdiMetafile1 : IComVtbl<ID2D1GdiMetafile1>, IComVtbl<ID2D1GdiMetafile>, IComVtbl<ID2D1Resource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("2e69f9e8-dd3f-4bf9-95ba-c04f49d788df");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID2D1GdiMetafile(ID2D1GdiMetafile1 val)
            => Unsafe.As<ID2D1GdiMetafile1, ID2D1GdiMetafile>(ref val);

        public static implicit operator ID2D1Resource(ID2D1GdiMetafile1 val)
            => Unsafe.As<ID2D1GdiMetafile1, ID2D1Resource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1GdiMetafile1 val)
            => Unsafe.As<ID2D1GdiMetafile1, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1GdiMetafile1
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (ID2D1GdiMetafile1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1GdiMetafile1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1GdiMetafile1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1GdiMetafile1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1GdiMetafile1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1GdiMetafile1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1GdiMetafile1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ref ID2D1Factory* factory)
        {
            var @this = (ID2D1GdiMetafile1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Factory** factoryPtr = &factory)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factoryPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Stream(ID2D1GdiMetafileSink* sink)
        {
            var @this = (ID2D1GdiMetafile1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, ID2D1GdiMetafileSink*, int>)@this->LpVtbl[4])(@this, sink);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Stream(ref ID2D1GdiMetafileSink sink)
        {
            var @this = (ID2D1GdiMetafile1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1GdiMetafileSink* sinkPtr = &sink)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, ID2D1GdiMetafileSink*, int>)@this->LpVtbl[4])(@this, sinkPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBounds(Silk.NET.Maths.Box2D<float>* bounds)
        {
            var @this = (ID2D1GdiMetafile1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[5])(@this, bounds);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetBounds(ref Silk.NET.Maths.Box2D<float> bounds)
        {
            var @this = (ID2D1GdiMetafile1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* boundsPtr = &bounds)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[5])(@this, boundsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDpi(float* dpiX, float* dpiY)
        {
            var @this = (ID2D1GdiMetafile1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, float*, float*, int>)@this->LpVtbl[6])(@this, dpiX, dpiY);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDpi(float* dpiX, ref float dpiY)
        {
            var @this = (ID2D1GdiMetafile1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* dpiYPtr = &dpiY)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, float*, float*, int>)@this->LpVtbl[6])(@this, dpiX, dpiYPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDpi(ref float dpiX, float* dpiY)
        {
            var @this = (ID2D1GdiMetafile1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* dpiXPtr = &dpiX)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, float*, float*, int>)@this->LpVtbl[6])(@this, dpiXPtr, dpiY);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDpi(ref float dpiX, ref float dpiY)
        {
            var @this = (ID2D1GdiMetafile1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* dpiXPtr = &dpiX)
            {
                fixed (float* dpiYPtr = &dpiY)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, float*, float*, int>)@this->LpVtbl[6])(@this, dpiXPtr, dpiYPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSourceBounds(Silk.NET.Maths.Box2D<float>* bounds)
        {
            var @this = (ID2D1GdiMetafile1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[7])(@this, bounds);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSourceBounds(ref Silk.NET.Maths.Box2D<float> bounds)
        {
            var @this = (ID2D1GdiMetafile1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* boundsPtr = &bounds)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[7])(@this, boundsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1GdiMetafile1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void GetFactory<TI0>(ref ComPtr<TI0> factory) where TI0 : unmanaged, IComVtbl<ID2D1Factory>, IComVtbl<TI0>
        {
            var @this = (ID2D1GdiMetafile1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetFactory((ID2D1Factory**) factory.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int Stream<TI0>(ComPtr<TI0> sink) where TI0 : unmanaged, IComVtbl<ID2D1GdiMetafileSink>, IComVtbl<TI0>
        {
            var @this = (ID2D1GdiMetafile1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Stream((ID2D1GdiMetafileSink*) sink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1GdiMetafile1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
