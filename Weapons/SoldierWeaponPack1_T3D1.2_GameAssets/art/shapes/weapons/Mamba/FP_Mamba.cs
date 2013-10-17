
singleton TSShapeConstructor(FP_MambaDAE)
{
   baseShape = "./FP_Mamba.DAE";
   loadLights = "0";
   lodType = "TrailingNumber";
};


function FP_MambaDAE::onLoad(%this)
{
   %this.renameSequence("ambient", "timeline");
   %this.setSequenceCyclic("timeline", "0");
   %this.addSequence("timeline", "Run", "20", "49", "1", "0");
   %this.setSequenceCyclic("Run", "1");
   %this.addSequence("timeline", "sprint", "110", "129", "1", "0");
   %this.setSequenceCyclic("sprint", "1");
   %this.addSequence("timeline", "idle", "210", "269", "1", "0");
   %this.setSequenceCyclic("idle", "1");
   %this.addSequence("timeline", "idle_fidget1", "310", "459", "1", "0");
   %this.setSequenceCyclic("idle_fidget1", "1");
   %this.addSequence("timeline", "fire", "520", "525", "1", "0");
   %this.setSequenceCyclic("fire", "0");
   %this.addSequence("timeline", "reload", "560", "650", "1", "0");
   %this.setSequenceCyclic("reload", "0");
   %this.addSequence("timeline", "switch_out", "760", "770", "1", "0");
   %this.setSequenceCyclic("switch_out", "0");
   %this.addSequence("timeline", "switch_in", "780", "790", "1", "0");
   %this.setSequenceCyclic("switch_in", "0");

}
