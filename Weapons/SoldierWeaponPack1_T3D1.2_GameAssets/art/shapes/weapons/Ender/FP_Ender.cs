
singleton TSShapeConstructor(FP_EnderDAE)
{
   baseShape = "./FP_Ender.DAE";
   lodType = "TrailingNumber";
   loadLights = "0";
};

function FP_EnderDAE::onLoad(%this)
{
   %this.renameSequence("ambient", "timeline");
   %this.setSequenceCyclic("timeline", "0");
   %this.addSequence("timeline", "Root", "10", "11", "1", "0");
   %this.setSequenceCyclic("Root", "1");
   %this.addSequence("timeline", "fire", "255", "269", "1", "0");
   %this.setSequenceCyclic("fire", "0");
   %this.addSequence("timeline", "fire_alt", "255", "269", "1", "0");
   %this.setSequenceCyclic("fire_alt", "0");
   %this.addSequence("timeline", "idle", "105", "224", "1", "0");
   %this.setSequenceCyclic("idle", "1");
   %this.addSequence("timeline", "reload", "295", "393", "1", "0");
   %this.setSequenceCyclic("reload", "0");
   %this.addSequence("timeline", "Run", "423", "452", "1", "0");
   %this.setSequenceCyclic("Run", "1");
   %this.addSequence("timeline", "run2sprint", "483", "498", "1", "0");
   %this.setSequenceCyclic("run2sprint", "0");
   %this.addSequence("timeline", "sprint", "543", "562", "1", "0");
   %this.setSequenceCyclic("sprint", "1");
   %this.addSequence("timeline", "sprint2run", "593", "608", "1", "0");
   %this.setSequenceCyclic("sprint2run", "0");
   %this.addSequence("timeline", "switch_in", "25", "85", "1", "0");
   %this.setSequenceCyclic("switch_in", "0");
   %this.addSequence("timeline", "switch_out", "638", "653", "1", "0");
   %this.setSequenceCyclic("switch_out", "0");
   %this.addSequence("timeline", "idle_fidget1", "105", "224", "1", "0");
   %this.setSequenceCyclic("idle_fidget1", "1");
}
