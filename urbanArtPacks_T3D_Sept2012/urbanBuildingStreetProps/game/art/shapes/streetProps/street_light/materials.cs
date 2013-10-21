//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//--- street_light.dae MATERIALS BEGIN ---
singleton Material(street_light_material)
{
	mapTo = "street_light";

	diffuseMap[0] = "street_light_d.dds";
	normalMap[0] = "street_light_n.dds";
	specularMap[0] = "street_light_s.dds";

	diffuseColor[0] = "0.7 0.7 0.7 0";
	specular[0] = "1 1 1 0";
	specularPower[0] = 50;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   pixelSpecular[0] = "0";
   constantCubemapGloss = "0.2";
   materialTag0 = "RoadAndPath";
};

//--- street_light.dae MATERIALS END ---




singleton Material(streetLightLOD)
{
   mapTo = "Street_LightLOD";
   diffuseMap[0] = "street_light_d.dds";
   translucentBlendOp = "None";
};

singleton Material(street_light_lod)
{
   mapTo = "street_light_lod";
   diffuseMap[0] = "street_light_d";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};
