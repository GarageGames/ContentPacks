
singleton TSShapeConstructor(Cheetah_WheelBackRightDae)
{
   baseShape = "./Cheetah_WheelBackLeft.dae";
   lodType = "TrailingNumber";
   neverImport = "null	EnvironmentAmbientLight";
   matNamePrefix = "";
   forceUpdateMaterials = "0";
   loadLights = "0";
};

function WheelBackDae::onLoad(%this)
{
   %this.removeNode("EnvironmentAmbientLight");
   %this.removeNode("TireBack_LOD2");
   %this.removeNode("TireBack_LOD300");
   %this.removeNode("TireBack_LOD200");
   %this.removeNode("TireBack_LOD100");
   %this.removeNode("collision-1");
}
