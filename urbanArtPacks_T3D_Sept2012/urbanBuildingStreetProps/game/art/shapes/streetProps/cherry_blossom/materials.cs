//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//--- cherryBlossomTree_001.dae MATERIALS BEGIN ---



singleton Material(cherry_branches_material)
{
	mapTo = "cherry_branches";

	diffuseMap[0] = "cherry_blossom_d.dds";
	normalMap[0] = "cherry_blossom_n.dds";
	

	diffuseColor[0] = "0.74902 0.647059 0.772549 1";
	specular[0] = "0.541176 0.537255 0.537255 1";
	specularPower[0] = 99;

	doubleSided = 1;
	translucent = false;
	translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "208";
 //  toneMap[0] = "art/shapes/props/MainSquareProps/leavesDiffLight.dds";
   emissive[0] = "0";
   materialTag0 = "RoadAndPath";
   pixelSpecular[0] = "0";
   parallaxScale[0] = "0";
   constantCubemapGloss = "0.2";
   planarReflection = "0";
   dynamicCubemap = "0";
   glow[0] = "0";
};

singleton Material(cherry_branches_lod_material)
{
	mapTo = "cherry_branches_lod";

	diffuseMap[0] = "cherry_blossom_d.dds";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 0";
	specular[0] = "1 1 1 0";
	specularPower[0] = 50;

	doubleSided = 1;
	translucent = false;
	translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "221";
};



singleton Material(cherry_trunk_material)
{
   mapTo = "cherry_trunk";
   diffuseColor[0] = "0.454902 0.454902 0.454902 1";
   diffuseMap[0] = "cherry_trunk_d.dds";
   normalMap[0] = "cherry_trunk_n.dds";
   specular[0] = "1 1 1 1";
   specularPower[0] = "8";
   pixelSpecular[0] = "0";
   specularMap[0] = "";
   doubleSided = "0";
   translucent = "0";
   translucentBlendOp = "None";
   translucentZWrite = "0";
   alphaTest = "0";
   alphaRef = "1";
   materialTag0 = "RoadAndPath";
};

singleton Material(cherry_trunk_LOD_material)
{
   mapTo = "cherry_trunk_lod";
   diffuseMap[0] = "cherry_trunk_d.dds";
};

