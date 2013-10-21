singleton Material(GG_SunriseSky01_Material)
{
   mapTo = "GG_SunriseSky01_Material";
   cubemap = "GG_SunriseSky01_Cubemap";
   castShadows = "0";
   showFootprints = "0";
   diffuseColor[0] = "0.0588235 0.14902 0.25098 1";
   materialTag0 = "Sky";
};

new CubemapData(GG_SunriseSky01_Cubemap)
{
   cubeFace[0] = "art/skies/GG_SunriseSky01/GG_SunriseSky01_0000.dds";
   cubeFace[1] = "art/skies/GG_SunriseSky01/GG_SunriseSky01_0001.dds";
   cubeFace[2] = "art/skies/GG_SunriseSky01/GG_SunriseSky01_0002.dds";
   cubeFace[3] = "art/skies/GG_SunriseSky01/GG_SunriseSky01_0003.dds";
   cubeFace[4] = "art/skies/GG_SunriseSky01/GG_SunriseSky01_0004.dds";
   cubeFace[5] = "art/skies/GG_SunriseSky01/GG_SunriseSky01_0005.dds";
};

singleton Material( GG_SunriseSky01_Moon_Material )
{
   mapTo = "GG_SunriseSky01_Moon_Material";
   emissive = true;
   translucent = true;
   diffuseColor[0] = "0.592157 0.67451 0.788235 1";
   diffuseMap[0] = "core/art/skies/night/moon_wglow.png";
};