// Material wrapper generated by shader translator tool

using System;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace Kopernicus.Components.MaterialWrapper
{
    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Local")]
    [SuppressMessage("ReSharper", "MemberCanBeProtected.Global")]
    public class AerialTransCutout : Material
    {
        // Internal property ID tracking object
        protected class Properties
        {
            // Return the shader for this wrapper
            private const String SHADER_NAME = "Terrain/PQS/Aerial Cutout";

            public static Shader Shader
            {
                get { return Shader.Find(SHADER_NAME); }
            }

            // Main Color, default = (1,1,1,1)
            public const String COLOR_KEY = "_Color";
            public Int32 ColorId { get; private set; }

            // Base (RGB) Trans (A), default = "white" { }
            public const String MAIN_TEX_KEY = "_MainTex";
            public Int32 MainTexId { get; private set; }

            // Alpha cutoff, default = 0.5
            public const String TEX_CUTOFF_KEY = "_texCutoff";
            public Int32 TexCutoffId { get; private set; }

            // AP Fog Color, default = (0,0,1,1)
            public const String FOG_COLOR_KEY = "_fogColor";
            public Int32 FogColorId { get; private set; }

            // AP Height Fall Off, default = 1
            public const String HEIGHT_FALL_OFF_KEY = "_heightFallOff";
            public Int32 HeightFallOffId { get; private set; }

            // AP Global Density, default = 1
            public const String GLOBAL_DENSITY_KEY = "_globalDensity";
            public Int32 GlobalDensityId { get; private set; }

            // AP Atmosphere Depth, default = 1
            public const String ATMOSPHERE_DEPTH_KEY = "_atmosphereDepth";
            public Int32 AtmosphereDepthId { get; private set; }

            // Singleton instance
            private static Properties _singleton;

            public static Properties Instance
            {
                get
                {
                    // Construct the singleton if it does not exist
                    return _singleton ?? (_singleton = new Properties());
                }
            }

            private Properties()
            {
                ColorId = Shader.PropertyToID(COLOR_KEY);
                MainTexId = Shader.PropertyToID(MAIN_TEX_KEY);
                TexCutoffId = Shader.PropertyToID(TEX_CUTOFF_KEY);
                FogColorId = Shader.PropertyToID(FOG_COLOR_KEY);
                HeightFallOffId = Shader.PropertyToID(HEIGHT_FALL_OFF_KEY);
                GlobalDensityId = Shader.PropertyToID(GLOBAL_DENSITY_KEY);
                AtmosphereDepthId = Shader.PropertyToID(ATMOSPHERE_DEPTH_KEY);
            }
        }

        // Is some random material this material 
        public static Boolean UsesSameShader(Material m)
        {
            return m.shader.name == Properties.Shader.name;
        }

        // Main Color, default = (1,1,1,1)
        public Color Color
        {
            get { return GetColor(Properties.Instance.ColorId); }
            set { SetColor(Properties.Instance.ColorId, value); }
        }

        // Base (RGB) Trans (A), default = "white" { }
        public Texture2D MainTex
        {
            get { return GetTexture(Properties.Instance.MainTexId) as Texture2D; }
            set { SetTexture(Properties.Instance.MainTexId, value); }
        }

        [SuppressMessage("ReSharper", "Unity.PreferAddressByIdToGraphicsParams")]
        public Vector2 MainTexScale
        {
            get { return GetTextureScale(Properties.MAIN_TEX_KEY); }
            set { SetTextureScale(Properties.MAIN_TEX_KEY, value); }
        }

        [SuppressMessage("ReSharper", "Unity.PreferAddressByIdToGraphicsParams")]
        public Vector2 MainTexOffset
        {
            get { return GetTextureOffset(Properties.MAIN_TEX_KEY); }
            set { SetTextureOffset(Properties.MAIN_TEX_KEY, value); }
        }

        // Alpha cutoff, default = 0.5
        public Single TexCutoff
        {
            get { return GetFloat(Properties.Instance.TexCutoffId); }
            set { SetFloat(Properties.Instance.TexCutoffId, Mathf.Clamp(value, 0f, 1f)); }
        }

        // AP Fog Color, default = (0,0,1,1)
        public Color FogColor
        {
            get { return GetColor(Properties.Instance.FogColorId); }
            set { SetColor(Properties.Instance.FogColorId, value); }
        }

        // AP Height Fall Off, default = 1
        public Single HeightFallOff
        {
            get { return GetFloat(Properties.Instance.HeightFallOffId); }
            set { SetFloat(Properties.Instance.HeightFallOffId, value); }
        }

        // AP Global Density, default = 1
        public Single GlobalDensity
        {
            get { return GetFloat(Properties.Instance.GlobalDensityId); }
            set { SetFloat(Properties.Instance.GlobalDensityId, value); }
        }

        // AP Atmosphere Depth, default = 1
        public Single AtmosphereDepth
        {
            get { return GetFloat(Properties.Instance.AtmosphereDepthId); }
            set { SetFloat(Properties.Instance.AtmosphereDepthId, value); }
        }

        public AerialTransCutout() : base(Properties.Shader)
        {
        }

        [Obsolete("Creating materials from shader source String is no longer supported. Use Shader assets instead.")]
        public AerialTransCutout(String contents) : base(contents)
        {
            shader = Properties.Shader;
        }

        public AerialTransCutout(Material material) : base(material)
        {
            // Throw exception if this material was not the proper material
            if (material.shader.name != Properties.Shader.name)
            {
                throw new InvalidOperationException("Type Mismatch: Terrain/PQS/Aerial Cutout shader required");
            }
        }

    }
}
