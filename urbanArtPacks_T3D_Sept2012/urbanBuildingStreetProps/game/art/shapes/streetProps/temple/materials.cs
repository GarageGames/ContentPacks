//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------




singleton Material(temple_material)
{
	mapTo = "temple";

	diffuseMap[0] = "temple_d.dds";
	normalMap[0] = "temple_n.dds";
	specularMap[0] = "temple_s.dds";

	diffuseColor[0] = "1 1 1 0";
	specular[0] = "1 1 1 0";
	specularPower[0] = 24;
	pixelSpecular[0] = 1;
	emissive[0] = 0;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
};



singleton Material(borders_material)
{
	mapTo = "borders";

	diffuseMap[0] = "borders_d.dds";
	normalMap[0] = "borders_n.dds";
	specularMap[0] = "borders_s.dds";

	diffuseColor[0] = "1 1 1 0";
	specular[0] = "0 0 0 0";
	specularPower[0] = 29;
	pixelSpecular[0] = 1;
	emissive[0] = 0;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   alphaTest = "1";
};


