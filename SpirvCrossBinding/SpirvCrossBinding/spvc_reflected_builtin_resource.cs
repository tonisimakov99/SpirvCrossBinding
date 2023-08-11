namespace SpirvCrossBinding
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct spvc_reflected_builtin_resource
    {
        public SpvBuiltIn_ builtin;
        public uint value_type_id;
        public spvc_reflected_resource resource;
    }
}