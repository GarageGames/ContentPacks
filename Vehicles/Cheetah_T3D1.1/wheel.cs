
singleton TSShapeConstructor(WheelDae)
{
   baseShape = "./wheel.dae";
   lodType = "TrailingNumber";
   neverImport = "null	EnvironmentAmbientLight";
   matNamePrefix = "";
   forceUpdateMaterials = "0";
   loadLights = "0";
};

function WheelDae::onLoad(%this)
{
   %this.removeNode("EnvironmentAmbientLight");
   %this.removeNode("Tread_LOD100");
   %this.removeNode("Tread_LOD2");
   %this.removeNode("Tread_LOD300");
   %this.removeNode("Tread_LOD200");
   %this.removeNode("collision-1");
}
