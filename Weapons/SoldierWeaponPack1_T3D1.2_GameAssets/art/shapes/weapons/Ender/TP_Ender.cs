
singleton TSShapeConstructor(TP_EnderDAE)
{
   baseShape = "./TP_Ender.DAE";
   matNamePrefix = "";
   lodType = "TrailingNumber";
   forceUpdateMaterials = "0";
   loadLights = "0";
   neverImport = "EnvironmentAmbientLight";
   unit = "1.0";
};

function TP_EnderDAE::onLoad(%this)
{
   %this.renameSequence("ambient", "timeline");
   %this.setSequenceCyclic("timeline", "0");
   %this.addSequence("timeline", "root", "0", "0");
   %this.addSequence("timeline", "fire", "0", "0");
   %this.addSequence("timeline", "fire_vis", "9", "18");
}
