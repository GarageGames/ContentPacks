//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//--- Lights MATERIALS BEGIN ---

singleton Material(lights)
{   
   mapTo = "lights";
   diffuseMap[0] = "lights_D.dds";
   normalMap[0] = "lights_N.dds";
   specular[0] = "1 1 1 0";
   specularPower[0] = "50";
   specularMap[0] = "lights/lights_S.dds";
   castShadows = "0";
   translucentBlendOp = "None";
   materialTag0 = "InteriorProps";
   constantCubemapGloss = "0.2";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "175";
};
