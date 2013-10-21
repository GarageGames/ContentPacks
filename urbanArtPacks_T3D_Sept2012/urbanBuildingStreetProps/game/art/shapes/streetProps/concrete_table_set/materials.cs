//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------


singleton Material(concretetableset_material)
{
   mapTo = "concretetableset";
   diffuseColor[0] = "0.454902 0.454902 0.454902 1";
   diffuseMap[0] = "concretetableset_d.dds";
   normalMap[0] = "concretetableset_n.dds";
   specular[0] = "1 1 1 1";
   specularPower[0] = "8";
   pixelSpecular[0] = "0";
   specularMap[0] = "concretetableset_s.dds";
   doubleSided = "0";
   translucent = "0";
   translucentBlendOp = "None";
   translucentZWrite = "0";
   alphaTest = "0";
   alphaRef = "1";
   materialTag0 = "RoadAndPath";
};

singleton Material(concrete_bench_concretetableset_lod)
{
   mapTo = "concretetableset_lod";
   diffuseMap[0] = "concretetableset_d";
   specular[0] = "0 0 0 1";
   specularPower[0] = "2";
   translucentBlendOp = "None";
};
