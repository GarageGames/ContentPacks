
singleton Material(Duke_Base)
{
   mapTo = "Duke_Base";
   diffuseMap[0] = "./Duke_D.dds";
   normalMap[0] = "./Duke_N.dds";
   specularMap[0] = "./Duke_S.dds";
   specularPower[0] = "32";
   translucentBlendOp = "None";
   useAnisotropic[0] = "1";
};

singleton Material(Duke_Clip_Base)
{
   mapTo = "Duke_Clip_Base";
   diffuseMap[0] = "./Duke_Clip_D.dds";
   normalMap[0] = "./Duke_Clip_N.dds";
   specularMap[0] = "./Duke_Clip_S.dds";
   specularPower[0] = "32";
   useAnisotropic[0] = "1";
};

singleton Material(Duke_Glows_Base)
{
   mapTo = "Duke_Glows_Base";
   diffuseMap[0] = "./Duke_Glows.dds";
   translucent = "1";
   glow[0] = "1";
   emissive[0] = "1";
   castShadows = "0";
   translucentBlendOp = "Add";
};

singleton Material(Duke_MuzzleFlash_Base)
{
   mapTo = "Duke_MuzzleFlash_Base";
   diffuseMap[0] = "./Duke_MuzzleFlash.dds";
   diffuseColor[0] = "0.05 0.05 0.05 1";
   specular[0] = "0 0 0 1";
   specularPower[0] = "10";
   translucent = "1";
   glow[0] = "1";
   emissive[0] = "1";
   doubleSided = "1";
   translucentBlendOp = "Add";
   animFlags[0] = "0x00000005";
   scrollDir[0] = "-0.15 -0.15";
   rotSpeed[0] = "0.25";
   rotPivotOffset[0] = "-0.5 -0.5";
   waveFreq[0] = "5.313";
   waveAmp[0] = "0.016";
   castShadows = "0";
};
