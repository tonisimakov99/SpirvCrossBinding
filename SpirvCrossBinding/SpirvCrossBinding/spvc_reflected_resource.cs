namespace SpirvCrossBinding
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct spvc_reflected_resource
    {
        public uint id;
        public uint base_type_id;
        public uint type_id;
        public byte* name;
    }
}