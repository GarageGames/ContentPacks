//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------



//--- Van_Delivery MATERIALS BEGIN ---
singleton Material(van_delivery_material)
{
	mapTo = "van_delivery";

	diffuseMap[0] = "van_delivery_diff.dds";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 0";
	specular[0] = "0.2 0.2 0.2 1";
	specularPower[0] = 50;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
    cubemap = "refDaySkyCubemap";
};

singleton Material(van_delivery_lod_material)
{
   mapTo = "van_delivery_lod";
	diffuseMap[0] = "van_delivery_diff.dds";
   materialTag0 = "RoadAndPath";
   constantCubemapGloss = "0.2";
};

//--- Van_Delivery MATERIALS END ---


//--- Van_Motorepair MATERIALS BEGIN ---
singleton Material(van_motorepair_material)
{
   mapTo = "van_motorepair";
   diffuseMap[0] = "van_motorepair_diff.dds";
   normalMap[0] = "van_norm.dds";
   specularMap[0] = "van_spec.dds";
   
   	diffuseColor[0] = "1 1 1 0";
	specular[0] = "0.2 0.2 0.2 1";
	specularPower[0] = 50;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
	cubemap = "refDaySkyCubemap";
	useAnisotropic[0] = true;
};

singleton Material(van_motorepair_lod_material)
{
   mapTo = "van_motorepair_lod";
   diffuseMap[0] = "van_motorepair_diff.dds";
   materialTag0 = "RoadAndPath";
   constantCubemapGloss = "0.2";
};


//--- Van_Motorepair MATERIALS END ---



//--- Van_Pharma MATERIALS BEGIN ---
singleton Material(van_pharma_material)
{
	mapTo = "van_pharma";

	diffuseMap[0] = "van_pharma_diff.dds";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 0";
	specular[0] = "0.2 0.2 0.2 1";
	specularPower[0] = 50;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
	cubemap = "refDaySkyCubemap";
};
singleton Material(van_pharma_lod_material)
{
   mapTo = "van_pharma_lod";
	diffuseMap[0] = "van_pharma_diff.dds";
   materialTag0 = "RoadAndPath";
   constantCubemapGloss = "0.2";
};

//--- Van_Pharma MATERIALS END ---



//--- Van_Police MATERIALS BEGIN ---
singleton Material(van_police_material)
{
	mapTo = "van_police";

	diffuseMap[0] = "van_police_diff";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "0.5 0.5 0.5 0";
	specular[0] = "1 1 1 1";
	specularPower[0] = 8;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
};

singleton Material(van_police_lod_material)
{
   mapTo = "van_police_lod";
	diffuseMap[0] = "van_police_diff";
   materialTag0 = "RoadAndPath";
   constantCubemapGloss = "0.2";
};

//--- Van_Police MATERIALS END ---


singleton Material(van_windows_material)
{
   mapTo = "van_windows";
   specular[0] = "0.368627 0.368627 0.368627 0";
   specularPower[0] = "50";
   translucentBlendOp = "LerpAlpha";
   materialTag0 = "RoadAndPath";
   constantCubemapGloss = "0.2";
	diffuseMap[0] = "van_delivery_diff.dds";
   specularMap[0] = "van_spec.dds";
   translucent = "1";
   cubemap = "CTDaySkyCubemap";
};
