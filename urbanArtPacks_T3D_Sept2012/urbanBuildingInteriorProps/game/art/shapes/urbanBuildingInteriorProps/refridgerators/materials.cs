//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//--- Refridgeration MATERIALS BEGIN ---

singleton Material(refridgerators)
{   
   mapTo = "refridgerators";
   diffuseMap[0] = "refridgerators_D.dds";
   normalMap[0] = "refridgerators_N.dds";
   specular[0] = "1 1 1 0";
   specularPower[0] = "50";
   specularMap[0] = "refridgerators_S.dds";
   castShadows = "0";
   translucentBlendOp = "None";
   materialTag0 = "InteriorProps";
   constantCubemapGloss = "0.2";
};
