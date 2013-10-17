
singleton TSShapeConstructor(TP_LurkerDAE)
{
   baseShape = "./TP_Lurker.DAE";
   forceUpdateMaterials = "0";
   loadLights = "0";
   lodType = "TrailingNumber";
};

function TP_LurkerDAE::onLoad(%this)
{
   %this.renameSequence("ambient", "timeline");
   %this.setSequenceCyclic("timeline", "0");
   %this.addSequence("timeline", "root", "0", "0", "1", "0");
   %this.addSequence("timeline", "fire", "0", "1", "1", "0");
   %this.addSequence("timeline", "fire_vis", "9", "18", "1", "0");
}
