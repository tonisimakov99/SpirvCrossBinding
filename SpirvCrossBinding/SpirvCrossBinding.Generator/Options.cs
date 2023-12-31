﻿using CommandLine.Text;
using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpirvCrossBinding.Generator
{
    internal class Options
    {
        [Option('o', "outdir", Required = true, HelpText = "Output directory")]
        public string OutDir { get; set; }

        [Option('f', "file", Required = true, HelpText = "Header file path")]
        public IEnumerable<string> FilePaths { get; set; }

        [Option('i', "include", Required = true, HelpText = "Include dir")]
        public string IncludePath { get; set; }

        [Option('n', "namespace", Required = true, HelpText = "Out namespace")]
        public string Namespace { get; set; }
    }
}
