//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//--- streetLamp.dae MATERIALS BEGIN ---
singleton Material(street_lamp_materials)
{
	mapTo = "street_lamp";

	diffuseMap[0] = "street_lamp_d.dds";
	normalMap[0] = "street_lamp_n.dds";
	specularMap[0] = "street_lamp_s.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "1 1 1 1";
	specularPower[0] = 4;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   pixelSpecular[0] = "0";
   alphaTest = "1";
   alphaRef = "33";
   materialTag0 = "RoadAndPath";
   constantCubemapGloss = "0.2";
};

//--- streetLamp.dae MATERIALS END ---


singleton Material(street_lamp_lod)
{
   mapTo = "street_lamp_lod";
   diffuseMap[0] = "street_lamp_d.dds";
   diffuseColor[0] = "1 1 1 0";
   alphaTest = "1";
   alphaRef = "87";
};
