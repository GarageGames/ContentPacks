singleton Material(Mamba_Base)
{
   mapTo = "Mamba_Base";
   diffuseMap[0] = "./Mamba_D";
   normalMap[0] = "./Mamba_N.dds";
   specularMap[0] = "./Mamba_S.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
};

singleton Material(Mamba_MuzzleFlash_Base)
{
   mapTo = "Mamba_MuzzleFlash_Base";
   diffuseMap[0] = "./Mamba_MuzzleFlash_D.dds";
   diffuseColor[0] = "0.15 0.15 0.15 1";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucent = "1";
   glow[0] = "1";
   emissive[0] = "0";
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
