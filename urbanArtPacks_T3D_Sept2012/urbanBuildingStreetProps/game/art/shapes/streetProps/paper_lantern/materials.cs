//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------



singleton Material(paper_lantern_material)
{
   mapTo = "paper_lantern";
   diffuseMap[0] = "paper_lantern_d.dds";
   normalMap[0] = "paper_lantern_n.dds";
   alphaTest = "1";
   alphaRef = "73";
   specularPower[0] = "66";
   pixelSpecular[0] = "1";
//   glow[0] = "1";
   doubleSided = "1";
//   diffuseMap[1] = "paper_lantern_g.dds";
//   glow[1] = "1";
   specular[0] = "1 0.396078 0 1";
};



singleton Material(paper_lantern_ColorEffectR166G229B229_material)
{
   mapTo = "ColorEffectR166G229B229-material";
   diffuseColor[0] = "0.65098 0.898039 0.898039 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};
