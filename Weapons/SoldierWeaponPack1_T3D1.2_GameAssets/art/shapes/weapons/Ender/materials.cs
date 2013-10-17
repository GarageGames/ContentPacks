
singleton Material(Ender_Base)
{
   mapTo = "Ender_Base";
   diffuseMap[0] = "./Ender_D.dds";
   specularPower[0] = "32";
   specular[0] = "0.9 0.9 0.9 1";
   specularMap[0] = "./Ender_S.dds";
   translucentBlendOp = "None";
   normalMap[0] = "./Ender_N.dds";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
};

singleton Material(Ender_MuzzleFlash_Base)
{
   mapTo = "Ender_MuzzleFlash_Base";
   diffuseMap[0] = "./Ender_MuzzleFlash_D.dds";
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

singleton Material(Ender_Glows_Base)
{
   mapTo = "Ender_Glows_Base";
   diffuseMap[0] = "Ender_Glows.dds";
   translucent = "1";
   glow[0] = "1";
   translucentBlendOp = "Add";
};


singleton Material(FP_Ender_Ender_Glow_Base)
{
   mapTo = "Ender_Glow_Base";
   diffuseMap[0] = "Ender_Glows";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucent = "1";
};

singleton Material(FP_Ender_Base)
{
   mapTo = "FP_Ender_Base";
   diffuseMap[0] = "Ender_D";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};
