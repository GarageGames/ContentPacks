
singleton TSShapeConstructor(FP_KralmokDAE)
{
   baseShape = "./FP_Kralmok.DAE";
   loadLights = "0";
   lodType = "TrailingNumber";
};

function FP_KralmokDAE::onLoad(%this)
{
   %this.renameSequence("ambient", "timeline");
   %this.addSequence("timeline", "idle", "105", "225", "1", "0");
   %this.addSequence("timeline", "fire", "255", "269", "1", "0");
   %this.setSequenceCyclic("fire", "0");
   %this.addSequence("timeline", "Fire2Idle", "270", "279", "1", "0");
   %this.setSequenceCyclic("Fire2Idle", "0");
   %this.addSequence("timeline", "Idle2Reload", "281", "291", "1", "0");
   %this.setSequenceCyclic("Idle2Reload", "0");
   %this.addSequence("timeline", "reload", "295", "393", "1", "0");
   %this.setSequenceCyclic("reload", "0");
   %this.addSequence("timeline", "Run", "423", "453", "1", "0");
   %this.addSequence("timeline", "run2sprint", "483", "498", "1", "0");
   %this.setSequenceCyclic("run2sprint", "0");
   %this.addSequence("timeline", "sprint", "543", "563", "1", "0");
   %this.addSequence("timeline", "sprint2run", "593", "608", "1", "0");
   %this.setSequenceCyclic("sprint2run", "0");
   %this.addSequence("timeline", "switch_out", "638", "653", "1", "0");
   %this.setSequenceCyclic("switch_out", "0");
   %this.addSequence("timeline", "switch_in", "25", "85", "1", "0");
   %this.setSequenceCyclic("switch_in", "0");
}
