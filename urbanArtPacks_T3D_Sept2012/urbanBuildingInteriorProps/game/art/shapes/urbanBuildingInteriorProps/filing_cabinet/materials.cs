//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//--- File Cabinet MATERIALS BEGIN ---

singleton Material(Interior_props_file_cabinet)
{   
   mapTo = "file_cabinet";
   diffuseMap[0] = "file_cabinet_D.dds";
   normalMap[0] = "file_cabinet_N.dds";
   specular[0] = "1 1 1 0";
   specularPower[0] = "50";
   specularMap[0] = "file_cabinet_S.dds";
   castShadows = "0";
   translucentBlendOp = "None";
   materialTag0 = "InteriorProps";
   constantCubemapGloss = "0.2";
};
