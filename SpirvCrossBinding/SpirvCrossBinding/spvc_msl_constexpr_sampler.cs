namespace SpirvCrossBinding
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct spvc_msl_constexpr_sampler
    {
        public spvc_msl_sampler_coord coord;
        public spvc_msl_sampler_filter min_filter;
        public spvc_msl_sampler_filter mag_filter;
        public spvc_msl_sampler_mip_filter mip_filter;
        public spvc_msl_sampler_address s_address;
        public spvc_msl_sampler_address t_address;
        public spvc_msl_sampler_address r_address;
        public spvc_msl_sampler_compare_func compare_func;
        public spvc_msl_sampler_border_color border_color;
        public float lod_clamp_min;
        public float lod_clamp_max;
        public int max_anisotropy;
        public byte compare_enable;
        public byte lod_clamp_enable;
        public byte anisotropy_enable;
    }
}