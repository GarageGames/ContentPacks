
singleton Material(Kraad_Base)
{
   mapTo = "Kraad_Base";
   diffuseMap[0] = "./Alien_Rifle_d.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "23";
   translucentBlendOp = "None";
   normalMap[0] = "./Alien_Rifle_n.dds";
   pixelSpecular[0] = "1";
   specularMap[0] = "./Alien_Rifle_s.dds";
   useAnisotropic[0] = "1";
   cubemap = "refnightSkyCubemap";
};

singleton Material(Kraad_Battery_Base)
{
   mapTo = "Kraad_Battery_Base";
   diffuseMap[0] = "./Kraad_Powercell.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucent = "1";
};

singleton Material(Kraad_MuzzleFlash_Base)
{
   mapTo = "Kraad_MuzzleFlash_Base";
   diffuseMap[0] = "./Kraad_MuzzleFlash.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucent = "1";
   glow[0] = "1";
   translucentBlendOp = "Add";
   animFlags[0] = "0x00000000";
   scrollDir[0] = "0 0";
   scrollSpeed[0] = "0";
   doubleSided = "1";
};

singleton Material(Kraad_Energy_Base)
{
   mapTo = "Kraad_Energy_Base";
   diffuseMap[0] = "./Kraad_Energy_Scroll.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucent = "1";
   glow[0] = "1";
   emissive[0] = "0";
   translucentBlendOp = "Add";
   animFlags[0] = "0x00000001";
   scrollDir[0] = "0 0.5";
   scrollSpeed[0] = "0.588";
   doubleSided = "1";
};
