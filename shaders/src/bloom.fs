//------------------------------------------------------------------------------
// Dithering configuration
//------------------------------------------------------------------------------

vec3 bloom(inout PostProcessInputs postProcess, const vec3 color) {
    vec3 blurred = textureLod(materialParams_bloomBuffer, variable_vertex.xy, 0).rgb;
    return color + blurred * materialParams.bloom;
}
