﻿namespace BackgroundCopyManager1_5
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, Guid("1AF4F612-3B71-466F-8F58-7B6F73AC57AD"), InterfaceType((short) 1)]
    public interface IEnumBackgroundCopyJobs
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void Next([In] uint celt, [MarshalAs(UnmanagedType.Interface)] out IBackgroundCopyJob rgelt, [In, Out] ref uint pceltFetched);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void Skip([In] uint celt);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void Reset();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void Clone([MarshalAs(UnmanagedType.Interface)] out IEnumBackgroundCopyJobs ppenum);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void GetCount(out uint puCount);
    }
}

