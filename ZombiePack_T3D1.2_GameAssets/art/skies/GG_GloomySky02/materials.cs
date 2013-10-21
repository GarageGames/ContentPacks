singleton Material(GG_GloomySky02_Material)
{
   mapTo = "GG_GloomySky02_Material";
   cubemap = "GG_GloomySky02_Cubemap";
   castShadows = "0";
   showFootprints = "0";
   diffuseColor[0] = "0.0588235 0.14902 0.25098 1";
   materialTag0 = "Sky";
};

new CubemapData(GG_GloomySky02_Cubemap)
{
   cubeFace[0] = "art/skies/GG_GloomySky02/GG_GloomySky02_0000.dds";
   cubeFace[1] = "art/skies/GG_GloomySky02/GG_GloomySky02_0001.dds";
   cubeFace[2] = "art/skies/GG_GloomySky02/GG_GloomySky02_0002.dds";
   cubeFace[3] = "art/skies/GG_GloomySky02/GG_GloomySky02_0003.dds";
   cubeFace[4] = "art/skies/GG_GloomySky02/GG_GloomySky02_0004.dds";
   cubeFace[5] = "art/skies/GG_GloomySky02/GG_GloomySky02_0005.dds";
};

singleton Material( GG_GloomySky02_Moon_Material )
{
   mapTo = "GG_GloomySky02_Moon_Material";
   emissive = true;
   translucent = true;
   diffuseColor[0] = "0.592157 0.67451 0.788235 1";
   diffuseMap[0] = "core/art/skies/night/moon_wglow.png";
};