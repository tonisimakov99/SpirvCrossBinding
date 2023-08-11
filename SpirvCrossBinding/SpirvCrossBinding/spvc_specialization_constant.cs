namespace SpirvCrossBinding
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct spvc_specialization_constant
    {
        public uint id;
        public uint constant_id;
    }
}