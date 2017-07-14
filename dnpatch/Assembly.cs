﻿using System;
using dnlib.DotNet;

namespace dnpatch
{
    public class Assembly
    {
        public AssemblyInfo AssemblyInfo;
        public AssemblyData AssemblyData;

        internal Assembly(AssemblyInfo assemblyInfo)
        {
            AssemblyInfo = assemblyInfo;
            AssemblyData = new AssemblyData() // Load assembly data
            {
                Module = ModuleDefMD.Load(AssemblyInfo.Name)
            };
        }
    }
}