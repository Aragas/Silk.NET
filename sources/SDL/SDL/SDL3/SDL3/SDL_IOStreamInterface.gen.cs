// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.SDL.ChromaLocation;
using static Silk.NET.SDL.ColorPrimaries;
using static Silk.NET.SDL.ColorRange;
using static Silk.NET.SDL.ColorType;
using static Silk.NET.SDL.MatrixCoefficients;
using static Silk.NET.SDL.PenAxis;
using static Silk.NET.SDL.Scancode;
using static Silk.NET.SDL.TransferCharacteristics;

namespace Silk.NET.SDL;

public unsafe partial struct IOStreamInterface
{
    [NativeTypeName("Sint64 (*)(void *)")]
    public delegate* unmanaged<void*, long> Size;

    [NativeTypeName("Sint64 (*)(void *, Sint64, int)")]
    public delegate* unmanaged<void*, long, int, long> Seek;

    [NativeTypeName("size_t (*)(void *, void *, size_t, SDL_IOStatus *)")]
    public delegate* unmanaged<void*, void*, nuint, IOStatus*, nuint> Read;

    [NativeTypeName("size_t (*)(void *, const void *, size_t, SDL_IOStatus *)")]
    public delegate* unmanaged<void*, void*, nuint, IOStatus*, nuint> Write;

    [NativeTypeName("int (*)(void *)")]
    public delegate* unmanaged<void*, int> Close;
}
