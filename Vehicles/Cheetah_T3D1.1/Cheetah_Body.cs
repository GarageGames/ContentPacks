
singleton TSShapeConstructor(CheetahDAE)
{
   baseShape = "./Cheetah_Body.DAE";
   loadLights = "0";
   lodType = "TrailingNumber";
   neverImport = "null  EnvironmentAmbientLight";
   matNamePrefix = "";
   forceUpdateMaterials = "0";
   loadLights = "0";
};

function CheetahDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "0");
   %this.addSequence("ambient", "root", "0", "1");
   %this.addSequence("ambient", "spring0", "10", "11");
   %this.addSequence("ambient", "spring1", "20", "21");
   %this.addSequence("ambient", "spring2", "30", "31");
   %this.addSequence("ambient", "spring3", "40", "41");
   %this.addSequence("ambient", "brakeLight", "50", "51");
   %this.removeSequence("ambient");
   %this.setNodeTransform("cam", "5.46934e-008 -4.75632 2.89171 -0.404897 0.817636 0.409303 1.71107", "1");
   %this.removeNode("EnvironmentAmbientLight");
   %this.removeNode("CheetahMesh300");
   %this.removeNode("CheetahMesh200");
   %this.removeNode("CheetahMesh100");
   %this.removeNode("CheetahMesh2");
   %this.removeNode("TailLightsMesh300");
   %this.removeNode("TailLightsMesh200");
   %this.removeNode("TailLightsMesh100");
   %this.removeNode("TailLightsMesh2");
   %this.removeNode("collision-1");
   %this.removeNode("collision-5");
   %this.removeNode("collision-4");
   %this.removeNode("collision-3");
   %this.removeNode("collision-2");
   %this.removeNode("nulldetail1");
}
