//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//--- dragonGate.dae MATERIALS BEGIN ---
singleton Material(dragonGate_lod_material)
{
	mapTo = "dragonGate_lod";

	diffuseMap[0] = "dragonGate_diffuse.dds";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "0.7 0.7 0.7 0";
	specular[0] = "1 1 1 0";
	specularPower[0] = 50;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "132";
   constantCubemapGloss = "0.2";
   materialTag0 = "RoadAndPath";
};

//--- dragonGate.dae MATERIALS END ---


singleton Material(dragonGate_material)
{
   mapTo = "dragonGate";
   diffuseMap[0] = "dragonGate_diffuse.dds";
   normalMap[0] = "dragonGate_normals.dds";
   specular[0] = "1 1 1 0";
   specularPower[0] = "1";
   specularMap[0] = "dragonGate_specular.dds";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "53";
};

singleton Material(dragon_gate_ColorEffectR184G228B153_material)
{
   mapTo = "ColorEffectR184G228B153-material";
   diffuseColor[0] = "0.721569 0.894118 0.6 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(dragon_gate_ColorEffectR225G87B143_material)
{
   mapTo = "ColorEffectR225G87B143-material";
   diffuseColor[0] = "0.882353 0.341177 0.560784 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};
