//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------





singleton Material(pavement_tree_material)
{
	mapTo = "pavement_tree";

	diffuseMap[0] = "pavement_tree_d.dds";
	normalMap[0] = "pavement_tree_n.dds";
	specularMap[0] = "pavement_tree_s.dds";
	diffuseColor[0] = "0.364706 0.364706 0.364706 1";
	specular[0] = "0.568627 0.780392 0.560784 1";
	specularPower[0] = 56;

	doubleSided = 1;
	translucent = 0;
	translucentBlendOp = "None";
   pixelSpecular[0] = "0";
   alphaTest = "1";
   alphaRef = "100";
   materialTag0 = "RoadAndPath";
   constantCubemapGloss = "0.2";
};
singleton Material(pavement_tree_lod_material)
{
	mapTo = "pavement_tree_lod";

	diffuseMap[0] = "pavement_tree_d.dds";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "0.337255 0.337255 0.337255 1";
	specular[0] = "0 0 0 1";
	specularPower[0] = 50;

	doubleSided = 1;
	translucent = false;
	translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "67";
   castShadows = "0";
   materialTag0 = "RoadAndPath";
};
