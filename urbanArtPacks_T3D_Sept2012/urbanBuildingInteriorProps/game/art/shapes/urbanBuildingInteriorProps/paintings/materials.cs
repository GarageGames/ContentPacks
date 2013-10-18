//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//--- Paintings MATERIALS BEGIN ---

singleton Material(paintings)
{   
   mapTo = "paintings";
   diffuseMap[0] = "paintings_D.dds";
   normalMap[0] = "paintings_N.dds";
   specular[0] = "1 1 1 0";
   specularPower[0] = "50";
   specularMap[0] = "paintings_S.dds";
   castShadows = "0";
   translucentBlendOp = "None";
   materialTag0 = "InteriorProps";
   constantCubemapGloss = "0.2";
};
