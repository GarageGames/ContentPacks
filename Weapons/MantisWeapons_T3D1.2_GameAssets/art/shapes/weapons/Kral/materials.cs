
singleton Material(Kral_Base)
{
   mapTo = "Kral_Base";
   diffuseMap[0] = "./Kral_d.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "23";
   translucentBlendOp = "None";
   normalMap[0] = "./Kral_n.dds";
   pixelSpecular[0] = "1";
   specularMap[0] = "./Kral_s.dds";
   useAnisotropic[0] = "1";
   cubemap = "refnightSkyCubemap";
};

singleton Material(Kral_Plasma_Base)
{
   mapTo = "Kral_Plasma_Base";
   diffuseMap[0] = "./Kral_Plasma.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucent = "1";
   emissive[0] = "1";
   doubleSided = "1";
   animFlags[0] = "0x00000002";
   rotSpeed[0] = "4";
   rotPivotOffset[0] = "-0.5 -0.5";
   translucentBlendOp = "Add";
};

singleton Material(Kral_MuzzleFlash_Base)
{
   mapTo = "Kral_MuzzleFlash_Base";
   diffuseMap[0] = "./Kral_MuzzleFlash.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucent = "1";
   glow[0] = "0";
   doubleSided = "1";
   translucentBlendOp = "Add";
};

singleton Material(Kral_Energy_Base)
{
   mapTo = "Kral_Energy_Base";
   diffuseMap[0] = "./Kral_Energy_Scroll.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucent = "1";
   glow[0] = "1";
   emissive[0] = "0";
   animFlags[0] = "0x00000001";
   scrollDir[0] = "0 0.5";
   scrollSpeed[0] = "0.5";
   doubleSided = "1";
   translucentBlendOp = "Add";
};

singleton Material(Kral_Battery_Base)
{
   mapTo = "Kral_Battery_Base";
   diffuseMap[0] = "./Kral_Powercell.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucent = "1";
};