//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------


//--- Police Light MATERIALS BEGIN ---
singleton Material(car_police_lights)
{
	mapTo = "car_police_lights";

	diffuseMap[0] = "lights_diff.dds";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "0.992157 0.992157 0.992157 0";
	specular[0] = "1 1 1 1";
	specularPower[0] = 50;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   glow[0] = "1";
   diffuseMap[1] = "police_lights/lights_diff.dds";
   pixelSpecular[0] = "0";
   glow[1] = "1";
   diffuseColor[1] = "0.509804 0.509804 0.509804 1";
   emissive[0] = "0";
   emissive[1] = "0";
   diffuseMap[2] = "";
   glow[2] = "0";
   diffuseColor[2] = "0.992157 0.992157 0.992157 0";
   emissive[2] = "0";
   animFlags[2] = "0x00000000";
   scrollDir[2] = "0.241 0";
   rotSpeed[2] = "1.294";
   rotPivotOffset[2] = "-1 -1";
   sequenceSegmentSize[2] = "2";
   animFlags[3] = "0x00000001";
   scrollSpeed[3] = "1.412";
   sequenceFramePerSec[2] = "1";
   animFlags[1] = "0x00000000";
   sequenceFramePerSec[1] = "1";
   sequenceSegmentSize[1] = "2";
   animFlags[0] = "0x00000000";
   sequenceFramePerSec[0] = "10.31";
   sequenceSegmentSize[0] = "0";
};

//--- Police Light MATERIALS END ---


singleton Material(policelights_Material__101)
{
   mapTo = "Material__101";
   diffuseMap[0] = "art/shapes/props/Car/police_lights/lights_diff";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};
