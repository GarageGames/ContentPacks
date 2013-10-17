
singleton Material(Disposition_Base)
{
   mapTo = "Disposition_Base";
   diffuseMap[0] = "./Disposition_D.dds";
   specularPower[0] = "32";
   specular[0] = "0.9 0.9 0.9 1";
   specularMap[0] = "./Disposition_S.dds";
   translucentBlendOp = "None";
   normalMap[0] = "./Disposition_N.dds";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
};

singleton Material(Disposition_MuzzleFlash_Base)
{
   mapTo = "Disposition_MuzzleFlash_Base";
   diffuseMap[0] = "./Disposition_MuzzleFlash_D.dds";
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
