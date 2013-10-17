
singleton TSShapeConstructor(FP_KralDAE)
{
   baseShape = "./FP_Kral.DAE";
   loadLights = "0";
   lodType = "TrailingNumber";
};

function FP_KralDAE::onLoad(%this)
{
   %this.renameSequence("ambient", "timeline");
   %this.addSequence("timeline", "switch_in", "10", "55", "1", "0");
   %this.setSequenceCyclic("switch_in", "0");
   %this.addSequence("timeline", "idle", "111", "170", "1", "0");
   %this.addSequence("timeline", "Run", "231", "260", "1", "0");
   %this.addSequence("timeline", "run2sprint", "281", "291", "1", "0");
   %this.setSequenceCyclic("run2sprint", "0");
   %this.addSequence("timeline", "sprint", "301", "320", "1", "0");
   %this.addSequence("timeline", "sprint2run", "341", "351", "1", "0");
   %this.setSequenceCyclic("sprint2run", "0");
   %this.addSequence("timeline", "fire", "411", "421", "1", "0");
   %this.setSequenceCyclic("fire", "0");
   %this.addSequence("timeline", "reload", "451", "524", "1", "0");
   %this.setSequenceCyclic("reload", "0");
   %this.addSequence("timeline", "switch_out", "551", "566", "1", "0");
   %this.setSequenceCyclic("switch_out", "0");
}
