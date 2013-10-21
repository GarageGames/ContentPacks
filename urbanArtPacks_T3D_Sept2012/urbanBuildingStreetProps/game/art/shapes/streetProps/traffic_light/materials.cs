//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//--- Traffic_light.dae MATERIALS BEGIN ---
singleton Material(traffic_light_material)
{
	mapTo = "traffic_light";

	diffuseMap[0] = "traffic_light_d.dds";
	normalMap[0] = "traffic_light_n.dds";
	specularMap[0] = "traffic_light_s.dds";

	diffuseColor[0] = "0.545098 0.545098 0.545098 1";
	specular[0] = "1 1 1 0";
	specularPower[0] = 50;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   pixelSpecular[0] = "0";
   constantCubemapGloss = "0.2";
   materialTag0 = "RoadAndPath";
};

singleton Material(traffic_light_lod_material)
{
	mapTo = "traffic_light_lod";

	diffuseMap[0] = "";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 0";
	specular[0] = "1 1 1 0";
	specularPower[0] = 50;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
};

//--- Traffic_light.dae MATERIALS END ---

//--- Traffic_light2.dae MATERIALS BEGIN ---
singleton Material(traffic_light_phong_material)
{
	mapTo = "traffic_light_phong";

	diffuseMap[0] = "traffic_light_walk_d.dds";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 0";
	specular[0] = "1 1 1 0";
	specularPower[0] = 50;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   emissive[0] = "1";
};

//--- Traffic_light2.dae MATERIALS END ---


singleton Material(traffic_light_light_material)
{
   mapTo = "traffic_light_light";
   diffuseMap[0] = "traffic_light_d.dds";
   specular[0] = "1 1 1 0";
   specularPower[0] = "50";
   translucentBlendOp = "None";
};
//--- Traffic_walk.dae MATERIALS BEGIN ---
singleton Material(traffic_light_walk_material)
{
	mapTo = "traffic_light_walk";

	diffuseMap[0] = "traffic_light_walk_d.dds";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "0.996078 0.996078 0.996078 0";
	specular[0] = "1 1 1 1";
	specularPower[0] = 8;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   emissive[0] = "1";
   constantCubemapGloss = "0.2";
   materialTag0 = "RoadAndPath";
   glow[0] = "1";
   animFlags[0] = "0x00000010";
   sequenceFramePerSec[0] = "1";
   sequenceSegmentSize[0] = "0.5";
};

//--- Traffic_walk.dae MATERIALS END ---

//--- Traffic_light_amber.dae MATERIALS BEGIN ---
singleton Material(traffic_light_amber_material)
{
	mapTo = "traffic_light_amber";

	diffuseMap[0] = "traffic_light_amber_d.dds";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "1 1 1 1";
	specularPower[0] = 8;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   glow[0] = "0";
   emissive[0] = "0";
   animFlags[0] = "0x00000000";
   sequenceFramePerSec[0] = "0";
   sequenceSegmentSize[0] = "0";
   materialTag0 = "RoadAndPath";
};

//--- Traffic_light_amber.dae MATERIALS END ---


singleton Material(traffic_light_ColorEffectR214G229B166_material)
{
   mapTo = "ColorEffectR214G229B166-material";
   diffuseColor[0] = "0.839216 0.898039 0.65098 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};
