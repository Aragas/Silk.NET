// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum ClearBufferMask : uint
{
    DepthBufferBit = unchecked((uint)0x00000100),
    StencilBufferBit = unchecked((uint)0x00000400),
    ColorBufferBit = unchecked((uint)0x00004000),
    AccumBufferBit = unchecked((uint)0x00000200),
    CoverageBufferBitNV = unchecked((uint)0x00008000)
}
