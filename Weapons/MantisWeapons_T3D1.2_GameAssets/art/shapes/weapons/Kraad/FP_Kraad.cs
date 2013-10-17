
singleton TSShapeConstructor(FP_KraadDAE)
{
   baseShape = "./FP_Kraad.DAE";
   neverImport = "null*";
   loadLights = "0";
   lodType = "TrailingNumber";
};

function FP_KraadDAE::onLoad(%this)
{
   %this.renameSequence("ambient", "timeline");
   %this.addSequence("timeline", "Run", "10", "40", "1", "0");
   %this.addSequence("timeline", "run2sprint", "60", "70", "1", "0");
   %this.setSequenceCyclic("run2sprint", "0");
   %this.addSequence("timeline", "sprint", "70", "90", "1", "0");
   %this.addSequence("timeline", "sprint2run", "90", "100", "1", "0");
   %this.setSequenceCyclic("sprint2run", "0");
   %this.addSequence("timeline", "idle", "120", "180", "1", "0");
   %this.addSequence("timeline", "idle_fidget1", "210", "360", "1", "0");
   %this.setSequenceCyclic("idle_fidget1", "0");
   %this.addSequence("timeline", "fire", "420", "425", "1", "0");
   %this.setSequenceCyclic("fire", "0");
   %this.addSequence("timeline", "reload", "460", "550", "1", "0");
   %this.setSequenceCyclic("reload", "0");
   %this.addSequence("timeline", "switch_in", "680", "690", "1", "0");
   %this.setSequenceCyclic("switch_in", "0");
   %this.addSequence("timeline", "switch_out", "660", "670", "1", "0");
   %this.setSequenceCyclic("switch_out", "0");
}
