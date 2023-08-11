namespace SpirvCrossBinding
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct spvc_hlsl_root_constants
    {
        public uint start;
        public uint end;
        public uint binding;
        public uint space;
    }
}