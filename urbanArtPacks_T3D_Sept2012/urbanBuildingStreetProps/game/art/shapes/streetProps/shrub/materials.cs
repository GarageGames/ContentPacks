//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------


singleton Material(shrub_material)
{
	mapTo = "shrub";

	diffuseMap[0] = "shrub_d.dds";
	normalMap[0] = "shrub_n.dds";
	specularMap[0] = "shrub_s.dds";

	diffuseColor[0] = "0.196078 0.192157 0.133333 1";
	specular[0] = "1 1 1 1";
	specularPower[0] = 8;

	doubleSided = 0;
	translucent = false;
	translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "80";
};

