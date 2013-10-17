
singleton TSShapeConstructor(TP_DispositionDAE)
{
   baseShape = "./TP_Disposition.DAE";
   matNamePrefix = "";
   forceUpdateMaterials = "0";
   loadLights = "0";
   neverImport = "EnvironmentAmbientLight";
};

function TP_DispositionDAE::onLoad(%this)
{
   %this.renameSequence("ambient", "timeline");
   %this.setSequenceCyclic("timeline", "0");
   %this.addSequence("timeline", "root", "0", "0");
   %this.addSequence("timeline", "fire", "9", "19");
   //%this.addSequence("timeline", "fire_vis", "9", "19");
   
   %this.setMeshSize("Shotgun_LOD300 2", "300");
   %this.setMeshSize("MuzzleFlash_LOD300 2", "300");
   %this.setMeshSize("Shotgun_LOD200 2", "200");
   %this.setMeshSize("MuzzleFlash_LOD200 2", "200");
   %this.setMeshSize("Shotgun_LOD100 2", "100");
   %this.setMeshSize("MuzzleFlash_LOD100 2", "100");
}
