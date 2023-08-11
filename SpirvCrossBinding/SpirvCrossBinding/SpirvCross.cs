namespace SpirvCrossBinding
{
    using System.Runtime.InteropServices;

    public unsafe static class SpirvCross
    {
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void spvc_get_version(uint* major, uint* minor, uint* patch);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* spvc_get_commit_revision_and_timestamp();
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void spvc_msl_vertex_attribute_init(spvc_msl_vertex_attribute* attr);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void spvc_msl_shader_interface_var_init(spvc_msl_shader_interface_var* var);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void spvc_msl_shader_input_init(spvc_msl_shader_interface_var* input);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void spvc_msl_shader_interface_var_init_2(spvc_msl_shader_interface_var_2* var);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void spvc_msl_resource_binding_init(spvc_msl_resource_binding* binding);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint spvc_msl_get_aux_buffer_struct_version();
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void spvc_msl_constexpr_sampler_init(spvc_msl_constexpr_sampler* sampler);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void spvc_msl_sampler_ycbcr_conversion_init(spvc_msl_sampler_ycbcr_conversion* conv);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void spvc_hlsl_resource_binding_init(spvc_hlsl_resource_binding* binding);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_context_create(spvc_context_s** context);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void spvc_context_destroy(spvc_context_s* context);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void spvc_context_release_allocations(spvc_context_s* context);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* spvc_context_get_last_error_string(spvc_context_s* context);
        public delegate void ErrorCallback(void* userData, byte* error);

        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void spvc_context_set_error_callback(spvc_context_s* context, ErrorCallback cb, void* userdata);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_context_parse_spirv(spvc_context_s* context, uint* spirv, ulong word_count, spvc_parsed_ir_s** parsed_ir);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_context_create_compiler(spvc_context_s* context, spvc_backend backend, spvc_parsed_ir_s* parsed_ir, spvc_capture_mode mode, spvc_compiler_s** compiler);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint spvc_compiler_get_current_id_bound(spvc_compiler_s* compiler);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_create_compiler_options(spvc_compiler_s* compiler, spvc_compiler_options_s** options);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_options_set_bool(spvc_compiler_options_s* options, spvc_compiler_option option, byte value);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_options_set_uint(spvc_compiler_options_s* options, spvc_compiler_option option, uint value);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_install_compiler_options(spvc_compiler_s* compiler, spvc_compiler_options_s* options);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_compile(spvc_compiler_s* compiler, byte** source);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_add_header_line(spvc_compiler_s* compiler, byte* line);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_require_extension(spvc_compiler_s* compiler, byte* ext);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong spvc_compiler_get_num_required_extensions(spvc_compiler_s* compiler);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* spvc_compiler_get_required_extension(spvc_compiler_s* compiler, ulong index);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_flatten_buffer_block(spvc_compiler_s* compiler, uint id);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte spvc_compiler_variable_is_depth_or_compare(spvc_compiler_s* compiler, uint id);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_mask_stage_output_by_location(spvc_compiler_s* compiler, uint location, uint component);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_mask_stage_output_by_builtin(spvc_compiler_s* compiler, SpvBuiltIn_ builtin);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_hlsl_set_root_constants_layout(spvc_compiler_s* compiler, spvc_hlsl_root_constants* constant_info, ulong count);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_hlsl_add_vertex_attribute_remap(spvc_compiler_s* compiler, spvc_hlsl_vertex_attribute_remap* remap, ulong remaps);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint spvc_compiler_hlsl_remap_num_workgroups_builtin(spvc_compiler_s* compiler);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_hlsl_set_resource_binding_flags(spvc_compiler_s* compiler, uint flags);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_hlsl_add_resource_binding(spvc_compiler_s* compiler, spvc_hlsl_resource_binding* binding);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte spvc_compiler_hlsl_is_resource_used(spvc_compiler_s* compiler, SpvExecutionModel_ model, uint set, uint binding);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte spvc_compiler_msl_is_rasterization_disabled(spvc_compiler_s* compiler);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte spvc_compiler_msl_needs_aux_buffer(spvc_compiler_s* compiler);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte spvc_compiler_msl_needs_swizzle_buffer(spvc_compiler_s* compiler);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte spvc_compiler_msl_needs_buffer_size_buffer(spvc_compiler_s* compiler);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte spvc_compiler_msl_needs_output_buffer(spvc_compiler_s* compiler);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte spvc_compiler_msl_needs_patch_output_buffer(spvc_compiler_s* compiler);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte spvc_compiler_msl_needs_input_threadgroup_mem(spvc_compiler_s* compiler);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_msl_add_vertex_attribute(spvc_compiler_s* compiler, spvc_msl_vertex_attribute* attrs);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_msl_add_resource_binding(spvc_compiler_s* compiler, spvc_msl_resource_binding* binding);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_msl_add_shader_input(spvc_compiler_s* compiler, spvc_msl_shader_interface_var* input);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_msl_add_shader_input_2(spvc_compiler_s* compiler, spvc_msl_shader_interface_var_2* input);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_msl_add_shader_output(spvc_compiler_s* compiler, spvc_msl_shader_interface_var* output);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_msl_add_shader_output_2(spvc_compiler_s* compiler, spvc_msl_shader_interface_var_2* output);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_msl_add_discrete_descriptor_set(spvc_compiler_s* compiler, uint desc_set);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_msl_set_argument_buffer_device_address_space(spvc_compiler_s* compiler, uint desc_set, byte device_address);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte spvc_compiler_msl_is_vertex_attribute_used(spvc_compiler_s* compiler, uint location);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte spvc_compiler_msl_is_shader_input_used(spvc_compiler_s* compiler, uint location);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte spvc_compiler_msl_is_shader_output_used(spvc_compiler_s* compiler, uint location);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte spvc_compiler_msl_is_resource_used(spvc_compiler_s* compiler, SpvExecutionModel_ model, uint set, uint binding);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_msl_remap_constexpr_sampler(spvc_compiler_s* compiler, uint id, spvc_msl_constexpr_sampler* sampler);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_msl_remap_constexpr_sampler_by_binding(spvc_compiler_s* compiler, uint desc_set, uint binding, spvc_msl_constexpr_sampler* sampler);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_msl_remap_constexpr_sampler_ycbcr(spvc_compiler_s* compiler, uint id, spvc_msl_constexpr_sampler* sampler, spvc_msl_sampler_ycbcr_conversion* conv);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_msl_remap_constexpr_sampler_by_binding_ycbcr(spvc_compiler_s* compiler, uint desc_set, uint binding, spvc_msl_constexpr_sampler* sampler, spvc_msl_sampler_ycbcr_conversion* conv);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_msl_set_fragment_output_components(spvc_compiler_s* compiler, uint location, uint components);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint spvc_compiler_msl_get_automatic_resource_binding(spvc_compiler_s* compiler, uint id);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint spvc_compiler_msl_get_automatic_resource_binding_secondary(spvc_compiler_s* compiler, uint id);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_msl_add_dynamic_buffer(spvc_compiler_s* compiler, uint desc_set, uint binding, uint index);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_msl_add_inline_uniform_block(spvc_compiler_s* compiler, uint desc_set, uint binding);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_msl_set_combined_sampler_suffix(spvc_compiler_s* compiler, byte* suffix);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* spvc_compiler_msl_get_combined_sampler_suffix(spvc_compiler_s* compiler);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_get_active_interface_variables(spvc_compiler_s* compiler, spvc_set_s** set);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_set_enabled_interface_variables(spvc_compiler_s* compiler, spvc_set_s* set);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_create_shader_resources(spvc_compiler_s* compiler, spvc_resources_s** resources);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_create_shader_resources_for_active_variables(spvc_compiler_s* compiler, spvc_resources_s** resources, spvc_set_s* active);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_resources_get_resource_list_for_type(spvc_resources_s* resources, spvc_resource_type type, spvc_reflected_resource** resource_list, ulong* resource_size);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_resources_get_builtin_resource_list_for_type(spvc_resources_s* resources, spvc_builtin_resource_type type, spvc_reflected_builtin_resource** resource_list, ulong* resource_size);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void spvc_compiler_set_decoration(spvc_compiler_s* compiler, uint id, SpvDecoration_ decoration, uint argument);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void spvc_compiler_set_decoration_string(spvc_compiler_s* compiler, uint id, SpvDecoration_ decoration, byte* argument);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void spvc_compiler_set_name(spvc_compiler_s* compiler, uint id, byte* argument);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void spvc_compiler_set_member_decoration(spvc_compiler_s* compiler, uint id, uint member_index, SpvDecoration_ decoration, uint argument);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void spvc_compiler_set_member_decoration_string(spvc_compiler_s* compiler, uint id, uint member_index, SpvDecoration_ decoration, byte* argument);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void spvc_compiler_set_member_name(spvc_compiler_s* compiler, uint id, uint member_index, byte* argument);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void spvc_compiler_unset_decoration(spvc_compiler_s* compiler, uint id, SpvDecoration_ decoration);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void spvc_compiler_unset_member_decoration(spvc_compiler_s* compiler, uint id, uint member_index, SpvDecoration_ decoration);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte spvc_compiler_has_decoration(spvc_compiler_s* compiler, uint id, SpvDecoration_ decoration);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte spvc_compiler_has_member_decoration(spvc_compiler_s* compiler, uint id, uint member_index, SpvDecoration_ decoration);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* spvc_compiler_get_name(spvc_compiler_s* compiler, uint id);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint spvc_compiler_get_decoration(spvc_compiler_s* compiler, uint id, SpvDecoration_ decoration);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* spvc_compiler_get_decoration_string(spvc_compiler_s* compiler, uint id, SpvDecoration_ decoration);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint spvc_compiler_get_member_decoration(spvc_compiler_s* compiler, uint id, uint member_index, SpvDecoration_ decoration);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* spvc_compiler_get_member_decoration_string(spvc_compiler_s* compiler, uint id, uint member_index, SpvDecoration_ decoration);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* spvc_compiler_get_member_name(spvc_compiler_s* compiler, uint id, uint member_index);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_get_entry_points(spvc_compiler_s* compiler, spvc_entry_point** entry_points, ulong* num_entry_points);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_set_entry_point(spvc_compiler_s* compiler, byte* name, SpvExecutionModel_ model);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_rename_entry_point(spvc_compiler_s* compiler, byte* old_name, byte* new_name, SpvExecutionModel_ model);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* spvc_compiler_get_cleansed_entry_point_name(spvc_compiler_s* compiler, byte* name, SpvExecutionModel_ model);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void spvc_compiler_set_execution_mode(spvc_compiler_s* compiler, SpvExecutionMode_ mode);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void spvc_compiler_unset_execution_mode(spvc_compiler_s* compiler, SpvExecutionMode_ mode);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void spvc_compiler_set_execution_mode_with_arguments(spvc_compiler_s* compiler, SpvExecutionMode_ mode, uint arg0, uint arg1, uint arg2);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_get_execution_modes(spvc_compiler_s* compiler, SpvExecutionMode_** modes, ulong* num_modes);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint spvc_compiler_get_execution_mode_argument(spvc_compiler_s* compiler, SpvExecutionMode_ mode);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint spvc_compiler_get_execution_mode_argument_by_index(spvc_compiler_s* compiler, SpvExecutionMode_ mode, uint index);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern SpvExecutionModel_ spvc_compiler_get_execution_model(spvc_compiler_s* compiler);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void spvc_compiler_update_active_builtins(spvc_compiler_s* compiler);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte spvc_compiler_has_active_builtin(spvc_compiler_s* compiler, SpvBuiltIn_ builtin, SpvStorageClass_ storage);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_type_s* spvc_compiler_get_type_handle(spvc_compiler_s* compiler, uint id);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint spvc_type_get_base_type_id(spvc_type_s* type);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_basetype spvc_type_get_basetype(spvc_type_s* type);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint spvc_type_get_bit_width(spvc_type_s* type);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint spvc_type_get_vector_size(spvc_type_s* type);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint spvc_type_get_columns(spvc_type_s* type);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint spvc_type_get_num_array_dimensions(spvc_type_s* type);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte spvc_type_array_dimension_is_literal(spvc_type_s* type, uint dimension);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint spvc_type_get_array_dimension(spvc_type_s* type, uint dimension);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint spvc_type_get_num_member_types(spvc_type_s* type);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint spvc_type_get_member_type(spvc_type_s* type, uint index);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern SpvStorageClass_ spvc_type_get_storage_class(spvc_type_s* type);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint spvc_type_get_image_sampled_type(spvc_type_s* type);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern SpvDim_ spvc_type_get_image_dimension(spvc_type_s* type);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte spvc_type_get_image_is_depth(spvc_type_s* type);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte spvc_type_get_image_arrayed(spvc_type_s* type);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte spvc_type_get_image_multisampled(spvc_type_s* type);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte spvc_type_get_image_is_storage(spvc_type_s* type);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern SpvImageFormat_ spvc_type_get_image_storage_format(spvc_type_s* type);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern SpvAccessQualifier_ spvc_type_get_image_access_qualifier(spvc_type_s* type);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_get_declared_struct_size(spvc_compiler_s* compiler, spvc_type_s* struct_type, ulong* size);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_get_declared_struct_size_runtime_array(spvc_compiler_s* compiler, spvc_type_s* struct_type, ulong array_size, ulong* size);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_get_declared_struct_member_size(spvc_compiler_s* compiler, spvc_type_s* type, uint index, ulong* size);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_type_struct_member_offset(spvc_compiler_s* compiler, spvc_type_s* type, uint index, uint* offset);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_type_struct_member_array_stride(spvc_compiler_s* compiler, spvc_type_s* type, uint index, uint* stride);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_type_struct_member_matrix_stride(spvc_compiler_s* compiler, spvc_type_s* type, uint index, uint* stride);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_build_dummy_sampler_for_combined_images(spvc_compiler_s* compiler, uint* id);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_build_combined_image_samplers(spvc_compiler_s* compiler);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_get_combined_image_samplers(spvc_compiler_s* compiler, spvc_combined_image_sampler** samplers, ulong* num_samplers);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_get_specialization_constants(spvc_compiler_s* compiler, spvc_specialization_constant** constants, ulong* num_constants);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_constant_s* spvc_compiler_get_constant_handle(spvc_compiler_s* compiler, uint id);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint spvc_compiler_get_work_group_size_specialization_constants(spvc_compiler_s* compiler, spvc_specialization_constant* x, spvc_specialization_constant* y, spvc_specialization_constant* z);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_get_active_buffer_ranges(spvc_compiler_s* compiler, uint id, spvc_buffer_range** ranges, ulong* num_ranges);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern float spvc_constant_get_scalar_fp16(spvc_constant_s* constant, uint column, uint row);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern float spvc_constant_get_scalar_fp32(spvc_constant_s* constant, uint column, uint row);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double spvc_constant_get_scalar_fp64(spvc_constant_s* constant, uint column, uint row);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint spvc_constant_get_scalar_u32(spvc_constant_s* constant, uint column, uint row);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int spvc_constant_get_scalar_i32(spvc_constant_s* constant, uint column, uint row);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint spvc_constant_get_scalar_u16(spvc_constant_s* constant, uint column, uint row);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int spvc_constant_get_scalar_i16(spvc_constant_s* constant, uint column, uint row);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint spvc_constant_get_scalar_u8(spvc_constant_s* constant, uint column, uint row);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int spvc_constant_get_scalar_i8(spvc_constant_s* constant, uint column, uint row);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void spvc_constant_get_subconstants(spvc_constant_s* constant, uint** constituents, ulong* count);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint spvc_constant_get_type(spvc_constant_s* constant);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void spvc_constant_set_scalar_fp16(spvc_constant_s* constant, uint column, uint row, ushort value);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void spvc_constant_set_scalar_fp32(spvc_constant_s* constant, uint column, uint row, float value);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void spvc_constant_set_scalar_fp64(spvc_constant_s* constant, uint column, uint row, double value);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void spvc_constant_set_scalar_u32(spvc_constant_s* constant, uint column, uint row, uint value);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void spvc_constant_set_scalar_i32(spvc_constant_s* constant, uint column, uint row, int value);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void spvc_constant_set_scalar_u16(spvc_constant_s* constant, uint column, uint row, ushort value);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void spvc_constant_set_scalar_i16(spvc_constant_s* constant, uint column, uint row, short value);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void spvc_constant_set_scalar_u8(spvc_constant_s* constant, uint column, uint row, byte value);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void spvc_constant_set_scalar_i8(spvc_constant_s* constant, uint column, uint row, sbyte value);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte spvc_compiler_get_binary_offset_for_decoration(spvc_compiler_s* compiler, uint id, SpvDecoration_ decoration, uint* word_offset);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte spvc_compiler_buffer_is_hlsl_counter_buffer(spvc_compiler_s* compiler, uint id);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte spvc_compiler_buffer_get_hlsl_counter_buffer(spvc_compiler_s* compiler, uint id, uint* counter_id);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_get_declared_capabilities(spvc_compiler_s* compiler, SpvCapability_** capabilities, ulong* num_capabilities);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_get_declared_extensions(spvc_compiler_s* compiler, byte*** extensions, ulong* num_extensions);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* spvc_compiler_get_remapped_declared_block_name(spvc_compiler_s* compiler, uint id);
        [DllImport("libs/spirv-cross-c-shared.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern spvc_result spvc_compiler_get_buffer_block_decorations(spvc_compiler_s* compiler, uint id, SpvDecoration_** decorations, ulong* num_decorations);
    }
}