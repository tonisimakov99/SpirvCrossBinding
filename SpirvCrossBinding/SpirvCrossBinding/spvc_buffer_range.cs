namespace SpirvCrossBinding
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct spvc_buffer_range
    {
        public uint index;
        public ulong offset;
        public ulong range;
    }
}