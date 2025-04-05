﻿using System.Runtime.InteropServices;

namespace ii.TotalAnnihilation.Model;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct HPIHEADER1
{
    public int DirectorySize;
    public int Key;
    public int Start;
}