
singleton Material(Mat_Soldier_Main)
{
   mapTo = "Soldier_Main";

   diffuseMap[0] = "Soldier_Dif.dds";
   normalMap[0] = "Soldier_N.dds";
   specularMap[0] = "Soldier_Spec.dds";

   diffuseColor[0] = "1 1 1 1";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = 10;

   doubleSided = false;
   translucent = false;
   showFootprints = "0";
};

singleton Material(Mat_Soldier_Dazzle)
{
   mapTo = "Soldier_Dazzle";

   diffuseMap[0] = "Soldier_Dazzle.dds";

   diffuseColor[0] = "1 1 1 1";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = 10;

   doubleSided = false;
   translucent = "1";
   translucentBlendOp = "Add";
   glow[0] = "1";
   emissive[0] = "1";
   castShadows = "0";
   showFootprints = "0";
};
