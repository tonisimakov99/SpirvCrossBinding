namespace SpirvCrossBinding
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct spvc_combined_image_sampler
    {
        public uint combined_id;
        public uint image_id;
        public uint sampler_id;
    }
}