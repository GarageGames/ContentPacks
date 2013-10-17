
singleton Material(Kralmok_Powercell_Base)
{
   mapTo = "Kralmok_Powercell_Base";
   diffuseMap[0] = "./Kralmok_Powercell.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   glow[0] = "1";
   animFlags[0] = "0x00000001";
   scrollDir[0] = "0 0.5";
   scrollSpeed[0] = "0.25";
};

singleton Material(Kralmok_Energy_Base)
{
   mapTo = "Kralmok_Energy_Base";
   diffuseMap[0] = "./Kralmok_Energy_Scroll.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucent = "1";
   glow[0] = "1";
   animFlags[0] = "0x00000001";
   scrollDir[0] = "0 0.5";
   scrollSpeed[0] = "1";
   translucentBlendOp = "Add";
   doubleSided = "1";
};

singleton Material(Kralmok_Plasma_Base)
{
   mapTo = "Kralmok_Plasma_Base";
   diffuseMap[0] = "./Kralmok_Plasma.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucent = "1";
   glow[0] = "1";
   doubleSided = "1";
   translucentBlendOp = "Add";
   animFlags[0] = "0x00000002";
   rotSpeed[0] = "5";
   rotPivotOffset[0] = "-0.5 -0.5";
};

singleton Material(Kralmok_MuzzleFlash_Base)
{
   mapTo = "Kralmok_MuzzleFlash_Base";
   diffuseMap[0] = "./Kralmok_MuzzleFlash.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucent = "1";
   glow[0] = "1";
   doubleSided = "1";
   translucentBlendOp = "Add";
};

singleton Material(Kralmok_Base)
{
   mapTo = "Kralmok_Base";
   diffuseMap[0] = "./Kralmok_d.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "23";
   translucentBlendOp = "None";
   normalMap[0] = "./Kralmok_n.dds";
   pixelSpecular[0] = "1";
   specularMap[0] = "./Kralmok_s.dds";
   useAnisotropic[0] = "1";
   cubemap = "refnightSkyCubemap";
};
