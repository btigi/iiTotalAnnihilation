﻿using System.Runtime.InteropServices;

namespace ii.CompleteDestruction.Model.Hpi;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct HPIHEADER2
{
    public int DirBlock;
    public int DirSize;
    public int NameBlock;
    public int NameSize;
    public int Data;
    public int Last78;
}