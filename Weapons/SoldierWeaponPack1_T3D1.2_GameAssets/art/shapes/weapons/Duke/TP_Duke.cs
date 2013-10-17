
singleton TSShapeConstructor(TP_DukeDAE)
{
   baseShape = "./TP_Duke.dae";
   loadLights = "0";
   unit = "1.0";
   upAxis = "DEFAULT";
   lodType = "TrailingNumber";
   ignoreNodeScale = "0";
   adjustCenter = "0";
   adjustFloor = "0";
   forceUpdateMaterials = "0";
};

function TP_DukeDAE::onLoad(%this)
{
   %this.renameSequence("ambient", "timeline");
   %this.setSequenceCyclic("timeline", "0");
   %this.addSequence("timeline", "root", "0", "0", "1", "0");
   %this.setSequenceCyclic("root", "1");
   %this.addSequence("timeline", "fire", "0", "0", "1", "0");
   %this.setSequenceCyclic("fire", "0");
   %this.addSequence("timeline", "fire_vis", "9", "19", "1", "0");
   %this.setSequenceCyclic("fire_vis", "0");
}
