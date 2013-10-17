
singleton TSShapeConstructor(TP_MambaDAE)
{
   baseShape = "./TP_Mamba.DAE";
   forceUpdateMaterials = "0";
   loadLights = "0";
   neverImport = "EnvironmentAmbientLight";
   lodType = "TrailingNumber";
};

function TP_MambaDAE::onLoad(%this)
{
   %this.setMeshSize("Rifle2_LOD300 2", "300");
   %this.setMeshSize("Rifle2_LOD200 2", "200");
   %this.setMeshSize("Rifle2_LOD100 2", "100");
   %this.setMeshSize("MuzzleFlash_LOD300 2", "300");
   %this.setMeshSize("MuzzleFlash_LOD200 2", "200");
   %this.setMeshSize("MuzzleFlash_LOD100 2", "100");

   %this.renameSequence("ambient", "timeline");
   %this.addSequence("timeline", "root", "0", "0");
   %this.addSequence("timeline", "fire", "0", "0");
   %this.setSequenceCyclic("fire", "0");
   %this.addSequence("timeline", "fire_vis", "09", "19");
   %this.setSequenceCyclic("fire_vis", "0");
}
