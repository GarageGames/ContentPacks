
singleton TSShapeConstructor(Cheetah_WheelFrontRightDae)
{
   baseShape = "./Cheetah_WheelFrontLeft.dae";
   lodType = "TrailingNumber";
   neverImport = "null	EnvironmentAmbientLight";
   matNamePrefix = "";
   forceUpdateMaterials = "0";
   loadLights = "0";
};

function WheelFrontDae::onLoad(%this)
{
   %this.removeNode("EnvironmentAmbientLight");
   %this.removeNode("TireBack_LOD2");
   %this.removeNode("TireBack_LOD300");
   %this.removeNode("TireBack_LOD200");
   %this.removeNode("TireBack_LOD100");
   %this.removeNode("collision-1");
}
