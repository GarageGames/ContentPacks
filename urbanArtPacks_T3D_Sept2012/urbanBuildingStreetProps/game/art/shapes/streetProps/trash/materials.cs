//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//--- trash.dae MATERIALS BEGIN ---
singleton Material(trash_trash)
{
	mapTo = "trash";

	diffuseMap[0] = "trash_d.dds";
	normalMap[0] = "trash_n.dds";
	specularMap[0] = "trash_s.dds";

	diffuseColor[0] = "1 1 1 0";
	specular[0] = "1 1 1 0";
	specularPower[0] = 1;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   alphaTest = "1";
   alphaRef = "161";
};

//--- trash.dae MATERIALS END ---
