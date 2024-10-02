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

public partial struct HapticCondition
{
    [NativeTypeName("Uint16")]
    public ushort Type;
    public HapticDirection Direction;

    [NativeTypeName("Uint32")]
    public uint Length;

    [NativeTypeName("Uint16")]
    public ushort Delay;

    [NativeTypeName("Uint16")]
    public ushort Button;

    [NativeTypeName("Uint16")]
    public ushort Interval;

    [NativeTypeName("Uint16[3]")]
    public _right_sat_e__FixedBuffer RightSat;

    [NativeTypeName("Uint16[3]")]
    public _left_sat_e__FixedBuffer LeftSat;

    [NativeTypeName("Sint16[3]")]
    public _right_coeff_e__FixedBuffer RightCoeff;

    [NativeTypeName("Sint16[3]")]
    public _left_coeff_e__FixedBuffer LeftCoeff;

    [NativeTypeName("Uint16[3]")]
    public _deadband_e__FixedBuffer Deadband;

    [NativeTypeName("Sint16[3]")]
    public _center_e__FixedBuffer Center;

    [InlineArray(3)]
    public partial struct _right_sat_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(3)]
    public partial struct _left_sat_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(3)]
    public partial struct _right_coeff_e__FixedBuffer
    {
        public short e0;
    }

    [InlineArray(3)]
    public partial struct _left_coeff_e__FixedBuffer
    {
        public short e0;
    }

    [InlineArray(3)]
    public partial struct _deadband_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(3)]
    public partial struct _center_e__FixedBuffer
    {
        public short e0;
    }
}
