
singleton TSShapeConstructor(FP_DispositionDAE)
{
   baseShape = "./FP_Disposition.DAE";
   loadLights = "0";
   lodType = "TrailingNumber";
};

function FP_DispositionDAE::onLoad(%this)
{
   %this.renameSequence("ambient", "timeline");
   %this.setSequenceCyclic("timeline", "0");
   %this.addSequence("timeline", "fire_alt", "280", "293", "1", "0");
   %this.setSequenceCyclic("fire_alt", "0");
   %this.addSequence("timeline", "Run", "150", "179", "1", "0");
   %this.setSequenceCyclic("Run", "1");
   %this.addSequence("timeline", "sprint", "210", "229", "1", "0");
   %this.setSequenceCyclic("sprint", "1");
   %this.addSequence("timeline", "idle", "70", "129", "1", "0");
   %this.setSequenceCyclic("idle", "1");
   %this.addSequence("timeline", "idle_fidget1", "294", "310", "1", "0");
   %this.setSequenceCyclic("idle_fidget1", "0");
   %this.addSequence("timeline", "reload", "350", "440", "1", "0");
   %this.setSequenceCyclic("reload", "0");
   %this.addSequence("timeline", "switch_out", "470", "480", "1", "0");
   %this.setSequenceCyclic("switch_out", "0");
   %this.addSequence("timeline", "switch_in", "10", "40", "1", "0");
   %this.setSequenceCyclic("switch_in", "0");
   %this.addSequence("timeline", "fire_cocking", "294", "310", "1", "0");
   %this.setSequenceCyclic("fire_cocking", "0");
   %this.addSequence("timeline", "fire", "280", "293", "1", "0");
   %this.setSequenceCyclic("fire", "0");
}
